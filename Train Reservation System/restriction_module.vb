Module restriction_module
    Public Sub restrict()
        If Mainfrm.txtpcontact.MaxLength = Mainfrm.txtpcontact.MaxLength Then
            Mainfrm.lblmaxlen.Text = "Max length is 10"
        End If
    End Sub
End Module
