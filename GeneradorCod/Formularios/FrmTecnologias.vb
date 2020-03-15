Public Class FrmTecnologias
    Private Sub FrmTecnologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetAdministracion.Tipos' Puede moverla o quitarla según sea necesario.
        Me.TiposTableAdapter.Fill(Me.DataSetAdministracion.Tipos)
        'TODO: esta línea de código carga datos en la tabla 'DataSetAdministracion.Tipos' Puede moverla o quitarla según sea necesario.

        Try
            Me.TecnologiasTableAdapter.Fill(Me.DataSetAdministracion.Tecnologias)
            Cancelar_Tecnologias()
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
            Cancelar_Plantillas()
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            Cancelar_Componentes()
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            Cancelar_RequerimientosPlantillas()
            SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            Cancelar_CampoComponentes()
            Me.SP_CARGA_CONVENSIONES_USADASTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CARGA_CONVENSIONES_USADAS)
            SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            Cancelar_TablasRelacionadas()
            SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
            Cancelar_TextoEnriquecido()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub TecnologiasDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TecnologiasDataGridView.CellFormatting
        Try
            If TecnologiasDataGridView.Columns(e.ColumnIndex).Name = "Validada" Then
                Dim _filaDGV As DataGridViewRow = TecnologiasDataGridView.Rows(e.RowIndex)
                If CStr(_filaDGV.Cells(1).Value) = "True" Then
                    _filaDGV.DefaultCellStyle.BackColor = Color.Green
                    _filaDGV.DefaultCellStyle.ForeColor = Color.White
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


#Region "Procedimientos"
    Sub Cancelar_Tecnologias()
        'Botones Del Menu
        Nuevo_Menu_Tecnologias.Enabled = True
        Guardar_Menu_Tecnologias.Enabled = False
        Editar_Menu_Tecnologias.Enabled = True
        Actualizar_Menu_Tecnologias.Enabled = False
        Eliminar_Menu_Tecnologias.Enabled = False
        'Grid
        TecnologiasDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.TecnologiasTableAdapter.Fill(Me.DataSetAdministracion.Tecnologias)
        Bloquear_Objetos_Tecnologias()
        Parar_Timer_Tecnologias()
        Timer_Ubicar_En_Fila_Tecnologias()
    End Sub
    'Insertar
    Private Sub SP_Tecnologias_EDICION_INSERTAR()
        Try
            Me.SP_Tecnologias_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_Tecnologias_EDICION_INSERTAR,
                                                 NombreTecnologiaTextBox.Text,
                                                 New System.Nullable(Of Boolean)(CType(ValidadaTextBox.Text, Boolean)))

            Me.TecnologiasTableAdapter.Fill(Me.DataSetAdministracion.Tecnologias)
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    'Actualizar
    Private Sub SP_Tecnologias_EDICION_ACTUALIZAR()
        Try
            Me.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Tecnologias_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)),
                                                 NombreTecnologiaTextBox.Text,
                                                 New System.Nullable(Of Boolean)(CType(ValidadaTextBox.Text, Boolean)))

            Me.TecnologiasTableAdapter.Fill(Me.DataSetAdministracion.Tecnologias)
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    'Eliminar
    Private Sub SP_Tecnologias_EDICION_ELIMINAR()
        Try
            Me.SP_Tecnologias_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetAdministracion.SP_Tecnologias_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(TecnologiaIDTextBox.Text, Long)))
            Me.TecnologiasTableAdapter.Fill(Me.DataSetAdministracion.Tecnologias)
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
#End Region
#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_Tecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_Tecnologias.Click
        Nuevo_Menu_Tecnologias.Enabled = False
        Editar_Menu_Tecnologias.Enabled = False
        TecnologiasDataGridView.Enabled = False
        Limpiar_Objetos_Tecnologias()
        NombreTecnologiaTextBox.Enabled = True
        NombreTecnologiaTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_Tecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_Tecnologias.Click
        Control_Nulos_Tecnologias()
        If ControlNulos.Text = "" Then ' Then
            SP_Tecnologias_EDICION_INSERTAR()
            Cancelar_Tecnologias()
            Parar_Timer_Tecnologias()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_Tecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_Tecnologias.Click
        Nuevo_Menu_Tecnologias.Enabled = False
        Guardar_Menu_Tecnologias.Enabled = False
        Editar_Menu_Tecnologias.Enabled = False
        Actualizar_Menu_Tecnologias.Enabled = True
        Eliminar_Menu_Tecnologias.Enabled = True
        TecnologiasDataGridView.Enabled = False
        Desbloquear_Objetos_Tecnologias()
        Timer_Actualizar_Tecnologias()
        Timer_Eliminar_Tecnologias()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_Tecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_Tecnologias.Click
        Control_Nulos_Tecnologias()

        If ControlNulos.Text = "" Then ' Then
            SP_Tecnologias_EDICION_ACTUALIZAR()
            Cancelar_Tecnologias()
            Parar_Timer_Tecnologias()
        End If
    End Sub
    Private Sub Eliminar_Menu_Tecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_Tecnologias.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_Tecnologias_EDICION_ELIMINAR()
            Cancelar_Tecnologias()
            Parar_Timer_Tecnologias()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_Tecnologias()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_Tecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_Tecnologias.Click
        Cancelar_Tecnologias()
    End Sub


#End Region
#Region "Eventos sobre Objetos "
    Private Sub ValidadaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidadaCheckBox.CheckedChanged
        If ValidadaCheckBox.Checked = True Then
            ValidadaCheckBox.Text = "Validado"
            ValidadaTextBox.Text = "True"
            ValidadaCheckBox.BackColor = Color.Green
        Else
            ValidadaCheckBox.Text = "Sin Validar"
            ValidadaTextBox.Text = "False"
            ValidadaCheckBox.BackColor = Color.Red
        End If
    End Sub

    'Control de Nulos
    Public Sub Control_Nulos_Tecnologias()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreTecnologiaTextBox.Text = ""
                MsgBox("El nombre del campo: NombreTecnologia; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreTecnologiaTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub TecnologiaIDTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TecnologiaIDTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TecnologiaIDTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                TecnologiaIDTextBox.Text = ""
                TecnologiaIDTextBox.Focus()
            Else
                NombreTecnologiaTextBox.Enabled = True
                NombreTecnologiaTextBox.Focus()
            End If
        End If
    End Sub
    Private Sub NombreTecnologiaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTecnologiaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_Tecnologias.Enabled = True Then
                Actualizar_Menu_Tecnologias.Enabled = True
                Eliminar_Menu_Tecnologias.Enabled = True
            Else
                If NombreTecnologiaTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    NombreTecnologiaTextBox.Text = ""
                    NombreTecnologiaTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_Tecnologias.Enabled = True
                    Timer_Guardar_Tecnologias()
                End If
            End If
        End If
    End Sub
    Public Sub Limpiar_Objetos_Tecnologias()
        NombreTecnologiaTextBox.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_Tecnologias()
        NombreTecnologiaTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_Tecnologias()
        NombreTecnologiaTextBox.Enabled = False
    End Sub
#End Region
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_Tecnologias As Timer
    Private WithEvents Timer_Actualizar_Menu_Tecnologias As Timer
    Private WithEvents Timer_Eliminar_Menu_Tecnologias As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_Tecnologias()
        Me.Timer_Guardar_Menu_Tecnologias = New Timer
        Timer_Guardar_Menu_Tecnologias.Interval = 250
        Timer_Guardar_Menu_Tecnologias.Start()
    End Sub
    Private Sub Timer_Actualizar_Tecnologias()
        Me.Timer_Actualizar_Menu_Tecnologias = New Timer
        Timer_Actualizar_Menu_Tecnologias.Interval = 500
        Timer_Actualizar_Menu_Tecnologias.Start()
    End Sub
    Private Sub Timer_Eliminar_Tecnologias()
        Me.Timer_Eliminar_Menu_Tecnologias = New Timer
        Timer_Eliminar_Menu_Tecnologias.Interval = 800
        Timer_Eliminar_Menu_Tecnologias.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_Tecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_Tecnologias.Tick
        If Guardar_Menu_Tecnologias.BackColor = Color.White Then
            Guardar_Menu_Tecnologias.BackColor = Color.Green
        Else
            Guardar_Menu_Tecnologias.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_Tecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_Tecnologias.Tick
        If Actualizar_Menu_Tecnologias.BackColor = Color.White Then
            Actualizar_Menu_Tecnologias.BackColor = Color.Green
        Else
            Actualizar_Menu_Tecnologias.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_Tecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_Tecnologias.Tick
        If Eliminar_Menu_Tecnologias.BackColor = Color.White Then
            Eliminar_Menu_Tecnologias.BackColor = Color.Red
        Else
            Eliminar_Menu_Tecnologias.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_Tecnologias()
        Me.Timer_Guardar_Menu_Tecnologias = New Timer
        Timer_Guardar_Menu_Tecnologias.Stop()
        Guardar_Menu_Tecnologias.BackColor = Color.White
        Me.Timer_Actualizar_Menu_Tecnologias = New Timer
        Timer_Actualizar_Menu_Tecnologias.Stop()
        Actualizar_Menu_Tecnologias.BackColor = Color.White
        Me.Timer_Eliminar_Menu_Tecnologias = New Timer
        Timer_Eliminar_Menu_Tecnologias.Stop()
        Eliminar_Menu_Tecnologias.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_Tecnologias As Timer
    Dim X_Tecnologias
    Private Sub Timer_Ubicar_En_Fila_Tecnologias()
        Me.Timer_Ubicacion_Tecnologias = New Timer
        Timer_Ubicacion_Tecnologias.Interval = 100
        Timer_Ubicacion_Tecnologias.Start()
    End Sub
    Private Sub TecnologiasDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles TecnologiasDataGridView.CellMouseClick
        X_Tecnologias = TecnologiasDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_Tecnologias()
        Try
            Me.TecnologiasDataGridView.Rows(X_Tecnologias).Selected = True
            Me.TecnologiasDataGridView.FirstDisplayedScrollingRowIndex = X_Tecnologias
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_Tecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_Tecnologias.Tick
        Ubicar_En_Fila_Tecnologias()
        Timer_Ubicacion_Tecnologias.Stop()
    End Sub

    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
        Try
            Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia, New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TecnologiaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles TecnologiaIDTextBox.TextChanged
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
    End Sub


#End Region





#Region "Procedimientos"
    Sub Cancelar_Plantillas()
        'Botones Del Menu
        Nuevo_Menu_Plantillas.Enabled = True
        Guardar_Menu_Plantillas.Enabled = False
        Editar_Menu_Plantillas.Enabled = True
        Actualizar_Menu_Plantillas.Enabled = False
        Eliminar_Menu_Plantillas.Enabled = False
        'Grid
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
        Bloquear_Objetos_Plantillas()
        Parar_Timer_Plantillas()
        Timer_Ubicar_En_Fila_Plantillas()
    End Sub
    'Insertar
    Private Sub SP_Plantillas_EDICION_INSERTAR()
        Try
            Me.SP_Plantillas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)),
                                                 NombrePlantillaTextBox.Text,
                                                 New System.Nullable(Of Integer)(CType(OrdenTextBox.Text, Integer)))
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    'Actualizar
    Private Sub SP_Plantillas_EDICION_ACTUALIZAR()
        Try
            Me.SP_Plantillas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)),
                                                 NombrePlantillaTextBox.Text,
                                                 New System.Nullable(Of Integer)(CType(OrdenTextBox.Text, Integer)))
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    'Eliminar
    Private Sub SP_Plantillas_EDICION_ELIMINAR()
        Try
            Me.SP_Plantillas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(PlantillaIDTextBox.Text, Long)))

            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_Plantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_Plantillas.Click
        Nuevo_Menu_Plantillas.Enabled = False
        Editar_Menu_Plantillas.Enabled = False
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Enabled = False
        Limpiar_Objetos_Plantillas()
        NombrePlantillaTextBox.Enabled = True
        NombrePlantillaTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_Plantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_Plantillas.Click
        Control_Nulos_Plantillas()

        If ControlNulos.Text = "" Then ' Then
            SP_Plantillas_EDICION_INSERTAR()
            Cancelar_Plantillas()
            Parar_Timer_Plantillas()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_Plantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_Plantillas.Click
        Nuevo_Menu_Plantillas.Enabled = False
        Guardar_Menu_Plantillas.Enabled = False
        Editar_Menu_Plantillas.Enabled = False
        Actualizar_Menu_Plantillas.Enabled = True
        Eliminar_Menu_Plantillas.Enabled = True
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Enabled = False
        Desbloquear_Objetos_Plantillas()
        Timer_Actualizar_Plantillas()
        Timer_Eliminar_Plantillas()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_Plantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_Plantillas.Click
        Control_Nulos_Plantillas()

        If ControlNulos.Text = "" Then ' Then
            SP_Plantillas_EDICION_ACTUALIZAR()
            Cancelar_Plantillas()
            Parar_Timer_Plantillas()
        End If
    End Sub
    Private Sub Eliminar_Menu_Plantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_Plantillas.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_Plantillas_EDICION_ELIMINAR()
            Cancelar_Plantillas()
            Parar_Timer_Plantillas()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_Plantillas()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_Plantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_Plantillas.Click
        Cancelar_Plantillas()
    End Sub
