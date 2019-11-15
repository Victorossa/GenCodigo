Public Class FrmTecnologias
    Private Sub FrmTecnologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
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
                                                 NombreTecnologiaTextBox.Text)

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
                                                 NombreTecnologiaTextBox.Text)

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
                                                 NombrePlantillaTextBox.Text)
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
                                                 NombrePlantillaTextBox.Text)
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
            If Actualizar_Menu_Plantillas.Enabled = True Then
                Actualizar_Menu_Plantillas.Enabled = True
                Eliminar_Menu_Plantillas.Enabled = True
            Else
                If NombrePlantillaTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    NombrePlantillaTextBox.Text = ""
                    NombrePlantillaTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_Plantillas.Enabled = True
                    Timer_Guardar_Plantillas()
                End If
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


    Public Sub Limpiar_Objetos_Plantillas()
        NombrePlantillaTextBox.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_Plantillas()
        NombrePlantillaTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_Plantillas()
        NombrePlantillaTextBox.Enabled = False
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
        SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
    End Sub

    Private Sub SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
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
    End Sub
    'Insertar
    Private Sub SP_Componentes_EDICION_INSERTAR()
        Try
            Me.SP_Componentes_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 NombreComponenteTextBox.Text,
                                                 ContenidoComponenteRichTextBox.Text)
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
                                                 ContenidoComponenteRichTextBox.Text)
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
                ContenidoComponenteRichTextBox.Enabled = True
                ContenidoComponenteRichTextBox.Focus()
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
    Public Sub Limpiar_Objetos_Componentes()
        NombreComponenteTextBox.Text = "" ''
        ContenidoComponenteRichTextBox.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_Componentes()
        NombreComponenteTextBox.Enabled = True
        ContenidoComponenteRichTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_Componentes()
        NombreComponenteTextBox.Enabled = False
        'ContenidoComponenteRichTextBox.Enabled = False
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
        X_Componentes = SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentRow.Index
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
                                                 EnunciadoTextBox.Text,
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
                                                 EnunciadoTextBox.Text,
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
        EnunciadoTextBox.Enabled = True
        EnunciadoTextBox.Focus()
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
            Case EnunciadoTextBox.Text = ""
                MsgBox("El nombre del campo: Enunciado; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                EnunciadoTextBox.BackColor = Color.Beige
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
    Private Sub EnunciadoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EnunciadoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If EnunciadoTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                EnunciadoTextBox.Text = ""
                EnunciadoTextBox.Focus()
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
        EnunciadoTextBox.Text = "" ''
        RequerimientoTextBox.Text = "" ''
        OrdenDePeticionTextBox.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_RequerimientosPlantillas()
        EnunciadoTextBox.Enabled = True
        RequerimientoTextBox.Enabled = True
        OrdenDePeticionTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_RequerimientosPlantillas()
        EnunciadoTextBox.Enabled = False
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
                                                 ContenidoComponenteRichTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnRemplazar_Click(sender As Object, e As EventArgs) Handles BtnRemplazar.Click
        ContenidoComponenteRichTextBox.Text = RemplazarTexto(TxtBuscado.Text, TxtRemplazarPor.Text, ContenidoComponenteRichTextBox.Text)
    End Sub

    Shared Function RemplazarTexto(TextoBuscado As String, TextoParaRemplazo As String, TextoBase As String) As String
        TextoParaRemplazo = TextoParaRemplazo.Replace(" "c, String.Empty)
        Dim resultado As String = TextoBase.Replace(TextoBuscado, TextoParaRemplazo)
        Return resultado
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
        If MsgBox("Desea Actualizar este codigo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_Componentes_EDICION_ACTUALIZAR_SoloCodigo()
            MsgBox("Se actualizo la plantilla", MsgBoxStyle.Information)
        Else
            MsgBox("Se Cancelo la Instrucción", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub TipoCampoIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoCampoIDTextBox.TextChanged

    End Sub

    Private Sub GrupoTiposIDLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GrupoTiposIDTextBox2_TextChanged(sender As Object, e As EventArgs) Handles GrupoTiposIDTextBox2.TextChanged

    End Sub

    Private Sub NombreGrupoTipoDeDatoLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NombreGrupoTipoDeDatoTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NombreGrupoTipoDeDatoTextBox1.TextChanged

    End Sub

    Private Sub GrupoTiposIDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GrupoTiposIDTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GrupoTiposIDTextBox1.TextChanged

    End Sub

    Private Sub GrupoTiposIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles GrupoTiposIDTextBox.TextChanged

    End Sub

    Private Sub RequerimientoPlantillaIDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RequerimientoPlantillaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles RequerimientoPlantillaIDTextBox.TextChanged

    End Sub

    Private Sub ComponenteIDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComponenteIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ComponenteIDTextBox.TextChanged

    End Sub

    Private Sub PlantillaIDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ControlNulos_TextChanged(sender As Object, e As EventArgs) Handles ControlNulos.TextChanged

    End Sub



    Private Sub TipoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoTextBox.TextChanged
        Cbo_TipoDato.Text = TipoTextBox.Text
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


#End Region


End Class