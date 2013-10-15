Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Response.Redirect("Signup.aspx")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "admin" & TextBox2.Text = "123") Then
            Response.Redirect("welcome.aspx")
        End If

        If (TextBox1.Text = "") Then
            Label1.Text = "Enter username"
        ElseIf (TextBox2.Text = "") Then
            Label1.Text = "Enter a password"
        End If
    End Sub
End Class