#End Region
#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_Plantillas()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case TecnologiaIDTextBox.Text = ""
                MsgBox("El nombre del campo: TecnologiaID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TecnologiaIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case NombrePlantillaTextBox.Text = ""
                MsgBox("El nombre del campo: Nombre Plantilla; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombrePlantillaTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub NombrePlantillaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombrePlantillaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombrePlantillaTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombrePlantillaTextBox.Text = ""
                NombrePlantillaTextBox.Focus()
            Else
                OrdenTextBox.Enabled = True
                OrdenTextBox.Focus()
            End If
        End If
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (NombrePlantillaTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(NombrePlantillaTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombrePlantillaTextBox.Text = ""
            NombrePlantillaTextBox.Text = Caracter
            NombrePlantillaTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(NombrePlantillaTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(NombrePlantillaTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(NombrePlantillaTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombrePlantillaTextBox.Text = ""
            NombrePlantillaTextBox.Text = Temp + Caracter
            NombrePlantillaTextBox.SelectionStart = Longitud + 1
        End If
    End Sub
    Private Sub OrdenTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OrdenTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_Plantillas.Enabled = True Then
                Actualizar_Menu_Plantillas.Enabled = True
                Eliminar_Menu_Plantillas.Enabled = True
            Else
                If OrdenTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    OrdenTextBox.Text = ""
                    OrdenTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_Plantillas.Enabled = True
                    Timer_Guardar_Plantillas()
                End If
            End If
        End If
    End Sub

    Public Sub Limpiar_Objetos_Plantillas()
        NombrePlantillaTextBox.Text = "" ''
        OrdenTextBox.Text = ""
    End Sub
    Public Sub Desbloquear_Objetos_Plantillas()
        NombrePlantillaTextBox.Enabled = True
        OrdenTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_Plantillas()
        NombrePlantillaTextBox.Enabled = False
        OrdenTextBox.Enabled = False
    End Sub
#End Region
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_Plantillas As Timer
    Private WithEvents Timer_Actualizar_Menu_Plantillas As Timer
    Private WithEvents Timer_Eliminar_Menu_Plantillas As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_Plantillas()
        Me.Timer_Guardar_Menu_Plantillas = New Timer
        Timer_Guardar_Menu_Plantillas.Interval = 250
        Timer_Guardar_Menu_Plantillas.Start()
    End Sub
    Private Sub Timer_Actualizar_Plantillas()
        Me.Timer_Actualizar_Menu_Plantillas = New Timer
        Timer_Actualizar_Menu_Plantillas.Interval = 500
        Timer_Actualizar_Menu_Plantillas.Start()
    End Sub
    Private Sub Timer_Eliminar_Plantillas()
        Me.Timer_Eliminar_Menu_Plantillas = New Timer
        Timer_Eliminar_Menu_Plantillas.Interval = 800
        Timer_Eliminar_Menu_Plantillas.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_Plantillas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_Plantillas.Tick
        If Guardar_Menu_Plantillas.BackColor = Color.White Then
            Guardar_Menu_Plantillas.BackColor = Color.Green
        Else
            Guardar_Menu_Plantillas.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_Plantillas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_Plantillas.Tick
        If Actualizar_Menu_Plantillas.BackColor = Color.White Then
            Actualizar_Menu_Plantillas.BackColor = Color.Green
        Else
            Actualizar_Menu_Plantillas.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_Plantillas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_Plantillas.Tick
        If Eliminar_Menu_Plantillas.BackColor = Color.White Then
            Eliminar_Menu_Plantillas.BackColor = Color.Red
        Else
            Eliminar_Menu_Plantillas.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_Plantillas()
        Me.Timer_Guardar_Menu_Plantillas = New Timer
        Timer_Guardar_Menu_Plantillas.Stop()
        Guardar_Menu_Plantillas.BackColor = Color.White
        Me.Timer_Actualizar_Menu_Plantillas = New Timer
        Timer_Actualizar_Menu_Plantillas.Stop()
        Actualizar_Menu_Plantillas.BackColor = Color.White
        Me.Timer_Eliminar_Menu_Plantillas = New Timer
        Timer_Eliminar_Menu_Plantillas.Stop()
        Eliminar_Menu_Plantillas.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_Plantillas As Timer
    Dim X_Plantillas
    Private Sub Timer_Ubicar_En_Fila_Plantillas()
        Me.Timer_Ubicacion_Plantillas = New Timer
        Timer_Ubicacion_Plantillas.Interval = 100
        Timer_Ubicacion_Plantillas.Start()
    End Sub
    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.CellMouseClick
        X_Plantillas = SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_Plantillas()
        Try
            Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Rows(X_Plantillas).Selected = True
            Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.FirstDisplayedScrollingRowIndex = X_Plantillas
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_Plantillas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_Plantillas.Tick
        Ubicar_En_Fila_Plantillas()
        Timer_Ubicacion_Plantillas.Stop()
    End Sub

    Private Sub PlantillaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIDTextBox.TextChanged
        Try
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            If RB_Plantilla.Checked = "True" Then
                SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLA()
                SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.Visible = True
                SP_CARGA_CONVENSIONES_USADASDataGridView.Visible = False
            Else
                SP_CARGA_CONVENSIONES_USADASDataGridView.Visible = True
                SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
            'ContenidoComponenteRichTextBox.Rtf = ContenidoComponenteRichTextBox.Text
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


#End Region


#Region "Procedimientos"
    Sub Cancelar_Componentes()
        'Botones Del Menu
        Nuevo_Menu_Componentes.Enabled = True
        Guardar_Menu_Componentes.Enabled = False
        Editar_Menu_Componentes.Enabled = True
        Actualizar_Menu_Componentes.Enabled = False
        Eliminar_Menu_Componentes.Enabled = False
        'Grid
        SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Bloquear_Objetos_Componentes()
        Parar_Timer_Componentes()
        Timer_Ubicar_En_Fila_Componentes()
        'Me.TecnologiasTableAdapter.Fill(Me.DataSetAdministracion.Tecnologias)
    End Sub
    'Insertar
    Private Sub SP_Componentes_EDICION_INSERTAR()
        Try
            Me.SP_Componentes_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 NombreComponenteTextBox.Text,
                                                 ContenidoComponenteRichTextBox.Text,
                                                 XTablaTextBox.Text)
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub SP_Componentes_EDICION_ACTUALIZAR()
        Try
            Me.SP_Componentes_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 NombreComponenteTextBox.Text,
                                                 ContenidoComponenteRichTextBox.Text,
                                                 XTablaTextBox.Text)
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_Componentes_EDICION_ELIMINAR()
        Try
            Me.SP_Componentes_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(ComponenteIDTextBox.Text, Long)))
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_Componentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_Componentes.Click
        Nuevo_Menu_Componentes.Enabled = False
        Editar_Menu_Componentes.Enabled = False
        SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = False
        Limpiar_Objetos_Componentes()
        NombreComponenteTextBox.Enabled = True
        NombreComponenteTextBox.Focus()
        XTablaTextBox.Text = False
    End Sub
    'Guardar
    Private Sub Guardar_Menu_Componentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_Componentes.Click
        Control_Nulos_Componentes()

        If ControlNulos.Text = "" Then ' Then
            SP_Componentes_EDICION_INSERTAR()
            Cancelar_Componentes()
            Parar_Timer_Componentes()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_Componentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_Componentes.Click
        Nuevo_Menu_Componentes.Enabled = False
        Guardar_Menu_Componentes.Enabled = False
        Editar_Menu_Componentes.Enabled = False
        Actualizar_Menu_Componentes.Enabled = True
        Eliminar_Menu_Componentes.Enabled = True
        SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = False
        Desbloquear_Objetos_Componentes()
        Timer_Actualizar_Componentes()
        Timer_Eliminar_Componentes()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_Componentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_Componentes.Click
        Control_Nulos_Componentes()

        If ControlNulos.Text = "" Then ' Then
            SP_Componentes_EDICION_ACTUALIZAR()
            Cancelar_Componentes()
            Parar_Timer_Componentes()
        End If
    End Sub
    Private Sub Eliminar_Menu_Componentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_Componentes.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_Componentes_EDICION_ELIMINAR()
            Cancelar_Componentes()
            Parar_Timer_Componentes()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_Componentes()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_Componentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_Componentes.Click
        Cancelar_Componentes()
    End Sub
#End Region
#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_Componentes()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case PlantillaIDTextBox.Text = ""
                MsgBox("El nombre del campo: PlantillaID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                PlantillaIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case NombreComponenteTextBox.Text = ""
                MsgBox("El nombre del campo: NombreComponente; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreComponenteTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case ContenidoComponenteRichTextBox.Text = ""
                MsgBox("El nombre del campo: Codigo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ContenidoComponenteRichTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub NombreComponenteTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreComponenteTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreComponenteTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombreComponenteTextBox.Text = ""
                NombreComponenteTextBox.Focus()
            Else
                XTablaCheckBox.Enabled = True
                XTablaCheckBox.Focus()
            End If
        End If
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (NombreComponenteTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(NombreComponenteTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreComponenteTextBox.Text = ""
            NombreComponenteTextBox.Text = Caracter
            NombreComponenteTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(NombreComponenteTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(NombreComponenteTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(NombreComponenteTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreComponenteTextBox.Text = ""
            NombreComponenteTextBox.Text = Temp + Caracter
            NombreComponenteTextBox.SelectionStart = Longitud + 1
        End If
    End Sub

    Private Sub XTablaCheckBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles XTablaCheckBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If XTablaCheckBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                XTablaCheckBox.Text = ""
                XTablaCheckBox.Focus()
            Else
                ContenidoComponenteRichTextBox.Enabled = True
                ContenidoComponenteRichTextBox.Focus()
            End If
        End If
    End Sub


    Private Sub ContenidoComponenteRichTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContenidoComponenteRichTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_Componentes.Enabled = True Then
                Actualizar_Menu_Componentes.Enabled = True
                Eliminar_Menu_Componentes.Enabled = True
            Else
                If ContenidoComponenteRichTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    ContenidoComponenteRichTextBox.Text = ""
                    ContenidoComponenteRichTextBox.Focus()
                Else
                    If Nuevo_Menu_Componentes.Enabled = False Then
                        MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                        Guardar_Menu_Componentes.Enabled = True
                        Timer_Guardar_Componentes()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub XTablaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XTablaCheckBox.CheckedChanged
        If XTablaCheckBox.Checked = True Then
            XTablaCheckBox.Text = "SI"
            XTablaTextBox.Text = "True"
        Else
            XTablaCheckBox.Text = "NO"
            XTablaTextBox.Text = "False"
        End If
    End Sub

    Public Sub Limpiar_Objetos_Componentes()
        NombreComponenteTextBox.Text = "" ''
        ContenidoComponenteRichTextBox.Text = "" ''
        XTablaTextBox.Text = ""
    End Sub
    Public Sub Desbloquear_Objetos_Componentes()
        NombreComponenteTextBox.Enabled = True
        XTablaCheckBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_Componentes()
        NombreComponenteTextBox.Enabled = False
        XTablaCheckBox.Enabled = False
    End Sub
#End Region
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_Componentes As Timer
    Private WithEvents Timer_Actualizar_Menu_Componentes As Timer
    Private WithEvents Timer_Eliminar_Menu_Componentes As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_Componentes()
        Me.Timer_Guardar_Menu_Componentes = New Timer
        Timer_Guardar_Menu_Componentes.Interval = 250
        Timer_Guardar_Menu_Componentes.Start()
    End Sub
    Private Sub Timer_Actualizar_Componentes()
        Me.Timer_Actualizar_Menu_Componentes = New Timer
        Timer_Actualizar_Menu_Componentes.Interval = 500
        Timer_Actualizar_Menu_Componentes.Start()
    End Sub
    Private Sub Timer_Eliminar_Componentes()
        Me.Timer_Eliminar_Menu_Componentes = New Timer
        Timer_Eliminar_Menu_Componentes.Interval = 800
        Timer_Eliminar_Menu_Componentes.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_Componentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_Componentes.Tick
        If Guardar_Menu_Componentes.BackColor = Color.White Then
            Guardar_Menu_Componentes.BackColor = Color.Green
        Else
            Guardar_Menu_Componentes.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_Componentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_Componentes.Tick
        If Actualizar_Menu_Componentes.BackColor = Color.White Then
            Actualizar_Menu_Componentes.BackColor = Color.Green
        Else
            Actualizar_Menu_Componentes.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_Componentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_Componentes.Tick
        If Eliminar_Menu_Componentes.BackColor = Color.White Then
            Eliminar_Menu_Componentes.BackColor = Color.Red
        Else
            Eliminar_Menu_Componentes.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_Componentes()
        Me.Timer_Guardar_Menu_Componentes = New Timer
        Timer_Guardar_Menu_Componentes.Stop()
        Guardar_Menu_Componentes.BackColor = Color.White
        Me.Timer_Actualizar_Menu_Componentes = New Timer
        Timer_Actualizar_Menu_Componentes.Stop()
        Actualizar_Menu_Componentes.BackColor = Color.White
        Me.Timer_Eliminar_Menu_Componentes = New Timer
        Timer_Eliminar_Menu_Componentes.Stop()
        Eliminar_Menu_Componentes.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_Componentes As Timer
    Dim X_Componentes
    Private Sub Timer_Ubicar_En_Fila_Componentes()
        Me.Timer_Ubicacion_Componentes = New Timer
        Timer_Ubicacion_Componentes.Interval = 100
        Timer_Ubicacion_Componentes.Start()
    End Sub
    Private Sub SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CellMouseClick
        Try
            X_Componentes = SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentRow.Index
            'ContenidoComponenteRichTextBox.Rtf = ContenidoComponenteRichTextBox.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Ubicar_En_Fila_Componentes()
        Try
            Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows(X_Componentes).Selected = True
            Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.FirstDisplayedScrollingRowIndex = X_Componentes
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_Componentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_Componentes.Tick
        Ubicar_En_Fila_Componentes()
        Timer_Ubicacion_Componentes.Stop()
    End Sub

    Private Sub SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
            EnunciadoRichTextBox.Rtf = EnunciadoRichTextBox.Text
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub





#End Region


#Region "Procedimientos"
    Sub Cancelar_RequerimientosPlantillas()
        'Botones Del Menu
        Nuevo_Menu_RequerimientosPlantillas.Enabled = True
        Guardar_Menu_RequerimientosPlantillas.Enabled = False
        Editar_Menu_RequerimientosPlantillas.Enabled = True
        Actualizar_Menu_RequerimientosPlantillas.Enabled = False
        Eliminar_Menu_RequerimientosPlantillas.Enabled = False
        'Grid
        SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Bloquear_Objetos_RequerimientosPlantillas()
        Parar_Timer_RequerimientosPlantillas()
        Timer_Ubicar_En_Fila_RequerimientosPlantillas()
    End Sub
    'Insertar
    Private Sub SP_RequerimientosPlantillas_EDICION_INSERTAR()
        Try
            Me.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_RequerimientosPlantillas_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 EnunciadoRichTextBox.Rtf,
                                                 RequerimientoTextBox.Text,
                                                 New System.Nullable(Of Integer)(CType(OrdenDePeticionTextBox.Text, Integer)))
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub SP_RequerimientosPlantillas_EDICION_ACTUALIZAR()
        Try
            Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_RequerimientosPlantillas_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(RequerimientoPlantillaIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 EnunciadoRichTextBox.Rtf,
                                                 RequerimientoTextBox.Text,
                                                 New System.Nullable(Of Integer)(CType(OrdenDePeticionTextBox.Text, Integer)))
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_RequerimientosPlantillas_EDICION_ELIMINAR()
        Try
            Me.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetAdministracion.SP_RequerimientosPlantillas_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(RequerimientoPlantillaIDTextBox.Text, Long)))
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_RequerimientosPlantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_RequerimientosPlantillas.Click
        Nuevo_Menu_RequerimientosPlantillas.Enabled = False
        Editar_Menu_RequerimientosPlantillas.Enabled = False
        SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = False
        Limpiar_Objetos_RequerimientosPlantillas()
        EnunciadoRichTextBox.Enabled = True
        EnunciadoRichTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_RequerimientosPlantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_RequerimientosPlantillas.Click
        Control_Nulos_RequerimientosPlantillas()

        If ControlNulos.Text = "" Then ' Then
            SP_RequerimientosPlantillas_EDICION_INSERTAR()
            Cancelar_RequerimientosPlantillas()
            Parar_Timer_RequerimientosPlantillas()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_RequerimientosPlantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_RequerimientosPlantillas.Click
        Nuevo_Menu_RequerimientosPlantillas.Enabled = False
        Guardar_Menu_RequerimientosPlantillas.Enabled = False
        Editar_Menu_RequerimientosPlantillas.Enabled = False
        Actualizar_Menu_RequerimientosPlantillas.Enabled = True
        Eliminar_Menu_RequerimientosPlantillas.Enabled = True
        SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = False
        Desbloquear_Objetos_RequerimientosPlantillas()
        Timer_Actualizar_RequerimientosPlantillas()
        Timer_Eliminar_RequerimientosPlantillas()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_RequerimientosPlantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_RequerimientosPlantillas.Click
        Control_Nulos_RequerimientosPlantillas()

        If ControlNulos.Text = "" Then ' Then
            SP_RequerimientosPlantillas_EDICION_ACTUALIZAR()
            Cancelar_RequerimientosPlantillas()
            Parar_Timer_RequerimientosPlantillas()
        End If
    End Sub
    Private Sub Eliminar_Menu_RequerimientosPlantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_RequerimientosPlantillas.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_RequerimientosPlantillas_EDICION_ELIMINAR()
            Cancelar_RequerimientosPlantillas()
            Parar_Timer_RequerimientosPlantillas()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_RequerimientosPlantillas()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_RequerimientosPlantillas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_RequerimientosPlantillas.Click
        Cancelar_RequerimientosPlantillas()
    End Sub
#End Region
#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_RequerimientosPlantillas()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case PlantillaIDTextBox.Text = ""
                MsgBox("El nombre del campo: PlantillaID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                PlantillaIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case EnunciadoRichTextBox.Text = ""
                MsgBox("El nombre del campo: Enunciado; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                EnunciadoRichTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case RequerimientoTextBox.Text = ""
                MsgBox("El nombre del campo: Requerimiento; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                RequerimientoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case OrdenDePeticionTextBox.Text = ""
                MsgBox("El nombre del campo: OrdenDePeticion; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                OrdenDePeticionTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub EnunciadoRichTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EnunciadoRichTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If EnunciadoRichTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                EnunciadoRichTextBox.Text = ""
                EnunciadoRichTextBox.Focus()
            Else
                RequerimientoTextBox.Enabled = True
                RequerimientoTextBox.Focus()
            End If
        End If
    End Sub
    Private Sub RequerimientoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RequerimientoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If RequerimientoTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                RequerimientoTextBox.Text = ""
                RequerimientoTextBox.Focus()
            Else
                OrdenDePeticionTextBox.Enabled = True
                OrdenDePeticionTextBox.Focus()
            End If
        End If
    End Sub
    Private Sub OrdenDePeticionTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OrdenDePeticionTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_RequerimientosPlantillas.Enabled = True Then
                Actualizar_Menu_RequerimientosPlantillas.Enabled = True
                Eliminar_Menu_RequerimientosPlantillas.Enabled = True
            Else
                If OrdenDePeticionTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    OrdenDePeticionTextBox.Text = ""
                    OrdenDePeticionTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_RequerimientosPlantillas.Enabled = True
                    Timer_Guardar_RequerimientosPlantillas()
                End If
            End If
        End If
    End Sub
    Public Sub Limpiar_Objetos_RequerimientosPlantillas()
        EnunciadoRichTextBox.Text = "" ''
        RequerimientoTextBox.Text = "" ''
        OrdenDePeticionTextBox.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_RequerimientosPlantillas()
        EnunciadoRichTextBox.Enabled = True
        RequerimientoTextBox.Enabled = True
        OrdenDePeticionTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_RequerimientosPlantillas()
        'EnunciadoRichTextBox.Enabled = False
        RequerimientoTextBox.Enabled = False
        OrdenDePeticionTextBox.Enabled = False
    End Sub
#End Region
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_RequerimientosPlantillas As Timer
    Private WithEvents Timer_Actualizar_Menu_RequerimientosPlantillas As Timer
    Private WithEvents Timer_Eliminar_Menu_RequerimientosPlantillas As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_RequerimientosPlantillas()
        Me.Timer_Guardar_Menu_RequerimientosPlantillas = New Timer
        Timer_Guardar_Menu_RequerimientosPlantillas.Interval = 250
        Timer_Guardar_Menu_RequerimientosPlantillas.Start()
    End Sub
    Private Sub Timer_Actualizar_RequerimientosPlantillas()
        Me.Timer_Actualizar_Menu_RequerimientosPlantillas = New Timer
        Timer_Actualizar_Menu_RequerimientosPlantillas.Interval = 500
        Timer_Actualizar_Menu_RequerimientosPlantillas.Start()
    End Sub
    Private Sub Timer_Eliminar_RequerimientosPlantillas()
        Me.Timer_Eliminar_Menu_RequerimientosPlantillas = New Timer
        Timer_Eliminar_Menu_RequerimientosPlantillas.Interval = 800
        Timer_Eliminar_Menu_RequerimientosPlantillas.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_RequerimientosPlantillas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_RequerimientosPlantillas.Tick
        If Guardar_Menu_RequerimientosPlantillas.BackColor = Color.White Then
            Guardar_Menu_RequerimientosPlantillas.BackColor = Color.Green
        Else
            Guardar_Menu_RequerimientosPlantillas.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_RequerimientosPlantillas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_RequerimientosPlantillas.Tick
        If Actualizar_Menu_RequerimientosPlantillas.BackColor = Color.White Then
            Actualizar_Menu_RequerimientosPlantillas.BackColor = Color.Green
        Else
            Actualizar_Menu_RequerimientosPlantillas.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_RequerimientosPlantillas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_RequerimientosPlantillas.Tick
        If Eliminar_Menu_RequerimientosPlantillas.BackColor = Color.White Then
            Eliminar_Menu_RequerimientosPlantillas.BackColor = Color.Red
        Else
            Eliminar_Menu_RequerimientosPlantillas.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_RequerimientosPlantillas()
        Me.Timer_Guardar_Menu_RequerimientosPlantillas = New Timer
        Timer_Guardar_Menu_RequerimientosPlantillas.Stop()
        Guardar_Menu_RequerimientosPlantillas.BackColor = Color.White
        Me.Timer_Actualizar_Menu_RequerimientosPlantillas = New Timer
        Timer_Actualizar_Menu_RequerimientosPlantillas.Stop()
        Actualizar_Menu_RequerimientosPlantillas.BackColor = Color.White
        Me.Timer_Eliminar_Menu_RequerimientosPlantillas = New Timer
        Timer_Eliminar_Menu_RequerimientosPlantillas.Stop()
        Eliminar_Menu_RequerimientosPlantillas.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_RequerimientosPlantillas As Timer
    Dim X_RequerimientosPlantillas
    Private Sub Timer_Ubicar_En_Fila_RequerimientosPlantillas()
        Me.Timer_Ubicacion_RequerimientosPlantillas = New Timer
        Timer_Ubicacion_RequerimientosPlantillas.Interval = 100
        Timer_Ubicacion_RequerimientosPlantillas.Start()
    End Sub
    Private Sub SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CellMouseClick
        X_RequerimientosPlantillas = SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_RequerimientosPlantillas()
        Try
            Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows(X_RequerimientosPlantillas).Selected = True
            Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.FirstDisplayedScrollingRowIndex = X_RequerimientosPlantillas
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_RequerimientosPlantillas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_RequerimientosPlantillas.Tick
        Ubicar_En_Fila_RequerimientosPlantillas()
        Timer_Ubicacion_RequerimientosPlantillas.Stop()
    End Sub
#End Region



    Private Sub BtnBuscarYPintar_Click(sender As Object, e As EventArgs) Handles BtnBuscarYPintar.Click
        If TxtBuscado.Text <> "" Then
            Try
                Dim index As Integer = 0
                While index < ContenidoComponenteRichTextBox.Text.LastIndexOf(TxtBuscado.Text)
                    ContenidoComponenteRichTextBox.Find(TxtBuscado.Text, index, ContenidoComponenteRichTextBox.TextLength, RichTextBoxFinds.None)
                    ContenidoComponenteRichTextBox.SelectionBackColor = Color.Yellow
                    index = ContenidoComponenteRichTextBox.Text.IndexOf(TxtBuscado.Text, index) + 1
                End While
            Catch ex As Exception

            End Try
        End If
    End Sub
    Dim incremento As Integer = 10
    Private Sub BtnSubirFuente_Click(sender As Object, e As EventArgs) Handles BtnSubirFuente.Click
        Try
            If incremento > 0 Then
                incremento = incremento + 1
                ContenidoComponenteRichTextBox.Font = New Font(ContenidoComponenteRichTextBox.Font.Name, incremento, ContenidoComponenteRichTextBox.Font.Style, ContenidoComponenteRichTextBox.Font.Unit)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnBajarFuente_Click(sender As Object, e As EventArgs) Handles BtnBajarFuente.Click
        Try
            If incremento > 0 Then
                incremento = incremento - 1
                ContenidoComponenteRichTextBox.Font = New Font(ContenidoComponenteRichTextBox.Font.Name, incremento, ContenidoComponenteRichTextBox.Font.Style, ContenidoComponenteRichTextBox.Font.Unit)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SP_Componentes_EDICION_ACTUALIZAR_SoloCodigo()
        Try

            Me.SP_Componentes_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 NombreComponenteTextBox.Text,
                                                 ContenidoComponenteRichTextBox.Text,
                                                 XTablaTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnRemplazar_Click(sender As Object, e As EventArgs) Handles BtnRemplazar.Click
        ContenidoComponenteRichTextBox.Text = RemplazarTexto(TxtBuscado.Text, TxtRemplazarPor.Text, ContenidoComponenteRichTextBox.Text)
    End Sub

    Shared Function RemplazarTexto(TextoBuscado As String, TextoParaRemplazo As String, TextoBase As String) As String
        Try
            TextoParaRemplazo = TextoParaRemplazo.Replace(" "c, String.Empty)
            Dim resultado As String = TextoBase.Replace(TextoBuscado, TextoParaRemplazo)
            Return resultado
        Catch ex As Exception

        End Try
    End Function


    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtBuscado.Text = ""
        TxtBuscado.Focus()
    End Sub

    Private Sub BtnSubirRemplazado_Click(sender As Object, e As EventArgs) Handles BtnSubirRemplazado.Click
        TxtBuscado.Text = TxtRemplazarPor.Text
    End Sub

    Private Sub BtnLimpiarRemplazar_Click(sender As Object, e As EventArgs) Handles BtnLimpiarRemplazar.Click
        TxtRemplazarPor.Text = ""
        TxtRemplazarPor.Focus()
    End Sub

    Private Sub BtnGuardarCodigo_Click(sender As Object, e As EventArgs) Handles BtnGuardarCodigo.Click
        'If MsgBox("Desea Actualizar este codigo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        SP_Componentes_EDICION_ACTUALIZAR_SoloCodigo()
        TabPage1.BackColor = Color.Chartreuse
        PanelGuardado.Visible = True
        TimerGuardarComponente.Start()
    End Sub
    Dim xtiempoGComp As Integer = 0
    Private Sub TimerGuardarComponente_Tick(sender As Object, e As EventArgs) Handles TimerGuardarComponente.Tick
        xtiempoGComp = xtiempoGComp + 1
        If xtiempoGComp = 2 Then
            TabPage1.BackColor = Color.Transparent
            TimerGuardarComponente.Stop()
            xtiempoGComp = 0
            PanelGuardado.Visible = False
        End If
    End Sub
    Private Sub PanelGuardado_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelGuardado.MouseClick
        TabPage1.BackColor = Color.Transparent
        TimerGuardarComponente.Stop()
        xtiempoGComp = 0
        PanelGuardado.Visible = False
    End Sub
    Private Sub Label5_MouseClick(sender As Object, e As MouseEventArgs) Handles Label5.MouseClick
        TabPage1.BackColor = Color.Transparent
        TimerGuardarComponente.Stop()
        xtiempoGComp = 0
        PanelGuardado.Visible = False
    End Sub

    Private Sub TipoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoTextBox.TextChanged
        Cbo_TipoDato.Text = TipoTextBox.Text
    End Sub

    Private Sub RequerimientoPlantillaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles RequerimientoPlantillaIDTextBox.TextChanged
        Try
            Timer1.Start()
            EnunciadoRichTextBox.Rtf = EnunciadoRichTextBox.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            EnunciadoRichTextBox.Rtf = EnunciadoRichTextBox.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            EnunciadoRichTextBox.Rtf = EnunciadoRichTextBox.Text
            Timer1.Stop()
        Catch ex As Exception

        End Try
    End Sub
#Region "Procedimientos"

    Private Sub SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub Cancelar_CampoComponentes()
        'Botones Del Menu
        Nuevo_Menu_CampoComponentes.Enabled = True
        Guardar_Menu_CampoComponentes.Enabled = False
        Editar_Menu_CampoComponentes.Enabled = True
        Actualizar_Menu_CampoComponentes.Enabled = False
        Eliminar_Menu_CampoComponentes.Enabled = False
        'Grid
        SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Bloquear_Objetos_CampoComponentes()
        Parar_Timer_CampoComponentes()
        Timer_Ubicar_En_Fila_CampoComponentes()
    End Sub
    'Insertar
    Private Sub SP_CampoComponentes_EDICION_INSERTAR()
        Try
            Me.SP_CampoComponentes_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CampoComponentes_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 Cbo_TipoDato.Text,
                                                 PrefijoTextBox.Text,
                                                 SuperiorTextBox.Text,
                                                 SufijoTextBox.Text,
                                                 InferiorTextBox.Text,
                                                 SeparadorCamposTextBox.Text,
                                                 MultiReplaceTextBox.Text)
            SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_CampoComponentes_EDICION_INSERTAR_Copia()
        Try
            Dim tipo As String = Cbo_TipoDato.Text
            Dim Prefijo As String = PrefijoTextBox.Text
            Dim Superior As String = SuperiorTextBox.Text
            Dim Sufijo As String = SufijoTextBox.Text
            Dim Inferior As String = InferiorTextBox.Text
            Dim Separador As String = SeparadorCamposTextBox.Text
            Dim Multi As String = MultiReplaceTextBox.Text

            Me.SP_CampoComponentes_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CampoComponentes_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 tipo,
                                                 Prefijo,
                                                 Superior,
                                                 Sufijo,
                                                 Inferior,
                                                 Separador,
                                                 Multi)
            SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CopiarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarRegistroToolStripMenuItem.Click
        SP_CampoComponentes_EDICION_INSERTAR_Copia()
    End Sub
    'Actualizar
    Private Sub SP_CampoComponentes_EDICION_ACTUALIZAR()
        Try
            Me.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CampoComponentes_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(CampoComponenteIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 Cbo_TipoDato.Text,
                                                 PrefijoTextBox.Text,
                                                 SuperiorTextBox.Text,
                                                 SufijoTextBox.Text,
                                                 InferiorTextBox.Text,
                                                 SeparadorCamposTextBox.Text,
                                                 MultiReplaceTextBox.Text)
            SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_CampoComponentes_EDICION_ELIMINAR()
        Try
            Me.SP_CampoComponentes_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CampoComponentes_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(CampoComponenteIDTextBox.Text, Long)))
            SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_CampoComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_CampoComponentes.Click
        Nuevo_Menu_CampoComponentes.Enabled = False
        Editar_Menu_CampoComponentes.Enabled = False
        SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = False
        Limpiar_Objetos_CampoComponentes()
        Cbo_TipoDato.Enabled = True
        Cbo_TipoDato.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_CampoComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_CampoComponentes.Click
        Control_Nulos_CampoComponentes()

        If ControlNulos.Text = "" Then ' Then
            SP_CampoComponentes_EDICION_INSERTAR()
            Cancelar_CampoComponentes()
            Parar_Timer_CampoComponentes()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_CampoComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_CampoComponentes.Click
        Nuevo_Menu_CampoComponentes.Enabled = False
        Guardar_Menu_CampoComponentes.Enabled = False
        Editar_Menu_CampoComponentes.Enabled = False
        Actualizar_Menu_CampoComponentes.Enabled = True
        Eliminar_Menu_CampoComponentes.Enabled = True
        SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = False
        Desbloquear_Objetos_CampoComponentes()
        Timer_Actualizar_CampoComponentes()
        Timer_Eliminar_CampoComponentes()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_CampoComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_CampoComponentes.Click
        Control_Nulos_CampoComponentes()

        If ControlNulos.Text = "" Then ' Then
            SP_CampoComponentes_EDICION_ACTUALIZAR()
            Cancelar_CampoComponentes()
            Parar_Timer_CampoComponentes()
        End If
    End Sub
    Private Sub Eliminar_Menu_CampoComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_CampoComponentes.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_CampoComponentes_EDICION_ELIMINAR()
            Cancelar_CampoComponentes()
            Parar_Timer_CampoComponentes()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_CampoComponentes()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_CampoComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_CampoComponentes.Click
        Cancelar_CampoComponentes()
    End Sub
    'Quitar espacios en blanco    
    Private Sub BtnPrevisualizar_Click(sender As Object, e As EventArgs) Handles BtnPrevisualizar.Click
        TratamientoPorDatoConPSSI()
    End Sub

    Private Sub TratamientoPorDatoConPSSI()
        Dim Campo As String = "CAMPO"
        If MultiReplaceTextBox.Text = "" Then
            'Pone prifijo
            If PrefijoTextBox.Text <> "" Then
                Campo = PrefijoTextBox.Text & Campo
            End If
            'pone sufijo
            If SufijoTextBox.Text <> "" Then
                Campo = Campo & SufijoTextBox.Text
            End If
            'superior
            If SuperiorTextBox.Text <> "" Then
                Campo = SuperiorTextBox.Text & vbCrLf & Campo
            End If
            'inferior
            If InferiorTextBox.Text <> "" Then
                Campo = Campo & vbCrLf & InferiorTextBox.Text
            End If
            MultiReplaceTextBox.Text = ""
            TxtPrevisualizar.Text = Trim(Campo)
        Else
            TxtPrevisualizar.Text = MultiReplaceTextBox.Text.Replace("Campo", Campo)
        End If
    End Sub

#End Region
#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_CampoComponentes()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case PlantillaIDTextBox.Text = ""
                MsgBox("El nombre del campo: PlantillaID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                PlantillaIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Cbo_TipoDato.Text = ""
                MsgBox("El nombre del campo: Tipo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                Cbo_TipoDato.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub Cbo_TipoDato_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbo_TipoDato.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Cbo_TipoDato.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                Cbo_TipoDato.Text = ""
                Cbo_TipoDato.Focus()
            Else
                SeparadorCamposTextBox.Enabled = True
                SeparadorCamposTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub SeparadorCamposTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SeparadorCamposTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            PrefijoTextBox.Enabled = True
            PrefijoTextBox.Focus()
        End If
        If InStr(1, ",;" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub PrefijoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrefijoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SuperiorTextBox.Enabled = True
            SuperiorTextBox.Focus()
        End If
    End Sub
    Private Sub SuperiorTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SuperiorTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SufijoTextBox.Enabled = True
            SufijoTextBox.Focus()
        End If
    End Sub
    Private Sub SufijoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SufijoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            InferiorTextBox.Enabled = True
            InferiorTextBox.Focus()
        End If
    End Sub
    Private Sub InferiorTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InferiorTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            MultiReplaceTextBox.Enabled = True
            MultiReplaceTextBox.Focus()
        End If
    End Sub
    Private Sub MultiReplaceTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MultiReplaceTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_CampoComponentes.Enabled = True Then
                Actualizar_Menu_CampoComponentes.Enabled = True
                Eliminar_Menu_CampoComponentes.Enabled = True
            Else
                MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                Guardar_Menu_CampoComponentes.Enabled = True
                Timer_Guardar_CampoComponentes()
            End If
        End If
    End Sub
    Public Sub Limpiar_Objetos_CampoComponentes()
        Cbo_TipoDato.Text = "" ''
        SeparadorCamposTextBox.Text = "" ''
        PrefijoTextBox.Text = "" ''
        SuperiorTextBox.Text = "" ''
        SufijoTextBox.Text = "" ''
        InferiorTextBox.Text = "" ''
        MultiReplaceTextBox.Text = ""
    End Sub
    Public Sub Desbloquear_Objetos_CampoComponentes()
        Cbo_TipoDato.Enabled = True
        SeparadorCamposTextBox.Enabled = True
        PrefijoTextBox.Enabled = True
        SuperiorTextBox.Enabled = True
        SufijoTextBox.Enabled = True
        InferiorTextBox.Enabled = True
        MultiReplaceTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_CampoComponentes()
        Cbo_TipoDato.Enabled = False
        SeparadorCamposTextBox.Enabled = False
        PrefijoTextBox.Enabled = False
        SuperiorTextBox.Enabled = False
        SufijoTextBox.Enabled = False
        InferiorTextBox.Enabled = False
        MultiReplaceTextBox.Enabled = False
    End Sub
#End Region

#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_CampoComponentes As Timer
    Private WithEvents Timer_Actualizar_Menu_CampoComponentes As Timer
    Private WithEvents Timer_Eliminar_Menu_CampoComponentes As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_CampoComponentes()
        Me.Timer_Guardar_Menu_CampoComponentes = New Timer
        Timer_Guardar_Menu_CampoComponentes.Interval = 250
        Timer_Guardar_Menu_CampoComponentes.Start()
    End Sub
    Private Sub Timer_Actualizar_CampoComponentes()
        Me.Timer_Actualizar_Menu_CampoComponentes = New Timer
        Timer_Actualizar_Menu_CampoComponentes.Interval = 500
        Timer_Actualizar_Menu_CampoComponentes.Start()
    End Sub
    Private Sub Timer_Eliminar_CampoComponentes()
        Me.Timer_Eliminar_Menu_CampoComponentes = New Timer
        Timer_Eliminar_Menu_CampoComponentes.Interval = 800
        Timer_Eliminar_Menu_CampoComponentes.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_CampoComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_CampoComponentes.Tick
        If Guardar_Menu_CampoComponentes.BackColor = Color.White Then
            Guardar_Menu_CampoComponentes.BackColor = Color.Green
        Else
            Guardar_Menu_CampoComponentes.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_CampoComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_CampoComponentes.Tick
        If Actualizar_Menu_CampoComponentes.BackColor = Color.White Then
            Actualizar_Menu_CampoComponentes.BackColor = Color.Green
        Else
            Actualizar_Menu_CampoComponentes.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_CampoComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_CampoComponentes.Tick
        If Eliminar_Menu_CampoComponentes.BackColor = Color.White Then
            Eliminar_Menu_CampoComponentes.BackColor = Color.Red
        Else
            Eliminar_Menu_CampoComponentes.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_CampoComponentes()
        Me.Timer_Guardar_Menu_CampoComponentes = New Timer
        Timer_Guardar_Menu_CampoComponentes.Stop()
        Guardar_Menu_CampoComponentes.BackColor = Color.White
        Me.Timer_Actualizar_Menu_CampoComponentes = New Timer
        Timer_Actualizar_Menu_CampoComponentes.Stop()
        Actualizar_Menu_CampoComponentes.BackColor = Color.White
        Me.Timer_Eliminar_Menu_CampoComponentes = New Timer
        Timer_Eliminar_Menu_CampoComponentes.Stop()
        Eliminar_Menu_CampoComponentes.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_CampoComponentes As Timer
    Dim X_CampoComponentes
    Private Sub Timer_Ubicar_En_Fila_CampoComponentes()
        Me.Timer_Ubicacion_CampoComponentes = New Timer
        Timer_Ubicacion_CampoComponentes.Interval = 100
        Timer_Ubicacion_CampoComponentes.Start()
    End Sub
    Private Sub SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CellMouseClick
        X_CampoComponentes = SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentRow.Index
    End Sub

    Private Sub Ubicar_En_Fila_CampoComponentes()
        Try
            Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows(X_CampoComponentes).Selected = True
            Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.FirstDisplayedScrollingRowIndex = X_CampoComponentes
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_CampoComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_CampoComponentes.Tick
        Ubicar_En_Fila_CampoComponentes()
        Timer_Ubicacion_CampoComponentes.Stop()
    End Sub

    Private Sub BtnImprimeCampos_Click(sender As Object, e As EventArgs) Handles BtnImprimeCampos.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{Campos}}}")
    End Sub

    Private Sub BtnImprimeTabla_Click(sender As Object, e As EventArgs) Handles BtnImprimeTabla.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{Tabla}}}")
    End Sub

    Private Sub BtnImprimeClavePrincipal_Click(sender As Object, e As EventArgs) Handles BtnImprimeClavePrincipal.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{Clave}}}")
    End Sub

    Private Sub BtnTablaMinuscula_Click(sender As Object, e As EventArgs) Handles BtnTablaMinuscula.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{Tmin}}}")
    End Sub
    Private Sub BtnTablaPlural_Click(sender As Object, e As EventArgs) Handles BtnTablaPlural.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{TPlur}}}")
    End Sub

    Private Sub BtnTablaPluralMinuscula_Click(sender As Object, e As EventArgs) Handles BtnTablaPluralMinuscula.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{TPlurMin}}}")
    End Sub
    Private Sub BtnCamposRelacionados_Click(sender As Object, e As EventArgs) Handles BtnCamposRelacionados.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{Camp-Rel}}}")
    End Sub
    Private Sub BtnTodasLasTablas_Click(sender As Object, e As EventArgs) Handles BtnTodasLasTablas.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{Tbl-Camel}}}")
    End Sub

    Private Sub SP_CARGA_CONVENSIONES_USADASDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_CARGA_CONVENSIONES_USADASDataGridView.CellMouseDoubleClick
        If Editar_Menu_RequerimientosPlantillas.Enabled = False Then
            RequerimientoTextBox.Text = CONVENSIONESTextBox.Text
            OrdenDePeticionTextBox.Enabled = True
            OrdenDePeticionTextBox.Focus()
        End If
    End Sub
    Private Sub SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.CellMouseDoubleClick
        If Editar_Menu_RequerimientosPlantillas.Enabled = False Then
            RequerimientoTextBox.Text = RequerimientoTextBox1.Text
            OrdenDePeticionTextBox.Enabled = True
            OrdenDePeticionTextBox.Focus()
        End If
    End Sub
    Private Sub BtnMayusculaAMinuscula_Click(sender As Object, e As EventArgs) Handles BtnMayusculaAMinuscula.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{A=>-a}}}")
    End Sub

    Private Sub BtnTD_Click(sender As Object, e As EventArgs) Handles BtnTD.Click
        Me.ContenidoRelacionTextBox.Text = Me.ContenidoRelacionTextBox.Text.Insert(Me.ContenidoRelacionTextBox.SelectionStart, "{{{Tabla_Dep}}}")
    End Sub

    Private Sub BtnCTD_Click(sender As Object, e As EventArgs) Handles BtnCTD.Click
        Me.ContenidoRelacionTextBox.Text = Me.ContenidoRelacionTextBox.Text.Insert(Me.ContenidoRelacionTextBox.SelectionStart, "{{{Campo_Dep}}}")
    End Sub

    Private Sub BtnTI_Click(sender As Object, e As EventArgs) Handles BtnTI.Click
        Me.ContenidoRelacionTextBox.Text = Me.ContenidoRelacionTextBox.Text.Insert(Me.ContenidoRelacionTextBox.SelectionStart, "{{{Tabla_Ind}}}")
    End Sub

    Private Sub BtnCTI_Click(sender As Object, e As EventArgs) Handles BtnCTI.Click
        Me.ContenidoRelacionTextBox.Text = Me.ContenidoRelacionTextBox.Text.Insert(Me.ContenidoRelacionTextBox.SelectionStart, "{{{Campo_Ind}}}")
    End Sub

    Private Sub BtnIzquierda_Click(sender As Object, e As EventArgs) Handles BtnIzquierda.Click
        Me.RichTextboxRichTextBox.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub BtnCentrar_Click(sender As Object, e As EventArgs) Handles BtnCentrar.Click
        Me.RichTextboxRichTextBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub BtnDerecha_Click(sender As Object, e As EventArgs) Handles BtnDerecha.Click
        Me.RichTextboxRichTextBox.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub BtnFuentes_Click(sender As Object, e As EventArgs) Handles BtnFuentes.Click
        Dim f As New FontDialog
        f.ShowDialog()
        Me.RichTextboxRichTextBox.SelectionFont = f.Font
    End Sub

    Private Sub BtnColor_Click(sender As Object, e As EventArgs) Handles BtnColor.Click
        Dim c As New ColorDialog
        c.ShowDialog()
        Me.RichTextboxRichTextBox.SelectionColor = c.Color
    End Sub



    Dim table As New DataTable
    Dim rowIndex As Integer
    Private Sub ChkMover_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMover.CheckedChanged
        If ChkMover.Checked = True Then
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Enabled = False
            DGVEdicionPosicion.Visible = True
            CargarGridEdicion()
            BtnSubirFila.Enabled = True
            BtnBajarFila.Enabled = True
            Nuevo_Menu_Plantillas.Enabled = False
            Editar_Menu_Plantillas.Enabled = False
            Cancelar_Menu_Plantillas.Enabled = False
        Else
            ActualizarItems2()
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Enabled = True
            DGVEdicionPosicion.Visible = False
            CargarGridEdicion()
            BtnSubirFila.Enabled = False
            BtnBajarFila.Enabled = False
            Nuevo_Menu_Plantillas.Enabled = True
            Editar_Menu_Plantillas.Enabled = True
            Cancelar_Menu_Plantillas.Enabled = True
        End If
    End Sub

    Private Sub ActualizarItems2()

        'Define Variables de Control
        Dim contadorfinal As Integer = DGVEdicionPosicion.Rows.Count

        Dim contadorInicial As Integer = 1
        While contadorfinal >= contadorInicial
            'Se ubica en la primera fila
            DGVEdicionPosicion.CurrentCell = DGVEdicionPosicion.Rows(0).Cells(0)
            Try
                ActualizarItem(Convert.ToString(DGVEdicionPosicion.CurrentRow.Cells(2).Value), DGVEdicionPosicion.CurrentRow.Cells(1).Value, contadorInicial)
            Catch ex As System.Exception
                'System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            DGVEdicionPosicion.Rows.RemoveAt(0)
            contadorInicial = contadorInicial + 1
        End While
        Cancelar_Plantillas()
    End Sub

    Private Sub ActualizarItem(PlantillaID As Integer, Nombre As String, item As Integer)
        Try
            PlantillaIDTextBox.Text = PlantillaID
            NombrePlantillaTextBox.Text = Nombre
            OrdenTextBox.Text = item
            Me.SP_Plantillas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)),
                                                 NombrePlantillaTextBox.Text,
                                                 New System.Nullable(Of Integer)(CType(OrdenTextBox.Text, Integer)))
            'Crear un metodo que actualize solo el dato de la plantilla
            'Me.SP_T_03_01_PlantillasDeProyecto_EDICION_ACTUALIZAR_Por_ItemTableAdapter.Fill(Me.DS_Plantilla.SP_T_03_01_PlantillasDeProyecto_EDICION_ACTUALIZAR_Por_Item,
            '                                                                                New System.Nullable(Of Long)(CType(T_01_02_TiposDeProyectosIDTextBox.Text, Long)),
            '                                                                                New System.Nullable(Of Long)(CType(IDPlantilla, Long)),
            '                                                                                New System.Nullable(Of Long)(CType(item, Long)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CargarGridEdicion()
        CargarGridSeleccion()
        With DGVEdicionPosicion
            For Each columna As DataGridViewColumn In .Columns
                'Ajustado
                'columna.MinimumWidth = Int((.Width - .RowHeadersWidth) / .ColumnCount)
                'columna.Width = Int((.Width - .RowHeadersWidth) / .ColumnCount)
                DGVEdicionPosicion.RowHeadersVisible = False
                DGVEdicionPosicion.Columns(0).Width = 30
                DGVEdicionPosicion.Columns(1).Width = 319
            Next
        End With
        DGVEdicionPosicion.AllowUserToAddRows = False
        DGVEdicionPosicion.ColumnHeadersVisible = False
    End Sub

    Private Sub CargarGridSeleccion()

        Try
            ' Obtenemos un objeto DataTable con los datos
            ' existentes en el control DataGridView.
            '
            table = Me.DataGridViewToDataTable(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView)

            'MessageBox.Show(String.Format("Nº de filas añadidas: {0}", table.Rows.Count))

            DGVEdicionPosicion.DataSource = table

        Catch ex As Exception
            ' Se ha producido un error.
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Function DataGridViewToDataTable(dgv As DataGridView) As DataTable

        ' Si no es válido el control DataGridView,
        ' devolvemos el valor Nothing.
        '
        If (dgv Is Nothing) Then Return Nothing

        ' Creamos un nuevo objeto DataTable.
        '
        Dim dt As New DataTable()

        ' Conforme recorremos las columnas existentes
        ' en el control DataGridView, vamos creando
        ' nuevas columnas en el objeto DataTable.
        '
        For Each col As DataGridViewColumn In dgv.Columns
            Dim column As New DataColumn(col.Name, Type.GetType("System.String"))
            dt.Columns.Add(column)
        Next

        ' Una vez creada la estructura del objeto DataTable,
        ' recorremos las filas del control DataGridView para
        ' rellenar de datos el objeto DataTable.
        '
        For Each viewRow As DataGridViewRow In dgv.Rows

            ' Creamos una nueva fila en el objeto DataTable;
            ' un objeto DataRow.
            '
            Dim row As DataRow = dt.NewRow()

            For Each col As DataGridViewColumn In dgv.Columns

                ' Valor de la celda actual del control DataGridView1.
                '
                Dim value As Object = viewRow.Cells(col.Name).Value

                ' Si el valor es Nothing, le asignamos un valor NULL a la
                ' columna del objeto DataTable; en caso contrario le asignamos
                ' el valor de la celda del control DataGridView.
                '
                row.Item(col.Name) = If(value Is Nothing, DBNull.Value, value)

            Next col        ' Siguiente columna

            ' Añadimos la fila al objeto DataTable.
            '
            dt.Rows.Add(row)

        Next viewRow ' Siguiente fila

        ' Por último devolvemos el objeto DataTable creado.
        '
        Return dt

    End Function

    Private Sub BtnSubirFila_Click(sender As Object, e As EventArgs) Handles BtnSubirFila.Click
        Try
            rowIndex = DGVEdicionPosicion.SelectedCells(0).OwningRow.Index
            Dim row As DataRow
            row = table.NewRow()

            row(0) = Integer.Parse(DGVEdicionPosicion.Rows(rowIndex).Cells(0).Value.ToString())
            row(1) = DGVEdicionPosicion.Rows(rowIndex).Cells(1).Value.ToString()
            row(2) = Integer.Parse(DGVEdicionPosicion.Rows(rowIndex).Cells(2).Value.ToString())

            'row(2) = DataGridView1.Rows(rowIndex).Cells(2).Value.ToString()
            'row(3) = Integer.Parse(DataGridView1.Rows(rowIndex).Cells(3).Value.ToString())

            If rowIndex > 0 Then
                table.Rows.RemoveAt(rowIndex)

                table.Rows.InsertAt(row, rowIndex - 1)
                DGVEdicionPosicion.ClearSelection()

                DGVEdicionPosicion.Rows(rowIndex - 1).Selected = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnBajarFila_Click(sender As Object, e As EventArgs) Handles BtnBajarFila.Click
        Try
            rowIndex = DGVEdicionPosicion.SelectedCells(0).OwningRow.Index
            Dim row As DataRow
            row = table.NewRow()

            row(0) = Integer.Parse(DGVEdicionPosicion.Rows(rowIndex).Cells(0).Value.ToString())
            row(1) = DGVEdicionPosicion.Rows(rowIndex).Cells(1).Value.ToString()
            row(2) = Integer.Parse(DGVEdicionPosicion.Rows(rowIndex).Cells(2).Value.ToString())
            If rowIndex < DGVEdicionPosicion.Rows.Count Then
                table.Rows.RemoveAt(rowIndex)

                table.Rows.InsertAt(row, rowIndex + 1)
                DGVEdicionPosicion.ClearSelection()

                DGVEdicionPosicion.Rows(rowIndex + 1).Selected = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGVEdicionPosicion_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVEdicionPosicion.CellMouseClick

    End Sub



