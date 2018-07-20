<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Matrix = New System.Windows.Forms.PictureBox()
        Me.TextBox_Message = New System.Windows.Forms.TextBox()
        Me.Button_Preview = New System.Windows.Forms.Button()
        Me.CheckBox_Center = New System.Windows.Forms.CheckBox()
        Me.Button_FontEditor = New System.Windows.Forms.Button()
        Me.Button_Transmit = New System.Windows.Forms.Button()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.CheckBox_Enabled = New System.Windows.Forms.CheckBox()
        Me.Timer_Clock = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker_Serial = New System.ComponentModel.BackgroundWorker()
        Me.CheckBox_Preview = New System.Windows.Forms.CheckBox()
        Me.Label_Brightness = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Button_LoadFont = New System.Windows.Forms.Button()
        Me.Label_CurrentFont = New System.Windows.Forms.Label()
        Me.TrackBar_Brightness = New System.Windows.Forms.TrackBar()
        Me.Timer_GUI = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel_Serial = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CheckBox_HUD = New System.Windows.Forms.CheckBox()
        CType(Me.Matrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_Brightness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Matrix
        '
        Me.Matrix.BackColor = System.Drawing.Color.Black
        Me.Matrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Matrix.Location = New System.Drawing.Point(12, 12)
        Me.Matrix.Name = "Matrix"
        Me.Matrix.Size = New System.Drawing.Size(1024, 256)
        Me.Matrix.TabIndex = 0
        Me.Matrix.TabStop = False
        '
        'TextBox_Message
        '
        Me.TextBox_Message.Location = New System.Drawing.Point(12, 297)
        Me.TextBox_Message.Name = "TextBox_Message"
        Me.TextBox_Message.Size = New System.Drawing.Size(159, 20)
        Me.TextBox_Message.TabIndex = 1
        '
        'Button_Preview
        '
        Me.Button_Preview.Location = New System.Drawing.Point(177, 295)
        Me.Button_Preview.Name = "Button_Preview"
        Me.Button_Preview.Size = New System.Drawing.Size(75, 23)
        Me.Button_Preview.TabIndex = 2
        Me.Button_Preview.Text = "Preview"
        Me.Button_Preview.UseVisualStyleBackColor = True
        '
        'CheckBox_Center
        '
        Me.CheckBox_Center.AutoSize = True
        Me.CheckBox_Center.Checked = True
        Me.CheckBox_Center.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Center.Location = New System.Drawing.Point(102, 328)
        Me.CheckBox_Center.Name = "CheckBox_Center"
        Me.CheckBox_Center.Size = New System.Drawing.Size(69, 17)
        Me.CheckBox_Center.TabIndex = 3
        Me.CheckBox_Center.Text = "Centered"
        Me.CheckBox_Center.UseVisualStyleBackColor = True
        '
        'Button_FontEditor
        '
        Me.Button_FontEditor.Location = New System.Drawing.Point(922, 324)
        Me.Button_FontEditor.Name = "Button_FontEditor"
        Me.Button_FontEditor.Size = New System.Drawing.Size(114, 23)
        Me.Button_FontEditor.TabIndex = 6
        Me.Button_FontEditor.Text = "Font Editor"
        Me.Button_FontEditor.UseVisualStyleBackColor = True
        '
        'Button_Transmit
        '
        Me.Button_Transmit.Location = New System.Drawing.Point(177, 324)
        Me.Button_Transmit.Name = "Button_Transmit"
        Me.Button_Transmit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Transmit.TabIndex = 7
        Me.Button_Transmit.Text = "Transmit"
        Me.Button_Transmit.UseVisualStyleBackColor = True
        '
        'SerialPort
        '
        Me.SerialPort.PortName = "COM8"
        '
        'CheckBox_Enabled
        '
        Me.CheckBox_Enabled.AutoSize = True
        Me.CheckBox_Enabled.Enabled = False
        Me.CheckBox_Enabled.Location = New System.Drawing.Point(959, 274)
        Me.CheckBox_Enabled.Name = "CheckBox_Enabled"
        Me.CheckBox_Enabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_Enabled.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox_Enabled.TabIndex = 10
        Me.CheckBox_Enabled.Text = "Screen Off"
        Me.CheckBox_Enabled.UseVisualStyleBackColor = True
        '
        'Timer_Clock
        '
        '
        'BackgroundWorker_Serial
        '
        '
        'CheckBox_Preview
        '
        Me.CheckBox_Preview.AutoSize = True
        Me.CheckBox_Preview.Checked = True
        Me.CheckBox_Preview.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Preview.Location = New System.Drawing.Point(12, 274)
        Me.CheckBox_Preview.Name = "CheckBox_Preview"
        Me.CheckBox_Preview.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox_Preview.TabIndex = 11
        Me.CheckBox_Preview.Text = "Preview"
        Me.CheckBox_Preview.UseVisualStyleBackColor = True
        '
        'Label_Brightness
        '
        Me.Label_Brightness.AutoSize = True
        Me.Label_Brightness.Location = New System.Drawing.Point(742, 274)
        Me.Label_Brightness.Name = "Label_Brightness"
        Me.Label_Brightness.Size = New System.Drawing.Size(59, 13)
        Me.Label_Brightness.TabIndex = 12
        Me.Label_Brightness.Text = "Brightness:"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.DefaultExt = "*.font"
        Me.OpenFileDialog.Filter = "Font Files|*.font|All Files|*.*"
        Me.OpenFileDialog.Title = "Load font..."
        '
        'Button_LoadFont
        '
        Me.Button_LoadFont.Location = New System.Drawing.Point(559, 283)
        Me.Button_LoadFont.Name = "Button_LoadFont"
        Me.Button_LoadFont.Size = New System.Drawing.Size(75, 23)
        Me.Button_LoadFont.TabIndex = 13
        Me.Button_LoadFont.Text = "Load Font"
        Me.Button_LoadFont.UseVisualStyleBackColor = True
        '
        'Label_CurrentFont
        '
        Me.Label_CurrentFont.AutoSize = True
        Me.Label_CurrentFont.Location = New System.Drawing.Point(640, 288)
        Me.Label_CurrentFont.Name = "Label_CurrentFont"
        Me.Label_CurrentFont.Size = New System.Drawing.Size(33, 13)
        Me.Label_CurrentFont.TabIndex = 14
        Me.Label_CurrentFont.Text = "None"
        '
        'TrackBar_Brightness
        '
        Me.TrackBar_Brightness.Location = New System.Drawing.Point(807, 274)
        Me.TrackBar_Brightness.Maximum = 15
        Me.TrackBar_Brightness.Minimum = -1
        Me.TrackBar_Brightness.Name = "TrackBar_Brightness"
        Me.TrackBar_Brightness.Size = New System.Drawing.Size(146, 45)
        Me.TrackBar_Brightness.TabIndex = 9
        Me.TrackBar_Brightness.Value = 4
        '
        'Timer_GUI
        '
        Me.Timer_GUI.Enabled = True
        Me.Timer_GUI.Interval = 500
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel_Serial})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 350)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1048, 22)
        Me.StatusStrip.TabIndex = 15
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusLabel_Serial
        '
        Me.StatusLabel_Serial.Name = "StatusLabel_Serial"
        Me.StatusLabel_Serial.Size = New System.Drawing.Size(0, 17)
        '
        'CheckBox_HUD
        '
        Me.CheckBox_HUD.AutoSize = True
        Me.CheckBox_HUD.Location = New System.Drawing.Point(12, 328)
        Me.CheckBox_HUD.Name = "CheckBox_HUD"
        Me.CheckBox_HUD.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox_HUD.TabIndex = 16
        Me.CheckBox_HUD.Text = "HUD Mode"
        Me.CheckBox_HUD.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 372)
        Me.Controls.Add(Me.CheckBox_HUD)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Label_CurrentFont)
        Me.Controls.Add(Me.Button_LoadFont)
        Me.Controls.Add(Me.Label_Brightness)
        Me.Controls.Add(Me.CheckBox_Preview)
        Me.Controls.Add(Me.CheckBox_Enabled)
        Me.Controls.Add(Me.TrackBar_Brightness)
        Me.Controls.Add(Me.Button_Transmit)
        Me.Controls.Add(Me.Button_FontEditor)
        Me.Controls.Add(Me.CheckBox_Center)
        Me.Controls.Add(Me.Button_Preview)
        Me.Controls.Add(Me.TextBox_Message)
        Me.Controls.Add(Me.Matrix)
        Me.MaximumSize = New System.Drawing.Size(1064, 411)
        Me.MinimumSize = New System.Drawing.Size(1064, 411)
        Me.Name = "Main"
        Me.Text = "MuRID  "
        CType(Me.Matrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_Brightness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Matrix As PictureBox
    Friend WithEvents TextBox_Message As TextBox
    Friend WithEvents Button_Preview As Button
    Friend WithEvents CheckBox_Center As CheckBox
    Friend WithEvents Button_FontEditor As Button
    Friend WithEvents Button_Transmit As Button
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents CheckBox_Enabled As CheckBox
    Friend WithEvents Timer_Clock As Timer
    Friend WithEvents BackgroundWorker_Serial As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckBox_Preview As CheckBox
    Friend WithEvents Label_Brightness As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Button_LoadFont As Button
    Friend WithEvents Label_CurrentFont As Label
    Friend WithEvents TrackBar_Brightness As TrackBar
    Friend WithEvents Timer_GUI As Timer
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents StatusLabel_Serial As ToolStripStatusLabel
    Friend WithEvents CheckBox_HUD As CheckBox
End Class
