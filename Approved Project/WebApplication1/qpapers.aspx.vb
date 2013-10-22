Public Class WebForm6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If DropDownList1.Text = "SEM1" Then
            Panel1.Visible = True
        ElseIf DropDownList1.Text = "SEM2" Then
            Panel2.Visible = True
        ElseIf DropDownList1.Text = "SEM3" Then
            Panel3.Visible = True
        ElseIf DropDownList1.Text = "SEM4" Then
            Panel4.Visible = True
        ElseIf DropDownList1.Text = "SEM5" Then
            Panel5.Visible = True
        End If
    End Sub
End Class