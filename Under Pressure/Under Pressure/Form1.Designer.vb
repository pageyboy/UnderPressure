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
        Me.btn_Connection = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_Data = New System.Windows.Forms.DataGridView()
        Me.TimeDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mSecs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataPointsSinceConnection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiffPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtBox_Hyperterminal = New System.Windows.Forms.TextBox()
        Me.comboBox_SerialPorts = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.num_DataPoints = New System.Windows.Forms.NumericUpDown()
        Me.lbl_DataPoints = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lbl_PercentSign = New System.Windows.Forms.Label()
        Me.lbl_Delta_RSD = New System.Windows.Forms.Label()
        Me.lbl_DT_RSD = New System.Windows.Forms.Label()
        Me.lbl_TF_RSD = New System.Windows.Forms.Label()
        Me.lbl_mTorr = New System.Windows.Forms.Label()
        Me.lbl_RangeDiff = New System.Windows.Forms.Label()
        Me.lbl_RangeDT = New System.Windows.Forms.Label()
        Me.lbl_RangeTF = New System.Windows.Forms.Label()
        Me.lbl_PlusMinus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_DeltaPressure = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_TFPressure = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_DTPressure = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lbl_dtRSDSetpoint = New System.Windows.Forms.Label()
        Me.lbl_tfRSDSetpoint = New System.Windows.Forms.Label()
        Me.lbl_DiffSetpoint = New System.Windows.Forms.Label()
        Me.txtBox_tfRSDSetpoint = New System.Windows.Forms.TextBox()
        Me.txtBox_dtRSDSetpoint = New System.Windows.Forms.TextBox()
        Me.txtBox_tfSetpoint = New System.Windows.Forms.TextBox()
        Me.txtBox_dtSetpoint = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_SecsConverter = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.num_DataPoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 454)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1367, 274)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1359, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Graphical"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1353, 242)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_Data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1359, 248)
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
        Me.dgv_Data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeDate, Me.mSecs, Me.DataPointsSinceConnection, Me.DTPressure, Me.TFPressure, Me.DiffPressure})
        Me.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Data.Location = New System.Drawing.Point(3, 3)
        Me.dgv_Data.Name = "dgv_Data"
        Me.dgv_Data.ReadOnly = True
        Me.dgv_Data.Size = New System.Drawing.Size(1353, 242)
        Me.dgv_Data.TabIndex = 0
        '
        'TimeDate
        '
        Me.TimeDate.HeaderText = "Date & Time"
        Me.TimeDate.Name = "TimeDate"
        Me.TimeDate.ReadOnly = True
        '
        'mSecs
        '
        Me.mSecs.HeaderText = "Time Since Program Start (mSeconds)"
        Me.mSecs.Name = "mSecs"
        Me.mSecs.ReadOnly = True
        Me.mSecs.Width = 200
        '
        'DataPointsSinceConnection
        '
        Me.DataPointsSinceConnection.HeaderText = "Data Points Since Connection"
        Me.DataPointsSinceConnection.Name = "DataPointsSinceConnection"
        Me.DataPointsSinceConnection.ReadOnly = True
        '
        'DTPressure
        '
        Me.DTPressure.HeaderText = "Drift Tube Pressure"
        Me.DTPressure.Name = "DTPressure"
        Me.DTPressure.ReadOnly = True
        '
        'TFPressure
        '
        Me.TFPressure.HeaderText = "Trap Funnel Pressure"
        Me.TFPressure.Name = "TFPressure"
        Me.TFPressure.ReadOnly = True
        '
        'DiffPressure
        '
        Me.DiffPressure.HeaderText = "Differential Pressure"
        Me.DiffPressure.Name = "DiffPressure"
        Me.DiffPressure.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtBox_Hyperterminal)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1359, 248)
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
        Me.txtBox_Hyperterminal.Size = New System.Drawing.Size(1353, 242)
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
        Me.comboBox_SerialPorts.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1247, 733)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Developed by Chris Page"
        '
        'num_DataPoints
        '
        Me.num_DataPoints.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.num_DataPoints.Location = New System.Drawing.Point(925, 13)
        Me.num_DataPoints.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.num_DataPoints.Minimum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.num_DataPoints.Name = "num_DataPoints"
        Me.num_DataPoints.Size = New System.Drawing.Size(105, 48)
        Me.num_DataPoints.TabIndex = 20
        Me.num_DataPoints.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lbl_DataPoints
        '
        Me.lbl_DataPoints.AutoSize = True
        Me.lbl_DataPoints.Font = New System.Drawing.Font("Arial monospaced for SAP", 15.0!)
        Me.lbl_DataPoints.Location = New System.Drawing.Point(617, 24)
        Me.lbl_DataPoints.Name = "lbl_DataPoints"
        Me.lbl_DataPoints.Size = New System.Drawing.Size(298, 23)
        Me.lbl_DataPoints.TabIndex = 25
        Me.lbl_DataPoints.Text = "Data Readings to Process"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(12, 67)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1363, 381)
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
        Me.TabPage4.Controls.Add(Me.lbl_RangeDiff)
        Me.TabPage4.Controls.Add(Me.lbl_RangeDT)
        Me.TabPage4.Controls.Add(Me.lbl_RangeTF)
        Me.TabPage4.Controls.Add(Me.lbl_PlusMinus)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.lbl_DeltaPressure)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.lbl_TFPressure)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.lbl_DTPressure)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1355, 355)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Measure"
        '
        'lbl_PercentSign
        '
        Me.lbl_PercentSign.AutoSize = True
        Me.lbl_PercentSign.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.lbl_PercentSign.Location = New System.Drawing.Point(1308, 157)
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
        Me.lbl_Delta_RSD.Size = New System.Drawing.Size(246, 98)
        Me.lbl_Delta_RSD.TabIndex = 54
        Me.lbl_Delta_RSD.Text = "1.80"
        Me.lbl_Delta_RSD.Visible = False
        '
        'lbl_DT_RSD
        '
        Me.lbl_DT_RSD.AutoSize = True
        Me.lbl_DT_RSD.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_DT_RSD.Location = New System.Drawing.Point(1072, 18)
        Me.lbl_DT_RSD.Name = "lbl_DT_RSD"
        Me.lbl_DT_RSD.Size = New System.Drawing.Size(246, 98)
        Me.lbl_DT_RSD.TabIndex = 53
        Me.lbl_DT_RSD.Text = "0.03"
        Me.lbl_DT_RSD.Visible = False
        '
        'lbl_TF_RSD
        '
        Me.lbl_TF_RSD.AutoSize = True
        Me.lbl_TF_RSD.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_TF_RSD.Location = New System.Drawing.Point(1072, 128)
        Me.lbl_TF_RSD.Name = "lbl_TF_RSD"
        Me.lbl_TF_RSD.Size = New System.Drawing.Size(246, 98)
        Me.lbl_TF_RSD.TabIndex = 52
        Me.lbl_TF_RSD.Text = "0.03"
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
        'lbl_RangeDiff
        '
        Me.lbl_RangeDiff.AutoSize = True
        Me.lbl_RangeDiff.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_RangeDiff.Location = New System.Drawing.Point(749, 238)
        Me.lbl_RangeDiff.Name = "lbl_RangeDiff"
        Me.lbl_RangeDiff.Size = New System.Drawing.Size(195, 98)
        Me.lbl_RangeDiff.TabIndex = 50
        Me.lbl_RangeDiff.Text = "2.7"
        Me.lbl_RangeDiff.Visible = False
        '
        'lbl_RangeDT
        '
        Me.lbl_RangeDT.AutoSize = True
        Me.lbl_RangeDT.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_RangeDT.Location = New System.Drawing.Point(749, 18)
        Me.lbl_RangeDT.Name = "lbl_RangeDT"
        Me.lbl_RangeDT.Size = New System.Drawing.Size(195, 98)
        Me.lbl_RangeDT.TabIndex = 49
        Me.lbl_RangeDT.Text = "1.2"
        Me.lbl_RangeDT.Visible = False
        '
        'lbl_RangeTF
        '
        Me.lbl_RangeTF.AutoSize = True
        Me.lbl_RangeTF.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_RangeTF.Location = New System.Drawing.Point(749, 128)
        Me.lbl_RangeTF.Name = "lbl_RangeTF"
        Me.lbl_RangeTF.Size = New System.Drawing.Size(195, 98)
        Me.lbl_RangeTF.TabIndex = 48
        Me.lbl_RangeTF.Text = "1.1"
        Me.lbl_RangeTF.Visible = False
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
        Me.lbl_DeltaPressure.Text = "0.1500"
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
        Me.lbl_TFPressure.Text = "3.8000"
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
        Me.lbl_DTPressure.Text = "3.9500"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.lbl_dtRSDSetpoint)
        Me.TabPage5.Controls.Add(Me.lbl_tfRSDSetpoint)
        Me.TabPage5.Controls.Add(Me.lbl_DiffSetpoint)
        Me.TabPage5.Controls.Add(Me.txtBox_tfRSDSetpoint)
        Me.TabPage5.Controls.Add(Me.txtBox_dtRSDSetpoint)
        Me.TabPage5.Controls.Add(Me.txtBox_tfSetpoint)
        Me.TabPage5.Controls.Add(Me.txtBox_dtSetpoint)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1355, 355)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Setpoints"
        '
        'lbl_dtRSDSetpoint
        '
        Me.lbl_dtRSDSetpoint.AutoSize = True
        Me.lbl_dtRSDSetpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_dtRSDSetpoint.Location = New System.Drawing.Point(749, 18)
        Me.lbl_dtRSDSetpoint.Name = "lbl_dtRSDSetpoint"
        Me.lbl_dtRSDSetpoint.Size = New System.Drawing.Size(195, 98)
        Me.lbl_dtRSDSetpoint.TabIndex = 66
        Me.lbl_dtRSDSetpoint.Text = "1.2"
        '
        'lbl_tfRSDSetpoint
        '
        Me.lbl_tfRSDSetpoint.AutoSize = True
        Me.lbl_tfRSDSetpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_tfRSDSetpoint.Location = New System.Drawing.Point(749, 128)
        Me.lbl_tfRSDSetpoint.Name = "lbl_tfRSDSetpoint"
        Me.lbl_tfRSDSetpoint.Size = New System.Drawing.Size(195, 98)
        Me.lbl_tfRSDSetpoint.TabIndex = 65
        Me.lbl_tfRSDSetpoint.Text = "1.1"
        '
        'lbl_DiffSetpoint
        '
        Me.lbl_DiffSetpoint.AutoSize = True
        Me.lbl_DiffSetpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!)
        Me.lbl_DiffSetpoint.Location = New System.Drawing.Point(221, 238)
        Me.lbl_DiffSetpoint.Name = "lbl_DiffSetpoint"
        Me.lbl_DiffSetpoint.Size = New System.Drawing.Size(348, 98)
        Me.lbl_DiffSetpoint.TabIndex = 64
        Me.lbl_DiffSetpoint.Text = "0.1500"
        '
        'txtBox_tfRSDSetpoint
        '
        Me.txtBox_tfRSDSetpoint.BackColor = System.Drawing.SystemColors.Control
        Me.txtBox_tfRSDSetpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_tfRSDSetpoint.Location = New System.Drawing.Point(1086, 125)
        Me.txtBox_tfRSDSetpoint.Name = "txtBox_tfRSDSetpoint"
        Me.txtBox_tfRSDSetpoint.Size = New System.Drawing.Size(216, 105)
        Me.txtBox_tfRSDSetpoint.TabIndex = 63
        Me.txtBox_tfRSDSetpoint.Text = "0.03"
        '
        'txtBox_dtRSDSetpoint
        '
        Me.txtBox_dtRSDSetpoint.BackColor = System.Drawing.SystemColors.Control
        Me.txtBox_dtRSDSetpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_dtRSDSetpoint.Location = New System.Drawing.Point(1086, 15)
        Me.txtBox_dtRSDSetpoint.Name = "txtBox_dtRSDSetpoint"
        Me.txtBox_dtRSDSetpoint.Size = New System.Drawing.Size(216, 105)
        Me.txtBox_dtRSDSetpoint.TabIndex = 62
        Me.txtBox_dtRSDSetpoint.Text = "0.03"
        '
        'txtBox_tfSetpoint
        '
        Me.txtBox_tfSetpoint.BackColor = System.Drawing.SystemColors.Control
        Me.txtBox_tfSetpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_tfSetpoint.Location = New System.Drawing.Point(234, 125)
        Me.txtBox_tfSetpoint.Name = "txtBox_tfSetpoint"
        Me.txtBox_tfSetpoint.Size = New System.Drawing.Size(318, 105)
        Me.txtBox_tfSetpoint.TabIndex = 58
        Me.txtBox_tfSetpoint.Text = "3.8000"
        '
        'txtBox_dtSetpoint
        '
        Me.txtBox_dtSetpoint.BackColor = System.Drawing.SystemColors.Control
        Me.txtBox_dtSetpoint.Font = New System.Drawing.Font("Arial monospaced for SAP", 63.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_dtSetpoint.Location = New System.Drawing.Point(234, 15)
        Me.txtBox_dtSetpoint.Name = "txtBox_dtSetpoint"
        Me.txtBox_dtSetpoint.Size = New System.Drawing.Size(318, 105)
        Me.txtBox_dtSetpoint.TabIndex = 56
        Me.txtBox_dtSetpoint.Text = "3.9500"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.Label4.Location = New System.Drawing.Point(1308, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 40)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "%"
        Me.Label4.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.Label9.Location = New System.Drawing.Point(953, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 40)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "mTorr"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.Label13.Location = New System.Drawing.Point(577, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 40)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Torr"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 239)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(164, 97)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "∆"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 97)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Trap Funnel"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(164, 97)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Drift Tube"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SecsConverter
        '
        Me.lbl_SecsConverter.AutoSize = True
        Me.lbl_SecsConverter.Font = New System.Drawing.Font("Arial monospaced for SAP", 15.0!)
        Me.lbl_SecsConverter.Location = New System.Drawing.Point(1036, 24)
        Me.lbl_SecsConverter.Name = "lbl_SecsConverter"
        Me.lbl_SecsConverter.Size = New System.Drawing.Size(178, 23)
        Me.lbl_SecsConverter.TabIndex = 27
        Me.lbl_SecsConverter.Text = "Approx. 5 mins"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btn_Connection
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1391, 752)
        Me.Controls.Add(Me.lbl_SecsConverter)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.lbl_DataPoints)
        Me.Controls.Add(Me.num_DataPoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboBox_SerialPorts)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_Connection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Under Pressure - Drift Tube Pressure Monitor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.num_DataPoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Connection As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_Data As DataGridView
    Friend WithEvents comboBox_SerialPorts As ComboBox
    Friend WithEvents Label2 As Label
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
    Friend WithEvents lbl_RangeDiff As Label
    Friend WithEvents lbl_RangeDT As Label
    Friend WithEvents lbl_RangeTF As Label
    Friend WithEvents lbl_PlusMinus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_DeltaPressure As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_TFPressure As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_DTPressure As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBox_tfSetpoint As TextBox
    Friend WithEvents txtBox_dtSetpoint As TextBox
    Friend WithEvents txtBox_tfRSDSetpoint As TextBox
    Friend WithEvents txtBox_dtRSDSetpoint As TextBox
    Friend WithEvents lbl_DiffSetpoint As Label
    Friend WithEvents lbl_dtRSDSetpoint As Label
    Friend WithEvents lbl_tfRSDSetpoint As Label
    Friend WithEvents lbl_SecsConverter As Label
    Friend WithEvents TimeDate As DataGridViewTextBoxColumn
    Friend WithEvents mSecs As DataGridViewTextBoxColumn
    Friend WithEvents DataPointsSinceConnection As DataGridViewTextBoxColumn
    Friend WithEvents DTPressure As DataGridViewTextBoxColumn
    Friend WithEvents TFPressure As DataGridViewTextBoxColumn
    Friend WithEvents DiffPressure As DataGridViewTextBoxColumn
End Class
