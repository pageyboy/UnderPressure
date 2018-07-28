Imports System
Imports System.IO.Ports
Imports System.Threading
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.IO
Imports System.Timers

Public Class frmMain

    Inherits Form

    Dim mTime As Long
    Dim startTime As DateTime

    Dim recentDT() As Single
    Dim recentTF() As Single
    Dim recentDiff() As Single

    Dim currentReading As Integer = 0
    Dim totalReadings As Integer = 0

    Dim dtSetpoint As Single
    Dim tfSetpoint As Single
    Dim dtRSDSetpoint As Single
    Dim tfRSDSetpoint As Single

    Dim theThread As System.Threading.Thread
    Dim selectedPort As IO.Ports.SerialPort = Nothing
    Dim _continue As Boolean = False
    Dim serialPort As String

    Dim testMode As Boolean

    Sub updateData(driftTube As Single, trapFunnel As Single)

        'If continue = false then prevent the UpdateData sub running otherwise there is a lag from the _continue flag being set to false and the reading thread being terminated
        If _continue = False Then
            Exit Sub
        End If

        'Determine the number of data points set by the user
        Dim numDataPoints = num_DataPoints.Value

        'Calculate differential and set label boxes as formatted value
        Dim differential As Single = driftTube - trapFunnel
        lbl_DTPressure.Text = Format(driftTube, "0.0000")
        lbl_TFPressure.Text = Format(trapFunnel, "0.0000")
        lbl_DeltaPressure.Text = Format(differential, "0.0000")

        ' Add data into DGV
        mTime = (DateTime.UtcNow - startTime).TotalMilliseconds
        dgv_Data.Rows.Add(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"), mTime, totalReadings + 1, Format(driftTube, "0.0000"), Format(trapFunnel, "0.0000"), Format(differential, "0.0000"))
        dgv_Data.AutoResizeColumns()
        dgv_Data.FirstDisplayedScrollingRowIndex = dgv_Data.RowCount - 1

        ' Add the data into the arrays which have been sized depending on the number of data points the user is interested in
        recentDT(currentReading) = driftTube
        recentTF(currentReading) = trapFunnel
        recentDiff(currentReading) = differential

        ' If the total number of readings that the user has requested are used for statistics have been reached then the statistics can be calculated and the labels to display these can be made visible.
        If totalReadings >= numDataPoints - 1 Then
            lbl_RangeDiff.Visible = True
            lbl_RangeDT.Visible = True
            lbl_RangeTF.Visible = True
            lbl_PlusMinus.Text = "Torr ±"
            lbl_mTorr.Visible = True

            lbl_Delta_RSD.Visible = True
            lbl_DT_RSD.Visible = True
            lbl_TF_RSD.Visible = True

            lbl_PercentSign.Visible = True
        End If

        totalReadings += 1

        ' _doNotContinueUpdate flag is used as 
        Dim _doNotContinueUpdate As Boolean
        Dim zeroDT As Integer = Array.FindIndex(recentDT, Function(val) val = 0)

        If zeroDT > 0 Then
            _doNotContinueUpdate = True
        End If

        If totalReadings >= numDataPoints - 1 And _doNotContinueUpdate = False Then

            lbl_DT_RSD.Text = Format(calcRSD(recentDT), "0.00")
            lbl_TF_RSD.Text = Format(calcRSD(recentTF), "0.00")
            lbl_Delta_RSD.Text = Format(calcRSD(recentDiff), "0.00")

            lbl_RangeDT.Text = Format(calcStandardDeviation(recentDT) * 1000, "0.0")
            lbl_RangeTF.Text = Format(calcStandardDeviation(recentTF) * 1000, "0.0")
            lbl_RangeDiff.Text = Format(calcStandardDeviation(recentDiff) * 1000, "0.0")

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

        If _continue = False And comboBox_SerialPorts.Text <> "" Then
            ReDim recentDT(num_DataPoints.Value - 1)
            ReDim recentTF(num_DataPoints.Value - 1)
            ReDim recentDiff(num_DataPoints.Value - 1)
            _continue = True
            currentReading = 0
            totalReadings = 0
            serialPort = comboBox_SerialPorts.Text
            theThread = New Threading.Thread(AddressOf readCOMData)
            theThread.Start()
            btn_Connection.Text = "Disconnect"
            num_DataPoints.Enabled = False
            lbl_DataPoints.Enabled = False
            comboBox_SerialPorts.Enabled = False
        Else
            Dim messageBoxAnswer As Integer
            messageBoxAnswer = MessageBox.Show(Me, "Are you sure you want to disconnect, if you reconnect then you will need to wait until there are enough data points to evaluate.", "Disconnect?", MessageBoxButtons.YesNo)
            If messageBoxAnswer = DialogResult.No Then
                Exit Sub
            End If
            _continue = False
            btn_Connection.Text = "Connect"
            num_DataPoints.Enabled = True
            lbl_DataPoints.Enabled = True
            comboBox_SerialPorts.Enabled = True
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
        startTime = DateTime.UtcNow
    End Sub

    Function calcStandardDeviation(ByVal ParamArray args() As Single) As Single
        Dim average As Single = args.Average()
        Dim squaredDifferences(args.Length - 1) As Single
        For i = 0 To args.Length - 1
            squaredDifferences(i) = (args(i) - average) ^ 2
        Next
        Dim averageSquaredDifferences As Single = squaredDifferences.Sum() / (squaredDifferences.Length - 1)
        Dim stdDev As Single = Math.Sqrt(averageSquaredDifferences)
        Return stdDev
    End Function

    Function calcRSD(ByVal ParamArray args() As Single) As Single
        Dim average As Single = args.Average()
        Dim sd As Single = calcStandardDeviation(args)
        Dim rsd As Single = (sd / average) * 100
        Return rsd
    End Function

    Private Sub txtBox_dtSetpoint_TextChanged(sender As Object, e As EventArgs) Handles txtBox_tfSetpoint.TextChanged, txtBox_dtSetpoint.TextChanged
        If txtBox_tfSetpoint.Text.Length > 0 And txtBox_dtSetpoint.Text.Length > 0 Then
            lbl_DiffSetpoint.Text = Format(Convert.ToSingle(txtBox_dtSetpoint.Text) - Convert.ToSingle(txtBox_tfSetpoint.Text), "0.0000")
        End If
    End Sub

    Private Sub txtBox_dtRSDSetpoint_TextChanged(sender As Object, e As EventArgs) Handles txtBox_dtRSDSetpoint.TextChanged
        If txtBox_dtRSDSetpoint.Text.Length > 0 Then
            'lbl_dtRSDSetpoint.Text = Format((((Convert.ToSingle(txtBox_dtRSDSetpoint.Text)) / 100) * Convert.ToSingle(txtBox_dtSetpoint.Text) * 1000), "0.00")
            'lbl_dtRSDSetpoint.Text = (Convert.ToSingle(txtBox_dtRSDSetpoint.Text) / 100) * (Convert.ToSingle(txtBox_dtSetpoint.Text))
        End If
    End Sub

    Dim num_DataPointsPrevValue = 25

    Private Sub num_DataPoints_ValueChanged(sender As Object, e As EventArgs) Handles num_DataPoints.ValueChanged 
        If num_DataPoints.Value > num_DataPointsPrevValue Then
            Select Case num_DataPointsPrevValue
                Case 25
                    num_DataPoints.Value = 750
                Case 750
                    num_DataPoints.Value = 1500
                Case Else
            End Select
        Else
            Select Case num_DataPointsPrevValue
                Case 1500
                    num_DataPoints.Value = 750
                Case 750
                    num_DataPoints.Value = 25
                Case Else
            End Select
        End If
        Select Case num_DataPoints.Value
            Case 25
                lbl_SecsConverter.Text = "Approx. 10 secs"
            Case 750
                lbl_SecsConverter.Text = "Approx. 5 mins"
            Case 1500
                lbl_SecsConverter.Text = "Approx. 10 mins"
            Case Else
        End Select

        num_DataPointsPrevValue = num_DataPoints.Value
    End Sub

End Class
