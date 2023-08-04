Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resp As Integer
        resp = MessageBox.Show("BotãoYes_No_Cancel", "vb.net",
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class