'A module for setting up the journey Distance. :-)

Module journeydis_module
    Sub distance()
        If (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
            Mainfrm.lbldis.Text = "380"
        ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
            Mainfrm.lbldis.Text = "380"
        ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
            Mainfrm.lbldis.Text = "252"
        ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
            Mainfrm.lbldis.Text = "252"
        ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
            Mainfrm.lbldis.Text = "316.7"
        ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
            Mainfrm.lbldis.Text = "316.7"
        ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
            Mainfrm.lbldis.Text = "580.80"
        ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
            Mainfrm.lbldis.Text = "580.80"
        ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
            Mainfrm.lbldis.Text = "91.0"
        ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
            Mainfrm.lbldis.Text = "91.0"
        ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
            Mainfrm.lbldis.Text = "173.3"
        ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
            Mainfrm.lbldis.Text = "173.3"
        ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Delhi") Then
            Mainfrm.lbldis.Text = "488.8"
        ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
            Mainfrm.lbldis.Text = "488.8"
        ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Delhi") Then
            Mainfrm.lbldis.Text = "363.3"
        ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
            Mainfrm.lbldis.Text = "363.3"
        ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Delhi") Then
            Mainfrm.lbldis.Text = "248"
        ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
            Mainfrm.lbldis.Text = "248"
        ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Delhi") Then
            Mainfrm.lbldis.Text = "259"
        ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
            Mainfrm.lbldis.Text = "259"
        ElseIf (Mainfrm.frmstationcombo.Text) = (Mainfrm.tostationcombo.Text) Then
            Mainfrm.lbldis.Text = "00"
            MsgBox("Same destinition , Journey not possible")
        End If
    End Sub
End Module
