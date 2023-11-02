Public Class InicioForm
    Private Sub JugarBtn_Click(sender As Object, e As EventArgs) Handles JugarBtn.Click
        PartidaForm.ShowDialog()
    End Sub

    Private Sub InstruccionesBtn_Click(sender As Object, e As EventArgs) Handles InstruccionesBtn.Click
        InstruccionesForm.ShowDialog()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'Pregunta al usuario si desea iniciar una partida antes de abandonar el juego
        If e.CloseReason = CloseReason.UserClosing Then
            Dim resultado As DialogResult = MessageBox.Show("¿Desea iniciar una partida antes de abandonar el juego?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                PartidaForm.Show()
                e.Cancel = True

            End If
        End If
    End Sub

    Private Sub CreditosBtn_Click(sender As Object, e As EventArgs) Handles CreditosBtn.Click
        CreditosForm.Show()
    End Sub

End Class