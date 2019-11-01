Public Class FrmReplace

    Dim ValorRequisito As String
    Dim Requisitos() As String
    Private Sub FrmReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetAdministracion.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DataSetAdministracion.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
        Try
            Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
            Cancelar_Proyectos()
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
        Dim contadorRequisitos = SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count()
        'If TxtBuscado.Text <> "" Then
        '    Try
        '        RtPlantilla.Text = Replace(RtPlantilla.Text, TxtBuscado.Text, TxtRemplazarPor.Text)
        '    Catch ex As Exception

        '    End Try
        'End If

        While contadorRequisitos > 0
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentCell = SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows(0).Cells(0)

            ValorRequisito = InputBox(EnunciadoTextBox.Text)
            If ValorRequisito = "" Then
                If MsgBox("No has ingresdo un valor para: " + EnunciadoTextBox.Text, MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
                    Exit While
                End If
            Else

                SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
                contadorRequisitos = contadorRequisitos - 1
            End If
        End While


    End Sub



#Region "Procedimientos"
    Sub Cancelar_Proyectos()
        'Botones Del Menu
        Nuevo_Menu_Proyectos.Enabled = True
        Guardar_Menu_Proyectos.Enabled = False
        Editar_Menu_Proyectos.Enabled = True
        Actualizar_Menu_Proyectos.Enabled = False
        Eliminar_Menu_Proyectos.Enabled = False
        'Grid
        ProyectosDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
        Bloquear_Objetos_Proyectos()
        Parar_Timer_Proyectos()
        Timer_Ubicar_En_Fila_Proyectos()
    End Sub
    'Insertar
    Private Sub SP_Proyectos_EDICION_INSERTAR()
        Try
            Me.SP_Proyectos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_Proyectos_EDICION_INSERTAR,
                                                 NombreProyectoTextBox.Text,
                                                 CodigoGeneradoTextBox.Text,
                                                 DescripcionTextBox.Text)
            Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub SP_Proyectos_EDICION_ACTUALIZAR()
        Try
            Me.SP_Proyectos_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Proyectos_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                 NombreProyectoTextBox.Text,
                                                 CodigoGeneradoTextBox.Text,
                                                 DescripcionTextBox.Text)
            Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_Proyectos_EDICION_ELIMINAR()
        Try
            Me.SP_Proyectos_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetAdministracion.SP_Proyectos_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(ProyectoIDTextBox.Text, Long)))
            Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_Proyectos.Click
        Nuevo_Menu_Proyectos.Enabled = False
        Editar_Menu_Proyectos.Enabled = False
        ProyectosDataGridView.Enabled = False
        Limpiar_Objetos_Proyectos()
        NombreProyectoTextBox.Enabled = True
        NombreProyectoTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_Proyectos.Click
        Control_Nulos_Proyectos()

        If ControlNulos.Text = "" Then ' Then
            SP_Proyectos_EDICION_INSERTAR()
            Cancelar_Proyectos()
            Parar_Timer_Proyectos()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_Proyectos.Click
        Nuevo_Menu_Proyectos.Enabled = False
        Guardar_Menu_Proyectos.Enabled = False
        Editar_Menu_Proyectos.Enabled = False
        Actualizar_Menu_Proyectos.Enabled = True
        Eliminar_Menu_Proyectos.Enabled = True
        ProyectosDataGridView.Enabled = False
        Desbloquear_Objetos_Proyectos()
        Timer_Actualizar_Proyectos()
        Timer_Eliminar_Proyectos()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_Proyectos.Click
        Control_Nulos_Proyectos()

        If ControlNulos.Text = "" Then ' Then
            SP_Proyectos_EDICION_ACTUALIZAR()
            Cancelar_Proyectos()
            Parar_Timer_Proyectos()
        End If
    End Sub
    Private Sub Eliminar_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_Proyectos.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_Proyectos_EDICION_ELIMINAR()
            Cancelar_Proyectos()
            Parar_Timer_Proyectos()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_Proyectos()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_Proyectos.Click
        Cancelar_Proyectos()
    End Sub
