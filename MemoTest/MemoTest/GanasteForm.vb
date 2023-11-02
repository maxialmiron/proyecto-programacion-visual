Public Class GanasteForm
    Private Sub SiBtn_Click(sender As Object, e As EventArgs) Handles SiBtn.Click
        'si el usuario acepta, el form partida comienza nuevamente
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub NoBtn_Click(sender As Object, e As EventArgs) Handles NoBtn.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class