Imports MySql.Data.MySqlClient
Public Class ConfirmarReserva
    Inherits System.Web.UI.Page
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cnn = New MySqlConnection(cadenaconexion)
        If tipo = "alojamiento" Then

        End If
        ' sql("select Nombre, Ubicacion from " & tipo & "t,  ")
        Try
            cnn.Open()

        Catch ex As Exception
            MsgBox("Fallo en la conexión")
        End Try
        cnn.Close()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cnn = New MySqlConnection(cadenaconexion)
        sql = "INSERT INTO reserva_alo(Fk_IdCliente,Fk_IdAlo,Dni,FechaIni,FechaFin,Habitaciones,Precio) VALUES (,@dni,@fechainicio,@fechafin,@habitaciones,@precio)"
        Dim cmd As New MySqlCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@dni", Me.txb_Dni.Text)
        cmd.Parameters.AddWithValue("@fechainicio", Me.datepicker.Value)
        cmd.Parameters.AddWithValue("@fechafin", Me.datepicker1.Value)
        cmd.Parameters.AddWithValue("@habitaciones", Me.ddl_Habitaciones.Text)
        cmd.Parameters.AddWithValue("@precio", Me.txb_Precio.Text)

        Try
            cnn.Open()
            resultado = cmd.ExecuteNonQuery()

            Response.Redirect("~/Factura.aspx")

        Catch ex As Exception

        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try

    End Sub
End Class