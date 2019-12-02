Public Class FrmPlantillas
#Region "Tecnologias"
    Private Sub FrmPlantillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.TecnologiasTableAdapter.Fill(Me.DataSetPlantillas.Tecnologias)
            Cancelar_Tecnologias()
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
            Cancelar_Plantillas()
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            Cancelar_Componentes()
            'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            'Cancelar_RequerimientosPlantillas()
            'SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            'Cancelar_CampoComponentes()
            'Me.SP_CARGA_CONVENSIONES_USADASTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CARGA_CONVENSIONES_USADAS)
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
        Me.TecnologiasTableAdapter.Fill(Me.DataSetPlantillas.Tecnologias)
        Bloquear_Objetos_Tecnologias()
        Parar_Timer_Tecnologias()
        Timer_Ubicar_En_Fila_Tecnologias()
    End Sub
    'Insertar
    Private Sub SP_Tecnologias_EDICION_INSERTAR()
        Try
            Me.SP_Tecnologias_EDICION_INSERTARTableAdapter.Fill(Me.DataSetPlantillas.SP_Tecnologias_EDICION_INSERTAR,
                                                 NombreTecnologiaTextBox.Text)

            Me.TecnologiasTableAdapter.Fill(Me.DataSetPlantillas.Tecnologias)
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    'Actualizar
    Private Sub SP_Tecnologias_EDICION_ACTUALIZAR()
        Try
            Me.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetPlantillas.SP_Tecnologias_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)),
                                                 NombreTecnologiaTextBox.Text)

            Me.TecnologiasTableAdapter.Fill(Me.DataSetPlantillas.Tecnologias)
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    'Eliminar
    Private Sub SP_Tecnologias_EDICION_ELIMINAR()
        Try
            Me.SP_Tecnologias_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetPlantillas.SP_Tecnologias_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(TecnologiaIDTextBox.Text, Long)))
            Me.TecnologiasTableAdapter.Fill(Me.DataSetPlantillas.Tecnologias)
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
            Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.Fill(Me.DataSetPlantillas.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia, New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TecnologiaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles TecnologiaIDTextBox.TextChanged
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
    End Sub

#End Region
#End Region

#Region "Plantilla"
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
            Me.SP_Plantillas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetPlantillas.SP_Plantillas_EDICION_INSERTAR,
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
            Me.SP_Plantillas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetPlantillas.SP_Plantillas_EDICION_ACTUALIZAR,
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
            Me.SP_Plantillas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetPlantillas.SP_Plantillas_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(PlantillaIDTextBox.Text, Long)))

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
            'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            'SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            ContenidoComponenteRichTextBox.Rtf = ContenidoComponenteRichTextBox.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetPlantillas.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
            ContenidoComponenteRichTextBox.Rtf = ContenidoComponenteRichTextBox.Text
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

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
            Me.SP_Plantillas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetPlantillas.SP_Plantillas_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)),
                                                 NombrePlantillaTextBox.Text,
                                                 New System.Nullable(Of Integer)(CType(OrdenTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CargarGridEdicion()
        CargarGridSeleccion()
        With DGVEdicionPosicion
            For Each columna As DataGridViewColumn In .Columns
                'Ajustado
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

#End Region
#End Region

#Region "Componentes"
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
        'Me.TecnologiasTableAdapter.Fill(Me.DataSetPlantillas.Tecnologias)
    End Sub
    'Insertar
    Private Sub SP_Componentes_EDICION_INSERTAR()
        Try
            Me.SP_Componentes_EDICION_INSERTARTableAdapter.Fill(Me.DataSetPlantillas.SP_Componentes_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 NombreComponenteTextBox.Text,
                                                 ContenidoComponenteRichTextBox.Rtf,
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
            Me.SP_Componentes_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetPlantillas.SP_Componentes_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 NombreComponenteTextBox.Text,
                                                 ContenidoComponenteRichTextBox.Rtf,
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
            Me.SP_Componentes_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetPlantillas.SP_Componentes_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(ComponenteIDTextBox.Text, Long)))
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
            Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetPlantillas.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#End Region

#Region "Editar Texto"
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

    Private Sub BtnRemplazar_Click(sender As Object, e As EventArgs) Handles BtnRemplazar.Click
        ContenidoComponenteRichTextBox.Text = RemplazarTexto(TxtBuscado.Text, TxtRemplazarPor.Text, ContenidoComponenteRichTextBox.Text)
    End Sub
    Shared Function RemplazarTexto(TextoBuscado As String, TextoParaRemplazo As String, TextoBase As String) As String
        TextoParaRemplazo = TextoParaRemplazo.Replace(" "c, String.Empty)
        Dim resultado As String = TextoBase.Replace(TextoBuscado, TextoParaRemplazo)
        Return resultado
    End Function
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
    Private Sub BtnFuentes_Click(sender As Object, e As EventArgs) Handles BtnFuentes.Click
        Dim f As New FontDialog
        f.ShowDialog()
        Me.ContenidoComponenteRichTextBox.SelectionFont = f.Font
    End Sub
    Private Sub BtnColor_Click(sender As Object, e As EventArgs) Handles BtnColor.Click
        Dim c As New ColorDialog
        c.ShowDialog()
        Me.ContenidoComponenteRichTextBox.SelectionColor = c.Color
    End Sub
    Private Sub BtnIzquierda_Click(sender As Object, e As EventArgs) Handles BtnIzquierda.Click
        Me.ContenidoComponenteRichTextBox.SelectionAlignment = HorizontalAlignment.Left
    End Sub
    Private Sub BtnCentrar_Click(sender As Object, e As EventArgs) Handles BtnCentrar.Click
        Me.ContenidoComponenteRichTextBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub BtnDerecha_Click(sender As Object, e As EventArgs) Handles BtnDerecha.Click
        Me.ContenidoComponenteRichTextBox.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub BtnGuardarCodigo_Click(sender As Object, e As EventArgs) Handles BtnGuardarCodigo.Click
        If MsgBox("Desea Actualizar este codigo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_Componentes_EDICION_ACTUALIZAR_SoloCodigo()
            MsgBox("Se actualizo la plantilla", MsgBoxStyle.Information)
        Else
            MsgBox("Se Cancelo la Instrucción", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub SP_Componentes_EDICION_ACTUALIZAR_SoloCodigo()
        Try

            Me.SP_Componentes_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetPlantillas.SP_Componentes_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 NombreComponenteTextBox.Text,
                                                 ContenidoComponenteRichTextBox.Rtf,
                                                 XTablaTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnImprimeTabla_Click(sender As Object, e As EventArgs) Handles BtnImprimeTabla.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{Tabla}}}")
    End Sub
    Private Sub BtnImprimeClavePrincipal_Click(sender As Object, e As EventArgs) Handles BtnImprimeClavePrincipal.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{Clave}}}")
    End Sub
    Private Sub BtnImprimeCampos_Click(sender As Object, e As EventArgs) Handles BtnImprimeCampos.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{Campos}}}")
    End Sub

    Private Sub BtnTablaMinuscula_Click(sender As Object, e As EventArgs) Handles BtnTablaMinuscula.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{Tmin}}}")
    End Sub
    Private Sub BtnTablaPlural_Click(sender As Object, e As EventArgs) Handles BtnTablaPlural.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{TPlur}}}")
    End Sub
    Private Sub BtnMayusculaAMinuscula_Click(sender As Object, e As EventArgs) Handles BtnMayusculaAMinuscula.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{A=>-a}}}")
    End Sub
    Private Sub BtnTablaPluralMinuscula_Click(sender As Object, e As EventArgs) Handles BtnTablaPluralMinuscula.Click
        Me.ContenidoComponenteRichTextBox.Text = Me.ContenidoComponenteRichTextBox.Text.Insert(Me.ContenidoComponenteRichTextBox.SelectionStart, "{{{TPlurMin}}}")
    End Sub


#End Region

#Region ""

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
            Me.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetPlantillas.SP_RequerimientosPlantillas_EDICION_INSERTAR,
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
            Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetPlantillas.SP_RequerimientosPlantillas_EDICION_ACTUALIZAR,
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
            Me.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetPlantillas.SP_RequerimientosPlantillas_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(RequerimientoPlantillaIDTextBox.Text, Long)))
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
    Private Sub SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
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
#End Region
End Class