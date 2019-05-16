Public Class Bienvenida
    Dim Contador As Byte = 0

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            Contador = Contador + 1
            ProgressBar1.Value = Contador
        Else
            Me.Hide()
            Form1.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class