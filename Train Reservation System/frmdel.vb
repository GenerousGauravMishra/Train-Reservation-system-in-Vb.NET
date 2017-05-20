Imports System.Data.SqlClient
Public Class frmdel
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HeartHacker\documents\visual studio 2010\Projects\Train reservation system\Train Reservation System\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim com As String = "SELECT *from Passanger"
    Dim adpt As New SqlDataAdapter(com, cn)
    Dim ds As New DataSet

    Private Sub frmdel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Module_properties.prop()
        cmd.Connection = cn
        adpt.Fill(ds, "Passanger")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btndfind_Click(sender As System.Object, e As System.EventArgs) Handles btndfind.Click
        If (txtdel.Text = "") Then
            Dim i As Integer = MsgBox("Please Enter a number in the TEXT box", vbOK)
            If i = vbOK Then
                i = Nothing
            End If
        Else
            cn.Open()
            cmd.CommandText = "SELECT *from passanger where PNR='" & txtdel.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            Call updatedg()
            txtdel.Text = ""
        End If
    End Sub

    Private Sub btnddelete_Click(sender As System.Object, e As System.EventArgs) Handles btnddelete.Click
        If (txtdel.Text = "") Then
            Dim i As Integer = MsgBox("Please Enter a number in the TEXT box", vbOK)
            If i = vbOK Then
                i = Nothing
            End If
        Else
            Dim cnf As Integer = MsgBox("Are You Sure ", vbYesNo)
            If cnf = vbYes Then
                cn.Open()
                cmd.CommandText = "delete from passanger where PNR= ('" & txtdel.Text & "')"
                Dim c As Integer = cmd.ExecuteNonQuery()
                If c > 0 Then
                    Call updatedg()
                    MsgBox("Record Deleted , It can`t Be Undone.")

                Else
                    MsgBox("Record Not deleted.")
                End If
                cn.Close()
            Else

            End If

        End If
        txtdel.Text = ""

        'Dim recordCount As Integer = 0
        'For Each table As DataTable In ds.Tables
        'recordCount += table.Rows.Count
        'Mainfrm.lblpnrres.Text = recordCount.ToString()
        'Mainfrm.lblpnrres.Text = Mainfrm.lblpnrres.Text + 1
        'cn.Close()
        'Next
    End Sub

    Private Sub btnexit_Click(sender As System.Object, e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    'Sub null()
    '   If (txtdel.Text = "") Then
    'Dim i As Integer = MsgBox("Please Enter a number in the TEXT box", vbOK)
    '       If i = vbOK Then
    '          i = Nothing
    '     End If
    'End If
    'End Sub
    Private Sub updatedg()
        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HeartHacker\documents\visual studio 2010\Projects\Train reservation system\Train Reservation System\Database1.mdf;Integrated Security=True;User Instance=True")
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim str1 As String = "select * from passanger"
        da.SelectCommand = New SqlCommand(str1, conn)
        da.Fill(ds, "passanger")
        conn.Close()
        DataGridView1.DataSource = ds.Tables(0)
        Mainfrm.DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class