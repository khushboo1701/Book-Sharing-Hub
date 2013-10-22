Imports System.Data.OleDb
Public Class feedback
    Inherits System.Web.UI.Page
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Manadatory entries cannot be left blank")
        Else
            con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
            con.Open()
            cmd = New OleDbCommand("insert into feedback values('" + TextBox1.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "' )", con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Thanks for your feedback")
            Response.Redirect("Default.aspx")
        End If
    End Sub
End Class