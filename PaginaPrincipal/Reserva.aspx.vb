Imports MySql.Data.MySqlClient
Public Class Reserva
    Inherits System.Web.UI.Page
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cnn = New MySqlConnection(cadenaconexion)


        If Nombre_usuario IsNot "" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Label1.Text = "Hola " & Nombre_usuario
            Me.Label1.Visible = True
        End If



    End Sub

    Protected Sub ImageButton7_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton7.Click
        cnn = New MySqlConnection(cadenaconexion)


        Me.Lbl_ubicacionfoto.Text = "Bizkaia"


        RadioButtonList1.ClearSelection()

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
        RadioButtonList1.ClearSelection()
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
        RadioButtonList1.ClearSelection()
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
            Me.ImageButton7.Visible = True
            Me.ImageButton5.Visible = True
            Me.ImageButton6.Visible = True
            Me.Lbl_ubicacionfoto.Text = "Camping"
            tipo = "camping"
        End If
        If RadioButtonList1.SelectedValue = "Albergue" Then
            GridView2.DataSourceID = Nothing
            GridView2.DataSourceID = SqlAlbregue.ID
            Me.ImageButton7.Visible = True
            Me.ImageButton5.Visible = True
            Me.ImageButton6.Visible = True
            Me.Lbl_ubicacionfoto.Text = "Albergue"
            tipo = "albergue"
        End If
        If RadioButtonList1.SelectedValue = "Alojamiento" Then
            GridView2.DataSourceID = Nothing
            GridView2.DataSourceID = Sqlalojamiento.ID
            Me.ImageButton7.Visible = True
            Me.ImageButton5.Visible = True
            Me.ImageButton6.Visible = True
            Me.Lbl_ubicacionfoto.Text = "Alojamiento"
            tipo = "alojamiento"
        End If
    End Sub

    Protected Sub AdRotator2_AdCreated(sender As Object, e As AdCreatedEventArgs) Handles AdRotator2.AdCreated

    End Sub

    'Private Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
    '    cnn = New MySqlConnection(cadenaconexion)
    '    If nombreestab IsNot "" Then

    '        sql = "SELECT Id, Nombre, Categoria, Ubicacion, Precio FROM establecimiento WHERE (Nombre LIKE '" & nombreestab & "%')"

    '        Try
    '            cnn.Open()

    '        Catch ex As Exception

    '        Finally
    '            If cnn.State = ConnectionState.Open Then
    '                cnn.Close()

    '            End If
    '        End Try
    '        GridView2.DataSourceID = Nothing
    '        GridView2.DataSourceID = SqlDataSource2.ID
    '    End If
    'End Sub

    Protected Sub GridView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView2.SelectedIndexChanged

        Dim row As GridViewRow = GridView2.SelectedRow
        id_alojamiento = row.Cells(1).Text
        nombreAloj = row.Cells(2).Text
        precio = row.Cells(4).Text
        ubicacion = row.Cells(5).Text
        tipo = row.Cells(1).Text
        tipo = tipo.Substring(0, 3)

        If tipo = "alo" Then
            tipo = "alojamiento"
        ElseIf tipo = "alb" Then
            tipo = "albergue"
        Else
            tipo = "camping"
        End If
        Response.Redirect("~/ConfirmarReserva.aspx")
    End Sub
End Class