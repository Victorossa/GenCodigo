Public Class FrmReplace

    Dim ValorRequisito As String
    Dim Requisitos() As String
    Private Sub FrmReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.TecnologiasTableAdapter.Fill(Me.DataSetAdministracion.Tecnologias)
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TecnologiaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles TecnologiaIDTextBox.TextChanged
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
    End Sub
    Private Sub PlantillaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIDTextBox.TextChanged
        SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
    End Sub
    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
        Try
            Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia, New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    'RTC



    Private Sub BtnBuscarYPintar_Click(sender As Object, e As EventArgs) Handles BtnBuscarYPintar.Click
        Dim contador = SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count()
        'If TxtBuscado.Text <> "" Then
        '    Try
        '        RtPlantilla.Text = Replace(RtPlantilla.Text, TxtBuscado.Text, TxtRemplazarPor.Text)
        '    Catch ex As Exception

        '    End Try
        'End If

        While contador > 0
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentCell = SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows(0).Cells(0)

            ValorRequisito = InputBox(EnunciadoTextBox.Text)
            If ValorRequisito = "" Then
                MsgBox("No has ingresdo un valor para: " + EnunciadoTextBox.Text, MsgBoxStyle.Critical)
            Else

                SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
                contador = contador - 1
            End If
        End While


    End Sub





End Class