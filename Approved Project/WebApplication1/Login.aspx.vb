Imports System.Data.OleDb
Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Response.Redirect("Signup.aspx")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            Label1.Text = "Enter username"
        ElseIf (TextBox2.Text = "") Then
            Label1.Text = "Enter a password"

        Else
            con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
            con.Open()
            cmd = New OleDbCommand("select Password from Login where user_name = '" + TextBox1.Text + "' ", con)
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then

                If (TextBox2.Text = dr(0)) Then

                    Response.Redirect("session.aspx")
                Else
                    MsgBox("Invalid Password")
                End If
            Else
                MsgBox("Wrong Username")

            End If

        End If
    End Sub
End Class