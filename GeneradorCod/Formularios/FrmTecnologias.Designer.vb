<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTecnologias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreTecnologiaLabel As System.Windows.Forms.Label
        Dim TecnologiaIDLabel As System.Windows.Forms.Label
        Dim NombrePlantillaLabel As System.Windows.Forms.Label
        Dim NombreComponenteLabel As System.Windows.Forms.Label
        Dim RequerimientoLabel As System.Windows.Forms.Label
        Dim OrdenDePeticionLabel As System.Windows.Forms.Label
        Dim EnunciadoLabel As System.Windows.Forms.Label
        Dim CampoComponenteIDLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim PrefijoLabel As System.Windows.Forms.Label
        Dim SuperiorLabel As System.Windows.Forms.Label
        Dim SufijoLabel As System.Windows.Forms.Label
        Dim InferiorLabel As System.Windows.Forms.Label
        Dim SeparadorCamposLabel As System.Windows.Forms.Label
        Dim MultiReplaceLabel As System.Windows.Forms.Label
        Dim CONVENSIONESLabel As System.Windows.Forms.Label
        Dim XTablaLabel As System.Windows.Forms.Label
        Dim XTablaLabel1 As System.Windows.Forms.Label
        Dim OrdenLabel As System.Windows.Forms.Label
        Dim ContenidoRelacionLabel As System.Windows.Forms.Label
        Dim RelacionTablasIDLabel As System.Windows.Forms.Label
        Dim TextoEnriquecidoIDLabel As System.Windows.Forms.Label
        Dim RequerimientoLabel1 As System.Windows.Forms.Label
        Dim ValidadaLabel As System.Windows.Forms.Label
        Dim ValidadaLabel1 As System.Windows.Forms.Label
        Dim XBaseLabel As System.Windows.Forms.Label
        Dim XBaseLabel1 As System.Windows.Forms.Label
        Dim NombreComponenteLabel1 As System.Windows.Forms.Label
        Dim ComponenteIDLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTecnologias))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TecnologiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Validada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TecnologiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAdministracion = New GeneradorCod.DataSetAdministracion()
        Me.NombreTecnologiaTextBox = New System.Windows.Forms.TextBox()
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.Editar_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.TecnologiaIDTextBox = New System.Windows.Forms.TextBox()
        Me.ControlNulos = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ValidadaCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVEdicionPosicion = New System.Windows.Forms.DataGridView()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView = New System.Windows.Forms.DataGridView()
        Me.Orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdenTextBox = New System.Windows.Forms.TextBox()
        Me.NombrePlantillaTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ChkMover = New System.Windows.Forms.CheckBox()
        Me.BtnBajarFila = New System.Windows.Forms.Button()
        Me.Nuevo_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.BtnSubirFila = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.Editar_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.PlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.Nuevo_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Editar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnVerCodigo = New System.Windows.Forms.Button()
        Me.PanelComponenteBase = New System.Windows.Forms.Panel()
        Me.BtnReseteoBase = New System.Windows.Forms.Button()
        Me.BtnAsignarBase = New System.Windows.Forms.Button()
        Me.XBaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XTablaCheckBox = New System.Windows.Forms.CheckBox()
        Me.NombreComponenteTextBox = New System.Windows.Forms.TextBox()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComponenteIDTextBox = New System.Windows.Forms.TextBox()
        Me.TxtBuscado = New System.Windows.Forms.TextBox()
        Me.TxtRemplazarPor = New System.Windows.Forms.TextBox()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequerimientoTextBox = New System.Windows.Forms.TextBox()
        Me.OrdenDePeticionTextBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Nuevo_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.Editar_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.Guardar_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.RequerimientoPlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPanelControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnZoom = New System.Windows.Forms.Button()
        Me.ContenidoComponenteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ChkControlCambios = New System.Windows.Forms.CheckBox()
        Me.ContenidoComponenteCopia = New System.Windows.Forms.RichTextBox()
        Me.BtnTodasLasTablas = New System.Windows.Forms.Button()
        Me.PanelGuardado = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCamposRelacionados = New System.Windows.Forms.Button()
        Me.BtnTablaPluralMinuscula = New System.Windows.Forms.Button()
        Me.BtnMayusculaAMinuscula = New System.Windows.Forms.Button()
        Me.BtnTablaPlural = New System.Windows.Forms.Button()
        Me.BtnTablaMinuscula = New System.Windows.Forms.Button()
        Me.BtnImprimeClavePrincipal = New System.Windows.Forms.Button()
        Me.BtnImprimeTabla = New System.Windows.Forms.Button()
        Me.BtnImprimeCampos = New System.Windows.Forms.Button()
        Me.BtnGuardarCodigo = New System.Windows.Forms.Button()
        Me.BtnSubirRemplazado = New System.Windows.Forms.Button()
        Me.BtnLimpiarRemplazar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnRemplazar = New System.Windows.Forms.Button()
        Me.BtnBajarFuente = New System.Windows.Forms.Button()
        Me.BtnSubirFuente = New System.Windows.Forms.Button()
        Me.BtnBuscarYPintar = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.RichTextboxRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTablasYCampos = New GeneradorCod.DataSetTablasYCampos()
        Me.TextoEnriquecidoIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Nuevo_Menu_TextoEnriquecido = New System.Windows.Forms.Button()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.BtnDerecha = New System.Windows.Forms.Button()
        Me.BtnFuentes = New System.Windows.Forms.Button()
        Me.BtnCentrar = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_TextoEnriquecido = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_TextoEnriquecido = New System.Windows.Forms.Button()
        Me.Editar_Menu_TextoEnriquecido = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_TextoEnriquecido = New System.Windows.Forms.Button()
        Me.Guardar_Menu_TextoEnriquecido = New System.Windows.Forms.Button()
        Me.BtnIzquierda = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MultiReplaceTextBox = New System.Windows.Forms.TextBox()
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtPrevisualizar = New System.Windows.Forms.TextBox()
        Me.CboTiposDatos = New System.Windows.Forms.ComboBox()
        Me.TiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.SuperiorTextBox = New System.Windows.Forms.TextBox()
        Me.PrefijoTextBox = New System.Windows.Forms.TextBox()
        Me.InferiorTextBox = New System.Windows.Forms.TextBox()
        Me.SufijoTextBox = New System.Windows.Forms.TextBox()
        Me.SeparadorCamposTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultiReplace = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CM_TiposDatos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BtnPrevisualizar = New System.Windows.Forms.Button()
        Me.Nuevo_Menu_CampoComponentes = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_CampoComponentes = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_CampoComponentes = New System.Windows.Forms.Button()
        Me.Editar_Menu_CampoComponentes = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_CampoComponentes = New System.Windows.Forms.Button()
        Me.Guardar_Menu_CampoComponentes = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.EnunciadoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_CARGA_CONVENSIONES_USADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequerimientoTextBox1 = New System.Windows.Forms.TextBox()
        Me.RB_Todas = New System.Windows.Forms.RadioButton()
        Me.RB_Plantilla = New System.Windows.Forms.RadioButton()
        Me.CONVENSIONESTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ContenidoRelacionTextBox = New System.Windows.Forms.TextBox()
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_TablasRelacionadas = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_TablasRelacionadas = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_TablasRelacionadas = New System.Windows.Forms.Button()
        Me.Editar_Menu_TablasRelacionadas = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_TablasRelacionadas = New System.Windows.Forms.Button()
        Me.Guardar_Menu_TablasRelacionadas = New System.Windows.Forms.Button()
        Me.BtnCTI = New System.Windows.Forms.Button()
        Me.BtnCTD = New System.Windows.Forms.Button()
        Me.BtnTI = New System.Windows.Forms.Button()
        Me.BtnTD = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cbo_TipoDato = New System.Windows.Forms.ComboBox()
        Me.RelacionTablasIDTextBox = New System.Windows.Forms.TextBox()
        Me.NombreGrupoTipoDeDatoTextBox1 = New System.Windows.Forms.TextBox()
        Me.TipoCampoIDTextBox = New System.Windows.Forms.TextBox()
        Me.CampoComponenteIDTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.XTablaTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimerGuardarComponente = New System.Windows.Forms.Timer(Me.components)
        Me.TableAdapterManager1 = New GeneradorCod.DataSetTablasYCamposTableAdapters.TableAdapterManager()
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.SP_CampoComponentes_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter()
        Me.SP_CampoComponentes_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CampoComponentes_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CampoComponentes_EDICION_ELIMINARTableAdapter()
        Me.SP_CampoComponentes_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CampoComponentes_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CampoComponentes_EDICION_INSERTARTableAdapter()
        Me.SP_CARGA_CONVENSIONES_USADASTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CARGA_CONVENSIONES_USADASTableAdapter()
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.SP_TablasRelacionadas_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasRelacionadas_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasRelacionadas_EDICION_ACTUALIZARTableAdapter()
        Me.SP_TablasRelacionadas_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasRelacionadas_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasRelacionadas_EDICION_ELIMINARTableAdapter()
        Me.SP_TablasRelacionadas_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasRelacionadas_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasRelacionadas_EDICION_INSERTARTableAdapter()
        Me.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter()
        Me.SP_TextoEnriquecido_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TextoEnriquecido_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TextoEnriquecido_EDICION_ACTUALIZARTableAdapter()
        Me.SP_TextoEnriquecido_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TextoEnriquecido_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TextoEnriquecido_EDICION_ELIMINARTableAdapter()
        Me.SP_TextoEnriquecido_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TextoEnriquecido_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TextoEnriquecido_EDICION_INSERTARTableAdapter()
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLATableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLATableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TecnologiasTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.TecnologiasTableAdapter()
        Me.TableAdapterManager = New GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager()
        Me.SP_Tecnologias_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter()
        Me.SP_Tecnologias_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Tecnologias_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Tecnologias_EDICION_ELIMINARTableAdapter()
        Me.SP_Tecnologias_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Tecnologias_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Tecnologias_EDICION_INSERTARTableAdapter()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter()
        Me.SP_Plantillas_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Plantillas_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Plantillas_EDICION_ACTUALIZARTableAdapter()
        Me.SP_Plantillas_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Plantillas_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Plantillas_EDICION_ELIMINARTableAdapter()
        Me.SP_Plantillas_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Plantillas_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Plantillas_EDICION_INSERTARTableAdapter()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.SP_Componentes_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Componentes_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Componentes_EDICION_ACTUALIZARTableAdapter()
        Me.SP_Componentes_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Componentes_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Componentes_EDICION_ELIMINARTableAdapter()
        Me.SP_Componentes_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Componentes_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Componentes_EDICION_INSERTARTableAdapter()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter()
        Me.SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter()
        Me.SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter()
        Me.ValidadaTextBox = New System.Windows.Forms.TextBox()
        Me.TiposTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.TiposTableAdapter()
        Me.TiposDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CM_AccionesEdicion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MinimizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.XBaseTextBox = New System.Windows.Forms.TextBox()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseTableAdapter()
        Me.NombreComponenteTextBox1 = New System.Windows.Forms.TextBox()
        Me.ComponenteIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaTableAdapter()
        Me.PanelConfiguracion = New System.Windows.Forms.Panel()
        NombreTecnologiaLabel = New System.Windows.Forms.Label()
        TecnologiaIDLabel = New System.Windows.Forms.Label()
        NombrePlantillaLabel = New System.Windows.Forms.Label()
        NombreComponenteLabel = New System.Windows.Forms.Label()
        RequerimientoLabel = New System.Windows.Forms.Label()
        OrdenDePeticionLabel = New System.Windows.Forms.Label()
        EnunciadoLabel = New System.Windows.Forms.Label()
        CampoComponenteIDLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        PrefijoLabel = New System.Windows.Forms.Label()
        SuperiorLabel = New System.Windows.Forms.Label()
        SufijoLabel = New System.Windows.Forms.Label()
        InferiorLabel = New System.Windows.Forms.Label()
        SeparadorCamposLabel = New System.Windows.Forms.Label()
        MultiReplaceLabel = New System.Windows.Forms.Label()
        CONVENSIONESLabel = New System.Windows.Forms.Label()
        XTablaLabel = New System.Windows.Forms.Label()
        XTablaLabel1 = New System.Windows.Forms.Label()
        OrdenLabel = New System.Windows.Forms.Label()
        ContenidoRelacionLabel = New System.Windows.Forms.Label()
        RelacionTablasIDLabel = New System.Windows.Forms.Label()
        TextoEnriquecidoIDLabel = New System.Windows.Forms.Label()
        RequerimientoLabel1 = New System.Windows.Forms.Label()
        ValidadaLabel = New System.Windows.Forms.Label()
        ValidadaLabel1 = New System.Windows.Forms.Label()
        XBaseLabel = New System.Windows.Forms.Label()
        XBaseLabel1 = New System.Windows.Forms.Label()
        NombreComponenteLabel1 = New System.Windows.Forms.Label()
        ComponenteIDLabel = New System.Windows.Forms.Label()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdministracion_.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVEdicionPosicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PanelComponenteBase.SuspendLayout()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.TabPanelControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PanelGuardado.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_TiposDatos.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CARGA_CONVENSIONES_USADASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CARGA_CONVENSIONES_USADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CampoComponentes_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CampoComponentes_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CampoComponentes_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasRelacionadas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasRelacionadas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasRelacionadas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TextoEnriquecido_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TextoEnriquecido_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TextoEnriquecido_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Tecnologias_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Tecnologias_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Tecnologias_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_AccionesEdicion.SuspendLayout()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelConfiguracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreTecnologiaLabel
        '
        NombreTecnologiaLabel.AutoSize = True
        NombreTecnologiaLabel.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreTecnologiaLabel.Location = New System.Drawing.Point(10, 59)
        NombreTecnologiaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreTecnologiaLabel.Name = "NombreTecnologiaLabel"
        NombreTecnologiaLabel.Size = New System.Drawing.Size(104, 14)
        NombreTecnologiaLabel.TabIndex = 1
        NombreTecnologiaLabel.Text = "Nombre Tecnologia:"
        '
        'TecnologiaIDLabel
        '
        TecnologiaIDLabel.Location = New System.Drawing.Point(0, 0)
        TecnologiaIDLabel.Name = "TecnologiaIDLabel"
        TecnologiaIDLabel.Size = New System.Drawing.Size(100, 23)
        TecnologiaIDLabel.TabIndex = 155
        '
        'NombrePlantillaLabel
        '
        NombrePlantillaLabel.AutoSize = True
        NombrePlantillaLabel.Location = New System.Drawing.Point(10, 52)
        NombrePlantillaLabel.Name = "NombrePlantillaLabel"
        NombrePlantillaLabel.Size = New System.Drawing.Size(91, 14)
        NombrePlantillaLabel.TabIndex = 94
        NombrePlantillaLabel.Text = "Nombre Plantilla:"
        '
        'NombreComponenteLabel
        '
        NombreComponenteLabel.AutoSize = True
        NombreComponenteLabel.Location = New System.Drawing.Point(3, 85)
        NombreComponenteLabel.Name = "NombreComponenteLabel"
        NombreComponenteLabel.Size = New System.Drawing.Size(87, 18)
        NombreComponenteLabel.TabIndex = 96
        NombreComponenteLabel.Text = "Componente"
        '
        'RequerimientoLabel
        '
        RequerimientoLabel.AutoSize = True
        RequerimientoLabel.Location = New System.Drawing.Point(4, 129)
        RequerimientoLabel.Name = "RequerimientoLabel"
        RequerimientoLabel.Size = New System.Drawing.Size(102, 18)
        RequerimientoLabel.TabIndex = 106
        RequerimientoLabel.Text = "Requerimiento:"
        '
        'OrdenDePeticionLabel
        '
        OrdenDePeticionLabel.AutoSize = True
        OrdenDePeticionLabel.Location = New System.Drawing.Point(706, 130)
        OrdenDePeticionLabel.Name = "OrdenDePeticionLabel"
        OrdenDePeticionLabel.Size = New System.Drawing.Size(46, 18)
        OrdenDePeticionLabel.TabIndex = 107
        OrdenDePeticionLabel.Text = "Orden"
        '
        'EnunciadoLabel
        '
        EnunciadoLabel.AutoSize = True
        EnunciadoLabel.Location = New System.Drawing.Point(3, 51)
        EnunciadoLabel.Name = "EnunciadoLabel"
        EnunciadoLabel.Size = New System.Drawing.Size(75, 18)
        EnunciadoLabel.TabIndex = 108
        EnunciadoLabel.Text = "Enunciado:"
        '
        'CampoComponenteIDLabel
        '
        CampoComponenteIDLabel.AutoSize = True
        CampoComponenteIDLabel.Location = New System.Drawing.Point(448, 258)
        CampoComponenteIDLabel.Name = "CampoComponenteIDLabel"
        CampoComponenteIDLabel.Size = New System.Drawing.Size(152, 18)
        CampoComponenteIDLabel.TabIndex = 121
        CampoComponenteIDLabel.Text = "Campo Componente ID:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(561, 292)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(39, 18)
        TipoLabel.TabIndex = 153
        TipoLabel.Text = "Tipo:"
        '
        'PrefijoLabel
        '
        PrefijoLabel.AutoSize = True
        PrefijoLabel.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrefijoLabel.Location = New System.Drawing.Point(34, 65)
        PrefijoLabel.Name = "PrefijoLabel"
        PrefijoLabel.Size = New System.Drawing.Size(55, 18)
        PrefijoLabel.TabIndex = 154
        PrefijoLabel.Text = "Prefijo:"
        '
        'SuperiorLabel
        '
        SuperiorLabel.AutoSize = True
        SuperiorLabel.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SuperiorLabel.Location = New System.Drawing.Point(43, 10)
        SuperiorLabel.Name = "SuperiorLabel"
        SuperiorLabel.Size = New System.Drawing.Size(68, 18)
        SuperiorLabel.TabIndex = 155
        SuperiorLabel.Text = "Superior:"
        '
        'SufijoLabel
        '
        SufijoLabel.AutoSize = True
        SufijoLabel.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SufijoLabel.Location = New System.Drawing.Point(237, 65)
        SufijoLabel.Name = "SufijoLabel"
        SufijoLabel.Size = New System.Drawing.Size(49, 18)
        SufijoLabel.TabIndex = 156
        SufijoLabel.Text = "Sufijo:"
        '
        'InferiorLabel
        '
        InferiorLabel.AutoSize = True
        InferiorLabel.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InferiorLabel.Location = New System.Drawing.Point(44, 199)
        InferiorLabel.Name = "InferiorLabel"
        InferiorLabel.Size = New System.Drawing.Size(61, 18)
        InferiorLabel.TabIndex = 157
        InferiorLabel.Text = "Inferior:"
        '
        'SeparadorCamposLabel
        '
        SeparadorCamposLabel.AutoSize = True
        SeparadorCamposLabel.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeparadorCamposLabel.Location = New System.Drawing.Point(333, 64)
        SeparadorCamposLabel.Name = "SeparadorCamposLabel"
        SeparadorCamposLabel.Size = New System.Drawing.Size(130, 18)
        SeparadorCamposLabel.TabIndex = 158
        SeparadorCamposLabel.Text = "Separador Campos:"
        '
        'MultiReplaceLabel
        '
        MultiReplaceLabel.AutoSize = True
        MultiReplaceLabel.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MultiReplaceLabel.Location = New System.Drawing.Point(333, 234)
        MultiReplaceLabel.Name = "MultiReplaceLabel"
        MultiReplaceLabel.Size = New System.Drawing.Size(271, 18)
        MultiReplaceLabel.TabIndex = 162
        MultiReplaceLabel.Text = "Multi Replace(Palabra Replace ""Campo""):"
        '
        'CONVENSIONESLabel
        '
        CONVENSIONESLabel.AutoSize = True
        CONVENSIONESLabel.Location = New System.Drawing.Point(511, 533)
        CONVENSIONESLabel.Name = "CONVENSIONESLabel"
        CONVENSIONESLabel.Size = New System.Drawing.Size(106, 18)
        CONVENSIONESLabel.TabIndex = 110
        CONVENSIONESLabel.Text = "CONVENSIONES:"
        '
        'XTablaLabel
        '
        XTablaLabel.AutoSize = True
        XTablaLabel.Location = New System.Drawing.Point(1, 235)
        XTablaLabel.Name = "XTablaLabel"
        XTablaLabel.Size = New System.Drawing.Size(69, 18)
        XTablaLabel.TabIndex = 97
        XTablaLabel.Text = "Por Tabla:"
        '
        'XTablaLabel1
        '
        XTablaLabel1.AutoSize = True
        XTablaLabel1.Location = New System.Drawing.Point(547, 324)
        XTablaLabel1.Name = "XTablaLabel1"
        XTablaLabel1.Size = New System.Drawing.Size(53, 18)
        XTablaLabel1.TabIndex = 155
        XTablaLabel1.Text = "XTabla:"
        '
        'OrdenLabel
        '
        OrdenLabel.AutoSize = True
        OrdenLabel.Location = New System.Drawing.Point(339, 52)
        OrdenLabel.Name = "OrdenLabel"
        OrdenLabel.Size = New System.Drawing.Size(40, 14)
        OrdenLabel.TabIndex = 95
        OrdenLabel.Text = "Orden:"
        '
        'ContenidoRelacionLabel
        '
        ContenidoRelacionLabel.AutoSize = True
        ContenidoRelacionLabel.Location = New System.Drawing.Point(8, 163)
        ContenidoRelacionLabel.Name = "ContenidoRelacionLabel"
        ContenidoRelacionLabel.Size = New System.Drawing.Size(128, 18)
        ContenidoRelacionLabel.TabIndex = 130
        ContenidoRelacionLabel.Text = "Contenido Relacion:"
        '
        'RelacionTablasIDLabel
        '
        RelacionTablasIDLabel.AutoSize = True
        RelacionTablasIDLabel.Location = New System.Drawing.Point(480, 385)
        RelacionTablasIDLabel.Name = "RelacionTablasIDLabel"
        RelacionTablasIDLabel.Size = New System.Drawing.Size(120, 18)
        RelacionTablasIDLabel.TabIndex = 131
        RelacionTablasIDLabel.Text = "Relacion Tablas ID:"
        '
        'TextoEnriquecidoIDLabel
        '
        TextoEnriquecidoIDLabel.AutoSize = True
        TextoEnriquecidoIDLabel.Location = New System.Drawing.Point(478, 546)
        TextoEnriquecidoIDLabel.Name = "TextoEnriquecidoIDLabel"
        TextoEnriquecidoIDLabel.Size = New System.Drawing.Size(138, 18)
        TextoEnriquecidoIDLabel.TabIndex = 92
        TextoEnriquecidoIDLabel.Text = "Texto Enriquecido ID:"
        '
        'RequerimientoLabel1
        '
        RequerimientoLabel1.AutoSize = True
        RequerimientoLabel1.Location = New System.Drawing.Point(515, 501)
        RequerimientoLabel1.Name = "RequerimientoLabel1"
        RequerimientoLabel1.Size = New System.Drawing.Size(102, 18)
        RequerimientoLabel1.TabIndex = 113
        RequerimientoLabel1.Text = "Requerimiento:"
        '
        'ValidadaLabel
        '
        ValidadaLabel.AutoSize = True
        ValidadaLabel.Location = New System.Drawing.Point(540, 11)
        ValidadaLabel.Name = "ValidadaLabel"
        ValidadaLabel.Size = New System.Drawing.Size(63, 18)
        ValidadaLabel.TabIndex = 156
        ValidadaLabel.Text = "Validada:"
        '
        'ValidadaLabel1
        '
        ValidadaLabel1.AutoSize = True
        ValidadaLabel1.Location = New System.Drawing.Point(290, 59)
        ValidadaLabel1.Name = "ValidadaLabel1"
        ValidadaLabel1.Size = New System.Drawing.Size(53, 14)
        ValidadaLabel1.TabIndex = 94
        ValidadaLabel1.Text = "Validada:"
        '
        'XBaseLabel
        '
        XBaseLabel.AutoSize = True
        XBaseLabel.Location = New System.Drawing.Point(4, 4)
        XBaseLabel.Name = "XBaseLabel"
        XBaseLabel.Size = New System.Drawing.Size(79, 18)
        XBaseLabel.TabIndex = 98
        XBaseLabel.Text = "Es Cte. Base"
        Me.ToolTip1.SetToolTip(XBaseLabel, "Define si el componente es el base para los otros, en este se remplaza")
        '
        'XBaseLabel1
        '
        XBaseLabel1.AutoSize = True
        XBaseLabel1.Location = New System.Drawing.Point(552, 356)
        XBaseLabel1.Name = "XBaseLabel1"
        XBaseLabel1.Size = New System.Drawing.Size(48, 18)
        XBaseLabel1.TabIndex = 165
        XBaseLabel1.Text = "XBase:"
        '
        'NombreComponenteLabel1
        '
        NombreComponenteLabel1.AutoSize = True
        NombreComponenteLabel1.Location = New System.Drawing.Point(426, 417)
        NombreComponenteLabel1.Name = "NombreComponenteLabel1"
        NombreComponenteLabel1.Size = New System.Drawing.Size(174, 18)
        NombreComponenteLabel1.TabIndex = 167
        NombreComponenteLabel1.Text = "Nombre Componente Base:"
        '
        'ComponenteIDLabel
        '
        ComponenteIDLabel.AutoSize = True
        ComponenteIDLabel.Location = New System.Drawing.Point(444, 449)
        ComponenteIDLabel.Name = "ComponenteIDLabel"
        ComponenteIDLabel.Size = New System.Drawing.Size(156, 18)
        ComponenteIDLabel.TabIndex = 168
        ComponenteIDLabel.Text = "Componente ID de Base:"
        '
        'TecnologiasDataGridView
        '
        Me.TecnologiasDataGridView.AllowUserToAddRows = False
        Me.TecnologiasDataGridView.AutoGenerateColumns = False
        Me.TecnologiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TecnologiasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Validada})
        Me.TecnologiasDataGridView.DataSource = Me.TecnologiasBindingSource
        Me.TecnologiasDataGridView.Location = New System.Drawing.Point(6, 103)
        Me.TecnologiasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TecnologiasDataGridView.Name = "TecnologiasDataGridView"
        Me.TecnologiasDataGridView.RowHeadersVisible = False
        Me.TecnologiasDataGridView.RowTemplate.Height = 27
        Me.TecnologiasDataGridView.Size = New System.Drawing.Size(374, 169)
        Me.TecnologiasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreTecnologia"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Tecnologia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 340
        '
        'Validada
        '
        Me.Validada.DataPropertyName = "Validada"
        Me.Validada.HeaderText = ""
        Me.Validada.Name = "Validada"
        Me.Validada.Width = 30
        '
        'TecnologiasBindingSource
        '
        Me.TecnologiasBindingSource.DataMember = "Tecnologias"
        Me.TecnologiasBindingSource.DataSource = Me.DataSetAdministracion
        '
        'DataSetAdministracion
        '
        Me.DataSetAdministracion.DataSetName = "DataSetAdministracion"
        Me.DataSetAdministracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTecnologiaTextBox
        '
        Me.NombreTecnologiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "NombreTecnologia", True))
        Me.NombreTecnologiaTextBox.Location = New System.Drawing.Point(6, 75)
        Me.NombreTecnologiaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreTecnologiaTextBox.Name = "NombreTecnologiaTextBox"
        Me.NombreTecnologiaTextBox.Size = New System.Drawing.Size(279, 22)
        Me.NombreTecnologiaTextBox.TabIndex = 2
        '
        'PanelAdministracion_
        '
        Me.PanelAdministracion_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdministracion_.Controls.Add(Me.Nuevo_Menu_Tecnologias)
        Me.PanelAdministracion_.Controls.Add(Me.Cancelar_Menu_Tecnologias)
        Me.PanelAdministracion_.Controls.Add(Me.Eliminar_Menu_Tecnologias)
        Me.PanelAdministracion_.Controls.Add(Me.Editar_Menu_Tecnologias)
        Me.PanelAdministracion_.Controls.Add(Me.Actualizar_Menu_Tecnologias)
        Me.PanelAdministracion_.Controls.Add(Me.Guardar_Menu_Tecnologias)
        Me.PanelAdministracion_.Location = New System.Drawing.Point(7, 10)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(373, 46)
        Me.PanelAdministracion_.TabIndex = 90
        '
        'Nuevo_Menu_Tecnologias
        '
        Me.Nuevo_Menu_Tecnologias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_Tecnologias.Image = CType(resources.GetObject("Nuevo_Menu_Tecnologias.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_Tecnologias.Location = New System.Drawing.Point(51, 3)
        Me.Nuevo_Menu_Tecnologias.Name = "Nuevo_Menu_Tecnologias"
        Me.Nuevo_Menu_Tecnologias.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_Tecnologias.TabIndex = 70
        Me.Nuevo_Menu_Tecnologias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_Tecnologias.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_Tecnologias
        '
        Me.Cancelar_Menu_Tecnologias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_Tecnologias.Image = CType(resources.GetObject("Cancelar_Menu_Tecnologias.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_Tecnologias.Location = New System.Drawing.Point(280, 3)
        Me.Cancelar_Menu_Tecnologias.Name = "Cancelar_Menu_Tecnologias"
        Me.Cancelar_Menu_Tecnologias.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_Tecnologias.TabIndex = 75
        Me.Cancelar_Menu_Tecnologias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_Tecnologias.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_Tecnologias
        '
        Me.Eliminar_Menu_Tecnologias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_Tecnologias.Image = CType(resources.GetObject("Eliminar_Menu_Tecnologias.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_Tecnologias.Location = New System.Drawing.Point(235, 3)
        Me.Eliminar_Menu_Tecnologias.Name = "Eliminar_Menu_Tecnologias"
        Me.Eliminar_Menu_Tecnologias.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_Tecnologias.TabIndex = 72
        Me.Eliminar_Menu_Tecnologias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_Tecnologias.UseVisualStyleBackColor = True
        '
        'Editar_Menu_Tecnologias
        '
        Me.Editar_Menu_Tecnologias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_Tecnologias.Image = CType(resources.GetObject("Editar_Menu_Tecnologias.Image"), System.Drawing.Image)
        Me.Editar_Menu_Tecnologias.Location = New System.Drawing.Point(143, 3)
        Me.Editar_Menu_Tecnologias.Name = "Editar_Menu_Tecnologias"
        Me.Editar_Menu_Tecnologias.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_Tecnologias.TabIndex = 74
        Me.Editar_Menu_Tecnologias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_Tecnologias.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_Tecnologias
        '
        Me.Actualizar_Menu_Tecnologias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_Tecnologias.Image = CType(resources.GetObject("Actualizar_Menu_Tecnologias.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_Tecnologias.Location = New System.Drawing.Point(189, 3)
        Me.Actualizar_Menu_Tecnologias.Name = "Actualizar_Menu_Tecnologias"
        Me.Actualizar_Menu_Tecnologias.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_Tecnologias.TabIndex = 73
        Me.Actualizar_Menu_Tecnologias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_Tecnologias.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_Tecnologias
        '
        Me.Guardar_Menu_Tecnologias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_Tecnologias.Image = CType(resources.GetObject("Guardar_Menu_Tecnologias.Image"), System.Drawing.Image)
        Me.Guardar_Menu_Tecnologias.Location = New System.Drawing.Point(97, 3)
        Me.Guardar_Menu_Tecnologias.Name = "Guardar_Menu_Tecnologias"
        Me.Guardar_Menu_Tecnologias.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_Tecnologias.TabIndex = 71
        Me.Guardar_Menu_Tecnologias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_Tecnologias.UseVisualStyleBackColor = True
        '
        'TecnologiaIDTextBox
        '
        Me.TecnologiaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "TecnologiaID", True))
        Me.TecnologiaIDTextBox.Location = New System.Drawing.Point(606, 127)
        Me.TecnologiaIDTextBox.Name = "TecnologiaIDTextBox"
        Me.TecnologiaIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TecnologiaIDTextBox.TabIndex = 91
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(606, 66)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(100, 26)
        Me.ControlNulos.TabIndex = 92
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 611)
        Me.Panel1.TabIndex = 93
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(ValidadaLabel1)
        Me.Panel2.Controls.Add(Me.ValidadaCheckBox)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PanelAdministracion_)
        Me.Panel2.Controls.Add(NombreTecnologiaLabel)
        Me.Panel2.Controls.Add(Me.TecnologiasDataGridView)
        Me.Panel2.Controls.Add(Me.NombreTecnologiaTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(387, 607)
        Me.Panel2.TabIndex = 94
        '
        'ValidadaCheckBox
        '
        Me.ValidadaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TecnologiasBindingSource, "Validada", True))
        Me.ValidadaCheckBox.Location = New System.Drawing.Point(288, 74)
        Me.ValidadaCheckBox.Name = "ValidadaCheckBox"
        Me.ValidadaCheckBox.Size = New System.Drawing.Size(92, 24)
        Me.ValidadaCheckBox.TabIndex = 95
        Me.ValidadaCheckBox.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.DGVEdicionPosicion)
        Me.Panel3.Controls.Add(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView)
        Me.Panel3.Controls.Add(OrdenLabel)
        Me.Panel3.Controls.Add(Me.OrdenTextBox)
        Me.Panel3.Controls.Add(NombrePlantillaLabel)
        Me.Panel3.Controls.Add(Me.NombrePlantillaTextBox)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(5, 279)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(382, 323)
        Me.Panel3.TabIndex = 94
        '
        'DGVEdicionPosicion
        '
        Me.DGVEdicionPosicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEdicionPosicion.Location = New System.Drawing.Point(6, 120)
        Me.DGVEdicionPosicion.Name = "DGVEdicionPosicion"
        Me.DGVEdicionPosicion.Size = New System.Drawing.Size(369, 200)
        Me.DGVEdicionPosicion.TabIndex = 119
        Me.DGVEdicionPosicion.Visible = False
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AllowUserToAddRows = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AutoGenerateColumns = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Orden, Me.DataGridViewTextBoxColumn4, Me.Column1})
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.DataSource = Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Location = New System.Drawing.Point(6, 97)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Name = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowHeadersVisible = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowTemplate.Height = 27
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Size = New System.Drawing.Size(369, 222)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.TabIndex = 94
        '
        'Orden
        '
        Me.Orden.DataPropertyName = "Orden"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Orden.DefaultCellStyle = DataGridViewCellStyle2
        Me.Orden.HeaderText = "#"
        Me.Orden.Name = "Orden"
        Me.Orden.Width = 30
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre Plantilla"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 309
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "PlantillaID"
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 5
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataMember = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataSource = Me.DataSetAdministracion
        '
        'OrdenTextBox
        '
        Me.OrdenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "Orden", True))
        Me.OrdenTextBox.Location = New System.Drawing.Point(342, 69)
        Me.OrdenTextBox.Name = "OrdenTextBox"
        Me.OrdenTextBox.Size = New System.Drawing.Size(33, 22)
        Me.OrdenTextBox.TabIndex = 96
        Me.OrdenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NombrePlantillaTextBox
        '
        Me.NombrePlantillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "NombrePlantilla", True))
        Me.NombrePlantillaTextBox.Location = New System.Drawing.Point(6, 69)
        Me.NombrePlantillaTextBox.Name = "NombrePlantillaTextBox"
        Me.NombrePlantillaTextBox.Size = New System.Drawing.Size(330, 22)
        Me.NombrePlantillaTextBox.TabIndex = 95
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ChkMover)
        Me.Panel4.Controls.Add(Me.BtnBajarFila)
        Me.Panel4.Controls.Add(Me.Nuevo_Menu_Plantillas)
        Me.Panel4.Controls.Add(Me.BtnSubirFila)
        Me.Panel4.Controls.Add(Me.Cancelar_Menu_Plantillas)
        Me.Panel4.Controls.Add(Me.Eliminar_Menu_Plantillas)
        Me.Panel4.Controls.Add(Me.Editar_Menu_Plantillas)
        Me.Panel4.Controls.Add(Me.Actualizar_Menu_Plantillas)
        Me.Panel4.Controls.Add(Me.Guardar_Menu_Plantillas)
        Me.Panel4.Location = New System.Drawing.Point(6, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(373, 44)
        Me.Panel4.TabIndex = 89
        '
        'ChkMover
        '
        Me.ChkMover.AutoSize = True
        Me.ChkMover.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMover.Location = New System.Drawing.Point(279, 15)
        Me.ChkMover.Name = "ChkMover"
        Me.ChkMover.Size = New System.Drawing.Size(15, 14)
        Me.ChkMover.TabIndex = 118
        Me.ToolTip1.SetToolTip(Me.ChkMover, "Mover Posicion")
        Me.ChkMover.UseVisualStyleBackColor = True
        '
        'BtnBajarFila
        '
        Me.BtnBajarFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBajarFila.Enabled = False
        Me.BtnBajarFila.Image = CType(resources.GetObject("BtnBajarFila.Image"), System.Drawing.Image)
        Me.BtnBajarFila.Location = New System.Drawing.Point(335, 3)
        Me.BtnBajarFila.Name = "BtnBajarFila"
        Me.BtnBajarFila.Size = New System.Drawing.Size(40, 38)
        Me.BtnBajarFila.TabIndex = 121
        Me.BtnBajarFila.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnBajarFila, "Bajar Paso")
        Me.BtnBajarFila.UseVisualStyleBackColor = True
        '
        'Nuevo_Menu_Plantillas
        '
        Me.Nuevo_Menu_Plantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_Plantillas.Image = CType(resources.GetObject("Nuevo_Menu_Plantillas.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_Plantillas.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_Plantillas.Name = "Nuevo_Menu_Plantillas"
        Me.Nuevo_Menu_Plantillas.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_Plantillas.TabIndex = 70
        Me.Nuevo_Menu_Plantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_Plantillas.UseVisualStyleBackColor = True
        '
        'BtnSubirFila
        '
        Me.BtnSubirFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSubirFila.Enabled = False
        Me.BtnSubirFila.Image = CType(resources.GetObject("BtnSubirFila.Image"), System.Drawing.Image)
        Me.BtnSubirFila.Location = New System.Drawing.Point(295, 3)
        Me.BtnSubirFila.Name = "BtnSubirFila"
        Me.BtnSubirFila.Size = New System.Drawing.Size(40, 38)
        Me.BtnSubirFila.TabIndex = 122
        Me.BtnSubirFila.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnSubirFila, "Subir Paso")
        Me.BtnSubirFila.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_Plantillas
        '
        Me.Cancelar_Menu_Plantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_Plantillas.Image = CType(resources.GetObject("Cancelar_Menu_Plantillas.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_Plantillas.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_Plantillas.Name = "Cancelar_Menu_Plantillas"
        Me.Cancelar_Menu_Plantillas.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_Plantillas.TabIndex = 75
        Me.Cancelar_Menu_Plantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_Plantillas.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_Plantillas
        '
        Me.Eliminar_Menu_Plantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_Plantillas.Image = CType(resources.GetObject("Eliminar_Menu_Plantillas.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_Plantillas.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_Plantillas.Name = "Eliminar_Menu_Plantillas"
        Me.Eliminar_Menu_Plantillas.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_Plantillas.TabIndex = 72
        Me.Eliminar_Menu_Plantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_Plantillas.UseVisualStyleBackColor = True
        '
        'Editar_Menu_Plantillas
        '
        Me.Editar_Menu_Plantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_Plantillas.Image = CType(resources.GetObject("Editar_Menu_Plantillas.Image"), System.Drawing.Image)
        Me.Editar_Menu_Plantillas.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_Plantillas.Name = "Editar_Menu_Plantillas"
        Me.Editar_Menu_Plantillas.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_Plantillas.TabIndex = 74
        Me.Editar_Menu_Plantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_Plantillas.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_Plantillas
        '
        Me.Actualizar_Menu_Plantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_Plantillas.Image = CType(resources.GetObject("Actualizar_Menu_Plantillas.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_Plantillas.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_Plantillas.Name = "Actualizar_Menu_Plantillas"
        Me.Actualizar_Menu_Plantillas.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_Plantillas.TabIndex = 73
        Me.Actualizar_Menu_Plantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_Plantillas.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_Plantillas
        '
        Me.Guardar_Menu_Plantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_Plantillas.Image = CType(resources.GetObject("Guardar_Menu_Plantillas.Image"), System.Drawing.Image)
        Me.Guardar_Menu_Plantillas.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_Plantillas.Name = "Guardar_Menu_Plantillas"
        Me.Guardar_Menu_Plantillas.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_Plantillas.TabIndex = 71
        Me.Guardar_Menu_Plantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_Plantillas.UseVisualStyleBackColor = True
        '
        'PlantillaIDTextBox
        '
        Me.PlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "PlantillaID", True))
        Me.PlantillaIDTextBox.Location = New System.Drawing.Point(606, 159)
        Me.PlantillaIDTextBox.Name = "PlantillaIDTextBox"
        Me.PlantillaIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.PlantillaIDTextBox.TabIndex = 94
        '
        'Nuevo_Menu_Componentes
        '
        Me.Nuevo_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_Componentes.Image = CType(resources.GetObject("Nuevo_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_Componentes.Location = New System.Drawing.Point(7, 5)
        Me.Nuevo_Menu_Componentes.Name = "Nuevo_Menu_Componentes"
        Me.Nuevo_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_Componentes.TabIndex = 70
        Me.Nuevo_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_Componentes.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_Componentes
        '
        Me.Cancelar_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_Componentes.Image = CType(resources.GetObject("Cancelar_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_Componentes.Location = New System.Drawing.Point(105, 44)
        Me.Cancelar_Menu_Componentes.Name = "Cancelar_Menu_Componentes"
        Me.Cancelar_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_Componentes.TabIndex = 75
        Me.Cancelar_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_Componentes.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_Componentes
        '
        Me.Eliminar_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_Componentes.Image = CType(resources.GetObject("Eliminar_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_Componentes.Location = New System.Drawing.Point(57, 44)
        Me.Eliminar_Menu_Componentes.Name = "Eliminar_Menu_Componentes"
        Me.Eliminar_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_Componentes.TabIndex = 72
        Me.Eliminar_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_Componentes.UseVisualStyleBackColor = True
        '
        'Editar_Menu_Componentes
        '
        Me.Editar_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_Componentes.Image = CType(resources.GetObject("Editar_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Editar_Menu_Componentes.Location = New System.Drawing.Point(7, 44)
        Me.Editar_Menu_Componentes.Name = "Editar_Menu_Componentes"
        Me.Editar_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_Componentes.TabIndex = 74
        Me.Editar_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_Componentes.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_Componentes
        '
        Me.Actualizar_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_Componentes.Image = CType(resources.GetObject("Actualizar_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_Componentes.Location = New System.Drawing.Point(105, 5)
        Me.Actualizar_Menu_Componentes.Name = "Actualizar_Menu_Componentes"
        Me.Actualizar_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_Componentes.TabIndex = 73
        Me.Actualizar_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_Componentes.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_Componentes
        '
        Me.Guardar_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_Componentes.Image = CType(resources.GetObject("Guardar_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Guardar_Menu_Componentes.Location = New System.Drawing.Point(57, 5)
        Me.Guardar_Menu_Componentes.Name = "Guardar_Menu_Componentes"
        Me.Guardar_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_Componentes.TabIndex = 71
        Me.Guardar_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_Componentes.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.BtnVerCodigo)
        Me.Panel6.Controls.Add(Me.PanelComponenteBase)
        Me.Panel6.Controls.Add(XTablaLabel)
        Me.Panel6.Controls.Add(Me.XTablaCheckBox)
        Me.Panel6.Controls.Add(Me.NombreComponenteTextBox)
        Me.Panel6.Controls.Add(NombreComponenteLabel)
        Me.Panel6.Controls.Add(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.Panel6.Controls.Add(Me.Cancelar_Menu_Componentes)
        Me.Panel6.Controls.Add(Me.Nuevo_Menu_Componentes)
        Me.Panel6.Controls.Add(Me.Eliminar_Menu_Componentes)
        Me.Panel6.Controls.Add(Me.Guardar_Menu_Componentes)
        Me.Panel6.Controls.Add(Me.Actualizar_Menu_Componentes)
        Me.Panel6.Controls.Add(Me.Editar_Menu_Componentes)
        Me.Panel6.Location = New System.Drawing.Point(389, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(155, 609)
        Me.Panel6.TabIndex = 96
        '
        'BtnVerCodigo
        '
        Me.BtnVerCodigo.BackColor = System.Drawing.Color.Black
        Me.BtnVerCodigo.Location = New System.Drawing.Point(124, 85)
        Me.BtnVerCodigo.Name = "BtnVerCodigo"
        Me.BtnVerCodigo.Size = New System.Drawing.Size(21, 18)
        Me.BtnVerCodigo.TabIndex = 170
        Me.BtnVerCodigo.UseVisualStyleBackColor = False
        '
        'PanelComponenteBase
        '
        Me.PanelComponenteBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelComponenteBase.Controls.Add(Me.BtnReseteoBase)
        Me.PanelComponenteBase.Controls.Add(XBaseLabel)
        Me.PanelComponenteBase.Controls.Add(Me.BtnAsignarBase)
        Me.PanelComponenteBase.Controls.Add(Me.XBaseCheckBox)
        Me.PanelComponenteBase.Location = New System.Drawing.Point(3, 263)
        Me.PanelComponenteBase.Name = "PanelComponenteBase"
        Me.PanelComponenteBase.Size = New System.Drawing.Size(147, 52)
        Me.PanelComponenteBase.TabIndex = 148
        '
        'BtnReseteoBase
        '
        Me.BtnReseteoBase.BackColor = System.Drawing.Color.Red
        Me.BtnReseteoBase.Location = New System.Drawing.Point(46, 25)
        Me.BtnReseteoBase.Name = "BtnReseteoBase"
        Me.BtnReseteoBase.Size = New System.Drawing.Size(21, 20)
        Me.BtnReseteoBase.TabIndex = 149
        Me.ToolTip1.SetToolTip(Me.BtnReseteoBase, "Resetear los Componentes ")
        Me.BtnReseteoBase.UseVisualStyleBackColor = False
        '
        'BtnAsignarBase
        '
        Me.BtnAsignarBase.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnAsignarBase.Location = New System.Drawing.Point(4, 25)
        Me.BtnAsignarBase.Name = "BtnAsignarBase"
        Me.BtnAsignarBase.Size = New System.Drawing.Size(21, 20)
        Me.BtnAsignarBase.TabIndex = 148
        Me.ToolTip1.SetToolTip(Me.BtnAsignarBase, "Asignar Base")
        Me.BtnAsignarBase.UseVisualStyleBackColor = False
        '
        'XBaseCheckBox
        '
        Me.XBaseCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "XBase", True))
        Me.XBaseCheckBox.Location = New System.Drawing.Point(96, 1)
        Me.XBaseCheckBox.Name = "XBaseCheckBox"
        Me.XBaseCheckBox.Size = New System.Drawing.Size(86, 24)
        Me.XBaseCheckBox.TabIndex = 99
        Me.XBaseCheckBox.UseVisualStyleBackColor = True
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetAdministracion
        '
        'XTablaCheckBox
        '
        Me.XTablaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "XTabla", True))
        Me.XTablaCheckBox.Location = New System.Drawing.Point(99, 233)
        Me.XTablaCheckBox.Name = "XTablaCheckBox"
        Me.XTablaCheckBox.Size = New System.Drawing.Size(61, 24)
        Me.XTablaCheckBox.TabIndex = 98
        Me.XTablaCheckBox.UseVisualStyleBackColor = True
        '
        'NombreComponenteTextBox
        '
        Me.NombreComponenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "NombreComponente", True))
        Me.NombreComponenteTextBox.Location = New System.Drawing.Point(3, 105)
        Me.NombreComponenteTextBox.Multiline = True
        Me.NombreComponenteTextBox.Name = "NombreComponenteTextBox"
        Me.NombreComponenteTextBox.Size = New System.Drawing.Size(147, 117)
        Me.NombreComponenteTextBox.TabIndex = 97
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5})
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(0, 321)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(153, 286)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 97
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NombreComponente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Componente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 142
        '
        'ComponenteIDTextBox
        '
        Me.ComponenteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "ComponenteID", True))
        Me.ComponenteIDTextBox.Location = New System.Drawing.Point(606, 191)
        Me.ComponenteIDTextBox.Name = "ComponenteIDTextBox"
        Me.ComponenteIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ComponenteIDTextBox.TabIndex = 98
        '
        'TxtBuscado
        '
        Me.TxtBuscado.Location = New System.Drawing.Point(6, 24)
        Me.TxtBuscado.Name = "TxtBuscado"
        Me.TxtBuscado.Size = New System.Drawing.Size(216, 26)
        Me.TxtBuscado.TabIndex = 104
        '
        'TxtRemplazarPor
        '
        Me.TxtRemplazarPor.Location = New System.Drawing.Point(6, 79)
        Me.TxtRemplazarPor.Name = "TxtRemplazarPor"
        Me.TxtRemplazarPor.Size = New System.Drawing.Size(216, 26)
        Me.TxtRemplazarPor.TabIndex = 105
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6})
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(6, 179)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowTemplate.Height = 27
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(490, 391)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 107
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Requerimiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Requerimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 455
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1.DataMember = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1.DataSource = Me.DataSetAdministracion
        '
        'RequerimientoTextBox
        '
        Me.RequerimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, "Requerimiento", True))
        Me.RequerimientoTextBox.Location = New System.Drawing.Point(6, 150)
        Me.RequerimientoTextBox.Name = "RequerimientoTextBox"
        Me.RequerimientoTextBox.Size = New System.Drawing.Size(700, 26)
        Me.RequerimientoTextBox.TabIndex = 107
        '
        'OrdenDePeticionTextBox
        '
        Me.OrdenDePeticionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, "OrdenDePeticion", True))
        Me.OrdenDePeticionTextBox.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdenDePeticionTextBox.Location = New System.Drawing.Point(712, 150)
        Me.OrdenDePeticionTextBox.Name = "OrdenDePeticionTextBox"
        Me.OrdenDePeticionTextBox.Size = New System.Drawing.Size(40, 27)
        Me.OrdenDePeticionTextBox.TabIndex = 108
        Me.OrdenDePeticionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.Nuevo_Menu_RequerimientosPlantillas)
        Me.Panel5.Controls.Add(Me.Cancelar_Menu_RequerimientosPlantillas)
        Me.Panel5.Controls.Add(Me.Eliminar_Menu_RequerimientosPlantillas)
        Me.Panel5.Controls.Add(Me.Editar_Menu_RequerimientosPlantillas)
        Me.Panel5.Controls.Add(Me.Actualizar_Menu_RequerimientosPlantillas)
        Me.Panel5.Controls.Add(Me.Guardar_Menu_RequerimientosPlantillas)
        Me.Panel5.Location = New System.Drawing.Point(6, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(748, 41)
        Me.Panel5.TabIndex = 110
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(338, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 36)
        Me.Button1.TabIndex = 76
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Nuevo_Menu_RequerimientosPlantillas
        '
        Me.Nuevo_Menu_RequerimientosPlantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_RequerimientosPlantillas.Image = CType(resources.GetObject("Nuevo_Menu_RequerimientosPlantillas.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_RequerimientosPlantillas.Location = New System.Drawing.Point(4, 1)
        Me.Nuevo_Menu_RequerimientosPlantillas.Name = "Nuevo_Menu_RequerimientosPlantillas"
        Me.Nuevo_Menu_RequerimientosPlantillas.Size = New System.Drawing.Size(38, 36)
        Me.Nuevo_Menu_RequerimientosPlantillas.TabIndex = 70
        Me.Nuevo_Menu_RequerimientosPlantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_RequerimientosPlantillas.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_RequerimientosPlantillas
        '
        Me.Cancelar_Menu_RequerimientosPlantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_RequerimientosPlantillas.Image = CType(resources.GetObject("Cancelar_Menu_RequerimientosPlantillas.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_RequerimientosPlantillas.Location = New System.Drawing.Point(224, 1)
        Me.Cancelar_Menu_RequerimientosPlantillas.Name = "Cancelar_Menu_RequerimientosPlantillas"
        Me.Cancelar_Menu_RequerimientosPlantillas.Size = New System.Drawing.Size(38, 36)
        Me.Cancelar_Menu_RequerimientosPlantillas.TabIndex = 75
        Me.Cancelar_Menu_RequerimientosPlantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_RequerimientosPlantillas.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_RequerimientosPlantillas
        '
        Me.Eliminar_Menu_RequerimientosPlantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_RequerimientosPlantillas.Image = CType(resources.GetObject("Eliminar_Menu_RequerimientosPlantillas.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_RequerimientosPlantillas.Location = New System.Drawing.Point(178, 1)
        Me.Eliminar_Menu_RequerimientosPlantillas.Name = "Eliminar_Menu_RequerimientosPlantillas"
        Me.Eliminar_Menu_RequerimientosPlantillas.Size = New System.Drawing.Size(38, 36)
        Me.Eliminar_Menu_RequerimientosPlantillas.TabIndex = 72
        Me.Eliminar_Menu_RequerimientosPlantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_RequerimientosPlantillas.UseVisualStyleBackColor = True
        '
        'Editar_Menu_RequerimientosPlantillas
        '
        Me.Editar_Menu_RequerimientosPlantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_RequerimientosPlantillas.Image = CType(resources.GetObject("Editar_Menu_RequerimientosPlantillas.Image"), System.Drawing.Image)
        Me.Editar_Menu_RequerimientosPlantillas.Location = New System.Drawing.Point(92, 1)
        Me.Editar_Menu_RequerimientosPlantillas.Name = "Editar_Menu_RequerimientosPlantillas"
        Me.Editar_Menu_RequerimientosPlantillas.Size = New System.Drawing.Size(38, 36)
        Me.Editar_Menu_RequerimientosPlantillas.TabIndex = 74
        Me.Editar_Menu_RequerimientosPlantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_RequerimientosPlantillas.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_RequerimientosPlantillas
        '
        Me.Actualizar_Menu_RequerimientosPlantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_RequerimientosPlantillas.Image = CType(resources.GetObject("Actualizar_Menu_RequerimientosPlantillas.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_RequerimientosPlantillas.Location = New System.Drawing.Point(132, 1)
        Me.Actualizar_Menu_RequerimientosPlantillas.Name = "Actualizar_Menu_RequerimientosPlantillas"
        Me.Actualizar_Menu_RequerimientosPlantillas.Size = New System.Drawing.Size(38, 36)
        Me.Actualizar_Menu_RequerimientosPlantillas.TabIndex = 73
        Me.Actualizar_Menu_RequerimientosPlantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_RequerimientosPlantillas.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_RequerimientosPlantillas
        '
        Me.Guardar_Menu_RequerimientosPlantillas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_RequerimientosPlantillas.Image = CType(resources.GetObject("Guardar_Menu_RequerimientosPlantillas.Image"), System.Drawing.Image)
        Me.Guardar_Menu_RequerimientosPlantillas.Location = New System.Drawing.Point(46, 1)
        Me.Guardar_Menu_RequerimientosPlantillas.Name = "Guardar_Menu_RequerimientosPlantillas"
        Me.Guardar_Menu_RequerimientosPlantillas.Size = New System.Drawing.Size(38, 36)
        Me.Guardar_Menu_RequerimientosPlantillas.TabIndex = 71
        Me.Guardar_Menu_RequerimientosPlantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_RequerimientosPlantillas.UseVisualStyleBackColor = True
        '
        'RequerimientoPlantillaIDTextBox
        '
        Me.RequerimientoPlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, "RequerimientoPlantillaID", True))
        Me.RequerimientoPlantillaIDTextBox.Location = New System.Drawing.Point(606, 36)
        Me.RequerimientoPlantillaIDTextBox.Name = "RequerimientoPlantillaIDTextBox"
        Me.RequerimientoPlantillaIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RequerimientoPlantillaIDTextBox.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Buscar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Remplazar por:"
        '
        'TabPanelControl
        '
        Me.TabPanelControl.Controls.Add(Me.TabPage1)
        Me.TabPanelControl.Controls.Add(Me.TabPage5)
        Me.TabPanelControl.Controls.Add(Me.TabPage3)
        Me.TabPanelControl.Controls.Add(Me.TabPage2)
        Me.TabPanelControl.Controls.Add(Me.TabPage4)
        Me.TabPanelControl.Controls.Add(Me.TabPage6)
        Me.TabPanelControl.Location = New System.Drawing.Point(549, 1)
        Me.TabPanelControl.Name = "TabPanelControl"
        Me.TabPanelControl.SelectedIndex = 0
        Me.TabPanelControl.Size = New System.Drawing.Size(768, 607)
        Me.TabPanelControl.TabIndex = 116
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.BtnZoom)
        Me.TabPage1.Controls.Add(Me.ContenidoComponenteRichTextBox)
        Me.TabPage1.Controls.Add(Me.ChkControlCambios)
        Me.TabPage1.Controls.Add(Me.ContenidoComponenteCopia)
        Me.TabPage1.Controls.Add(Me.BtnTodasLasTablas)
        Me.TabPage1.Controls.Add(Me.PanelGuardado)
        Me.TabPage1.Controls.Add(Me.BtnCamposRelacionados)
        Me.TabPage1.Controls.Add(Me.BtnTablaPluralMinuscula)
        Me.TabPage1.Controls.Add(Me.BtnMayusculaAMinuscula)
        Me.TabPage1.Controls.Add(Me.BtnTablaPlural)
        Me.TabPage1.Controls.Add(Me.BtnTablaMinuscula)
        Me.TabPage1.Controls.Add(Me.BtnImprimeClavePrincipal)
        Me.TabPage1.Controls.Add(Me.BtnImprimeTabla)
        Me.TabPage1.Controls.Add(Me.BtnImprimeCampos)
        Me.TabPage1.Controls.Add(Me.BtnGuardarCodigo)
        Me.TabPage1.Controls.Add(Me.BtnSubirRemplazado)
        Me.TabPage1.Controls.Add(Me.BtnLimpiarRemplazar)
        Me.TabPage1.Controls.Add(Me.BtnLimpiar)
        Me.TabPage1.Controls.Add(Me.BtnRemplazar)
        Me.TabPage1.Controls.Add(Me.BtnBajarFuente)
        Me.TabPage1.Controls.Add(Me.BtnSubirFuente)
        Me.TabPage1.Controls.Add(Me.BtnBuscarYPintar)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtBuscado)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtRemplazarPor)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(760, 576)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Text Cod"
        '
        'BtnZoom
        '
        Me.BtnZoom.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnZoom.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnZoom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnZoom.Location = New System.Drawing.Point(702, 55)
        Me.BtnZoom.Name = "BtnZoom"
        Me.BtnZoom.Size = New System.Drawing.Size(48, 25)
        Me.BtnZoom.TabIndex = 147
        Me.BtnZoom.Text = "Zoom"
        Me.BtnZoom.UseVisualStyleBackColor = False
        '
        'ContenidoComponenteRichTextBox
        '
        Me.ContenidoComponenteRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Codigo", True))
        Me.ContenidoComponenteRichTextBox.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContenidoComponenteRichTextBox.Location = New System.Drawing.Point(3, 111)
        Me.ContenidoComponenteRichTextBox.Name = "ContenidoComponenteRichTextBox"
        Me.ContenidoComponenteRichTextBox.Size = New System.Drawing.Size(749, 458)
        Me.ContenidoComponenteRichTextBox.TabIndex = 115
        Me.ContenidoComponenteRichTextBox.Text = ""
        '
        'ChkControlCambios
        '
        Me.ChkControlCambios.AutoSize = True
        Me.ChkControlCambios.Checked = True
        Me.ChkControlCambios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkControlCambios.Location = New System.Drawing.Point(573, 85)
        Me.ChkControlCambios.Name = "ChkControlCambios"
        Me.ChkControlCambios.Size = New System.Drawing.Size(144, 22)
        Me.ChkControlCambios.TabIndex = 146
        Me.ChkControlCambios.Text = "Control de Cambios"
        Me.ChkControlCambios.UseVisualStyleBackColor = True
        '
        'ContenidoComponenteCopia
        '
        Me.ContenidoComponenteCopia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Codigo", True))
        Me.ContenidoComponenteCopia.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContenidoComponenteCopia.Location = New System.Drawing.Point(646, 137)
        Me.ContenidoComponenteCopia.Name = "ContenidoComponenteCopia"
        Me.ContenidoComponenteCopia.Size = New System.Drawing.Size(49, 43)
        Me.ContenidoComponenteCopia.TabIndex = 145
        Me.ContenidoComponenteCopia.Text = ""
        '
        'BtnTodasLasTablas
        '
        Me.BtnTodasLasTablas.BackColor = System.Drawing.Color.White
        Me.BtnTodasLasTablas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTodasLasTablas.Location = New System.Drawing.Point(573, 55)
        Me.BtnTodasLasTablas.Name = "BtnTodasLasTablas"
        Me.BtnTodasLasTablas.Size = New System.Drawing.Size(89, 25)
        Me.BtnTodasLasTablas.TabIndex = 144
        Me.BtnTodasLasTablas.Text = "{{{Tbl-Camel}}}"
        Me.ToolTip1.SetToolTip(Me.BtnTodasLasTablas, "Toma todas las tablas del proyecto y las remplaza en un texto especifico")
        Me.BtnTodasLasTablas.UseVisualStyleBackColor = False
        '
        'PanelGuardado
        '
        Me.PanelGuardado.BackColor = System.Drawing.Color.Chartreuse
        Me.PanelGuardado.Controls.Add(Me.Label5)
        Me.PanelGuardado.Location = New System.Drawing.Point(191, 250)
        Me.PanelGuardado.Name = "PanelGuardado"
        Me.PanelGuardado.Size = New System.Drawing.Size(346, 100)
        Me.PanelGuardado.TabIndex = 143
        Me.PanelGuardado.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(271, 59)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "GUARDADO"
        '
        'BtnCamposRelacionados
        '
        Me.BtnCamposRelacionados.BackColor = System.Drawing.Color.White
        Me.BtnCamposRelacionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCamposRelacionados.Location = New System.Drawing.Point(463, 82)
        Me.BtnCamposRelacionados.Name = "BtnCamposRelacionados"
        Me.BtnCamposRelacionados.Size = New System.Drawing.Size(104, 25)
        Me.BtnCamposRelacionados.TabIndex = 142
        Me.BtnCamposRelacionados.Text = "{{{Camp-Rel}}}"
        Me.ToolTip1.SetToolTip(Me.BtnCamposRelacionados, "Campos Relacionados de la Tabla")
        Me.BtnCamposRelacionados.UseVisualStyleBackColor = False
        '
        'BtnTablaPluralMinuscula
        '
        Me.BtnTablaPluralMinuscula.BackColor = System.Drawing.Color.White
        Me.BtnTablaPluralMinuscula.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTablaPluralMinuscula.Location = New System.Drawing.Point(463, 55)
        Me.BtnTablaPluralMinuscula.Name = "BtnTablaPluralMinuscula"
        Me.BtnTablaPluralMinuscula.Size = New System.Drawing.Size(104, 25)
        Me.BtnTablaPluralMinuscula.TabIndex = 130
        Me.BtnTablaPluralMinuscula.Text = "{{{TPlurMin}}}"
        Me.ToolTip1.SetToolTip(Me.BtnTablaPluralMinuscula, "Tabla en Plural y en Minuscula")
        Me.BtnTablaPluralMinuscula.UseVisualStyleBackColor = False
        '
        'BtnMayusculaAMinuscula
        '
        Me.BtnMayusculaAMinuscula.BackColor = System.Drawing.Color.White
        Me.BtnMayusculaAMinuscula.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMayusculaAMinuscula.Location = New System.Drawing.Point(366, 82)
        Me.BtnMayusculaAMinuscula.Name = "BtnMayusculaAMinuscula"
        Me.BtnMayusculaAMinuscula.Size = New System.Drawing.Size(89, 25)
        Me.BtnMayusculaAMinuscula.TabIndex = 129
        Me.BtnMayusculaAMinuscula.Text = "{{{A=>-a}}}"
        Me.ToolTip1.SetToolTip(Me.BtnMayusculaAMinuscula, "Nombre de la Tabla en Minusculas, y donde tenga mayusculas se le antecede un gion" &
        " ( - ) y se pone en minusculas FormaDePago => forma-de-pago")
        Me.BtnMayusculaAMinuscula.UseVisualStyleBackColor = False
        '
        'BtnTablaPlural
        '
        Me.BtnTablaPlural.BackColor = System.Drawing.Color.White
        Me.BtnTablaPlural.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTablaPlural.Location = New System.Drawing.Point(366, 55)
        Me.BtnTablaPlural.Name = "BtnTablaPlural"
        Me.BtnTablaPlural.Size = New System.Drawing.Size(89, 25)
        Me.BtnTablaPlural.TabIndex = 128
        Me.BtnTablaPlural.Text = "{{{TPlur}}}"
        Me.ToolTip1.SetToolTip(Me.BtnTablaPlural, "Nombre de la Tabla en Plural")
        Me.BtnTablaPlural.UseVisualStyleBackColor = False
        '
        'BtnTablaMinuscula
        '
        Me.BtnTablaMinuscula.BackColor = System.Drawing.Color.White
        Me.BtnTablaMinuscula.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTablaMinuscula.Location = New System.Drawing.Point(268, 82)
        Me.BtnTablaMinuscula.Name = "BtnTablaMinuscula"
        Me.BtnTablaMinuscula.Size = New System.Drawing.Size(89, 25)
        Me.BtnTablaMinuscula.TabIndex = 127
        Me.BtnTablaMinuscula.Text = "{{{Tmin}}}"
        Me.ToolTip1.SetToolTip(Me.BtnTablaMinuscula, "Nombre de la Tabla en Minuscula")
        Me.BtnTablaMinuscula.UseVisualStyleBackColor = False
        '
        'BtnImprimeClavePrincipal
        '
        Me.BtnImprimeClavePrincipal.BackColor = System.Drawing.Color.White
        Me.BtnImprimeClavePrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimeClavePrincipal.Location = New System.Drawing.Point(573, 7)
        Me.BtnImprimeClavePrincipal.Name = "BtnImprimeClavePrincipal"
        Me.BtnImprimeClavePrincipal.Size = New System.Drawing.Size(89, 43)
        Me.BtnImprimeClavePrincipal.TabIndex = 126
        Me.BtnImprimeClavePrincipal.Text = "{{{Clave}}}"
        Me.ToolTip1.SetToolTip(Me.BtnImprimeClavePrincipal, "Clave Principal de la Tabla")
        Me.BtnImprimeClavePrincipal.UseVisualStyleBackColor = False
        '
        'BtnImprimeTabla
        '
        Me.BtnImprimeTabla.BackColor = System.Drawing.Color.White
        Me.BtnImprimeTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimeTabla.Location = New System.Drawing.Point(487, 7)
        Me.BtnImprimeTabla.Name = "BtnImprimeTabla"
        Me.BtnImprimeTabla.Size = New System.Drawing.Size(80, 43)
        Me.BtnImprimeTabla.TabIndex = 125
        Me.BtnImprimeTabla.Text = "{{{Tabla}}}"
        Me.ToolTip1.SetToolTip(Me.BtnImprimeTabla, "Nombre de La Tabla tal como esta Generada")
        Me.BtnImprimeTabla.UseVisualStyleBackColor = False
        '
        'BtnImprimeCampos
        '
        Me.BtnImprimeCampos.BackColor = System.Drawing.Color.White
        Me.BtnImprimeCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimeCampos.Location = New System.Drawing.Point(268, 55)
        Me.BtnImprimeCampos.Name = "BtnImprimeCampos"
        Me.BtnImprimeCampos.Size = New System.Drawing.Size(89, 25)
        Me.BtnImprimeCampos.TabIndex = 124
        Me.BtnImprimeCampos.Text = "{{{Campos}}}"
        Me.ToolTip1.SetToolTip(Me.BtnImprimeCampos, "Campos de la Tabla, prefijos - sufijos - superior - inferior o multireplace son p" &
        "or plantilla")
        Me.BtnImprimeCampos.UseVisualStyleBackColor = False
        '
        'BtnGuardarCodigo
        '
        Me.BtnGuardarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardarCodigo.Image = CType(resources.GetObject("BtnGuardarCodigo.Image"), System.Drawing.Image)
        Me.BtnGuardarCodigo.Location = New System.Drawing.Point(702, 6)
        Me.BtnGuardarCodigo.Name = "BtnGuardarCodigo"
        Me.BtnGuardarCodigo.Size = New System.Drawing.Size(49, 44)
        Me.BtnGuardarCodigo.TabIndex = 123
        Me.BtnGuardarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnGuardarCodigo, "Actualizar los cambios en el texto")
        Me.BtnGuardarCodigo.UseVisualStyleBackColor = True
        '
        'BtnSubirRemplazado
        '
        Me.BtnSubirRemplazado.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnSubirRemplazado.Location = New System.Drawing.Point(244, 27)
        Me.BtnSubirRemplazado.Name = "BtnSubirRemplazado"
        Me.BtnSubirRemplazado.Size = New System.Drawing.Size(18, 23)
        Me.BtnSubirRemplazado.TabIndex = 122
        Me.BtnSubirRemplazado.UseVisualStyleBackColor = False
        '
        'BtnLimpiarRemplazar
        '
        Me.BtnLimpiarRemplazar.BackColor = System.Drawing.Color.Red
        Me.BtnLimpiarRemplazar.Location = New System.Drawing.Point(225, 81)
        Me.BtnLimpiarRemplazar.Name = "BtnLimpiarRemplazar"
        Me.BtnLimpiarRemplazar.Size = New System.Drawing.Size(18, 23)
        Me.BtnLimpiarRemplazar.TabIndex = 121
        Me.BtnLimpiarRemplazar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Red
        Me.BtnLimpiar.Location = New System.Drawing.Point(225, 27)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(18, 23)
        Me.BtnLimpiar.TabIndex = 120
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnRemplazar
        '
        Me.BtnRemplazar.BackColor = System.Drawing.Color.White
        Me.BtnRemplazar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemplazar.Image = CType(resources.GetObject("BtnRemplazar.Image"), System.Drawing.Image)
        Me.BtnRemplazar.Location = New System.Drawing.Point(323, 7)
        Me.BtnRemplazar.Name = "BtnRemplazar"
        Me.BtnRemplazar.Size = New System.Drawing.Size(49, 43)
        Me.BtnRemplazar.TabIndex = 118
        Me.BtnRemplazar.Text = "-"
        Me.ToolTip1.SetToolTip(Me.BtnRemplazar, "Previsualizar Cambios")
        Me.BtnRemplazar.UseVisualStyleBackColor = False
        '
        'BtnBajarFuente
        '
        Me.BtnBajarFuente.BackColor = System.Drawing.Color.White
        Me.BtnBajarFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBajarFuente.Image = CType(resources.GetObject("BtnBajarFuente.Image"), System.Drawing.Image)
        Me.BtnBajarFuente.Location = New System.Drawing.Point(432, 7)
        Me.BtnBajarFuente.Name = "BtnBajarFuente"
        Me.BtnBajarFuente.Size = New System.Drawing.Size(49, 43)
        Me.BtnBajarFuente.TabIndex = 117
        Me.BtnBajarFuente.Text = "-"
        Me.ToolTip1.SetToolTip(Me.BtnBajarFuente, "Disminuir tamaño de letra")
        Me.BtnBajarFuente.UseVisualStyleBackColor = False
        '
        'BtnSubirFuente
        '
        Me.BtnSubirFuente.BackColor = System.Drawing.Color.White
        Me.BtnSubirFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubirFuente.Image = CType(resources.GetObject("BtnSubirFuente.Image"), System.Drawing.Image)
        Me.BtnSubirFuente.Location = New System.Drawing.Point(377, 7)
        Me.BtnSubirFuente.Name = "BtnSubirFuente"
        Me.BtnSubirFuente.Size = New System.Drawing.Size(49, 43)
        Me.BtnSubirFuente.TabIndex = 116
        Me.ToolTip1.SetToolTip(Me.BtnSubirFuente, "Aumentar Tamaño de Letra")
        Me.BtnSubirFuente.UseVisualStyleBackColor = False
        '
        'BtnBuscarYPintar
        '
        Me.BtnBuscarYPintar.BackColor = System.Drawing.Color.White
        Me.BtnBuscarYPintar.Image = CType(resources.GetObject("BtnBuscarYPintar.Image"), System.Drawing.Image)
        Me.BtnBuscarYPintar.Location = New System.Drawing.Point(268, 7)
        Me.BtnBuscarYPintar.Name = "BtnBuscarYPintar"
        Me.BtnBuscarYPintar.Size = New System.Drawing.Size(49, 43)
        Me.BtnBuscarYPintar.TabIndex = 99
        Me.ToolTip1.SetToolTip(Me.BtnBuscarYPintar, "Buscar en el Texto")
        Me.BtnBuscarYPintar.UseVisualStyleBackColor = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.RichTextboxRichTextBox)
        Me.TabPage5.Controls.Add(TextoEnriquecidoIDLabel)
        Me.TabPage5.Controls.Add(Me.TextoEnriquecidoIDTextBox)
        Me.TabPage5.Controls.Add(Me.Panel10)
        Me.TabPage5.Location = New System.Drawing.Point(4, 27)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(760, 576)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Descripciones"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'RichTextboxRichTextBox
        '
        Me.RichTextboxRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, "RichTextbox", True))
        Me.RichTextboxRichTextBox.Location = New System.Drawing.Point(6, 56)
        Me.RichTextboxRichTextBox.Name = "RichTextboxRichTextBox"
        Me.RichTextboxRichTextBox.Size = New System.Drawing.Size(746, 513)
        Me.RichTextboxRichTextBox.TabIndex = 92
        Me.RichTextboxRichTextBox.Text = ""
        '
        'SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource
        '
        Me.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource.DataMember = "SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID"
        Me.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataSetTablasYCampos
        '
        Me.DataSetTablasYCampos.DataSetName = "DataSetTablasYCampos"
        Me.DataSetTablasYCampos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextoEnriquecidoIDTextBox
        '
        Me.TextoEnriquecidoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, "TextoEnriquecidoID", True))
        Me.TextoEnriquecidoIDTextBox.Location = New System.Drawing.Point(622, 543)
        Me.TextoEnriquecidoIDTextBox.Name = "TextoEnriquecidoIDTextBox"
        Me.TextoEnriquecidoIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TextoEnriquecidoIDTextBox.TabIndex = 93
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.BtnActualizar)
        Me.Panel10.Controls.Add(Me.Nuevo_Menu_TextoEnriquecido)
        Me.Panel10.Controls.Add(Me.BtnColor)
        Me.Panel10.Controls.Add(Me.BtnDerecha)
        Me.Panel10.Controls.Add(Me.BtnFuentes)
        Me.Panel10.Controls.Add(Me.BtnCentrar)
        Me.Panel10.Controls.Add(Me.Cancelar_Menu_TextoEnriquecido)
        Me.Panel10.Controls.Add(Me.Eliminar_Menu_TextoEnriquecido)
        Me.Panel10.Controls.Add(Me.Editar_Menu_TextoEnriquecido)
        Me.Panel10.Controls.Add(Me.Actualizar_Menu_TextoEnriquecido)
        Me.Panel10.Controls.Add(Me.Guardar_Menu_TextoEnriquecido)
        Me.Panel10.Controls.Add(Me.BtnIzquierda)
        Me.Panel10.Location = New System.Drawing.Point(6, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(746, 46)
        Me.Panel10.TabIndex = 91
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnActualizar.Location = New System.Drawing.Point(697, 4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(41, 36)
        Me.BtnActualizar.TabIndex = 141
        Me.BtnActualizar.Text = "-->"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Nuevo_Menu_TextoEnriquecido
        '
        Me.Nuevo_Menu_TextoEnriquecido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_TextoEnriquecido.Image = CType(resources.GetObject("Nuevo_Menu_TextoEnriquecido.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_TextoEnriquecido.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_TextoEnriquecido.Name = "Nuevo_Menu_TextoEnriquecido"
        Me.Nuevo_Menu_TextoEnriquecido.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_TextoEnriquecido.TabIndex = 70
        Me.Nuevo_Menu_TextoEnriquecido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_TextoEnriquecido.UseVisualStyleBackColor = True
        '
        'BtnColor
        '
        Me.BtnColor.Location = New System.Drawing.Point(523, 8)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(75, 28)
        Me.BtnColor.TabIndex = 140
        Me.BtnColor.Text = "Color"
        Me.BtnColor.UseVisualStyleBackColor = True
        '
        'BtnDerecha
        '
        Me.BtnDerecha.Location = New System.Drawing.Point(373, 4)
        Me.BtnDerecha.Name = "BtnDerecha"
        Me.BtnDerecha.Size = New System.Drawing.Size(41, 36)
        Me.BtnDerecha.TabIndex = 138
        Me.BtnDerecha.Text = "-->"
        Me.BtnDerecha.UseVisualStyleBackColor = True
        '
        'BtnFuentes
        '
        Me.BtnFuentes.Location = New System.Drawing.Point(435, 8)
        Me.BtnFuentes.Name = "BtnFuentes"
        Me.BtnFuentes.Size = New System.Drawing.Size(75, 28)
        Me.BtnFuentes.TabIndex = 139
        Me.BtnFuentes.Text = "Fuente"
        Me.BtnFuentes.UseVisualStyleBackColor = True
        '
        'BtnCentrar
        '
        Me.BtnCentrar.Location = New System.Drawing.Point(326, 5)
        Me.BtnCentrar.Name = "BtnCentrar"
        Me.BtnCentrar.Size = New System.Drawing.Size(41, 36)
        Me.BtnCentrar.TabIndex = 137
        Me.BtnCentrar.Text = "="
        Me.BtnCentrar.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_TextoEnriquecido
        '
        Me.Cancelar_Menu_TextoEnriquecido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_TextoEnriquecido.Image = CType(resources.GetObject("Cancelar_Menu_TextoEnriquecido.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_TextoEnriquecido.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_TextoEnriquecido.Name = "Cancelar_Menu_TextoEnriquecido"
        Me.Cancelar_Menu_TextoEnriquecido.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_TextoEnriquecido.TabIndex = 75
        Me.Cancelar_Menu_TextoEnriquecido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_TextoEnriquecido.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_TextoEnriquecido
        '
        Me.Eliminar_Menu_TextoEnriquecido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_TextoEnriquecido.Image = CType(resources.GetObject("Eliminar_Menu_TextoEnriquecido.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_TextoEnriquecido.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_TextoEnriquecido.Name = "Eliminar_Menu_TextoEnriquecido"
        Me.Eliminar_Menu_TextoEnriquecido.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_TextoEnriquecido.TabIndex = 72
        Me.Eliminar_Menu_TextoEnriquecido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_TextoEnriquecido.UseVisualStyleBackColor = True
        '
        'Editar_Menu_TextoEnriquecido
        '
        Me.Editar_Menu_TextoEnriquecido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_TextoEnriquecido.Image = CType(resources.GetObject("Editar_Menu_TextoEnriquecido.Image"), System.Drawing.Image)
        Me.Editar_Menu_TextoEnriquecido.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_TextoEnriquecido.Name = "Editar_Menu_TextoEnriquecido"
        Me.Editar_Menu_TextoEnriquecido.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_TextoEnriquecido.TabIndex = 74
        Me.Editar_Menu_TextoEnriquecido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_TextoEnriquecido.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_TextoEnriquecido
        '
        Me.Actualizar_Menu_TextoEnriquecido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_TextoEnriquecido.Image = CType(resources.GetObject("Actualizar_Menu_TextoEnriquecido.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_TextoEnriquecido.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_TextoEnriquecido.Name = "Actualizar_Menu_TextoEnriquecido"
        Me.Actualizar_Menu_TextoEnriquecido.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_TextoEnriquecido.TabIndex = 73
        Me.Actualizar_Menu_TextoEnriquecido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_TextoEnriquecido.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_TextoEnriquecido
        '
        Me.Guardar_Menu_TextoEnriquecido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_TextoEnriquecido.Image = CType(resources.GetObject("Guardar_Menu_TextoEnriquecido.Image"), System.Drawing.Image)
        Me.Guardar_Menu_TextoEnriquecido.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_TextoEnriquecido.Name = "Guardar_Menu_TextoEnriquecido"
        Me.Guardar_Menu_TextoEnriquecido.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_TextoEnriquecido.TabIndex = 71
        Me.Guardar_Menu_TextoEnriquecido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_TextoEnriquecido.UseVisualStyleBackColor = True
        '
        'BtnIzquierda
        '
        Me.BtnIzquierda.Location = New System.Drawing.Point(279, 5)
        Me.BtnIzquierda.Name = "BtnIzquierda"
        Me.BtnIzquierda.Size = New System.Drawing.Size(41, 36)
        Me.BtnIzquierda.TabIndex = 136
        Me.BtnIzquierda.Text = "<--"
        Me.BtnIzquierda.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.MultiReplaceTextBox)
        Me.TabPage3.Controls.Add(Me.TxtPrevisualizar)
        Me.TabPage3.Controls.Add(Me.CboTiposDatos)
        Me.TabPage3.Controls.Add(MultiReplaceLabel)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Panel8)
        Me.TabPage3.Controls.Add(SeparadorCamposLabel)
        Me.TabPage3.Controls.Add(Me.SeparadorCamposTextBox)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(760, 576)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tratamiento Campos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MultiReplaceTextBox
        '
        Me.MultiReplaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "MultiReplace", True))
        Me.MultiReplaceTextBox.Location = New System.Drawing.Point(333, 255)
        Me.MultiReplaceTextBox.Multiline = True
        Me.MultiReplaceTextBox.Name = "MultiReplaceTextBox"
        Me.MultiReplaceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MultiReplaceTextBox.Size = New System.Drawing.Size(419, 101)
        Me.MultiReplaceTextBox.TabIndex = 163
        '
        'SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource
        '
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource.DataMember = "SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteID"
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'TxtPrevisualizar
        '
        Me.TxtPrevisualizar.Location = New System.Drawing.Point(333, 123)
        Me.TxtPrevisualizar.Multiline = True
        Me.TxtPrevisualizar.Name = "TxtPrevisualizar"
        Me.TxtPrevisualizar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtPrevisualizar.Size = New System.Drawing.Size(419, 100)
        Me.TxtPrevisualizar.TabIndex = 161
        '
        'CboTiposDatos
        '
        Me.CboTiposDatos.DataSource = Me.TiposBindingSource
        Me.CboTiposDatos.DisplayMember = "Tipo"
        Me.CboTiposDatos.FormattingEnabled = True
        Me.CboTiposDatos.Location = New System.Drawing.Point(114, 64)
        Me.CboTiposDatos.Name = "CboTiposDatos"
        Me.CboTiposDatos.Size = New System.Drawing.Size(213, 26)
        Me.CboTiposDatos.TabIndex = 158
        Me.CboTiposDatos.ValueMember = "Tipo"
        '
        'TiposBindingSource
        '
        Me.TiposBindingSource.DataMember = "Tipos"
        Me.TiposBindingSource.DataSource = Me.DataSetAdministracion
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(333, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 18)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Previsualizacion del Campo"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.SuperiorTextBox)
        Me.Panel8.Controls.Add(Me.PrefijoTextBox)
        Me.Panel8.Controls.Add(PrefijoLabel)
        Me.Panel8.Controls.Add(InferiorLabel)
        Me.Panel8.Controls.Add(SuperiorLabel)
        Me.Panel8.Controls.Add(Me.InferiorTextBox)
        Me.Panel8.Controls.Add(Me.SufijoTextBox)
        Me.Panel8.Controls.Add(SufijoLabel)
        Me.Panel8.Location = New System.Drawing.Point(6, 102)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(321, 254)
        Me.Panel8.TabIndex = 160
        '
        'SuperiorTextBox
        '
        Me.SuperiorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "Superior", True))
        Me.SuperiorTextBox.Location = New System.Drawing.Point(109, 6)
        Me.SuperiorTextBox.Multiline = True
        Me.SuperiorTextBox.Name = "SuperiorTextBox"
        Me.SuperiorTextBox.Size = New System.Drawing.Size(100, 80)
        Me.SuperiorTextBox.TabIndex = 156
        '
        'PrefijoTextBox
        '
        Me.PrefijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "Prefijo", True))
        Me.PrefijoTextBox.Location = New System.Drawing.Point(9, 86)
        Me.PrefijoTextBox.Multiline = True
        Me.PrefijoTextBox.Name = "PrefijoTextBox"
        Me.PrefijoTextBox.Size = New System.Drawing.Size(100, 80)
        Me.PrefijoTextBox.TabIndex = 155
        '
        'InferiorTextBox
        '
        Me.InferiorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "Inferior", True))
        Me.InferiorTextBox.Location = New System.Drawing.Point(109, 166)
        Me.InferiorTextBox.Multiline = True
        Me.InferiorTextBox.Name = "InferiorTextBox"
        Me.InferiorTextBox.Size = New System.Drawing.Size(100, 80)
        Me.InferiorTextBox.TabIndex = 158
        '
        'SufijoTextBox
        '
        Me.SufijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "Sufijo", True))
        Me.SufijoTextBox.Location = New System.Drawing.Point(209, 86)
        Me.SufijoTextBox.Multiline = True
        Me.SufijoTextBox.Name = "SufijoTextBox"
        Me.SufijoTextBox.Size = New System.Drawing.Size(100, 80)
        Me.SufijoTextBox.TabIndex = 157
        '
        'SeparadorCamposTextBox
        '
        Me.SeparadorCamposTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "SeparadorCampos", True))
        Me.SeparadorCamposTextBox.Location = New System.Drawing.Point(496, 60)
        Me.SeparadorCamposTextBox.Name = "SeparadorCamposTextBox"
        Me.SeparadorCamposTextBox.Size = New System.Drawing.Size(256, 26)
        Me.SeparadorCamposTextBox.TabIndex = 159
        Me.SeparadorCamposTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Tipo de Dato"
        '
        'SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.MultiReplace, Me.DataGridViewTextBoxColumn12})
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ContextMenuStrip = Me.CM_TiposDatos
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(8, 364)
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowTemplate.Height = 27
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(744, 206)
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 91
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 140
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Prefijo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Prefijo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Superior"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Superior"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Sufijo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Sufijo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Inferior"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Inferior"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'MultiReplace
        '
        Me.MultiReplace.DataPropertyName = "MultiReplace"
        Me.MultiReplace.HeaderText = "MultiReplace"
        Me.MultiReplace.Name = "MultiReplace"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SeparadorCampos"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Separador Campos"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'CM_TiposDatos
        '
        Me.CM_TiposDatos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarRegistroToolStripMenuItem})
        Me.CM_TiposDatos.Name = "CM_TiposDatos"
        Me.CM_TiposDatos.Size = New System.Drawing.Size(156, 26)
        '
        'CopiarRegistroToolStripMenuItem
        '
        Me.CopiarRegistroToolStripMenuItem.Name = "CopiarRegistroToolStripMenuItem"
        Me.CopiarRegistroToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CopiarRegistroToolStripMenuItem.Text = "Copiar Registro"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.BtnPrevisualizar)
        Me.Panel7.Controls.Add(Me.Nuevo_Menu_CampoComponentes)
        Me.Panel7.Controls.Add(Me.Cancelar_Menu_CampoComponentes)
        Me.Panel7.Controls.Add(Me.Eliminar_Menu_CampoComponentes)
        Me.Panel7.Controls.Add(Me.Editar_Menu_CampoComponentes)
        Me.Panel7.Controls.Add(Me.Actualizar_Menu_CampoComponentes)
        Me.Panel7.Controls.Add(Me.Guardar_Menu_CampoComponentes)
        Me.Panel7.Location = New System.Drawing.Point(6, 6)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(746, 46)
        Me.Panel7.TabIndex = 91
        '
        'BtnPrevisualizar
        '
        Me.BtnPrevisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrevisualizar.Image = CType(resources.GetObject("BtnPrevisualizar.Image"), System.Drawing.Image)
        Me.BtnPrevisualizar.Location = New System.Drawing.Point(280, 3)
        Me.BtnPrevisualizar.Name = "BtnPrevisualizar"
        Me.BtnPrevisualizar.Size = New System.Drawing.Size(40, 38)
        Me.BtnPrevisualizar.TabIndex = 77
        Me.BtnPrevisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrevisualizar.UseVisualStyleBackColor = True
        '
        'Nuevo_Menu_CampoComponentes
        '
        Me.Nuevo_Menu_CampoComponentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_CampoComponentes.Image = CType(resources.GetObject("Nuevo_Menu_CampoComponentes.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_CampoComponentes.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_CampoComponentes.Name = "Nuevo_Menu_CampoComponentes"
        Me.Nuevo_Menu_CampoComponentes.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_CampoComponentes.TabIndex = 70
        Me.Nuevo_Menu_CampoComponentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_CampoComponentes.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_CampoComponentes
        '
        Me.Cancelar_Menu_CampoComponentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_CampoComponentes.Image = CType(resources.GetObject("Cancelar_Menu_CampoComponentes.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_CampoComponentes.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_CampoComponentes.Name = "Cancelar_Menu_CampoComponentes"
        Me.Cancelar_Menu_CampoComponentes.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_CampoComponentes.TabIndex = 75
        Me.Cancelar_Menu_CampoComponentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_CampoComponentes.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_CampoComponentes
        '
        Me.Eliminar_Menu_CampoComponentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_CampoComponentes.Image = CType(resources.GetObject("Eliminar_Menu_CampoComponentes.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_CampoComponentes.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_CampoComponentes.Name = "Eliminar_Menu_CampoComponentes"
        Me.Eliminar_Menu_CampoComponentes.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_CampoComponentes.TabIndex = 72
        Me.Eliminar_Menu_CampoComponentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_CampoComponentes.UseVisualStyleBackColor = True
        '
        'Editar_Menu_CampoComponentes
        '
        Me.Editar_Menu_CampoComponentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_CampoComponentes.Image = CType(resources.GetObject("Editar_Menu_CampoComponentes.Image"), System.Drawing.Image)
        Me.Editar_Menu_CampoComponentes.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_CampoComponentes.Name = "Editar_Menu_CampoComponentes"
        Me.Editar_Menu_CampoComponentes.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_CampoComponentes.TabIndex = 74
        Me.Editar_Menu_CampoComponentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_CampoComponentes.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_CampoComponentes
        '
        Me.Actualizar_Menu_CampoComponentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_CampoComponentes.Image = CType(resources.GetObject("Actualizar_Menu_CampoComponentes.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_CampoComponentes.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_CampoComponentes.Name = "Actualizar_Menu_CampoComponentes"
        Me.Actualizar_Menu_CampoComponentes.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_CampoComponentes.TabIndex = 73
        Me.Actualizar_Menu_CampoComponentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_CampoComponentes.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_CampoComponentes
        '
        Me.Guardar_Menu_CampoComponentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_CampoComponentes.Image = CType(resources.GetObject("Guardar_Menu_CampoComponentes.Image"), System.Drawing.Image)
        Me.Guardar_Menu_CampoComponentes.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_CampoComponentes.Name = "Guardar_Menu_CampoComponentes"
        Me.Guardar_Menu_CampoComponentes.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_CampoComponentes.TabIndex = 71
        Me.Guardar_Menu_CampoComponentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_CampoComponentes.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.TabPage2.Controls.Add(Me.EnunciadoRichTextBox)
        Me.TabPage2.Controls.Add(Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView)
        Me.TabPage2.Controls.Add(Me.SP_CARGA_CONVENSIONES_USADASDataGridView)
        Me.TabPage2.Controls.Add(RequerimientoLabel1)
        Me.TabPage2.Controls.Add(Me.RequerimientoTextBox1)
        Me.TabPage2.Controls.Add(Me.RB_Todas)
        Me.TabPage2.Controls.Add(Me.RB_Plantilla)
        Me.TabPage2.Controls.Add(CONVENSIONESLabel)
        Me.TabPage2.Controls.Add(Me.CONVENSIONESTextBox)
        Me.TabPage2.Controls.Add(Me.RequerimientoTextBox)
        Me.TabPage2.Controls.Add(RequerimientoLabel)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.OrdenDePeticionTextBox)
        Me.TabPage2.Controls.Add(EnunciadoLabel)
        Me.TabPage2.Controls.Add(OrdenDePeticionLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(760, 576)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Requerimientos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EnunciadoRichTextBox
        '
        Me.EnunciadoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, "Enunciado", True))
        Me.EnunciadoRichTextBox.Location = New System.Drawing.Point(7, 72)
        Me.EnunciadoRichTextBox.Name = "EnunciadoRichTextBox"
        Me.EnunciadoRichTextBox.Size = New System.Drawing.Size(745, 54)
        Me.EnunciadoRichTextBox.TabIndex = 115
        Me.EnunciadoRichTextBox.Text = ""
        '
        'SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView
        '
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.AllowUserToAddRows = False
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Italic)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13})
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.DataSource = Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLABindingSource
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.Location = New System.Drawing.Point(502, 217)
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.Name = "SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView"
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.RowHeadersVisible = False
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.Size = New System.Drawing.Size(250, 353)
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView.TabIndex = 113
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Requerimiento"
        Me.DataGridViewTextBoxColumn13.HeaderText = "CONVENSIONES USADAS"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 246
        '
        'SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLABindingSource
        '
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLABindingSource.DataMember = "SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLA"
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLABindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CARGA_CONVENSIONES_USADASDataGridView
        '
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.AllowUserToAddRows = False
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Italic)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.DataSource = Me.SP_CARGA_CONVENSIONES_USADASBindingSource
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.Location = New System.Drawing.Point(502, 217)
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.Name = "SP_CARGA_CONVENSIONES_USADASDataGridView"
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.RowHeadersVisible = False
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.RowTemplate.Height = 27
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.Size = New System.Drawing.Size(250, 353)
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.TabIndex = 110
        Me.SP_CARGA_CONVENSIONES_USADASDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CONVENSIONES"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CONVENSIONES USADAS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 246
        '
        'SP_CARGA_CONVENSIONES_USADASBindingSource
        '
        Me.SP_CARGA_CONVENSIONES_USADASBindingSource.DataMember = "SP_CARGA_CONVENSIONES_USADAS"
        Me.SP_CARGA_CONVENSIONES_USADASBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'RequerimientoTextBox1
        '
        Me.RequerimientoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLABindingSource, "Requerimiento", True))
        Me.RequerimientoTextBox1.Location = New System.Drawing.Point(623, 498)
        Me.RequerimientoTextBox1.Name = "RequerimientoTextBox1"
        Me.RequerimientoTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.RequerimientoTextBox1.TabIndex = 114
        '
        'RB_Todas
        '
        Me.RB_Todas.AutoSize = True
        Me.RB_Todas.Location = New System.Drawing.Point(658, 189)
        Me.RB_Todas.Name = "RB_Todas"
        Me.RB_Todas.Size = New System.Drawing.Size(86, 22)
        Me.RB_Todas.TabIndex = 113
        Me.RB_Todas.Text = "Ver Todas"
        Me.RB_Todas.UseVisualStyleBackColor = True
        '
        'RB_Plantilla
        '
        Me.RB_Plantilla.AutoSize = True
        Me.RB_Plantilla.Checked = True
        Me.RB_Plantilla.Location = New System.Drawing.Point(513, 189)
        Me.RB_Plantilla.Name = "RB_Plantilla"
        Me.RB_Plantilla.Size = New System.Drawing.Size(121, 22)
        Me.RB_Plantilla.TabIndex = 112
        Me.RB_Plantilla.TabStop = True
        Me.RB_Plantilla.Text = "Ver por Plantilla"
        Me.RB_Plantilla.UseVisualStyleBackColor = True
        '
        'CONVENSIONESTextBox
        '
        Me.CONVENSIONESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_CONVENSIONES_USADASBindingSource, "CONVENSIONES", True))
        Me.CONVENSIONESTextBox.Location = New System.Drawing.Point(623, 530)
        Me.CONVENSIONESTextBox.Name = "CONVENSIONESTextBox"
        Me.CONVENSIONESTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CONVENSIONESTextBox.TabIndex = 111
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(ContenidoRelacionLabel)
        Me.TabPage4.Controls.Add(Me.ContenidoRelacionTextBox)
        Me.TabPage4.Controls.Add(Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.TabPage4.Controls.Add(Me.Panel9)
        Me.TabPage4.Controls.Add(Me.BtnCTI)
        Me.TabPage4.Controls.Add(Me.BtnCTD)
        Me.TabPage4.Controls.Add(Me.BtnTI)
        Me.TabPage4.Controls.Add(Me.BtnTD)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(760, 576)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Campos Relacionados"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ContenidoRelacionTextBox
        '
        Me.ContenidoRelacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "ContenidoRelacion", True))
        Me.ContenidoRelacionTextBox.Location = New System.Drawing.Point(6, 184)
        Me.ContenidoRelacionTextBox.Multiline = True
        Me.ContenidoRelacionTextBox.Name = "ContenidoRelacionTextBox"
        Me.ContenidoRelacionTextBox.Size = New System.Drawing.Size(746, 282)
        Me.ContenidoRelacionTextBox.TabIndex = 131
        '
        'SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14})
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(6, 472)
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(746, 98)
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 130
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ContenidoRelacion"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Contenido Relacion"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 740
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Nuevo_Menu_TablasRelacionadas)
        Me.Panel9.Controls.Add(Me.Cancelar_Menu_TablasRelacionadas)
        Me.Panel9.Controls.Add(Me.Eliminar_Menu_TablasRelacionadas)
        Me.Panel9.Controls.Add(Me.Editar_Menu_TablasRelacionadas)
        Me.Panel9.Controls.Add(Me.Actualizar_Menu_TablasRelacionadas)
        Me.Panel9.Controls.Add(Me.Guardar_Menu_TablasRelacionadas)
        Me.Panel9.Location = New System.Drawing.Point(6, 6)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(746, 46)
        Me.Panel9.TabIndex = 130
        '
        'Nuevo_Menu_TablasRelacionadas
        '
        Me.Nuevo_Menu_TablasRelacionadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_TablasRelacionadas.Image = CType(resources.GetObject("Nuevo_Menu_TablasRelacionadas.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_TablasRelacionadas.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_TablasRelacionadas.Name = "Nuevo_Menu_TablasRelacionadas"
        Me.Nuevo_Menu_TablasRelacionadas.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_TablasRelacionadas.TabIndex = 70
        Me.Nuevo_Menu_TablasRelacionadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_TablasRelacionadas.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_TablasRelacionadas
        '
        Me.Cancelar_Menu_TablasRelacionadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_TablasRelacionadas.Image = CType(resources.GetObject("Cancelar_Menu_TablasRelacionadas.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_TablasRelacionadas.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_TablasRelacionadas.Name = "Cancelar_Menu_TablasRelacionadas"
        Me.Cancelar_Menu_TablasRelacionadas.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_TablasRelacionadas.TabIndex = 75
        Me.Cancelar_Menu_TablasRelacionadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_TablasRelacionadas.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_TablasRelacionadas
        '
        Me.Eliminar_Menu_TablasRelacionadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_TablasRelacionadas.Image = CType(resources.GetObject("Eliminar_Menu_TablasRelacionadas.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_TablasRelacionadas.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_TablasRelacionadas.Name = "Eliminar_Menu_TablasRelacionadas"
        Me.Eliminar_Menu_TablasRelacionadas.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_TablasRelacionadas.TabIndex = 72
        Me.Eliminar_Menu_TablasRelacionadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_TablasRelacionadas.UseVisualStyleBackColor = True
        '
        'Editar_Menu_TablasRelacionadas
        '
        Me.Editar_Menu_TablasRelacionadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_TablasRelacionadas.Image = CType(resources.GetObject("Editar_Menu_TablasRelacionadas.Image"), System.Drawing.Image)
        Me.Editar_Menu_TablasRelacionadas.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_TablasRelacionadas.Name = "Editar_Menu_TablasRelacionadas"
        Me.Editar_Menu_TablasRelacionadas.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_TablasRelacionadas.TabIndex = 74
        Me.Editar_Menu_TablasRelacionadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_TablasRelacionadas.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_TablasRelacionadas
        '
        Me.Actualizar_Menu_TablasRelacionadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_TablasRelacionadas.Image = CType(resources.GetObject("Actualizar_Menu_TablasRelacionadas.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_TablasRelacionadas.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_TablasRelacionadas.Name = "Actualizar_Menu_TablasRelacionadas"
        Me.Actualizar_Menu_TablasRelacionadas.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_TablasRelacionadas.TabIndex = 73
        Me.Actualizar_Menu_TablasRelacionadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_TablasRelacionadas.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_TablasRelacionadas
        '
        Me.Guardar_Menu_TablasRelacionadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_TablasRelacionadas.Image = CType(resources.GetObject("Guardar_Menu_TablasRelacionadas.Image"), System.Drawing.Image)
        Me.Guardar_Menu_TablasRelacionadas.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_TablasRelacionadas.Name = "Guardar_Menu_TablasRelacionadas"
        Me.Guardar_Menu_TablasRelacionadas.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_TablasRelacionadas.TabIndex = 71
        Me.Guardar_Menu_TablasRelacionadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_TablasRelacionadas.UseVisualStyleBackColor = True
        '
        'BtnCTI
        '
        Me.BtnCTI.BackColor = System.Drawing.Color.White
        Me.BtnCTI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCTI.Location = New System.Drawing.Point(525, 109)
        Me.BtnCTI.Name = "BtnCTI"
        Me.BtnCTI.Size = New System.Drawing.Size(142, 43)
        Me.BtnCTI.TabIndex = 129
        Me.BtnCTI.Text = "{{{Campo_Ind}}}"
        Me.ToolTip1.SetToolTip(Me.BtnCTI, "Nombre de La Tabla tal como esta Generada")
        Me.BtnCTI.UseVisualStyleBackColor = False
        '
        'BtnCTD
        '
        Me.BtnCTD.BackColor = System.Drawing.Color.White
        Me.BtnCTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCTD.Location = New System.Drawing.Point(93, 109)
        Me.BtnCTD.Name = "BtnCTD"
        Me.BtnCTD.Size = New System.Drawing.Size(146, 43)
        Me.BtnCTD.TabIndex = 128
        Me.BtnCTD.Text = "{{{Campo_Dep}}}"
        Me.ToolTip1.SetToolTip(Me.BtnCTD, "Nombre de La Tabla tal como esta Generada")
        Me.BtnCTD.UseVisualStyleBackColor = False
        '
        'BtnTI
        '
        Me.BtnTI.BackColor = System.Drawing.Color.White
        Me.BtnTI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTI.Location = New System.Drawing.Point(568, 62)
        Me.BtnTI.Name = "BtnTI"
        Me.BtnTI.Size = New System.Drawing.Size(137, 43)
        Me.BtnTI.TabIndex = 127
        Me.BtnTI.Text = "{{{Tabla_Ind}}}"
        Me.ToolTip1.SetToolTip(Me.BtnTI, "Nombre de La Tabla tal como esta Generada")
        Me.BtnTI.UseVisualStyleBackColor = False
        '
        'BtnTD
        '
        Me.BtnTD.BackColor = System.Drawing.Color.White
        Me.BtnTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTD.Location = New System.Drawing.Point(54, 62)
        Me.BtnTD.Name = "BtnTD"
        Me.BtnTD.Size = New System.Drawing.Size(137, 43)
        Me.BtnTD.TabIndex = 126
        Me.BtnTD.Text = "{{{Tabla_Dep}}}"
        Me.ToolTip1.SetToolTip(Me.BtnTD, "Nombre de La Tabla tal como esta Generada")
        Me.BtnTD.UseVisualStyleBackColor = False
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 27)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(760, 576)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Tratamiento Tablas"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(450, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Recorrera las tablas y aplicara el nombre de cada una en el siguiente texto"
        '
        'SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'Cbo_TipoDato
        '
        Me.Cbo_TipoDato.FormattingEnabled = True
        Me.Cbo_TipoDato.Location = New System.Drawing.Point(259, 61)
        Me.Cbo_TipoDato.Name = "Cbo_TipoDato"
        Me.Cbo_TipoDato.Size = New System.Drawing.Size(100, 26)
        Me.Cbo_TipoDato.Sorted = True
        Me.Cbo_TipoDato.TabIndex = 152
        '
        'RelacionTablasIDTextBox
        '
        Me.RelacionTablasIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "RelacionTablasID", True))
        Me.RelacionTablasIDTextBox.Location = New System.Drawing.Point(606, 382)
        Me.RelacionTablasIDTextBox.Name = "RelacionTablasIDTextBox"
        Me.RelacionTablasIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RelacionTablasIDTextBox.TabIndex = 132
        '
        'NombreGrupoTipoDeDatoTextBox1
        '
        Me.NombreGrupoTipoDeDatoTextBox1.Location = New System.Drawing.Point(606, 98)
        Me.NombreGrupoTipoDeDatoTextBox1.Name = "NombreGrupoTipoDeDatoTextBox1"
        Me.NombreGrupoTipoDeDatoTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.NombreGrupoTipoDeDatoTextBox1.TabIndex = 119
        '
        'TipoCampoIDTextBox
        '
        Me.TipoCampoIDTextBox.Location = New System.Drawing.Point(606, 223)
        Me.TipoCampoIDTextBox.Name = "TipoCampoIDTextBox"
        Me.TipoCampoIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TipoCampoIDTextBox.TabIndex = 121
        '
        'CampoComponenteIDTextBox
        '
        Me.CampoComponenteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "CampoComponenteID", True))
        Me.CampoComponenteIDTextBox.Location = New System.Drawing.Point(606, 255)
        Me.CampoComponenteIDTextBox.Name = "CampoComponenteIDTextBox"
        Me.CampoComponenteIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CampoComponenteIDTextBox.TabIndex = 122
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(606, 289)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TipoTextBox.TabIndex = 154
        '
        'XTablaTextBox
        '
        Me.XTablaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "XTabla", True))
        Me.XTablaTextBox.Location = New System.Drawing.Point(606, 321)
        Me.XTablaTextBox.Name = "XTablaTextBox"
        Me.XTablaTextBox.Size = New System.Drawing.Size(100, 26)
        Me.XTablaTextBox.TabIndex = 156
        '
        'TimerGuardarComponente
        '
        Me.TimerGuardarComponente.Interval = 1000
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CampoComponentes_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CampoComponentes_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CamposDeTablas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_ComponentesContenidoProvisional_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasRelacionadas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasRelacionadas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasRelacionadas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TextoEnriquecido_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TextoEnriquecido_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TextoEnriquecido_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = GeneradorCod.DataSetTablasYCamposTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
        '
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_CampoComponentes_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_CampoComponentes_EDICION_ACTUALIZARBindingSource.DataMember = "SP_CampoComponentes_EDICION_ACTUALIZAR"
        Me.SP_CampoComponentes_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_CampoComponentes_EDICION_ELIMINARBindingSource
        '
        Me.SP_CampoComponentes_EDICION_ELIMINARBindingSource.DataMember = "SP_CampoComponentes_EDICION_ELIMINAR"
        Me.SP_CampoComponentes_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CampoComponentes_EDICION_ELIMINARTableAdapter
        '
        Me.SP_CampoComponentes_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_CampoComponentes_EDICION_INSERTARBindingSource
        '
        Me.SP_CampoComponentes_EDICION_INSERTARBindingSource.DataMember = "SP_CampoComponentes_EDICION_INSERTAR"
        Me.SP_CampoComponentes_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CampoComponentes_EDICION_INSERTARTableAdapter
        '
        Me.SP_CampoComponentes_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_CARGA_CONVENSIONES_USADASTableAdapter
        '
        Me.SP_CARGA_CONVENSIONES_USADASTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
        '
        Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasRelacionadas_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_TablasRelacionadas_EDICION_ACTUALIZARBindingSource.DataMember = "SP_TablasRelacionadas_EDICION_ACTUALIZAR"
        Me.SP_TablasRelacionadas_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasRelacionadas_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_TablasRelacionadas_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasRelacionadas_EDICION_ELIMINARBindingSource
        '
        Me.SP_TablasRelacionadas_EDICION_ELIMINARBindingSource.DataMember = "SP_TablasRelacionadas_EDICION_ELIMINAR"
        Me.SP_TablasRelacionadas_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasRelacionadas_EDICION_ELIMINARTableAdapter
        '
        Me.SP_TablasRelacionadas_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasRelacionadas_EDICION_INSERTARBindingSource
        '
        Me.SP_TablasRelacionadas_EDICION_INSERTARBindingSource.DataMember = "SP_TablasRelacionadas_EDICION_INSERTAR"
        Me.SP_TablasRelacionadas_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasRelacionadas_EDICION_INSERTARTableAdapter
        '
        Me.SP_TablasRelacionadas_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter
        '
        Me.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter.ClearBeforeFill = True
        '
        'SP_TextoEnriquecido_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_TextoEnriquecido_EDICION_ACTUALIZARBindingSource.DataMember = "SP_TextoEnriquecido_EDICION_ACTUALIZAR"
        Me.SP_TextoEnriquecido_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TextoEnriquecido_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_TextoEnriquecido_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_TextoEnriquecido_EDICION_ELIMINARBindingSource
        '
        Me.SP_TextoEnriquecido_EDICION_ELIMINARBindingSource.DataMember = "SP_TextoEnriquecido_EDICION_ELIMINAR"
        Me.SP_TextoEnriquecido_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TextoEnriquecido_EDICION_ELIMINARTableAdapter
        '
        Me.SP_TextoEnriquecido_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_TextoEnriquecido_EDICION_INSERTARBindingSource
        '
        Me.SP_TextoEnriquecido_EDICION_INSERTARBindingSource.DataMember = "SP_TextoEnriquecido_EDICION_INSERTAR"
        Me.SP_TextoEnriquecido_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TextoEnriquecido_EDICION_INSERTARTableAdapter
        '
        Me.SP_TextoEnriquecido_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLATableAdapter
        '
        Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLATableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'TecnologiasTableAdapter
        '
        Me.TecnologiasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ELIMINA_SEGUN_PROYECTOTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Proyectos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Proyectos_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Proyectos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tecnologias_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tecnologias_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tipos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tipos_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tipos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.TecnologiasTableAdapter = Me.TecnologiasTableAdapter
        Me.TableAdapterManager.TiposTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_Tecnologias_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_Tecnologias_EDICION_ACTUALIZARBindingSource.DataMember = "SP_Tecnologias_EDICION_ACTUALIZAR"
        Me.SP_Tecnologias_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Tecnologias_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_Tecnologias_EDICION_ELIMINARBindingSource
        '
        Me.SP_Tecnologias_EDICION_ELIMINARBindingSource.DataMember = "SP_Tecnologias_EDICION_ELIMINAR"
        Me.SP_Tecnologias_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Tecnologias_EDICION_ELIMINARTableAdapter
        '
        Me.SP_Tecnologias_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_Tecnologias_EDICION_INSERTARBindingSource
        '
        Me.SP_Tecnologias_EDICION_INSERTARBindingSource.DataMember = "SP_Tecnologias_EDICION_INSERTAR"
        Me.SP_Tecnologias_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Tecnologias_EDICION_INSERTARTableAdapter
        '
        Me.SP_Tecnologias_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.ClearBeforeFill = True
        '
        'SP_Plantillas_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_Plantillas_EDICION_ACTUALIZARBindingSource.DataMember = "SP_Plantillas_EDICION_ACTUALIZAR"
        Me.SP_Plantillas_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Plantillas_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_Plantillas_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_Plantillas_EDICION_ELIMINARBindingSource
        '
        Me.SP_Plantillas_EDICION_ELIMINARBindingSource.DataMember = "SP_Plantillas_EDICION_ELIMINAR"
        Me.SP_Plantillas_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Plantillas_EDICION_ELIMINARTableAdapter
        '
        Me.SP_Plantillas_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_Plantillas_EDICION_INSERTARBindingSource
        '
        Me.SP_Plantillas_EDICION_INSERTARBindingSource.DataMember = "SP_Plantillas_EDICION_INSERTAR"
        Me.SP_Plantillas_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Plantillas_EDICION_INSERTARTableAdapter
        '
        Me.SP_Plantillas_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_Componentes_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_Componentes_EDICION_ACTUALIZARBindingSource.DataMember = "SP_Componentes_EDICION_ACTUALIZAR"
        Me.SP_Componentes_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Componentes_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_Componentes_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_Componentes_EDICION_ELIMINARBindingSource
        '
        Me.SP_Componentes_EDICION_ELIMINARBindingSource.DataMember = "SP_Componentes_EDICION_ELIMINAR"
        Me.SP_Componentes_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Componentes_EDICION_ELIMINARTableAdapter
        '
        Me.SP_Componentes_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_Componentes_EDICION_INSERTARBindingSource
        '
        Me.SP_Componentes_EDICION_INSERTARBindingSource.DataMember = "SP_Componentes_EDICION_INSERTAR"
        Me.SP_Componentes_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Componentes_EDICION_INSERTARTableAdapter
        '
        Me.SP_Componentes_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetAdministracion
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.Position = 0
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource.DataMember = "SP_RequerimientosPlantillas_EDICION_ACTUALIZAR"
        Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource
        '
        Me.SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource.DataMember = "SP_RequerimientosPlantillas_EDICION_ELIMINAR"
        Me.SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter
        '
        Me.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource
        '
        Me.SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource.DataMember = "SP_RequerimientosPlantillas_EDICION_INSERTAR"
        Me.SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter
        '
        Me.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'ValidadaTextBox
        '
        Me.ValidadaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "Validada", True))
        Me.ValidadaTextBox.Location = New System.Drawing.Point(606, 7)
        Me.ValidadaTextBox.Name = "ValidadaTextBox"
        Me.ValidadaTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ValidadaTextBox.TabIndex = 157
        '
        'TiposTableAdapter
        '
        Me.TiposTableAdapter.ClearBeforeFill = True
        '
        'TiposDataGridView
        '
        Me.TiposDataGridView.AllowUserToAddRows = False
        Me.TiposDataGridView.AutoGenerateColumns = False
        Me.TiposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TiposDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn15})
        Me.TiposDataGridView.DataSource = Me.TiposBindingSource
        Me.TiposDataGridView.Location = New System.Drawing.Point(3, 93)
        Me.TiposDataGridView.Name = "TiposDataGridView"
        Me.TiposDataGridView.RowHeadersVisible = False
        Me.TiposDataGridView.Size = New System.Drawing.Size(229, 135)
        Me.TiposDataGridView.TabIndex = 157
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tipoID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tipoID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.ContextMenuStrip = Me.CM_AccionesEdicion
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Codigo", True))
        Me.RichTextBox1.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(259, 7)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 48)
        Me.RichTextBox1.TabIndex = 158
        Me.RichTextBox1.Text = ""
        '
        'CM_AccionesEdicion
        '
        Me.CM_AccionesEdicion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimizarToolStripMenuItem})
        Me.CM_AccionesEdicion.Name = "CM_AccionesEdicion"
        Me.CM_AccionesEdicion.Size = New System.Drawing.Size(128, 26)
        '
        'MinimizarToolStripMenuItem
        '
        Me.MinimizarToolStripMenuItem.Name = "MinimizarToolStripMenuItem"
        Me.MinimizarToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.MinimizarToolStripMenuItem.Text = "Minimizar"
        '
        'SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter
        '
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(483, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 18)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "PlantillaIDTextBox"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(452, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 18)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "ComponenteIDTextBox"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(393, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(210, 18)
        Me.Label9.TabIndex = 161
        Me.Label9.Text = "RequerimientoPlantillaIDTextBox"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(516, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 18)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "ControlNulos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(465, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 18)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "TecnologiaIDTextBox"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(379, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(224, 18)
        Me.Label12.TabIndex = 164
        Me.Label12.Text = "NombreGrupoTipoDeDatoTextBox1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(551, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 18)
        Me.Label13.TabIndex = 165
        Me.Label13.Text = "Label13"
        '
        'XBaseTextBox
        '
        Me.XBaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "XBase", True))
        Me.XBaseTextBox.Location = New System.Drawing.Point(606, 353)
        Me.XBaseTextBox.Name = "XBaseTextBox"
        Me.XBaseTextBox.Size = New System.Drawing.Size(100, 26)
        Me.XBaseTextBox.TabIndex = 166
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseBindingSource
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseBindingSource.DataMember = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBase"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseTableAdapter
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseTableAdapter.ClearBeforeFill = True
        '
        'NombreComponenteTextBox1
        '
        Me.NombreComponenteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseBindingSource, "NombreComponente", True))
        Me.NombreComponenteTextBox1.Location = New System.Drawing.Point(606, 414)
        Me.NombreComponenteTextBox1.Name = "NombreComponenteTextBox1"
        Me.NombreComponenteTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.NombreComponenteTextBox1.TabIndex = 168
        '
        'ComponenteIDTextBox1
        '
        Me.ComponenteIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseBindingSource, "ComponenteID", True))
        Me.ComponenteIDTextBox1.Location = New System.Drawing.Point(606, 446)
        Me.ComponenteIDTextBox1.Name = "ComponenteIDTextBox1"
        Me.ComponenteIDTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.ComponenteIDTextBox1.TabIndex = 169
        '
        'SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaBindingSource
        '
        Me.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaBindingSource.DataMember = "SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantilla"
        Me.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaTableAdapter
        '
        Me.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaTableAdapter.ClearBeforeFill = True
        '
        'PanelConfiguracion
        '
        Me.PanelConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelConfiguracion.Controls.Add(Me.RichTextBox1)
        Me.PanelConfiguracion.Controls.Add(Me.TipoTextBox)
        Me.PanelConfiguracion.Controls.Add(TipoLabel)
        Me.PanelConfiguracion.Controls.Add(Me.XTablaTextBox)
        Me.PanelConfiguracion.Controls.Add(XTablaLabel1)
        Me.PanelConfiguracion.Controls.Add(Me.RelacionTablasIDTextBox)
        Me.PanelConfiguracion.Controls.Add(RelacionTablasIDLabel)
        Me.PanelConfiguracion.Controls.Add(Me.Label13)
        Me.PanelConfiguracion.Controls.Add(Me.XBaseTextBox)
        Me.PanelConfiguracion.Controls.Add(Me.Label12)
        Me.PanelConfiguracion.Controls.Add(XBaseLabel1)
        Me.PanelConfiguracion.Controls.Add(Me.Label11)
        Me.PanelConfiguracion.Controls.Add(Me.NombreComponenteTextBox1)
        Me.PanelConfiguracion.Controls.Add(Me.Label10)
        Me.PanelConfiguracion.Controls.Add(NombreComponenteLabel1)
        Me.PanelConfiguracion.Controls.Add(Me.Label9)
        Me.PanelConfiguracion.Controls.Add(Me.ComponenteIDTextBox1)
        Me.PanelConfiguracion.Controls.Add(Me.Label8)
        Me.PanelConfiguracion.Controls.Add(ComponenteIDLabel)
        Me.PanelConfiguracion.Controls.Add(Me.Label7)
        Me.PanelConfiguracion.Controls.Add(Me.Cbo_TipoDato)
        Me.PanelConfiguracion.Controls.Add(Me.TiposDataGridView)
        Me.PanelConfiguracion.Controls.Add(Me.TecnologiaIDTextBox)
        Me.PanelConfiguracion.Controls.Add(ValidadaLabel)
        Me.PanelConfiguracion.Controls.Add(Me.ControlNulos)
        Me.PanelConfiguracion.Controls.Add(Me.ValidadaTextBox)
        Me.PanelConfiguracion.Controls.Add(Me.PlantillaIDTextBox)
        Me.PanelConfiguracion.Controls.Add(CampoComponenteIDLabel)
        Me.PanelConfiguracion.Controls.Add(Me.ComponenteIDTextBox)
        Me.PanelConfiguracion.Controls.Add(Me.CampoComponenteIDTextBox)
        Me.PanelConfiguracion.Controls.Add(Me.RequerimientoPlantillaIDTextBox)
        Me.PanelConfiguracion.Controls.Add(Me.TipoCampoIDTextBox)
        Me.PanelConfiguracion.Controls.Add(Me.NombreGrupoTipoDeDatoTextBox1)
        Me.PanelConfiguracion.Location = New System.Drawing.Point(582, 5)
        Me.PanelConfiguracion.Name = "PanelConfiguracion"
        Me.PanelConfiguracion.Size = New System.Drawing.Size(721, 599)
        Me.PanelConfiguracion.TabIndex = 170
        '
        'FrmTecnologias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 611)
        Me.Controls.Add(Me.TabPanelControl)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(TecnologiaIDLabel)
        Me.Controls.Add(Me.PanelConfiguracion)
        Me.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Italic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmTecnologias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tecnologias"
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdministracion_.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVEdicionPosicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PanelComponenteBase.ResumeLayout(False)
        Me.PanelComponenteBase.PerformLayout()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.TabPanelControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelGuardado.ResumeLayout(False)
        Me.PanelGuardado.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_TiposDatos.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CARGA_CONVENSIONES_USADASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CARGA_CONVENSIONES_USADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CampoComponentes_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CampoComponentes_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CampoComponentes_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasRelacionadas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasRelacionadas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasRelacionadas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TextoEnriquecido_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TextoEnriquecido_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TextoEnriquecido_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Tecnologias_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Tecnologias_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Tecnologias_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_AccionesEdicion.ResumeLayout(False)
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelConfiguracion.ResumeLayout(False)
        Me.PanelConfiguracion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSetAdministracion As DataSetAdministracion
    Friend WithEvents TecnologiasBindingSource As BindingSource
    Friend WithEvents TecnologiasTableAdapter As DataSetAdministracionTableAdapters.TecnologiasTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAdministracionTableAdapters.TableAdapterManager
    Friend WithEvents TecnologiasDataGridView As DataGridView
    Friend WithEvents NombreTecnologiaTextBox As TextBox
    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Nuevo_Menu_Tecnologias As Button
    Friend WithEvents Cancelar_Menu_Tecnologias As Button
    Friend WithEvents Eliminar_Menu_Tecnologias As Button
    Friend WithEvents Editar_Menu_Tecnologias As Button
    Friend WithEvents Actualizar_Menu_Tecnologias As Button
    Friend WithEvents Guardar_Menu_Tecnologias As Button
    Friend WithEvents TecnologiaIDTextBox As TextBox
    Friend WithEvents SP_Tecnologias_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_Tecnologias_EDICION_ACTUALIZARTableAdapter As DataSetAdministracionTableAdapters.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_Tecnologias_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_Tecnologias_EDICION_ELIMINARTableAdapter As DataSetAdministracionTableAdapters.SP_Tecnologias_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_Tecnologias_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_Tecnologias_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_Tecnologias_EDICION_INSERTARTableAdapter
    Friend WithEvents ControlNulos As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Nuevo_Menu_Plantillas As Button
    Friend WithEvents Cancelar_Menu_Plantillas As Button
    Friend WithEvents Eliminar_Menu_Plantillas As Button
    Friend WithEvents Editar_Menu_Plantillas As Button
    Friend WithEvents Actualizar_Menu_Plantillas As Button
    Friend WithEvents Guardar_Menu_Plantillas As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter As DataSetAdministracionTableAdapters.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView As DataGridView
    Friend WithEvents NombrePlantillaTextBox As TextBox
    Friend WithEvents PlantillaIDTextBox As TextBox
    Friend WithEvents SP_Plantillas_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_EDICION_ACTUALIZARTableAdapter As DataSetAdministracionTableAdapters.SP_Plantillas_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_Plantillas_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_EDICION_ELIMINARTableAdapter As DataSetAdministracionTableAdapters.SP_Plantillas_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_Plantillas_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_Plantillas_EDICION_INSERTARTableAdapter
    Friend WithEvents Nuevo_Menu_Componentes As Button
    Friend WithEvents Cancelar_Menu_Componentes As Button
    Friend WithEvents Eliminar_Menu_Componentes As Button
    Friend WithEvents Editar_Menu_Componentes As Button
    Friend WithEvents Actualizar_Menu_Componentes As Button
    Friend WithEvents Guardar_Menu_Componentes As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents NombreComponenteTextBox As TextBox
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents SP_Componentes_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_Componentes_EDICION_ACTUALIZARTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_Componentes_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_Componentes_EDICION_ELIMINARTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_Componentes_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_Componentes_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_EDICION_INSERTARTableAdapter
    Friend WithEvents ComponenteIDTextBox As TextBox
    Friend WithEvents TxtBuscado As TextBox
    Friend WithEvents TxtRemplazarPor As TextBox
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1 As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents RequerimientoTextBox As TextBox
    Friend WithEvents OrdenDePeticionTextBox As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Nuevo_Menu_RequerimientosPlantillas As Button
    Friend WithEvents Cancelar_Menu_RequerimientosPlantillas As Button
    Friend WithEvents Eliminar_Menu_RequerimientosPlantillas As Button
    Friend WithEvents Editar_Menu_RequerimientosPlantillas As Button
    Friend WithEvents Actualizar_Menu_RequerimientosPlantillas As Button
    Friend WithEvents Guardar_Menu_RequerimientosPlantillas As Button
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter As DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter As DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter
    Friend WithEvents RequerimientoPlantillaIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

    Friend WithEvents TabPanelControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ContenidoComponenteRichTextBox As RichTextBox
    Friend WithEvents BtnSubirFuente As Button
    Friend WithEvents BtnBuscarYPintar As Button
    Friend WithEvents BtnRemplazar As Button
    Friend WithEvents BtnBajarFuente As Button
    Friend WithEvents BtnSubirRemplazado As Button
    Friend WithEvents BtnLimpiarRemplazar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardarCodigo As Button
    Friend WithEvents DataSetTablasYCampos As DataSetTablasYCampos
    Friend WithEvents TableAdapterManager1 As DataSetTablasYCamposTableAdapters.TableAdapterManager

    Friend WithEvents NombreGrupoTipoDeDatoTextBox1 As TextBox

    Friend WithEvents BtnImprimeTabla As Button
    Friend WithEvents BtnImprimeCampos As Button
    Friend WithEvents TipoCampoIDTextBox As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Nuevo_Menu_CampoComponentes As Button
    Friend WithEvents Cancelar_Menu_CampoComponentes As Button
    Friend WithEvents Eliminar_Menu_CampoComponentes As Button
    Friend WithEvents Editar_Menu_CampoComponentes As Button
    Friend WithEvents Actualizar_Menu_CampoComponentes As Button
    Friend WithEvents Guardar_Menu_CampoComponentes As Button
    Friend WithEvents SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents CampoComponenteIDTextBox As TextBox
    Friend WithEvents SeparadorCamposTextBox As TextBox
    Friend WithEvents InferiorTextBox As TextBox
    Friend WithEvents SufijoTextBox As TextBox
    Friend WithEvents SuperiorTextBox As TextBox
    Friend WithEvents PrefijoTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Cbo_TipoDato As ComboBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents SP_CampoComponentes_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_CampoComponentes_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_CampoComponentes_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CampoComponentes_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_CampoComponentes_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_CampoComponentes_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CampoComponentes_EDICION_INSERTARTableAdapter
    Friend WithEvents BtnPrevisualizar As Button
    Friend WithEvents TxtPrevisualizar As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents MultiReplaceTextBox As TextBox
    Friend WithEvents BtnImprimeClavePrincipal As Button
    Friend WithEvents BtnTablaMinuscula As Button
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents SP_CARGA_CONVENSIONES_USADASBindingSource As BindingSource
    Friend WithEvents SP_CARGA_CONVENSIONES_USADASTableAdapter As DataSetTablasYCamposTableAdapters.SP_CARGA_CONVENSIONES_USADASTableAdapter
    Friend WithEvents SP_CARGA_CONVENSIONES_USADASDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CONVENSIONESTextBox As TextBox
    Friend WithEvents BtnTablaPlural As Button
    Friend WithEvents BtnMayusculaAMinuscula As Button
    Friend WithEvents XTablaCheckBox As CheckBox
    Friend WithEvents XTablaTextBox As TextBox
    Friend WithEvents BtnTablaPluralMinuscula As Button
    Friend WithEvents OrdenTextBox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ChkMover As CheckBox
    Friend WithEvents BtnBajarFila As Button
    Friend WithEvents BtnSubirFila As Button
    Friend WithEvents DGVEdicionPosicion As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Orden As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents CM_TiposDatos As ContextMenuStrip
    Friend WithEvents CopiarRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnColor As Button
    Friend WithEvents BtnFuentes As Button
    Friend WithEvents BtnDerecha As Button
    Friend WithEvents BtnCentrar As Button
    Friend WithEvents BtnIzquierda As Button
    Friend WithEvents BtnCamposRelacionados As Button
    Friend WithEvents BtnCTI As Button
    Friend WithEvents BtnCTD As Button
    Friend WithEvents BtnTI As Button
    Friend WithEvents BtnTD As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Nuevo_Menu_TablasRelacionadas As Button
    Friend WithEvents Cancelar_Menu_TablasRelacionadas As Button
    Friend WithEvents Eliminar_Menu_TablasRelacionadas As Button
    Friend WithEvents Editar_Menu_TablasRelacionadas As Button
    Friend WithEvents Actualizar_Menu_TablasRelacionadas As Button
    Friend WithEvents Guardar_Menu_TablasRelacionadas As Button
    Friend WithEvents SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents ContenidoRelacionTextBox As TextBox
    Friend WithEvents SP_TablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents RelacionTablasIDTextBox As TextBox
    Friend WithEvents SP_TablasRelacionadas_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_TablasRelacionadas_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasRelacionadas_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_TablasRelacionadas_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_TablasRelacionadas_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasRelacionadas_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_TablasRelacionadas_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_TablasRelacionadas_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasRelacionadas_EDICION_INSERTARTableAdapter
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Nuevo_Menu_TextoEnriquecido As Button
    Friend WithEvents Cancelar_Menu_TextoEnriquecido As Button
    Friend WithEvents Eliminar_Menu_TextoEnriquecido As Button
    Friend WithEvents Editar_Menu_TextoEnriquecido As Button
    Friend WithEvents Actualizar_Menu_TextoEnriquecido As Button
    Friend WithEvents Guardar_Menu_TextoEnriquecido As Button
    Friend WithEvents SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource As BindingSource
    Friend WithEvents SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_TextoEnriquecido_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter
    Friend WithEvents TextoEnriquecidoIDTextBox As TextBox
    Friend WithEvents RichTextboxRichTextBox As RichTextBox
    Friend WithEvents SP_TextoEnriquecido_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_TextoEnriquecido_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TextoEnriquecido_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_TextoEnriquecido_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_TextoEnriquecido_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TextoEnriquecido_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_TextoEnriquecido_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_TextoEnriquecido_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TextoEnriquecido_EDICION_INSERTARTableAdapter
    Friend WithEvents TimerGuardarComponente As Timer
    Friend WithEvents PanelGuardado As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents RB_Todas As RadioButton
    Friend WithEvents RB_Plantilla As RadioButton
    Friend WithEvents SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLABindingSource As BindingSource
    Friend WithEvents SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLATableAdapter As DataSetTablasYCamposTableAdapters.SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLATableAdapter
    Friend WithEvents SP_CARGA_CONVENSIONES_USADAS_POR_PLANTILLADataGridView As DataGridView
    Friend WithEvents RequerimientoTextBox1 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents BtnTodasLasTablas As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents EnunciadoRichTextBox As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ValidadaCheckBox As CheckBox
    Friend WithEvents ValidadaTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Validada As DataGridViewCheckBoxColumn
    Friend WithEvents TiposBindingSource As BindingSource
    Friend WithEvents TiposTableAdapter As DataSetAdministracionTableAdapters.TiposTableAdapter
    Friend WithEvents TiposDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents CboTiposDatos As ComboBox
    Friend WithEvents ContenidoComponenteCopia As RichTextBox
    Friend WithEvents ChkControlCambios As CheckBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BtnZoom As Button
    Friend WithEvents CM_AccionesEdicion As ContextMenuStrip
    Friend WithEvents MinimizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents MultiReplace As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource As BindingSource
    Friend WithEvents SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents XBaseCheckBox As CheckBox
    Friend WithEvents XBaseTextBox As TextBox
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseBindingSource As BindingSource
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_XBaseTableAdapter
    Friend WithEvents NombreComponenteTextBox1 As TextBox
    Friend WithEvents ComponenteIDTextBox1 As TextBox
    Friend WithEvents SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaBindingSource As BindingSource
    Friend WithEvents SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaTableAdapter
    Friend WithEvents BtnAsignarBase As Button
    Friend WithEvents PanelComponenteBase As Panel
    Friend WithEvents BtnReseteoBase As Button
    Friend WithEvents BtnVerCodigo As Button
    Friend WithEvents PanelConfiguracion As Panel
End Class
