<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbMinimize = New System.Windows.Forms.PictureBox()
        Me.pbMazimize = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.imageBoxFrameGrabber = New Emgu.CV.UI.ImageBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ImageBox1 = New Emgu.CV.UI.ImageBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtBadge = New System.Windows.Forms.TextBox()
        Me.ImageBoxAddFace = New Emgu.CV.UI.ImageBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMazimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageBoxAddFace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.pbMinimize)
        Me.Panel1.Controls.Add(Me.pbMazimize)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(907, 31)
        Me.Panel1.TabIndex = 18
        '
        'pbMinimize
        '
        Me.pbMinimize.Image = Global.Aplikasi_Absensi_Wajah.My.Resources.Resources.minimize
        Me.pbMinimize.Location = New System.Drawing.Point(851, 2)
        Me.pbMinimize.Name = "pbMinimize"
        Me.pbMinimize.Size = New System.Drawing.Size(24, 26)
        Me.pbMinimize.TabIndex = 27
        Me.pbMinimize.TabStop = False
        '
        'pbMazimize
        '
        Me.pbMazimize.Image = Global.Aplikasi_Absensi_Wajah.My.Resources.Resources.cancel
        Me.pbMazimize.Location = New System.Drawing.Point(880, 2)
        Me.pbMazimize.Name = "pbMazimize"
        Me.pbMazimize.Size = New System.Drawing.Size(24, 26)
        Me.pbMazimize.TabIndex = 25
        Me.pbMazimize.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Digital-7", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(675, 2)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(73, 28)
        Me.lblTime.TabIndex = 26
        Me.lblTime.Text = "Time..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(274, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(309, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "APLIKASI ABSENSI  WAJAH"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 467)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(907, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(168, 17)
        Me.ToolStripStatusLabel1.Text = "Version 1.0 Develop By Love 💖"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(907, 427)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.groupBox1)
        Me.TabPage1.Controls.Add(Me.button1)
        Me.TabPage1.Controls.Add(Me.label3)
        Me.TabPage1.Controls.Add(Me.label4)
        Me.TabPage1.Controls.Add(Me.label2)
        Me.TabPage1.Controls.Add(Me.label5)
        Me.TabPage1.Controls.Add(Me.imageBoxFrameGrabber)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(899, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ABSENSI"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(691, 125)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(194, 270)
        Me.groupBox1.TabIndex = 24
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Training: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Badge"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 155)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Name: "
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(687, 70)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(198, 36)
        Me.button1.TabIndex = 18
        Me.button1.Text = "Start Camera"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Red
        Me.label3.Location = New System.Drawing.Point(869, 52)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(16, 16)
        Me.label3.TabIndex = 21
        Me.label3.Text = "0"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Blue
        Me.label4.Location = New System.Drawing.Point(687, 33)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(45, 19)
        Me.label4.TabIndex = 22
        Me.label4.Text = "........."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(688, 52)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(179, 15)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Number of faces detected: "
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(688, 8)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(197, 15)
        Me.label5.TabIndex = 23
        Me.label5.Text = "Persons present in the scene:"
        '
        'imageBoxFrameGrabber
        '
        Me.imageBoxFrameGrabber.BackgroundImage = Global.Aplikasi_Absensi_Wajah.My.Resources.Resources.frame
        Me.imageBoxFrameGrabber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageBoxFrameGrabber.InitialImage = Global.Aplikasi_Absensi_Wajah.My.Resources.Resources.frame
        Me.imageBoxFrameGrabber.Location = New System.Drawing.Point(6, 6)
        Me.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber"
        Me.imageBoxFrameGrabber.Size = New System.Drawing.Size(675, 374)
        Me.imageBoxFrameGrabber.TabIndex = 14
        Me.imageBoxFrameGrabber.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ImageBox1)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.txtBadge)
        Me.TabPage2.Controls.Add(Me.ImageBoxAddFace)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(899, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DAFTAR WAJAH"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ImageBox1
        '
        Me.ImageBox1.BackColor = System.Drawing.Color.Transparent
        Me.ImageBox1.BackgroundImage = Global.Aplikasi_Absensi_Wajah.My.Resources.Resources.acb2ff8f4b2df5982605f86d3321ed54
        Me.ImageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageBox1.InitialImage = Nothing
        Me.ImageBox1.Location = New System.Drawing.Point(6, 6)
        Me.ImageBox1.Name = "ImageBox1"
        Me.ImageBox1.Size = New System.Drawing.Size(201, 202)
        Me.ImageBox1.TabIndex = 5
        Me.ImageBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(329, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Badge"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(517, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(238, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Training Wajah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtBadge
        '
        Me.txtBadge.Location = New System.Drawing.Point(334, 375)
        Me.txtBadge.Name = "txtBadge"
        Me.txtBadge.Size = New System.Drawing.Size(177, 20)
        Me.txtBadge.TabIndex = 9
        '
        'ImageBoxAddFace
        '
        Me.ImageBoxAddFace.BackgroundImage = Global.Aplikasi_Absensi_Wajah.My.Resources.Resources.frame
        Me.ImageBoxAddFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ImageBoxAddFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageBoxAddFace.InitialImage = Global.Aplikasi_Absensi_Wajah.My.Resources.Resources.frame
        Me.ImageBoxAddFace.Location = New System.Drawing.Point(167, 6)
        Me.ImageBoxAddFace.Name = "ImageBoxAddFace"
        Me.ImageBoxAddFace.Size = New System.Drawing.Size(588, 348)
        Me.ImageBoxAddFace.TabIndex = 15
        Me.ImageBoxAddFace.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(148, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Name: "
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(151, 375)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(177, 20)
        Me.txtName.TabIndex = 7
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 489)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Face Recognition"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMazimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageBoxAddFace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Private WithEvents button1 As Button
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents imageBoxFrameGrabber As ImageBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label7 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents Label6 As Label
    Private WithEvents label1 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents pbMazimize As PictureBox
    Friend WithEvents pbMinimize As PictureBox
    Private WithEvents ImageBoxAddFace As ImageBox
    Private WithEvents ImageBox1 As ImageBox
    Private WithEvents Label8 As Label
    Private WithEvents Button2 As Button
    Private WithEvents txtBadge As TextBox
    Private WithEvents Label9 As Label
    Private WithEvents txtName As TextBox
    Friend WithEvents Timer3 As Timer
End Class
