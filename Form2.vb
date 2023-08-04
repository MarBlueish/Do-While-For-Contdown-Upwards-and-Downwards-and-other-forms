Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resp As Integer
        resp = MessageBox.Show("BotãoYes_No_Cancel", "vb.net",
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

        If resp = vbYes Then
            MessageBox.Show("Botão Yes pressionado", "vb.net")
        ElseIf resp = vbNo Then
            MessageBox.Show("Botão No Pressionado", "vb.net")
        ElseIf resp = vbCancel Then
            MessageBox.Show("Botão Cancel Pressionado", "vb.net")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resp As Integer
        resp = MessageBox.Show("Botão OK", "vb.net",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resp As Integer
        resp = MessageBox.Show("Botão Abort_Retry_Ignore", "vb.net",
            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)

        If resp = vbAbort Then
            MessageBox.Show("Botão Abort pressionado", "vb.net")
        ElseIf resp = vbRetry Then
            MessageBox.Show("Botão Retry pressionado", "vb.net")
        ElseIf resp = vbIgnore Then
            MessageBox.Show("Botão Retry pressionado", "vb.net")
        End If

    End Sub
End Class