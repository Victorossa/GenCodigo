﻿Imports System.IO
Imports System.Text
Imports System.Drawing
Public Class FrmReplace
    Dim ValorRequisito As String
    Dim Requisitos() As String
    Dim creaDocTec As Boolean
    Dim creaCarpArch As Boolean
    Dim NombreArchivoACrear As String
    Dim ContenidoACrear As String
    Dim RutaProcesada As String
    Dim contadorContadorArchivo As Integer = 0
    Dim ComponenteBase As Integer

    Private Sub FrmReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetTablasYCampos.SP_RequerimientosValorProvisional_TRUNCA' Puede moverla o quitarla según sea necesario.
        Me.SP_RequerimientosValorProvisional_TRUNCATableAdapter.Fill(Me.DataSetTablasYCampos.SP_RequerimientosValorProvisional_TRUNCA)

        'TODO: esta línea de código carga datos en la tabla 'DataSetAdministracion.Proyectos' Puede moverla o quitarla según sea necesario.
        'Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DataSetAdministracion.Proyectos' Puede moverla o quitarla según sea necesario.
        'Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
        Try
            Me.TiposTableAdapter.Fill(Me.DataSetAdministracion.Tipos)
            Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
            Cancelar_Proyectos()
            Me.TecnologiasTableAdapter.Fill(Me.DataSetAdministracion.Tecnologias)
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
            Cancelar_TablasDeProyecto()
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID()
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2()
            Cancelar_CamposDeTablas()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FrmReplace_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDoubleClick
        PanelConf.BringToFront()
        PanelConf.Dock = DockStyle.Fill
    End Sub
    Private Sub PanelConf_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PanelConf.MouseDoubleClick
        PanelConf.SendToBack()
        PanelConf.Dock = DockStyle.None
    End Sub

    Private Sub TecnologiaIDTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles TecnologiaIDTextBox.TextChanged
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia_3()
    End Sub
    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia_3()
        Try
            Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia, New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub PlantillaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIDTextBox.TextChanged
        SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
    End Sub
    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
        Try
            Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia, New System.Nullable(Of Integer)(CType(TecnologiaID_EliminaRelacion.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia_2()
        Try
            Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia, New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub PlantillaIDTextBox1_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIDTextBox1.TextChanged
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia_2()
        SP_CARGA_TablasRelacionadas_SEGUN_PlantillaID()
        SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
    End Sub
    Private Sub SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox1.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox1.Text, Integer)))
            EnunciadoEnRich.Text = EnunciadoTextBox.Text
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'RTC
    Private Sub BtnBuscarYPintar_Click(sender As Object, e As EventArgs)
        'Limpia la base de Datos
        SP_ELIMINA_RegistroValorRequerimientos_SegunID()
        Dim contadorTecnologiasAplicadas = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.Count()
        'Carga las tecnologias aplicadas y segun pide los requerimientos de de las plantillas de dichas tecnologias
        While contadorTecnologiasAplicadas > 0
            'Se ubica en la primera fila
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.CurrentCell = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows(0).Cells(0)
            RecorrerRequerimientosPorTecnologia()
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.RemoveAt(0)
            contadorTecnologiasAplicadas = contadorTecnologiasAplicadas - 1
        End While
        'Vuelve y carga las tecnologias aplicadas
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        'Carga los Valores asignados
        SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
    End Sub

    Public Sub RecorrerRequerimientosPorTecnologia()
        Dim contadorRequerimientos = SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count()
        While contadorRequerimientos > 0
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentCell = SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows(0).Cells(0)
            SP_RegistroValorRequerimientos_SegunProyectoRequerimiento()
            If RegistroValorRequerimientoIDTextBox.Text = "" Then
                ValorRequerimientoTextBox.Text = InputBox(EnunciadoTextBox.Text)
                If ValorRequerimientoTextBox.Text = "" Then
                    If MsgBox("No has ingresdo un valor para: " + EnunciadoTextBox.Text, MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
                        Exit While
                    End If
                Else
                    'Guarda el Valor del Requerimiento
                    SP_RegistroValorRequerimientos_EDICION_INSERTAR(ValorRequerimientoTextBox.Text)
                    'Elimina la fila del grid
                    SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
                    'Descuenta del Contador
                    contadorRequerimientos = contadorRequerimientos - 1
                End If
            Else
                'Inserta el mismo valor que ha trabajado
                ValorRequerimientoTextBox.Text = ValorRequerimientoTextBox2.Text
                'Guarda el Valor del Requerimiento
                SP_RegistroValorRequerimientos_EDICION_INSERTAR(ValorRequerimientoTextBox.Text)
                SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
                ''Descuenta del Contador
                contadorRequerimientos = contadorRequerimientos - 1
            End If
        End While
    End Sub
    Private Sub BtnLimpiarValoresRequerimientos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarValoresRequerimientos.Click
        If MsgBox("Desea eliminar el registro de los valores de Requerimiento para este Proyecto?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Limpia la base de Datos
            SP_ELIMINA_RegistroValorRequerimientos_SegunID()
            MsgBox("Se eliminaron todos los valores de requerimientos para este proyecto", MsgBoxStyle.Information)
            SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        Else
            MsgBox("Se cancelo la instrucciòn", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub BtnCancelarCargue_Click(sender As Object, e As EventArgs) Handles BtnCancelarCargue.Click
        Timer_CargueValorRequerimientos.Stop()
        BtnConfirmarValorRequerimiento.Enabled = False
        ValorRequerimiento.Enabled = False
        SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
        BtnEditarValorDeRequerimiento.Enabled = False
        BtnConservarYSeguir.Enabled = False
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
    End Sub
    Private Sub BtnEditarValorDeRequerimiento_Click(sender As Object, e As EventArgs) Handles BtnEditarValorDeRequerimiento.Click
        If ValorRequerimiento.Enabled = False Then
            ValorRequerimiento.Enabled = True
            ValorRequerimiento.Focus()
        Else
            SP_RegistroValorRequerimientos_EDICION_ACTUALIZAR()
            ValorRequerimiento.Enabled = False
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.RemoveAt(0)
            Timer_EdicionValorRequerimiento.Start()
        End If
    End Sub
    Private Sub SP_RegistroValorRequerimientos_EDICION_ACTUALIZAR()
        Try
            Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroValorRequerimientos_EDICION_ACTUALIZAR,
                                                                                  New System.Nullable(Of Long)(CType(RegistroValorRequerimientoIDTextBox1.Text, Long)),
                                                                                  New System.Nullable(Of Integer)(CType(ProyectoIDTextBox1.Text, Integer)),
                                                                                  RequerimientoTextBox2.Text,
                                                                                  ValorRequerimiento.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnConservarYSeguir_Click(sender As Object, e As EventArgs) Handles BtnConservarYSeguir.Click
        If SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.Count > 0 Then
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.RemoveAt(0)
            ValorRequerimiento.Text = ValorRequerimientoTextBox3.Text
            ValorRequerimiento.Enabled = False
            Timer_EdicionValorRequerimiento.Start()
        Else
            Timer_EdicionValorRequerimiento.Stop()
            SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
            BtnEditarValorDeRequerimiento.Enabled = False
            BtnConservarYSeguir.Enabled = False
        End If
    End Sub
    Private Sub Timer_EdicionValorRequerimiento_Tick(sender As Object, e As EventArgs) Handles Timer_EdicionValorRequerimiento.Tick
        Timer_EdicionValorRequerimiento.Stop()
    End Sub
    Private Sub BtnConfirmarValorRequerimiento_Click(sender As Object, e As EventArgs) Handles BtnConfirmarValorRequerimiento.Click
        RegistrarRequerimiento()
    End Sub

    Private Sub RegistrarRequerimiento()
        If ValorRequerimiento.Text = "" Then
            MsgBox("El Requerimiento no puede ser un valor vacio... Favor verificar", MsgBoxStyle.Critical)
            ValorRequerimiento.Focus()
        Else
            'Hace el registro del requerimiento
            SP_RegistroValorRequerimientos_EDICION_INSERTAR(ValorRequerimiento.Text)
            'Carga el registro en el grid
            SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
            'Elimina la fila del grid
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
            'Vacea la caja
            ValorRequerimiento.Text = ""
            'Bloquea la caja
            ValorRequerimiento.Enabled = False
            'Bloquea el boton
            BtnConfirmarValorRequerimiento.Enabled = False
            'Arranca el Timer
            Timer_CargueValorRequerimientos.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim cargaRequerimientos As MsgBoxResult
            If SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.Count > 0 Then
                cargaRequerimientos = MsgBox("Este proyecto ya tiene requerimientos, Desea Editarlos?", MsgBoxStyle.YesNoCancel, "Ediciòn de Requerimientos")
                If cargaRequerimientos = MsgBoxResult.Yes Then
                    BtnEditarValorDeRequerimiento.Enabled = True
                    BtnConservarYSeguir.Enabled = True
                    ValorRequerimiento.Enabled = False
                    ValorRequerimiento.Text = ValorRequerimientoTextBox3.Text
                    Timer_EdicionValorRequerimiento.Start()
                End If
                If cargaRequerimientos = MsgBoxResult.No Then
                    Timer_CargueValorRequerimientos.Stop()
                    BtnConfirmarValorRequerimiento.Enabled = False
                    ValorRequerimiento.Enabled = False
                End If
                If cargaRequerimientos = MsgBoxResult.Cancel Then
                    Timer_CargueValorRequerimientos.Stop()
                    BtnConfirmarValorRequerimiento.Enabled = False
                    ValorRequerimiento.Enabled = False
                End If
            Else
                Label18.Text = 0
                BtnConfirmarValorRequerimiento.Enabled = True
                Timer_CargueValorRequerimientos.Start()
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Timer_CargueValorRequerimientos_Tick(sender As Object, e As EventArgs) Handles Timer_CargueValorRequerimientos.Tick
        Try
            'Verifica que hallan datos en las tecnologias aplicadas de lo contrario para el timer
            If SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.Count > 0 Then
                'Verifica si hay requerimiento por parte de esa plantilla, si no lo hay elimina el registro
                If Lbl_Requerimiento.Text = "" Then
                    'Elimina el registro
                    SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.RemoveAt(0)
                Else
                    'Si esta lleno, busca si ya existe el requerimiento para ese proyecto 
                    SP_RegistroValorRequerimientos_SegunProyectoRequerimiento()
                    If RegistroValorRequerimientoIDTextBox.Text = "" Then
                        Timer_CargueValorRequerimientos.Stop()
                        ValorRequerimiento.Enabled = True
                        BtnConfirmarValorRequerimiento.Enabled = True
                        ValorRequerimiento.Focus()
                        Label18.Text = Label18.Text + 1
                    Else
                        SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
                        Timer_CargueValorRequerimientos.Start()
                        If Lbl_Requerimiento.Text = "" Then
                            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.RemoveAt(0)
                            Lbl_Requerimiento.Text = ""
                        End If
                    End If
                End If
            Else
                Timer_CargueValorRequerimientos.Stop()
                SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
                MsgBox("Valores de Requerimientos cargados Exitosamente!!!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Dim aList As New List(Of String)
    Public Sub ValidarRequerimientos()



        Dim contador As Integer
        Dim cuentaRequerimientos As Integer = 0
        contador = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.Count
        While contador > 0
            'If Lbl_Requerimiento.Text <> "" Then
            'MsgBox(Lbl_Requerimiento.Text)
            aList.Add(Lbl_Requerimiento.Text)
            cuentaRequerimientos = cuentaRequerimientos + 1
            'End If
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.RemoveAt(0)
            contador = contador - 1
        End While
        MsgBox(aList)
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        If cuentaRequerimientos = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.Count Then
            MsgBox("El proyecto " & NombreProyectoTextBox.Text & "tiene la cantidad de requerimientos correctos", MsgBoxStyle.Information)
        Else
            MsgBox("El proyecto " & NombreProyectoTextBox.Text & " tiene " & SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.Count & " requerimientos, solo cuenta con " & cuentaRequerimientos & "", MsgBoxStyle.Exclamation)
        End If
    End Sub



    Private Sub generarValoresRequerimientos()
        'Cuenta las tecnologias aplicadas al proyecto
        Dim contadorTecnologiasAplicadas = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.Count()
        'Registro de cantidad de tecnologias aplicadas
        Label18.Text = contadorTecnologiasAplicadas
        If contadorTecnologiasAplicadas > 0 Then
            'Se ubica en la primera fila del grid
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.CurrentCell = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows(0).Cells(0)
            'Metodo para recoger los valores de requerimiento
            CargarValoresRequerimientos()
            'Elimina fila trabajada
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.RemoveAt(0)
            'Resta del contador
            contadorTecnologiasAplicadas = contadorTecnologiasAplicadas - 1
            'Muestra en Pantalla
            Label18.Text = contadorTecnologiasAplicadas
        Else
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        End If
    End Sub
    Private Sub CargarValoresRequerimientos()

        If SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count > 0 Then
            'Busca que el requerimiento no halla sido registrado para este proyecto
            SP_RegistroValorRequerimientos_SegunProyectoRequerimiento()
            If RegistroValorRequerimientoIDTextBox.Text = "" Then
                If ValorRequerimiento.Text = "" Then
                    '            MsgBox("Debes ingresar un valor", MsgBoxStyle.Critical)
                    '            ValorRequerimiento.Focus()
                Else
                    '            'Guarda el Valor del Requerimiento
                    '            SP_RegistroValorRequerimientos_EDICION_INSERTAR(ValorRequerimiento.Text)
                    '            'Elimina la fila del grid
                    '            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
                    '            Label18.Text = SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count
                    '            SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
                    '            If SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count = 0 Then
                    '                ValorRequerimiento.Enabled = False
                    '                MsgBox("Los requerimientos para este proyecto ya fueron Completados", MsgBoxStyle.Information)
                    '            End If
                    '            ValorRequerimiento.Text = ""
                    '            ValorRequerimiento.Focus()
                End If
            Else
                MsgBox("Este dato ya fue registrado para este proyecto", MsgBoxStyle.Exclamation)
            End If
        Else
            ValorRequerimiento.Enabled = False
        End If
    End Sub

    Private Sub ValorRequerimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ValorRequerimiento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If BtnEditarValorDeRequerimiento.Enabled = True Then
                If ValorRequerimiento.Enabled = False Then
                    ValorRequerimiento.Enabled = True
                    ValorRequerimiento.Focus()
                Else
                    SP_RegistroValorRequerimientos_EDICION_ACTUALIZAR()
                    ValorRequerimiento.Enabled = False
                    SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.RemoveAt(0)
                    Timer_EdicionValorRequerimiento.Start()
                End If
            Else
                RegistrarRequerimiento()
            End If
        End If
    End Sub
    Private Sub BtnRemplazar2_Click(sender As Object, e As EventArgs) Handles BtnRemplazar2.Click
        If ChkGenerarCarpetasYArchivos.Checked = True Then
            creaCarpArch = True
        Else
            creaCarpArch = False
        End If

        If ChkDocumentoTecnico.Checked = True Then
            creaDocTec = True
        Else
            creaDocTec = False
        End If
        If chkValidacion.Checked = True Then
            ValidarRequerimientos()
            GenerarCodigo(creaDocTec, creaCarpArch)
        Else
            GenerarCodigo(creaDocTec, creaCarpArch)
        End If
    End Sub

    Public Sub GenerarCodigo(ByVal CreaDocTec As Boolean, ByVal CreaCarpArch As Boolean)
        'Limpia todo el codigo generado que se tenga guardado en el momento
        CodigoGeneradoRichTextBox.Text = ""
        'Cuenta las tecnologias aplicadas al proyecto o las plantillas que se aplicaran
        Dim contadorTecnologiasAplicadas = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.Count()
        'RECORRE LAS PLANTILLAS DE TECNOLOGIAS APLICADAS
        While contadorTecnologiasAplicadas > 0
            'Se ubica en la primera fila
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.CurrentCell = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows(0).Cells(0)
            'RECORRE LOS "COMPONENTES" de la PLANTILLA Y DEFINE SI CREA ARCHIVOS O DOCUMENTO TECNICO
            RecorrerComponentesHaciendoReplace(CreaDocTec, CreaCarpArch)
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.RemoveAt(0)
            contadorTecnologiasAplicadas = contadorTecnologiasAplicadas - 1
            PrefijoTextBox.Text = ""
            SufijoTextBox.Text = ""
            SuperiorTextBox.Text = ""
            InferiorTextBox.Text = ""
            MultiReplaceTextBox.Text = ""
            SP_CampoComponentes_Segun_Plantilla_TipoTable()
            SP_CampoComponentes_Segun_Plantilla_Tipo_ComponenteID()
        End While
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
    End Sub
    Public Sub GenerarArchivos(ByVal archivo As String, ByVal ruta As String, ByVal contenido As String)
        SP_ProyectoCarpetasArchivos_EDICION_INSERTAR(ruta, archivo, contenido)
    End Sub

    Public Sub RecorrerComponentesHaciendoReplace(ByVal CreaDocTec As Boolean, ByVal CreaCarpArch As Boolean)
        'VARIABLES
        Dim cteBase As Boolean
        Dim contenidoConBase As String = ""

        ' --1-- VALIDA PRIMERO SI EL COMPONENTE TRABAJADO ES UN COMPONENTE BASE
        SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBase()
        ' --2-- RESULTADO DE LA VERIFICACION DE SI EXISTE EN LOS COMPONENTETES DE LA PLANTILLA UNO QUE SEA TIPO BASE
        If ComponenteEvaluaSiTieneBase.Text = "" Then
            cteBase = False
        Else
            cteBase = True
            ' --2.1-- ASIGNA A LA VARIABLE GLOBAL EL VALOR DEL COMPONENTE TRABAJADO PARA UTILIZARLO EN OTRO MODULO
            ComponenteBase = ComponenteEvaluaSiTieneBase.Text
            ' --2.2-- EJECUTA PROCESAMIENTO PARA PLANTILLAS QUE TIENEN COMPONENTES CON BASE
            contenidoConBase = procesandoConBase(cteBase, CreaCarpArch)
        End If

        ' --4-- VALIDA SI TIENE ARCHIVOS O CARPETAS POR ELIMINAR
        If SP_ComponenteArchivoEliminar_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.Count > 0 Then
            'MsgBox("Este componente contiene rutas de archivo a eliminar")
            'EliminarCarpetasArchivos()
        End If

        ' --3-- CUENTA LOS COMPONENTES DE LA PLANTILLA TRABAJADA
        'CUENTA LOS COMPONENTES DE LA PLANTILLA A TRABAJAR
        Dim contadorComponentes = SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count()

        While contadorComponentes > 0
            'Se ubica en la primera fila
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentCell = SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows(0).Cells(0)
            'ComponenteIDTextBox3.Text
            'CODIGO NO APLICABLE A TABLAS
            If XTablaCheckBox.Checked = False Then
                'CODIGO GENERADO CON ENCABEZADO Y SEPARACION
                'CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & "                              " & NombreTecnologiaTextBox1.Text & vbCrLf & vbCrLf & NombreComponenteTextBox.Text & vbCrLf & CodigoTextBox.Text & vbCrLf & "-- ____________________________________________________________________________________________________________________________________________" & vbCrLf & vbCrLf
                'Verifica si contiene tratamiento para tablas
                If InStr(CodigoTextBox.Text, "{{{Tabla-G}}}") Then
                    CodigoTextBox.Text = validarProcesoTablas(CodigoTextBox.Text, ComponenteIDTextBox3.Text)
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & CodigoTextBox.Text & vbCrLf & NombreComponenteTextBox.Text & vbCrLf & vbCrLf
                    If AdmiteCreacionCheckBox.Checked = True Then
                        'BUSCA EN LA BASE DE DATOS SI EXISTE PARA EL COMPONENTE TRABAJADO REGISTRO DE RUTA Y ARCHIVO
                        SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
                        If RutaTextBox.Text <> "" Then
                            NombreArchivoACrear = NombreArchivoTextBox.Text & ExtensionArchivoTextBox.Text
                            NombreArchivoACrear = RemplazaRequerimientos(NombreArchivoACrear)
                            RutaProcesada = RemplazaRequerimientos(RutaTextBox.Text)
                            CodigoTextBox.Text = RemplazaRequerimientos(CodigoTextBox.Text)
                            CodigoTextBox.Text = validarProcesoTablas(CodigoTextBox.Text, ComponenteIDTextBox3.Text)
                            GenerarArchivos(NombreArchivoACrear, RutaProcesada, CodigoTextBox.Text)
                        End If
                    Else
                        CodigoGeneradoRichTextBox.Text = CodigoTextBox.Text & vbCrLf & NombreComponenteTextBox.Text & "--" & vbCrLf & vbCrLf
                    End If
                Else
                    If AdmiteCreacionCheckBox.Checked = True Then
                        'CODIGO GENERADO SIN ENCABEZADO
                        CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & NombreComponenteTextBox.Text & vbCrLf & CodigoTextBox.Text & vbCrLf & "--" & vbCrLf & vbCrLf
                        'BUSCA EN LA BASE DE DATOS SI EXISTE PARA EL COMPONENTE TRABAJADO REGISTRO DE RUTA Y ARCHIVO
                        SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
                        If RutaTextBox.Text <> "" Then
                            NombreArchivoACrear = NombreArchivoTextBox.Text & ExtensionArchivoTextBox.Text
                            NombreArchivoACrear = RemplazaRequerimientos(NombreArchivoACrear)
                            RutaProcesada = RemplazaRequerimientos(RutaTextBox.Text)
                            CodigoTextBox.Text = RemplazaRequerimientos(CodigoTextBox.Text)
                            CodigoTextBox.Text = validarProcesoTablas(CodigoTextBox.Text, ComponenteIDTextBox3.Text)
                            GenerarArchivos(NombreArchivoACrear, RutaProcesada, CodigoTextBox.Text)
                        End If
                    Else
                        'CODIGO GENERADO SIN ENCABEZADO
                        CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & NombreComponenteTextBox.Text & vbCrLf & CodigoTextBox.Text & vbCrLf & "--" & vbCrLf & vbCrLf
                    End If
                End If


            Else
                'CODIGO APLICABLE A TODAS LAS TABLAS
                If cteBase = False Then
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & "                             " & NombreTecnologiaTextBox1.Text & vbCrLf & vbCrLf & NombreComponenteTextBox.Text & TablasDeAplicacion(CodigoTextBox.Text, cteBase, CreaCarpArch) & vbCrLf & vbCrLf & "-- ____________________________________________________________________________________________________________________________________________" & vbCrLf & vbCrLf
                End If
            End If
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
            contadorComponentes = contadorComponentes - 1
        End While
        If cteBase = True Then
            ' --2.3 EL CONTENIDO QUE SE GENERO COMO BASE SE AGREGA AL CONTENIDO QUE SE GENERARA COMO PRINCIPAL
            CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & vbCrLf & contenidoConBase
        End If
        RemplazarEnResultado(CodigoGeneradoRichTextBox.Text, NombreTablaTextBox1.Text)
        If CreaDocTec = True Then
            If SP_PlantillasImagenes_BUSCA_SEGUN_PlantillaIDDataGridView.Rows.Count > 0 Then
                Dim myImg As Image
                myImg = ImagenPictureBox.Image
                ContadorImagenes.Text = ContadorImagenes.Text + 1
                SP_ProyectoDocumentoTecnico_EDICION_INSERTAR(CodigoParaReporte.Text, (ImagenToBytes(myImg)))
                ImagenPictureBox.Image = Nothing
            Else
                Dim lotsaBytes(0) As Byte
                SP_ProyectoDocumentoTecnico_EDICION_INSERTAR(CodigoParaReporte.Text, Nothing)
                ImagenPictureBox.Image = Nothing
            End If
        End If
    End Sub
    Public Function ImagenToBytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        Dim arreglo As Byte() = Nothing
        Try
            If Not Imagen Is Nothing Then
                'variable de datos binarios en stream(flujo)
                Dim Bin As New MemoryStream
                'convertir a bytes
                Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
                'retorna binario
                arreglo = Bin.GetBuffer
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("No convirtio a bytes por: " + ex.ToString)
        End Try
        Return arreglo
    End Function

    Function procesandoConBase(cteBase As Boolean, ByVal CreaCarpArch As Boolean)
        ' --2.3-- SE DECLARA VARIABLE CON EL CONTENIDO CON BASE
        Dim contenidoConBase As String = ""
        ' --2.4-- CUENTA LOS COMPONENTES DE LA ESTRUCTURA TOTAL 
        Dim contadorComponentes = SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count()
        While contadorComponentes > 0
            ' --2.5-- SE UBICA EN LA PRIMERA FILA
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentCell = SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows(0).Cells(0)
            ' --2.6-- PROCESA LOS COMPONENTES QUE COMPONEN LA PLANTILLA QUE TIENE COMPONENTE BASE
            If cteBase = True Then
                contenidoConBase = contenidoConBase & vbCrLf & TablasDeAplicacion(CodigoTextBox.Text, cteBase, CreaCarpArch) & vbCrLf & vbCrLf
            End If
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
            contadorComponentes = contadorComponentes - 1
        End While
        ' --2.7-- PROCESARA LO GUARDADO EN BASE DE DATOS PARA HACER LOS REPLACE
        contenidoConBase = ProcesarProvisionales(CreaCarpArch)
        Return contenidoConBase
    End Function

    Private Sub SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBase()
        Try
            Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBase, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox1.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub RemplazarEnResultado(textoBase As String, NombreTabla As String)
        'Remplaza los Requerimientos
        CargaRequerimientos()
        'Guarda la informacion
        SP_Proyectos_EDICION_ACTUALIZAR_CodigoRemplazado()
    End Sub
    Function validarContenidoTablas(textoBase As String, NombreTabla As String)
        Dim CodigoGenerado = textoBase.Replace("{{{Tabla}}}", NombreTabla)
        Return CodigoGenerado
    End Function

    Function ProcesarProvisionales(ByVal CreaCarpArch As Boolean)
        'VARIABLES 
        Dim respuestaFormularios As String = ""
        ComponenteIDTextBox.Text = ComponenteEvaluaSiTieneBase.Text


        ' --2.7.1 PROCESA LOS REGISTROS GUARDADOS PROVISIONAL Y HACE LOS REPLACE EN LA BASE
        CargaTablasParaComponentesContenidoProvisional()
        ' --2.7.2 CUENTA LAS TABLAS A PROCESAR
        Dim contadorTablas = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoTablasContProvi.Rows.Count()
        While contadorTablas > 0
            'SE UBICA EN LA PRIMERA FILA
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoTablasContProvi.CurrentCell = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoTablasContProvi.Rows(0).Cells(0)
            ' --2.7.3 VA AGREGANDO LO PROCESADO PARA ENTREGAR LA RESPUESTA DEL PROCESO
            respuestaFormularios = respuestaFormularios & BaseTextBox.Text & vbCrLf
            If CreaCarpArch = True Then
                SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
                If RutaTextBox.Text <> "" Then
                    NombreArchivoACrear = RemplazosDeTabla(NombreArchivoTextBox.Text, NombreTablaTextBox3.Text) & ExtensionArchivoTextBox.Text
                    RutaProcesada = RemplazaRequerimientos(RutaTextBox.Text)
                    RutaProcesada = RemplazosDeTabla(RutaProcesada, NombreTablaTextBox3.Text)
                    respuestaFormularios = RemplazaRequerimientos(respuestaFormularios)
                    GenerarArchivos(NombreArchivoACrear, RutaProcesada, respuestaFormularios)
                End If
            End If
            ' --2.7.4 ELIMINA EJECUTANDO EL TEXCHANGED GENERANDO EL NUEVO BASE MAS SUS REPLACE PARA ADICIONAR A LA RESPUESTA DEL FORMULARIO
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoTablasContProvi.Rows.RemoveAt(0)
            contadorTablas = contadorTablas - 1
        End While
        ' --2.7.4 TRUNCA EL CONTENIDO DE LA TABLA PROVISIONAL
        Me.SP_ComponentesContenidoProvisional_TruncateTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesContenidoProvisional_Truncate)
        Return respuestaFormularios
    End Function

    Private Sub CargaTablasParaComponentesContenidoProvisional()
        Try
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID3TableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID3, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Carga la base
    Private Sub SP_ComponentesContenidoProvisional_SEGUN_TABLA_BASE()
        Try
            Me.SP_ComponentesContenidoProvisional_SEGUN_TABLA_BASETableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesContenidoProvisional_SEGUN_TABLA_BASE, New System.Nullable(Of Integer)(CType(TablaID_Provisional.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_ComponentesContenidoProvisional_SEGUN_TABLA_REPLACE()
        Try
            Me.SP_ComponentesContenidoProvisional_SEGUN_TABLA_REPLACETableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesContenidoProvisional_SEGUN_TABLA_REPLACE, New System.Nullable(Of Integer)(CType(TablaID_Provisional.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TablaID_Provisional_TextChanged(sender As Object, e As EventArgs) Handles TablaID_Provisional.TextChanged
        ' --2.7.1.1 TRUNCA LA TABLA DE COMPONENTE PROVISIONAL
        Me.SP_ComponentesContenidoProvisional_Base_TrucateTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesContenidoProvisional_Base_Trucate)
        ' --2.7.1.2 CARGA LOS REGISTROS DE LA TABLA PROVISIONAL QUE CORRESPONDEN A LA TABLA TRABAJADA
        SP_ComponentesContenidoProvisional_SEGUN_TABLA_BASE()
        ' --2.7.1.3 
        SP_ComponentesContenidoProvisional_SEGUN_TABLA_REPLACE()
        ' --2.7.1.4 INSERTA EL CONTENIDO DE BASE PARA IR HACIENDO EL REPLACE PARA LA TABLA EN PROCESO
        FSP_ComponentesContenidoProvisional_Base_EDICION_INSERTAR()
        ' --2.7.1.5 CUENTA LA CANTIDAD DE FILAS QUE NO SON TIPO BASE O SEA QUE NO SON TRUE 
        Dim cantidadComp = SP_ComponentesContenidoProvisional_SEGUN_TABLA_REPLACEDataGridView.Rows.Count
        While cantidadComp > 0
            ' --2.7.1.6 CARGA EL QUE ES DENOMINADO LA BASE
            Me.SP_ComponentesContenidoProvisional_Base_BUSQUEDA_SEGUN_PARAMETRO_IdTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesContenidoProvisional_Base_BUSQUEDA_SEGUN_PARAMETRO_Id)
            ' --2.7.1.7 LO QUE ENCUENTE EN EL TEXTO BASE Y QUE SEA COMO REFERENCIA LO REMPLAZA POR EL CONTENIDO 
            BaseTextBox.Text = Replace(BaseTextBox.Text, ReferenciaTextBox.Text, ContenidoDeRemplazo.Text)
            ' --2.7.1.8 ACTUALIZA LO REMPLAZADO 
            SP_ComponentesContenidoProvisional_Base_EDICION_ACTUALIZAR()
            SP_ComponentesContenidoProvisional_SEGUN_TABLA_REPLACEDataGridView.Rows.RemoveAt(0)
            cantidadComp = cantidadComp - 1
        End While
        If cantidadComp = 0 Then

            If ChkGenerarCarpetasYArchivos.Checked = True Then
                SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID_Metodo(ComponenteBase)
                If RutaTextBox.Text <> "" And NombreTablaTextBox3.Text <> "" Then
                    'Nombre archivo
                    NombreArchivoACrear = NombreArchivoTextBox.Text & ExtensionArchivoTextBox.Text
                    'Tabla
                    NombreArchivoACrear = RemplazosDeTabla(NombreArchivoACrear, NombreTablaTextBox3.Text)
                    'Requerimientos
                    NombreArchivoACrear = RemplazaRequerimientos(NombreArchivoACrear)

                    'Ruta
                    RutaProcesada = RutaTextBox.Text
                    'Tabla
                    RutaProcesada = RemplazosDeTabla(RutaProcesada, NombreTablaTextBox3.Text)
                    'Requerimientos
                    RutaProcesada = RemplazaRequerimientos(RutaProcesada)

                    'Contenido
                    ContenidoACrear = BaseTextBox.Text
                    'Tabla
                    ContenidoACrear = RemplazosDeTabla(ContenidoACrear, NombreTablaTextBox3.Text)

                    ContenidoACrear = RemplazaRequerimientos(ContenidoACrear)
                    'Guardado
                    GenerarArchivos(NombreArchivoACrear, RutaProcesada, ContenidoACrear)
                End If
            End If
        End If
    End Sub

    'Función para quitar los saltos de línea de un texto
    Private Function quitarSaltosLinea(ByVal texto As String, caracterReemplazar As String) As String
        quitarSaltosLinea = Replace(Replace(texto, Chr(10), caracterReemplazar), Chr(13), caracterReemplazar)
        Return quitarSaltosLinea
    End Function

    Private Sub FSP_ComponentesContenidoProvisional_Base_EDICION_INSERTAR()
        Try
            Me.SP_ComponentesContenidoProvisional_Base_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesContenidoProvisional_Base_EDICION_INSERTAR, ContenidoTextBoxBase.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub SP_ComponentesContenidoProvisional_Base_EDICION_ACTUALIZAR()
        Try
            Me.SP_ComponentesContenidoProvisional_Base_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesContenidoProvisional_Base_EDICION_ACTUALIZAR, BaseTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub CargaRequerimientos()
        Dim contadorRequerimientos = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.Count
        While contadorRequerimientos > 0
            'Se ubica en la primera fila
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.CurrentCell = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows(0).Cells(0)
            CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text.Replace(RequerimientoTextBox1.Text, ValorRequerimientoTextBox1.Text)
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.RemoveAt(0)
            contadorRequerimientos = contadorRequerimientos - 1
        End While
        SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
    End Sub
    Private Sub SP_Proyectos_EDICION_ACTUALIZAR_CodigoRemplazado()
        Try
            Me.SP_Proyectos_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Proyectos_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                 NombreProyectoTextBox.Text,
                                                 CodigoGeneradoRichTextBox.Text,
                                                 DescripcionTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function GenerarCampos()
        Dim contadorCampos = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count
        Dim Campos As String = ""
        While contadorCampos > 0
            'Se ubica en la primera fila
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            Campos = Campos + TratamientoCampos(NombreCampoTextBox1.Text, contadorCampos) & vbCrLf
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
            contadorCampos = contadorCampos - 1
        End While
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1()
        Return Campos
    End Function
    Function GenerarCampos_Sin_ID()
        If SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count > 0 Then
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
        End If
        Dim contadorCampos = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count
        Dim Campos As String = ""
        While contadorCampos > 0
            'Se ubica en la primera fila
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            Campos = Campos + TratamientoCampos(NombreCampoTextBox1.Text, contadorCampos) & vbCrLf
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
            contadorCampos = contadorCampos - 1
        End While
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1()
        Return Campos
    End Function
    Function GenerarCampos_Sin_Relacionados()
        Dim contadorCampos = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count
        Dim Campos As String = ""
        While contadorCampos > 0
            'Se ubica en la primera fila
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            If TipoTextBox1.Text = "numeric (Relacionado)" Or TipoTextBox1.Text = "int(Relacionado)" Then
                SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
                contadorCampos = contadorCampos - 1
            Else
                Campos = Campos + TratamientoCampos(NombreCampoTextBox1.Text, contadorCampos) & vbCrLf
                SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
                contadorCampos = contadorCampos - 1
            End If
        End While
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1()
        Return Campos
    End Function
    Function TratamientoCampos(campoConComplemento As String, contadorCampos As Integer) As String
        Dim Campo As String = "Campo"
        Dim Objeto As String = ""

        If MultiReplaceTextBox.Text = "" Then
            'Poner Prefijo
            If PrefijoTextBox.Text <> "" Then
                Campo = PrefijoTextBox.Text & Campo
            End If
            'Poner Sufijo con separador
            If contadorCampos > 1 Then
                Campo = Campo & SufijoTextBox.Text & SeparadorCamposTextBox.Text
            Else
                Campo = Campo & SufijoTextBox.Text
            End If
            'Poner Superior
            If SuperiorTextBox.Text <> "" Then
                Campo = SuperiorTextBox.Text & vbCrLf & Campo
            End If
            'Poner Inferior
            If InferiorTextBox.Text <> "" Then
                Campo = Campo & vbCrLf & InferiorTextBox.Text
            End If
            Objeto = Campo.Replace("Campo", campoConComplemento)
        Else
            Objeto = MultiReplaceTextBox.Text.Replace("Campo", campoConComplemento)
            If SeparadorCamposTextBox.Text <> "" And SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count <> 1 Then
                Objeto = Objeto & SeparadorCamposTextBox.Text
            Else
                Objeto = Objeto
            End If
            'INCLUIR RECORRIDO POR TABLA RELACIONADA PARA CAPTURAR TABLA INDEPENDIENTE Y DEPENDIENTE
            If TipoTextBox1.Text = "numeric (Relacionado)" Then
                'MsgBox("ID Tabla en la que estamos" + TextBox1.Text + " " + " ID Tabla independiente con la que esta relacionada " + TextBox2.Text)
            End If
        End If

        Return Objeto
    End Function
    Function GenerarClave()
        Dim Clave = CapturaClavePrincipal()
        Return Clave
    End Function
    Function CargarTabla(textoBase As String, NombreTabla As String)
        Dim CodigoGenerado = textoBase.Replace("{{{Tabla}}}", NombreTabla)
        Return CodigoGenerado
    End Function
    Function CargarTablaMinuscula(textoBase As String, NombreTabla As String)
        NombreTabla = LCase(NombreTabla)
        Dim CodigoGenerado = textoBase.Replace("{{{Tmin}}}", NombreTabla)
        Return CodigoGenerado
    End Function
    Function CargarTablaEnPlural(textoBase As String, NombreTabla As String)
        NombreTabla = NombreTabla + "s"
        Dim CodigoGenerado = textoBase.Replace("{{{TPlur}}}", NombreTabla)
        Return CodigoGenerado
    End Function

    Function CargarTablaEnPluralMinus(textoBase As String, NombreTabla As String)
        NombreTabla = NombreTabla + "s"
        NombreTabla = LCase(NombreTabla)
        Dim CodigoGenerado = textoBase.Replace("{{{TPlurMin}}}", NombreTabla)
        Return CodigoGenerado
    End Function

    Function ConvertirMayusculasMinSeparadasPorGuion(textoBase As String, NombreTabla As String)
        Dim cadena As String = NombreTabla
        Dim myChar As String = ""
        Dim fChar As String = ""
        Dim otra As String = ""
        For i = 1 To Len(cadena)
            'Evalua si es mayuscula
            If Asc(Mid(cadena, i, 1)) >= 65 And Asc(Mid(cadena, i, 1)) <= 90 Then
                myChar = cadena.Chars(i - 1)
                myChar = LCase(myChar)
                If i = 1 Then
                    fChar = fChar + myChar
                Else
                    fChar = fChar + "-" & myChar
                End If
                myChar = ""
            Else
                fChar = fChar + myChar + Mid(cadena, i, 1)
                myChar = ""
            End If
        Next
        Dim CodigoGenerado = textoBase.Replace("{{{A=>-a}}}", fChar)
        NombreTablaTextBox1.Text = NombreTablaTextBox.Text
        Return CodigoGenerado
    End Function

    Function CapturaClavePrincipal()
        Try
            'Se ubica en la primera fila
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            Dim Clave = NombreCampoTextBox1.Text
            Return Clave
        Catch ex As Exception

        End Try

    End Function

    Function ucaseCamelCase(textoBase As String, NombreTabla As String)
        Dim cadena As String = NombreTabla
        Dim primera As String = cadena.Substring(0, 1)
        Dim resto As String = cadena.Substring(1)
        Dim myChar As String = ""
        Dim fChar As String = ""
        Dim i As Integer = Len(cadena)
        Dim valor As Integer = Asc((cadena.Substring(0, 1)))
        If valor >= 65 And valor <= 90 Then
            primera = LCase(primera)
            primera = primera + resto
        End If
        Dim CodigoGenerado = textoBase.Replace("{{{Tbl-Camel}}}", primera)
        Return CodigoGenerado
    End Function





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
        TabControl1.Location = New Point(8, 403)
        TabControl1.Height = 187
    End Sub
    'Insertar
    Private Sub SP_Proyectos_EDICION_INSERTAR()
        Try
            Me.SP_Proyectos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_Proyectos_EDICION_INSERTAR,
                                                 NombreProyectoTextBox.Text,
                                                 CodigoGeneradoRichTextBox.Text,
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
                                                 CodigoGeneradoRichTextBox.Text,
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
        'Carga los registros de Parametros del Proyecto ya ingresados
        SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
        'Carga las tecnologias aplicadas al proyecto
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        'Carga Tablas del Proyecto
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2()
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1_RepetirTablas()
        'Carga las rutas del proyecto
        SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
        ContadorImagenes.Text = 0
        RutaUbicacion.Text = ""
        ChkGenerarCarpetasYArchivos.Checked = False
    End Sub



#Region "Proyectos y Tecnologias"
    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.CellMouseDoubleClick
        'Inserta la relacion entre el proyecto y la tecnologia aplicada al mismo
        SP_ProyectosYTecnologias_EDICION_INSERTAR()
        'Carga las tecnologias aplicadas al proyecto

        'MsgBox("Se Crea Relación Del Proyecto" & NombreProyectoTextBox.Text & " con la tecnologia " & NombreTecnologiaTextBox.Text, MsgBoxStyle.Information)
        Timer_CargaTecnologias.Start()
    End Sub
    Private Sub Timer_CargaTecnologias_Tick(sender As Object, e As EventArgs) Handles Timer_CargaTecnologias.Tick
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        Timer_CargaTecnologias.Stop()
    End Sub
    'Metodo que inserta la relacion
    Private Sub SP_ProyectosYTecnologias_EDICION_INSERTAR()
        Try
            Me.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectosYTecnologias_EDICION_INSERTAR, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)), New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox.Text, Integer)), New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


#End Region




    Private Sub ELIMINA_SEGUN_PROYECTO()
        Try
            Me.ELIMINA_SEGUN_PROYECTOTableAdapter.Fill(Me.DataSetAdministracion.ELIMINA_SEGUN_PROYECTO, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)), New System.Nullable(Of Integer)(CType(TecnologiaID_EliminaRelacion.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.CellMouseDoubleClick
        SP_ProyectosYTecnologias_EDICION_ELIMINAR()
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
    End Sub
    Private Sub EliminarUna_Click(sender As Object, e As EventArgs) Handles EliminarUna.Click
        SP_ProyectosYTecnologias_EDICION_ELIMINAR()
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
    End Sub
    Private Sub SP_ProyectosYTecnologias_EDICION_ELIMINAR()
        Try
            Me.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectosYTecnologias_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(ProyectosYTecnologiasIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EliminarTodas_Click(sender As Object, e As EventArgs) Handles EliminarTodas.Click
        ELIMINA_SEGUN_PROYECTO()
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        MsgBox("Se Elimino Relacion", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub TecnologiaID_EliminaRelacion_TextChanged(sender As Object, e As EventArgs) Handles TecnologiaID_EliminaRelacion.TextChanged
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
    End Sub




#Region "Registro Valores de Requerimientos de Plantillas"
    'Inserta valores de los requerimientos de las plantillas de la tecnologia asignada al proyecto
    Private Sub SP_RegistroValorRequerimientos_EDICION_INSERTAR(Valor As String)
        Try
            Me.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroValorRequerimientos_EDICION_INSERTAR,
                                                                                New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                                                RequerimientoTextBox.Text,
                                                                                Valor)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Elimina los valores registrados de los requerimientos de las plantillas de la tecnologia asignada al proyecto
    Private Sub SP_ELIMINA_RegistroValorRequerimientos_SegunID()
        Try
            Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ELIMINA_RegistroValorRequerimientos_SegunID, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Carga los valores de los requerimientos de las plantillas de la tecnologia asignada al proyecto
    Private Sub SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
        Try
            Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroValorRequerimientos_SEGUN_ProyectoID, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub













#End Region


#End Region


#Region "Administracion Tablas"

#Region "Procedimientos"
    Private Sub SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
        Try
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Cancelar_TablasDeProyecto()
        'Botones Del Menu
        Nuevo_Menu_TablasDeProyecto.Enabled = True
        Guardar_Menu_TablasDeProyecto.Enabled = False
        Editar_Menu_TablasDeProyecto.Enabled = True
        Actualizar_Menu_TablasDeProyecto.Enabled = False
        Eliminar_Menu_TablasDeProyecto.Enabled = False
        'Grid
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
        Bloquear_Objetos_TablasDeProyecto()
        Parar_Timer_TablasDeProyecto()
        Timer_Ubicar_En_Fila_TablasDeProyecto()
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Location = New Point(708, 117)
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Location = New Point(708, 362)
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Width = 358
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Width = 358
    End Sub
    'Insertar
    Private Sub SP_TablasDeProyecto_EDICION_INSERTAR()
        Try
            Me.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                 NombreTablaTextBox.Text,
                                                 New System.Nullable(Of Boolean)(CType(TipoTextBox2.Text, Boolean)))
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub SP_TablasDeProyecto_EDICION_ACTUALIZAR()
        Try
            Me.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(TablaIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                 NombreTablaTextBox.Text,
                                                 New System.Nullable(Of Boolean)(CType(TipoTextBox2.Text, Boolean)))
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_TablasDeProyecto_EDICION_ELIMINAR()
        Try
            Me.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(TablaIDTextBox.Text, Long)))
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



