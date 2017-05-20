<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbllmain = New System.Windows.Forms.Label()
        Me.grplogin = New System.Windows.Forms.GroupBox()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lbluname = New System.Windows.Forms.Label()
        Me.chkbx = New System.Windows.Forms.CheckBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblabt = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1.SuspendLayout()
        Me.grplogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.lbllmain)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 81)
        Me.Panel1.TabIndex = 1
        '
        'lbllmain
        '
        Me.lbllmain.AutoSize = True
        Me.lbllmain.Font = New System.Drawing.Font("Palatino Linotype", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllmain.Location = New System.Drawing.Point(150, 12)
        Me.lbllmain.Name = "lbllmain"
        Me.lbllmain.Size = New System.Drawing.Size(131, 50)
        Me.lbllmain.TabIndex = 0
        Me.lbllmain.Text = "Label1"
        '
        'grplogin
        '
        Me.grplogin.Controls.Add(Me.lblpass)
        Me.grplogin.Controls.Add(Me.lbluname)
        Me.grplogin.Controls.Add(Me.chkbx)
        Me.grplogin.Controls.Add(Me.txtpass)
        Me.grplogin.Controls.Add(Me.txtuname)
        Me.grplogin.Controls.Add(Me.btnlogin)
        Me.grplogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grplogin.Location = New System.Drawing.Point(212, 163)
        Me.grplogin.Name = "grplogin"
        Me.grplogin.Size = New System.Drawing.Size(411, 239)
        Me.grplogin.TabIndex = 2
        Me.grplogin.TabStop = False
        Me.grplogin.Text = "GroupBox"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(49, 75)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(49, 16)
        Me.lblpass.TabIndex = 5
        Me.lblpass.Text = "Label2"
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.Location = New System.Drawing.Point(48, 33)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(49, 16)
        Me.lbluname.TabIndex = 4
        Me.lbluname.Text = "Label1"
        '
        'chkbx
        '
        Me.chkbx.AutoSize = True
        Me.chkbx.Location = New System.Drawing.Point(151, 119)
        Me.chkbx.Name = "chkbx"
        Me.chkbx.Size = New System.Drawing.Size(95, 20)
        Me.chkbx.TabIndex = 3
        Me.chkbx.Text = "CheckBox1"
        Me.chkbx.UseVisualStyleBackColor = True
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(131, 67)
        Me.txtpass.Multiline = True
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(234, 31)
        Me.txtpass.TabIndex = 2
        '
        'txtuname
        '
        Me.txtuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.Location = New System.Drawing.Point(131, 28)
        Me.txtuname.Multiline = True
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(234, 29)
        Me.txtuname.TabIndex = 1
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(160, 158)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(106, 49)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "Button1"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Train_Reservation_System.My.Resources.Resources._1473016492_User
        Me.PictureBox1.Location = New System.Drawing.Point(226, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(815, 530)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 816
        Me.LineShape1.Y1 = 84
        Me.LineShape1.Y2 = 84
        '
        'lblabt
        '
        Me.lblabt.AutoSize = True
        Me.lblabt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblabt.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblabt.Location = New System.Drawing.Point(15, 504)
        Me.lblabt.Name = "lblabt"
        Me.lblabt.Size = New System.Drawing.Size(49, 18)
        Me.lblabt.TabIndex = 5
        Me.lblabt.Text = "Label1"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(7, 500)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(68, 25)
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 530)
        Me.Controls.Add(Me.lblabt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grplogin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmlogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grplogin.ResumeLayout(False)
        Me.grplogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbllmain As System.Windows.Forms.Label
    Friend WithEvents grplogin As System.Windows.Forms.GroupBox
    Friend WithEvents chkbx As System.Windows.Forms.CheckBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lbluname As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblabt As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
