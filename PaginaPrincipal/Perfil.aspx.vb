Imports MySql.Data.MySqlClient
Public Class Perfil
    Inherits System.Web.UI.Page
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim texto As String
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cnn = New MySqlConnection(cadenaconexion)
        tx_Dni.Text = dni
        sql = "SELECT * FROM cliente WHERE Dni= @dni"
        Dim cmd As New MySqlCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@dni", dni)
        Dim dr As MySqlDataReader = Nothing
        Try
            cnn.Open()

            dr = cmd.ExecuteReader
            If dr.Read Then
                tx_Nombre.Text = dr("Nombre").ToString()
                tx_Apellido.Text = dr("Apellido").ToString()
                tx_Edad.Text = dr("Edad").ToString()
                tx_Gmail.Text = dr("Gmail").ToString()
                tx_Contrasena.Text = dr("contrasena").ToString()
                tx_Telefono.Text = dr("Telefono").ToString()
                DropDownList1.Text = dr("Sexo").ToString()
            End If
        Catch ex As Exception

        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                dr.Close()
            End If
        End Try


        Me.Button2.Visible = False
        Me.lbl_ConfirmarContrasena.Visible = False
        Me.tx_ConfirmarContrasena.Visible = False
        Me.tx_Nombre.Enabled = False
        Me.tx_Apellido.Enabled = False
        Me.tx_Dni.Enabled = False
        Me.tx_Edad.Enabled = False
        Me.DropDownList1.Enabled = False
        Me.tx_Telefono.Enabled = False
        Me.tx_Gmail.Enabled = False
        Me.tx_Contrasena.Enabled = False
        Me.lbl_NuevaContrasena.Visible = False
        Me.tx_NuevaContrasena.Visible = False
        Me.Button3.Visible = False
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Button2.Visible = True
        Me.lbl_ConfirmarContrasena.Visible = False
        Me.tx_ConfirmarContrasena.Visible = False
        Me.tx_Nombre.Enabled = True
        Me.tx_Apellido.Enabled = True
        Me.tx_Dni.Enabled = True
        Me.tx_Edad.Enabled = True
        Me.DropDownList1.Enabled = True
        Me.tx_Telefono.Enabled = True
        Me.tx_Gmail.Enabled = True
        Me.tx_Contrasena.Enabled = True
        Me.lbl_NuevaContrasena.Visible = False
        Me.tx_NuevaContrasena.Visible = False
        Me.Button3.Visible = True
    End Sub


    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cnn = New MySqlConnection(cadenaconexion)

        If tx_NuevaContrasena.Text = tx_ConfirmarContrasena.Text Then
            sql = "UPDATE cliente SET Dni=@dni, Nombre=@nombre, Apellido=@apellido, Edad=@edad, Sexo=@sexo, Telefono=@telefono,Gmail=@gmail,contrasena=@contrasena WHERE Dni = '" & dni & "'"
            Dim cmd As New MySqlCommand(sql, cnn)
            cmd.Parameters.AddWithValue("@dni", Me.tx_Dni.Text)
            cmd.Parameters.AddWithValue("@nombre", Me.tx_Nombre.Text)
            cmd.Parameters.AddWithValue("@apellido", Me.tx_Apellido.Text)
            cmd.Parameters.AddWithValue("@edad", Me.tx_Edad.Text)
            cmd.Parameters.AddWithValue("@sexo", Me.DropDownList1.Text)
            cmd.Parameters.AddWithValue("@telefono", Me.tx_Telefono.Text)
            cmd.Parameters.AddWithValue("@gmail", Me.tx_Gmail.Text)
            cmd.Parameters.AddWithValue("@contrasena", Me.tx_NuevaContrasena.Text)
            Try
                cnn.Open()
                resultado = cmd.ExecuteNonQuery
                MsgBox("Actualizadas " & resultado & "filas")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                End If
            End Try
        ElseIf tx_NuevaContrasena.Text = "" Then
            sql = "UPDATE cliente SET Dni=@dni, Nombre=@nombre, Apellido=@apellido, Edad=@edad, Sexo=@sexo, Telefono=@telefono,Gmail=@gmail,contrasena=@contrasena WHERE Dni = '" & dni & "'"
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
                resultado = cmd.ExecuteNonQuery
                MsgBox("Actualizadas " & resultado & "filas")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                End If
            End Try
        Else
            MsgBox("Las contraseñas no coinciden")
            tx_Contrasena.Text = ""
            tx_ConfirmarContrasena.Text = ""
            tx_Contrasena.Focus()





        End If


    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.lbl_NuevaContrasena.Visible = True
        Me.tx_NuevaContrasena.Visible = True
        Me.lbl_ConfirmarContrasena.Visible = True
        Me.tx_ConfirmarContrasena.Visible = True
        Me.tx_Nombre.Enabled = True
        Me.tx_Apellido.Enabled = True
        Me.tx_Dni.Enabled = True
        Me.tx_Edad.Enabled = True
        Me.DropDownList1.Enabled = True
        Me.tx_Telefono.Enabled = True
        Me.tx_Gmail.Enabled = True
        Me.tx_Contrasena.Enabled = True
        Me.Button2.Visible = True
    End Sub
End Class