Public Class SerialReg

    Private Sub btnSerial_Click(sender As System.Object, e As System.EventArgs) Handles btnSerial.Click
        If txt1.Text & txt2.Text & txt3.Text = My.Settings.Ser Then
            'My.Settings.FechaCaducidad = DateTime.Now.AddDays(365).Date
            'Este código es por sí se le quiere colocar al ususario de
            'Software un tiempo de vencimiento de un año (365 dias).
            My.Settings.ProReg = True
            My.Settings.Save()
            Me.Close()
            MsgBox("Bienvenidos...!" & Chr(13) & Chr(13) & _
                   "...al Sistema de Control de Tablas de" & Chr(13) & _
                   "Presencia del Personal Operativo del" & Chr(13) & _
                   "Metro de Caracas c.a.", MsgBoxStyle.Information, "Bienvenido")
            Form1.ShowDialog()
            Me.Hide()
        Else
            MsgBox("El serial es incorrecto!", MsgBoxStyle.Critical, "Error")
            Me.txt1.Text = ""
            Me.txt2.Text = ""
            Me.txt3.Text = ""
            Me.txt1.Select()
        End If
    End Sub

    Private Sub txt1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 13 Then
            Me.txt2.Focus()
        End If
    End Sub

    Private Sub txt2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 13 Then
            Me.txt3.Focus()
        End If
    End Sub

    Private Sub Serial_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.txt1.Select()
    End Sub
End Class