#End Region
#Region "Campos Requeridos"
#Region "Procedimientos"
    Private Sub SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region
    Sub Cancelar_TablasRelacionadas()
        'Botones Del Menu
        Nuevo_Menu_TablasRelacionadas.Enabled = True
        Guardar_Menu_TablasRelacionadas.Enabled = False
        Editar_Menu_TablasRelacionadas.Enabled = True
        Actualizar_Menu_TablasRelacionadas.Enabled = False
        Eliminar_Menu_TablasRelacionadas.Enabled = False
        'Grid
        SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Bloquear_Objetos_TablasRelacionadas()
        Parar_Timer_TablasRelacionadas()
        Timer_Ubicar_En_Fila_TablasRelacionadas()
    End Sub
    'Insertar
    Private Sub SP_TablasRelacionadas_EDICION_INSERTAR()
        Try
            Me.SP_TablasRelacionadas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasRelacionadas_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 ContenidoRelacionTextBox.Text)
            SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub SP_TablasRelacionadas_EDICION_ACTUALIZAR()
        Try
            Me.SP_TablasRelacionadas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasRelacionadas_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(RelacionTablasIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 ContenidoRelacionTextBox.Text)
            SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_TablasRelacionadas_EDICION_ELIMINAR()
        Try
            Me.SP_TablasRelacionadas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasRelacionadas_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(RelacionTablasIDTextBox.Text, Long)))
            SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_TablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_TablasRelacionadas.Click
        Nuevo_Menu_TablasRelacionadas.Enabled = False
        Editar_Menu_TablasRelacionadas.Enabled = False
        SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = False
        Limpiar_Objetos_TablasRelacionadas()
        ContenidoRelacionTextBox.Enabled = True
        ContenidoRelacionTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_TablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_TablasRelacionadas.Click
        Control_Nulos_TablasRelacionadas()

        If ControlNulos.Text = "" Then ' Then
            SP_TablasRelacionadas_EDICION_INSERTAR()
            Cancelar_TablasRelacionadas()
            Parar_Timer_TablasRelacionadas()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_TablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_TablasRelacionadas.Click
        Nuevo_Menu_TablasRelacionadas.Enabled = False
        Guardar_Menu_TablasRelacionadas.Enabled = False
        Editar_Menu_TablasRelacionadas.Enabled = False
        Actualizar_Menu_TablasRelacionadas.Enabled = True
        Eliminar_Menu_TablasRelacionadas.Enabled = True
        SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Enabled = False
        Desbloquear_Objetos_TablasRelacionadas()
        Timer_Actualizar_TablasRelacionadas()
        Timer_Eliminar_TablasRelacionadas()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_TablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_TablasRelacionadas.Click
        Control_Nulos_TablasRelacionadas()

        If ControlNulos.Text = "" Then ' Then
            SP_TablasRelacionadas_EDICION_ACTUALIZAR()
            Cancelar_TablasRelacionadas()
            Parar_Timer_TablasRelacionadas()
        End If
    End Sub
    Private Sub Eliminar_Menu_TablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_TablasRelacionadas.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_TablasRelacionadas_EDICION_ELIMINAR()
            Cancelar_TablasRelacionadas()
            Parar_Timer_TablasRelacionadas()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_TablasRelacionadas()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_TablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_TablasRelacionadas.Click
        Cancelar_TablasRelacionadas()
    End Sub
