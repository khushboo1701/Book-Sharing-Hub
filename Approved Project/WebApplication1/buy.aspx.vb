Imports System.Data.OleDb
Public Class buy
    Inherits System.Web.UI.Page
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label3.Text = Session("ss6")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Manadatory entries cannot be left blank")
        Else
            con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
            con.Open()
            cmd = New OleDbCommand("insert into buybook values('" + Label3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox5.Text + "' )", con)
            cmd.ExecuteNonQuery()
            con.Close()
            Session("ss7") = TextBox1.Text
            Session("ss8") = Label3.Text
            Response.Redirect("buy_confirm.aspx")
        End If

    End Sub
End Class