#End Region

#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_TablasDeProyecto.Click
        Nuevo_Menu_TablasDeProyecto.Enabled = False
        Editar_Menu_TablasDeProyecto.Enabled = False
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Enabled = False
        Limpiar_Objetos_TablasDeProyecto()
        NombreTablaTextBox.Enabled = True
        NombreTablaTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_TablasDeProyecto.Click
        Control_Nulos_TablasDeProyecto()

        If ControlNulos.Text = "" Then ' Then
            SP_TablasDeProyecto_EDICION_INSERTAR()
            Cancelar_TablasDeProyecto()
            Parar_Timer_TablasDeProyecto()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_TablasDeProyecto.Click
        Nuevo_Menu_TablasDeProyecto.Enabled = False
        Guardar_Menu_TablasDeProyecto.Enabled = False
        Editar_Menu_TablasDeProyecto.Enabled = False
        Actualizar_Menu_TablasDeProyecto.Enabled = True
        Eliminar_Menu_TablasDeProyecto.Enabled = True
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Enabled = False
        Desbloquear_Objetos_TablasDeProyecto()
        Timer_Actualizar_TablasDeProyecto()
        Timer_Eliminar_TablasDeProyecto()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_TablasDeProyecto.Click
        Control_Nulos_TablasDeProyecto()

        If ControlNulos.Text = "" Then ' Then
            SP_TablasDeProyecto_EDICION_ACTUALIZAR()
            Cancelar_TablasDeProyecto()
            Parar_Timer_TablasDeProyecto()
        End If
    End Sub
    Private Sub Eliminar_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_TablasDeProyecto.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_TablasDeProyecto_EDICION_ELIMINAR()
            Cancelar_TablasDeProyecto()
            Parar_Timer_TablasDeProyecto()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_TablasDeProyecto()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_TablasDeProyecto.Click
        Cancelar_TablasDeProyecto()
    End Sub



