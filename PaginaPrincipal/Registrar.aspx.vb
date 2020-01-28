Imports MySql.Data.MySqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim coon As New MySqlConnection(cadenaconexion)
        Try
            coon.Open()

        Catch ex As Exception
            MsgBox("Fallo en la conexión")
        End Try
        coon.Close()
    End Sub


    Protected Sub Btn_registro_Click(sender As Object, e As EventArgs) Handles Btn_registro.Click

        If Me.tx_Contrasena.Text = Me.tx_ConfirmarContrasena.Text Then
            cnn = New MySqlConnection(cadenaconexion)
            sql = "INSERT INTO cliente (Dni,Nombre,Apellido,Edad,Sexo,Telefono,Gmail,contrasena) values (@dni,@nombre,@apellido,@edad,@sexo,@telefono,@gmail,@contrasena)"
            Dim cmd As New MySqlCommand(sql, cnn)
            cmd.Parameters.AddWithValue("@dni", Me.tx_Dni.Text)
            cmd.Parameters.AddWithValue("@nombre", Me.tx_Nombre.Text)
            cmd.Parameters.AddWithValue("@apellido", Me.tx_Apellido.Text)
            cmd.Parameters.AddWithValue("@edad", Me.tx_Edad.Text)
            cmd.Parameters.AddWithValue("@sexo", Me.DropDownList1.Text)
            cmd.Parameters.AddWithValue("@telefono", Me.tx_Telefono.Text)
            cmd.Parameters.AddWithValue("@gmail", Me.tx_Gmail.Text)
            cmd.Parameters.AddWithValue("@contrasena", Me.tx_Contrasena.Text)
            Try
                cnn.Open()
                resultado = cmd.ExecuteNonQuery()

                Response.Redirect("~/PaginaPrincipal.aspx")

            Catch ex As Exception

            Finally
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                End If
            End Try
        End If
    End Sub
End Class