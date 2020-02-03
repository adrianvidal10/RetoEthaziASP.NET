Imports MySql.Data.MySqlClient

Public Class ConfirmarReserva
    Inherits System.Web.UI.Page
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
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
        cnn = New MySqlConnection(cadenaconexion)
        sql = "INSERT INTO reservas (IdReser,Fk_IdCliente,Fk_IdEsta,Dni,fecha_ini,FechaFin,Habitaciones,Precio) values (@IdReser,@Fk_IdCliente,@Fk_IdEsta,@Dni,@fecha_ini,@FechaFin,@Habitaciones,@Precio)"
        Dim cmd As New MySqlCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@Dni", dni)
        cmd.Parameters.AddWithValue("@nombre", Me.tx_Nombre.Text)
        cmd.Parameters.AddWithValue("@apellido", Me.tx_Apellido.Text)
        cmd.Parameters.AddWithValue("@edad", Me.tx_Edad.Text)
        cmd.Parameters.AddWithValue("@fecha_ini", F_Inicio)
        cmd.Parameters.AddWithValue("@FechaFin", F_Fin)
        cmd.Parameters.AddWithValue("@Habitaciones", nhabitaciones)
        cmd.Parameters.AddWithValue("@Precio", precio)
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