#End Region

#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_TablasDeProyecto()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case ProyectoIDTextBox.Text = ""
                MsgBox("El nombre del campo: ProyectoID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ProyectoIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case NombreTablaTextBox.Text = ""
                MsgBox("El nombre del campo: NombreTabla; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreTablaTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case TipoCheckBox.Text = ""
                MsgBox("El nombre del campo: Tipo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TipoCheckBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub NombreTablaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTablaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreTablaTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombreTablaTextBox.Text = ""
                NombreTablaTextBox.Focus()
            Else
                TipoCheckBox.Enabled = True
                TipoCheckBox.Focus()
            End If
        End If
    End Sub

    Private Sub TipoCheckBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TipoCheckBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_TablasDeProyecto.Enabled = True Then
                Actualizar_Menu_TablasDeProyecto.Enabled = True
                Eliminar_Menu_TablasDeProyecto.Enabled = True
            Else
                If TipoTextBox2.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    TipoCheckBox.Text = ""
                    TipoCheckBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_TablasDeProyecto.Enabled = True
                    Timer_Guardar_TablasDeProyecto()
                End If
            End If
        End If
    End Sub

    Public Sub Limpiar_Objetos_TablasDeProyecto()
        NombreTablaTextBox.Text = "" ''
        TipoTextBox.Text = ""
    End Sub
    Public Sub Desbloquear_Objetos_TablasDeProyecto()
        NombreTablaTextBox.Enabled = True
        TipoCheckBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_TablasDeProyecto()
        NombreTablaTextBox.Enabled = False
        TipoCheckBox.Enabled = False
    End Sub



#End Region

#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_TablasDeProyecto As Timer
    Private WithEvents Timer_Actualizar_Menu_TablasDeProyecto As Timer
    Private WithEvents Timer_Eliminar_Menu_TablasDeProyecto As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_TablasDeProyecto()
        Me.Timer_Guardar_Menu_TablasDeProyecto = New Timer
        Timer_Guardar_Menu_TablasDeProyecto.Interval = 250
        Timer_Guardar_Menu_TablasDeProyecto.Start()
    End Sub
    Private Sub Timer_Actualizar_TablasDeProyecto()
        Me.Timer_Actualizar_Menu_TablasDeProyecto = New Timer
        Timer_Actualizar_Menu_TablasDeProyecto.Interval = 500
        Timer_Actualizar_Menu_TablasDeProyecto.Start()
    End Sub
    Private Sub Timer_Eliminar_TablasDeProyecto()
        Me.Timer_Eliminar_Menu_TablasDeProyecto = New Timer
        Timer_Eliminar_Menu_TablasDeProyecto.Interval = 800
        Timer_Eliminar_Menu_TablasDeProyecto.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_TablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_TablasDeProyecto.Tick
        If Guardar_Menu_TablasDeProyecto.BackColor = Color.White Then
            Guardar_Menu_TablasDeProyecto.BackColor = Color.Green
        Else
            Guardar_Menu_TablasDeProyecto.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_TablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_TablasDeProyecto.Tick
        If Actualizar_Menu_TablasDeProyecto.BackColor = Color.White Then
            Actualizar_Menu_TablasDeProyecto.BackColor = Color.Green
        Else
            Actualizar_Menu_TablasDeProyecto.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_TablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_TablasDeProyecto.Tick
        If Eliminar_Menu_TablasDeProyecto.BackColor = Color.White Then
            Eliminar_Menu_TablasDeProyecto.BackColor = Color.Red
        Else
            Eliminar_Menu_TablasDeProyecto.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_TablasDeProyecto()
        Me.Timer_Guardar_Menu_TablasDeProyecto = New Timer
        Timer_Guardar_Menu_TablasDeProyecto.Stop()
        Guardar_Menu_TablasDeProyecto.BackColor = Color.White
        Me.Timer_Actualizar_Menu_TablasDeProyecto = New Timer
        Timer_Actualizar_Menu_TablasDeProyecto.Stop()
        Actualizar_Menu_TablasDeProyecto.BackColor = Color.White
        Me.Timer_Eliminar_Menu_TablasDeProyecto = New Timer
        Timer_Eliminar_Menu_TablasDeProyecto.Stop()
        Eliminar_Menu_TablasDeProyecto.BackColor = Color.White
    End Sub



#End Region

#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_TablasDeProyecto As Timer
    Dim X_TablasDeProyecto
    Private Sub Timer_Ubicar_En_Fila_TablasDeProyecto()
        Me.Timer_Ubicacion_TablasDeProyecto = New Timer
        Timer_Ubicacion_TablasDeProyecto.Interval = 100
        Timer_Ubicacion_TablasDeProyecto.Start()
    End Sub
    Private Sub SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.CellMouseClick
        X_TablasDeProyecto = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_TablasDeProyecto()
        Try
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Rows(X_TablasDeProyecto).Selected = True
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.FirstDisplayedScrollingRowIndex = X_TablasDeProyecto
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_TablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_TablasDeProyecto.Tick
        Ubicar_En_Fila_TablasDeProyecto()
        Timer_Ubicacion_TablasDeProyecto.Stop()
    End Sub









#End Region

#End Region



#Region "Procedimientos"
    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID()
        Try
            If TablaIDTextBox.Text = "" Then
                TablaIDTextBox.Text = "0"
                Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID, New System.Nullable(Of Integer)(CType(TablaIDTextBox.Text, Integer)))
            Else
                Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID, New System.Nullable(Of Integer)(CType(TablaIDTextBox.Text, Integer)))
            End If
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Cancelar_CamposDeTablas()
        'Botones Del Menu
        Nuevo_Menu_CamposDeTablas.Enabled = True
        Guardar_Menu_CamposDeTablas.Enabled = False
        Editar_Menu_CamposDeTablas.Enabled = True
        Actualizar_Menu_CamposDeTablas.Enabled = False
        Eliminar_Menu_CamposDeTablas.Enabled = False
        'Grid
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Enabled = True
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Enabled = True
        Panel2.Enabled = True
        'Cargar Datos de Tabla Actualizados
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID()
        Bloquear_Objetos_CamposDeTablas()
        Parar_Timer_CamposDeTablas()
        Timer_Ubicar_En_Fila_CamposDeTablas()

    End Sub
    'Insertar
    Private Sub SP_CamposDeTablas_EDICION_INSERTAR()
        Try
            Me.SP_CamposDeTablas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(TablaIDTextBox.Text, Integer)),
                                                 CboTiposDatos.Text,
                                                 NombreCampoTextBox.Text)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID()
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub SP_CamposDeTablas_EDICION_ACTUALIZAR()
        Try
            Me.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(CampoIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TablaIDTextBox.Text, Integer)),
                                                 CboTiposDatos.Text,
                                                 NombreCampoTextBox.Text)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID()
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_CamposDeTablas_EDICION_ELIMINAR()
        Try
            Me.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(CampoIDTextBox.Text, Long)))
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID()
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



