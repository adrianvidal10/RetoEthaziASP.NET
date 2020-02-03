Public Class ConfirmarReserva
    Inherits System.Web.UI.Page

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
        Response.Redirect("~/Factura.aspx")
    End Sub


End Class