Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList2.SelectedIndexChanged

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
       
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If DropDownList1.Text = ("Sem1") Then
            DropDownList2.Items.Add(("C").ToString)
            DropDownList2.Items.Add("Discrete")
            DropDownList2.Items.Add("COA")
            DropDownList2.Items.Add("Accounts")
            DropDownList2.Items.Add("Probability")
            DropDownList2.Items.Add("Communication")
        End If
        If DropDownList1.Text = ("Sem2") Then
            DropDownList2.Items.Add("DS")
            DropDownList2.Items.Add("DBMS")
            DropDownList2.Items.Add("CN")
            DropDownList2.Items.Add("OOPS")
            DropDownList2.Items.Add("RMT")
        End If
        If DropDownList1.Text = ("Sem3") Then
            DropDownList2.Items.Add("DM")
            DropDownList2.Items.Add("GRAPHICS")
            DropDownList2.Items.Add("SE")
            DropDownList2.Items.Add("OS")
            DropDownList2.Items.Add("OOAD")

        End If
        If DropDownList1.Text = ("Sem4") Then
            DropDownList2.Items.Add("JAVA")
            DropDownList2.Items.Add("IS")
            DropDownList2.Items.Add("SAPM")
            DropDownList2.Items.Add("ALGORITHMS")
        End If
        If DropDownList1.Text = ("Sem5") Then
            DropDownList2.Items.Add("WEB")
            DropDownList2.Items.Add("DS")
        End If
    End Sub
End Class