<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PartidaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Timer1 = New Timer(components)
        TimerLbl = New Label()
        Panel1 = New Panel()
        PictureBox13 = New PictureBox()
        PictureBox14 = New PictureBox()
        PictureBox15 = New PictureBox()
        PictureBox16 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox11 = New PictureBox()
        PictureBox12 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        ComenzarBtn = New Button()
        mejorTiempoLbl = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Cyan
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Ink Free", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(120, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(449, 47)
        Label1.TabIndex = 16
        Label1.Text = "JUEGO DE LA MEMORIA"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        ' 
        ' TimerLbl
        ' 
        TimerLbl.AutoSize = True
        TimerLbl.BackColor = SystemColors.ButtonHighlight
        TimerLbl.Font = New Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TimerLbl.Location = New Point(295, 599)
        TimerLbl.Name = "TimerLbl"
        TimerLbl.Size = New Size(79, 42)
        TimerLbl.TabIndex = 18
        TimerLbl.Text = "0:00"
        TimerLbl.UseMnemonic = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Cyan
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PictureBox13)
        Panel1.Controls.Add(PictureBox14)
        Panel1.Controls.Add(PictureBox15)
        Panel1.Controls.Add(PictureBox16)
        Panel1.Controls.Add(PictureBox9)
        Panel1.Controls.Add(PictureBox10)
        Panel1.Controls.Add(PictureBox11)
        Panel1.Controls.Add(PictureBox12)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(37, 74)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(603, 503)
        Panel1.TabIndex = 36
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = SystemColors.ButtonHighlight
        PictureBox13.BorderStyle = BorderStyle.FixedSingle
        PictureBox13.Cursor = Cursors.Hand
        PictureBox13.Image = My.Resources.Resources.question
        PictureBox13.Location = New Point(430, 380)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(101, 103)
        PictureBox13.TabIndex = 49
        PictureBox13.TabStop = False
        ' 
        ' PictureBox14
        ' 
        PictureBox14.BackColor = SystemColors.ButtonHighlight
        PictureBox14.BorderStyle = BorderStyle.FixedSingle
        PictureBox14.Cursor = Cursors.Hand
        PictureBox14.Image = My.Resources.Resources.question
        PictureBox14.Location = New Point(310, 380)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(101, 103)
        PictureBox14.TabIndex = 48
        PictureBox14.TabStop = False
        ' 
        ' PictureBox15
        ' 
        PictureBox15.BackColor = SystemColors.ButtonHighlight
        PictureBox15.BorderStyle = BorderStyle.FixedSingle
        PictureBox15.Cursor = Cursors.Hand
        PictureBox15.Image = My.Resources.Resources.question
        PictureBox15.Location = New Point(190, 380)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(101, 103)
        PictureBox15.TabIndex = 47
        PictureBox15.TabStop = False
        ' 
        ' PictureBox16
        ' 
        PictureBox16.BackColor = SystemColors.ButtonHighlight
        PictureBox16.BorderStyle = BorderStyle.FixedSingle
        PictureBox16.Cursor = Cursors.Hand
        PictureBox16.Image = My.Resources.Resources.question
        PictureBox16.Location = New Point(70, 380)
        PictureBox16.Name = "PictureBox16"
        PictureBox16.Size = New Size(101, 103)
        PictureBox16.TabIndex = 46
        PictureBox16.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = SystemColors.ButtonHighlight
        PictureBox9.BorderStyle = BorderStyle.FixedSingle
        PictureBox9.Cursor = Cursors.Hand
        PictureBox9.Image = My.Resources.Resources.question
        PictureBox9.Location = New Point(430, 260)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(101, 103)
        PictureBox9.TabIndex = 45
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = SystemColors.ButtonHighlight
        PictureBox10.BorderStyle = BorderStyle.FixedSingle
        PictureBox10.Cursor = Cursors.Hand
        PictureBox10.Image = My.Resources.Resources.question
        PictureBox10.Location = New Point(310, 260)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(101, 103)
        PictureBox10.TabIndex = 44
        PictureBox10.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = SystemColors.ButtonHighlight
        PictureBox11.BorderStyle = BorderStyle.FixedSingle
        PictureBox11.Cursor = Cursors.Hand
        PictureBox11.Image = My.Resources.Resources.question
        PictureBox11.Location = New Point(190, 260)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(101, 103)
        PictureBox11.TabIndex = 43
        PictureBox11.TabStop = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = SystemColors.ButtonHighlight
        PictureBox12.BorderStyle = BorderStyle.FixedSingle
        PictureBox12.Cursor = Cursors.Hand
        PictureBox12.Image = My.Resources.Resources.question
        PictureBox12.Location = New Point(70, 260)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(101, 103)
        PictureBox12.TabIndex = 42
        PictureBox12.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.ButtonHighlight
        PictureBox5.BorderStyle = BorderStyle.FixedSingle
        PictureBox5.Cursor = Cursors.Hand
        PictureBox5.Image = My.Resources.Resources.question
        PictureBox5.Location = New Point(430, 140)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(101, 103)
        PictureBox5.TabIndex = 41
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.ButtonHighlight
        PictureBox6.BorderStyle = BorderStyle.FixedSingle
        PictureBox6.Cursor = Cursors.Hand
        PictureBox6.Image = My.Resources.Resources.question
        PictureBox6.Location = New Point(310, 140)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(101, 103)
        PictureBox6.TabIndex = 40
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.ButtonHighlight
        PictureBox7.BorderStyle = BorderStyle.FixedSingle
        PictureBox7.Cursor = Cursors.Hand
        PictureBox7.Image = My.Resources.Resources.question
        PictureBox7.Location = New Point(190, 140)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(101, 103)
        PictureBox7.TabIndex = 39
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.ButtonHighlight
        PictureBox8.BorderStyle = BorderStyle.FixedSingle
        PictureBox8.Cursor = Cursors.Hand
        PictureBox8.Image = My.Resources.Resources.question
        PictureBox8.Location = New Point(70, 140)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(101, 103)
        PictureBox8.TabIndex = 38
        PictureBox8.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.ButtonHighlight
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
        PictureBox4.Cursor = Cursors.Hand
        PictureBox4.Image = My.Resources.Resources.question
        PictureBox4.Location = New Point(430, 20)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(101, 103)
        PictureBox4.TabIndex = 37
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonHighlight
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = My.Resources.Resources.question
        PictureBox3.Location = New Point(310, 20)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(101, 103)
        PictureBox3.TabIndex = 36
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ControlLightLight
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources.question
        PictureBox2.Location = New Point(190, 20)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(101, 103)
        PictureBox2.TabIndex = 35
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources.question
        PictureBox1.Location = New Point(70, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 103)
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        PictureBox1.Tag = ""
        ' 
        ' ComenzarBtn
        ' 
        ComenzarBtn.BackColor = Color.SpringGreen
        ComenzarBtn.Cursor = Cursors.Hand
        ComenzarBtn.Font = New Font("Ink Free", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComenzarBtn.Location = New Point(173, 591)
        ComenzarBtn.Name = "ComenzarBtn"
        ComenzarBtn.Size = New Size(317, 62)
        ComenzarBtn.TabIndex = 37
        ComenzarBtn.Text = "COMENZAR"
        ComenzarBtn.UseVisualStyleBackColor = False
        ' 
        ' mejorTiempoLbl
        ' 
        mejorTiempoLbl.AutoSize = True
        mejorTiempoLbl.BackColor = Color.BlueViolet
        mejorTiempoLbl.Font = New Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point)
        mejorTiempoLbl.ForeColor = Color.Cyan
        mejorTiempoLbl.Location = New Point(416, 675)
        mejorTiempoLbl.Name = "mejorTiempoLbl"
        mejorTiempoLbl.Size = New Size(33, 42)
        mejorTiempoLbl.TabIndex = 35
        mejorTiempoLbl.Text = "-"
        mejorTiempoLbl.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Cyan
        Label3.Cursor = Cursors.IBeam
        Label3.Font = New Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(173, 675)
        Label3.Name = "Label3"
        Label3.Size = New Size(224, 42)
        Label3.TabIndex = 34
        Label3.Text = "MEJOR TIEMPO:"
        ' 
        ' PartidaForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(683, 737)
        Controls.Add(ComenzarBtn)
        Controls.Add(Panel1)
        Controls.Add(mejorTiempoLbl)
        Controls.Add(Label3)
        Controls.Add(TimerLbl)
        Controls.Add(Label1)
        ForeColor = SystemColors.ControlText
        Name = "PartidaForm"
        Text = "Partida"
        Panel1.ResumeLayout(False)
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimerLbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComenzarBtn As Button
    Friend WithEvents mejorTiempoLbl As Label
    Friend WithEvents Label3 As Label
End Class
