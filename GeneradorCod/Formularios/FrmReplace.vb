Public Class FrmReplace
    Private Sub BtnBuscarYPintar_Click(sender As Object, e As EventArgs) Handles BtnBuscarYPintar.Click
        If TxtBuscado.Text <> "" Then
            Try


                RtPlantilla.Text = Replace(RtPlantilla.Text, TxtBuscado.Text, TxtRemplazarPor.Text)



            Catch ex As Exception

            End Try
        End If
    End Sub
End Class