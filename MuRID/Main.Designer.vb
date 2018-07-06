<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Matrix = New System.Windows.Forms.PictureBox()
        CType(Me.Matrix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Matrix
        '
        Me.Matrix.BackColor = System.Drawing.Color.Black
        Me.Matrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Matrix.Location = New System.Drawing.Point(45, 125)
        Me.Matrix.Name = "Matrix"
        Me.Matrix.Size = New System.Drawing.Size(1024, 256)
        Me.Matrix.TabIndex = 0
        Me.Matrix.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 551)
        Me.Controls.Add(Me.Matrix)
        Me.Name = "Main"
        Me.Text = "Main - MuRID"
        CType(Me.Matrix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Matrix As PictureBox
End Class
