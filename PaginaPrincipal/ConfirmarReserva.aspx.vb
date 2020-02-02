Public Class ConfirmarReserva
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Calendar1.Visible = False
        Me.Calendar2.Visible = False
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombreAloj = TextBox1.Text
        ubicacion = TextBox2.Text
        F_Inicio = Tx_fechainicio.Text
        F_Fin = Tx_fechafin.Text
        precio = TextBox6.Text
        nhabitaciones = DropDownList1.SelectedValue
        Response.Redirect("~/Factura.aspx")
    End Sub

    Private Sub Tx_fechainicio_TextChanged(sender As Object, e As EventArgs) Handles Tx_fechainicio.TextChanged
        Me.Calendar1.Visible = True
    End Sub
End Class