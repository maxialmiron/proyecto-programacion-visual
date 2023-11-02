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

    'evento que llama al cargar el form
    Private Sub PartidaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarDatos()

        'flag que se utiliza una vez q se cargo el form para evitar asignar mas de un evento a cada carta
        loaded = True
    End Sub

    'Reinicia las variables a sus valores por defecto para poder jugar una nueva partida
    'carga imagenes
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
        TimerLbl.BackColor = Color.White
        setControls()
    End Sub

    'Asigna una imagen random del listado a cada carta, osea a cada control picturebox
    Private Sub setControls()
        For Each control As Control In Me.Panel1.Controls

            If TypeOf control Is PictureBox Then
                Dim pictureBox As PictureBox = DirectCast(control, PictureBox)

                'obtengo un nro ramdom ,enviando el maximo nro permitido que es la cantidad restante de imagenes'
                ' a medida q se van extrayendo imagenes el nro decrece
                Dim index As Integer = GenerarNumeroAleatorio(listaDeImagenes.Count)
                pictureBox.Image = My.Resources.question
                pictureBox.Visible = True
                'Guardo en esta propiedad el valor real de una imagen random
                pictureBox.Tag = ExtraerYRemoverItem(index)
                pictureBox.Enabled = False

                ' le asigno la funcion Box_Click a cada carta para no tener que repetirlo por cada una
                'entonces la misma funcion aplica para todas las cartas
                'si el formulario ya se cargo no hace falta volver a asignarle la funcion en cada partida
                If Not loaded Then
                    AddHandler pictureBox.Click, AddressOf Box_Click
                End If
            End If
        Next
    End Sub

    'Esta funcion permite obtener un item de la lista de imagenes
    'segun el valor enviado como parametro y lo remueve de la lista
    'para no volver a utlizar esa imagen
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

    ' Genera un número aleatorio , el maximo es el nro que se envia como parametro
    Private Function GenerarNumeroAleatorio(total As Integer) As Integer
        Dim generadorAleatorio As New Random()
        Dim numeroAleatorio As Integer = generadorAleatorio.Next(total)
        Return numeroAleatorio
    End Function

    ' Cargo una lista con cada par de imagenes
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

    'evento que maneja el click en cada carta
    Private Sub Box_Click(sender As Object, e As EventArgs)
        sender.Image = sender.Tag
        If ultimoSeleccionado IsNot Nothing Then
            compararConUltimo(sender)
        Else
            ultimoSeleccionado = sender
        End If
    End Sub

    'habilito o deshabilito todas las cartas segun el flag
    Private Sub habilitarBoxs(enabled As Boolean)
        For Each control As Control In Me.Panel1.Controls
            If TypeOf control Is PictureBox Then
                Dim pictureBox As PictureBox = DirectCast(control, PictureBox)
                pictureBox.Enabled = enabled
            End If
        Next
    End Sub

    'compara cada carta con la ultima seleccionada para verificar si
    'hay coincidencia
    Private Async Sub compararConUltimo(Box As PictureBox)

        'deshabilito las cartas para evitar seleccionar una tercera
        habilitarBoxs(False)

        If ultimoSeleccionado IsNot Nothing Then
            If Box.Image.Equals(ultimoSeleccionado.Image) Then
                Await SimularEspera()
                Box.Visible = False
                ultimoSeleccionado.Visible = False
                ultimoSeleccionado = Nothing

                'Sumo cada coincidencia
                totalBoxSeleccionadas += 1
            Else
                Await SimularEspera()
                Box.Image = My.Resources.question
                ultimoSeleccionado.Image = My.Resources.question
                ultimoSeleccionado = Nothing
            End If
        End If

        'habilito nuevamente todas las cartas disponibles
        habilitarBoxs(True)

        'Si el total de coincidencias es la mitad del total cartas gana el juego
        If totalBoxSeleccionadas = 8 Then

            'guardo el tiempo y lo comparo con el mejor tiempo anterior
            'si es menor lo reemplaza
            Timer1.Stop()
            If mejorTiempo = 0 Then
                mejorTiempo = segundosTranscurridos
            Else
                If segundosTranscurridos < mejorTiempo Then
                    mejorTiempo = segundosTranscurridos
                End If
            End If

            ´ convierto los segundos transcurridos a minutos y segundos
            Dim minutos As Integer = mejorTiempo \ 60
            Dim segundos As Integer = mejorTiempo Mod 60

            mejorTiempoLbl.Text = $"{minutos} : {segundos}"

            ' abro el form de juego ganado
            If GanasteForm.ShowDialog() = DialogResult.OK Then
                iniciarDatos()
            Else
                cerrarFormSinPreguntar = True
                Me.Close()
            End If
        End If

    End Sub

    ' esta funcion me permite esperar un tiempo cuando selecciono la siguiente carta 
    ' para poder visualizar la imagen contenida
    Private Async Function SimularEspera() As Task
        Await Task.Run(Sub()
                           System.Threading.Thread.Sleep(1000)
                       End Sub)
    End Function

    ' comienza el juego, corre el tiempo y habilita la seleccion de cartas
    Private Sub ComenzarBtn_Click(sender As Object, e As EventArgs) Handles ComenzarBtn.Click
        ' se actualiza cada 1 segundo el timer
        Timer1.Interval = 1000
        Timer1.Start()
        ComenzarBtn.Visible = False
        TimerLbl.Visible = True

        habilitarBoxs(True)
    End Sub

    ' creo un timer para el tiempo transcurrido desde que comienza el juego
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        segundosTranscurridos += 1

        Dim minutosTranscurridos As Integer = segundosTranscurridos \ 60
        Dim segundos As Integer = segundosTranscurridos Mod 60

        TimerLbl.Text = $"{minutosTranscurridos} : {segundos}"

        'si quedan 10 segundos para los 3 minutos se cambia el label del tiempo a rojo
        If segundosTranscurridos >= 170 Then
            TimerLbl.BackColor = Color.Red
        End If

        'si llega a 3 minutos se finaliza la partida y pregunta al usuario y desea iniciar otra
        If segundosTranscurridos >= 180 Then
            Timer1.Stop()
            Dim resultado As DialogResult = MessageBox.Show("Se agoto el tiempo.¿Desea iniciar otra partida?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                iniciarDatos()
            Else
                cerrarFormSinPreguntar = True
                Me.Close()
            End If
        End If

    End Sub

    '  al cerrar el form, pregunta al usuario si desea continuar o abandonar la partida
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing And Not cerrarFormSinPreguntar Then

            Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas abandonar la partida?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub


End Class
