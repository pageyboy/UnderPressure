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
        Me.lbl_DTPressure = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_TFPressure = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_DeltaPressure = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_Data = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtBox_Hyperterminal = New System.Windows.Forms.TextBox()
        Me.lbl_PlusMinus = New System.Windows.Forms.Label()
        Me.lbl_RangeTF = New System.Windows.Forms.Label()
        Me.lbl_RangeDT = New System.Windows.Forms.Label()
        Me.lbl_RangeDiff = New System.Windows.Forms.Label()
        Me.lbl_mTorr = New System.Windows.Forms.Label()
        Me.comboBox_SerialPorts = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.num_DataPoints = New System.Windows.Forms.NumericUpDown()
        Me.lbl_TF_RSD = New System.Windows.Forms.Label()
        Me.lbl_DT_RSD = New System.Windows.Forms.Label()
        Me.lbl_Delta_RSD = New System.Windows.Forms.Label()
        Me.lbl_PercentSign = New System.Windows.Forms.Label()
        Me.lbl_DataPoints = New System.Windows.Forms.Label()
        Me.TimeDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiffPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.num_DataPoints, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lbl_DTPressure
        '
        Me.lbl_DTPressure.AutoSize = True
        Me.lbl_DTPressure.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DTPressure.Location = New System.Drawing.Point(182, 106)
        Me.lbl_DTPressure.Name = "lbl_DTPressure"
        Me.lbl_DTPressure.Size = New System.Drawing.Size(395, 110)
        Me.lbl_DTPressure.TabIndex = 3
        Me.lbl_DTPressure.Text = "9.9999"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 97)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Drift Tube"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 97)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Trap Funnel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_TFPressure
        '
        Me.lbl_TFPressure.AutoSize = True
        Me.lbl_TFPressure.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TFPressure.Location = New System.Drawing.Point(182, 216)
        Me.lbl_TFPressure.Name = "lbl_TFPressure"
        Me.lbl_TFPressure.Size = New System.Drawing.Size(395, 110)
        Me.lbl_TFPressure.TabIndex = 6
        Me.lbl_TFPressure.Text = "9.9999"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 97)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "∆"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_DeltaPressure
        '
        Me.lbl_DeltaPressure.AutoSize = True
        Me.lbl_DeltaPressure.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DeltaPressure.Location = New System.Drawing.Point(182, 326)
        Me.lbl_DeltaPressure.Name = "lbl_DeltaPressure"
        Me.lbl_DeltaPressure.Size = New System.Drawing.Size(395, 110)
        Me.lbl_DeltaPressure.TabIndex = 8
        Me.lbl_DeltaPressure.Text = "9.9999"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 450)
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
        Me.dgv_Data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeDate, Me.DTPressure, Me.TFPressure, Me.DiffPressure})
        Me.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Data.Location = New System.Drawing.Point(3, 3)
        Me.dgv_Data.Name = "dgv_Data"
        Me.dgv_Data.ReadOnly = True
        Me.dgv_Data.Size = New System.Drawing.Size(1353, 242)
        Me.dgv_Data.TabIndex = 0
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
        'lbl_PlusMinus
        '
        Me.lbl_PlusMinus.AutoSize = True
        Me.lbl_PlusMinus.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.lbl_PlusMinus.Location = New System.Drawing.Point(583, 251)
        Me.lbl_PlusMinus.Name = "lbl_PlusMinus"
        Me.lbl_PlusMinus.Size = New System.Drawing.Size(101, 40)
        Me.lbl_PlusMinus.TabIndex = 12
        Me.lbl_PlusMinus.Text = "Torr"
        '
        'lbl_RangeTF
        '
        Me.lbl_RangeTF.AutoSize = True
        Me.lbl_RangeTF.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RangeTF.Location = New System.Drawing.Point(732, 216)
        Me.lbl_RangeTF.Name = "lbl_RangeTF"
        Me.lbl_RangeTF.Size = New System.Drawing.Size(221, 110)
        Me.lbl_RangeTF.TabIndex = 13
        Me.lbl_RangeTF.Text = "999"
        Me.lbl_RangeTF.Visible = False
        '
        'lbl_RangeDT
        '
        Me.lbl_RangeDT.AutoSize = True
        Me.lbl_RangeDT.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RangeDT.Location = New System.Drawing.Point(732, 106)
        Me.lbl_RangeDT.Name = "lbl_RangeDT"
        Me.lbl_RangeDT.Size = New System.Drawing.Size(221, 110)
        Me.lbl_RangeDT.TabIndex = 14
        Me.lbl_RangeDT.Text = "999"
        Me.lbl_RangeDT.Visible = False
        '
        'lbl_RangeDiff
        '
        Me.lbl_RangeDiff.AutoSize = True
        Me.lbl_RangeDiff.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RangeDiff.Location = New System.Drawing.Point(732, 326)
        Me.lbl_RangeDiff.Name = "lbl_RangeDiff"
        Me.lbl_RangeDiff.Size = New System.Drawing.Size(221, 110)
        Me.lbl_RangeDiff.TabIndex = 15
        Me.lbl_RangeDiff.Text = "999"
        Me.lbl_RangeDiff.Visible = False
        '
        'lbl_mTorr
        '
        Me.lbl_mTorr.AutoSize = True
        Me.lbl_mTorr.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.lbl_mTorr.Location = New System.Drawing.Point(959, 251)
        Me.lbl_mTorr.Name = "lbl_mTorr"
        Me.lbl_mTorr.Size = New System.Drawing.Size(122, 40)
        Me.lbl_mTorr.TabIndex = 17
        Me.lbl_mTorr.Text = "mTorr"
        Me.lbl_mTorr.Visible = False
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
        Me.Label2.Location = New System.Drawing.Point(1252, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Developed by Chris Page"
        '
        'num_DataPoints
        '
        Me.num_DataPoints.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.num_DataPoints.Location = New System.Drawing.Point(925, 13)
        Me.num_DataPoints.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.num_DataPoints.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.num_DataPoints.Name = "num_DataPoints"
        Me.num_DataPoints.Size = New System.Drawing.Size(87, 48)
        Me.num_DataPoints.TabIndex = 20
        Me.num_DataPoints.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lbl_TF_RSD
        '
        Me.lbl_TF_RSD.AutoSize = True
        Me.lbl_TF_RSD.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TF_RSD.Location = New System.Drawing.Point(1087, 216)
        Me.lbl_TF_RSD.Name = "lbl_TF_RSD"
        Me.lbl_TF_RSD.Size = New System.Drawing.Size(221, 110)
        Me.lbl_TF_RSD.TabIndex = 21
        Me.lbl_TF_RSD.Text = "999"
        Me.lbl_TF_RSD.Visible = False
        '
        'lbl_DT_RSD
        '
        Me.lbl_DT_RSD.AutoSize = True
        Me.lbl_DT_RSD.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DT_RSD.Location = New System.Drawing.Point(1087, 106)
        Me.lbl_DT_RSD.Name = "lbl_DT_RSD"
        Me.lbl_DT_RSD.Size = New System.Drawing.Size(221, 110)
        Me.lbl_DT_RSD.TabIndex = 22
        Me.lbl_DT_RSD.Text = "999"
        Me.lbl_DT_RSD.Visible = False
        '
        'lbl_Delta_RSD
        '
        Me.lbl_Delta_RSD.AutoSize = True
        Me.lbl_Delta_RSD.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Delta_RSD.Location = New System.Drawing.Point(1087, 326)
        Me.lbl_Delta_RSD.Name = "lbl_Delta_RSD"
        Me.lbl_Delta_RSD.Size = New System.Drawing.Size(221, 110)
        Me.lbl_Delta_RSD.TabIndex = 23
        Me.lbl_Delta_RSD.Text = "999"
        Me.lbl_Delta_RSD.Visible = False
        '
        'lbl_PercentSign
        '
        Me.lbl_PercentSign.AutoSize = True
        Me.lbl_PercentSign.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.lbl_PercentSign.Location = New System.Drawing.Point(1314, 251)
        Me.lbl_PercentSign.Name = "lbl_PercentSign"
        Me.lbl_PercentSign.Size = New System.Drawing.Size(38, 40)
        Me.lbl_PercentSign.TabIndex = 24
        Me.lbl_PercentSign.Text = "%"
        Me.lbl_PercentSign.Visible = False
        '
        'lbl_DataPoints
        '
        Me.lbl_DataPoints.AutoSize = True
        Me.lbl_DataPoints.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.lbl_DataPoints.Location = New System.Drawing.Point(440, 16)
        Me.lbl_DataPoints.Name = "lbl_DataPoints"
        Me.lbl_DataPoints.Size = New System.Drawing.Size(479, 40)
        Me.lbl_DataPoints.TabIndex = 25
        Me.lbl_DataPoints.Text = "Data Readings to Proc."
        '
        'TimeDate
        '
        Me.TimeDate.HeaderText = "Date & Time"
        Me.TimeDate.Name = "TimeDate"
        Me.TimeDate.ReadOnly = True
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
        'frmMain
        '
        Me.AcceptButton = Me.btn_Connection
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1391, 736)
        Me.Controls.Add(Me.lbl_DataPoints)
        Me.Controls.Add(Me.lbl_PercentSign)
        Me.Controls.Add(Me.lbl_Delta_RSD)
        Me.Controls.Add(Me.lbl_DT_RSD)
        Me.Controls.Add(Me.lbl_TF_RSD)
        Me.Controls.Add(Me.num_DataPoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboBox_SerialPorts)
        Me.Controls.Add(Me.lbl_mTorr)
        Me.Controls.Add(Me.lbl_RangeDiff)
        Me.Controls.Add(Me.lbl_RangeDT)
        Me.Controls.Add(Me.lbl_RangeTF)
        Me.Controls.Add(Me.lbl_PlusMinus)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_DeltaPressure)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_TFPressure)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_DTPressure)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Connection As Button
    Friend WithEvents lbl_DTPressure As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_TFPressure As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_DeltaPressure As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_Data As DataGridView
    Friend WithEvents lbl_PlusMinus As Label
    Friend WithEvents lbl_RangeTF As Label
    Friend WithEvents lbl_RangeDT As Label
    Friend WithEvents lbl_RangeDiff As Label
    Friend WithEvents lbl_mTorr As Label
    Friend WithEvents comboBox_SerialPorts As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents num_DataPoints As NumericUpDown
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtBox_Hyperterminal As TextBox
    Friend WithEvents lbl_TF_RSD As Label
    Friend WithEvents lbl_DT_RSD As Label
    Friend WithEvents lbl_Delta_RSD As Label
    Friend WithEvents lbl_PercentSign As Label
    Friend WithEvents lbl_DataPoints As Label
    Friend WithEvents TimeDate As DataGridViewTextBoxColumn
    Friend WithEvents DTPressure As DataGridViewTextBoxColumn
    Friend WithEvents TFPressure As DataGridViewTextBoxColumn
    Friend WithEvents DiffPressure As DataGridViewTextBoxColumn
End Class
