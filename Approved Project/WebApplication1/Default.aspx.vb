Imports System.Data.OleDb
Public Class _Default
    Inherits System.Web.UI.Page
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If TextBox1.Text = "" Or TextBox1.Text = "Search" Then
            Label1.Text = "Enter value"
        Else
            Session("ss3") = DropDownList1.Text
            Session("ss4") = TextBox1.Text
            Response.Redirect("Subjects.aspx")
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
    End Sub

End Class