<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GanasteForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        SiBtn = New Button()
        NoBtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.win4
        PictureBox1.Location = New Point(44, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(707, 270)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Ink Free", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(186, 320)
        Label2.Name = "Label2"
        Label2.Size = New Size(390, 34)
        Label2.TabIndex = 2
        Label2.Text = "¿Deseas iniciar otra partida?"
        ' 
        ' SiBtn
        ' 
        SiBtn.Location = New Point(230, 382)
        SiBtn.Name = "SiBtn"
        SiBtn.Size = New Size(126, 34)
        SiBtn.TabIndex = 3
        SiBtn.Text = "SI"
        SiBtn.UseVisualStyleBackColor = True
        ' 
        ' NoBtn
        ' 
        NoBtn.Location = New Point(405, 382)
        NoBtn.Name = "NoBtn"
        NoBtn.Size = New Size(126, 34)
        NoBtn.TabIndex = 4
        NoBtn.Text = "NO"
        NoBtn.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(NoBtn)
        Controls.Add(SiBtn)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Ganaste!"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SiBtn As Button
    Friend WithEvents NoBtn As Button
End Class
