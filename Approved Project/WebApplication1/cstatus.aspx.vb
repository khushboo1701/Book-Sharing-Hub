Imports System.Data.OleDb
Partial Public Class cstatus
    Inherits System.Web.UI.Page
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Visible = False
        Label2.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button3.Visible = False
        DropDownList1.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Manadatory entries cannot be left blank")
        Else
            Label1.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            DropDownList1.Visible = True
            Button3.Visible = True
            Label11.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Try
                con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
                con.Open()
                cmd = New OleDbCommand("select name,rno,phone,title,mrp  from booksell where saleid = '" + TextBox1.Text + "'", con)
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

            Try
                con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
                con.Open()
                cmd = New OleDbCommand("select rno from buybook where buyid= '" + TextBox1.Text + "'", con)
                cmd.ExecuteNonQuery()
                dr = cmd.ExecuteReader()
                While (dr.Read())

                    DropDownList1.Items.Add(dr(0))

                End While
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Label1.Visible = True
        Label2.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Button3.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        DropDownList1.Visible = True
        Try
            con = New OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1230;PASSWORD=User127;Data Source=nitt")
            con.Open()
            cmd = New OleDbCommand("select name, phone, amount from buybook where rno = '" + DropDownList1.SelectedItem.Text + "'", con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                Label2.Text = dr(0)
                Label9.Text = dr(1)
                Label10.Text = dr(2)
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class