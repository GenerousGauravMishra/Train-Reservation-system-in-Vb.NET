<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdel
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
        Me.txtdel = New System.Windows.Forms.TextBox()
        Me.lbldel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblm = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnddelete = New System.Windows.Forms.Button()
        Me.btndfind = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdel
        '
        Me.txtdel.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdel.Location = New System.Drawing.Point(344, 84)
        Me.txtdel.Multiline = True
        Me.txtdel.Name = "txtdel"
        Me.txtdel.Size = New System.Drawing.Size(238, 40)
        Me.txtdel.TabIndex = 0
        '
        'lbldel
        '
        Me.lbldel.AutoSize = True
        Me.lbldel.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldel.Location = New System.Drawing.Point(225, 88)
        Me.lbldel.Name = "lbldel"
        Me.lbldel.Size = New System.Drawing.Size(76, 28)
        Me.lbldel.TabIndex = 1
        Me.lbldel.Text = "Label1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 168)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1205, 79)
        Me.DataGridView1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.lblm)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1205, 63)
        Me.Panel1.TabIndex = 5
        '
        'lblm
        '
        Me.lblm.AutoSize = True
        Me.lblm.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm.Location = New System.Drawing.Point(489, 14)
        Me.lblm.Name = "lblm"
        Me.lblm.Size = New System.Drawing.Size(92, 36)
        Me.lblm.TabIndex = 7
        Me.lblm.Text = "Label1"
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Image = Global.Train_Reservation_System.My.Resources.Resources._1473016476_Log_Out
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexit.Location = New System.Drawing.Point(838, 81)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(97, 41)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "Button2"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnddelete
        '
        Me.btnddelete.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnddelete.Image = Global.Train_Reservation_System.My.Resources.Resources._1473016284_3
        Me.btnddelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnddelete.Location = New System.Drawing.Point(726, 81)
        Me.btnddelete.Name = "btnddelete"
        Me.btnddelete.Size = New System.Drawing.Size(105, 41)
        Me.btnddelete.TabIndex = 3
        Me.btnddelete.Text = "Button2"
        Me.btnddelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnddelete.UseVisualStyleBackColor = True
        '
        'btndfind
        '
        Me.btndfind.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndfind.Image = Global.Train_Reservation_System.My.Resources.Resources._1473016511_Search
        Me.btndfind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndfind.Location = New System.Drawing.Point(616, 81)
        Me.btndfind.Name = "btndfind"
        Me.btndfind.Size = New System.Drawing.Size(102, 41)
        Me.btndfind.TabIndex = 2
        Me.btndfind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndfind.UseVisualStyleBackColor = True
        '
        'frmdel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 247)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnddelete)
        Me.Controls.Add(Me.btndfind)
        Me.Controls.Add(Me.lbldel)
        Me.Controls.Add(Me.txtdel)
        Me.Name = "frmdel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmdel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdel As System.Windows.Forms.TextBox
    Friend WithEvents lbldel As System.Windows.Forms.Label
    Friend WithEvents btndfind As System.Windows.Forms.Button
    Friend WithEvents btnddelete As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lblm As System.Windows.Forms.Label
End Class
