Public Class frmMain

    Dim recentDT(4) As Single
    Dim recentTF(4) As Single
    Dim recentDiff(4) As Single
    Dim currentReading As Integer = 0
    Dim totalReadings As Integer = 0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Test_Click(sender As Object, e As EventArgs) Handles btn_Test.Click
        Dim r As Random = New Random
        Dim randomDT As Single = r.Next(3950, 4100) / 1000
        Dim randomTF As Single = r.Next(3800, 3950) / 1000
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

End Class
