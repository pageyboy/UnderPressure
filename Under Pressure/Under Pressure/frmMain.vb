Imports System
Imports System.IO.Ports
Imports System.Threading
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.IO
Imports System.Timers
Imports System.Reflection

Public Class frmMain

    Inherits Form

    Dim mTime As Long
    Dim mTimeAcq As Long
    Dim startTime As DateTime
    Dim startTimeAcq As DateTime

    Dim recentDT() As Single
    Dim recentTF() As Single
    Dim recentDelta() As Single

    Dim currentReading As Integer = 0
    Dim totalReadings As Integer = 0

    Dim dtSetpoint As Single
    Dim tfSetpoint As Single
    Dim deltaSetpoint As Single
    Dim dtRSDSetpoint As Single
    Dim tfRSDSetpoint As Single

    Dim theThread As System.Threading.Thread
    Dim selectedPort As IO.Ports.SerialPort
    Dim _continue As Boolean = False
    Dim _everConnected As Boolean = False
    Dim serialPort As String
    Dim _acquisition As Boolean = False

    Dim colorGood As Color = Color.Green
    Dim colorOK As Color = Color.Orange
    Dim colorBad As Color = Color.Red

    Dim _runEvents = False

    ' Update all of the various data outputs: Graphical, DataGridView, Labels and Color Codes
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
        mTimeAcq = (DateTime.UtcNow - startTimeAcq).TotalMilliseconds
        dgv_Data.Rows.Add(DateTime.Now.ToString("dd MMM yyyy hh:mm:ss.fff tt"), mTime, mTimeAcq, totalReadings + 1, Format(driftTube, "0.0000"), Format(trapFunnel, "0.0000"), Format(delta, "0.0000"))

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
                lbl_DataPointWarning.Text = "Number of data points OK"
                lbl_DataPointWarning.ForeColor = colorGood
                lbl_Delta_SD.Visible = True
                lbl_DT_SD.Visible = True
                lbl_TF_SD.Visible = True
                lbl_PlusMinus.Text = "Torr ±"
                lbl_mTorr.Visible = True

                lbl_Delta_RSD.Visible = True
                lbl_DT_RSD.Visible = True
                lbl_TF_RSD.Visible = True

                lbl_PercentSign.Visible = True
            Else
                lbl_DataPointWarning.Text = "Waiting for correct number of data points"
                lbl_DataPointWarning.ForeColor = colorBad
            End If

            ' _doNotContinueUpdate flag is used to check that once an array has been resized and filled with zeroes that no incorrect SDs/RSDs are returned 
            Dim _doNotContinueUpdate As Boolean
            Dim zeroDT As Integer = Array.FindIndex(recentDT, Function(val) val = 0)

            If zeroDT > 0 Then
                _doNotContinueUpdate = True
            End If

            ' If the desired number of data points are reached and the array doesn't have any zeroes in it from a resize
            If totalReadings >= numDataPoints - 1 And _doNotContinueUpdate = False Then

                Dim dtRSD As Single = Math.Round(calcRSD(recentDT), 3)
                Dim tfRSD As Single = Math.Round(calcRSD(recentTF), 3)
                Dim deltaRSD As Single = Math.Round(calcRSD(recentDelta), 3)

                Dim dtSD As Single = Math.Round(calcStandardDeviation(recentDT) * 1000, 1)
                Dim tfSD As Single = Math.Round(calcStandardDeviation(recentTF) * 1000, 1)
                Dim deltaSD As Single = Math.Round(calcStandardDeviation(recentDelta) * 1000, 1)

                ' Update stats labels
                lbl_DT_RSD.Text = Format(dtRSD, "0.000")
                lbl_TF_RSD.Text = Format(tfRSD, "0.000")
                lbl_Delta_RSD.Text = Format(deltaRSD, "0.000")

                lbl_DT_SD.Text = Format(dtSD, "0.0")
                lbl_TF_SD.Text = Format(tfSD, "0.0")
                lbl_Delta_SD.Text = Format(deltaSD, "0.0")

                ' Fixes Issue #1 by checking for numeric values
                If Not IsNumeric(txtBox_DT_RSD_Setpoint.Text) Or Not IsNumeric(txtBox_TF_RSD_Setpoint.Text) Then
                    Exit Sub
                End If

                Dim dtRSDSetpoint As Single = Convert.ToSingle(txtBox_DT_RSD_Setpoint.Text)
                Dim tfRSDSetpoint As Single = Convert.ToSingle(txtBox_TF_RSD_Setpoint.Text)

                ' Update the stats labels with these colors
                Select Case dtRSD
                    Case <= dtRSDSetpoint
                        lbl_DT_RSD.ForeColor = colorGood
                        lbl_DT_SD.ForeColor = colorGood
                    Case <= dtRSDSetpoint * 2
                        lbl_DT_RSD.ForeColor = colorOK
                        lbl_DT_SD.ForeColor = colorOK
                    Case Else
                        lbl_DT_RSD.ForeColor = colorBad
                        lbl_DT_SD.ForeColor = colorBad
                End Select

                Select Case tfRSD
                    Case <= tfRSDSetpoint
                        lbl_TF_RSD.ForeColor = colorGood
                        lbl_TF_SD.ForeColor = colorGood
                    Case <= tfRSDSetpoint * 2
                        lbl_TF_RSD.ForeColor = colorOK
                        lbl_TF_SD.ForeColor = colorOK
                    Case Else
                        lbl_TF_RSD.ForeColor = colorBad
                        lbl_TF_SD.ForeColor = colorBad
                End Select

                ' Fixes Issue #1 by checking for numeric values
                If Not IsNumeric(txtBox_DT_Error_Setpoint.Text) Or Not IsNumeric(txtBox_TF_Error_Setpoint.Text) Or
                    Not IsNumeric(txtBox_Delta_Error_Setpoint.Text) Or Not IsNumeric(txtBox_DT_Value_Setpoint.Text) Or
                    Not IsNumeric(txtBox_TF_Value_Setpoint.Text) Or Not IsNumeric(txtBox_Delta_Value_Setpoint.Text) Then
                    Exit Sub
                End If

                Dim dtError As Single = Convert.ToSingle(txtBox_DT_Error_Setpoint.Text) / 1000
                Dim tfError As Single = Convert.ToSingle(txtBox_TF_Error_Setpoint.Text) / 1000
                Dim deltaError As Single = Convert.ToSingle(txtBox_Delta_Error_Setpoint.Text) / 1000

                dtSetpoint = Convert.ToSingle(txtBox_DT_Value_Setpoint.Text)
                tfSetpoint = Convert.ToSingle(txtBox_TF_Value_Setpoint.Text)
                deltaSetpoint = Convert.ToSingle(txtBox_Delta_Value_Setpoint.Text)

                Select Case Math.Abs(dtSetpoint - driftTube)
                    Case <= dtError
                        lbl_DTPressure.ForeColor = colorGood
                    Case <= dtError * 2
                        lbl_DTPressure.ForeColor = colorOK
                    Case > dtError
                        lbl_DTPressure.ForeColor = colorBad
                End Select

                Select Case Math.Abs(tfSetpoint - trapFunnel)
                    Case <= tfError
                        lbl_TFPressure.ForeColor = colorGood
                    Case <= tfError * 2
                        lbl_TFPressure.ForeColor = colorOK
                    Case > tfError
                        lbl_TFPressure.ForeColor = colorBad
                End Select

                Select Case Math.Abs(deltaSetpoint - delta)
                    Case <= deltaError
                        lbl_DeltaPressure.ForeColor = colorGood
                    Case <= deltaError * 2
                        lbl_DeltaPressure.ForeColor = colorOK
                    Case > deltaError
                        lbl_DeltaPressure.ForeColor = colorBad
                End Select

            End If
        Else
            ' If leak test has been selected then the number of readings is 2500 (approx 15 minutes as per documentation)
            If totalReadings <= 2500 Then
                chart_Data.ChartAreas(0).AxisX.Minimum = 0
                chart_Data.ChartAreas(0).AxisX.Maximum = totalReadings
            Else
                chart_Data.ChartAreas(0).AxisX.Minimum = totalReadings - 2500
                chart_Data.ChartAreas(0).AxisX.Maximum = totalReadings
            End If

            ' Update label colors based on documentation
            Select Case driftTube
                Case <= 0.05
                    lbl_DTPressure.ForeColor = colorGood
                Case <= 0.075
                    lbl_DTPressure.ForeColor = colorOK
                Case Else
                    lbl_DTPressure.ForeColor = colorBad
            End Select

            Select Case trapFunnel
                Case <= 0.05
                    lbl_TFPressure.ForeColor = colorGood
                Case <= 0.075
                    lbl_TFPressure.ForeColor = colorOK
                Case Else
                    lbl_TFPressure.ForeColor = colorBad
            End Select

        End If

        totalReadings += 1

        If currentReading = numDataPoints - 1 Then
            currentReading = 0
        Else
            currentReading += 1
        End If
    End Sub

    ' Thread to read the Serial Port data being received
    Public Sub readCOMData()

        Try

            ' Set port parameters as per HyperTerminal documentation
            selectedPort = New SerialPort(serialPort)
            selectedPort.BaudRate = 19200
            selectedPort.Parity = Parity.None
            selectedPort.StopBits = StopBits.One
            selectedPort.ReadTimeout = 5000
            selectedPort.Open()

            Dim incoming As String = selectedPort.ReadLine()

            ' This variable is used in the Timeout Exception to help distinguish between whether the the read timeout timed out because the IM was disconnected or
            ' because it was never connected. Helpful for troubleshooting
            If incoming IsNot Nothing Then
                _everConnected = True
            End If

            ' Loop to read data
            Do
                ' The _continue flag is set by clicking the connect/disconnect button
                If _continue = True Then
                    incoming = selectedPort.ReadLine()
                    If incoming Is Nothing Then
                        Exit Do
                    Else
                        If _acquisition = True Then
                            ' Parse the data using the parseData function
                            Me.Invoke(Sub() parseData(incoming.ToString))
                        End If
                    End If
                Else
                    selectedPort.Close()
                    Exit Sub
                End If
            Loop
        Catch ex As TimeoutException
            If _everConnected Then
                MessageBox.Show(Me, "Lost connection to IMQTOF on " & serialPort, "Under Pressure - Error with Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(Me, "Unabled to connect to IMQTOF on " & serialPort, "Under Pressure - Error with Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Invoke(Sub() DisconnectIM())
        Catch ex As Exception
        End Try

    End Sub

    ' Sub to handle the Connect/Disconnect button
    Private Sub btn_Connection_Click(sender As Object, e As EventArgs) Handles btn_Connection.Click

        ' Check whether the instrument is connected (via the _continue flag) and whether a Serial Port has been specified
        If _continue = False And comboBox_SerialPorts.Text <> "" Then

            Dim answer As Integer
            Dim message As String
            message = "For this program to work then the Hyperterminal connection needs to be running in the background. Please follow the steps below to establish a connection:" & vbCr & vbCr
            message &= "If an IM Hyperterminl connection has been previously created then open the connection and skip to step 5." & vbCr & vbCr
            message &= "1. Open Hyperterminal. Click 'New Connection' and enter an name and an icon." & vbCr & vbCr
            message &= "2. Select the correct COM port" & vbCr & vbCr
            message &= "3. Set the Serial Port properties as per the following:" & vbCr & vbCr
            message &= "Baud Rate: 19200 bits per second" & vbCr
            message &= "Data bits: 8" & vbCr
            message &= "Parity: None" & vbCr
            message &= "Stop bits: 1" & vbCr
            message &= "Flow Control: None" & vbCr & vbCr
            message &= "4. Click OK and File > Save As the connection as IMQTOF" & vbCr & vbCr
            message &= "5. Press the escape key until the revision and a list of commands is shown" & vbCr & vbCr
            message &= "6. Enter '5' into Hyperterminal" & vbCr & vbCr
            message &= "7. If a scrolling output is displayed similar to the below then Hyperterminal can be closed as the instrument is ready to connect to:" & vbCr & "CON>1: 3.7868 0x50 2: 3.9459 0x00" & vbCr & vbCr
            message &= "8. If the output is blank or static then enter the command RCN and press enter to start the scrolling output and close Hyperterminal" & vbCr & vbCr
            message &= "Has the scrolling output been activated and Hyperterminal been closed?"
            answer = MessageBox.Show(Me, message, "Under Pressure - Ensure Hyperterminal is Running in Background", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If answer = DialogResult.No Then
                Exit Sub
            End If

            ' Set up continue and connect flags and get ready to start receiving data
            _continue = True
            _everConnected = False
            serialPort = comboBox_SerialPorts.Text
            theThread = New Threading.Thread(AddressOf readCOMData)
            theThread.Start()

            ' Change UI to accept stats
            btn_Connection.Text = "Disconnect"
            btn_AcquisitionStartStop.Enabled = True
            comboBox_SerialPorts.Enabled = False
        Else
            ' Ensure that the IM is disconnected so that we can reconnect later
            DisconnectIM()
        End If

    End Sub

    ' Sub to disconnect Serial Port safely
    Sub DisconnectIM()
        _continue = False
        btn_Connection.Text = "Connect"
        btn_AcquisitionStartStop.Text = "Start Acquisition"
        btn_AcquisitionStartStop.Enabled = False
        _acquisition = False
        comboBox_SerialPorts.Enabled = True
    End Sub

    ' Sub to parse data
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

    ' Sub to handle closing of form and disconnection of IM safely
    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If _continue Then
            Dim answer As Integer
            answer = MessageBox.Show(Me, "This will disconnect from the IMQTOF and all data will be lost. Are you sure you want to close?", "Under Pressure - IMQTOF Still Connected!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = DialogResult.Yes Then
                DisconnectIM()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    ' Sub to load form.
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Get all serial ports that are available and display in combo box for selection.
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comboBox_SerialPorts.Items.Add(sp)
        Next
        comboBox_SerialPorts.SelectedIndex = comboBox_SerialPorts.Items.Count - 1
        startTime = DateTime.UtcNow

        Dim assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim fileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion
        Debug.Print(fileVersion)

        Me.Text = "Under Pressure - Drift Tube Pressure Monitor - v" & fileVersion

        ' Ensure that the correct Attribution is made as per the licencing
        lbl_Atribution.Text = "Icons made by Freepik from Flaticon is licensed by Creative Commons BY 3.0"
        lbl_Atribution.Links.Add(14, 7, "http://www.freepik.com")
        lbl_Atribution.Links.Add(27, 8, "https://www.flaticon.com/")
        lbl_Atribution.Links.Add(51, 23, "http://creativecommons.org/licenses/by/3.0/")

        Dim emailLink As String = "mailto:chris.page@agilent.com?subject=Under%20Pressure%20v" & fileVersion
        lbl_Developer.Text = "Made in UK by Chris Page"
        lbl_Developer.Links.Add(14, 10, emailLink)

        lbl_Github.Text = "Visit Github for the latest updates and information"
        lbl_Github.Links.Add(6, 6, "https://github.com/pageyboy/UnderPressure")


    End Sub

    ' Sub to handle form showing.
    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Allow events to run again
        _runEvents = True
    End Sub

    ' Subs to handle clicking of links
    Private Sub lbl_Atribution_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_Atribution.LinkClicked
        Dim target As String = Convert.ToString(e.Link.LinkData)
        System.Diagnostics.Process.Start(target)
    End Sub

    Private Sub lbl_Developer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_Developer.LinkClicked
        Dim target As String = Convert.ToString(e.Link.LinkData)
        System.Diagnostics.Process.Start(target)
    End Sub

    Private Sub lbl_Github_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_Github.LinkClicked
        Dim target As String = Convert.ToString(e.Link.LinkData)
        System.Diagnostics.Process.Start(target)
    End Sub

    ' Custom function to calculate standard deviation
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

    ' Custom function to calculate standard deviation
    Function calcRSD(ByVal ParamArray args() As Single) As Single
        Dim average As Single = args.Average()
        Dim sd As Single = calcStandardDeviation(args)
        Dim rsd As Single = (sd / average) * 100
        Return rsd
    End Function

    ' Subs to handle number spinner up and down.
    ' Only want to allow certain values:
    ' 25: Quick 10 second check to allow approximate setting
    ' 750: 5 minute test as per the documentation
    ' 1500: 10 minute in depth oscillation test
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

    ' Sub to handle leak test check box being checked
    Private Sub chkBox_LeakTest_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox_LeakTest.CheckedChanged
        If chkBox_LeakTest.Checked = True Then

            ' Disable useless parts of UI for this test
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

            ' Display information about how to run the leak test
            Dim message As String = "By checking this box the acceptable limits of the Drift Gas and Trap Funnel pressures are changed to 50mTorr and the Drift Tube Leak Rate is evaluated. Follow the steps below before clicking 'Connect':" & vbCr & vbCr
            message &= "1. Set the Drift Tube Entrance voltage to 250V. (Set and apply in MassHunter). Arcing and an Error state can occur if this is not performed." & vbCr & vbCr
            message &= "2. Set the instrument into standyby mode and allow gas temperatures to cool." & vbCr & vbCr
            message &= "3. Remove the spray shield and capillary cap and place a GC septum over the ion transfer capillary hole and secure with a classic ESI spray shield (G1946-20157)." & vbCr & vbCr
            message &= "4. Turn off the drift/funnel gas supplies by using the valves on the Pressure Control Module and IM chassis." & vbCr & vbCr
            message &= "5. After 15 minutes the Drift Tube pressure should be less than 50 mTorr. If the pressure is greater than 50 mTorr then there is likely a leak in the drift gas assy, the trapping funnel assy, drift tube exit or any of the connecting flanges. N.B. if the capillary cap is in place the drift tube vacuum is approximately 75 mTorr." & vbCr & vbCr
            MessageBox.Show(Me, message, "Under Pressure - Running the IM Leak Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            ' Reset UI back to standard
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

    ' Sub to handle validation of text box inputs to ensure that they are numeric and formatted in a consistent manner
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

    ' Sub to handle calculations after text box inputs are changed
    Private Sub txtBox_DT_Value_Setpoint_TextChanged(sender As Object, e As EventArgs) Handles _
        txtBox_TF_Value_Setpoint.TextChanged, txtBox_TF_SD_Setpoint.TextChanged, txtBox_TF_RSD_Setpoint.TextChanged,
        txtBox_DT_Value_Setpoint.TextChanged, txtBox_DT_SD_Setpoint.TextChanged, txtBox_DT_RSD_Setpoint.TextChanged,
        txtBox_Delta_Value_Setpoint.TextChanged

        Dim t As TextBox = sender

        ' Fixes Issue #1 by checking for numeric values
        If Not IsNumeric(t.Text) Then
            t.BackColor = Color.PaleVioletRed
            Exit Sub
        Else
            t.BackColor = System.Drawing.SystemColors.Window
        End If

        If _runEvents = True Then

            _runEvents = False

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
                        txtBox_DT_SD_Setpoint.Text = Format(((dtRSD / 100) * dtValue) * 1000, "0.000")
                    ElseIf t.Name.Contains("TF") Then
                        txtBox_TF_SD_Setpoint.Text = Format(((tfRSD / 100) * tfValue) * 1000, "0.000")
                    End If
            End Select

            _runEvents = True

        End If

    End Sub

    Private Sub txtBox_DT_Leak_Setpoint_TextChanged(sender As Object, e As EventArgs) Handles txtBox_DT_Leak_Setpoint.TextChanged, txtBox_TF_Leak_Setpoint.TextChanged,
            txtBox_DT_Error_Setpoint.TextChanged, txtBox_TF_Error_Setpoint.TextChanged, txtBox_Delta_Error_Setpoint.TextChanged

        Dim t As TextBox = sender

        ' Fixes Issue #1 by checking for numeric values
        If Not IsNumeric(t.Text) Then
            t.BackColor = Color.PaleVioletRed
            Exit Sub
        Else
            t.BackColor = System.Drawing.SystemColors.Window
        End If

    End Sub

    ' Fixes Issue #3 by providing button to start/stop data acquisition
    Private Sub btn_AcquisitionStartStop_Click(sender As Object, e As EventArgs) Handles btn_AcquisitionStartStop.Click

        If _acquisition Then
            Dim messageBoxAnswer As Integer
            messageBoxAnswer = MessageBox.Show(Me, "Are you sure you want to stop acquisition, if you start acquisition again then you will need to wait until there are enough data points to evaluate.", "Under Pressure - Disconnect from IM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If messageBoxAnswer = DialogResult.No Then
                Exit Sub
            End If
            _acquisition = False
            btn_AcquisitionStartStop.Text = "Start Acquisition"
            num_DataPoints.Enabled = True
            lbl_DataPoints.Enabled = True
            chkBox_LeakTest.Enabled = True
            lbl_SecsConverter.Enabled = True
            btn_Connection.Enabled = True
        Else
            btn_Connection.Enabled = False
            startTimeAcq = DateTime.UtcNow
            currentReading = 0
            totalReadings = 0
            num_DataPoints.Enabled = False
            lbl_DataPoints.Enabled = False
            lbl_SecsConverter.Enabled = False
            chkBox_LeakTest.Enabled = False
            _acquisition = True
            btn_AcquisitionStartStop.Text = "Stop Acquisition"

            ReDim recentDT(num_DataPoints.Value - 1)
            ReDim recentTF(num_DataPoints.Value - 1)
            ReDim recentDelta(num_DataPoints.Value - 1)

            ' Handle UI
            lbl_DT_RSD.Visible = False
            lbl_TF_RSD.Visible = False
            lbl_PercentSign.Visible = False
            lbl_mTorr.Visible = False
            lbl_Delta_RSD.Visible = False
            lbl_Delta_SD.Visible = False
            lbl_DT_SD.Visible = False
            lbl_TF_SD.Visible = False
            lbl_PlusMinus.Text = "Torr"

            lbl_DTPressure.ForeColor = Color.Black
            lbl_TFPressure.ForeColor = Color.Black
            lbl_DeltaPressure.ForeColor = Color.Black

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
                .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
                .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
            End With

        End If
    End Sub
End Class