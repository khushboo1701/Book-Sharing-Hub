Imports System.Data.OleDb
Public Class Subjects
    Inherits System.Web.UI.Page
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label20.Text = ""
        Label1.Visible = False
        Label19.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Try
            con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
            con.Open()
            If Session("ss3") = "Subject" Then
                cmd = New OleDbCommand("select saleid from booksell where subject = '" + Session("ss4") + "'", con)
                cmd.ExecuteNonQuery()
            End If
            dr = cmd.ExecuteReader()
            While (dr.Read())
                DropDownList1.Items.Add(dr(0))
                End While
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Label19.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Try
            con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
            con.Open()
            cmd = New OleDbCommand("select subject, title, author, edition, mrp  from booksell where saleid = '" + DropDownList1.Text + "'", con)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            While (dr.Read())
                Label4.Text = dr(0)
                Label5.Text = dr(1)
                Label6.Text = dr(2)
                Label7.Text = dr(3)
                Label1.Text = dr(4)
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class