Public Class Reserva
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Clicada1 = True Then
            ImageButton7.Visible = False
        ElseIf Clicada2 = True Then
            ImageButton5.Visible = False
        ElseIf Clicada3 = True Then
            ImageButton6.Visible = False
        End If



    End Sub


End Class