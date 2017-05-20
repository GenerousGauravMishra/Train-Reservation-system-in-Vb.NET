'A module for setting up the trains info.  :-)
Module Traininfo_module
    Sub Tinfo()
        If Mainfrm.tnocombo.Text = "13009" Then
            Mainfrm.lblstrainno.Text = "13009"
            Mainfrm.lbltsname.Text = "Doon Express"
            Mainfrm.lblsft.Text = "Dehradun To Hawrah"
        ElseIf Mainfrm.tnocombo.Text = "14266" Then
            Mainfrm.lblstrainno.Text = "14266"
            Mainfrm.lbltsname.Text = "Janta Express"
            Mainfrm.lblsft.Text = "Dehradun To Hawrah"
        ElseIf Mainfrm.tnocombo.Text = "15005" Then
            Mainfrm.lblstrainno.Text = "15005"
            Mainfrm.lbltsname.Text = "Rapti Ganga Express"
            Mainfrm.lblsft.Text = "Gorakhpur To Dehradun"
        End If
    End Sub
End Module
