Public Class PaginaPrincipal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Nombre_usuario IsNot "" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.HyperLink1.Visible = True
            Label3.Text = "Hola : " & Nombre_usuario
            Me.Label3.Visible = True
        End If
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click

        If TextBox1.Text IsNot "" Then
            nombreestab = TextBox1.Text
        End If

        Response.Redirect("~/Reserva.aspx")
    End Sub

    Private Sub ImgB_Alava_Click(sender As Object, e As ImageClickEventArgs) Handles ImgB_Alava.Click
        Clicada1 = False
        Clicada2 = False
        Clicada3 = True

        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If

        Response.Redirect("~/Reserva.aspx")
    End Sub

    Private Sub ImgB_Bizkaia_Click(sender As Object, e As ImageClickEventArgs) Handles ImgB_Bizkaia.Click
        Clicada1 = True
        Clicada2 = False
        Clicada3 = False


        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If

        Response.Redirect("~/Reserva.aspx")
    End Sub

    Private Sub ImgB_Gipuzkoa_Click(sender As Object, e As ImageClickEventArgs) Handles ImgB_Gipuzkoa.Click
        Clicada1 = False
        Clicada2 = True
        Clicada3 = False


        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If

        Response.Redirect("~/Reserva.aspx")
    End Sub


End Class