<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gallery
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
        Me.components = New System.ComponentModel.Container()
        Me.Label_Time = New System.Windows.Forms.Label()
        Me.Label_Date = New System.Windows.Forms.Label()
        Me.Label_CPU = New System.Windows.Forms.Label()
        Me.Label_RAM = New System.Windows.Forms.Label()
        Me.Label_Language = New System.Windows.Forms.Label()
        Me.Label_Download = New System.Windows.Forms.Label()
        Me.Timer_Update = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label_Time
        '
        Me.Label_Time.AutoSize = True
        Me.Label_Time.Location = New System.Drawing.Point(107, 65)
        Me.Label_Time.Name = "Label_Time"
        Me.Label_Time.Size = New System.Drawing.Size(30, 13)
        Me.Label_Time.TabIndex = 0
        Me.Label_Time.Text = "Time"
        '
        'Label_Date
        '
        Me.Label_Date.AutoSize = True
        Me.Label_Date.Location = New System.Drawing.Point(107, 114)
        Me.Label_Date.Name = "Label_Date"
        Me.Label_Date.Size = New System.Drawing.Size(30, 13)
        Me.Label_Date.TabIndex = 1
        Me.Label_Date.Text = "Date"
        '
        'Label_CPU
        '
        Me.Label_CPU.AutoSize = True
        Me.Label_CPU.Location = New System.Drawing.Point(107, 169)
        Me.Label_CPU.Name = "Label_CPU"
        Me.Label_CPU.Size = New System.Drawing.Size(29, 13)
        Me.Label_CPU.TabIndex = 2
        Me.Label_CPU.Text = "CPU"
        '
        'Label_RAM
        '
        Me.Label_RAM.AutoSize = True
        Me.Label_RAM.Location = New System.Drawing.Point(107, 218)
        Me.Label_RAM.Name = "Label_RAM"
        Me.Label_RAM.Size = New System.Drawing.Size(31, 13)
        Me.Label_RAM.TabIndex = 3
        Me.Label_RAM.Text = "RAM"
        '
        'Label_Language
        '
        Me.Label_Language.AutoSize = True
        Me.Label_Language.Location = New System.Drawing.Point(107, 267)
        Me.Label_Language.Name = "Label_Language"
        Me.Label_Language.Size = New System.Drawing.Size(55, 13)
        Me.Label_Language.TabIndex = 4
        Me.Label_Language.Text = "Language"
        '
        'Label_Download
        '
        Me.Label_Download.AutoSize = True
        Me.Label_Download.Location = New System.Drawing.Point(107, 313)
        Me.Label_Download.Name = "Label_Download"
        Me.Label_Download.Size = New System.Drawing.Size(55, 13)
        Me.Label_Download.TabIndex = 5
        Me.Label_Download.Text = "Download"
        '
        'Timer_Update
        '
        Me.Timer_Update.Enabled = True
        Me.Timer_Update.Interval = 1000
        '
        'Gallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label_Download)
        Me.Controls.Add(Me.Label_Language)
        Me.Controls.Add(Me.Label_RAM)
        Me.Controls.Add(Me.Label_CPU)
        Me.Controls.Add(Me.Label_Date)
        Me.Controls.Add(Me.Label_Time)
        Me.Name = "Gallery"
        Me.Text = "Gallery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Time As Label
    Friend WithEvents Label_Date As Label
    Friend WithEvents Label_CPU As Label
    Friend WithEvents Label_RAM As Label
    Friend WithEvents Label_Language As Label
    Friend WithEvents Label_Download As Label
    Friend WithEvents Timer_Update As Timer
End Class