#End Region
#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_TablasRelacionadas()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case PlantillaIDTextBox.Text = ""
                MsgBox("El nombre del campo: PlantillaID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                PlantillaIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case ContenidoRelacionTextBox.Text = ""
                MsgBox("El nombre del campo: ContenidoRelacion; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ContenidoRelacionTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub ContenidoRelacionTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContenidoRelacionTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_TablasRelacionadas.Enabled = True Then
                Actualizar_Menu_TablasRelacionadas.Enabled = True
                Eliminar_Menu_TablasRelacionadas.Enabled = True
            Else
                If ContenidoRelacionTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    ContenidoRelacionTextBox.Text = ""
                    ContenidoRelacionTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_TablasRelacionadas.Enabled = True
                    Timer_Guardar_TablasRelacionadas()
                End If
            End If
        End If
    End Sub
    Public Sub Limpiar_Objetos_TablasRelacionadas()
        ContenidoRelacionTextBox.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_TablasRelacionadas()
        ContenidoRelacionTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_TablasRelacionadas()
        ContenidoRelacionTextBox.Enabled = False
    End Sub

#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_TablasRelacionadas As Timer
    Private WithEvents Timer_Actualizar_Menu_TablasRelacionadas As Timer
    Private WithEvents Timer_Eliminar_Menu_TablasRelacionadas As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_TablasRelacionadas()
        Me.Timer_Guardar_Menu_TablasRelacionadas = New Timer
        Timer_Guardar_Menu_TablasRelacionadas.Interval = 250
        Timer_Guardar_Menu_TablasRelacionadas.Start()
    End Sub
    Private Sub Timer_Actualizar_TablasRelacionadas()
        Me.Timer_Actualizar_Menu_TablasRelacionadas = New Timer
        Timer_Actualizar_Menu_TablasRelacionadas.Interval = 500
        Timer_Actualizar_Menu_TablasRelacionadas.Start()
    End Sub
    Private Sub Timer_Eliminar_TablasRelacionadas()
        Me.Timer_Eliminar_Menu_TablasRelacionadas = New Timer
        Timer_Eliminar_Menu_TablasRelacionadas.Interval = 800
        Timer_Eliminar_Menu_TablasRelacionadas.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_TablasRelacionadas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_TablasRelacionadas.Tick
        If Guardar_Menu_TablasRelacionadas.BackColor = Color.White Then
            Guardar_Menu_TablasRelacionadas.BackColor = Color.Green
        Else
            Guardar_Menu_TablasRelacionadas.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_TablasRelacionadas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_TablasRelacionadas.Tick
        If Actualizar_Menu_TablasRelacionadas.BackColor = Color.White Then
            Actualizar_Menu_TablasRelacionadas.BackColor = Color.Green
        Else
            Actualizar_Menu_TablasRelacionadas.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_TablasRelacionadas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_TablasRelacionadas.Tick
        If Eliminar_Menu_TablasRelacionadas.BackColor = Color.White Then
            Eliminar_Menu_TablasRelacionadas.BackColor = Color.Red
        Else
            Eliminar_Menu_TablasRelacionadas.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_TablasRelacionadas()
        Me.Timer_Guardar_Menu_TablasRelacionadas = New Timer
        Timer_Guardar_Menu_TablasRelacionadas.Stop()
        Guardar_Menu_TablasRelacionadas.BackColor = Color.White
        Me.Timer_Actualizar_Menu_TablasRelacionadas = New Timer
        Timer_Actualizar_Menu_TablasRelacionadas.Stop()
        Actualizar_Menu_TablasRelacionadas.BackColor = Color.White
        Me.Timer_Eliminar_Menu_TablasRelacionadas = New Timer
        Timer_Eliminar_Menu_TablasRelacionadas.Stop()
        Eliminar_Menu_TablasRelacionadas.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_TablasRelacionadas As Timer
    Dim X_TablasRelacionadas
    Private Sub Timer_Ubicar_En_Fila_TablasRelacionadas()
        Me.Timer_Ubicacion_TablasRelacionadas = New Timer
        Timer_Ubicacion_TablasRelacionadas.Interval = 100
        Timer_Ubicacion_TablasRelacionadas.Start()
    End Sub
    Private Sub SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CellMouseClick
        X_TablasRelacionadas = SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_TablasRelacionadas()
        Try
            Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows(X_TablasRelacionadas).Selected = True
            Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.FirstDisplayedScrollingRowIndex = X_TablasRelacionadas
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_TablasRelacionadas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_TablasRelacionadas.Tick
        Ubicar_En_Fila_TablasRelacionadas()
        Timer_Ubicacion_TablasRelacionadas.Stop()
    End Sub

    Private Sub TxtPrevisualizar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtPrevisualizar.MouseDoubleClick
        If TxtPrevisualizar.Dock = DockStyle.None Then
            TxtPrevisualizar.Dock = DockStyle.Fill
        Else
            TxtPrevisualizar.Dock = DockStyle.None
        End If
    End Sub

    Private Sub MultiReplaceTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MultiReplaceTextBox.MouseDoubleClick
        If MultiReplaceTextBox.Dock = DockStyle.None Then
            MultiReplaceTextBox.Dock = DockStyle.Fill
        Else
            MultiReplaceTextBox.Dock = DockStyle.None
        End If
    End Sub
#End Region
#End Region
#Region "Texto Enriquecido"
    Private Sub SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
        Try
            Me.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID, New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)))
            RichTextboxRichTextBox.Rtf = RichTextboxRichTextBox.Text
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComponenteIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ComponenteIDTextBox.TextChanged
        SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
    End Sub

