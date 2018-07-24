<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_Test = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Connection
        '
        Me.btn_Connection.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.btn_Connection.Location = New System.Drawing.Point(12, 12)
        Me.btn_Connection.Name = "btn_Connection"
        Me.btn_Connection.Size = New System.Drawing.Size(243, 66)
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 450)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1176, 274)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1168, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Graphical"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1168, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(583, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 110)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "±"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(694, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(395, 110)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "9.9999"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(694, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(395, 110)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "9.9999"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial monospaced for SAP", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(694, 326)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(395, 110)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "9.9999"
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
        Me.Chart1.Size = New System.Drawing.Size(1162, 242)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1162, 242)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_Test
        '
        Me.btn_Test.Font = New System.Drawing.Font("Arial monospaced for SAP", 26.25!)
        Me.btn_Test.Location = New System.Drawing.Point(945, 12)
        Me.btn_Test.Name = "btn_Test"
        Me.btn_Test.Size = New System.Drawing.Size(243, 66)
        Me.btn_Test.TabIndex = 16
        Me.btn_Test.Text = "Test"
        Me.btn_Test.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 736)
        Me.Controls.Add(Me.btn_Test)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_DeltaPressure)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_TFPressure)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_DTPressure)
        Me.Controls.Add(Me.btn_Connection)
        Me.Name = "frmMain"
        Me.Text = "Under Pressure - Drift Tube Pressure Monitor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_Test As Button
End Class
