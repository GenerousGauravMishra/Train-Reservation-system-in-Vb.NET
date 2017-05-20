Public Class frmmail

    Private Sub E_mail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtmessage.Text = "Hello! Mr./Miss " & Mainfrm.txtpname.Text & " Your train reservation is successfull for the journey of (" & Mainfrm.frmstationcombo.Text & " TO " & Mainfrm.tostationcombo.Text & ") On the date of (" & Mainfrm.DateTimePicker1.Text & ") your paid ammount is Rs.(" & Mainfrm.lblgt.Text & ") For more information call +91-9456510074 , Thanks for using Train Reservation System By Gaurav Mishra  , HAPPY JOURNEY.."
        txtmby.Text = "trsbygaurav@gmail.com"
    End Sub
End Class