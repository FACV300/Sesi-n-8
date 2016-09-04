Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click

    End Sub

    Private Sub BtnVerInfo1_Click(sender As Object, e As EventArgs) Handles BtnVerInfo1.Click
        LblNombreCancion.Text = LblNombreCancion.Text + " Far From th End of the World"
    End Sub
End Class
