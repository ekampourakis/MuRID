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
        Me.Label_Result = New System.Windows.Forms.Label()
        Me.CheckBox_ClipEmpty = New System.Windows.Forms.CheckBox()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.TextBox_Raw = New System.Windows.Forms.TextBox()
        Me.Label_Raw = New System.Windows.Forms.Label()
        Me.CheckBox_RawEnabled = New System.Windows.Forms.CheckBox()
        Me.Button_LoadFont = New System.Windows.Forms.Button()
        Me.Button_ExportFont = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox_Editor = New System.Windows.Forms.GroupBox()
        Me.CheckBox_Override = New System.Windows.Forms.CheckBox()
        Me.Label_Shift = New System.Windows.Forms.Label()
        Me.CheckBox_Preserve = New System.Windows.Forms.CheckBox()
        Me.Button_ShiftRight = New System.Windows.Forms.Button()
        Me.Button_ShiftLeft = New System.Windows.Forms.Button()
        Me.Button_ShiftDown = New System.Windows.Forms.Button()
        Me.Button_ShiftUp = New System.Windows.Forms.Button()
        Me.Button_Push = New System.Windows.Forms.Button()
        Me.TextBox_Character = New System.Windows.Forms.TextBox()
        Me.Label_Character = New System.Windows.Forms.Label()
        Me.ListBox_Letters = New System.Windows.Forms.ListBox()
        Me.Label_Changes = New System.Windows.Forms.Label()
        Me.Label_Characters = New System.Windows.Forms.Label()
        CType(Me.PictureBox_Letter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Editor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox_Letter
        '
        Me.PictureBox_Letter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_Letter.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox_Letter.Name = "PictureBox_Letter"
        Me.PictureBox_Letter.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox_Letter.TabIndex = 0
        Me.PictureBox_Letter.TabStop = False
        '
        'TextBox_Result
        '
        Me.TextBox_Result.Location = New System.Drawing.Point(6, 333)
        Me.TextBox_Result.Name = "TextBox_Result"
        Me.TextBox_Result.Size = New System.Drawing.Size(256, 20)
        Me.TextBox_Result.TabIndex = 1
        '
        'Label_Result
        '
        Me.Label_Result.AutoSize = True
        Me.Label_Result.Location = New System.Drawing.Point(3, 317)
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
        Me.CheckBox_ClipEmpty.Location = New System.Drawing.Point(268, 174)
        Me.CheckBox_ClipEmpty.Name = "CheckBox_ClipEmpty"
        Me.CheckBox_ClipEmpty.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox_ClipEmpty.TabIndex = 4
        Me.CheckBox_ClipEmpty.Text = "Clip Empty"
        Me.CheckBox_ClipEmpty.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(6, 359)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(53, 23)
        Me.Button_Clear.TabIndex = 6
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'TextBox_Raw
        '
        Me.TextBox_Raw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Raw.Enabled = False
        Me.TextBox_Raw.Location = New System.Drawing.Point(607, 25)
        Me.TextBox_Raw.Multiline = True
        Me.TextBox_Raw.Name = "TextBox_Raw"
        Me.TextBox_Raw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Raw.Size = New System.Drawing.Size(311, 404)
        Me.TextBox_Raw.TabIndex = 7
        '
        'Label_Raw
        '
        Me.Label_Raw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Raw.AutoSize = True
        Me.Label_Raw.Location = New System.Drawing.Point(604, 9)
        Me.Label_Raw.Name = "Label_Raw"
        Me.Label_Raw.Size = New System.Drawing.Size(32, 13)
        Me.Label_Raw.TabIndex = 8
        Me.Label_Raw.Text = "Raw:"
        '
        'CheckBox_RawEnabled
        '
        Me.CheckBox_RawEnabled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_RawEnabled.AutoSize = True
        Me.CheckBox_RawEnabled.Enabled = False
        Me.CheckBox_RawEnabled.Location = New System.Drawing.Point(853, 8)
        Me.CheckBox_RawEnabled.Name = "CheckBox_RawEnabled"
        Me.CheckBox_RawEnabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_RawEnabled.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox_RawEnabled.TabIndex = 9
        Me.CheckBox_RawEnabled.Text = "Enabled"
        Me.CheckBox_RawEnabled.UseVisualStyleBackColor = True
        '
        'Button_LoadFont
        '
        Me.Button_LoadFont.Location = New System.Drawing.Point(12, 406)
        Me.Button_LoadFont.Name = "Button_LoadFont"
        Me.Button_LoadFont.Size = New System.Drawing.Size(75, 23)
        Me.Button_LoadFont.TabIndex = 10
        Me.Button_LoadFont.Text = "Load Font"
        Me.Button_LoadFont.UseVisualStyleBackColor = True
        '
        'Button_ExportFont
        '
        Me.Button_ExportFont.Location = New System.Drawing.Point(93, 406)
        Me.Button_ExportFont.Name = "Button_ExportFont"
        Me.Button_ExportFont.Size = New System.Drawing.Size(75, 23)
        Me.Button_ExportFont.TabIndex = 11
        Me.Button_ExportFont.Text = "Export Font"
        Me.Button_ExportFont.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.DefaultExt = "*.font"
        Me.OpenFileDialog.Filter = "Font Files|*.font|All Files|*.*"
        Me.OpenFileDialog.Title = "Load font..."
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "*.font"
        Me.SaveFileDialog.Filter = "Font Files|*.font"
        Me.SaveFileDialog.Title = "Export font..."
        '
        'GroupBox_Editor
        '
        Me.GroupBox_Editor.Controls.Add(Me.CheckBox_Override)
        Me.GroupBox_Editor.Controls.Add(Me.Label_Shift)
        Me.GroupBox_Editor.Controls.Add(Me.CheckBox_Preserve)
        Me.GroupBox_Editor.Controls.Add(Me.Button_ShiftRight)
        Me.GroupBox_Editor.Controls.Add(Me.Button_ShiftLeft)
        Me.GroupBox_Editor.Controls.Add(Me.Button_ShiftDown)
        Me.GroupBox_Editor.Controls.Add(Me.Button_ShiftUp)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Push)
        Me.GroupBox_Editor.Controls.Add(Me.TextBox_Character)
        Me.GroupBox_Editor.Controls.Add(Me.Label_Character)
        Me.GroupBox_Editor.Controls.Add(Me.PictureBox_Letter)
        Me.GroupBox_Editor.Controls.Add(Me.TextBox_Result)
        Me.GroupBox_Editor.Controls.Add(Me.Label_Result)
        Me.GroupBox_Editor.Controls.Add(Me.CheckBox_ClipEmpty)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Clear)
        Me.GroupBox_Editor.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_Editor.Name = "GroupBox_Editor"
        Me.GroupBox_Editor.Size = New System.Drawing.Size(349, 388)
        Me.GroupBox_Editor.TabIndex = 12
        Me.GroupBox_Editor.TabStop = False
        Me.GroupBox_Editor.Text = "Letter Editor"
        '
        'CheckBox_Override
        '
        Me.CheckBox_Override.AutoSize = True
        Me.CheckBox_Override.Location = New System.Drawing.Point(268, 197)
        Me.CheckBox_Override.Name = "CheckBox_Override"
        Me.CheckBox_Override.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox_Override.TabIndex = 16
        Me.CheckBox_Override.Text = "Override"
        Me.CheckBox_Override.UseVisualStyleBackColor = True
        '
        'Label_Shift
        '
        Me.Label_Shift.AutoSize = True
        Me.Label_Shift.Location = New System.Drawing.Point(265, 19)
        Me.Label_Shift.Name = "Label_Shift"
        Me.Label_Shift.Size = New System.Drawing.Size(31, 13)
        Me.Label_Shift.TabIndex = 15
        Me.Label_Shift.Text = "Shift:"
        '
        'CheckBox_Preserve
        '
        Me.CheckBox_Preserve.AutoSize = True
        Me.CheckBox_Preserve.Checked = True
        Me.CheckBox_Preserve.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Preserve.Location = New System.Drawing.Point(268, 151)
        Me.CheckBox_Preserve.Name = "CheckBox_Preserve"
        Me.CheckBox_Preserve.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox_Preserve.TabIndex = 14
        Me.CheckBox_Preserve.Text = "Preserve"
        Me.CheckBox_Preserve.UseVisualStyleBackColor = True
        '
        'Button_ShiftRight
        '
        Me.Button_ShiftRight.Location = New System.Drawing.Point(268, 122)
        Me.Button_ShiftRight.Name = "Button_ShiftRight"
        Me.Button_ShiftRight.Size = New System.Drawing.Size(75, 23)
        Me.Button_ShiftRight.TabIndex = 13
        Me.Button_ShiftRight.Text = "→"
        Me.Button_ShiftRight.UseVisualStyleBackColor = True
        '
        'Button_ShiftLeft
        '
        Me.Button_ShiftLeft.Location = New System.Drawing.Point(268, 93)
        Me.Button_ShiftLeft.Name = "Button_ShiftLeft"
        Me.Button_ShiftLeft.Size = New System.Drawing.Size(75, 23)
        Me.Button_ShiftLeft.TabIndex = 12
        Me.Button_ShiftLeft.Text = "←"
        Me.Button_ShiftLeft.UseVisualStyleBackColor = True
        '
        'Button_ShiftDown
        '
        Me.Button_ShiftDown.Location = New System.Drawing.Point(268, 64)
        Me.Button_ShiftDown.Name = "Button_ShiftDown"
        Me.Button_ShiftDown.Size = New System.Drawing.Size(75, 23)
        Me.Button_ShiftDown.TabIndex = 11
        Me.Button_ShiftDown.Text = "↓"
        Me.Button_ShiftDown.UseVisualStyleBackColor = True
        '
        'Button_ShiftUp
        '
        Me.Button_ShiftUp.Location = New System.Drawing.Point(268, 35)
        Me.Button_ShiftUp.Name = "Button_ShiftUp"
        Me.Button_ShiftUp.Size = New System.Drawing.Size(75, 23)
        Me.Button_ShiftUp.TabIndex = 10
        Me.Button_ShiftUp.Text = "↑"
        Me.Button_ShiftUp.UseVisualStyleBackColor = True
        '
        'Button_Push
        '
        Me.Button_Push.Location = New System.Drawing.Point(212, 359)
        Me.Button_Push.Name = "Button_Push"
        Me.Button_Push.Size = New System.Drawing.Size(50, 23)
        Me.Button_Push.TabIndex = 9
        Me.Button_Push.Text = ">>"
        Me.Button_Push.UseVisualStyleBackColor = True
        '
        'TextBox_Character
        '
        Me.TextBox_Character.HideSelection = False
        Me.TextBox_Character.Location = New System.Drawing.Point(6, 294)
        Me.TextBox_Character.MaxLength = 2
        Me.TextBox_Character.Name = "TextBox_Character"
        Me.TextBox_Character.Size = New System.Drawing.Size(256, 20)
        Me.TextBox_Character.TabIndex = 8
        '
        'Label_Character
        '
        Me.Label_Character.AutoSize = True
        Me.Label_Character.Location = New System.Drawing.Point(3, 278)
        Me.Label_Character.Name = "Label_Character"
        Me.Label_Character.Size = New System.Drawing.Size(56, 13)
        Me.Label_Character.TabIndex = 7
        Me.Label_Character.Text = "Character:"
        '
        'ListBox_Letters
        '
        Me.ListBox_Letters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox_Letters.FormattingEnabled = True
        Me.ListBox_Letters.Location = New System.Drawing.Point(367, 25)
        Me.ListBox_Letters.Name = "ListBox_Letters"
        Me.ListBox_Letters.Size = New System.Drawing.Size(234, 381)
        Me.ListBox_Letters.TabIndex = 13
        '
        'Label_Changes
        '
        Me.Label_Changes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Changes.AutoSize = True
        Me.Label_Changes.Location = New System.Drawing.Point(366, 416)
        Me.Label_Changes.Name = "Label_Changes"
        Me.Label_Changes.Size = New System.Drawing.Size(63, 13)
        Me.Label_Changes.TabIndex = 14
        Me.Label_Changes.Text = "Unchanged"
        '
        'Label_Characters
        '
        Me.Label_Characters.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Characters.AutoSize = True
        Me.Label_Characters.Location = New System.Drawing.Point(366, 9)
        Me.Label_Characters.Name = "Label_Characters"
        Me.Label_Characters.Size = New System.Drawing.Size(61, 13)
        Me.Label_Characters.TabIndex = 15
        Me.Label_Characters.Text = "Characters:"
        '
        'FontDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 441)
        Me.Controls.Add(Me.Label_Characters)
        Me.Controls.Add(Me.Label_Changes)
        Me.Controls.Add(Me.ListBox_Letters)
        Me.Controls.Add(Me.GroupBox_Editor)
        Me.Controls.Add(Me.Button_ExportFont)
        Me.Controls.Add(Me.Button_LoadFont)
        Me.Controls.Add(Me.CheckBox_RawEnabled)
        Me.Controls.Add(Me.Label_Raw)
        Me.Controls.Add(Me.TextBox_Raw)
        Me.MaximumSize = New System.Drawing.Size(946, 480)
        Me.MinimumSize = New System.Drawing.Size(946, 480)
        Me.Name = "FontDesigner"
        Me.Text = "Font Editor"
        CType(Me.PictureBox_Letter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Editor.ResumeLayout(False)
        Me.GroupBox_Editor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox_Letter As PictureBox
    Friend WithEvents TextBox_Result As TextBox
    Friend WithEvents Label_Result As Label
    Friend WithEvents CheckBox_ClipEmpty As CheckBox
    Friend WithEvents Button_Clear As Button
    Friend WithEvents TextBox_Raw As TextBox
    Friend WithEvents Label_Raw As Label
    Friend WithEvents CheckBox_RawEnabled As CheckBox
    Friend WithEvents Button_LoadFont As Button
    Friend WithEvents Button_ExportFont As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents GroupBox_Editor As GroupBox
    Friend WithEvents ListBox_Letters As ListBox
    Friend WithEvents Label_Changes As Label
    Friend WithEvents Button_Push As Button
    Friend WithEvents TextBox_Character As TextBox
    Friend WithEvents Label_Character As Label
    Friend WithEvents Button_ShiftRight As Button
    Friend WithEvents Button_ShiftLeft As Button
    Friend WithEvents Button_ShiftDown As Button
    Friend WithEvents Button_ShiftUp As Button
    Friend WithEvents Label_Characters As Label
    Friend WithEvents CheckBox_Preserve As CheckBox
    Friend WithEvents Label_Shift As Label
    Friend WithEvents CheckBox_Override As CheckBox
End Class