#End Region

#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_CamposDeTablas.Click
        Nuevo_Menu_CamposDeTablas.Enabled = False
        Editar_Menu_CamposDeTablas.Enabled = False
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Enabled = False
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Enabled = False
        Panel2.Enabled = False
        Limpiar_Objetos_CamposDeTablas()
        NombreCampoTextBox.Enabled = True
        NombreCampoTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_CamposDeTablas.Click
        Control_Nulos_CamposDeTablas()

        If ControlNulos.Text = "" Then ' Then
            SP_CamposDeTablas_EDICION_INSERTAR()
            Cancelar_CamposDeTablas()
            Parar_Timer_CamposDeTablas()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_CamposDeTablas.Click
        Nuevo_Menu_CamposDeTablas.Enabled = False
        Guardar_Menu_CamposDeTablas.Enabled = False
        Editar_Menu_CamposDeTablas.Enabled = False
        Actualizar_Menu_CamposDeTablas.Enabled = True
        Eliminar_Menu_CamposDeTablas.Enabled = True
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Enabled = False
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Enabled = False
        Panel2.Enabled = False
        Desbloquear_Objetos_CamposDeTablas()
        Timer_Actualizar_CamposDeTablas()
        Timer_Eliminar_CamposDeTablas()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_CamposDeTablas.Click
        Control_Nulos_CamposDeTablas()

        If ControlNulos.Text = "" Then ' Then
            SP_CamposDeTablas_EDICION_ACTUALIZAR()
            Cancelar_CamposDeTablas()
            Parar_Timer_CamposDeTablas()
        End If
    End Sub
    Private Sub Eliminar_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_CamposDeTablas.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_CamposDeTablas_EDICION_ELIMINAR()
            Cancelar_CamposDeTablas()
            Parar_Timer_CamposDeTablas()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_CamposDeTablas()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_CamposDeTablas.Click
        Cancelar_CamposDeTablas()
    End Sub
    Private Sub TipoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoCheckBox.CheckedChanged
        If TipoCheckBox.Checked = True Then
            TipoCheckBox.Text = "Independiente"
            TipoCheckBox.BackColor = Color.Green
            TipoTextBox2.Text = "True"
        Else
            TipoCheckBox.Text = "Dependiente"
            TipoCheckBox.BackColor = Color.Red
            TipoTextBox2.Text = "False"
        End If
    End Sub




