Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub


    Protected Sub CmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click

        'Check for valid password field (must match)
        If (txtPass.Text = txtPassConfirm.Text) Then
            lbl_error.Text = "Welcome," + txtUsername.Text + "!"
        End If


        ' If passwords are not equal !=
        If (txtPass.Text <> txtPassConfirm.Text) Then
            txtPass.Text = ""
            txtPassConfirm.Text = ""
            lbl_error.Text = "Passwords don't match."
        End If





    End Sub

End Class