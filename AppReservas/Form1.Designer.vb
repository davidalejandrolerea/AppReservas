﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ReservasGrp = New System.Windows.Forms.GroupBox()
        Me.BtnCantidadDias = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtChicos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAdultos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbTipoHabitacion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateSalida = New System.Windows.Forms.DateTimePicker()
        Me.DateIngreso = New System.Windows.Forms.DateTimePicker()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReservasGrp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReservasGrp
        '
        Me.ReservasGrp.Controls.Add(Me.BtnCantidadDias)
        Me.ReservasGrp.Controls.Add(Me.PictureBox1)
        Me.ReservasGrp.Controls.Add(Me.Button1)
        Me.ReservasGrp.Controls.Add(Me.TxtChicos)
        Me.ReservasGrp.Controls.Add(Me.Label5)
        Me.ReservasGrp.Controls.Add(Me.TxtAdultos)
        Me.ReservasGrp.Controls.Add(Me.Label4)
        Me.ReservasGrp.Controls.Add(Me.CmbTipoHabitacion)
        Me.ReservasGrp.Controls.Add(Me.Label3)
        Me.ReservasGrp.Controls.Add(Me.Label2)
        Me.ReservasGrp.Controls.Add(Me.Label1)
        Me.ReservasGrp.Controls.Add(Me.DateSalida)
        Me.ReservasGrp.Controls.Add(Me.DateIngreso)
        Me.ReservasGrp.Location = New System.Drawing.Point(12, 12)
        Me.ReservasGrp.Name = "ReservasGrp"
        Me.ReservasGrp.Size = New System.Drawing.Size(592, 137)
        Me.ReservasGrp.TabIndex = 1
        Me.ReservasGrp.TabStop = False
        Me.ReservasGrp.Text = "Reservas"
        '
        'BtnCantidadDias
        '
        Me.BtnCantidadDias.Location = New System.Drawing.Point(343, 17)
        Me.BtnCantidadDias.Name = "BtnCantidadDias"
        Me.BtnCantidadDias.Size = New System.Drawing.Size(100, 23)
        Me.BtnCantidadDias.TabIndex = 8
        Me.BtnCantidadDias.Text = "Cantidad en dias"
        Me.BtnCantidadDias.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(466, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Reservar Ahora!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtChicos
        '
        Me.TxtChicos.Location = New System.Drawing.Point(94, 98)
        Me.TxtChicos.Name = "TxtChicos"
        Me.TxtChicos.Size = New System.Drawing.Size(39, 20)
        Me.TxtChicos.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Niños"
        '
        'TxtAdultos
        '
        Me.TxtAdultos.Location = New System.Drawing.Point(94, 72)
        Me.TxtAdultos.Name = "TxtAdultos"
        Me.TxtAdultos.Size = New System.Drawing.Size(39, 20)
        Me.TxtAdultos.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Adultos"
        '
        'CmbTipoHabitacion
        '
        Me.CmbTipoHabitacion.FormattingEnabled = True
        Me.CmbTipoHabitacion.Items.AddRange(New Object() {"Single", "Doble", "Triple", "Cuadruple"})
        Me.CmbTipoHabitacion.Location = New System.Drawing.Point(94, 45)
        Me.CmbTipoHabitacion.Name = "CmbTipoHabitacion"
        Me.CmbTipoHabitacion.Size = New System.Drawing.Size(164, 21)
        Me.CmbTipoHabitacion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Habitación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingreso"
        '
        'DateSalida
        '
        Me.DateSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateSalida.Location = New System.Drawing.Point(245, 19)
        Me.DateSalida.Name = "DateSalida"
        Me.DateSalida.Size = New System.Drawing.Size(91, 20)
        Me.DateSalida.TabIndex = 1
        '
        'DateIngreso
        '
        Me.DateIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateIngreso.Location = New System.Drawing.Point(94, 19)
        Me.DateIngreso.Name = "DateIngreso"
        Me.DateIngreso.Size = New System.Drawing.Size(91, 20)
        Me.DateIngreso.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 152)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(153, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Actualizar Listado de Reservas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(592, 171)
        Me.DataGridView1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 347)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ReservasGrp)
        Me.Name = "Form1"
        Me.Text = "Hotel Asterion"
        Me.ReservasGrp.ResumeLayout(False)
        Me.ReservasGrp.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReservasGrp As GroupBox
    Friend WithEvents CmbTipoHabitacion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateSalida As DateTimePicker
    Friend WithEvents DateIngreso As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtChicos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAdultos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCantidadDias As System.Windows.Forms.Button
End Class
