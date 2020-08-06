Public Class Reportes
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SP_Proyectos_SEGUN_ProyectoID()
        Try
            Me.SP_Proyectos_SEGUN_ProyectoIDTableAdapter.Fill(Me.DataSetReportes.SP_Proyectos_SEGUN_ProyectoID, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ProyectoIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProyectoIDTextBox.TextChanged
        SP_Proyectos_SEGUN_ProyectoID()
        SP_TOTALIZA_TIEMPO_POR_PROYECTO()
        SP_TablasDeProyecto_Cant_Tablas_Proyecto()
        SP_Vista_Para_Metricas_Suma_False()
        SP_Vista_Para_Metricas_Suma_True()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SP_TablasDeProyecto_Cant_Tablas_Proyecto()
        Try
            Me.SP_TablasDeProyecto_Cant_Tablas_ProyectoTableAdapter.Fill(Me.DataSetReportes.SP_TablasDeProyecto_Cant_Tablas_Proyecto, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_Vista_Para_Metricas_Suma_False()
        Try
            Me.SP_Vista_Para_Metricas_Suma_FalseTableAdapter.Fill(Me.DataSetReportes.SP_Vista_Para_Metricas_Suma_False, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_Vista_Para_Metricas_Suma_True()
        Try
            Me.SP_Vista_Para_Metricas_Suma_TrueTableAdapter.Fill(Me.DataSetReportes.SP_Vista_Para_Metricas_Suma_True, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_TOTALIZA_TIEMPO_POR_PROYECTO()
        Try
            Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOTableAdapter.Fill(Me.DataSetReportes.SP_TOTALIZA_TIEMPO_POR_PROYECTO, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class