#Region "Procedimientos"
    Sub Cancelar_TextoEnriquecido()
        Try
            'Botones Del Menu
            Nuevo_Menu_TextoEnriquecido.Enabled = True
            Guardar_Menu_TextoEnriquecido.Enabled = False
            Editar_Menu_TextoEnriquecido.Enabled = True
            Actualizar_Menu_TextoEnriquecido.Enabled = False
            Eliminar_Menu_TextoEnriquecido.Enabled = False
            'Grid
            'SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDDataGridView.Enabled = True
            'Cargar Datos de Tabla Actualizados
            SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
            Bloquear_Objetos_TextoEnriquecido()
            Parar_Timer_TextoEnriquecido()
            RichTextboxRichTextBox.Rtf = RichTextboxRichTextBox.Text
        Catch ex As Exception

        End Try
    End Sub
    'Insertar
    Private Sub SP_TextoEnriquecido_EDICION_INSERTAR()
        Try
            Me.SP_TextoEnriquecido_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TextoEnriquecido_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)),
                                                 RichTextboxRichTextBox.Rtf)
            SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub SP_TextoEnriquecido_EDICION_ACTUALIZAR()
        Try
            Me.SP_TextoEnriquecido_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TextoEnriquecido_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(TextoEnriquecidoIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)),
                                                 RichTextboxRichTextBox.Rtf)
            SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_TextoEnriquecido_EDICION_ACTUALIZAR_Rapida()
        Try
            Me.SP_TextoEnriquecido_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TextoEnriquecido_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(TextoEnriquecidoIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)),
                                                 RichTextboxRichTextBox.Rtf)
            SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_TextoEnriquecido_EDICION_ELIMINAR()
        Try
            Me.SP_TextoEnriquecido_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TextoEnriquecido_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(TextoEnriquecidoIDTextBox.Text, Long)))
            SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_TextoEnriquecido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_TextoEnriquecido.Click
        Nuevo_Menu_TextoEnriquecido.Enabled = False
        Editar_Menu_TextoEnriquecido.Enabled = False
        Limpiar_Objetos_TextoEnriquecido()
        RichTextboxRichTextBox.Enabled = True
        RichTextboxRichTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_TextoEnriquecido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_TextoEnriquecido.Click
        Control_Nulos_TextoEnriquecido()

        If ControlNulos.Text = "" Then ' Then
            SP_TextoEnriquecido_EDICION_INSERTAR()
            Cancelar_TextoEnriquecido()
            Parar_Timer_TextoEnriquecido()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_TextoEnriquecido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_TextoEnriquecido.Click
        Nuevo_Menu_TextoEnriquecido.Enabled = False
        Guardar_Menu_TextoEnriquecido.Enabled = False
        Editar_Menu_TextoEnriquecido.Enabled = False
        Actualizar_Menu_TextoEnriquecido.Enabled = True
        Eliminar_Menu_TextoEnriquecido.Enabled = True
        Desbloquear_Objetos_TextoEnriquecido()
        Timer_Actualizar_TextoEnriquecido()
        Timer_Eliminar_TextoEnriquecido()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_TextoEnriquecido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_TextoEnriquecido.Click
        Control_Nulos_TextoEnriquecido()

        If ControlNulos.Text = "" Then ' Then
            SP_TextoEnriquecido_EDICION_ACTUALIZAR()
            Cancelar_TextoEnriquecido()
            Parar_Timer_TextoEnriquecido()
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        SP_TextoEnriquecido_EDICION_ACTUALIZAR_Rapida()
    End Sub
    Private Sub Eliminar_Menu_TextoEnriquecido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_TextoEnriquecido.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_TextoEnriquecido_EDICION_ELIMINAR()
            Cancelar_TextoEnriquecido()
            Parar_Timer_TextoEnriquecido()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_TextoEnriquecido()
        End If
    End Sub
