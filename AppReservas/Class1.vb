Imports System.Data.OracleClient
Public Class Reserva
    'Propiedades
    Private vDesde As Date
    Private vHasta As Date
    Private vTHabitacion As String
    Private vCantAdultos As Integer
    Private vCantchicos As Integer

    'Constructores
    Public Sub New()

    End Sub
    Public Sub New(FechaD As Date, FechaH As Date, TipoHab As String, CantA As Integer, CantC As Integer)
        Desde = FechaD
        Hasta = FechaH
        THabitacion = TipoHab
        CantAdultos = CantA
        CantChicos = CantC
    End Sub
    'Encapsulamiento
    Public Property Desde As Date
        Get
            Return vDesde
        End Get
        Set(value As Date)
            vDesde = value
        End Set
    End Property
    Public Property Hasta As Date
        Get
            Return vHasta
        End Get
        Set(value As Date)
            vHasta = value
        End Set
    End Property
    Public Property THabitacion As String
        Get
            Return vTHabitacion
        End Get
        Set(value As String)
            vTHabitacion = value
        End Set
    End Property
    Public Property CantChicos As Byte
        Get
            Return vCantchicos
        End Get
        Set(value As Byte)
            vCantchicos = value
        End Set
    End Property
    Public Property CantAdultos As Byte
        Get
            Return vCantAdultos
        End Get
        Set(value As Byte)
            vCantAdultos = value
        End Set
    End Property

    'Demas metodos
    Public Sub Guardar(Consulta As String)
        Try
            Dim Conexion As New OracleConnection
            Dim Comando As New OracleCommand
            Conexion.ConnectionString = "Data Source=localhost;User Id=DATABASE;Password=35488299;"
            Conexion.Open()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = Consulta
            Comando.Parameters.Add(New OracleParameter(":RESERVA_FDESDE", Desde))
            Comando.Parameters.Add(New OracleParameter(":RESERVA_FHASTA", Hasta))
            Comando.Parameters.Add(New OracleParameter(":RESERVA_TIPOHABITACION", THabitacion))
            Comando.Parameters.Add(New OracleParameter(":RESERVA_CANTADULTOS", CantAdultos))
            Comando.Parameters.Add(New OracleParameter(":RESERVA_CANTNINOS", CantChicos))
            Comando.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function ListarReservas(Consulta As String) As DataTable
        Dim Conexion As New OracleConnection
        Dim Comando As New OracleCommand
        Dim Reader As OracleDataReader
        Dim Tabla As New DataTable
        Conexion.ConnectionString = "Data Source=localhost;User Id=DATABASE;Password=35488299;"
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandText = Consulta
        Reader = Comando.ExecuteReader(CommandBehavior.CloseConnection)
        Tabla.Load(Reader, LoadOption.OverwriteChanges)
        Return Tabla
    End Function

    Public Function CantidadDias() As Long
        Return DateDiff(DateInterval.Day, Desde, Hasta)
    End Function

    Public Function ValidarFechas(Fecha As Date) As Boolean
        If IsDate(Fecha) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
