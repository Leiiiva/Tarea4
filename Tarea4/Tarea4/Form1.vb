Public Class Form1
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim num, x, i As Integer
        x = 1
        num = txt_num.Text
        For i = 1 To num
            x = x * i
        Next
        lbl_fact.Text = x.ToString()
    End Sub
End Class