#End Region

#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_CamposDeTablas()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case TablaIDTextBox.Text = ""
                MsgBox("El nombre del campo: TablaID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TablaIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CboTiposDatos.Text = ""
                MsgBox("El nombre del campo: TablaID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTiposDatos.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case NombreCampoTextBox.Text = ""
                MsgBox("El nombre del campo: NombreCampo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreCampoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub NombreCampoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreCampoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreCampoTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombreCampoTextBox.Text = ""
                NombreCampoTextBox.Focus()
            Else
                CboTiposDatos.Enabled = True
                CboTiposDatos.Focus()
            End If
        End If
    End Sub
    Private Sub Cbo_TipoDato_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTiposDatos.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_CamposDeTablas.Enabled = True Then
                Actualizar_Menu_CamposDeTablas.Enabled = True
                Eliminar_Menu_CamposDeTablas.Enabled = True
            Else
                If CboTiposDatos.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    CboTiposDatos.Text = ""
                    CboTiposDatos.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_CamposDeTablas.Enabled = True
                    Timer_Guardar_CamposDeTablas()
                End If
            End If
        End If
    End Sub
    Public Sub Limpiar_Objetos_CamposDeTablas()
        NombreCampoTextBox.Text = "" ''
        CboTiposDatos.Text = ""
    End Sub
    Public Sub Desbloquear_Objetos_CamposDeTablas()
        NombreCampoTextBox.Enabled = True
        CboTiposDatos.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_CamposDeTablas()
        NombreCampoTextBox.Enabled = False
        CboTiposDatos.Enabled = False
    End Sub



#End Region

#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_CamposDeTablas As Timer
    Private WithEvents Timer_Actualizar_Menu_CamposDeTablas As Timer
    Private WithEvents Timer_Eliminar_Menu_CamposDeTablas As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_CamposDeTablas()
        Me.Timer_Guardar_Menu_CamposDeTablas = New Timer
        Timer_Guardar_Menu_CamposDeTablas.Interval = 250
        Timer_Guardar_Menu_CamposDeTablas.Start()
    End Sub
    Private Sub Timer_Actualizar_CamposDeTablas()
        Me.Timer_Actualizar_Menu_CamposDeTablas = New Timer
        Timer_Actualizar_Menu_CamposDeTablas.Interval = 500
        Timer_Actualizar_Menu_CamposDeTablas.Start()
    End Sub
    Private Sub Timer_Eliminar_CamposDeTablas()
        Me.Timer_Eliminar_Menu_CamposDeTablas = New Timer
        Timer_Eliminar_Menu_CamposDeTablas.Interval = 800
        Timer_Eliminar_Menu_CamposDeTablas.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_CamposDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_CamposDeTablas.Tick
        If Guardar_Menu_CamposDeTablas.BackColor = Color.White Then
            Guardar_Menu_CamposDeTablas.BackColor = Color.Green
        Else
            Guardar_Menu_CamposDeTablas.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_CamposDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_CamposDeTablas.Tick
        If Actualizar_Menu_CamposDeTablas.BackColor = Color.White Then
            Actualizar_Menu_CamposDeTablas.BackColor = Color.Green
        Else
            Actualizar_Menu_CamposDeTablas.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_CamposDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_CamposDeTablas.Tick
        If Eliminar_Menu_CamposDeTablas.BackColor = Color.White Then
            Eliminar_Menu_CamposDeTablas.BackColor = Color.Red
        Else
            Eliminar_Menu_CamposDeTablas.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_CamposDeTablas()
        Me.Timer_Guardar_Menu_CamposDeTablas = New Timer
        Timer_Guardar_Menu_CamposDeTablas.Stop()
        Guardar_Menu_CamposDeTablas.BackColor = Color.White
        Me.Timer_Actualizar_Menu_CamposDeTablas = New Timer
        Timer_Actualizar_Menu_CamposDeTablas.Stop()
        Actualizar_Menu_CamposDeTablas.BackColor = Color.White
        Me.Timer_Eliminar_Menu_CamposDeTablas = New Timer
        Timer_Eliminar_Menu_CamposDeTablas.Stop()
        Eliminar_Menu_CamposDeTablas.BackColor = Color.White
    End Sub



#End Region

#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_CamposDeTablas As Timer
    Dim X_CamposDeTablas
    Private Sub Timer_Ubicar_En_Fila_CamposDeTablas()
        Me.Timer_Ubicacion_CamposDeTablas = New Timer
        Timer_Ubicacion_CamposDeTablas.Interval = 100
        Timer_Ubicacion_CamposDeTablas.Start()
    End Sub
    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.CellMouseClick
        X_CamposDeTablas = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_CamposDeTablas()
        Try
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Rows(X_CamposDeTablas).Selected = True
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.FirstDisplayedScrollingRowIndex = X_CamposDeTablas
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_CamposDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_CamposDeTablas.Tick
        Ubicar_En_Fila_CamposDeTablas()
        Timer_Ubicacion_CamposDeTablas.Stop()
    End Sub
    Private Sub TablaIDTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles TablaIDTextBox.TextChanged
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID()
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2()
    End Sub

    Private Sub TipoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoTextBox.TextChanged
        CboTiposDatos.Text = TipoTextBox.Text
    End Sub

    Private Sub SP_CampoComponentes_Segun_Plantilla_TipoTable()
        Try
            Me.SP_CampoComponentes_Segun_Plantilla_TipoTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CampoComponentes_Segun_Plantilla_Tipo, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox1.Text, Integer)), TipoTextBox1.Text)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub NombreCampoTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NombreCampoTextBox1.TextChanged
        SP_CampoComponentes_Segun_Plantilla_TipoTable()
        SP_CampoComponentes_Segun_Plantilla_Tipo_ComponenteID()
    End Sub
    Private Sub NombreCampoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreCampoTextBox.TextChanged
        SP_CampoComponentes_Segun_Plantilla_TipoTable()
        SP_CampoComponentes_Segun_Plantilla_Tipo_ComponenteID()
    End Sub

    Private Sub CodigoGeneradoRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles CodigoGeneradoRichTextBox.MouseDoubleClick
        CodigoGeneradoRichTextBox.BringToFront()
        CodigoGeneradoRichTextBox.Dock = DockStyle.Fill
        BtnAmpliar.BackColor = Color.GreenYellow
    End Sub

    Private Sub MaximizarCodigoGeneradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizarCodigoGeneradoToolStripMenuItem.Click
        CodigoGeneradoRichTextBox.SendToBack()
        CodigoGeneradoRichTextBox.Dock = DockStyle.None
    End Sub
