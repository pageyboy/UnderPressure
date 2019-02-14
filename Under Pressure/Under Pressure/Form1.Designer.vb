<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btn_Connection = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chart_Data = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_Data = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtBox_Hyperterminal = New System.Windows.Forms.TextBox()
        Me.comboBox_SerialPorts = New System.Windows.Forms.ComboBox()
        Me.num_DataPoints = New System.Windows.Forms.NumericUpDown()
        Me.lbl_DataPoints = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lbl_PercentSign = New System.Windows.Forms.Label()
        Me.lbl_Delta_RSD = New System.Windows.Forms.Label()
        Me.lbl_DT_RSD = New System.Windows.Forms.Label()
        Me.lbl_TF_RSD = New System.Windows.Forms.Label()
        Me.lbl_mTorr = New System.Windows.Forms.Label()
        Me.lbl_Delta_SD = New System.Windows.Forms.Label()
        Me.lbl_DT_SD = New System.Windows.Forms.Label()
        Me.lbl_TF_SD = New System.Windows.Forms.Label()
        Me.lbl_PlusMinus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_DeltaPressure = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_TFPressure = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_DTPressure = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtBox_TF_Leak_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBox_DT_Leak_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtBox_Delta_Error_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtBox_TF_Error_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtBox_DT_Error_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.radBtn_Delta = New System.Windows.Forms.RadioButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtBox_Delta_Value_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.radBtn_TF = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBox_TF_RSD_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBox_TF_SD_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBox_TF_Value_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.radBtn_DT = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBox_DT_RSD_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBox_DT_SD_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBox_DT_Value_Setpoint = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_SecsConverter = New System.Windows.Forms.Label()
        Me.chkBox_LeakTest = New System.Windows.Forms.CheckBox()
        Me.lbl_Atribution = New System.Windows.Forms.LinkLabel()
        Me.lbl_Developer = New System.Windows.Forms.LinkLabel()
        Me.btn_AcquisitionStartStop = New System.Windows.Forms.Button()
        Me.TimeDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mSecs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mSecsAcq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataPointsSinceConnection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiffPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.chart_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.num_DataPoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Connection
        '
        Me.btn_Connection.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.btn_Connection.Location = New System.Drawing.Point(12, 12)
        Me.btn_Connection.Name = "btn_Connection"
        Me.btn_Connection.Size = New System.Drawing.Size(243, 48)
        Me.btn_Connection.TabIndex = 0
        Me.btn_Connection.Text = "Connect"
        Me.btn_Connection.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.0!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 507)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1410, 274)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chart_Data)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1402, 241)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Graphical"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chart_Data
        '
        ChartArea1.Name = "ChartArea1"
        Me.chart_Data.ChartAreas.Add(ChartArea1)
        Me.chart_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chart_Data.Legends.Add(Legend1)
        Me.chart_Data.Location = New System.Drawing.Point(3, 3)
        Me.chart_Data.Name = "chart_Data"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chart_Data.Series.Add(Series1)
        Me.chart_Data.Size = New System.Drawing.Size(1396, 235)
        Me.chart_Data.TabIndex = 0
        Me.chart_Data.Text = "Chart1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_Data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1402, 241)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_Data
        '
        Me.dgv_Data.AllowUserToAddRows = False
        Me.dgv_Data.AllowUserToDeleteRows = False
        Me.dgv_Data.AllowUserToResizeRows = False
        Me.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeDate, Me.mSecs, Me.mSecsAcq, Me.DataPointsSinceConnection, Me.DTPressure, Me.TFPressure, Me.DiffPressure})
        Me.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Data.Location = New System.Drawing.Point(3, 3)
        Me.dgv_Data.Name = "dgv_Data"
        Me.dgv_Data.ReadOnly = True
        Me.dgv_Data.Size = New System.Drawing.Size(1396, 235)
        Me.dgv_Data.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtBox_Hyperterminal)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1385, 241)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Hyperterminal"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtBox_Hyperterminal
        '
        Me.txtBox_Hyperterminal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBox_Hyperterminal.Location = New System.Drawing.Point(3, 3)
        Me.txtBox_Hyperterminal.Multiline = True
        Me.txtBox_Hyperterminal.Name = "txtBox_Hyperterminal"
        Me.txtBox_Hyperterminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBox_Hyperterminal.Size = New System.Drawing.Size(1379, 235)
        Me.txtBox_Hyperterminal.TabIndex = 0
        '
        'comboBox_SerialPorts
        '
        Me.comboBox_SerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox_SerialPorts.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.comboBox_SerialPorts.FormattingEnabled = True
        Me.comboBox_SerialPorts.Location = New System.Drawing.Point(261, 12)
        Me.comboBox_SerialPorts.Name = "comboBox_SerialPorts"
        Me.comboBox_SerialPorts.Size = New System.Drawing.Size(173, 48)
        Me.comboBox_SerialPorts.TabIndex = 1
        '
        'num_DataPoints
        '
        Me.num_DataPoints.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.num_DataPoints.Location = New System.Drawing.Point(757, 12)
        Me.num_DataPoints.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.num_DataPoints.Minimum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.num_DataPoints.Name = "num_DataPoints"
        Me.num_DataPoints.Size = New System.Drawing.Size(105, 48)
        Me.num_DataPoints.TabIndex = 2
        Me.num_DataPoints.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lbl_DataPoints
        '
        Me.lbl_DataPoints.AutoSize = True
        Me.lbl_DataPoints.Font = New System.Drawing.Font("Arial monospaced for SAP", 15.0!)
        Me.lbl_DataPoints.Location = New System.Drawing.Point(449, 23)
        Me.lbl_DataPoints.Name = "lbl_DataPoints"
        Me.lbl_DataPoints.Size = New System.Drawing.Size(298, 23)
        Me.lbl_DataPoints.TabIndex = 25
        Me.lbl_DataPoints.Text = "Data Readings to Process"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.0!)
        Me.TabControl2.Location = New System.Drawing.Point(12, 120)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1410, 381)
        Me.TabControl2.TabIndex = 26
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.lbl_PercentSign)
        Me.TabPage4.Controls.Add(Me.lbl_Delta_RSD)
        Me.TabPage4.Controls.Add(Me.lbl_DT_RSD)
        Me.TabPage4.Controls.Add(Me.lbl_TF_RSD)
        Me.TabPage4.Controls.Add(Me.lbl_mTorr)
        Me.TabPage4.Controls.Add(Me.lbl_Delta_SD)
        Me.TabPage4.Controls.Add(Me.lbl_DT_SD)
        Me.TabPage4.Controls.Add(Me.lbl_TF_SD)
        Me.TabPage4.Controls.Add(Me.lbl_PlusMinus)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.lbl_DeltaPressure)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.lbl_TFPressure)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.lbl_DTPressure)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1402, 348)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Measure"
        '
        'lbl_PercentSign
        '
        Me.lbl_PercentSign.AutoSize = True
        Me.lbl_PercentSign.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.lbl_PercentSign.Location = New System.Drawing.Point(1348, 157)
        Me.lbl_PercentSign.Name = "lbl_PercentSign"
        Me.lbl_PercentSign.Size = New System.Drawing.Size(38, 40)
        Me.lbl_PercentSign.TabIndex = 55
        Me.lbl_PercentSign.Text = "%"
        Me.lbl_PercentSign.Visible = False
        '
        'lbl_Delta_RSD
        '
        Me.lbl_Delta_RSD.AutoSize = True
        Me.lbl_Delta_RSD.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_Delta_RSD.Location = New System.Drawing.Point(1072, 238)
        Me.lbl_Delta_RSD.Name = "lbl_Delta_RSD"
        Me.lbl_Delta_RSD.Size = New System.Drawing.Size(297, 98)
        Me.lbl_Delta_RSD.TabIndex = 54
        Me.lbl_Delta_RSD.Text = "1.800"
        Me.lbl_Delta_RSD.Visible = False
        '
        'lbl_DT_RSD
        '
        Me.lbl_DT_RSD.AutoSize = True
        Me.lbl_DT_RSD.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_DT_RSD.Location = New System.Drawing.Point(1072, 18)
        Me.lbl_DT_RSD.Name = "lbl_DT_RSD"
        Me.lbl_DT_RSD.Size = New System.Drawing.Size(297, 98)
        Me.lbl_DT_RSD.TabIndex = 53
        Me.lbl_DT_RSD.Text = "0.030"
        Me.lbl_DT_RSD.Visible = False
        '
        'lbl_TF_RSD
        '
        Me.lbl_TF_RSD.AutoSize = True
        Me.lbl_TF_RSD.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_TF_RSD.Location = New System.Drawing.Point(1072, 128)
        Me.lbl_TF_RSD.Name = "lbl_TF_RSD"
        Me.lbl_TF_RSD.Size = New System.Drawing.Size(297, 98)
        Me.lbl_TF_RSD.TabIndex = 52
        Me.lbl_TF_RSD.Text = "0.030"
        Me.lbl_TF_RSD.Visible = False
        '
        'lbl_mTorr
        '
        Me.lbl_mTorr.AutoSize = True
        Me.lbl_mTorr.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.lbl_mTorr.Location = New System.Drawing.Point(953, 157)
        Me.lbl_mTorr.Name = "lbl_mTorr"
        Me.lbl_mTorr.Size = New System.Drawing.Size(122, 40)
        Me.lbl_mTorr.TabIndex = 51
        Me.lbl_mTorr.Text = "mTorr"
        Me.lbl_mTorr.Visible = False
        '
        'lbl_Delta_SD
        '
        Me.lbl_Delta_SD.AutoSize = True
        Me.lbl_Delta_SD.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_Delta_SD.Location = New System.Drawing.Point(749, 238)
        Me.lbl_Delta_SD.Name = "lbl_Delta_SD"
        Me.lbl_Delta_SD.Size = New System.Drawing.Size(195, 98)
        Me.lbl_Delta_SD.TabIndex = 50
        Me.lbl_Delta_SD.Text = "2.7"
        Me.lbl_Delta_SD.Visible = False
        '
        'lbl_DT_SD
        '
        Me.lbl_DT_SD.AutoSize = True
        Me.lbl_DT_SD.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_DT_SD.Location = New System.Drawing.Point(749, 18)
        Me.lbl_DT_SD.Name = "lbl_DT_SD"
        Me.lbl_DT_SD.Size = New System.Drawing.Size(195, 98)
        Me.lbl_DT_SD.TabIndex = 49
        Me.lbl_DT_SD.Text = "1.2"
        Me.lbl_DT_SD.Visible = False
        '
        'lbl_TF_SD
        '
        Me.lbl_TF_SD.AutoSize = True
        Me.lbl_TF_SD.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_TF_SD.Location = New System.Drawing.Point(749, 128)
        Me.lbl_TF_SD.Name = "lbl_TF_SD"
        Me.lbl_TF_SD.Size = New System.Drawing.Size(195, 98)
        Me.lbl_TF_SD.TabIndex = 48
        Me.lbl_TF_SD.Text = "1.1"
        Me.lbl_TF_SD.Visible = False
        '
        'lbl_PlusMinus
        '
        Me.lbl_PlusMinus.AutoSize = True
        Me.lbl_PlusMinus.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.lbl_PlusMinus.Location = New System.Drawing.Point(577, 157)
        Me.lbl_PlusMinus.Name = "lbl_PlusMinus"
        Me.lbl_PlusMinus.Size = New System.Drawing.Size(101, 40)
        Me.lbl_PlusMinus.TabIndex = 47
        Me.lbl_PlusMinus.Text = "Torr"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 97)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "∆"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_DeltaPressure
        '
        Me.lbl_DeltaPressure.AutoSize = True
        Me.lbl_DeltaPressure.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_DeltaPressure.Location = New System.Drawing.Point(221, 238)
        Me.lbl_DeltaPressure.Name = "lbl_DeltaPressure"
        Me.lbl_DeltaPressure.Size = New System.Drawing.Size(348, 98)
        Me.lbl_DeltaPressure.TabIndex = 45
        Me.lbl_DeltaPressure.Text = "0.0000"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 97)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Trap Funnel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_TFPressure
        '
        Me.lbl_TFPressure.AutoSize = True
        Me.lbl_TFPressure.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_TFPressure.Location = New System.Drawing.Point(220, 128)
        Me.lbl_TFPressure.Name = "lbl_TFPressure"
        Me.lbl_TFPressure.Size = New System.Drawing.Size(348, 98)
        Me.lbl_TFPressure.TabIndex = 43
        Me.lbl_TFPressure.Text = "0.0000"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 97)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Drift Tube"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_DTPressure
        '
        Me.lbl_DTPressure.AutoSize = True
        Me.lbl_DTPressure.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_DTPressure.Location = New System.Drawing.Point(220, 18)
        Me.lbl_DTPressure.Name = "lbl_DTPressure"
        Me.lbl_DTPressure.Size = New System.Drawing.Size(348, 98)
        Me.lbl_DTPressure.TabIndex = 41
        Me.lbl_DTPressure.Text = "0.0000"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Controls.Add(Me.GroupBox1)
        Me.TabPage5.Font = New System.Drawing.Font("Arial monospaced for SAP", 15.0!)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1389, 348)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Setpoints"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.txtBox_TF_Leak_Setpoint)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtBox_DT_Leak_Setpoint)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(1103, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 338)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Leak Test"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label35.Location = New System.Drawing.Point(135, 148)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 17)
        Me.Label35.TabIndex = 47
        Me.Label35.Text = "mTorr"
        '
        'txtBox_TF_Leak_Setpoint
        '
        Me.txtBox_TF_Leak_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_TF_Leak_Setpoint.Location = New System.Drawing.Point(29, 145)
        Me.txtBox_TF_Leak_Setpoint.Name = "txtBox_TF_Leak_Setpoint"
        Me.txtBox_TF_Leak_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_TF_Leak_Setpoint.TabIndex = 1
        Me.txtBox_TF_Leak_Setpoint.Text = "50"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label36.Location = New System.Drawing.Point(6, 148)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(17, 17)
        Me.Label36.TabIndex = 45
        Me.Label36.Text = "≤"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label33.Location = New System.Drawing.Point(135, 66)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 17)
        Me.Label33.TabIndex = 44
        Me.Label33.Text = "mTorr"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Drift Tube:"
        '
        'txtBox_DT_Leak_Setpoint
        '
        Me.txtBox_DT_Leak_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_DT_Leak_Setpoint.Location = New System.Drawing.Point(29, 63)
        Me.txtBox_DT_Leak_Setpoint.Name = "txtBox_DT_Leak_Setpoint"
        Me.txtBox_DT_Leak_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_DT_Leak_Setpoint.TabIndex = 0
        Me.txtBox_DT_Leak_Setpoint.Text = "50"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(6, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Trap Funnel:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label34.Location = New System.Drawing.Point(6, 66)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(17, 17)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "≤"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtBox_Delta_Error_Setpoint)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtBox_TF_Error_Setpoint)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.txtBox_DT_Error_Setpoint)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.radBtn_Delta)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtBox_Delta_Value_Setpoint)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.radBtn_TF)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtBox_TF_RSD_Setpoint)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtBox_TF_SD_Setpoint)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtBox_TF_Value_Setpoint)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.radBtn_DT)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtBox_DT_RSD_Setpoint)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtBox_DT_SD_Setpoint)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtBox_DT_Value_Setpoint)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial monospaced for SAP", 13.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1091, 335)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Analysis"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label31.Location = New System.Drawing.Point(571, 230)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 17)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "mTorr"
        '
        'txtBox_Delta_Error_Setpoint
        '
        Me.txtBox_Delta_Error_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_Delta_Error_Setpoint.Location = New System.Drawing.Point(465, 227)
        Me.txtBox_Delta_Error_Setpoint.Name = "txtBox_Delta_Error_Setpoint"
        Me.txtBox_Delta_Error_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_Delta_Error_Setpoint.TabIndex = 9
        Me.txtBox_Delta_Error_Setpoint.Text = "30"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label32.Location = New System.Drawing.Point(397, 230)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(62, 17)
        Me.Label32.TabIndex = 39
        Me.Label32.Text = "Error:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label29.Location = New System.Drawing.Point(571, 148)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 17)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "mTorr"
        '
        'txtBox_TF_Error_Setpoint
        '
        Me.txtBox_TF_Error_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_TF_Error_Setpoint.Location = New System.Drawing.Point(465, 145)
        Me.txtBox_TF_Error_Setpoint.Name = "txtBox_TF_Error_Setpoint"
        Me.txtBox_TF_Error_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_TF_Error_Setpoint.TabIndex = 5
        Me.txtBox_TF_Error_Setpoint.Text = "30"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label30.Location = New System.Drawing.Point(397, 148)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(62, 17)
        Me.Label30.TabIndex = 36
        Me.Label30.Text = "Error:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label28.Location = New System.Drawing.Point(571, 66)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 17)
        Me.Label28.TabIndex = 35
        Me.Label28.Text = "mTorr"
        '
        'txtBox_DT_Error_Setpoint
        '
        Me.txtBox_DT_Error_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_DT_Error_Setpoint.Location = New System.Drawing.Point(465, 63)
        Me.txtBox_DT_Error_Setpoint.Name = "txtBox_DT_Error_Setpoint"
        Me.txtBox_DT_Error_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_DT_Error_Setpoint.TabIndex = 1
        Me.txtBox_DT_Error_Setpoint.Text = "30"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label27.Location = New System.Drawing.Point(397, 66)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 17)
        Me.Label27.TabIndex = 33
        Me.Label27.Text = "Error:"
        '
        'radBtn_Delta
        '
        Me.radBtn_Delta.AutoSize = True
        Me.radBtn_Delta.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.radBtn_Delta.Location = New System.Drawing.Point(9, 228)
        Me.radBtn_Delta.Name = "radBtn_Delta"
        Me.radBtn_Delta.Size = New System.Drawing.Size(107, 21)
        Me.radBtn_Delta.TabIndex = 32
        Me.radBtn_Delta.Text = "Fix Delta"
        Me.radBtn_Delta.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label23.Location = New System.Drawing.Point(323, 230)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 17)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Torr"
        '
        'txtBox_Delta_Value_Setpoint
        '
        Me.txtBox_Delta_Value_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_Delta_Value_Setpoint.Location = New System.Drawing.Point(217, 227)
        Me.txtBox_Delta_Value_Setpoint.Name = "txtBox_Delta_Value_Setpoint"
        Me.txtBox_Delta_Value_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_Delta_Value_Setpoint.TabIndex = 8
        Me.txtBox_Delta_Value_Setpoint.Text = "0.1500"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label26.Location = New System.Drawing.Point(130, 230)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(89, 17)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "Setpoint:"
        '
        'radBtn_TF
        '
        Me.radBtn_TF.AutoSize = True
        Me.radBtn_TF.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.radBtn_TF.Location = New System.Drawing.Point(9, 146)
        Me.radBtn_TF.Name = "radBtn_TF"
        Me.radBtn_TF.Size = New System.Drawing.Size(80, 21)
        Me.radBtn_TF.TabIndex = 22
        Me.radBtn_TF.Text = "Fix TF"
        Me.radBtn_TF.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label15.Location = New System.Drawing.Point(1045, 148)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "%"
        '
        'txtBox_TF_RSD_Setpoint
        '
        Me.txtBox_TF_RSD_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_TF_RSD_Setpoint.Location = New System.Drawing.Point(939, 145)
        Me.txtBox_TF_RSD_Setpoint.Name = "txtBox_TF_RSD_Setpoint"
        Me.txtBox_TF_RSD_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_TF_RSD_Setpoint.TabIndex = 7
        Me.txtBox_TF_RSD_Setpoint.Text = "0.03"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label16.Location = New System.Drawing.Point(808, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 17)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "mTorr"
        '
        'txtBox_TF_SD_Setpoint
        '
        Me.txtBox_TF_SD_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_TF_SD_Setpoint.Location = New System.Drawing.Point(702, 145)
        Me.txtBox_TF_SD_Setpoint.Name = "txtBox_TF_SD_Setpoint"
        Me.txtBox_TF_SD_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_TF_SD_Setpoint.TabIndex = 6
        Me.txtBox_TF_SD_Setpoint.Text = "1.14"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label17.Location = New System.Drawing.Point(323, 148)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 17)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Torr"
        '
        'txtBox_TF_Value_Setpoint
        '
        Me.txtBox_TF_Value_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_TF_Value_Setpoint.Location = New System.Drawing.Point(217, 145)
        Me.txtBox_TF_Value_Setpoint.Name = "txtBox_TF_Value_Setpoint"
        Me.txtBox_TF_Value_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_TF_Value_Setpoint.TabIndex = 4
        Me.txtBox_TF_Value_Setpoint.Text = "3.8000"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label18.Location = New System.Drawing.Point(889, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 17)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "RSD:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label19.Location = New System.Drawing.Point(661, 148)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 17)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "SD:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label20.Location = New System.Drawing.Point(130, 148)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 17)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Setpoint:"
        '
        'radBtn_DT
        '
        Me.radBtn_DT.AutoSize = True
        Me.radBtn_DT.Checked = True
        Me.radBtn_DT.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.radBtn_DT.Location = New System.Drawing.Point(9, 64)
        Me.radBtn_DT.Name = "radBtn_DT"
        Me.radBtn_DT.Size = New System.Drawing.Size(80, 21)
        Me.radBtn_DT.TabIndex = 12
        Me.radBtn_DT.TabStop = True
        Me.radBtn_DT.Text = "Fix DT"
        Me.radBtn_DT.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label14.Location = New System.Drawing.Point(1045, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "%"
        '
        'txtBox_DT_RSD_Setpoint
        '
        Me.txtBox_DT_RSD_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_DT_RSD_Setpoint.Location = New System.Drawing.Point(939, 63)
        Me.txtBox_DT_RSD_Setpoint.Name = "txtBox_DT_RSD_Setpoint"
        Me.txtBox_DT_RSD_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_DT_RSD_Setpoint.TabIndex = 3
        Me.txtBox_DT_RSD_Setpoint.Text = "0.03"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(808, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 17)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "mTorr"
        '
        'txtBox_DT_SD_Setpoint
        '
        Me.txtBox_DT_SD_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_DT_SD_Setpoint.Location = New System.Drawing.Point(702, 63)
        Me.txtBox_DT_SD_Setpoint.Name = "txtBox_DT_SD_Setpoint"
        Me.txtBox_DT_SD_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_DT_SD_Setpoint.TabIndex = 2
        Me.txtBox_DT_SD_Setpoint.Text = "1.19"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label12.Location = New System.Drawing.Point(323, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 17)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Torr"
        '
        'txtBox_DT_Value_Setpoint
        '
        Me.txtBox_DT_Value_Setpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.txtBox_DT_Value_Setpoint.Location = New System.Drawing.Point(217, 63)
        Me.txtBox_DT_Value_Setpoint.Name = "txtBox_DT_Value_Setpoint"
        Me.txtBox_DT_Value_Setpoint.Size = New System.Drawing.Size(100, 24)
        Me.txtBox_DT_Value_Setpoint.TabIndex = 0
        Me.txtBox_DT_Value_Setpoint.Text = "3.9500"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(889, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 17)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "RSD:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(661, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "SD:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(130, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Setpoint:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Drift Tube:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Delta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial monospaced for SAP", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Trap Funnel:"
        '
        'lbl_SecsConverter
        '
        Me.lbl_SecsConverter.AutoSize = True
        Me.lbl_SecsConverter.Font = New System.Drawing.Font("Arial monospaced for SAP", 15.0!)
        Me.lbl_SecsConverter.Location = New System.Drawing.Point(868, 23)
        Me.lbl_SecsConverter.Name = "lbl_SecsConverter"
        Me.lbl_SecsConverter.Size = New System.Drawing.Size(178, 23)
        Me.lbl_SecsConverter.TabIndex = 27
        Me.lbl_SecsConverter.Text = "Approx. 5 mins"
        '
        'chkBox_LeakTest
        '
        Me.chkBox_LeakTest.AutoSize = True
        Me.chkBox_LeakTest.Font = New System.Drawing.Font("Arial monospaced for SAP", 15.0!)
        Me.chkBox_LeakTest.Location = New System.Drawing.Point(1285, 22)
        Me.chkBox_LeakTest.Name = "chkBox_LeakTest"
        Me.chkBox_LeakTest.Size = New System.Drawing.Size(137, 27)
        Me.chkBox_LeakTest.TabIndex = 3
        Me.chkBox_LeakTest.Text = "Leak Test"
        Me.chkBox_LeakTest.UseVisualStyleBackColor = True
        '
        'lbl_Atribution
        '
        Me.lbl_Atribution.AutoSize = True
        Me.lbl_Atribution.Location = New System.Drawing.Point(12, 786)
        Me.lbl_Atribution.Name = "lbl_Atribution"
        Me.lbl_Atribution.Size = New System.Drawing.Size(113, 13)
        Me.lbl_Atribution.TabIndex = 30
        Me.lbl_Atribution.TabStop = True
        Me.lbl_Atribution.Text = "Attribution Placeholder"
        '
        'lbl_Developer
        '
        Me.lbl_Developer.Location = New System.Drawing.Point(955, 786)
        Me.lbl_Developer.Name = "lbl_Developer"
        Me.lbl_Developer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_Developer.Size = New System.Drawing.Size(447, 13)
        Me.lbl_Developer.TabIndex = 31
        Me.lbl_Developer.TabStop = True
        Me.lbl_Developer.Text = "Developer Placeholder"
        Me.lbl_Developer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_AcquisitionStartStop
        '
        Me.btn_AcquisitionStartStop.Enabled = False
        Me.btn_AcquisitionStartStop.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.btn_AcquisitionStartStop.Location = New System.Drawing.Point(12, 66)
        Me.btn_AcquisitionStartStop.Name = "btn_AcquisitionStartStop"
        Me.btn_AcquisitionStartStop.Size = New System.Drawing.Size(422, 48)
        Me.btn_AcquisitionStartStop.TabIndex = 32
        Me.btn_AcquisitionStartStop.Text = "Start Acquisition"
        Me.btn_AcquisitionStartStop.UseVisualStyleBackColor = True
        '
        'TimeDate
        '
        Me.TimeDate.HeaderText = "Date & Time"
        Me.TimeDate.Name = "TimeDate"
        Me.TimeDate.ReadOnly = True
        Me.TimeDate.Width = 200
        '
        'mSecs
        '
        Me.mSecs.HeaderText = "Time Since Program Start (mSeconds)"
        Me.mSecs.Name = "mSecs"
        Me.mSecs.ReadOnly = True
        Me.mSecs.Width = 150
        '
        'mSecsAcq
        '
        Me.mSecsAcq.HeaderText = "Time Since Acq Start"
        Me.mSecsAcq.Name = "mSecsAcq"
        Me.mSecsAcq.ReadOnly = True
        Me.mSecsAcq.Width = 150
        '
        'DataPointsSinceConnection
        '
        Me.DataPointsSinceConnection.HeaderText = "Data Points Since Connection"
        Me.DataPointsSinceConnection.Name = "DataPointsSinceConnection"
        Me.DataPointsSinceConnection.ReadOnly = True
        Me.DataPointsSinceConnection.Width = 150
        '
        'DTPressure
        '
        Me.DTPressure.HeaderText = "Drift Tube Pressure"
        Me.DTPressure.Name = "DTPressure"
        Me.DTPressure.ReadOnly = True
        Me.DTPressure.Width = 150
        '
        'TFPressure
        '
        Me.TFPressure.HeaderText = "Trap Funnel Pressure"
        Me.TFPressure.Name = "TFPressure"
        Me.TFPressure.ReadOnly = True
        Me.TFPressure.Width = 150
        '
        'DiffPressure
        '
        Me.DiffPressure.HeaderText = "Delta Pressure"
        Me.DiffPressure.Name = "DiffPressure"
        Me.DiffPressure.ReadOnly = True
        Me.DiffPressure.Width = 150
        '
        'frmMain
        '
        Me.AcceptButton = Me.btn_Connection
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1434, 812)
        Me.Controls.Add(Me.btn_AcquisitionStartStop)
        Me.Controls.Add(Me.lbl_Developer)
        Me.Controls.Add(Me.lbl_Atribution)
        Me.Controls.Add(Me.chkBox_LeakTest)
        Me.Controls.Add(Me.lbl_SecsConverter)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.lbl_DataPoints)
        Me.Controls.Add(Me.num_DataPoints)
        Me.Controls.Add(Me.comboBox_SerialPorts)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_Connection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1450, 850)
        Me.MinimumSize = New System.Drawing.Size(1450, 850)
        Me.Name = "frmMain"
        Me.Text = "Under Pressure - Drift Tube Pressure Monitor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.chart_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.num_DataPoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Connection As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chart_Data As DataVisualization.Charting.Chart
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_Data As DataGridView
    Friend WithEvents comboBox_SerialPorts As ComboBox
    Friend WithEvents num_DataPoints As NumericUpDown
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtBox_Hyperterminal As TextBox
    Friend WithEvents lbl_DataPoints As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lbl_PercentSign As Label
    Friend WithEvents lbl_Delta_RSD As Label
    Friend WithEvents lbl_DT_RSD As Label
    Friend WithEvents lbl_TF_RSD As Label
    Friend WithEvents lbl_mTorr As Label
    Friend WithEvents lbl_Delta_SD As Label
    Friend WithEvents lbl_DT_SD As Label
    Friend WithEvents lbl_TF_SD As Label
    Friend WithEvents lbl_PlusMinus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_DeltaPressure As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_TFPressure As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_DTPressure As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lbl_SecsConverter As Label
    Friend WithEvents chkBox_LeakTest As CheckBox
    Friend WithEvents lbl_Atribution As LinkLabel
    Friend WithEvents lbl_Developer As LinkLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txtBox_TF_Leak_Setpoint As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtBox_DT_Leak_Setpoint As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtBox_Delta_Error_Setpoint As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtBox_TF_Error_Setpoint As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtBox_DT_Error_Setpoint As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents radBtn_Delta As RadioButton
    Friend WithEvents Label23 As Label
    Friend WithEvents txtBox_Delta_Value_Setpoint As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents radBtn_TF As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBox_TF_RSD_Setpoint As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBox_TF_SD_Setpoint As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBox_TF_Value_Setpoint As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents radBtn_DT As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBox_DT_RSD_Setpoint As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBox_DT_SD_Setpoint As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBox_DT_Value_Setpoint As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_AcquisitionStartStop As Button
    Friend WithEvents TimeDate As DataGridViewTextBoxColumn
    Friend WithEvents mSecs As DataGridViewTextBoxColumn
    Friend WithEvents mSecsAcq As DataGridViewTextBoxColumn
    Friend WithEvents DataPointsSinceConnection As DataGridViewTextBoxColumn
    Friend WithEvents DTPressure As DataGridViewTextBoxColumn
    Friend WithEvents TFPressure As DataGridViewTextBoxColumn
    Friend WithEvents DiffPressure As DataGridViewTextBoxColumn
End Class
