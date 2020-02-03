Imports System.IO
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim reserva As String
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim das As DataSet
    Dim adap As MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim cadenadeconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox3.Text = nombreAloj
        TextBox4.Text = ubicacion
        TextBox5.Text = F_Inicio
        TextBox6.Text = F_Fin
        TextBox7.Text = nhabitaciones
        TextBox8.Text = precio & "€"
        cnn = New MySqlConnection(cadenadeconexion)
        sql = "SELECT * FROM cliente WHERE Dni= @dni"
        Dim cmd As New MySqlCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@dni", dni)
        Dim dr As MySqlDataReader = Nothing
        Try
            cnn.Open()

            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox1.Text = dr("Nombre").ToString()
                TextBox2.Text = dr("Apellido").ToString()
            End If
        Catch ex As Exception

        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                dr.Close()
            End If
        End Try
        Dim eleccion As String = Nothing
        If tipo = "alojamiento" Then
            eleccion = "reserva_alo"
        ElseIf tipo = "camping" Then
            eleccion = "reserva_camping"
        ElseIf tipo = "albergue" Then
            eleccion = "reserva_alb"
        End If
        sql = "select Id_Reserva FROM reservas where Dni = " & dni
        Try
            cnn.Open()

            dr = cmd.ExecuteReader
            If dr.Read Then
                reserva = dr("IdReserva").ToString()
            End If
        Catch ex As Exception
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                dr.Close()
            End If
        End Try
        TextBox9.Text = reserva
    End Sub

    Protected Sub btnGenerarPdf_Click(sender As Object, e As EventArgs) Handles btnGenerarPdf.Click
        Try
            'Creamos el objeto documento PDF
            Dim documentoPDF As New Document
            PdfWriter.GetInstance(documentoPDF,
                    New FileStream("C:\Users\admin1\Downloads\" & reserva & ".pdf", FileMode.Create))
            documentoPDF.Open()

            'Escribimos el texto en el objeto documento PDF
            documentoPDF.Add(New Paragraph(Label10.Text & "                                                 " & TextBox9.Text,
                      FontFactory.GetFont(FontFactory.TIMES, 11,
                          iTextSharp.text.Font.NORMAL)))
            documentoPDF.Add(New Paragraph(Label2.Text & "                                                 " & TextBox1.Text,
                      FontFactory.GetFont(FontFactory.TIMES, 11,
                          iTextSharp.text.Font.NORMAL)))
            documentoPDF.Add(New Paragraph(Label3.Text & "                                                 " & TextBox2.Text,
                      FontFactory.GetFont(FontFactory.TIMES, 11,
                          iTextSharp.text.Font.NORMAL)))
            documentoPDF.Add(New Paragraph(Label4.Text & "               " & TextBox3.Text,
                      FontFactory.GetFont(FontFactory.TIMES, 11,
                          iTextSharp.text.Font.NORMAL)))
            documentoPDF.Add(New Paragraph(Label5.Text & "                                                " & TextBox4.Text,
                      FontFactory.GetFont(FontFactory.TIMES, 11,
                          iTextSharp.text.Font.NORMAL)))
            documentoPDF.Add(New Paragraph(Label6.Text & "                                            " & TextBox5.Text,
                      FontFactory.GetFont(FontFactory.TIMES, 11,
                          iTextSharp.text.Font.NORMAL)))
            documentoPDF.Add(New Paragraph(Label7.Text & "                                             " & TextBox6.Text,
                      FontFactory.GetFont(FontFactory.TIMES, 11,
                          iTextSharp.text.Font.NORMAL)))
            documentoPDF.Add(New Paragraph(Label8.Text & "                              " & TextBox7.Text,
                      FontFactory.GetFont(FontFactory.TIMES, 11,
                          iTextSharp.text.Font.NORMAL)))
            documentoPDF.Add(New Paragraph(Label9.Text & "                                                        " & TextBox8.Text,
                      FontFactory.GetFont(FontFactory.TIMES, 11,
                          iTextSharp.text.Font.NORMAL)))

            'Cerramos el objeto documento, guardamos y creamos el PDF
            documentoPDF.Close()
        Catch ex As Exception
            MsgBox("Se ha producido un error al intentar convertir el texto a PDF: " +
                    vbCrLf + vbCrLf + ex.Message,
                    MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Protected Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Response.Redirect("~/PaginaPrincipal.aspx")
    End Sub
End Class