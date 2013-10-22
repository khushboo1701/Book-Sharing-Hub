Imports System.Data.OleDb
Partial Public Class Signup
    Inherits System.Web.UI.Page
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label5.Text = ""
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If NAME.Text = "" Or RNO.Text = "" Or EMAIL.Text = "" Or USERNAME.Text = "" Or PASSWORD.Text = "" Or PHONE.Text = "" Then
            Label5.Text = "Entries cannot be left blank"
        ElseIf PASSWORD.Text <> TextBox6.Text Then
            Label5.Text = "Passwords do not match"
        Else
            con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
            con.Open()
            cmd = New OleDbCommand("insert into signup values('" + NAME.Text + "','" + RNO.Text + "','" + EMAIL.Text + "','" + USERNAME.Text + "','" + PASSWORD.Text + "','" + PHONE.Text + "')", con)
            cmd.ExecuteNonQuery()
            con.Close()

            con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
            con.Open()
            cmd = New OleDbCommand("insert into login values('" + USERNAME.Text + "', '" + PASSWORD.Text + "')", con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("entry Saved")
            Response.Redirect("session.aspx")
        End If

    End Sub
End Class