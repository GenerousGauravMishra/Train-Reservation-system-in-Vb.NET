<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmail
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
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.txtmby = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtmessage
        '
        Me.txtmessage.Location = New System.Drawing.Point(73, 24)
        Me.txtmessage.Multiline = True
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(371, 304)
        Me.txtmessage.TabIndex = 0
        '
        'txtmby
        '
        Me.txtmby.Location = New System.Drawing.Point(73, 334)
        Me.txtmby.Multiline = True
        Me.txtmby.Name = "txtmby"
        Me.txtmby.Size = New System.Drawing.Size(371, 34)
        Me.txtmby.TabIndex = 1
        '
        'frmmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 392)
        Me.Controls.Add(Me.txtmby)
        Me.Controls.Add(Me.txtmessage)
        Me.Name = "frmmail"
        Me.Text = "E-mail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmessage As System.Windows.Forms.TextBox
    Friend WithEvents txtmby As System.Windows.Forms.TextBox
End Class
