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
        If Nombre_usuario IsNot "" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.HyperLink1.Visible = True
            Label1.Text = "Hola usuario: " & Nombre_usuario
            Me.Label1.Visible = True
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
        cnn = New MySqlConnection(cadenaconexion)
        Clicada1 = True
        Clicada2 = False
        Clicada3 = False

        Me.Lbl_ubicacionfoto.Text = "Bizkaia"

        If RadioButtonList1.SelectedIndex = True Then
            tipo = RadioButtonList1.SelectedValue
        End If



        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If

        '/ Response.Redirect("~/Reserva.aspx")
        GridView2.DataSourceID = Nothing
        GridView2.DataSourceID = SqlUbicacionBizkaia.ID
        Me.ImageButton7.Visible = False
        Me.ImageButton5.Visible = True
        Me.ImageButton6.Visible = True
    End Sub

    Protected Sub ImageButton5_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton5.Click
        cnn = New MySqlConnection(cadenaconexion)
        Clicada1 = False
        Clicada2 = True
        Clicada3 = False
        Me.Lbl_ubicacionfoto.Text = "Gipuzkoa"
        GridView2.DataSourceID = Nothing
        GridView2.DataSourceID = Sqlubicaciongipuzkoa.ID
        If RadioButtonList1.SelectedIndex = True Then
            tipo = RadioButtonList1.SelectedValue
        End If
        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If

        ' Response.Redirect("~/Reserva.aspx")
        Me.ImageButton7.Visible = True
        Me.ImageButton5.Visible = False
        Me.ImageButton6.Visible = True
    End Sub

    Protected Sub ImageButton6_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton6.Click
        cnn = New MySqlConnection(cadenaconexion)
        Clicada1 = False
        Clicada2 = False
        Clicada3 = True
        Me.Lbl_ubicacionfoto.Text = "Alava"
        GridView2.DataSourceID = Nothing
        GridView2.DataSourceID = SqlUbicacionAlaba.ID
        If RadioButtonList1.SelectedIndex = True Then
            tipo = RadioButtonList1.SelectedValue
        End If
        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If

        'Response.Redirect("~/Reserva.aspx")
        Me.ImageButton7.Visible = True
        Me.ImageButton5.Visible = True
        Me.ImageButton6.Visible = False
    End Sub

    Private Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        cnn = New MySqlConnection(cadenaconexion)
        If RadioButtonList1.SelectedValue = "Camping" Then
            GridView2.DataSourceID = Nothing
            GridView2.DataSourceID = SqlCamping.ID
        End If
        If RadioButtonList1.SelectedValue = "Albergue" Then
            GridView2.DataSourceID = Nothing
            GridView2.DataSourceID = SqlAlbregue.ID
        End If
        If RadioButtonList1.SelectedValue = "Alojamiento" Then
            GridView2.DataSourceID = Nothing
            GridView2.DataSourceID = Sqlalojamiento.ID
        End If
    End Sub

    Protected Sub AdRotator2_AdCreated(sender As Object, e As AdCreatedEventArgs) Handles AdRotator2.AdCreated

    End Sub
End Class