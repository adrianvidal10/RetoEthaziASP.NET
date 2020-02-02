Imports MySql.Data.MySqlClient
Public Class Reserva
    Inherits System.Web.UI.Page
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cnn = New MySqlConnection(cadenaconexion)
        If Clicada1 = True Then
            ImageButton7.Visible = False
        ElseIf Clicada2 = True Then
            ImageButton5.Visible = False
        ElseIf Clicada3 = True Then
            ImageButton6.Visible = False
        End If

        'sql = "SELECT Nombre,Ubicacion,Categoria,Precio FROM " & tipo & ""


        'Dim cmd As New MySqlCommand(sql, cnn)


        'Dim dr As MySqlDataReader = Nothing

        'Try
        '    cnn.Open()
        '    dr = cmd.ExecuteReader
        '    Dim x As Integer
        '    ListView1.Items.Clear()

        '    If dr.Read Then
        '        ListView1.Items.Add(dr.Item(0))
        '        ListView1.Items(X).SubItems.Add(dr.Item(1)) = dr("Nombre").ToString()

        '    End If
        'Catch ex As Exception

        'Finally

        'End Try


    End Sub

    Protected Sub ImageButton7_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton7.Click
        Clicada1 = True
        Clicada2 = False
        Clicada3 = False
        Me.Lbl_Ubicacion.Text = "Bizkaia"
        If RadioButtonList1.SelectedIndex = True Then
            tipo = RadioButtonList1.SelectedValue
        End If
        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If
        If Not datepicker.Value = "" Then
            F_Inicio = datepicker.Value
        End If
        If Not datepicker1.Value = "" Then
            F_Fin = datepicker1.Value
        End If
        Response.Redirect("~/Reserva.aspx")
    End Sub

    Protected Sub ImageButton5_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton5.Click
        Clicada1 = False
        Clicada2 = True
        Clicada3 = False
        Me.Lbl_Ubicacion.Text = "Gipuzkoa"
        If RadioButtonList1.SelectedIndex = True Then
            tipo = RadioButtonList1.SelectedValue
        End If
        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If
        If Not datepicker.Value = "" Then
            F_Inicio = datepicker.Value
        End If
        If Not datepicker1.Value = "" Then
            F_Fin = datepicker1.Value
        End If
        Response.Redirect("~/Reserva.aspx")
    End Sub

    Protected Sub ImageButton6_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton6.Click
        Clicada1 = False
        Clicada2 = False
        Clicada3 = True
        Me.Lbl_Ubicacion.Text = "Alava"
        If RadioButtonList1.SelectedIndex = True Then
            tipo = RadioButtonList1.SelectedValue
        End If
        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If
        If Not datepicker.Value = "" Then
            F_Inicio = datepicker.Value
        End If
        If Not datepicker1.Value = "" Then
            F_Fin = datepicker1.Value
        End If
        Response.Redirect("~/Reserva.aspx")
    End Sub

    Private Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        cnn = New MySqlConnection(cadenaconexion)
        If RadioButtonList1.SelectedValue = "Camping" Then
            GridView2.DataSourceID = Nothing
            GridView2.DataSourceID = SqlCamping.ID
        End If
    End Sub
End Class