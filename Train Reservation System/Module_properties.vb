'A module for setting up the properties of the objects.  :-)n                                  
Module Module_properties
    Sub prop()

        Mainfrm.Text = "Welcome To Train Reservation System"
        frmdel.Text = "Find OR Delete Ticket"

        Mainfrm.btndelete.Text = "Delete OR Find Ticket"
        Mainfrm.lblmain.Text = "Train Reservation System"
        Mainfrm.lblpname.Text = "Name"
        Mainfrm.lblsex.Text = "Sex"
        Mainfrm.lblage.Text = "Age"
        Mainfrm.lblcontact.Text = "Contact"
        Mainfrm.lbladdress.Text = "Address"
        Mainfrm.lblclass.Text = "Class"
        Mainfrm.lbltno.Text = "Train no."
        Mainfrm.lblfstation.Text = "From station"
        Mainfrm.lbltstation.Text = "To station"
        Mainfrm.lbldoj.Text = "Date of journey"
        Mainfrm.lblbirth.Text = "Birth"
        Mainfrm.lblcomp.Text = "Class"
        Mainfrm.lblchild.Text = "Child"
        Mainfrm.lbladult.Text = "Adult"
        Mainfrm.lblclassres.Text = ""
        Mainfrm.lblchildres.Text = ""
        Mainfrm.lbladultres.Text = ""
        Mainfrm.lbltdageres.Text = ""
        Mainfrm.lbltdcontctres.Text = ""
        Mainfrm.lbltdnameres.Text = ""
        Mainfrm.lbltdtname.Text = ""
        Mainfrm.lbltdsexres.Text = ""
        Mainfrm.lbltdtnamers.Text = ""
        Mainfrm.lbltdnores.Text = ""
        Mainfrm.lbltdfstationres.Text = ""
        Mainfrm.lbltdtstation .Text = ""
        Mainfrm.lbltdbirthres.Text = ""
        Mainfrm.lbltstatires.Text = ""
        Mainfrm.lblsubt.Text = "Sub Total"
        Mainfrm.lbltax.Text = "Tax"
        Mainfrm.lblgrandt.Text = "Grand Total"
        Mainfrm.lblst.Text = "00"
        Mainfrm.lblt.Text = "00"
        Mainfrm.lblgt.Text = "00"
        Mainfrm.lblstrainno.Text = ""
        Mainfrm.lbltsname.Text = ""
        Mainfrm.lblsft.Text = ""
        Mainfrm.lblpnrres.Text = "0"
        Mainfrm.lblpnr.Text = "PNR"
        Mainfrm.lbltpname.Text = "Name"
        Mainfrm.lbltpsex.Text = "Sex"
        Mainfrm.lbltpage.Text = "Age"
        Mainfrm.lbltpcontact.Text = "Contact"
        Mainfrm.lbltpaddress.Text = "Address"
        Mainfrm.lbltdbirth.Text = "Birth"
        Mainfrm.lbltdtname.Text = "Train Name"
        Mainfrm.lbltdfstation.Text = "From Station"
        Mainfrm.lbltdtno.Text = "Train no"
        Mainfrm.lbltdtstation.Text = "To Station"
        Mainfrm.lbljdis.Text = "Journey Distance"
        Mainfrm.lbldis.Text = "00"
        Mainfrm.lblkm.Text = "KM"

        Mainfrm.btnclearps.Text = "Clear"
        Mainfrm.btnexit.Text = "Exit"
        Mainfrm.btnresetall.Text = "Reset All"
        Mainfrm.btnmaketick.Text = "Make Ticket"
        'Mainfrm.btnfindtick.Text = "Find Ticket"


        Mainfrm.Pdetailsgroup.Text = "Passanger Details"
        Mainfrm.jdetailsgroup.Text = "journey Details"
        Mainfrm.tinfogroup.Text = "Train Information"
        Mainfrm.pamtgroup.Text = "Payble Ammount"
        Mainfrm.Tckdetailsgroup.Text = "Ticket Details"
        Mainfrm.pdbgroup.Text = "Passanger Database"


        Mainfrm.radmale.Text = "Male"
        Mainfrm.radfemale.Text = "Female"

        Mainfrm.classcombo.Items.Add("First AC")
        Mainfrm.classcombo.Items.Add("Second AC")
        Mainfrm.classcombo.Items.Add("Third AC")
        Mainfrm.classcombo.Items.Add("Sleeper")

        Mainfrm.tnocombo.Items.Add("13009")
        Mainfrm.tnocombo.Items.Add("14266")
        Mainfrm.tnocombo.Items.Add("15005")

        Mainfrm.frmstationcombo.Items.Add("Shahjahanpur")
        Mainfrm.frmstationcombo.Items.Add("Dehradun")
        Mainfrm.frmstationcombo.Items.Add("Lucknow")
        Mainfrm.frmstationcombo.Items.Add("Bareilly")
        Mainfrm.frmstationcombo.Items.Add("Delhi")

        Mainfrm.tostationcombo.Items.Add("Shahjahanpur")
        Mainfrm.tostationcombo.Items.Add("Dehradun")
        Mainfrm.tostationcombo.Items.Add("Lucknow")
        Mainfrm.tostationcombo.Items.Add("Bareilly")
        Mainfrm.tostationcombo.Items.Add("Delhi")

        Mainfrm.bithcombo.Items.Add("Upper")
        Mainfrm.bithcombo.Items.Add("Middle")
        Mainfrm.bithcombo.Items.Add("Lower")
        Mainfrm.bithcombo.Items.Add("Side Upper")
        Mainfrm.bithcombo.Items.Add("Side Lower")

        Mainfrm.txttdaddress.ReadOnly = True

        frmdel.lbldel.Text = "Enter PNR"
        frmdel.btndfind.Text = "Find"
        frmdel.btnddelete.Text = "Delete Ticket"

        frmdel.btnexit.Text = "Exit"

        frmdel.MaximizeBox = False
        frmdel.MinimizeBox = False
        frmdel.HelpButton = True

        frmdel.lblm.Text = "Find OR Delete Ticket"

        frmlogin.lbllmain.Text = "Train Reservation System Login"
        Mainfrm.lblemail.Text = "Email"
        frmlogin.Text = "Train Reservation System Login Panel"
        frmlogin.MaximizeBox = False
        frmlogin.MinimizeBox = False
        frmlogin.grplogin.Text = ""
        frmlogin.btnlogin.Text = "Login"
        frmlogin.txtpass.PasswordChar = "*"
        frmlogin.chkbx.Text = "Show Password"
        frmlogin.lblpass.Text = "Password"
        frmlogin.lbluname.Text = "Username"

        frmlogin.lblabt.Text = "About"

        Mainfrm.txtpcontact.MaxLength = 10

        Mainfrm.lblmaxlen.Text = ""
    End Sub
End Module