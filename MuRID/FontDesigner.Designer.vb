<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FontDesigner
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
        Me.PictureBox_Letter = New System.Windows.Forms.PictureBox()
        Me.TextBox_Result = New System.Windows.Forms.TextBox()
        Me.Button_Copy = New System.Windows.Forms.Button()
        Me.Label_Result = New System.Windows.Forms.Label()
        Me.CheckBox_ClipEmpty = New System.Windows.Forms.CheckBox()
        Me.CheckBox_IncludeWidth = New System.Windows.Forms.CheckBox()
        Me.Button_Clear = New System.Windows.Forms.Button()
        CType(Me.PictureBox_Letter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_Letter
        '
        Me.PictureBox_Letter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_Letter.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox_Letter.Name = "PictureBox_Letter"
        Me.PictureBox_Letter.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox_Letter.TabIndex = 0
        Me.PictureBox_Letter.TabStop = False
        '
        'TextBox_Result
        '
        Me.TextBox_Result.Location = New System.Drawing.Point(274, 219)
        Me.TextBox_Result.Name = "TextBox_Result"
        Me.TextBox_Result.Size = New System.Drawing.Size(232, 20)
        Me.TextBox_Result.TabIndex = 1
        Me.TextBox_Result.Text = "{129,129,129,129,129,129,129,129}"
        '
        'Button_Copy
        '
        Me.Button_Copy.Location = New System.Drawing.Point(431, 245)
        Me.Button_Copy.Name = "Button_Copy"
        Me.Button_Copy.Size = New System.Drawing.Size(75, 23)
        Me.Button_Copy.TabIndex = 2
        Me.Button_Copy.Text = "Copy"
        Me.Button_Copy.UseVisualStyleBackColor = True
        '
        'Label_Result
        '
        Me.Label_Result.AutoSize = True
        Me.Label_Result.Location = New System.Drawing.Point(271, 203)
        Me.Label_Result.Name = "Label_Result"
        Me.Label_Result.Size = New System.Drawing.Size(40, 13)
        Me.Label_Result.TabIndex = 3
        Me.Label_Result.Text = "Result:"
        '
        'CheckBox_ClipEmpty
        '
        Me.CheckBox_ClipEmpty.AutoSize = True
        Me.CheckBox_ClipEmpty.Checked = True
        Me.CheckBox_ClipEmpty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_ClipEmpty.Location = New System.Drawing.Point(274, 160)
        Me.CheckBox_ClipEmpty.Name = "CheckBox_ClipEmpty"
        Me.CheckBox_ClipEmpty.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox_ClipEmpty.TabIndex = 4
        Me.CheckBox_ClipEmpty.Text = "Clip Empty"
        Me.CheckBox_ClipEmpty.UseVisualStyleBackColor = True
        '
        'CheckBox_IncludeWidth
        '
        Me.CheckBox_IncludeWidth.AutoSize = True
        Me.CheckBox_IncludeWidth.Location = New System.Drawing.Point(274, 183)
        Me.CheckBox_IncludeWidth.Name = "CheckBox_IncludeWidth"
        Me.CheckBox_IncludeWidth.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox_IncludeWidth.TabIndex = 5
        Me.CheckBox_IncludeWidth.Text = "Include Width"
        Me.CheckBox_IncludeWidth.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(274, 245)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 6
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'FontDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 280)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.CheckBox_IncludeWidth)
        Me.Controls.Add(Me.CheckBox_ClipEmpty)
        Me.Controls.Add(Me.Label_Result)
        Me.Controls.Add(Me.Button_Copy)
        Me.Controls.Add(Me.TextBox_Result)
        Me.Controls.Add(Me.PictureBox_Letter)
        Me.MaximumSize = New System.Drawing.Size(534, 319)
        Me.MinimumSize = New System.Drawing.Size(534, 319)
        Me.Name = "FontDesigner"
        Me.Text = "FontDesigner"
        CType(Me.PictureBox_Letter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox_Letter As PictureBox
    Friend WithEvents TextBox_Result As TextBox
    Friend WithEvents Button_Copy As Button
    Friend WithEvents Label_Result As Label
    Friend WithEvents CheckBox_ClipEmpty As CheckBox
    Friend WithEvents CheckBox_IncludeWidth As CheckBox
    Friend WithEvents Button_Clear As Button
End Class
