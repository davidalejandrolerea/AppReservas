Public Class Form1
    Public oReserva As New Reserva
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        oReserva.Desde = DateIngreso.Value
        oReserva.Hasta = DateSalida.Value
        oReserva.THabitacion = CmbTipoHabitacion.Text
        oReserva.CantChicos = Val(TxtChicos.Text)
        oReserva.CantAdultos = Val(TxtAdultos.Text)
        oReserva.Guardar("Insert Into RESERVA(RESERVA_FDESDE. RESERVA_FHASTA, RESERVA_TIPOHABITACION, RESERVA_CANTADULTOS, RESERVA_CANTNINOS) Values(:RESERVA_FDESDE, :RESERVA_FHASTA, :RESERVA_CANTADULTOS, :RESERVA_CANTNINOS);")
    End Sub

    Private Sub BtnCantidadDias_Click(sender As Object, e As EventArgs) Handles BtnCantidadDias.Click
        oReserva.Desde = DateIngreso.Value
        oReserva.Hasta = DateSalida.Value
        MsgBox(oReserva.CantidadDias)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        DataGridView1.DataSource = oReserva.ListarReservas("Select * From Reserva")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = oReserva.ListarReservas("Select * From Reserva")
    End Sub
End Class
