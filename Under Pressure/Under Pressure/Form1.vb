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
    Dim recentDelta() As Single

    Dim currentReading As Integer = 0
    Dim totalReadings As Integer = 0

    Dim dtSetpoint As Single
    Dim tfSetpoint As Single
    Dim dtRSDSetpoint As Single
    Dim tfRSDSetpoint As Single

    Dim theThread As System.Threading.Thread
    Dim selectedPort As New IO.Ports.SerialPort
    Dim _continue As Boolean = False
    Dim _everConnected As Boolean = False
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
        Dim delta As Single = driftTube - trapFunnel
        lbl_DTPressure.Text = Format(driftTube, "0.0000")
        lbl_TFPressure.Text = Format(trapFunnel, "0.0000")
        lbl_DeltaPressure.Text = Format(delta, "0.0000")

        ' Add the data into the arrays which have been sized depending on the number of data points the user is interested in
        recentDT(currentReading) = driftTube
        recentTF(currentReading) = trapFunnel
        recentDelta(currentReading) = delta

        ' Add data into DGV
        mTime = (DateTime.UtcNow - startTime).TotalMilliseconds
        dgv_Data.Rows.Add(DateTime.Now.ToString("dd MMM yyyy hh:mm:ss.fff tt"), mTime, totalReadings + 1, Format(driftTube, "0.0000"), Format(trapFunnel, "0.0000"), Format(delta, "0.0000"))

        ' Update chart
        chart_Data.Series("Drift Tube Pressure").Points.AddXY(totalReadings, driftTube)
        chart_Data.Series("Trap Funnel Pressure").Points.AddXY(totalReadings, trapFunnel)
        chart_Data.ChartAreas(0).AxisY.Minimum = Convert.ToDouble(recentTF.Where(Function(num) num > 0).Min) - 0.15
        chart_Data.ChartAreas(0).AxisY.Maximum = Convert.ToDouble(recentDT.Max) + 0.15

        If chkBox_LeakTest.CheckState = False Then
            Select Case numDataPoints
                Case 25
                    If totalReadings <= 150 Then
                        chart_Data.ChartAreas(0).AxisX.Minimum = 0
                        chart_Data.ChartAreas(0).AxisX.Maximum = totalReadings
                    Else
                        chart_Data.ChartAreas(0).AxisX.Minimum = totalReadings - 150
                        chart_Data.ChartAreas(0).AxisX.Maximum = totalReadings
                    End If
                Case 750
                    If totalReadings <= 750 Then
                        chart_Data.ChartAreas(0).AxisX.Minimum = 0
                        chart_Data.ChartAreas(0).AxisX.Maximum = totalReadings
                    Else
                        chart_Data.ChartAreas(0).AxisX.Minimum = totalReadings - 750
                        chart_Data.ChartAreas(0).AxisX.Maximum = totalReadings
                    End If
                Case 1500
                    If totalReadings <= 1500 Then
                        chart_Data.ChartAreas(0).AxisX.Minimum = 0
                        chart_Data.ChartAreas(0).AxisX.Maximum = totalReadings
                    Else
                        chart_Data.ChartAreas(0).AxisX.Minimum = totalReadings - 1500
                        chart_Data.ChartAreas(0).AxisX.Maximum = totalReadings
                    End If
            End Select

            ' If the total number of readings that the user has requested are used for statistics have been reached then the statistics can be calculated and the labels to display these can be made visible.
            If totalReadings >= numDataPoints - 1 Then
                lbl_Delta_SD.Visible = True
                lbl_DT_SD.Visible = True
                lbl_TF_SD.Visible = True
                lbl_PlusMinus.Text = "Torr ±"
                lbl_mTorr.Visible = True

                lbl_Delta_RSD.Visible = True
                lbl_DT_RSD.Visible = True
                lbl_TF_RSD.Visible = True

                lbl_PercentSign.Visible = True
            End If

            ' _doNotContinueUpdate flag is used as 
            Dim _doNotContinueUpdate As Boolean
            Dim zeroDT As Integer = Array.FindIndex(recentDT, Function(val) val = 0)

            If zeroDT > 0 Then
                _doNotContinueUpdate = True
            End If

            If totalReadings >= numDataPoints - 1 And _doNotContinueUpdate = False Then

                Dim dtRSD As Single = Math.Round(calcRSD(recentDT), 2)
                Dim tfRSD As Single = Math.Round(calcRSD(recentTF), 2)
                Dim deltaRSD As Single = Math.Round(calcRSD(recentDelta), 2)

                Dim dtSD As Single = Math.Round(calcStandardDeviation(recentDT) * 1000, 1)
                Dim tfSD As Single = Math.Round(calcStandardDeviation(recentTF) * 1000, 1)
                Dim deltaSD As Single = Math.Round(calcStandardDeviation(recentDelta) * 1000, 1)

                lbl_DT_RSD.Text = Format(dtRSD, "0.00")
                lbl_TF_RSD.Text = Format(tfRSD, "0.00")
                lbl_Delta_RSD.Text = Format(deltaRSD, "0.00")

                lbl_DT_SD.Text = Format(dtSD, "0.0")
                lbl_TF_SD.Text = Format(tfSD, "0.0")
                lbl_Delta_SD.Text = Format(deltaSD, "0.0")

                Dim dtRSDSetpoint As Single = Convert.ToSingle(txtBox_DT_RSD_Setpoint.Text)
                Dim tfRSDSetpoint As Single = Convert.ToSingle(txtBox_TF_RSD_Setpoint.Text)

                Select Case dtRSD
                    Case <= dtRSDSetpoint
                        lbl_DT_RSD.ForeColor = Color.LightGreen
                        lbl_DT_SD.ForeColor = Color.LightGreen
                    Case <= dtRSDSetpoint * 2
                        lbl_DT_RSD.ForeColor = Color.Orange
                        lbl_DT_SD.ForeColor = Color.Orange
                    Case Else
                        lbl_DT_RSD.ForeColor = Color.Red
                        lbl_DT_SD.ForeColor = Color.Red
                End Select

                Select Case tfRSD
                    Case <= tfRSDSetpoint
                        lbl_TF_RSD.ForeColor = Color.LightGreen
                        lbl_TF_SD.ForeColor = Color.LightGreen
                    Case <= tfRSDSetpoint * 2
                        lbl_TF_RSD.ForeColor = Color.Orange
                        lbl_TF_SD.ForeColor = Color.Orange
                    Case Else
                        lbl_TF_RSD.ForeColor = Color.Red
                        lbl_TF_SD.ForeColor = Color.Red
                End Select

            End If
        Else
            If totalReadings <= 2500 Then
                chart_Data.ChartAreas(0).AxisX.Minimum = 0
                chart_Data.ChartAreas(0).AxisX.Maximum = totalReadings
            Else
                chart_Data.ChartAreas(0).AxisX.Minimum = totalReadings - 2500
                chart_Data.ChartAreas(0).AxisX.Maximum = totalReadings
            End If

            Select Case driftTube
                Case <= 0.05
                    lbl_DTPressure.ForeColor = Color.LightGreen
                Case <= 0.075
                    lbl_DTPressure.ForeColor = Color.Orange
                Case Else
                    lbl_DTPressure.ForeColor = Color.Red
            End Select

            Select Case trapFunnel
                Case <= 0.05
                    lbl_TFPressure.ForeColor = Color.LightGreen
                Case <= 0.075
                    lbl_TFPressure.ForeColor = Color.Orange
                Case Else
                    lbl_TFPressure.ForeColor = Color.Red
            End Select

        End If

        totalReadings += 1

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
            AddHandler selectedPort.DataReceived, AddressOf DataReceivedHandler
            Dim incoming As String = selectedPort.ReadLine()
            If incoming IsNot Nothing Then
                _everConnected = True
            End If

            'Dim Output As String
            'Output = Chr(27)
            'selectedPort.WriteLine(Output)


            Do
                If _continue = True Then
                    incoming = selectedPort.ReadLine()
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
            If _everConnected Then
                MessageBox.Show(Me, "Lost connection to IMQTOF on " & serialPort, "Error with Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(Me, "Unabled to connect to IMQTOF on " & serialPort, "Error with Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Invoke(Sub() DisconnectIM())
        Catch ex As Exception
        End Try

    End Sub

    Public Sub DataReceivedHandler(sender As Object,
                        e As SerialDataReceivedEventArgs)

        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim indata As String = sp.ReadExisting()
        Me.Invoke(Sub() parseData(indata.ToString))

    End Sub

    Private Sub btn_Connection_Click(sender As Object, e As EventArgs) Handles btn_Connection.Click

        If _continue = False And comboBox_SerialPorts.Text <> "" Then
            ReDim recentDT(num_DataPoints.Value - 1)
            ReDim recentTF(num_DataPoints.Value - 1)
            ReDim recentDelta(num_DataPoints.Value - 1)

            lbl_DT_RSD.Visible = False
            lbl_TF_RSD.Visible = False
            lbl_PercentSign.Visible = False
            lbl_mTorr.Visible = False
            lbl_Delta_RSD.Visible = False
            lbl_Delta_SD.Visible = False
            lbl_DT_SD.Visible = False
            lbl_TF_SD.Visible = False
            lbl_PlusMinus.Text = "Torr"

            ' Chart setup

            With chart_Data.Series
                .Clear()
                .Add("Drift Tube Pressure")
                .Add("Trap Funnel Pressure")
            End With

            With chart_Data.Series("Drift Tube Pressure")
                .ChartType = DataVisualization.Charting.SeriesChartType.FastLine
                .BorderWidth = 3
            End With

            With chart_Data.Series("Trap Funnel Pressure")
                .ChartType = DataVisualization.Charting.SeriesChartType.FastLine
                .BorderWidth = 3
            End With

            With chart_Data.ChartAreas(0)
                .AxisY.LabelStyle.Format = "0.0"
                .AxisX.LabelStyle.Format = "0"
                '.AxisY.Interval = 0.1
                .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
                .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
            End With

            _continue = True
            _everConnected = False
            currentReading = 0
            totalReadings = 0
            serialPort = comboBox_SerialPorts.Text
            theThread = New Threading.Thread(AddressOf readCOMData)
            theThread.Start()
            btn_Connection.Text = "Disconnect"
            num_DataPoints.Enabled = False
            lbl_DataPoints.Enabled = False
            comboBox_SerialPorts.Enabled = False
            chkBox_LeakTest.Enabled = False
            lbl_SecsConverter.Enabled = False
        Else
            Dim messageBoxAnswer As Integer
            messageBoxAnswer = MessageBox.Show(Me, "Are you sure you want to disconnect, if you reconnect then you will need to wait until there are enough data points to evaluate.", "Disconnect?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If messageBoxAnswer = DialogResult.No Then
                Exit Sub
            End If
            DisconnectIM()
        End If

    End Sub

    Sub DisconnectIM()
        _continue = False
        btn_Connection.Text = "Connect"
        num_DataPoints.Enabled = True
        lbl_DataPoints.Enabled = True
        comboBox_SerialPorts.Enabled = True
        chkBox_LeakTest.Enabled = True
        lbl_SecsConverter.Enabled = True
    End Sub

    Private Sub parseData(readLine As String)
        Try
            Dim parsedDT As Single
            Dim parsedTF As Single
            txtBox_Hyperterminal.AppendText(readLine & vbCrLf)
            If readLine.IndexOf("1: ") > -1 And readLine.IndexOf("2: ") > -1 Then
                Dim temp As String = readLine.Substring(readLine.IndexOf("1: ") + 3, 6)
                parsedTF = Convert.ToSingle(temp)
                temp = readLine.Substring(readLine.IndexOf("2: ") + 3, 6)
                parsedDT = Convert.ToSingle(temp)
                updateData(parsedDT, parsedTF)
                txtBox_Hyperterminal.AppendText(readLine & vbCrLf)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If _continue Then
            Dim answer As Integer
            answer = MessageBox.Show(Me, "This will disconnect from the IMQTOF and all data will be lost. Are you sure you want to close?", "IMQTOF Still Connected - Action Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = DialogResult.Yes Then
                DisconnectIM()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        For Each sp As String In My.Computer.Ports.SerialPortNames
            comboBox_SerialPorts.Items.Add(sp)
        Next
        comboBox_SerialPorts.SelectedIndex = comboBox_SerialPorts.Items.Count - 1
        startTime = DateTime.UtcNow

        lbl_Atribution.Text = "Icons made by Freepik from Flaticon is licensed by Creative Commons BY 3.0"
        lbl_Atribution.Links.Add(14, 7, "http://www.freepik.com")
        lbl_Atribution.Links.Add(27, 8, "https://www.flaticon.com/")
        lbl_Atribution.Links.Add(51, 23, "http://creativecommons.org/licenses/by/3.0/")

        lbl_Developer.Text = "Made in UK by Chris Page"
        lbl_Developer.Links.Add(14, 10, "mailto: chris.page@agilent.com")

    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        _runEvents = True
    End Sub

    Private Sub lbl_Atribution_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_Atribution.LinkClicked
        Dim target As String = Convert.ToString(e.Link.LinkData)
        System.Diagnostics.Process.Start(target)
    End Sub

    Private Sub lbl_Developer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_Developer.LinkClicked
        Dim target As String = Convert.ToString(e.Link.LinkData)
        System.Diagnostics.Process.Start(target)
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

    Private Sub chkBox_LeakTest_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox_LeakTest.CheckedChanged
        If chkBox_LeakTest.Checked = True Then
            num_DataPoints.Enabled = False
            lbl_DataPoints.Enabled = False
            lbl_SecsConverter.Enabled = False
            lbl_DT_RSD.Visible = False
            lbl_TF_RSD.Visible = False
            lbl_PercentSign.Visible = False
            lbl_mTorr.Visible = False
            lbl_Delta_RSD.Visible = False
            lbl_Delta_SD.Visible = False
            lbl_DT_SD.Visible = False
            lbl_TF_SD.Visible = False
            lbl_PlusMinus.Text = "Torr"

            Dim message As String = "By checking this box the acceptable limits of the Drift Gas and Trap Funnel pressures are changed to 50mTorr and the Drift Tube Leak Rate is evaluated. Follow the steps below before clicking 'Connect':" & vbCr & vbCr
            message &= "1. Set the Drift Tube Entrance voltage to 250V. (Set and apply in MassHunter). Arcing and an Error state can occur if this is not performed." & vbCr & vbCr
            message &= "2. Set the instrument into standyby mode and allow gas temperatures to cool." & vbCr & vbCr
            message &= "3. Remove the spray shield and capillary cap and place a GC septum over the ion transfer capillary hole and secure with a classic ESI spray shield (G1946-20157)." & vbCr & vbCr
            message &= "4. Turn off the drift/funnel gas supplies by using the valves on the Pressure Control Module and IM chassis." & vbCr & vbCr
            message &= "5. After 15 minutes the Drift Tube pressure should be less than 50 mTorr. If the pressure is greater than 50 mTorr then there is likely a leak in the drift gas assy, the trapping funnel assy, drift tube exit or any of the connecting flanges. N.B. if the capillary cap is in place the drift tube vacuum is approximately 75 mTorr." & vbCr & vbCr
            MessageBox.Show(Me, message, "Running the IM Leak Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            lbl_DTPressure.ForeColor = Color.Black
            lbl_TFPressure.ForeColor = Color.Black
            num_DataPoints.Enabled = True
            lbl_DataPoints.Enabled = True
            lbl_SecsConverter.Enabled = True
            If lbl_DTPressure.Text = "0.0000" Then
                lbl_PlusMinus.Text = "Torr"
            Else
                lbl_PlusMinus.Text = "Torr ±"
                lbl_DT_RSD.Visible = True
                lbl_TF_RSD.Visible = True
                lbl_PercentSign.Visible = True
                lbl_mTorr.Visible = True
                lbl_Delta_RSD.Visible = True
                lbl_Delta_SD.Visible = True
                lbl_DT_SD.Visible = True
                lbl_TF_SD.Visible = True
            End If
        End If
    End Sub

    Private Sub txtBox_DT_Setpoint_TextChanged(sender As Object, e As EventArgs)

        Select Case True
            Case radBtn_DT.Checked
            Case radBtn_TF.Checked
            Case radBtn_Delta.Checked
        End Select
    End Sub

    Private Sub txtBox_DT_Setpoint_Validating(sender As Object, e As CancelEventArgs) Handles txtBox_TF_Value_Setpoint.Validating, txtBox_TF_SD_Setpoint.Validating, txtBox_TF_RSD_Setpoint.Validating, txtBox_TF_Leak_Setpoint.Validating, txtBox_TF_Error_Setpoint.Validating, txtBox_DT_Value_Setpoint.Validating, txtBox_DT_SD_Setpoint.Validating, txtBox_DT_RSD_Setpoint.Validating, txtBox_DT_Leak_Setpoint.Validating, txtBox_DT_Error_Setpoint.Validating, txtBox_Delta_Value_Setpoint.Validating, txtBox_Delta_Error_Setpoint.Validating

        If _runEvents = True Then
            Dim t As TextBox = sender

            If t.Text = "" Or IsNumeric(sender.text) = False Then
                e.Cancel = True
            End If

            Dim tValue As Single = Convert.ToSingle(t.Text)

            If tValue = 0 Then
                e.Cancel = True
            End If

            Select Case True
                Case t.Name.Contains("Value")
                    t.Text = Format(tValue, "0.0000")
                Case t.Name.Contains("SD")
                    t.Text = Format(tValue, "0.00")
                Case (t.Name.Contains("Error") Or t.Name.Contains("Leak"))
                    t.Text = Format(tValue, "0")
            End Select
        End If

    End Sub

    Dim _runEvents = False

    Private Sub txtBox_DT_Value_Setpoint_TextChanged(sender As Object, e As EventArgs) Handles txtBox_TF_Value_Setpoint.TextChanged, txtBox_TF_SD_Setpoint.TextChanged, txtBox_TF_RSD_Setpoint.TextChanged, txtBox_DT_Value_Setpoint.TextChanged, txtBox_DT_SD_Setpoint.TextChanged, txtBox_DT_RSD_Setpoint.TextChanged, txtBox_Delta_Value_Setpoint.TextChanged

        If _runEvents = True Then

            _runEvents = False

            Dim t As TextBox = sender

            Dim dtValue As Single = Convert.ToSingle(txtBox_DT_Value_Setpoint.Text)
            Dim tfValue As Single = Convert.ToSingle(txtBox_TF_Value_Setpoint.Text)
            Dim deltaValue As Single = Convert.ToSingle(txtBox_Delta_Value_Setpoint.Text)

            Dim dtSD As Single = Convert.ToSingle(txtBox_DT_SD_Setpoint.Text)
            Dim tfSD As Single = Convert.ToSingle(txtBox_TF_SD_Setpoint.Text)

            Dim dtRSD As Single = Convert.ToSingle(txtBox_DT_RSD_Setpoint.Text)
            Dim tfRSD As Single = Convert.ToSingle(txtBox_TF_RSD_Setpoint.Text)

            Select Case True
                Case t.Name.Contains("Value")
                    Select Case True
                        Case radBtn_DT.Checked
                            If t.Name.Contains("TF") Then
                                txtBox_Delta_Value_Setpoint.Text = Format(dtValue - tfValue, "0.0000")
                            ElseIf t.Name.Contains("Delta") Then
                                txtBox_TF_Value_Setpoint.Text = Format(dtValue - deltaValue, "0.0000")
                            End If
                        Case radBtn_TF.Checked
                            If t.Name.Contains("DT") Then
                                txtBox_Delta_Value_Setpoint.Text = Format(dtValue - tfValue, "0.0000")
                            ElseIf t.Name.Contains("Delta") Then
                                txtBox_DT_Value_Setpoint.Text = Format(tfValue + deltaValue, "0.0000")
                            End If
                        Case radBtn_Delta.Checked
                            If t.Name.Contains("DT") Then
                                txtBox_DT_Value_Setpoint.Text = Format(tfValue + deltaValue, "0.0000")
                            ElseIf t.Name.Contains("TF") Then
                                txtBox_Delta_Value_Setpoint.Text = Format(dtValue - deltaValue, "0.0000")
                            End If
                    End Select
                Case t.Name.Contains("_SD")
                    If t.Name.Contains("DT") Then
                        txtBox_DT_RSD_Setpoint.Text = Format(((dtValue / dtSD) * 100) / 1000, "0.00")
                    ElseIf t.Name.Contains("TF") Then
                        txtBox_TF_RSD_Setpoint.Text = Format(((tfValue / tfSD) * 100) / 1000, "0.00")
                    End If
                Case t.Name.Contains("RSD")
                    If t.Name.Contains("DT") Then
                        txtBox_DT_SD_Setpoint.Text = Format(((dtRSD / 100) * dtValue) * 1000, "0.00")
                    ElseIf t.Name.Contains("TF") Then
                        txtBox_TF_SD_Setpoint.Text = Format(((tfRSD / 100) * tfValue) * 1000, "0.00")
                    End If
            End Select

            _runEvents = True

        End If

    End Sub

End Class
