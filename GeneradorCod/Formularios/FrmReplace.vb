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
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'RTC
    Private Sub BtnBuscarYPintar_Click(sender As Object, e As EventArgs) Handles BtnBuscarYPintar.Click
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
                    SP_RegistroValorRequerimientos_EDICION_INSERTAR()
                    'Elimina la fila del grid
                    SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
                    'Descuenta del Contador
                    contadorRequerimientos = contadorRequerimientos - 1
                End If
            Else
                'Inserta el mismo valor que ha trabajado
                ValorRequerimientoTextBox.Text = ValorRequerimientoTextBox2.Text
                'Guarda el Valor del Requerimiento
                SP_RegistroValorRequerimientos_EDICION_INSERTAR()
                SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
                ''Descuenta del Contador
                contadorRequerimientos = contadorRequerimientos - 1
            End If
        End While
    End Sub

    Private Sub BtnRemplazar_Click(sender As Object, e As EventArgs) Handles BtnRemplazar.Click
        'Limpia
        CodigoGeneradoTextBox.Text = ""
        'Cuenta las tecnologias aplicadas al proyecto
        Dim contadorTecnologiasAplicadas = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.Count()
        'Recorre el grid con las tecnologias aplicadas
        While contadorTecnologiasAplicadas > 0
            'Se ubica en la primera fila
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.CurrentCell = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows(0).Cells(0)
            RecorrerComponentesHaciendoReplace()
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.RemoveAt(0)
            contadorTecnologiasAplicadas = contadorTecnologiasAplicadas - 1
            PrefijoTextBox.Text = ""
            SufijoTextBox.Text = ""
            SuperiorTextBox.Text = ""
            InferiorTextBox.Text = ""
            MultiReplaceTextBox.Text = ""
            SP_CampoComponentes_Segun_Plantilla_TipoTable()
        End While
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
    End Sub
    Public Sub RecorrerComponentesHaciendoReplace()
        Dim contadorComponentes = SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count()
        While contadorComponentes > 0
            'Se ubica en la primera fila
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.CurrentCell = SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows(0).Cells(0)
            If XTablaCheckBox.Checked = False Then
                CodigoGeneradoTextBox.Text = CodigoGeneradoTextBox.Text & vbCrLf & "                              " & NombreTecnologiaTextBox1.Text & vbCrLf & NombreComponenteTextBox.Text & vbCrLf & CodigoTextBox.Text & vbCrLf & "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" & vbCrLf & vbCrLf
            Else
                CodigoGeneradoTextBox.Text = CodigoGeneradoTextBox.Text & vbCrLf & NombreComponenteTextBox.Text & TablasDeAplicacion(CodigoTextBox.Text) & vbCrLf & "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" & vbCrLf & vbCrLf
            End If
            SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
            contadorComponentes = contadorComponentes - 1
        End While
        RemplazarEnResultado(CodigoGeneradoTextBox.Text, NombreTablaTextBox1.Text)
    End Sub

    Public Sub RemplazarEnResultado(textoBase As String, NombreTabla As String)
        'Remplaza los Requerimientos
        CargaRequerimientos()
        'Guarda la informacion
        SP_Proyectos_EDICION_ACTUALIZAR_CodigoRemplazado()
    End Sub

    Private Sub CargaRequerimientos()
        Dim contadorRequerimientos = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.Count
        While contadorRequerimientos > 0
            'Se ubica en la primera fila
            SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.CurrentCell = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows(0).Cells(0)
            CodigoGeneradoTextBox.Text = CodigoGeneradoTextBox.Text.Replace(RequerimientoTextBox1.Text, ValorRequerimientoTextBox1.Text)
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
                                                 CodigoGeneradoTextBox.Text,
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
        Return Campos
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1()
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
        'Carga los registros de Parametros del Proyecto ya ingresados
        SP_RegistroValorRequerimientos_SEGUN_ProyectoID()
        'Carga las tecnologias aplicadas al proyecto
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        'Carga Tablas del Proyecto
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID()
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2()
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1_RepetirTablas()
    End Sub

