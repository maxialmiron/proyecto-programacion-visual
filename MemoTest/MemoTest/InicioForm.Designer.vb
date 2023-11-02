<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioForm
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
        Label1 = New Label()
        JugarBtn = New Button()
        InstruccionesBtn = New Button()
        CreditosBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Cyan
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Ink Free", 26F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(69, 44)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10)
        Label1.Size = New Size(661, 86)
        Label1.TabIndex = 18
        Label1.Text = "JUEGO DE LA MEMORIA"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' JugarBtn
        ' 
        JugarBtn.BackColor = Color.SpringGreen
        JugarBtn.Cursor = Cursors.Hand
        JugarBtn.FlatAppearance.BorderColor = Color.Black
        JugarBtn.FlatStyle = FlatStyle.Flat
        JugarBtn.Font = New Font("Ink Free", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        JugarBtn.Location = New Point(211, 160)
        JugarBtn.Name = "JugarBtn"
        JugarBtn.Size = New Size(384, 72)
        JugarBtn.TabIndex = 22
        JugarBtn.Text = "JUGAR"
        JugarBtn.UseVisualStyleBackColor = False
        ' 
        ' InstruccionesBtn
        ' 
        InstruccionesBtn.BackColor = Color.Fuchsia
        InstruccionesBtn.Cursor = Cursors.Hand
        InstruccionesBtn.FlatAppearance.BorderColor = Color.Black
        InstruccionesBtn.FlatAppearance.BorderSize = 2
        InstruccionesBtn.FlatStyle = FlatStyle.Flat
        InstruccionesBtn.Font = New Font("Ink Free", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        InstruccionesBtn.Location = New Point(211, 262)
        InstruccionesBtn.Name = "InstruccionesBtn"
        InstruccionesBtn.Size = New Size(384, 77)
        InstruccionesBtn.TabIndex = 23
        InstruccionesBtn.Text = "INSTRUCCIONES"
        InstruccionesBtn.UseVisualStyleBackColor = False
        ' 
        ' CreditosBtn
        ' 
        CreditosBtn.Cursor = Cursors.Hand
        CreditosBtn.Location = New Point(296, 381)
        CreditosBtn.Name = "CreditosBtn"
        CreditosBtn.Size = New Size(216, 34)
        CreditosBtn.TabIndex = 24
        CreditosBtn.Text = "Ver créditos"
        CreditosBtn.UseVisualStyleBackColor = True
        ' 
        ' InicioForm
        ' 
        AcceptButton = CreditosBtn
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(CreditosBtn)
        Controls.Add(InstruccionesBtn)
        Controls.Add(JugarBtn)
        Controls.Add(Label1)
        Name = "InicioForm"
        Text = "Juego de la Memoria"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents JugarBtn As Button
    Friend WithEvents InstruccionesBtn As Button
    Friend WithEvents CreditosBtn As Button
End Class
