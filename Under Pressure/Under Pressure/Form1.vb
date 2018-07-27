﻿Imports System
Imports System.IO.Ports
Imports System.Threading
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.IO
Imports System.Timers

Public Class frmMain

    Inherits Form

    Dim recentDT() As Single
    Dim recentTF() As Single
    Dim recentDiff() As Single

    Dim currentReading As Integer = 0
    Dim totalReadings As Integer = 0

    Dim theThread As System.Threading.Thread
    Dim selectedPort As IO.Ports.SerialPort = Nothing
    Dim _continue As Boolean = False
    Dim serialPort As String

    Dim testMode As Boolean

    Sub updateData(driftTube As Single, trapFunnel As Single)

        If _continue = False Then
            Exit Sub
        End If

        Dim numDataPoints = num_DataPoints.Value
        Dim differential As Single = driftTube - trapFunnel
        lbl_DTPressure.Text = Format(driftTube, "0.0000")
        lbl_TFPressure.Text = Format(trapFunnel, "0.0000")
        lbl_DeltaPressure.Text = Format(differential, "0.0000")
        dgv_Data.Rows.Add()
        recentDT(currentReading) = driftTube
        recentTF(currentReading) = trapFunnel
        recentDiff(currentReading) = differential
        If totalReadings = numDataPoints - 1 Then
            lbl_RangeDiff.Visible = True
            lbl_RangeDT.Visible = True
            lbl_RangeTF.Visible = True
            lbl_PlusMinus.Text = "Torr ±"
            lbl_mTorr.Visible = True

            lbl_Delta_RSD.Visible = True
            lbl_DT_RSD.Visible = True
            lbl_TF_RSD.Visible = True

            lbl_PercentSign.Visible = True

        Else
            totalReadings += 1
        End If

        Dim _doNotContinueUpdate As Boolean

        For i = 0 To numDataPoints - 1
            If recentDT(i) = 0 Or recentTF(i) = 0 Or recentDiff(0) Then
                _doNotContinueUpdate = True
            End If
        Next

        If totalReadings >= numDataPoints - 1 And _doNotContinueUpdate = False Then

            lbl_DT_RSD.Text = Format(calcRSD(recentDT), "0.00")
            lbl_TF_RSD.Text = Format(calcRSD(recentTF), "0.00")
            lbl_Delta_RSD.Text = Format(calcRSD(recentDiff), "0.00")

            'IF USING RANGE AS THE STAT THEN THIS TO BE USED

            'lbl_RangeDT.Text = Format((recentDT.Max() - recentDT.Min()) * 500, "0")
            'lbl_RangeTF.Text = Format((recentTF.Max() - recentTF.Min()) * 500, "0")
            'lbl_RangeDiff.Text = Format((recentDiff.Max() - recentDiff.Min()) * 500, "0")

            'Select Case (recentDiff.Max() - recentDiff.Min()) * 500
            '    Case <= 5
            '        lbl_RangeDiff.ForeColor = Color.LightGreen
            '    Case <= 10
            '        lbl_RangeDiff.ForeColor = Color.Orange
            '    Case > 10
            '        lbl_RangeDiff.ForeColor = Color.Red
            'End Select

            'Select Case (recentDT.Max() - recentDT.Min()) * 500
            '    Case <= 5
            '        lbl_RangeDT.ForeColor = Color.LightGreen
            '    Case <= 10
            '        lbl_RangeDT.ForeColor = Color.Orange
            '    Case > 10
            '        lbl_RangeDT.ForeColor = Color.Red
            'End Select

            'Select Case (recentTF.Max() - recentTF.Min()) * 500
            '    Case <= 5
            '        lbl_RangeTF.ForeColor = Color.LightGreen
            '    Case <= 10
            '        lbl_RangeTF.ForeColor = Color.Orange
            '    Case > 10
            '        lbl_RangeTF.ForeColor = Color.Red
            'End Select

            'IF USING RSD AS THE STAT THEN THIS TO BE USED

            lbl_RangeDT.Text = Format(calcStandardDeviation(recentDT) * 1000, "0")
            lbl_RangeTF.Text = Format(calcStandardDeviation(recentTF) * 1000, "0")
            lbl_RangeDiff.Text = Format(calcStandardDeviation(recentDiff) * 1000, "0")

            Select Case (recentDiff.Max() - recentDiff.Min()) * 500
                Case <= 5
                    lbl_RangeDiff.ForeColor = Color.LightGreen
                Case <= 10
                    lbl_RangeDiff.ForeColor = Color.Orange
                Case > 10
                    lbl_RangeDiff.ForeColor = Color.Red
            End Select

            Select Case (recentDT.Max() - recentDT.Min()) * 500
                Case <= 5
                    lbl_RangeDT.ForeColor = Color.LightGreen
                Case <= 10
                    lbl_RangeDT.ForeColor = Color.Orange
                Case > 10
                    lbl_RangeDT.ForeColor = Color.Red
            End Select

            Select Case (recentTF.Max() - recentTF.Min()) * 500
                Case <= 5
                    lbl_RangeTF.ForeColor = Color.LightGreen
                Case <= 10
                    lbl_RangeTF.ForeColor = Color.Orange
                Case > 10
                    lbl_RangeTF.ForeColor = Color.Red
            End Select


        End If

        If currentReading = numDataPoints - 1 Then
            currentReading = 0
        Else
            currentReading += 1
        End If
    End Sub

    Public Sub readCOMData()

        Try
            selectedPort = My.Computer.Ports.OpenSerialPort(serialPort, 19200, Parity.None, 8, StopBits.One)
            selectedPort.ReadTimeout = 10000
            selectedPort.WriteLine("RCN")
                Do
                If _continue = True Then
                    Dim incoming As String = selectedPort.ReadLine()
                    If incoming Is Nothing Then
                        Exit Do
                    Else
                        Me.Invoke(Sub() parseData(incoming.ToString))
                    End If
                Else
                    selectedPort.Close()
                    Exit Sub
                End If
            Loop
        Catch ex As TimeoutException
            MessageBox.Show("Serial Port lost or not detected")
        End Try

    End Sub

    Private Sub btn_Connection_Click(sender As Object, e As EventArgs) Handles btn_Connection.Click

        ReDim recentDT(num_DataPoints.Value - 1)
        ReDim recentTF(num_DataPoints.Value - 1)
        ReDim recentDiff(num_DataPoints.Value - 1)

        If _continue = False And comboBox_SerialPorts.Text <> "" Then
            _continue = True
            currentReading = 0
            totalReadings = 0
            serialPort = comboBox_SerialPorts.Text
            theThread = New Threading.Thread(AddressOf readCOMData)
            theThread.Start()
            btn_Connection.Text = "Disconnect"
            num_DataPoints.Enabled = False
            lbl_DataPoints.Enabled = False
        Else
            _continue = False
            btn_Connection.Text = "Connect"
            num_DataPoints.Enabled = True
            lbl_DataPoints.Enabled = True
        End If

    End Sub

    Private Sub parseData(readLine As String)
        Dim parsedDT As Single
        Dim parsedTF As Single
        If readLine.IndexOf("1: ") > -1 And readLine.IndexOf("2: ") > -1 Then
            Dim temp As String = readLine.Substring(readLine.IndexOf("1: ") + 3, 6)
            parsedTF = Convert.ToSingle(temp)
            temp = readLine.Substring(readLine.IndexOf("2: ") + 3, 6)
            parsedDT = Convert.ToSingle(temp)
            updateData(parsedDT, parsedTF)
            txtBox_Hyperterminal.AppendText(readLine & vbCrLf)
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If _continue Then
            MessageBox.Show(Me, "Disconnect from the IMQTOF first!")
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comboBox_SerialPorts.Items.Add(sp)
        Next
        comboBox_SerialPorts.SelectedIndex = comboBox_SerialPorts.Items.Count - 1
    End Sub

    Function calcStandardDeviation(ByVal ParamArray args() As Single) As Single
        Dim average As Single = args.Average()
        Debug.Print("Values:")
        For i = 0 To args.Length - 1
            Debug.Print(args(i).ToString)
        Next
        Debug.Print("Squared Differences")
        Dim squaredDifferences(args.Length - 1) As Single
        For i = 0 To args.Length - 1
            squaredDifferences(i) = (args(i) - average) ^ 2
            Debug.Print(squaredDifferences(i).ToString)
        Next
        Debug.Print("Average - 1 Square Difference")
        Dim averageSquaredDifferences As Single = squaredDifferences.Sum() / (squaredDifferences.Length - 1)
        Debug.Print(averageSquaredDifferences)
        Debug.Print("Square root of Average Squared Differences")
        Dim stdDev As Single = Math.Sqrt(averageSquaredDifferences)
        Debug.Print(stdDev)
        Return stdDev
    End Function

    Function calcRSD(ByVal ParamArray args() As Single) As Single
        Dim average As Single = args.Average()
        Dim sd As Single = calcStandardDeviation(args)
        Dim rsd As Single = (sd / average) * 100
        Return rsd
    End Function

End Class