#Region "Proyectos y Tecnologias"
    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.CellMouseDoubleClick
        'Inserta la relacion entre el proyecto y la tecnologia aplicada al mismo
        SP_ProyectosYTecnologias_EDICION_INSERTAR()
        'Carga las tecnologias aplicadas al proyecto
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        MsgBox("Se Crea Relación Del Proyecto" & NombreProyectoTextBox.Text & " con la tecnologia " & NombreTecnologiaTextBox.Text, MsgBoxStyle.Information)
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
        ELIMINA_SEGUN_PROYECTO()
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO()
        MsgBox("Se Elimino Relacion", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub TecnologiaID_EliminaRelacion_TextChanged(sender As Object, e As EventArgs) Handles TecnologiaID_EliminaRelacion.TextChanged
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia()
    End Sub


#Region "Registro Valores de Requerimientos de Plantillas"
    'Inserta valores de los requerimientos de las plantillas de la tecnologia asignada al proyecto
    Private Sub SP_RegistroValorRequerimientos_EDICION_INSERTAR()
        Try
            Me.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroValorRequerimientos_EDICION_INSERTAR,
                                                                                New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                                                RequerimientoTextBox.Text,
                                                                                ValorRequerimientoTextBox.Text)
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
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Location = New Point(708, 117)
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Location = New Point(708, 362)
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Width = 358
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Width = 358
    End Sub
    'Insertar
    Private Sub SP_TablasDeProyecto_EDICION_INSERTAR()
        Try
            Me.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                 NombreTablaTextBox.Text)
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
                                                 NombreTablaTextBox.Text)
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
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub NombreTablaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTablaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_TablasDeProyecto.Enabled = True Then
                Actualizar_Menu_TablasDeProyecto.Enabled = True
                Eliminar_Menu_TablasDeProyecto.Enabled = True
            Else
                If NombreTablaTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    NombreTablaTextBox.Text = ""
                    NombreTablaTextBox.Focus()
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
    End Sub
    Public Sub Desbloquear_Objetos_TablasDeProyecto()
        NombreTablaTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_TablasDeProyecto()
        NombreTablaTextBox.Enabled = False
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
                                                 Cbo_TipoDato.Text,
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
                                                 Cbo_TipoDato.Text,
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
            Case Cbo_TipoDato.Text = ""
                MsgBox("El nombre del campo: TablaID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                Cbo_TipoDato.BackColor = Color.Beige
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
                Cbo_TipoDato.Enabled = True
                Cbo_TipoDato.Focus()
            End If
        End If
    End Sub
    Private Sub Cbo_TipoDato_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbo_TipoDato.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_CamposDeTablas.Enabled = True Then
                Actualizar_Menu_CamposDeTablas.Enabled = True
                Eliminar_Menu_CamposDeTablas.Enabled = True
            Else
                If Cbo_TipoDato.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    Cbo_TipoDato.Text = ""
                    Cbo_TipoDato.Focus()
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
        Cbo_TipoDato.Text = ""
    End Sub
    Public Sub Desbloquear_Objetos_CamposDeTablas()
        NombreCampoTextBox.Enabled = True
        Cbo_TipoDato.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_CamposDeTablas()
        NombreCampoTextBox.Enabled = False
        Cbo_TipoDato.Enabled = False
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
        Cbo_TipoDato.Text = TipoTextBox.Text
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
    End Sub
    Private Sub NombreCampoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreCampoTextBox.TextChanged
        SP_CampoComponentes_Segun_Plantilla_TipoTable()
    End Sub

    Private Sub CodigoGeneradoTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles CodigoGeneradoTextBox.MouseDoubleClick
        CodigoGeneradoTextBox.SendToBack()
        CodigoGeneradoTextBox.Dock = DockStyle.None
    End Sub

    Private Sub MaximizarCodigoGeneradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizarCodigoGeneradoToolStripMenuItem.Click
        CodigoGeneradoTextBox.BringToFront()
        CodigoGeneradoTextBox.Dock = DockStyle.Fill
    End Sub

#End Region


    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        If CodigoGeneradoTextBox.Text <> "" Then
            Clipboard.SetText(CodigoGeneradoTextBox.Text)
        End If
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        CodigoGeneradoTextBox.Text = ""
        SP_Proyectos_EDICION_ACTUALIZAR_CodigoRemplazado()
    End Sub
    Private Sub SP_RegistroValorRequerimientos_SegunProyectoRequerimiento()
        Try
            Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroValorRequerimientos_SegunProyectoRequerimiento, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)), RequerimientoTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function TablasDeAplicacion(Contenido As String)
        'carga las tablas que tenga el proyecto
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1_RepetirTablas()
        'Cuenta las tablas que hay
        Dim contadorTablasSistema = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Rows.Count()
        Dim textoDeTablas As String = ""
        'Carga las tecnologias aplicadas y segun pide los requerimientos de de las plantillas de dichas tecnologias
        While contadorTablasSistema > 0
            'Se ubica en la primera fila
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.CurrentCell = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Rows(0).Cells(0)
            textoDeTablas = textoDeTablas & RemplazosDeTodasTablas(Contenido, NombreTablaTextBox2.Text) & vbCrLf
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Rows.RemoveAt(0)
            contadorTablasSistema = contadorTablasSistema - 1
        End While
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1_RepetirTablas()
        Return textoDeTablas
    End Function
    Private Sub SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1_RepetirTablas()
        Try
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Function RemplazosDeTodasTablas(Contenido As String, Tabla As String)
        Dim ContenidoGenerado As String = Contenido
        Dim ObjContenido As String = ""
        If InStr(Contenido, "{{{Tabla}}}") Then
            ContenidoGenerado = CargarTabla(Contenido, Tabla)
        End If
        If InStr(Contenido, "{{{Tmin}}}") Then
            ContenidoGenerado = CargarTablaMinuscula(ContenidoGenerado, Tabla)
        End If
        If InStr(Contenido, "{{{TPlur}}}") Then
            ContenidoGenerado = CargarTablaEnPlural(ContenidoGenerado, Tabla)
        End If
        If InStr(Contenido, "{{{TPlurMin}}}") Then
            ContenidoGenerado = CargarTablaEnPluralMinus(ContenidoGenerado, Tabla)
        End If
        If InStr(Contenido, "{{{A=>-a}}}") Then
            ContenidoGenerado = ConvertirMayusculasMinSeparadasPorGuion(ContenidoGenerado, Tabla)
        End If
        If InStr(Contenido, "{{{Clave}}}") Then
            Dim Clave = GenerarClave()
            ContenidoGenerado = ContenidoGenerado.Replace("{{{Clave}}}", Clave)
        End If
        If Not InStr(Contenido, "{{{Campos}}}") Then
            Dim Campos = GenerarCampos()
            ContenidoGenerado = ContenidoGenerado.Replace("{{{Campos}}}", Campos)
        End If
        Return ContenidoGenerado
    End Function
    Private Sub TablaIDTextBox1_TextChanged(sender As Object, e As EventArgs) Handles TablaIDTextBox1.TextChanged
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1()
    End Sub

    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1()
        Try
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1, New System.Nullable(Of Integer)(CType(TablaIDTextBox1.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub RemplazarEnResultadoPorTabla(textoBase As String, nombreTabla As String)

        'Remplaza los Requerimientos
        CargaRequerimientos()
        'Guarda la informacion
        SP_Proyectos_EDICION_ACTUALIZAR_CodigoRemplazado()

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
        MsgBox("Se Crea Relación Del Proyecto" & NombreProyectoTextBox.Text & " con la tecnologia " & NombreTecnologiaTextBox.Text, MsgBoxStyle.Information)
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
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2, New System.Nullable(Of Integer)(CType(TablaIDTextBox2.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TablaIDTextBox2_TextChanged(sender As Object, e As EventArgs) Handles TablaIDTextBox2.TextChanged
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2()
    End Sub

    Private Sub Chk_Rel_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Rel.CheckedChanged
        If Chk_Rel.Checked = True Then
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Location = New Point(708, 117)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Location = New Point(708, 362)
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Width = 174
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Width = 174
            Nuevo_Menu_TablasDeProyecto.Enabled = False
            Editar_Menu_TablasDeProyecto.Enabled = False
        Else
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Location = New Point(708, 117)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Location = New Point(708, 362)
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Width = 358
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Width = 358
            Cancelar_TablasDeProyecto()
        End If
    End Sub
End Class