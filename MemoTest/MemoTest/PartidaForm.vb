Imports System.Reflection
Imports System.Reflection.Emit

Public Class PartidaForm

    Dim listaDeImagenes As New List(Of Image)
    Dim ultimoSeleccionado As PictureBox
    Dim segundosTranscurridos As Integer = 0
    Dim totalBoxSeleccionadas As Integer = 0
    Dim loaded As Boolean = False
    Dim cerrarFormSinPreguntar As Boolean = False
    Dim mejorTiempo As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarDatos()
        loaded = True
    End Sub

    Private Function GenerarNumeroAleatorio(total As Integer) As Integer
        ' Crea una instancia de la clase Random
        Dim generadorAleatorio As New Random()

        ' Genera un número aleatorio entre 0 y 16
        Dim numeroAleatorio As Integer = generadorAleatorio.Next(total)

        ' Devuelve el número aleatorio generado
        Return numeroAleatorio
    End Function

    Private Sub cargarImagenes()

        Dim Orange As Image = My.Resources.orange
        Dim Apple As Image = My.Resources.apple
        Dim Lemon As Image = My.Resources.lemon
        Dim Banana As Image = My.Resources.banana
        Dim Strawberry As Image = My.Resources.strawberry
        Dim Pineapple As Image = My.Resources.pineapple
        Dim Grape As Image = My.Resources.grape
        Dim Watermelon As Image = My.Resources.watermelon

        listaDeImagenes.Add(Orange)
        listaDeImagenes.Add(Apple)
        listaDeImagenes.Add(Lemon)
        listaDeImagenes.Add(Banana)
        listaDeImagenes.Add(Strawberry)
        listaDeImagenes.Add(Pineapple)
        listaDeImagenes.Add(Grape)
        listaDeImagenes.Add(Watermelon)
        listaDeImagenes.Add(Orange)
        listaDeImagenes.Add(Apple)
        listaDeImagenes.Add(Lemon)
        listaDeImagenes.Add(Banana)
        listaDeImagenes.Add(Strawberry)
        listaDeImagenes.Add(Pineapple)
        listaDeImagenes.Add(Grape)
        listaDeImagenes.Add(Watermelon)

    End Sub

    Private Function ExtraerYRemoverItem(index As Integer) As Image
        ' valido que el indice este dentro del rango de la lista imagenes
        If index >= 0 AndAlso index < listaDeImagenes.Count Then
            ' Extraigo el item en el index especificado
            Dim item As Image = listaDeImagenes(index)
            ' Remuevo el item ya asignado
            listaDeImagenes.RemoveAt(index)
            Return item
        End If
    End Function

    Private Sub Box_Click(sender As Object, e As EventArgs)
        sender.Image = sender.Tag
        If ultimoSeleccionado IsNot Nothing Then
            compararConUltimo(sender)
        Else
            ultimoSeleccionado = sender
        End If
    End Sub


    Private Sub habilitarBoxs(enabled As Boolean)
        For Each control As Control In Me.Panel1.Controls
            If TypeOf control Is PictureBox Then
                Dim pictureBox As PictureBox = DirectCast(control, PictureBox)
                pictureBox.Enabled = enabled
            End If
        Next
    End Sub


    Private Async Sub compararConUltimo(Box As PictureBox)
        habilitarBoxs(False)

        If ultimoSeleccionado IsNot Nothing Then
            If Box.Image.Equals(ultimoSeleccionado.Image) Then
                Await SimularEspera()
                Box.Visible = False
                ultimoSeleccionado.Visible = False
                ultimoSeleccionado = Nothing
                totalBoxSeleccionadas += 1
            Else
                Await SimularEspera()
                Box.Image = My.Resources.question
                ultimoSeleccionado.Image = My.Resources.question
                ultimoSeleccionado = Nothing
            End If
        End If

        habilitarBoxs(True)

        If totalBoxSeleccionadas = 8 Then
            Timer1.Stop()
            If mejorTiempo = 0 Then
                mejorTiempo = segundosTranscurridos
            Else
                If segundosTranscurridos < mejorTiempo Then
                    mejorTiempo = segundosTranscurridos
                End If
            End If

            Dim minutos As Integer = mejorTiempo \ 60
            Dim segundos As Integer = mejorTiempo Mod 60

            mejorTiempoLbl.Text = $"{minutos} : {segundos}"

            If GanasteForm.ShowDialog() = DialogResult.OK Then
                iniciarDatos()
            Else
                cerrarFormSinPreguntar = True
                Me.Close()
            End If
        End If

    End Sub

    Private Async Function SimularEspera() As Task
        ' Simulate an asynchronous operation (e.g., loading data from a database)
        Await Task.Run(Sub()
                           System.Threading.Thread.Sleep(1000)
                       End Sub)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        segundosTranscurridos += 1

        Dim minutosTranscurridos As Integer = segundosTranscurridos \ 60
        Dim segundosRestantes As Integer = segundosTranscurridos Mod 60

        TimerLbl.Text = $"{minutosTranscurridos} : {segundosRestantes}"
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing And Not cerrarFormSinPreguntar Then

            Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas abandonar la partida?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ComenzarBtn_Click(sender As Object, e As EventArgs) Handles ComenzarBtn.Click
        Timer1.Interval = 1000
        Timer1.Start()
        ComenzarBtn.Visible = False
        TimerLbl.Visible = True

        habilitarBoxs(True)
    End Sub

    Public Sub iniciarDatos()
        segundosTranscurridos = 0
        totalBoxSeleccionadas = 0
        listaDeImagenes.Clear()
        cargarImagenes()
        ComenzarBtn.Visible = True
        TimerLbl.Visible = False
        TimerLbl.Text = 0
        ultimoSeleccionado = Nothing
        cerrarFormSinPreguntar = False

        setControls()
    End Sub

    Private Sub setControls()
        For Each control As Control In Me.Panel1.Controls

            If TypeOf control Is PictureBox Then
                Dim pictureBox As PictureBox = DirectCast(control, PictureBox)
                Dim index As Integer = GenerarNumeroAleatorio(listaDeImagenes.Count)
                pictureBox.Image = My.Resources.question
                pictureBox.Visible = True
                pictureBox.Tag = ExtraerYRemoverItem(index)
                pictureBox.Enabled = False
                If Not loaded Then
                    AddHandler pictureBox.Click, AddressOf Box_Click
                End If
            End If
        Next
    End Sub

End Class
