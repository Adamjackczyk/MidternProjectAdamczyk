<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpMeasurment = New System.Windows.Forms.GroupBox()
        Me.RBtnMetersToInches = New System.Windows.Forms.RadioButton()
        Me.RBtnInchtoMeter = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtEnter = New System.Windows.Forms.TextBox()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblShow = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMeasurment.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'grpMeasurment
        '
        Me.grpMeasurment.BackColor = System.Drawing.Color.Indigo
        Me.grpMeasurment.Controls.Add(Me.RBtnMetersToInches)
        Me.grpMeasurment.Controls.Add(Me.RBtnInchtoMeter)
        Me.grpMeasurment.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMeasurment.ForeColor = System.Drawing.Color.White
        Me.grpMeasurment.Location = New System.Drawing.Point(476, 166)
        Me.grpMeasurment.Name = "grpMeasurment"
        Me.grpMeasurment.Size = New System.Drawing.Size(248, 100)
        Me.grpMeasurment.TabIndex = 1
        Me.grpMeasurment.TabStop = False
        Me.grpMeasurment.Text = "Convert Measurement "
        '
        'RBtnMetersToInches
        '
        Me.RBtnMetersToInches.AutoSize = True
        Me.RBtnMetersToInches.Location = New System.Drawing.Point(24, 67)
        Me.RBtnMetersToInches.Name = "RBtnMetersToInches"
        Me.RBtnMetersToInches.Size = New System.Drawing.Size(153, 23)
        Me.RBtnMetersToInches.TabIndex = 1
        Me.RBtnMetersToInches.TabStop = True
        Me.RBtnMetersToInches.Text = "Meters to Inches"
        Me.RBtnMetersToInches.UseVisualStyleBackColor = True
        '
        'RBtnInchtoMeter
        '
        Me.RBtnInchtoMeter.AutoSize = True
        Me.RBtnInchtoMeter.Location = New System.Drawing.Point(24, 26)
        Me.RBtnInchtoMeter.Name = "RBtnInchtoMeter"
        Me.RBtnInchtoMeter.Size = New System.Drawing.Size(153, 23)
        Me.RBtnInchtoMeter.TabIndex = 0
        Me.RBtnInchtoMeter.TabStop = True
        Me.RBtnInchtoMeter.Text = "Inches to Meters"
        Me.RBtnInchtoMeter.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(73, 362)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(134, 49)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(316, 362)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 49)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtEnter
        '
        Me.txtEnter.BackColor = System.Drawing.Color.Indigo
        Me.txtEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnter.ForeColor = System.Drawing.Color.White
        Me.txtEnter.Location = New System.Drawing.Point(624, 94)
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(100, 27)
        Me.txtEnter.TabIndex = 4
        Me.txtEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.Location = New System.Drawing.Point(296, 28)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(274, 45)
        Me.lblHead.TabIndex = 5
        Me.lblHead.Text = "Converter App"
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnter.Location = New System.Drawing.Point(269, 92)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(315, 23)
        Me.lblEnter.TabIndex = 6
        Me.lblEnter.Text = "Enter a value and choose conversion"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(544, 362)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblShow
        '
        Me.lblShow.AutoSize = True
        Me.lblShow.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShow.Location = New System.Drawing.Point(449, 303)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(0, 23)
        Me.lblShow.TabIndex = 8
        '
        'Form1
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblShow)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.lblHead)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpMeasurment)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMeasurment.ResumeLayout(False)
        Me.grpMeasurment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpMeasurment As GroupBox
    Friend WithEvents RBtnMetersToInches As RadioButton
    Friend WithEvents RBtnInchtoMeter As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtEnter As TextBox
    Friend WithEvents lblHead As Label
    Friend WithEvents lblEnter As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblShow As Label
End Class
