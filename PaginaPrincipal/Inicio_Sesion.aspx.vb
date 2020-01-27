﻿Imports MySql.Data.MySqlClient

Public Class Inicio_Sesion
    Inherits System.Web.UI.Page
    Dim cnn As MySqlConnection
    Dim sql As String
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

    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        cnn = New MySqlConnection(cadenaconexion)
        Dim cmd1 = cnn.CreateCommand()
        cmd1.CommandText = "SELECT Dni,contrasena FROM usuario WHERE Dni= @dni AND contrasena= @contrasena AND admin=1"
        cmd1.Parameters.AddWithValue("@dni", Me.Tx_Dni.Text)
        cmd1.Parameters.AddWithValue("@contrasena", Me.Tx_Contra.Text)

        Dim dr As MySqlDataReader = Nothing
        Try
            cnn.Open()

            dr = cmd1.ExecuteReader
            If dr.HasRows Then
                MsgBox("Aceptado en el sistema")

                ' Btn_Aceptar.PostBackUrl = "C:\Users\admin1\Source\Repos\RetoEthaziASP.NET\PaginaPrincipal\Buscar.aspx"
            Else
                MsgBox("Usuario o contraseña erronea")
                Btn_Aceptar.PostBackUrl = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                dr.Close()
            End If
        End Try
    End Sub
End Class