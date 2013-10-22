Imports System.Data.OleDb
Partial Public Class WebForm4
    Inherits System.Web.UI.Page
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label3.Text = Date.Now.Second.ToString() + Date.Now.Millisecond.ToString()

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Manadatory entries cannot be left blank")
        Else
            con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
            con.Open()
            cmd = New OleDbCommand("insert into booksell values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "', '" + Label3.Text + "')", con)
            cmd.ExecuteNonQuery()
            con.Close()
            Session("ss0") = TextBox1.Text
            Session("ss5") = Label3.Text
            Response.Redirect("sell_confirm.aspx")
        End If
    End Sub

   
    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class