#End Region
#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_Proyectos()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreProyectoTextBox.Text = ""
                MsgBox("El nombre del campo: NombreProyecto; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreProyectoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case DescripcionTextBox.Text = ""
                MsgBox("El nombre del campo: Descripcion; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                DescripcionTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub NombreProyectoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreProyectoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreProyectoTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombreProyectoTextBox.Text = ""
                NombreProyectoTextBox.Focus()
            Else
                DescripcionTextBox.Enabled = True
                DescripcionTextBox.Focus()
            End If
        End If
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (NombreProyectoTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(NombreProyectoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreProyectoTextBox.Text = ""
            NombreProyectoTextBox.Text = Caracter
            NombreProyectoTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(NombreProyectoTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(NombreProyectoTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(NombreProyectoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreProyectoTextBox.Text = ""
            NombreProyectoTextBox.Text = Temp + Caracter
            NombreProyectoTextBox.SelectionStart = Longitud + 1
        End If
    End Sub
    Private Sub DescripcionTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_Proyectos.Enabled = True Then
                Actualizar_Menu_Proyectos.Enabled = True
                Eliminar_Menu_Proyectos.Enabled = True
            Else
                If DescripcionTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    DescripcionTextBox.Text = ""
                    DescripcionTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_Proyectos.Enabled = True
                    Timer_Guardar_Proyectos()
                End If
            End If
        End If
    End Sub
    Public Sub Limpiar_Objetos_Proyectos()
        NombreProyectoTextBox.Text = "" ''
        DescripcionTextBox.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_Proyectos()
        NombreProyectoTextBox.Enabled = True
        DescripcionTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_Proyectos()
        NombreProyectoTextBox.Enabled = False
        DescripcionTextBox.Enabled = False
    End Sub

#End Region

#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_Proyectos As Timer
    Private WithEvents Timer_Actualizar_Menu_Proyectos As Timer
    Private WithEvents Timer_Eliminar_Menu_Proyectos As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_Proyectos()
        Me.Timer_Guardar_Menu_Proyectos = New Timer
        Timer_Guardar_Menu_Proyectos.Interval = 250
        Timer_Guardar_Menu_Proyectos.Start()
    End Sub
    Private Sub Timer_Actualizar_Proyectos()
        Me.Timer_Actualizar_Menu_Proyectos = New Timer
        Timer_Actualizar_Menu_Proyectos.Interval = 500
        Timer_Actualizar_Menu_Proyectos.Start()
    End Sub
    Private Sub Timer_Eliminar_Proyectos()
        Me.Timer_Eliminar_Menu_Proyectos = New Timer
        Timer_Eliminar_Menu_Proyectos.Interval = 800
        Timer_Eliminar_Menu_Proyectos.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_Proyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_Proyectos.Tick
        If Guardar_Menu_Proyectos.BackColor = Color.White Then
            Guardar_Menu_Proyectos.BackColor = Color.Green
        Else
            Guardar_Menu_Proyectos.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_Proyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_Proyectos.Tick
        If Actualizar_Menu_Proyectos.BackColor = Color.White Then
            Actualizar_Menu_Proyectos.BackColor = Color.Green
        Else
            Actualizar_Menu_Proyectos.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_Proyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_Proyectos.Tick
        If Eliminar_Menu_Proyectos.BackColor = Color.White Then
            Eliminar_Menu_Proyectos.BackColor = Color.Red
        Else
            Eliminar_Menu_Proyectos.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_Proyectos()
        Me.Timer_Guardar_Menu_Proyectos = New Timer
        Timer_Guardar_Menu_Proyectos.Stop()
        Guardar_Menu_Proyectos.BackColor = Color.White
        Me.Timer_Actualizar_Menu_Proyectos = New Timer
        Timer_Actualizar_Menu_Proyectos.Stop()
        Actualizar_Menu_Proyectos.BackColor = Color.White
        Me.Timer_Eliminar_Menu_Proyectos = New Timer
        Timer_Eliminar_Menu_Proyectos.Stop()
        Eliminar_Menu_Proyectos.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_Proyectos As Timer
    Dim X_Proyectos
    Private Sub Timer_Ubicar_En_Fila_Proyectos()
        Me.Timer_Ubicacion_Proyectos = New Timer
        Timer_Ubicacion_Proyectos.Interval = 100
        Timer_Ubicacion_Proyectos.Start()
    End Sub
    Private Sub ProyectosDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ProyectosDataGridView.CellMouseClick
        X_Proyectos = ProyectosDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_Proyectos()
        Try
            Me.ProyectosDataGridView.Rows(X_Proyectos).Selected = True
            Me.ProyectosDataGridView.FirstDisplayedScrollingRowIndex = X_Proyectos
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_Proyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_Proyectos.Tick
        Ubicar_En_Fila_Proyectos()
        Timer_Ubicacion_Proyectos.Stop()
    End Sub

    Private Sub SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        Try
            Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter.Fill(Me.DataSetAdministracion.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ProyectoIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProyectoIDTextBox.TextChanged
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
    End Sub

    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.CellMouseDoubleClick
        SP_ProyectosYTecnologias_EDICION_INSERTAR()
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        MsgBox("Se Crea Relación Del Proyecto" & NombreProyectoTextBox.Text & " con la tecnologia " & NombreTecnologiaTextBox.Text, MsgBoxStyle.Information)
    End Sub

    Private Sub SP_ProyectosYTecnologias_EDICION_INSERTAR()
        Try
            Me.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectosYTecnologias_EDICION_INSERTAR, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)), New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)), New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ELIMINA_SEGUN_PROYECTO()
        Try
            Me.ELIMINA_SEGUN_PROYECTOTableAdapter.Fill(Me.DataSetAdministracion.ELIMINA_SEGUN_PROYECTO, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)), New System.Nullable(Of Integer)(CType(TecnologiaID_EliminaRelacion.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.CellMouseDoubleClick
        ELIMINA_SEGUN_PROYECTO()
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        MsgBox("Se Elimino Relacion", MsgBoxStyle.Exclamation)
    End Sub


#End Region



End Class