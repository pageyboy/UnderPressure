Imports System
Imports System.IO.Ports
Imports System.Threading
Imports System.Windows.Forms
Imports System.ComponentModel


Public Class frmMain

    Inherits Form

    Dim recentDT(4) As Single
    Dim recentTF(4) As Single
    Dim recentDiff(4) As Single
    Dim currentReading As Integer = 0
    Dim totalReadings As Integer = 0

    Dim theThread As System.Threading.Thread
    Dim com7 As IO.Ports.SerialPort = Nothing
    Dim _continue As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Test_Click(sender As Object, e As EventArgs) Handles btn_Test.Click
        Dim r As Random = New Random
        Dim randomDT As Single = r.Next(39500, 41000) / 10000
        Dim randomTF As Single = r.Next(38000, 39500) / 10000
        updateData(randomDT, randomTF)
    End Sub

    Sub updateData(driftTube As Single, trapFunnel As Single)
        Dim differential As Single = driftTube - trapFunnel
        lbl_DTPressure.Text = Format(driftTube, "0.0000")
        lbl_TFPressure.Text = Format(trapFunnel, "0.0000")
        lbl_DeltaPressure.Text = Format(differential, "0.0000")
        recentDT(currentReading) = driftTube
        recentTF(currentReading) = trapFunnel
        recentDiff(currentReading) = differential
        If totalReadings = 4 Then
            lbl_RangeDiff.Visible = True
            lbl_RangeDT.Visible = True
            lbl_RangeTF.Visible = True
            lbl_PlusMinus.Text = "Torr ±"
            lbl_mTorr.Visible = True
        Else
            totalReadings += 1
        End If

        If totalReadings >= 4 Then
            lbl_RangeDT.Text = Format((recentDT.Max() - recentDT.Min()) * 500, "0")
            lbl_RangeTF.Text = Format((recentTF.Max() - recentTF.Min()) * 500, "0")
            lbl_RangeDiff.Text = Format((recentDiff.Max() - recentDiff.Min()) * 500, "0")
        End If

        If currentReading = 4 Then
            currentReading = 0
        Else
            currentReading += 1
        End If
    End Sub

    Public Sub TestMultiThreading()

        Dim returnStr As String = ""

        Try
            com7 = My.Computer.Ports.OpenSerialPort("COM7", 19200, Parity.None, 8, StopBits.One)
            com7.ReadTimeout = 10000
            Do
                If _continue = True Then
                    Dim incoming As String = com7.ReadLine()
                    If incoming Is Nothing Then
                        Exit Do
                    Else
                        Debug.Print(incoming)
                        UpdateScreen(incoming)
                    End If
                Else
                    com7.Close()
                    Exit Sub
                End If
            Loop
        Catch ex As TimeoutException
            MessageBox.Show("Serial Port lost or not detected")
        End Try

    End Sub

    Private Sub btn_Connection_Click(sender As Object, e As EventArgs) Handles btn_Connection.Click

        If _continue = False Then
            _continue = True
            theThread = New Threading.Thread(AddressOf TestMultiThreading)
            theThread.Start()
            btn_Connection.Text = "Disconnect"
        Else
            _continue = False
            btn_Connection.Text = "Connect"
        End If

    End Sub

    Sub UpdateScreen(readLine As String)
        Dim r As Random = New Random
        Dim randomDT As Single = r.Next(39500, 41000) / 10000
        Dim randomTF As Single = r.Next(38000, 39500) / 10000
        updateData(randomDT, randomTF)
    End Sub

End Class
