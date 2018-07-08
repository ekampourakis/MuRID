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
        Me.TextBox_Raw = New System.Windows.Forms.TextBox()
        Me.Label_Raw = New System.Windows.Forms.Label()
        Me.CheckBox_RawEnabled = New System.Windows.Forms.CheckBox()
        Me.Button_LoadFont = New System.Windows.Forms.Button()
        Me.Button_ExportFont = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox_Letter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.TextBox_Result.Location = New System.Drawing.Point(6, 373)
        Me.TextBox_Result.Name = "TextBox_Result"
        Me.TextBox_Result.Size = New System.Drawing.Size(232, 20)
        Me.TextBox_Result.TabIndex = 1
        Me.TextBox_Result.Text = "{129,129,129,129,129,129,129,129}"
        '
        'Button_Copy
        '
        Me.Button_Copy.Location = New System.Drawing.Point(163, 399)
        Me.Button_Copy.Name = "Button_Copy"
        Me.Button_Copy.Size = New System.Drawing.Size(75, 23)
        Me.Button_Copy.TabIndex = 2
        Me.Button_Copy.Text = "Copy"
        Me.Button_Copy.UseVisualStyleBackColor = True
        '
        'Label_Result
        '
        Me.Label_Result.AutoSize = True
        Me.Label_Result.Location = New System.Drawing.Point(3, 357)
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
        Me.CheckBox_ClipEmpty.Location = New System.Drawing.Point(6, 314)
        Me.CheckBox_ClipEmpty.Name = "CheckBox_ClipEmpty"
        Me.CheckBox_ClipEmpty.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox_ClipEmpty.TabIndex = 4
        Me.CheckBox_ClipEmpty.Text = "Clip Empty"
        Me.CheckBox_ClipEmpty.UseVisualStyleBackColor = True
        '
        'CheckBox_IncludeWidth
        '
        Me.CheckBox_IncludeWidth.AutoSize = True
        Me.CheckBox_IncludeWidth.Location = New System.Drawing.Point(6, 337)
        Me.CheckBox_IncludeWidth.Name = "CheckBox_IncludeWidth"
        Me.CheckBox_IncludeWidth.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox_IncludeWidth.TabIndex = 5
        Me.CheckBox_IncludeWidth.Text = "Include Width"
        Me.CheckBox_IncludeWidth.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(6, 399)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 6
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'TextBox_Raw
        '
        Me.TextBox_Raw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Raw.Enabled = False
        Me.TextBox_Raw.Location = New System.Drawing.Point(732, 25)
        Me.TextBox_Raw.Multiline = True
        Me.TextBox_Raw.Name = "TextBox_Raw"
        Me.TextBox_Raw.Size = New System.Drawing.Size(359, 739)
        Me.TextBox_Raw.TabIndex = 7
        '
        'Label_Raw
        '
        Me.Label_Raw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Raw.AutoSize = True
        Me.Label_Raw.Location = New System.Drawing.Point(729, 9)
        Me.Label_Raw.Name = "Label_Raw"
        Me.Label_Raw.Size = New System.Drawing.Size(32, 13)
        Me.Label_Raw.TabIndex = 8
        Me.Label_Raw.Text = "Raw:"
        '
        'CheckBox_RawEnabled
        '
        Me.CheckBox_RawEnabled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_RawEnabled.AutoSize = True
        Me.CheckBox_RawEnabled.Location = New System.Drawing.Point(1026, 8)
        Me.CheckBox_RawEnabled.Name = "CheckBox_RawEnabled"
        Me.CheckBox_RawEnabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_RawEnabled.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox_RawEnabled.TabIndex = 9
        Me.CheckBox_RawEnabled.Text = "Enabled"
        Me.CheckBox_RawEnabled.UseVisualStyleBackColor = True
        '
        'Button_LoadFont
        '
        Me.Button_LoadFont.Location = New System.Drawing.Point(35, 524)
        Me.Button_LoadFont.Name = "Button_LoadFont"
        Me.Button_LoadFont.Size = New System.Drawing.Size(75, 23)
        Me.Button_LoadFont.TabIndex = 10
        Me.Button_LoadFont.Text = "Load Font"
        Me.Button_LoadFont.UseVisualStyleBackColor = True
        '
        'Button_ExportFont
        '
        Me.Button_ExportFont.Location = New System.Drawing.Point(126, 524)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox_Letter)
        Me.GroupBox1.Controls.Add(Me.TextBox_Result)
        Me.GroupBox1.Controls.Add(Me.Button_Copy)
        Me.GroupBox1.Controls.Add(Me.Label_Result)
        Me.GroupBox1.Controls.Add(Me.CheckBox_ClipEmpty)
        Me.GroupBox1.Controls.Add(Me.CheckBox_IncludeWidth)
        Me.GroupBox1.Controls.Add(Me.Button_Clear)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 464)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(497, 25)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(229, 446)
        Me.ListBox1.TabIndex = 13
        '
        'FontDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 776)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_ExportFont)
        Me.Controls.Add(Me.Button_LoadFont)
        Me.Controls.Add(Me.CheckBox_RawEnabled)
        Me.Controls.Add(Me.Label_Raw)
        Me.Controls.Add(Me.TextBox_Raw)
        Me.Name = "FontDesigner"
        Me.Text = "Font Editor"
        CType(Me.PictureBox_Letter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents TextBox_Raw As TextBox
    Friend WithEvents Label_Raw As Label
    Friend WithEvents CheckBox_RawEnabled As CheckBox
    Friend WithEvents Button_LoadFont As Button
    Friend WithEvents Button_ExportFont As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
End Class
