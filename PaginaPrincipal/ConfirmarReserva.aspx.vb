Imports MySql.Data.MySqlClient

Public Class ConfirmarReserva
    Inherits System.Web.UI.Page
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim das As DataSet
    Dim adap As MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim cadenadeconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Text = nombreAloj
        TextBox2.Text = ubicacion
        TextBox3.Text = dni
        TextBox6.Text = precio

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F_Inicio = datepicker.Value
        F_Fin = datepicker1.Value
        precio = TextBox6.Text
        nhabitaciones = DropDownList1.SelectedValue
        cnn = New MySqlConnection(cadenadeconexion)
        Dim cmd = cnn.CreateCommand()
        cmd.CommandText = "INSERT INTO reservas (Fk_IdCliente, Fk_IdEsta, Dni, fecha_Ini, FechaFin, Habitaciones, Precio) values(@idCliente,@idEsta,@dni,@fechaIni,@fechaFinal,@Habitaciones,@Precio)"

        cmd.Parameters.AddWithValue("@dni", dni)
        cmd.Parameters.AddWithValue("@idCliente", id_usuario)
        cmd.Parameters.AddWithValue("@idEsta", id_alojamiento)
        cmd.Parameters.AddWithValue("@fechaIni", F_Inicio)
        cmd.Parameters.AddWithValue("@fechaFinal", F_Fin)
        cmd.Parameters.AddWithValue("@Habitaciones", nhabitaciones)
        cmd.Parameters.AddWithValue("@Precio", precio)

        Try
            cnn.Open()
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
            Response.Redirect("~/Factura.aspx")

        Catch ex As Exception

        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Sub

    Protected Sub AdRotator2_AdCreated(sender As Object, e As AdCreatedEventArgs) Handles AdRotator2.AdCreated

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.TextBox6.Text = precio * DropDownList1.SelectedValue
        precio = Me.TextBox6.Text

    End Sub
End Class