Public Class PaginaPrincipal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        If CheckBoxList1.SelectedIndex = True Then
            Opciones = CheckBoxList1.SelectedValue
        End If
        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If
        If RadioButtonList1.SelectedIndex = True Then
            tipo = RadioButtonList1.SelectedValue
        End If
        If Not datepicker.Value = "" Then
            F_Inicio = datepicker.Value
        End If
        If Not datepicker1.Value = "" Then
            F_Fin = datepicker1.Value
        End If
        Response.Redirect("~/Reserva.aspx")
    End Sub

    Private Sub ImgB_Alava_Click(sender As Object, e As ImageClickEventArgs) Handles ImgB_Alava.Click
        Clicada1 = False
        Clicada2 = False
        Clicada3 = True
        If CheckBoxList1.SelectedIndex = True Then
            Opciones = CheckBoxList1.SelectedValue
        End If
        If Not TextBox1.Text = "" Then
            busqueda = TextBox1.Text
        End If
        If RadioButtonList1.SelectedIndex = True Then
            tipo = RadioButtonList1.SelectedValue
        End If
        If Not datepicker.Value = "" Then
            F_Inicio = datepicker.Value
        End If
        If Not datepicker1.Value = "" Then
            F_Fin = datepicker1.Value
        End If
        Response.Redirect("~/Reserva.aspx")
    End Sub

    Private Sub ImgB_Bizkaia_Click(sender As Object, e As ImageClickEventArgs) Handles ImgB_Bizkaia.Click
        Clicada1 = True
        Clicada2 = False
        Clicada3 = False
        If CheckBoxList1.SelectedIndex = True Then
            Opciones = CheckBoxList1.SelectedValue
        End If
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

    Private Sub ImgB_Gipuzkoa_Click(sender As Object, e As ImageClickEventArgs) Handles ImgB_Gipuzkoa.Click
        Clicada1 = False
        Clicada2 = True
        Clicada3 = False
        If CheckBoxList1.SelectedIndex = True Then
            Opciones = CheckBoxList1.SelectedValue
        End If
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


End Class