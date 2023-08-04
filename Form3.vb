Option Explicit On 'força declaração de variaveis
Public Class Form3
    Dim n, i, n_inicial, n_final, dia As Integer 'vars globais
    Dim txt As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim n2 As Integer
        Dim N_txt As String
        Dim N2_txt As String

        N_txt = Txtin.Text
        N2_txt = Txtfin.Text

        If Integer.TryParse(N_txt, n) AndAlso Integer.TryParse(N2_txt, n2) Then ' Safely parse the input strings to integers.
            If n2 > n Then ' Contagem crescente
                Do While n <= n2
                    MessageBox.Show("Do While " & n, "Contagem Crescente Do While")
                    n += 1
                Loop
            ElseIf n2 < n Then ' Contagem decrescente
                Do While n >= n2
                    MessageBox.Show("Do While " & n, "Contagem Decrescente Do While")
                    n -= 1
                Loop
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim N_txt As Integer
        Dim N2_Txt As Integer
        Dim i As Integer

        Integer.TryParse(Txtin.Text, N_txt)
        Integer.TryParse(Txtfin.Text, N2_Txt)

        ' Contagem crescente
        If N2_Txt > N_txt Then
            For i = N_txt To N2_Txt
                MessageBox.Show("For " & i, "Contagem Crescente")
            Next i

            ' Contagem decrescente
        ElseIf N2_Txt < N_txt Then
            For i = N_txt To N2_Txt Step -1
                MessageBox.Show("For " & i, "Contagem Decrescente")
            Next i
        End If
    End Sub
End Class