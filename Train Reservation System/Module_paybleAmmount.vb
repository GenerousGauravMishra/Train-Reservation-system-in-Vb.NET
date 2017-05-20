'A module for setting up the payble ammount of ticket. :-)

Module Module_paybleAmmount
    Sub ammount()
        If Mainfrm.classcombo.Text = "First AC" Then
            If (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = "725"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = "725"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 625"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 625"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 545"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 545"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            End If
        End If

        If Mainfrm.classcombo.Text = "Second AC" Then
            If (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = "600"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = "600"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 625"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 625"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 545"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 545"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            End If
        End If
        If Mainfrm.classcombo.Text = "Third AC" Then
            If (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = "500"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = "500"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 625"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 625"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 545"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 545"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            End If
        End If
        If Mainfrm.classcombo.Text = "Sleeper" Then
            If (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = "230"
                Mainfrm.lblst.Text = "5"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = "230"
                Mainfrm.lblst.Text = "5"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 625"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 625"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 545"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 545"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Lucknow") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Lucknow") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Shahjahanpur") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Shahjahanpur") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Dehradun") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Dehradun") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Bareilly") And (Mainfrm.tostationcombo.Text = "Delhi") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            ElseIf (Mainfrm.frmstationcombo.Text = "Delhi") And (Mainfrm.tostationcombo.Text = "Bareilly") Then
                Dim total As Integer
                Mainfrm.lblt.Text = " 1450"
                Mainfrm.lblst.Text = "10"
                total = Val(Mainfrm.lblt.Text) + Val(Mainfrm.lblst.Text)
                Mainfrm.lblgt.Text = total
            End If
        End If
    End Sub
End Module
