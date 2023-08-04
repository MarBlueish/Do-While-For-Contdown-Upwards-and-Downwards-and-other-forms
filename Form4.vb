Public Class Form4
    Dim n As Integer
    Dim resp As Integer

    Private Sub cmd_addItem_Click(sender As Object, e As EventArgs) Handles cmd_addItem.Click
        Dim n As Integer
        n = InputBox("Inserir Número", "vb.net")
        ListView1.Items.Add(n)
    End Sub

    Private Sub cmd_limpa_Click(sender As Object, e As EventArgs) Handles cmd_limpa.Click
        ListView1.Clear()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub cmd_add10_Click(sender As Object, e As EventArgs) Handles cmd_add10.Click

        For i = 1 To 10
            n = InputBox("N" & i, "inserir 10 números")
            ListView1.Items.Add(n)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class