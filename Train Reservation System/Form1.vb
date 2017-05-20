Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Mainfrm
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HeartHacker\documents\visual studio 2010\Projects\Train reservation system\Train Reservation System\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim com As String = "Select *from Passanger"
    Dim adpt As New SqlDataAdapter(com, cn)
    Dim ds As New DataSet

    Private Sub Mainfrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Module_properties.prop()
        cmd.Connection = cn
        adpt.Fill(ds, "Passanger")
        DataGridView1.DataSource = ds.Tables(0)
        cn.Open()
        Call pnr()
    End Sub

    Private Sub tnocombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tnocombo.SelectedIndexChanged
        Traininfo_module.Tinfo()
    End Sub

    Private Sub txtpage_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpage.TextChanged

        If (txtpage.Text) < "18" Then
            lblchildres.Text = "Yes"
            lbladultres.Text = "No"
        ElseIf (txtpage.Text) > "18" Then
            lblchildres.Text = "No"
            lbladultres.Text = "Yes"
        End If

    End Sub

    Private Sub classcombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles classcombo.SelectedIndexChanged
        lblclassres.Text = classcombo.Text
    End Sub

    Private Sub btnmaketick_Click(sender As System.Object, e As System.EventArgs) Handles btnmaketick.Click

        Module_paybleAmmount.ammount()
        lbltdnores.Text = tnocombo.Text
        lbltstatires.Text = tostationcombo.Text
        lbltdfstationres.Text = frmstationcombo.Text
        lbltdtnamers.Text = lbltsname.Text
        lbltdbirthres.Text = bithcombo.Text
        lbltdnameres.Text = txtpname.Text
        lbltdageres.Text = txtpage.Text
        lbltdcontctres.Text = txtpcontact.Text
        txttdaddress.Text = txtpaddress.Text
        If (radmale.Checked) Then
            lbltdsexres.Text = "Male"
        ElseIf (radfemale.Checked) Then
            lbltdsexres.Text = "Female"
        End If

        cn.Open()
        cmd.CommandText = "INSERT into passanger (PNR,Train_No,Train_Name,From_Station,To_Station,Date,Birth,Passanger_Name,Sex,Age,Contact,Address,Ammount) VALUES ('" & Me.lblpnrres.Text & "','" & Me.lbltdnores.Text & "','" & Me.lbltdtnamers.Text & "','" & Me.lbltdfstationres.Text & "','" & Me.lbltstatires.Text & "','" & Me.DateTimePicker1.Text & "','" & Me.lbltdbirthres.Text & "','" & Me.lbltdnameres.Text & "','" & Me.lbltdsexres.Text & "','" & Me.lbltdageres.Text & "','" & Me.lbltdcontctres.Text & "','" & Me.txttdaddress.Text & "','" & Me.lblgt.Text & "')"
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            Call updatedg()
            MsgBox("Record Added.")
            lblpnrres.Text = lblpnrres.Text + 1
        Else
            MsgBox("Record not added.")
        End If
        cn.Close()

        frmmail.Show()
        frmmail.Hide()
        '************************************************************************************************
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("trsbygaurav@gmail.com", "Gaurav@12345")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(frmmail.txtmby.Text)
            e_mail.To.Add(txtemail.Text)
            e_mail.Subject = "Email Sending"
            e_mail.IsBodyHtml = False
            e_mail.Body = frmmail.txtmessage.Text
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent Successfully.")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
        '***************************************************************************************************

    End Sub

    Private Sub frmstationcombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles frmstationcombo.SelectedIndexChanged
        journeydis_module.distance()
    End Sub

    Private Sub tostationcombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tostationcombo.SelectedIndexChanged
        journeydis_module.distance()
    End Sub

    Private Sub btnclearps_Click(sender As System.Object, e As System.EventArgs) Handles btnclearps.Click
        txtpname.Text = ""
        txtpage.Text = ""
        txtpcontact.Text = ""
        txtpaddress.Text = ""
    End Sub

    Sub ex()
        Dim cnf As Integer = MsgBox("Are you sure ?", vbYesNo)
        If cnf = vbYes Then
            Me.Close()
        Else
            cnf = Nothing
        End If
    End Sub

    Private Sub btnexit_Click(sender As System.Object, e As System.EventArgs) Handles btnexit.Click
        Call ex()
    End Sub

    Private Sub btndelete_Click(sender As System.Object, e As System.EventArgs) Handles btndelete.Click
        frmdel.Show()
    End Sub


    Private Sub updatedg()
        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HeartHacker\documents\visual studio 2010\Projects\Train reservation system\Train Reservation System\Database1.mdf;Integrated Security=True;User Instance=True")
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim str1 As String = "select * from passanger"
        da.SelectCommand = New SqlCommand(str1, conn)
        da.Fill(ds, "passanger")
        conn.Close()
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub txtpcontact_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpcontact.TextChanged
        If txtpcontact.MaxLength = txtpcontact.MaxLength Then
            restriction_module.restrict()
        End If
    End Sub

    Sub pnr()
        Dim recordCount As Integer = 0
        For Each table As DataTable In ds.Tables
            recordCount += table.Rows.Count
            lblpnrres.Text = recordCount.ToString()
            lblpnrres.Text = lblpnrres.Text + 1
            cn.Close()
        Next
    End Sub
End Class