#End Region
    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        If CodigoGeneradoRichTextBox.Text <> "" Then
            Clipboard.SetText(CodigoGeneradoRichTextBox.Text)
        End If
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        CodigoGeneradoRichTextBox.Text = ""
        SP_Proyectos_EDICION_ACTUALIZAR_CodigoRemplazado()
    End Sub
    Private Sub SP_RegistroValorRequerimientos_SegunProyectoRequerimiento()
        Try
            Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroValorRequerimientos_SegunProyectoRequerimiento, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)), RequerimientoTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function TablasDeAplicacion(ByVal Contenido As String, ByVal cteBase As Boolean, ByVal CreaCarpArch As Boolean)
        ' VARIABLES DE LA FUNCION
        Dim textoDeTablas As String = ""

        ' --2.6.1-- CARGA EN EL GRID LAS TABLAS PROCESADAS 
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1_RepetirTablas()
        ' --2.6.2-- CUENTA LAS TABLAS DEL GRID QUE SE VAN A PROCESAR
        Dim contadorTablasSistema = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Rows.Count()
        ' --2.6.3-- RECORRERA EL CONTENIDO DEL COMPONENTE BASE Y VA A REMPLAZAR EL NOMBRE DE CADA TABLA EN ESTE
        While contadorTablasSistema > 0
            'SE UBICA EN LA PRIMERA FILA DEL GRID DE LAS TABLAS
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.CurrentCell = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Rows(0).Cells(0)
            ' --2.6.4-- EJECUTA EL METODO QUE REMPLAZA TODO LO QUE ENCUENTRE POR REMPLAZAR HE INSERTA EN BASE DE DATOS PROVISIONAL
            textoDeTablas = textoDeTablas & RemplazosDeTodasTablas(Contenido, NombreTablaTextBox2.Text, cteBase, CreaCarpArch, contadorTablasSistema) & vbCrLf
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Rows.RemoveAt(0)
            contadorTablasSistema = contadorTablasSistema - 1
        End While
        ' --2.6.5-- CARGA DE NUEVO LAS TABLAS A PROCESAR
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1_RepetirTablas()
        ' --2.6.6-- HACE EL RETORNO DE LA FUNCION
        Return textoDeTablas
    End Function
    Public Sub SP_ComponentesContenidoProvisional_EDICION_INSERTAR(TablaID As Integer, PlantillaID As Integer, TipoXBase As String, Referencia As String, Contenido As String)
        ' --2.6.4.2-- INSERTA EN BASE DE DATOS LAS PARTES DEL COMPONENTE BASE
        Try
            Me.SP_ComponentesContenidoProvisional_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesContenidoProvisional_EDICION_INSERTAR,
                                                                                    New System.Nullable(Of Integer)(CType(TablaID, Integer)),
                                                                                    New System.Nullable(Of Integer)(CType(PlantillaID, Integer)),
                                                                                    New System.Nullable(Of Boolean)(CType(TipoXBase, Boolean)),
                                                                                    Referencia,
                                                                                    Contenido)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1_RepetirTablas()
        Try
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Function RemplazosDeTodasTablas(ByVal Contenido As String, ByVal Tabla As String, ByVal cteBase As Boolean, ByVal creaCarpArch As Boolean, ByVal cantTablas As Integer)
        Dim ContenidoGenerado As String = Contenido
        Dim ObjContenido As String = ""
        'Remplaza el nombre de la tabla en el contenido
        If InStr(Contenido, "{{{Tabla}}}") Then
            ContenidoGenerado = CargarTabla(Contenido, Tabla)
        End If
        'Remplaza el nombre de la tabla poniendola en minuscula
        If InStr(Contenido, "{{{Tmin}}}") Then
            ContenidoGenerado = CargarTablaMinuscula(ContenidoGenerado, Tabla)
        End If
        'Remplaza el nombre de la tabla poniendola en plorual
        If InStr(Contenido, "{{{TPlur}}}") Then
            ContenidoGenerado = CargarTablaEnPlural(ContenidoGenerado, Tabla)
        End If
        'Remplaza el nombre de la tabla poniendola en minuscula y en plural
        If InStr(Contenido, "{{{TPlurMin}}}") Then
            ContenidoGenerado = CargarTablaEnPluralMinus(ContenidoGenerado, Tabla)
        End If
        'Remplaza el nombre de la tabla poniendola en minusculas y donde encuentre una mayuscula la remplaza por un guion poniendo la letra que sigue en minuscula
        If InStr(Contenido, "{{{A=>-a}}}") Then
            ContenidoGenerado = ConvertirMayusculasMinSeparadasPorGuion(ContenidoGenerado, Tabla)
        End If
        'Remplaza el nombre de la tabla poniendola en
        If InStr(Contenido, "{{{Tbl-Camel}}}") Then
            ContenidoGenerado = ucaseCamelCase(ContenidoGenerado, Tabla)
        End If


        If InStr(Contenido, "{{{Clave}}}") Then
            Dim Clave = GenerarClave()
            ContenidoGenerado = ContenidoGenerado.Replace("{{{Clave}}}", Clave)
        End If


        If Not InStr(Contenido, "{{{Campos}}}") Then
            Dim Campos = GenerarCampos()
            ContenidoGenerado = ContenidoGenerado.Replace("{{{Campos}}}", Campos)
            If InStr(ContenidoGenerado, "{{{Tabla}}}") Then
                ContenidoGenerado = ContenidoGenerado.Replace("{{{Tabla}}}", Tabla)
            End If
        End If


        If Not InStr(Contenido, "{{{TCampos-ID}}}") Then
            Dim Campos = GenerarCampos_Sin_ID()
            ContenidoGenerado = ContenidoGenerado.Replace("{{{TCampos-ID}}}", Campos)
            If InStr(ContenidoGenerado, "{{{Tabla}}}") Then
                ContenidoGenerado = ContenidoGenerado.Replace("{{{Tabla}}}", Tabla)
            End If
        End If


        If Not InStr(Contenido, "{{{TCampos-R}}}") Then
            Dim Campos = GenerarCampos_Sin_Relacionados()
            ContenidoGenerado = ContenidoGenerado.Replace("{{{TCampos-R}}}", Campos)
            If InStr(ContenidoGenerado, "{{{Tabla}}}") Then
                ContenidoGenerado = ContenidoGenerado.Replace("{{{Tabla}}}", Tabla)
            End If
        End If



        If InStr(Contenido, "{{{Camp-Rel}}}") Then
            Dim CamposRel = RecorreTablasRelacionadas()
            ContenidoGenerado = ContenidoGenerado.Replace("{{{Camp-Rel}}}", CamposRel)
        End If


        If cteBase = True Then
            ' --2.6.4.1-- INSERTA EN BASE DE DATOS LAS PARTES DEL COMPONENTE BASE
            SP_ComponentesContenidoProvisional_EDICION_INSERTAR(TablaIDTextBox1.Text, PlantillaIDTextBox1.Text, TipoXBase.Text, NombreComponenteTextBox.Text, ContenidoGenerado)
        End If

        'CREARA ARCHIVOS Y CARPETAS 
        If creaCarpArch = True And cteBase <> True Then
            SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
            If RutaTextBox.Text <> "" Then
                NombreArchivoACrear = RemplazosDeTabla(NombreArchivoTextBox.Text, Tabla) & ExtensionArchivoTextBox.Text
                RutaProcesada = RemplazaRequerimientos(RutaTextBox.Text)
                RutaProcesada = RemplazosDeTabla(RutaProcesada, Tabla)
                ContenidoGenerado = RemplazaRequerimientos(ContenidoGenerado)

                GenerarArchivos(NombreArchivoACrear, RutaProcesada, ContenidoGenerado)
            End If
        End If
        Return ContenidoGenerado
    End Function

    Function RemplazaRequerimientos(ByVal Texto As String)
        Dim contenido As String = ""
        'Inserta en provisional
        SP_RequerimientosValorProvisional_EDICION_INSERTAR(Texto)
        Dim contadorRequerimientos = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.Count
        If contadorRequerimientos = 0 Then
            contenido = Texto
        Else
            While contadorRequerimientos > 0
                'Se ubica en la primera fila
                SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.CurrentCell = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows(0).Cells(0)
                'Carga lo que hay en provisional
                SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO()
                contenido = TextoDeBD.Text.Replace(RequerimientoTextBox1.Text, ValorRequerimientoTextBox1.Text)
                'Actualiza valor en provisional
                SP_RequerimientosValorProvisional_EDICION_ACTUALIZAR(contenido)
                SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.RemoveAt(0)
                contadorRequerimientos = contadorRequerimientos - 1
            End While
            SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
            'Trunca Tabla del provisional
            Me.SP_RequerimientosValorProvisional_TRUNCATableAdapter.Fill(Me.DataSetTablasYCampos.SP_RequerimientosValorProvisional_TRUNCA)
        End If
        Return contenido
    End Function

    Function validarProcesoTablas(ByVal Texto As String, ByVal ComponenteID As Integer)
        Dim contenido As String = ""
        Dim ContenidoGenerado As String = ""
        Dim contadorTablas As Integer = 0
        Dim ObjContenido As String = ""


        If InStr(Texto, "{{{Tabla-G}}}") Then
            'Carga el contenido que hara replace
            SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID(ComponenteID)
            'Carga las tablas del proyecto
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID4()
            'Recorre Tablas
            contadorTablas = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID4DataGridView.Rows.Count
            While contadorTablas > 0
                SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID4DataGridView.CurrentCell = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID4DataGridView.Rows(0).Cells(0)
                contenido = contenido & vbCrLf & RemplazosDeTodasTablas(ContenidoXTablaTextBox.Text, NombreTablaParaAplicacionXTabla.Text, False, False, 0)
                SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID4DataGridView.Rows.RemoveAt(0)
                contadorTablas = contadorTablas - 1
            End While
            ContenidoGenerado = Texto.Replace("{{{Tabla-G}}}", contenido)
        Else
            ContenidoGenerado = Texto
        End If
        Return ContenidoGenerado
    End Function



    Private Sub SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID4()
        Try
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID4TableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID4, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID(ByVal ComponenteId As Integer)
        Try
            Me.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID, New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub SP_RequerimientosValorProvisional_EDICION_INSERTAR(ByVal Texto As String)
        Try
            Me.SP_RequerimientosValorProvisional_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RequerimientosValorProvisional_EDICION_INSERTAR,
                                                                                   Texto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO()
        Try
            Dim parametro As Integer = 1
            Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_TableAdapter.Fill(Me.DataSetTablasYCampos.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_, New System.Nullable(Of Integer)(CType(parametro, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub SP_RequerimientosValorProvisional_EDICION_ACTUALIZAR(ByVal Texto As String)
        Try
            Dim parametro As Integer = 1
            Me.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RequerimientosValorProvisional_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(parametro, Integer)), Texto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'dfklñjasdklñfjasdlñkfjasdñklfjasdlñfjasñfjasdklñdf
    Function RemplazosDeTabla(ByVal Contenido As String, ByVal Tabla As String)
        Dim ContenidoGenerado As String = Contenido
        Dim ObjContenido As String = ""
        If InStr(Contenido, "{{{Tabla}}}") Then
            Contenido = Contenido.Replace("{{{Tabla}}}", Tabla)
        End If
        Return Contenido
    End Function
    Private Sub TablaIDTextBox1_TextChanged(sender As Object, e As EventArgs) Handles TablaIDTextBox1.TextChanged
        SP_CampoComponentes_Segun_Plantilla_Tipo_ComponenteID()
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1()
        SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1()
    End Sub

    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1()
        Try
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1, New System.Nullable(Of Integer)(CType(TablaIDTextBox1.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub AgregarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarTodasToolStripMenuItem.Click
        Dim contadorTecnologiasAplicadas = SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Rows.Count()
        'Carga las tecnologias aplicadas y segun pide los requerimientos de de las plantillas de dichas tecnologias
        While contadorTecnologiasAplicadas > 0
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.CurrentCell = SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Rows(0).Cells(0)
            SP_ProyectosYTecnologias_EDICION_INSERTAR()
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Rows.RemoveAt(0)
            contadorTecnologiasAplicadas = contadorTecnologiasAplicadas - 1
        End While
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        MsgBox("Se Crea Relación Del Proyecto " & NombreProyectoTextBox.Text & " con todas las Plantillas de la Tecnologia: " & NombreTecnologiaTextBox.Text, MsgBoxStyle.Information)
    End Sub

    Private Sub AgregarPlantillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPlantillaToolStripMenuItem.Click
        SP_ProyectosYTecnologias_EDICION_INSERTAR()
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        'MsgBox("Se Crea Relación Del Proyecto" & NombreProyectoTextBox.Text & " con la tecnologia " & NombreTecnologiaTextBox.Text, MsgBoxStyle.Information)
    End Sub


    Private Sub SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2()
        Try
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2TableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2()
        Try
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2, New System.Nullable(Of Integer)(CType(TI_.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TablaIDTextBox2_TextChanged(sender As Object, e As EventArgs) Handles TI_.TextChanged
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2()
    End Sub

    Private Sub Chk_Rel_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Rel.CheckedChanged
        If Chk_Rel.Checked = True Then
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Location = New Point(6, 103)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Location = New Point(6, 348)
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Width = 221
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Width = 221
            Nuevo_Menu_TablasDeProyecto.Enabled = False
            Editar_Menu_TablasDeProyecto.Enabled = False
        Else
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Location = New Point(6, 103)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Location = New Point(6, 348)
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Width = 451
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Width = 451
            Cancelar_TablasDeProyecto()
        End If
    End Sub



#Region "Relaciones Entre Tablas"
    'Busca si hay relaciones
    Private Sub SP_RegistroRelacionesTablas_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTI()
        'Try
        '    Me.SP_RegistroRelacionesTablas_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroRelacionesTablas_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTI,
        '                                                                                           New System.Nullable(Of Integer)(CType(TD_.Text, Integer)),
        '                                                                                           New System.Nullable(Of Integer)(CType(CTD_.Text, Integer)),
        '                                                                                           New System.Nullable(Of Integer)(CType(TI_.Text, Integer)),
        '                                                                                           New System.Nullable(Of Integer)(CType(CTI_.Text, Integer)))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub SP_RegistroRelacionesTablas_EDICION_INSERTAR()
        Try
            Me.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroRelacionesTablas_EDICION_INSERTAR, New System.Nullable(Of Integer)(CType(TD_.Text, Integer)), New System.Nullable(Of Integer)(CType(CTD_.Text, Integer)), New System.Nullable(Of Integer)(CType(TI_.Text, Integer)), New System.Nullable(Of Integer)(CType(CTI_.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CrearRelacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearRelacionToolStripMenuItem.Click
        ValidandoRelacion()
    End Sub
    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.CellMouseDoubleClick
        ValidandoRelacion()
    End Sub

    Private Sub ValidandoRelacion()
        If Chk_Rel.Checked = True Then
            SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTI()
            If RegistroRelacionesTablasIDTextBox.Text = "" Then
                'TODO: Pendiente definir cuando se tenga la administracion de los tipos de datos
                If TipoCTD.Text = "numeric" Or TipoCTD.Text = "numeric (Clave)" Or TipoCTD.Text = "numeric (Relacionado)" Then
                    If TipoCTI.Text = "numeric" Or TipoCTI.Text = "numeric (Clave)" Or TipoCTI.Text = "numeric (Relacionado)" Then
                        SP_RegistroRelacionesTablas_EDICION_INSERTAR()
                        MsgBox("Relacion entre las dos Tablas Creada Exitosamente", MsgBoxStyle.Information)
                        SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD()
                        TabPage3.BackColor = Color.Cornsilk
                    End If
                Else
                    MsgBox("Los tipos de datos de los campos de esta relación no son correctos, verifica el tipo de dato", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Esta Relación entre tablas ya fue creada", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub



    Private Sub SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTI()
        Try
            Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTI,
                                                                                                         New System.Nullable(Of Integer)(CType(TD_.Text, Integer)),
                                                                                                         New System.Nullable(Of Integer)(CType(CTD_.Text, Integer)),
                                                                                                         New System.Nullable(Of Integer)(CType(TI_.Text, Integer)),
                                                                                                         New System.Nullable(Of Integer)(CType(CTI_.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_RegistroRelacionesTablas_EDICION_ELIMINAR()
        Try
            Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroRelacionesTablas_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(RegistroRelacionesTablasIDTextBox1.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub EliminarRelaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRelaciónToolStripMenuItem.Click
        If RegistroRelacionesTablasIDTextBox1.Text = "" Then
            MsgBox("No Existe una relacion a Eliminar", MsgBoxStyle.Exclamation)
        Else
            SP_RegistroRelacionesTablas_EDICION_ELIMINAR()
            MsgBox("Relación Eliminada Exitosamente!!!", MsgBoxStyle.Exclamation)
            SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD()
            TabPage3.BackColor = Color.Transparent
        End If

    End Sub

    Private Sub TD__TextChanged(sender As Object, e As EventArgs) Handles TD_.TextChanged
        SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD()
        'Cambiar el color del control cuando se tengan relaciones con tablas
        If SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Rows.Count > 0 Then
            TabPage3.BackColor = Color.Cornsilk
        Else
            TabPage3.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD()
        Try
            Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD, New System.Nullable(Of Integer)(CType(TD_.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.CellMouseDoubleClick
        SP_RegistroRelacionesTablas_EDICION_ELIMINAR()
        MsgBox("Relación Eliminada Exitosamente!!!", MsgBoxStyle.Exclamation)
        SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD()
        TabPage3.BackColor = Color.Transparent
    End Sub

    Private Sub SP_CARGA_TablasRelacionadas_SEGUN_PlantillaID()
        Try
            Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaIDTextBox1.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    'Carga las relaciones de la tabla
    Private Sub SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1()
        Try
            Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1TableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1, New System.Nullable(Of Integer)(CType(TablaIDTextBox1.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Function RecorreTablasRelacionadas()
        Dim CamposRelacionados As String = ""
        Dim contadorTablasRelacionadas = SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Rows.Count()
        'Carga las tecnologias aplicadas y segun pide los requerimientos de de las plantillas de dichas tecnologias
        While contadorTablasRelacionadas > 0
            'Se ubica en la primera fila
            SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.CurrentCell = SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Rows(0).Cells(0)
            CamposRelacionados = CamposRelacionados & GenerarRelacionTabla(ContenidoRelacionTextBox.Text) & vbCrLf
            SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Rows.RemoveAt(0)
            contadorTablasRelacionadas = contadorTablasRelacionadas - 1
        End While
        'Vuelve y carga las tecnologias aplicadas
        SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1()
        Return CamposRelacionados
    End Function


    Function GenerarRelacionTabla(contenido As String)
        Dim ContenidoGenerado As String = contenido
        If InStr(ContenidoRelacionTextBox.Text, "{{{Tabla_Dep}}}") Then
            ContenidoGenerado = contenido.Replace("{{{Tabla_Dep}}}", TablaDependienteTextBox1.Text)
        End If
        If InStr(ContenidoRelacionTextBox.Text, "{{{Campo_Dep}}}") Then
            ContenidoGenerado = ContenidoGenerado.Replace("{{{Campo_Dep}}}", CampoDependienteTextBox1.Text)
        End If
        If InStr(ContenidoRelacionTextBox.Text, "{{{Tabla_Ind}}}") Then
            ContenidoGenerado = ContenidoGenerado.Replace("{{{Tabla_Ind}}}", TablaIndependienteTextBox1.Text)
        End If
        If InStr(ContenidoRelacionTextBox.Text, "{{{Campo_Ind}}}") Then
            ContenidoGenerado = ContenidoGenerado.Replace("{{{Campo_Ind}}}", CampoIndependienteTextBox1.Text)
        End If
        Return ContenidoGenerado
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RecorreTablasRelacionadas()
    End Sub

    Private Sub EnunciadoTextBox_TextChanged(sender As Object, e As EventArgs) Handles EnunciadoTextBox.TextChanged
        Try
            EnunciadoEnRich.Text = EnunciadoTextBox.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CM_EliminandoTecnologias_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CM_EliminandoTecnologias.Opening

    End Sub

    Private Sub MaximizarPaneles_Click(sender As Object, e As EventArgs) Handles MaximizarPaneles.Click
        TabControl1.Location = New Point(8, 52)
        TabControl1.Height = 535
    End Sub

    Private Sub MinimizarPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarPToolStripMenuItem.Click
        TabControl1.Location = New Point(8, 403)
        TabControl1.Height = 187
    End Sub

    Private Sub ValorRequerimientoTextBox3_TextChanged(sender As Object, e As EventArgs) Handles ValorRequerimientoTextBox3.TextChanged
        Try
            ValorRequerimiento.Text = ValorRequerimientoTextBox3.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MaximizarPanelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizarPanelesToolStripMenuItem.Click
        TabControl1.Location = New Point(8, 52)
        TabControl1.Height = 535
    End Sub

    Private Sub MinimizarPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MinimizarPToolStripMenuItem1.Click
        TabControl1.Location = New Point(8, 403)
        TabControl1.Height = 187
    End Sub

    Private Sub Btn_Maximizar_Click(sender As Object, e As EventArgs) Handles Btn_Maximizar.Click
        If Btn_Maximizar.Text = "+" Then
            Btn_Maximizar.Text = "-"
            TabControl1.Location = New Point(8, 52)
            TabControl1.Height = 535
        Else
            If Btn_Maximizar.Text = "-" Then
                Btn_Maximizar.Text = "+"
                TabControl1.Location = New Point(8, 403)
                TabControl1.Height = 187
                SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnExplorar.Click
        PanelConf.BringToFront()
        PanelConf.Dock = DockStyle.Fill
    End Sub

    Private Sub SP_CampoComponentes_Segun_Plantilla_Tipo_ComponenteID()
        Try
            Me.SP_CampoComponentes_Segun_Plantilla_Tipo_ComponenteIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CampoComponentes_Segun_Plantilla_Tipo_ComponenteID,
                                                                                      New System.Nullable(Of Integer)(CType(PlantillaIDTextBox1.Text, Integer)),
                                                                                      TipoTextBox1.Text,
                                                                                      New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnAmpliar_Click(sender As Object, e As EventArgs) Handles BtnAmpliar.Click
        If BtnAmpliar.BackColor = Color.White Then
            BtnAmpliar.BackColor = Color.GreenYellow
            CodigoGeneradoRichTextBox.BringToFront()
            CodigoGeneradoRichTextBox.Dock = DockStyle.Fill
        Else
            If BtnAmpliar.BackColor = Color.GreenYellow Then
                BtnAmpliar.BackColor = Color.White
                CodigoGeneradoRichTextBox.SendToBack()
                CodigoGeneradoRichTextBox.Dock = DockStyle.None
            End If
        End If
    End Sub

    Private Sub BtnRequerimientos_Click(sender As Object, e As EventArgs) Handles BtnRequerimientos.Click
        If BtnRequerimientos.BackColor = Color.White Then
            BtnRequerimientos.BackColor = Color.GreenYellow
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.BringToFront()
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Height = 600
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Location = New Point(440, 0)
        Else
            BtnRequerimientos.BackColor = Color.White
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.SendToBack()
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Height = 109
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Location = New Point(454, 498)
        End If
    End Sub

    Private Sub SP_PlantillasImagenes_BUSCA_SEGUN_PlantillaID()
        Try
            Me.SP_PlantillasImagenes_BUSCA_SEGUN_PlantillaIDTableAdapter.Fill(Me.DataSetReportes.SP_PlantillasImagenes_BUSCA_SEGUN_PlantillaID,
                                                                              New System.Nullable(Of Integer)(CType(PlantillaIDCargaImagenes.Text, Integer)))

        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub PlantillaIDCargaImagenes_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIDCargaImagenes.TextChanged
        SP_PlantillasImagenes_BUSCA_SEGUN_PlantillaID()
    End Sub





    Private Sub SP_ProyectoDocumentoTecnico_EDICION_INSERTAR(ByVal Codigo As String, ByVal Imagen As Byte())
        Try

            Me.SP_ProyectoDocumentoTecnico_EDICION_INSERTARTableAdapter.Fill(Me.DataSetReportes.SP_ProyectoDocumentoTecnico_EDICION_INSERTAR,
                                                                             New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                                             Codigo,
                                                                             Imagen)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
#Region "Valida si se aplica o no la creacion de carpetas y archivos segun tecnologia"
    Private Sub TecnologiaIDTextBox1_TextChanged(sender As Object, e As EventArgs) Handles TecnologiaIDTextBox1.TextChanged
        SP_TecnologiasConCreacion_BUSQUEDA_SEGUN_Id()
    End Sub
    Private Sub SP_TecnologiasConCreacion_BUSQUEDA_SEGUN_Id()
        Try
            Me.SP_TecnologiasConCreacion_BUSQUEDA_SEGUN_IdTableAdapter.Fill(Me.DataSetAdministracion.SP_TecnologiasConCreacion_BUSQUEDA_SEGUN_Id, New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox1.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub BtnCreacion_Click(sender As Object, e As EventArgs) Handles BtnCreacion.Click
        If RBNuevo.Checked = True Or RBExistente.Checked = True Then
            If ChkGenerarCarpetasYArchivos.Checked = True Then
                If RutaUbicacion.Text <> "" Then
                    If SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Rows.Count > 0 Then
                        If SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.Count > 0 Then
                            If NombreRequerimientoFuncionalTextBox.Text <> "" Then
                                validarNombreAplicacion(NombreRequerimientoFuncionalTextBox.Text)
                            Else
                                MsgBox("Deberia existir un nombre o requisito funcional para la creacion de carpetas y archivos, favor verificar", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Para realizar esta acción deberas tener una lista de requerimientos, favor verificar", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("No existen rutas definidas para este proyecto, debera generarlas primero", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("El proyecto " & NombreProyectoTextBox.Text & " Deberas asignarle una ruta de ubicación", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("No has chekeado que deseas generar la creación de carpetas y archivos", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("No has seleccionado el tipo de aplicacion que deseas construir, ya sea un proyecto ya creado o nuevo", MsgBoxStyle.Exclamation)
        End If
        MsgBox("Creación de proyecto finalizada...", MsgBoxStyle.Information)
        RutaUbicacion.Text = ""
    End Sub

    Private Sub validarNombreAplicacion(ByVal nombreRequerimientoFuncional As String)
        Dim contador As Integer = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.Count
        Dim req As Boolean = False
        Dim remplaza As Boolean
        While contador > 0
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.CurrentCell = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows(0).Cells(0)
            If RequerimientoTextBox3.Text = nombreRequerimientoFuncional Then ' Aqui verificamos que exista un nombre para la aplicacion
                If RBNuevo.Checked = True Then
                    RutaUbicacion.Text = RutaUbicacion.Text + "\" + ValorRequerimientoTextBox4.Text
                    If Directory.Exists(RutaUbicacion.Text) = Nothing Then
                        If Directory.Exists(RutaUbicacion.Text) = Nothing Then
                            If MsgBox("Se crearan en " & RutaUbicacion.Text & " todos los archivos para este proyecto, desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                remplaza = False
                                GenerarProyecto(remplaza)
                            Else
                                MsgBox("Se cancelo la instrucción", MsgBoxStyle.Information)
                            End If
                        End If
                    Else
                        MsgBox("Este proyecto que se desea construir como 'NUEVO' ya existe, favor verificar", MsgBoxStyle.Exclamation)
                    End If
                End If
                If RBExistente.Checked = True Then
                    If Directory.Exists(RutaUbicacion.Text) Then
                        If MsgBox("Se crearan en " & RutaUbicacion.Text & " todos los archivos para este proyecto, desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            remplaza = True
                            GenerarProyecto(remplaza)
                        Else
                            MsgBox("Se cancelo la instrucción", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("Este proyecto que se desea construir como 'EXISTENTE' No fue posible encontrarlo, favor verificar", MsgBoxStyle.Exclamation)
                    End If
                End If
                SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
                req = True
                Exit While
            End If
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.RemoveAt(0)
            contador = contador - 1
        End While
        SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
        If req = False Then
            MsgBox("El proyecto " & NombreProyectoTextBox.Text & " Debe de cumplir con el requerimiento => **" & nombreRequerimientoFuncional & "** para la creacion de archivos, y este no se encuentra en la lista de requerimientos, favor verificar ", MsgBoxStyle.Critical)
        End If
    End Sub
    Public Sub GenerarProyecto(ByVal remplaza As Boolean)
        RecorrePlantillasEliminandoArchivos()
        Dim cantRutas As Integer = 0
        Dim rutaConcatenada As String
        cantRutas = SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Rows.Count
        While cantRutas > 0
            SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.CurrentCell = SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Rows(0).Cells(0)
            rutaConcatenada = RutaUbicacion.Text & "\" & RutaCrear.Text
            tratamientoRuta(RutaCrear.Text, RutaUbicacion.Text)
            If remplaza = True Then
                GenerarYRemplazarArchivo(rutaConcatenada, NombreArchivoCrear.Text, ContenidoCrear.Text)
            End If
            If remplaza = False Then
                GenerarArchivo(rutaConcatenada, NombreArchivoCrear.Text, ContenidoCrear.Text)
            End If
            SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Rows.RemoveAt(0)
            cantRutas = cantRutas - 1
        End While
        SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
    End Sub
    Private Sub tratamientoRuta(ByVal ruta As String, ByVal rutaBase As String)
        Dim Directorio() As String
        Dim rutaVerificar As String = rutaBase
        Directorio = ruta.Split("\")
        For i = 0 To Directorio.Length - 1
            rutaVerificar = rutaVerificar & "\" & Directorio(i)
            If (My.Computer.FileSystem.DirectoryExists(rutaVerificar) = False) Then
                My.Computer.FileSystem.CreateDirectory(rutaVerificar)
            End If
        Next
    End Sub
    Private Sub GenerarArchivo(ByVal Ruta As String, ByVal Archivo As String, ByVal Contenido As String)
        My.Computer.FileSystem.WriteAllText(Ruta + "\" + Archivo, Contenido, True)
    End Sub

    Private Sub GenerarYRemplazarArchivo(ByVal Ruta As String, ByVal Archivo As String, ByVal Contenido As String)
        ModuloReplace.GenerarYRemplazar(Ruta, Archivo, Contenido)
    End Sub

    Private Sub BtnCargaRuta_Click(sender As Object, e As EventArgs) Handles BtnCargaRuta.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            RutaUbicacion.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID()
        Try
            If ComponenteIDTextBox.Text = "" Then
                ComponenteIDTextBox.Text = "0"
            End If
            Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter.Fill(Me.DataSetAdministracion.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID,
                                                                                                      New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID_Metodo(ByVal ComponenteId As Integer)
        Try
            Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter.Fill(Me.DataSetAdministracion.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID,
                                                                                                      New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID()
        Try
            If PlantillaIDTextBox1.Text = "" Then
                PlantillaIDTextBox1.Text = "0"
            End If
            Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID,
                                                                                                     New System.Nullable(Of Integer)(CType(PlantillaIDTextBox1.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_ProyectoCarpetasArchivos_EDICION_INSERTAR(ByVal Ruta As String, ByVal NombreArchivo As String, ByVal Contenido As String)
        Try
            Me.SP_ProyectoCarpetasArchivos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectoCarpetasArchivos_EDICION_INSERTAR,
                                                                             New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                                             Ruta, NombreArchivo,
                                                                             Contenido)
            SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnReiniciarCreacion_Click(sender As Object, e As EventArgs) Handles BtnReiniciarCreacion.Click
        SP_ProyectoCarpetasArchivos_EDICION_ELIMINAR_SEGUN_ProyectoID()
    End Sub

    Private Sub SP_ProyectoCarpetasArchivos_EDICION_ELIMINAR_SEGUN_ProyectoID()
        Try
            Me.SP_ProyectoCarpetasArchivos_EDICION_ELIMINAR_SEGUN_ProyectoIDTableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectoCarpetasArchivos_EDICION_ELIMINAR_SEGUN_ProyectoID, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
            SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
        Try
            Me.SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectoCarpetasArchivos_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ContenidoCrear_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ContenidoCrear.MouseDoubleClick
        ContenidoCrear.BringToFront()
        ContenidoCrear.Dock = DockStyle.Fill
        BtnCodigoRuta.BackColor = Color.GreenYellow
    End Sub



    Private Sub BtnCodigoRuta_Click(sender As Object, e As EventArgs) Handles BtnCodigoRuta.Click
        If BtnCodigoRuta.BackColor = Color.White Then
            BtnCodigoRuta.BackColor = Color.GreenYellow
            ContenidoCrear.BringToFront()
            ContenidoCrear.Dock = DockStyle.Fill
        Else
            BtnCodigoRuta.BackColor = Color.White
            ContenidoCrear.BringToFront()
            ContenidoCrear.Dock = DockStyle.None
        End If
    End Sub






    Private Sub SP_ComponenteArchivoEliminar_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId()
        Try
            Me.SP_ComponenteArchivoEliminar_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetAdministracion.SP_ComponenteArchivoEliminar_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId, New System.Nullable(Of Integer)(CType(ComponenteIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComponenteIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ComponenteIDTextBox.TextChanged
        SP_ComponenteArchivoEliminar_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId()
    End Sub

    Public Sub RecorrePlantillasEliminandoArchivos()
        Dim contadorTecnologiasAplicadas = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.Count()
        'Carga las tecnologias aplicadas y segun pide los requerimientos de de las plantillas de dichas tecnologias
        While contadorTecnologiasAplicadas > 0
            'Se ubica en la primera fila
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.CurrentCell = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows(0).Cells(0)
            EliminarCarpetasArchivos()
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.RemoveAt(0)
            contadorTecnologiasAplicadas = contadorTecnologiasAplicadas - 1
        End While
        'Vuelve y carga las tecnologias aplicadas
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
    End Sub


    Public Sub EliminarCarpetasArchivos()
        Dim contador As Integer
        contador = SP_ComponenteArchivoEliminar_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.Count
        While contador > 0
            SP_ComponenteArchivoEliminar_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentCell = SP_ComponenteArchivoEliminar_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(0).Cells(0)
            If RutaArchivoTextBox.Text <> "" Then
                RutaProcesada = RutaUbicacion.Text & "\" & RutaArchivoTextBox.Text
                RutaProcesada = RemplazaRequerimientos(RutaProcesada)
                Eliminar_Archivo(RutaProcesada)
            End If
            SP_ComponenteArchivoEliminar_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.RemoveAt(0)
            contador = contador - 1
        End While
        SP_ComponenteArchivoEliminar_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId()
    End Sub

    Public Sub Eliminar_Archivo(Path As String)
        If File.Exists(Path) Then
            My.Computer.FileSystem.DeleteFile(Path)
        End If
    End Sub
    Public Sub Eliminar_Directorio(Path As String)
        My.Computer.FileSystem.DeleteDirectory(Path, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub






















#End Region
End Class