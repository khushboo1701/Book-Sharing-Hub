Public Class buy_confirm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Session("ss7")
        Label2.Text = Session("ss8")
    End Sub

End Class