#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_TextoEnriquecido()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case PlantillaIDTextBox.Text = ""
                MsgBox("El nombre del campo: PlantillasID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                PlantillaIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case ComponenteIDTextBox.Text = ""
                MsgBox("El nombre del campo: ComponenteID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ComponenteIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case RichTextboxRichTextBox.Text = ""
                MsgBox("El nombre del campo: RichTextbox; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                RichTextboxRichTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    Private Sub RichTextboxTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextboxRichTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_TextoEnriquecido.Enabled = True Then
                Actualizar_Menu_TextoEnriquecido.Enabled = True
                Eliminar_Menu_TextoEnriquecido.Enabled = True
            Else
                If RichTextboxRichTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    RichTextboxRichTextBox.Text = ""
                    RichTextboxRichTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_TextoEnriquecido.Enabled = True
                    Timer_Guardar_TextoEnriquecido()
                End If
            End If
        End If
    End Sub
    Public Sub Limpiar_Objetos_TextoEnriquecido()
        RichTextboxRichTextBox.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_TextoEnriquecido()
        RichTextboxRichTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_TextoEnriquecido()
        'RichTextboxRichTextBox.Enabled = False
    End Sub
#End Region
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_TextoEnriquecido As Timer
    Private WithEvents Timer_Actualizar_Menu_TextoEnriquecido As Timer
    Private WithEvents Timer_Eliminar_Menu_TextoEnriquecido As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_TextoEnriquecido()
        Me.Timer_Guardar_Menu_TextoEnriquecido = New Timer
        Timer_Guardar_Menu_TextoEnriquecido.Interval = 250
        Timer_Guardar_Menu_TextoEnriquecido.Start()
    End Sub
    Private Sub Timer_Actualizar_TextoEnriquecido()
        Me.Timer_Actualizar_Menu_TextoEnriquecido = New Timer
        Timer_Actualizar_Menu_TextoEnriquecido.Interval = 500
        Timer_Actualizar_Menu_TextoEnriquecido.Start()
    End Sub
    Private Sub Timer_Eliminar_TextoEnriquecido()
        Me.Timer_Eliminar_Menu_TextoEnriquecido = New Timer
        Timer_Eliminar_Menu_TextoEnriquecido.Interval = 800
        Timer_Eliminar_Menu_TextoEnriquecido.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_TextoEnriquecido_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_TextoEnriquecido.Tick
        If Guardar_Menu_TextoEnriquecido.BackColor = Color.White Then
            Guardar_Menu_TextoEnriquecido.BackColor = Color.Green
        Else
            Guardar_Menu_TextoEnriquecido.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_TextoEnriquecido_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_TextoEnriquecido.Tick
        If Actualizar_Menu_TextoEnriquecido.BackColor = Color.White Then
            Actualizar_Menu_TextoEnriquecido.BackColor = Color.Green
        Else
            Actualizar_Menu_TextoEnriquecido.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_TextoEnriquecido_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_TextoEnriquecido.Tick
        If Eliminar_Menu_TextoEnriquecido.BackColor = Color.White Then
            Eliminar_Menu_TextoEnriquecido.BackColor = Color.Red
        Else
            Eliminar_Menu_TextoEnriquecido.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_TextoEnriquecido()
        Me.Timer_Guardar_Menu_TextoEnriquecido = New Timer
        Timer_Guardar_Menu_TextoEnriquecido.Stop()
        Guardar_Menu_TextoEnriquecido.BackColor = Color.White
        Me.Timer_Actualizar_Menu_TextoEnriquecido = New Timer
        Timer_Actualizar_Menu_TextoEnriquecido.Stop()
        Actualizar_Menu_TextoEnriquecido.BackColor = Color.White
        Me.Timer_Eliminar_Menu_TextoEnriquecido = New Timer
        Timer_Eliminar_Menu_TextoEnriquecido.Stop()
        Eliminar_Menu_TextoEnriquecido.BackColor = Color.White
    End Sub

    Private Sub Cancelar_Menu_TextoEnriquecido_Click(sender As Object, e As EventArgs) Handles Cancelar_Menu_TextoEnriquecido.Click
        Cancelar_TextoEnriquecido()
    End Sub
    'Convierte el rtf en text cuando se selecciona el tap
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage5 Then
            Try
                RichTextboxRichTextBox.Rtf = RichTextboxRichTextBox.Text
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub TextoEnriquecidoIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles TextoEnriquecidoIDTextBox.TextChanged
        Try
            RichTextboxRichTextBox.Rtf = RichTextboxRichTextBox.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLA()
        Try
            Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLATableAdapter.Fill(Me.DataSetTablasYCampos.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLA, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RB_Plantilla_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Plantilla.CheckedChanged
        SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.Visible = True
        SP_CARGA_CONVENSIONES_USADASDataGridView.Visible = False
    End Sub

    Private Sub RB_Todas_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Todas.CheckedChanged
        SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.Visible = False
        SP_CARGA_CONVENSIONES_USADASDataGridView.Visible = True
    End Sub

    Private Sub EnunciadoRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles EnunciadoRichTextBox.MouseDoubleClick
        If EnunciadoRichTextBox.Dock = DockStyle.None Then
            EnunciadoRichTextBox.Dock = DockStyle.Fill
            EnunciadoRichTextBox.BringToFront()
        Else
            EnunciadoRichTextBox.Dock = DockStyle.None
        End If
    End Sub

    Private Sub TecnologiasDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TecnologiasDataGridView.CellMouseDoubleClick
        If TecnologiasDataGridView.Dock = DockStyle.None Then
            TecnologiasDataGridView.Dock = DockStyle.Fill
            TecnologiasDataGridView.BringToFront()
        Else
            TecnologiasDataGridView.Dock = DockStyle.None
        End If
    End Sub






















#End Region
#End Region
#End Region

End Class