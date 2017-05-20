Imports System.Data.SqlClient
Public Class frmlogin
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HeartHacker\documents\visual studio 2010\Projects\Train reservation system\Train Reservation System\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim ds As New DataSet()
    Dim com As String = "select *form login"
    Dim adpt As New SqlDataAdapter(com, cn)

    Private Sub frmlogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Module_properties.prop()
        cmd.Connection = cn
    End Sub

    Private Sub chkbx_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbx.CheckedChanged
        If txtpass.PasswordChar = "*" Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        cn.Open()

        cn.Close()
    End Sub
End Class