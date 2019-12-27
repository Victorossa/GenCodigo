<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReplace
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
        Dim ComponenteIDLabel As System.Windows.Forms.Label
        Dim PlantillaIDLabel As System.Windows.Forms.Label
        Dim TecnologiaIDLabel As System.Windows.Forms.Label
        Dim EnunciadoLabel As System.Windows.Forms.Label
        Dim ProyectoIDLabel As System.Windows.Forms.Label
        Dim NombreProyectoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim NombreTecnologiaLabel As System.Windows.Forms.Label
        Dim TecnologiaIDLabel1 As System.Windows.Forms.Label
        Dim RequerimientoLabel As System.Windows.Forms.Label
        Dim NombreComponenteLabel As System.Windows.Forms.Label
        Dim NombreTecnologiaLabel1 As System.Windows.Forms.Label
        Dim RequerimientoLabel1 As System.Windows.Forms.Label
        Dim ValorRequerimientoLabel As System.Windows.Forms.Label
        Dim NombreTablaLabel As System.Windows.Forms.Label
        Dim TablaIDLabel As System.Windows.Forms.Label
        Dim CampoIDLabel As System.Windows.Forms.Label
        Dim NombreCampoLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim PrefijoLabel As System.Windows.Forms.Label
        Dim SuperiorLabel As System.Windows.Forms.Label
        Dim SufijoLabel As System.Windows.Forms.Label
        Dim InferiorLabel As System.Windows.Forms.Label
        Dim PlantillaIDLabel1 As System.Windows.Forms.Label
        Dim SeparadorCamposLabel As System.Windows.Forms.Label
        Dim MultiReplaceLabel As System.Windows.Forms.Label
        Dim NombreTablaLabel1 As System.Windows.Forms.Label
        Dim RegistroValorRequerimientoIDLabel As System.Windows.Forms.Label
        Dim ValorRequerimientoLabel1 As System.Windows.Forms.Label
        Dim XTablaLabel As System.Windows.Forms.Label
        Dim NombreTablaLabel2 As System.Windows.Forms.Label
        Dim TablaIDLabel1 As System.Windows.Forms.Label
        Dim CampoIDLabel1 As System.Windows.Forms.Label
        Dim NombreCampoLabel1 As System.Windows.Forms.Label
        Dim TipoLabel1 As System.Windows.Forms.Label
        Dim CampoIDLabel2 As System.Windows.Forms.Label
        Dim TablaIDLabel2 As System.Windows.Forms.Label
        Dim CodigoGeneradoLabel As System.Windows.Forms.Label
        Dim RegistroRelacionesTablasIDLabel As System.Windows.Forms.Label
        Dim RegistroRelacionesTablasIDLabel1 As System.Windows.Forms.Label
        Dim TablaDependienteLabel As System.Windows.Forms.Label
        Dim CampoDependienteLabel As System.Windows.Forms.Label
        Dim TablaIndependienteLabel As System.Windows.Forms.Label
        Dim CampoIndependienteLabel As System.Windows.Forms.Label
        Dim ContenidoRelacionLabel As System.Windows.Forms.Label
        Dim TablaDependienteLabel1 As System.Windows.Forms.Label
        Dim CampoDependienteLabel1 As System.Windows.Forms.Label
        Dim TablaIndependienteLabel1 As System.Windows.Forms.Label
        Dim CampoIndependienteLabel1 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim ProyectosYTecnologiasIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReplace))
        Dim RequerimientoLabel2 As System.Windows.Forms.Label
        Dim ValorRequerimientoLabel2 As System.Windows.Forms.Label
        Dim RegistroValorRequerimientoIDLabel1 As System.Windows.Forms.Label
        Dim ProyectoIDLabel1 As System.Windows.Forms.Label
        Dim RequerimientoLabel3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView = New System.Windows.Forms.DataGridView()
        Me.CM_Plantilla = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarPlantillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TecnologiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.ComponenteIDTextBox = New System.Windows.Forms.TextBox()
        Me.PlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.ControlNulos = New System.Windows.Forms.TextBox()
        Me.TecnologiaIDTextBox = New System.Windows.Forms.TextBox()
        Me.EnunciadoTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView = New System.Windows.Forms.DataGridView()
        Me.CM_EliminandoTecnologias = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarUna = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarTodas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MaximizarPaneles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MinimizarPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Editar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.NombreProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.ProyectosDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProyectoIDTextBox = New System.Windows.Forms.TextBox()
        Me.CM1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MaximizarCodigoGeneradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombreTecnologiaTextBox = New System.Windows.Forms.TextBox()
        Me.TecnologiaID_EliminaRelacion = New System.Windows.Forms.TextBox()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.CM_RelacionesTablas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CrearRelacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarRelaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequerimientoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.BtnRemplazar = New System.Windows.Forms.Button()
        Me.NombreComponenteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTecnologiaTextBox1 = New System.Windows.Forms.TextBox()
        Me.RequerimientoTextBox1 = New System.Windows.Forms.TextBox()
        Me.ValorRequerimientoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chk_Rel = New System.Windows.Forms.CheckBox()
        Me.Nuevo_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Editar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Guardar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.NombreTablaTextBox = New System.Windows.Forms.TextBox()
        Me.TablaIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Editar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Guardar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.CampoIDTextBox = New System.Windows.Forms.TextBox()
        Me.NombreCampoTextBox = New System.Windows.Forms.TextBox()
        Me.Cbo_TipoDato = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.PrefijoTextBox = New System.Windows.Forms.TextBox()
        Me.SuperiorTextBox = New System.Windows.Forms.TextBox()
        Me.SufijoTextBox = New System.Windows.Forms.TextBox()
        Me.InferiorTextBox = New System.Windows.Forms.TextBox()
        Me.PlantillaIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelConf = New System.Windows.Forms.Panel()
        Me.ProyectosYTecnologiasIDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CampoIndependienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TablaIndependienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CampoDependienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.TablaDependienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView = New System.Windows.Forms.DataGridView()
        Me.ContenidoRelacionTextBox = New System.Windows.Forms.TextBox()
        Me.RegistroRelacionesTablasIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RegistroRelacionesTablasIDTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreCampoTextBox1 = New System.Windows.Forms.TextBox()
        Me.CampoIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView = New System.Windows.Forms.DataGridView()
        Me.TablaIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTablaTextBox2 = New System.Windows.Forms.TextBox()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView = New System.Windows.Forms.DataGridView()
        Me.XTablaCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ValorRequerimientoTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RegistroValorRequerimientoIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClavePrincipal = New System.Windows.Forms.TextBox()
        Me.NombreTablaTextBox1 = New System.Windows.Forms.TextBox()
        Me.MultiReplaceTextBox = New System.Windows.Forms.TextBox()
        Me.SeparadorCamposTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValorRequerimientoTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView = New System.Windows.Forms.DataGridView()
        Me.CTI_ = New System.Windows.Forms.TextBox()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView = New System.Windows.Forms.DataGridView()
        Me.TablaIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProyectoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTablaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TI_ = New System.Windows.Forms.TextBox()
        Me.CodigoGeneradoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TD_ = New System.Windows.Forms.TextBox()
        Me.CTD_ = New System.Windows.Forms.TextBox()
        Me.TipoCTD = New System.Windows.Forms.TextBox()
        Me.TipoCTI = New System.Windows.Forms.TextBox()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CampoIndependienteTextBox = New System.Windows.Forms.TextBox()
        Me.TablaIndependienteTextBox = New System.Windows.Forms.TextBox()
        Me.CampoDependienteTextBox = New System.Windows.Forms.TextBox()
        Me.TablaDependienteTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel_Requerimiento = New System.Windows.Forms.Panel()
        Me.BtnCancelarCargue = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnLimpiarValoresRequerimientos = New System.Windows.Forms.Button()
        Me.ValorRequerimiento = New System.Windows.Forms.TextBox()
        Me.BtnEditarValorDeRequerimiento = New System.Windows.Forms.Button()
        Me.BtnConfirmarValorRequerimiento = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Lbl_Requerimiento = New System.Windows.Forms.Label()
        Me.EnunciadoEnRich = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer_CargueValorRequerimientos = New System.Windows.Forms.Timer(Me.components)
        Me.BtnConservarYSeguir = New System.Windows.Forms.Button()
        Me.Timer_EdicionValorRequerimiento = New System.Windows.Forms.Timer(Me.components)
        Me.RequerimientoTextBox2 = New System.Windows.Forms.TextBox()
        Me.ValorRequerimientoTextBox3 = New System.Windows.Forms.TextBox()
        Me.RegistroValorRequerimientoIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.ProyectoIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.RequerimientoLabel4 = New System.Windows.Forms.Label()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTablasYCampos = New GeneradorCod.DataSetTablasYCampos()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter()
        Me.TableAdapterManager1 = New GeneradorCod.DataSetTablasYCamposTableAdapters.TableAdapterManager()
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter()
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter()
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter()
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter()
        Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter()
        Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter()
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter()
        Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter()
        Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_INSERTARTableAdapter()
        Me.SP_CampoComponentes_Segun_Plantilla_TipoTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CampoComponentes_Segun_Plantilla_TipoTableAdapter()
        Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoTableAdapter()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2TableAdapter()
        Me.SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter()
        Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter()
        Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1TableAdapter()
        Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter()
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAdministracion = New GeneradorCod.DataSetAdministracion()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TecnologiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager()
        Me.TecnologiasTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.TecnologiasTableAdapter()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.ProyectosTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.ProyectosTableAdapter()
        Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Proyectos_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_ACTUALIZARTableAdapter()
        Me.SP_Proyectos_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Proyectos_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_ELIMINARTableAdapter()
        Me.SP_Proyectos_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Proyectos_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_INSERTARTableAdapter()
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter()
        Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter()
        Me.ELIMINA_SEGUN_PROYECTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ELIMINA_SEGUN_PROYECTOTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.ELIMINA_SEGUN_PROYECTOTableAdapter()
        Me.SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter()
        ComponenteIDLabel = New System.Windows.Forms.Label()
        PlantillaIDLabel = New System.Windows.Forms.Label()
        TecnologiaIDLabel = New System.Windows.Forms.Label()
        EnunciadoLabel = New System.Windows.Forms.Label()
        ProyectoIDLabel = New System.Windows.Forms.Label()
        NombreProyectoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        NombreTecnologiaLabel = New System.Windows.Forms.Label()
        TecnologiaIDLabel1 = New System.Windows.Forms.Label()
        RequerimientoLabel = New System.Windows.Forms.Label()
        NombreComponenteLabel = New System.Windows.Forms.Label()
        NombreTecnologiaLabel1 = New System.Windows.Forms.Label()
        RequerimientoLabel1 = New System.Windows.Forms.Label()
        ValorRequerimientoLabel = New System.Windows.Forms.Label()
        NombreTablaLabel = New System.Windows.Forms.Label()
        TablaIDLabel = New System.Windows.Forms.Label()
        CampoIDLabel = New System.Windows.Forms.Label()
        NombreCampoLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        PrefijoLabel = New System.Windows.Forms.Label()
        SuperiorLabel = New System.Windows.Forms.Label()
        SufijoLabel = New System.Windows.Forms.Label()
        InferiorLabel = New System.Windows.Forms.Label()
        PlantillaIDLabel1 = New System.Windows.Forms.Label()
        SeparadorCamposLabel = New System.Windows.Forms.Label()
        MultiReplaceLabel = New System.Windows.Forms.Label()
        NombreTablaLabel1 = New System.Windows.Forms.Label()
        RegistroValorRequerimientoIDLabel = New System.Windows.Forms.Label()
        ValorRequerimientoLabel1 = New System.Windows.Forms.Label()
        XTablaLabel = New System.Windows.Forms.Label()
        NombreTablaLabel2 = New System.Windows.Forms.Label()
        TablaIDLabel1 = New System.Windows.Forms.Label()
        CampoIDLabel1 = New System.Windows.Forms.Label()
        NombreCampoLabel1 = New System.Windows.Forms.Label()
        TipoLabel1 = New System.Windows.Forms.Label()
        CampoIDLabel2 = New System.Windows.Forms.Label()
        TablaIDLabel2 = New System.Windows.Forms.Label()
        CodigoGeneradoLabel = New System.Windows.Forms.Label()
        RegistroRelacionesTablasIDLabel = New System.Windows.Forms.Label()
        RegistroRelacionesTablasIDLabel1 = New System.Windows.Forms.Label()
        TablaDependienteLabel = New System.Windows.Forms.Label()
        CampoDependienteLabel = New System.Windows.Forms.Label()
        TablaIndependienteLabel = New System.Windows.Forms.Label()
        CampoIndependienteLabel = New System.Windows.Forms.Label()
        ContenidoRelacionLabel = New System.Windows.Forms.Label()
        TablaDependienteLabel1 = New System.Windows.Forms.Label()
        CampoDependienteLabel1 = New System.Windows.Forms.Label()
        TablaIndependienteLabel1 = New System.Windows.Forms.Label()
        CampoIndependienteLabel1 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        ProyectosYTecnologiasIDLabel = New System.Windows.Forms.Label()
        RequerimientoLabel2 = New System.Windows.Forms.Label()
        ValorRequerimientoLabel2 = New System.Windows.Forms.Label()
        RegistroValorRequerimientoIDLabel1 = New System.Windows.Forms.Label()
        ProyectoIDLabel1 = New System.Windows.Forms.Label()
        RequerimientoLabel3 = New System.Windows.Forms.Label()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_Plantilla.SuspendLayout()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_EliminandoTecnologias.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.PanelAdministracion_.SuspendLayout()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM1.SuspendLayout()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_RelacionesTablas.SuspendLayout()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelConf.SuspendLayout()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel_Requerimiento.SuspendLayout()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Proyectos_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Proyectos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELIMINA_SEGUN_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComponenteIDLabel
        '
        ComponenteIDLabel.AutoSize = True
        ComponenteIDLabel.Location = New System.Drawing.Point(56, 401)
        ComponenteIDLabel.Name = "ComponenteIDLabel"
        ComponenteIDLabel.Size = New System.Drawing.Size(84, 13)
        ComponenteIDLabel.TabIndex = 117
        ComponenteIDLabel.Text = "Componente ID:"
        '
        'PlantillaIDLabel
        '
        PlantillaIDLabel.AutoSize = True
        PlantillaIDLabel.Location = New System.Drawing.Point(80, 340)
        PlantillaIDLabel.Name = "PlantillaIDLabel"
        PlantillaIDLabel.Size = New System.Drawing.Size(60, 13)
        PlantillaIDLabel.TabIndex = 115
        PlantillaIDLabel.Text = "Plantilla ID:"
        '
        'TecnologiaIDLabel
        '
        TecnologiaIDLabel.AutoSize = True
        TecnologiaIDLabel.Location = New System.Drawing.Point(63, 284)
        TecnologiaIDLabel.Name = "TecnologiaIDLabel"
        TecnologiaIDLabel.Size = New System.Drawing.Size(77, 13)
        TecnologiaIDLabel.TabIndex = 112
        TecnologiaIDLabel.Text = "Tecnologia ID:"
        '
        'EnunciadoLabel
        '
        EnunciadoLabel.AutoSize = True
        EnunciadoLabel.Location = New System.Drawing.Point(80, 128)
        EnunciadoLabel.Name = "EnunciadoLabel"
        EnunciadoLabel.Size = New System.Drawing.Size(61, 13)
        EnunciadoLabel.TabIndex = 120
        EnunciadoLabel.Text = "Enunciado:"
        '
        'ProyectoIDLabel
        '
        ProyectoIDLabel.AutoSize = True
        ProyectoIDLabel.Location = New System.Drawing.Point(73, 565)
        ProyectoIDLabel.Name = "ProyectoIDLabel"
        ProyectoIDLabel.Size = New System.Drawing.Size(66, 13)
        ProyectoIDLabel.TabIndex = 122
        ProyectoIDLabel.Text = "Proyecto ID:"
        '
        'NombreProyectoLabel
        '
        NombreProyectoLabel.AutoSize = True
        NombreProyectoLabel.Location = New System.Drawing.Point(8, 52)
        NombreProyectoLabel.Name = "NombreProyectoLabel"
        NombreProyectoLabel.Size = New System.Drawing.Size(92, 13)
        NombreProyectoLabel.TabIndex = 1
        NombreProyectoLabel.Text = "Nombre Proyecto:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(8, 121)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'NombreTecnologiaLabel
        '
        NombreTecnologiaLabel.AutoSize = True
        NombreTecnologiaLabel.Location = New System.Drawing.Point(37, 262)
        NombreTecnologiaLabel.Name = "NombreTecnologiaLabel"
        NombreTecnologiaLabel.Size = New System.Drawing.Size(103, 13)
        NombreTecnologiaLabel.TabIndex = 123
        NombreTecnologiaLabel.Text = "Nombre Tecnologia:"
        '
        'TecnologiaIDLabel1
        '
        TecnologiaIDLabel1.AutoSize = True
        TecnologiaIDLabel1.Location = New System.Drawing.Point(9, 80)
        TecnologiaIDLabel1.Name = "TecnologiaIDLabel1"
        TecnologiaIDLabel1.Size = New System.Drawing.Size(133, 13)
        TecnologiaIDLabel1.TabIndex = 124
        TecnologiaIDLabel1.Text = "Tecnologia ID Eliminacion:"
        '
        'RequerimientoLabel
        '
        RequerimientoLabel.AutoSize = True
        RequerimientoLabel.Location = New System.Drawing.Point(62, 148)
        RequerimientoLabel.Name = "RequerimientoLabel"
        RequerimientoLabel.Size = New System.Drawing.Size(78, 13)
        RequerimientoLabel.TabIndex = 126
        RequerimientoLabel.Text = "Requerimiento:"
        '
        'NombreComponenteLabel
        '
        NombreComponenteLabel.AutoSize = True
        NombreComponenteLabel.Location = New System.Drawing.Point(30, 423)
        NombreComponenteLabel.Name = "NombreComponenteLabel"
        NombreComponenteLabel.Size = New System.Drawing.Size(110, 13)
        NombreComponenteLabel.TabIndex = 132
        NombreComponenteLabel.Text = "Nombre Componente:"
        '
        'NombreTecnologiaLabel1
        '
        NombreTecnologiaLabel1.AutoSize = True
        NombreTecnologiaLabel1.Location = New System.Drawing.Point(40, 57)
        NombreTecnologiaLabel1.Name = "NombreTecnologiaLabel1"
        NombreTecnologiaLabel1.Size = New System.Drawing.Size(103, 13)
        NombreTecnologiaLabel1.TabIndex = 133
        NombreTecnologiaLabel1.Text = "Nombre Tecnologia:"
        '
        'RequerimientoLabel1
        '
        RequerimientoLabel1.AutoSize = True
        RequerimientoLabel1.Location = New System.Drawing.Point(62, 494)
        RequerimientoLabel1.Name = "RequerimientoLabel1"
        RequerimientoLabel1.Size = New System.Drawing.Size(78, 13)
        RequerimientoLabel1.TabIndex = 134
        RequerimientoLabel1.Text = "Requerimiento:"
        '
        'ValorRequerimientoLabel
        '
        ValorRequerimientoLabel.AutoSize = True
        ValorRequerimientoLabel.Location = New System.Drawing.Point(35, 520)
        ValorRequerimientoLabel.Name = "ValorRequerimientoLabel"
        ValorRequerimientoLabel.Size = New System.Drawing.Size(105, 13)
        ValorRequerimientoLabel.TabIndex = 135
        ValorRequerimientoLabel.Text = "Valor Requerimiento:"
        '
        'NombreTablaLabel
        '
        NombreTablaLabel.AutoSize = True
        NombreTablaLabel.Location = New System.Drawing.Point(6, 61)
        NombreTablaLabel.Name = "NombreTablaLabel"
        NombreTablaLabel.Size = New System.Drawing.Size(77, 13)
        NombreTablaLabel.TabIndex = 138
        NombreTablaLabel.Text = "Nombre Tabla:"
        '
        'TablaIDLabel
        '
        TablaIDLabel.AutoSize = True
        TablaIDLabel.Location = New System.Drawing.Point(89, 193)
        TablaIDLabel.Name = "TablaIDLabel"
        TablaIDLabel.Size = New System.Drawing.Size(51, 13)
        TablaIDLabel.TabIndex = 139
        TablaIDLabel.Text = "Tabla ID:"
        '
        'CampoIDLabel
        '
        CampoIDLabel.AutoSize = True
        CampoIDLabel.Location = New System.Drawing.Point(81, 660)
        CampoIDLabel.Name = "CampoIDLabel"
        CampoIDLabel.Size = New System.Drawing.Size(57, 13)
        CampoIDLabel.TabIndex = 147
        CampoIDLabel.Text = "Campo ID:"
        '
        'NombreCampoLabel
        '
        NombreCampoLabel.AutoSize = True
        NombreCampoLabel.Location = New System.Drawing.Point(6, 275)
        NombreCampoLabel.Name = "NombreCampoLabel"
        NombreCampoLabel.Size = New System.Drawing.Size(83, 13)
        NombreCampoLabel.TabIndex = 148
        NombreCampoLabel.Text = "Nombre Campo:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(107, 682)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 151
        TipoLabel.Text = "Tipo:"
        '
        'PrefijoLabel
        '
        PrefijoLabel.AutoSize = True
        PrefijoLabel.Location = New System.Drawing.Point(499, 130)
        PrefijoLabel.Name = "PrefijoLabel"
        PrefijoLabel.Size = New System.Drawing.Size(39, 13)
        PrefijoLabel.TabIndex = 153
        PrefijoLabel.Text = "Prefijo:"
        '
        'SuperiorLabel
        '
        SuperiorLabel.AutoSize = True
        SuperiorLabel.Location = New System.Drawing.Point(552, 98)
        SuperiorLabel.Name = "SuperiorLabel"
        SuperiorLabel.Size = New System.Drawing.Size(49, 13)
        SuperiorLabel.TabIndex = 154
        SuperiorLabel.Text = "Superior:"
        '
        'SufijoLabel
        '
        SufijoLabel.AutoSize = True
        SufijoLabel.Location = New System.Drawing.Point(618, 130)
        SufijoLabel.Name = "SufijoLabel"
        SufijoLabel.Size = New System.Drawing.Size(36, 13)
        SufijoLabel.TabIndex = 155
        SufijoLabel.Text = "Sufijo:"
        '
        'InferiorLabel
        '
        InferiorLabel.AutoSize = True
        InferiorLabel.Location = New System.Drawing.Point(500, 176)
        InferiorLabel.Name = "InferiorLabel"
        InferiorLabel.Size = New System.Drawing.Size(42, 13)
        InferiorLabel.TabIndex = 156
        InferiorLabel.Text = "Inferior:"
        '
        'PlantillaIDLabel1
        '
        PlantillaIDLabel1.AutoSize = True
        PlantillaIDLabel1.Location = New System.Drawing.Point(83, 30)
        PlantillaIDLabel1.Name = "PlantillaIDLabel1"
        PlantillaIDLabel1.Size = New System.Drawing.Size(60, 13)
        PlantillaIDLabel1.TabIndex = 157
        PlantillaIDLabel1.Text = "Plantilla ID:"
        '
        'SeparadorCamposLabel
        '
        SeparadorCamposLabel.AutoSize = True
        SeparadorCamposLabel.Location = New System.Drawing.Point(664, 91)
        SeparadorCamposLabel.Name = "SeparadorCamposLabel"
        SeparadorCamposLabel.Size = New System.Drawing.Size(100, 13)
        SeparadorCamposLabel.TabIndex = 168
        SeparadorCamposLabel.Text = "Separador Campos:"
        '
        'MultiReplaceLabel
        '
        MultiReplaceLabel.AutoSize = True
        MultiReplaceLabel.Location = New System.Drawing.Point(671, 149)
        MultiReplaceLabel.Name = "MultiReplaceLabel"
        MultiReplaceLabel.Size = New System.Drawing.Size(75, 13)
        MultiReplaceLabel.TabIndex = 169
        MultiReplaceLabel.Text = "Multi Replace:"
        '
        'NombreTablaLabel1
        '
        NombreTablaLabel1.AutoSize = True
        NombreTablaLabel1.Location = New System.Drawing.Point(63, 214)
        NombreTablaLabel1.Name = "NombreTablaLabel1"
        NombreTablaLabel1.Size = New System.Drawing.Size(77, 13)
        NombreTablaLabel1.TabIndex = 170
        NombreTablaLabel1.Text = "Nombre Tabla:"
        '
        'RegistroValorRequerimientoIDLabel
        '
        RegistroValorRequerimientoIDLabel.AutoSize = True
        RegistroValorRequerimientoIDLabel.Location = New System.Drawing.Point(13, 617)
        RegistroValorRequerimientoIDLabel.Name = "RegistroValorRequerimientoIDLabel"
        RegistroValorRequerimientoIDLabel.Size = New System.Drawing.Size(161, 13)
        RegistroValorRequerimientoIDLabel.TabIndex = 172
        RegistroValorRequerimientoIDLabel.Text = "Registro Valor Requerimiento ID:"
        '
        'ValorRequerimientoLabel1
        '
        ValorRequerimientoLabel1.AutoSize = True
        ValorRequerimientoLabel1.Location = New System.Drawing.Point(249, 617)
        ValorRequerimientoLabel1.Name = "ValorRequerimientoLabel1"
        ValorRequerimientoLabel1.Size = New System.Drawing.Size(105, 13)
        ValorRequerimientoLabel1.TabIndex = 174
        ValorRequerimientoLabel1.Text = "Valor Requerimiento:"
        '
        'XTablaLabel
        '
        XTablaLabel.AutoSize = True
        XTablaLabel.Location = New System.Drawing.Point(96, 447)
        XTablaLabel.Name = "XTablaLabel"
        XTablaLabel.Size = New System.Drawing.Size(44, 13)
        XTablaLabel.TabIndex = 177
        XTablaLabel.Text = "XTabla:"
        '
        'NombreTablaLabel2
        '
        NombreTablaLabel2.AutoSize = True
        NombreTablaLabel2.Location = New System.Drawing.Point(491, 211)
        NombreTablaLabel2.Name = "NombreTablaLabel2"
        NombreTablaLabel2.Size = New System.Drawing.Size(77, 13)
        NombreTablaLabel2.TabIndex = 178
        NombreTablaLabel2.Text = "Nombre Tabla:"
        '
        'TablaIDLabel1
        '
        TablaIDLabel1.AutoSize = True
        TablaIDLabel1.Location = New System.Drawing.Point(517, 237)
        TablaIDLabel1.Name = "TablaIDLabel1"
        TablaIDLabel1.Size = New System.Drawing.Size(51, 13)
        TablaIDLabel1.TabIndex = 179
        TablaIDLabel1.Text = "Tabla ID:"
        '
        'CampoIDLabel1
        '
        CampoIDLabel1.AutoSize = True
        CampoIDLabel1.Location = New System.Drawing.Point(679, 290)
        CampoIDLabel1.Name = "CampoIDLabel1"
        CampoIDLabel1.Size = New System.Drawing.Size(57, 13)
        CampoIDLabel1.TabIndex = 180
        CampoIDLabel1.Text = "Campo ID:"
        '
        'NombreCampoLabel1
        '
        NombreCampoLabel1.AutoSize = True
        NombreCampoLabel1.Location = New System.Drawing.Point(629, 316)
        NombreCampoLabel1.Name = "NombreCampoLabel1"
        NombreCampoLabel1.Size = New System.Drawing.Size(83, 13)
        NombreCampoLabel1.TabIndex = 181
        NombreCampoLabel1.Text = "Nombre Campo:"
        '
        'TipoLabel1
        '
        TipoLabel1.AutoSize = True
        TipoLabel1.Location = New System.Drawing.Point(681, 340)
        TipoLabel1.Name = "TipoLabel1"
        TipoLabel1.Size = New System.Drawing.Size(31, 13)
        TipoLabel1.TabIndex = 182
        TipoLabel1.Text = "Tipo:"
        '
        'CampoIDLabel2
        '
        CampoIDLabel2.AutoSize = True
        CampoIDLabel2.Location = New System.Drawing.Point(191, 534)
        CampoIDLabel2.Name = "CampoIDLabel2"
        CampoIDLabel2.Size = New System.Drawing.Size(57, 13)
        CampoIDLabel2.TabIndex = 160
        CampoIDLabel2.Text = "Campo ID:"
        '
        'TablaIDLabel2
        '
        TablaIDLabel2.AutoSize = True
        TablaIDLabel2.Location = New System.Drawing.Point(241, 202)
        TablaIDLabel2.Name = "TablaIDLabel2"
        TablaIDLabel2.Size = New System.Drawing.Size(51, 13)
        TablaIDLabel2.TabIndex = 183
        TablaIDLabel2.Text = "Tabla ID:"
        '
        'CodigoGeneradoLabel
        '
        CodigoGeneradoLabel.AutoSize = True
        CodigoGeneradoLabel.Location = New System.Drawing.Point(506, 9)
        CodigoGeneradoLabel.Name = "CodigoGeneradoLabel"
        CodigoGeneradoLabel.Size = New System.Drawing.Size(93, 13)
        CodigoGeneradoLabel.TabIndex = 184
        CodigoGeneradoLabel.Text = "Codigo Generado:"
        '
        'RegistroRelacionesTablasIDLabel
        '
        RegistroRelacionesTablasIDLabel.AutoSize = True
        RegistroRelacionesTablasIDLabel.Location = New System.Drawing.Point(487, 30)
        RegistroRelacionesTablasIDLabel.Name = "RegistroRelacionesTablasIDLabel"
        RegistroRelacionesTablasIDLabel.Size = New System.Drawing.Size(221, 13)
        RegistroRelacionesTablasIDLabel.TabIndex = 183
        RegistroRelacionesTablasIDLabel.Text = "Registro Relaciones Tablas ID Para Registro:"
        '
        'RegistroRelacionesTablasIDLabel1
        '
        RegistroRelacionesTablasIDLabel1.AutoSize = True
        RegistroRelacionesTablasIDLabel1.Location = New System.Drawing.Point(488, 58)
        RegistroRelacionesTablasIDLabel1.Name = "RegistroRelacionesTablasIDLabel1"
        RegistroRelacionesTablasIDLabel1.Size = New System.Drawing.Size(195, 13)
        RegistroRelacionesTablasIDLabel1.TabIndex = 185
        RegistroRelacionesTablasIDLabel1.Text = "Registro Relaciones Tablas ID Verificar:"
        '
        'TablaDependienteLabel
        '
        TablaDependienteLabel.AutoSize = True
        TablaDependienteLabel.Location = New System.Drawing.Point(6, 349)
        TablaDependienteLabel.Name = "TablaDependienteLabel"
        TablaDependienteLabel.Size = New System.Drawing.Size(101, 13)
        TablaDependienteLabel.TabIndex = 184
        TablaDependienteLabel.Text = "Tabla Dependiente:"
        '
        'CampoDependienteLabel
        '
        CampoDependienteLabel.AutoSize = True
        CampoDependienteLabel.Location = New System.Drawing.Point(6, 399)
        CampoDependienteLabel.Name = "CampoDependienteLabel"
        CampoDependienteLabel.Size = New System.Drawing.Size(107, 13)
        CampoDependienteLabel.TabIndex = 185
        CampoDependienteLabel.Text = "Campo Dependiente:"
        '
        'TablaIndependienteLabel
        '
        TablaIndependienteLabel.AutoSize = True
        TablaIndependienteLabel.Location = New System.Drawing.Point(6, 467)
        TablaIndependienteLabel.Name = "TablaIndependienteLabel"
        TablaIndependienteLabel.Size = New System.Drawing.Size(108, 13)
        TablaIndependienteLabel.TabIndex = 186
        TablaIndependienteLabel.Text = "Tabla Independiente:"
        '
        'CampoIndependienteLabel
        '
        CampoIndependienteLabel.AutoSize = True
        CampoIndependienteLabel.Location = New System.Drawing.Point(6, 513)
        CampoIndependienteLabel.Name = "CampoIndependienteLabel"
        CampoIndependienteLabel.Size = New System.Drawing.Size(114, 13)
        CampoIndependienteLabel.TabIndex = 187
        CampoIndependienteLabel.Text = "Campo Independiente:"
        '
        'ContenidoRelacionLabel
        '
        ContenidoRelacionLabel.AutoSize = True
        ContenidoRelacionLabel.Location = New System.Drawing.Point(498, 360)
        ContenidoRelacionLabel.Name = "ContenidoRelacionLabel"
        ContenidoRelacionLabel.Size = New System.Drawing.Size(103, 13)
        ContenidoRelacionLabel.TabIndex = 186
        ContenidoRelacionLabel.Text = "Contenido Relacion:"
        '
        'TablaDependienteLabel1
        '
        TablaDependienteLabel1.AutoSize = True
        TablaDependienteLabel1.Location = New System.Drawing.Point(495, 419)
        TablaDependienteLabel1.Name = "TablaDependienteLabel1"
        TablaDependienteLabel1.Size = New System.Drawing.Size(101, 13)
        TablaDependienteLabel1.TabIndex = 187
        TablaDependienteLabel1.Text = "Tabla Dependiente:"
        '
        'CampoDependienteLabel1
        '
        CampoDependienteLabel1.AutoSize = True
        CampoDependienteLabel1.Location = New System.Drawing.Point(489, 441)
        CampoDependienteLabel1.Name = "CampoDependienteLabel1"
        CampoDependienteLabel1.Size = New System.Drawing.Size(107, 13)
        CampoDependienteLabel1.TabIndex = 188
        CampoDependienteLabel1.Text = "Campo Dependiente:"
        '
        'TablaIndependienteLabel1
        '
        TablaIndependienteLabel1.AutoSize = True
        TablaIndependienteLabel1.Location = New System.Drawing.Point(488, 478)
        TablaIndependienteLabel1.Name = "TablaIndependienteLabel1"
        TablaIndependienteLabel1.Size = New System.Drawing.Size(108, 13)
        TablaIndependienteLabel1.TabIndex = 189
        TablaIndependienteLabel1.Text = "Tabla Independiente:"
        '
        'CampoIndependienteLabel1
        '
        CampoIndependienteLabel1.AutoSize = True
        CampoIndependienteLabel1.Location = New System.Drawing.Point(481, 500)
        CampoIndependienteLabel1.Name = "CampoIndependienteLabel1"
        CampoIndependienteLabel1.Size = New System.Drawing.Size(114, 13)
        CampoIndependienteLabel1.TabIndex = 190
        CampoIndependienteLabel1.Text = "Campo Independiente:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(271, 243)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(78, 13)
        Label17.TabIndex = 130
        Label17.Text = "Requerimiento:"
        '
        'ProyectosYTecnologiasIDLabel
        '
        ProyectosYTecnologiasIDLabel.AutoSize = True
        ProyectosYTecnologiasIDLabel.Location = New System.Drawing.Point(258, 30)
        ProyectosYTecnologiasIDLabel.Name = "ProyectosYTecnologiasIDLabel"
        ProyectosYTecnologiasIDLabel.Size = New System.Drawing.Size(139, 13)
        ProyectosYTecnologiasIDLabel.TabIndex = 193
        ProyectosYTecnologiasIDLabel.Text = "Proyectos YTecnologias ID:"
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5})
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(362, 102)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(112, 63)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 91
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AllowUserToAddRows = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AutoGenerateColumns = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6})
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.ContextMenuStrip = Me.CM_Plantilla
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.DataSource = Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Location = New System.Drawing.Point(192, 3)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Name = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowHeadersVisible = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowTemplate.Height = 27
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Size = New System.Drawing.Size(190, 155)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.TabIndex = 94
        '
        'CM_Plantilla
        '
        Me.CM_Plantilla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPlantillaToolStripMenuItem, Me.AgregarTodasToolStripMenuItem})
        Me.CM_Plantilla.Name = "CM_Plantilla"
        Me.CM_Plantilla.Size = New System.Drawing.Size(162, 48)
        '
        'AgregarPlantillaToolStripMenuItem
        '
        Me.AgregarPlantillaToolStripMenuItem.Name = "AgregarPlantillaToolStripMenuItem"
        Me.AgregarPlantillaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AgregarPlantillaToolStripMenuItem.Text = "Agregar Plantilla"
        '
        'AgregarTodasToolStripMenuItem
        '
        Me.AgregarTodasToolStripMenuItem.Name = "AgregarTodasToolStripMenuItem"
        Me.AgregarTodasToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AgregarTodasToolStripMenuItem.Text = "Agregar Todas"
        '
        'TecnologiasDataGridView
        '
        Me.TecnologiasDataGridView.AllowUserToAddRows = False
        Me.TecnologiasDataGridView.AutoGenerateColumns = False
        Me.TecnologiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TecnologiasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7})
        Me.TecnologiasDataGridView.DataSource = Me.TecnologiasBindingSource
        Me.TecnologiasDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.TecnologiasDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.TecnologiasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TecnologiasDataGridView.Name = "TecnologiasDataGridView"
        Me.TecnologiasDataGridView.RowHeadersVisible = False
        Me.TecnologiasDataGridView.RowTemplate.Height = 27
        Me.TecnologiasDataGridView.Size = New System.Drawing.Size(182, 155)
        Me.TecnologiasDataGridView.TabIndex = 96
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8})
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(1054, 386)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(163, 109)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 98
        '
        'ComponenteIDTextBox
        '
        Me.ComponenteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "ComponenteID", True))
        Me.ComponenteIDTextBox.Location = New System.Drawing.Point(146, 398)
        Me.ComponenteIDTextBox.Name = "ComponenteIDTextBox"
        Me.ComponenteIDTextBox.Size = New System.Drawing.Size(101, 20)
        Me.ComponenteIDTextBox.TabIndex = 118
        '
        'PlantillaIDTextBox
        '
        Me.PlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "PlantillaID", True))
        Me.PlantillaIDTextBox.Location = New System.Drawing.Point(146, 337)
        Me.PlantillaIDTextBox.Name = "PlantillaIDTextBox"
        Me.PlantillaIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlantillaIDTextBox.TabIndex = 116
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(986, 137)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(47, 20)
        Me.ControlNulos.TabIndex = 114
        '
        'TecnologiaIDTextBox
        '
        Me.TecnologiaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "TecnologiaID", True))
        Me.TecnologiaIDTextBox.Location = New System.Drawing.Point(146, 281)
        Me.TecnologiaIDTextBox.Name = "TecnologiaIDTextBox"
        Me.TecnologiaIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TecnologiaIDTextBox.TabIndex = 113
        '
        'EnunciadoTextBox
        '
        Me.EnunciadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Enunciado", True))
        Me.EnunciadoTextBox.Location = New System.Drawing.Point(147, 123)
        Me.EnunciadoTextBox.Name = "EnunciadoTextBox"
        Me.EnunciadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EnunciadoTextBox.TabIndex = 121
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.PanelAdministracion_)
        Me.Panel1.Controls.Add(DescripcionLabel)
        Me.Panel1.Controls.Add(Me.DescripcionTextBox)
        Me.Panel1.Controls.Add(NombreProyectoLabel)
        Me.Panel1.Controls.Add(Me.NombreProyectoTextBox)
        Me.Panel1.Controls.Add(Me.ProyectosDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 591)
        Me.Panel1.TabIndex = 122
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 403)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(393, 187)
        Me.TabControl1.TabIndex = 124
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(385, 161)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tecnologias Aplicadas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView
        '
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.AllowUserToAddRows = False
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.AutoGenerateColumns = False
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.ContextMenuStrip = Me.CM_EliminandoTecnologias
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.DataSource = Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Name = "SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView"
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.RowHeadersVisible = False
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.RowTemplate.Height = 27
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Size = New System.Drawing.Size(379, 155)
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.TabIndex = 124
        '
        'CM_EliminandoTecnologias
        '
        Me.CM_EliminandoTecnologias.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarUna, Me.ToolStripSeparator2, Me.EliminarTodas, Me.ToolStripSeparator3, Me.MaximizarPaneles, Me.ToolStripSeparator4, Me.MinimizarPToolStripMenuItem})
        Me.CM_EliminandoTecnologias.Name = "CM_EliminandoTecnologias"
        Me.CM_EliminandoTecnologias.Size = New System.Drawing.Size(241, 110)
        '
        'EliminarUna
        '
        Me.EliminarUna.Name = "EliminarUna"
        Me.EliminarUna.Size = New System.Drawing.Size(240, 22)
        Me.EliminarUna.Text = "Eliminar Esta Plantilla Aplicada"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(237, 6)
        '
        'EliminarTodas
        '
        Me.EliminarTodas.Name = "EliminarTodas"
        Me.EliminarTodas.Size = New System.Drawing.Size(240, 22)
        Me.EliminarTodas.Text = "Eliminar Todas las Relacionadas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(237, 6)
        '
        'MaximizarPaneles
        '
        Me.MaximizarPaneles.Name = "MaximizarPaneles"
        Me.MaximizarPaneles.Size = New System.Drawing.Size(240, 22)
        Me.MaximizarPaneles.Text = "Maximizar Paneles"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(237, 6)
        '
        'MinimizarPToolStripMenuItem
        '
        Me.MinimizarPToolStripMenuItem.Name = "MinimizarPToolStripMenuItem"
        Me.MinimizarPToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.MinimizarPToolStripMenuItem.Text = "Minimizar P."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TecnologiasDataGridView)
        Me.TabPage2.Controls.Add(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(385, 161)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Agregar Tecnologias"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PanelAdministracion_
        '
        Me.PanelAdministracion_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdministracion_.Controls.Add(Me.Nuevo_Menu_Proyectos)
        Me.PanelAdministracion_.Controls.Add(Me.Cancelar_Menu_Proyectos)
        Me.PanelAdministracion_.Controls.Add(Me.Eliminar_Menu_Proyectos)
        Me.PanelAdministracion_.Controls.Add(Me.Editar_Menu_Proyectos)
        Me.PanelAdministracion_.Controls.Add(Me.Actualizar_Menu_Proyectos)
        Me.PanelAdministracion_.Controls.Add(Me.Guardar_Menu_Proyectos)
        Me.PanelAdministracion_.Location = New System.Drawing.Point(6, 3)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(393, 46)
        Me.PanelAdministracion_.TabIndex = 90
        '
        'Nuevo_Menu_Proyectos
        '
        Me.Nuevo_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_Proyectos.Image = CType(resources.GetObject("Nuevo_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_Proyectos.Location = New System.Drawing.Point(61, 3)
        Me.Nuevo_Menu_Proyectos.Name = "Nuevo_Menu_Proyectos"
        Me.Nuevo_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_Proyectos.TabIndex = 70
        Me.Nuevo_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_Proyectos
        '
        Me.Cancelar_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_Proyectos.Image = CType(resources.GetObject("Cancelar_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_Proyectos.Location = New System.Drawing.Point(290, 3)
        Me.Cancelar_Menu_Proyectos.Name = "Cancelar_Menu_Proyectos"
        Me.Cancelar_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_Proyectos.TabIndex = 75
        Me.Cancelar_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_Proyectos
        '
        Me.Eliminar_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_Proyectos.Image = CType(resources.GetObject("Eliminar_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_Proyectos.Location = New System.Drawing.Point(245, 3)
        Me.Eliminar_Menu_Proyectos.Name = "Eliminar_Menu_Proyectos"
        Me.Eliminar_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_Proyectos.TabIndex = 72
        Me.Eliminar_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'Editar_Menu_Proyectos
        '
        Me.Editar_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_Proyectos.Image = CType(resources.GetObject("Editar_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Editar_Menu_Proyectos.Location = New System.Drawing.Point(153, 3)
        Me.Editar_Menu_Proyectos.Name = "Editar_Menu_Proyectos"
        Me.Editar_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_Proyectos.TabIndex = 74
        Me.Editar_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_Proyectos
        '
        Me.Actualizar_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_Proyectos.Image = CType(resources.GetObject("Actualizar_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_Proyectos.Location = New System.Drawing.Point(199, 3)
        Me.Actualizar_Menu_Proyectos.Name = "Actualizar_Menu_Proyectos"
        Me.Actualizar_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_Proyectos.TabIndex = 73
        Me.Actualizar_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_Proyectos
        '
        Me.Guardar_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_Proyectos.Image = CType(resources.GetObject("Guardar_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Guardar_Menu_Proyectos.Location = New System.Drawing.Point(107, 3)
        Me.Guardar_Menu_Proyectos.Name = "Guardar_Menu_Proyectos"
        Me.Guardar_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_Proyectos.TabIndex = 71
        Me.Guardar_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(8, 137)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(393, 65)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'NombreProyectoTextBox
        '
        Me.NombreProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "NombreProyecto", True))
        Me.NombreProyectoTextBox.Location = New System.Drawing.Point(8, 68)
        Me.NombreProyectoTextBox.Multiline = True
        Me.NombreProyectoTextBox.Name = "NombreProyectoTextBox"
        Me.NombreProyectoTextBox.Size = New System.Drawing.Size(393, 50)
        Me.NombreProyectoTextBox.TabIndex = 2
        '
        'ProyectosDataGridView
        '
        Me.ProyectosDataGridView.AllowUserToAddRows = False
        Me.ProyectosDataGridView.AutoGenerateColumns = False
        Me.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10})
        Me.ProyectosDataGridView.DataSource = Me.ProyectosBindingSource
        Me.ProyectosDataGridView.Location = New System.Drawing.Point(8, 208)
        Me.ProyectosDataGridView.Name = "ProyectosDataGridView"
        Me.ProyectosDataGridView.RowHeadersVisible = False
        Me.ProyectosDataGridView.RowTemplate.Height = 27
        Me.ProyectosDataGridView.Size = New System.Drawing.Size(393, 189)
        Me.ProyectosDataGridView.TabIndex = 0
        '
        'ProyectoIDTextBox
        '
        Me.ProyectoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "ProyectoID", True))
        Me.ProyectoIDTextBox.Location = New System.Drawing.Point(145, 562)
        Me.ProyectoIDTextBox.Name = "ProyectoIDTextBox"
        Me.ProyectoIDTextBox.Size = New System.Drawing.Size(101, 20)
        Me.ProyectoIDTextBox.TabIndex = 123
        '
        'CM1
        '
        Me.CM1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaximizarCodigoGeneradoToolStripMenuItem})
        Me.CM1.Name = "CM1"
        Me.CM1.Size = New System.Drawing.Size(225, 26)
        '
        'MaximizarCodigoGeneradoToolStripMenuItem
        '
        Me.MaximizarCodigoGeneradoToolStripMenuItem.Name = "MaximizarCodigoGeneradoToolStripMenuItem"
        Me.MaximizarCodigoGeneradoToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.MaximizarCodigoGeneradoToolStripMenuItem.Text = "Maximizar Codigo Generado"
        '
        'NombreTecnologiaTextBox
        '
        Me.NombreTecnologiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "NombreTecnologia", True))
        Me.NombreTecnologiaTextBox.Location = New System.Drawing.Point(146, 259)
        Me.NombreTecnologiaTextBox.Name = "NombreTecnologiaTextBox"
        Me.NombreTecnologiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTecnologiaTextBox.TabIndex = 124
        '
        'TecnologiaID_EliminaRelacion
        '
        Me.TecnologiaID_EliminaRelacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "TecnologiaID", True))
        Me.TecnologiaID_EliminaRelacion.Location = New System.Drawing.Point(148, 76)
        Me.TecnologiaID_EliminaRelacion.Name = "TecnologiaID_EliminaRelacion"
        Me.TecnologiaID_EliminaRelacion.Size = New System.Drawing.Size(101, 20)
        Me.TecnologiaID_EliminaRelacion.TabIndex = 125
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.AllowUserToAddRows = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.AutoGenerateColumns = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14})
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.ContextMenuStrip = Me.CM_RelacionesTablas
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.DataSource = Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Location = New System.Drawing.Point(6, 103)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Name = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.RowHeadersVisible = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.RowTemplate.Height = 27
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Size = New System.Drawing.Size(451, 121)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.TabIndex = 126
        '
        'CM_RelacionesTablas
        '
        Me.CM_RelacionesTablas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearRelacionToolStripMenuItem, Me.EliminarRelaciónToolStripMenuItem})
        Me.CM_RelacionesTablas.Name = "CM_RelacionesTablas"
        Me.CM_RelacionesTablas.Size = New System.Drawing.Size(166, 48)
        '
        'CrearRelacionToolStripMenuItem
        '
        Me.CrearRelacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1})
        Me.CrearRelacionToolStripMenuItem.Name = "CrearRelacionToolStripMenuItem"
        Me.CrearRelacionToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CrearRelacionToolStripMenuItem.Text = "Crear Relación"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(57, 6)
        '
        'EliminarRelaciónToolStripMenuItem
        '
        Me.EliminarRelaciónToolStripMenuItem.Name = "EliminarRelaciónToolStripMenuItem"
        Me.EliminarRelaciónToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EliminarRelaciónToolStripMenuItem.Text = "Eliminar Relación"
        '
        'RequerimientoTextBox
        '
        Me.RequerimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Requerimiento", True))
        Me.RequerimientoTextBox.Location = New System.Drawing.Point(146, 145)
        Me.RequerimientoTextBox.Name = "RequerimientoTextBox"
        Me.RequerimientoTextBox.Size = New System.Drawing.Size(101, 20)
        Me.RequerimientoTextBox.TabIndex = 127
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(1054, 17)
        Me.CodigoTextBox.Multiline = True
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(283, 248)
        Me.CodigoTextBox.TabIndex = 130
        '
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.AllowUserToAddRows = False
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.AutoGenerateColumns = False
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.DataSource = Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Location = New System.Drawing.Point(412, 486)
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Name = "SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView"
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.RowHeadersVisible = False
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.RowTemplate.Height = 27
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Size = New System.Drawing.Size(346, 101)
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.TabIndex = 131
        '
        'BtnRemplazar
        '
        Me.BtnRemplazar.BackColor = System.Drawing.Color.White
        Me.BtnRemplazar.Image = CType(resources.GetObject("BtnRemplazar.Image"), System.Drawing.Image)
        Me.BtnRemplazar.Location = New System.Drawing.Point(292, 2)
        Me.BtnRemplazar.Name = "BtnRemplazar"
        Me.BtnRemplazar.Size = New System.Drawing.Size(49, 44)
        Me.BtnRemplazar.TabIndex = 132
        Me.BtnRemplazar.UseVisualStyleBackColor = False
        '
        'NombreComponenteTextBox
        '
        Me.NombreComponenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "NombreComponente", True))
        Me.NombreComponenteTextBox.Location = New System.Drawing.Point(146, 420)
        Me.NombreComponenteTextBox.Name = "NombreComponenteTextBox"
        Me.NombreComponenteTextBox.Size = New System.Drawing.Size(101, 20)
        Me.NombreComponenteTextBox.TabIndex = 133
        '
        'NombreTecnologiaTextBox1
        '
        Me.NombreTecnologiaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "NombreTecnologia", True))
        Me.NombreTecnologiaTextBox1.Location = New System.Drawing.Point(149, 53)
        Me.NombreTecnologiaTextBox1.Name = "NombreTecnologiaTextBox1"
        Me.NombreTecnologiaTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.NombreTecnologiaTextBox1.TabIndex = 134
        '
        'RequerimientoTextBox1
        '
        Me.RequerimientoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "Requerimiento", True))
        Me.RequerimientoTextBox1.Location = New System.Drawing.Point(146, 490)
        Me.RequerimientoTextBox1.Name = "RequerimientoTextBox1"
        Me.RequerimientoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.RequerimientoTextBox1.TabIndex = 135
        '
        'ValorRequerimientoTextBox1
        '
        Me.ValorRequerimientoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "ValorRequerimiento", True))
        Me.ValorRequerimientoTextBox1.Location = New System.Drawing.Point(146, 516)
        Me.ValorRequerimientoTextBox1.Name = "ValorRequerimientoTextBox1"
        Me.ValorRequerimientoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ValorRequerimientoTextBox1.TabIndex = 136
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Chk_Rel)
        Me.Panel2.Controls.Add(Me.Nuevo_Menu_TablasDeProyecto)
        Me.Panel2.Controls.Add(Me.Cancelar_Menu_TablasDeProyecto)
        Me.Panel2.Controls.Add(Me.Eliminar_Menu_TablasDeProyecto)
        Me.Panel2.Controls.Add(Me.Editar_Menu_TablasDeProyecto)
        Me.Panel2.Controls.Add(Me.Actualizar_Menu_TablasDeProyecto)
        Me.Panel2.Controls.Add(Me.Guardar_Menu_TablasDeProyecto)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 46)
        Me.Panel2.TabIndex = 138
        '
        'Chk_Rel
        '
        Me.Chk_Rel.AutoSize = True
        Me.Chk_Rel.Location = New System.Drawing.Point(317, 15)
        Me.Chk_Rel.Name = "Chk_Rel"
        Me.Chk_Rel.Size = New System.Drawing.Size(121, 17)
        Me.Chk_Rel.TabIndex = 76
        Me.Chk_Rel.Text = "Relacion de Tablas."
        Me.Chk_Rel.UseVisualStyleBackColor = True
        '
        'Nuevo_Menu_TablasDeProyecto
        '
        Me.Nuevo_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Nuevo_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_TablasDeProyecto.Location = New System.Drawing.Point(10, 3)
        Me.Nuevo_Menu_TablasDeProyecto.Name = "Nuevo_Menu_TablasDeProyecto"
        Me.Nuevo_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_TablasDeProyecto.TabIndex = 70
        Me.Nuevo_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_TablasDeProyecto
        '
        Me.Cancelar_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Cancelar_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(239, 3)
        Me.Cancelar_Menu_TablasDeProyecto.Name = "Cancelar_Menu_TablasDeProyecto"
        Me.Cancelar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_TablasDeProyecto.TabIndex = 75
        Me.Cancelar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_TablasDeProyecto
        '
        Me.Eliminar_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Eliminar_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(194, 3)
        Me.Eliminar_Menu_TablasDeProyecto.Name = "Eliminar_Menu_TablasDeProyecto"
        Me.Eliminar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_TablasDeProyecto.TabIndex = 72
        Me.Eliminar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'Editar_Menu_TablasDeProyecto
        '
        Me.Editar_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Editar_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Editar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(102, 3)
        Me.Editar_Menu_TablasDeProyecto.Name = "Editar_Menu_TablasDeProyecto"
        Me.Editar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_TablasDeProyecto.TabIndex = 74
        Me.Editar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_TablasDeProyecto
        '
        Me.Actualizar_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Actualizar_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(148, 3)
        Me.Actualizar_Menu_TablasDeProyecto.Name = "Actualizar_Menu_TablasDeProyecto"
        Me.Actualizar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_TablasDeProyecto.TabIndex = 73
        Me.Actualizar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_TablasDeProyecto
        '
        Me.Guardar_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Guardar_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Guardar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(56, 3)
        Me.Guardar_Menu_TablasDeProyecto.Name = "Guardar_Menu_TablasDeProyecto"
        Me.Guardar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_TablasDeProyecto.TabIndex = 71
        Me.Guardar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'NombreTablaTextBox
        '
        Me.NombreTablaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, "NombreTabla", True))
        Me.NombreTablaTextBox.Location = New System.Drawing.Point(6, 77)
        Me.NombreTablaTextBox.Name = "NombreTablaTextBox"
        Me.NombreTablaTextBox.Size = New System.Drawing.Size(449, 20)
        Me.NombreTablaTextBox.TabIndex = 139
        '
        'TablaIDTextBox
        '
        Me.TablaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, "TablaID", True))
        Me.TablaIDTextBox.Location = New System.Drawing.Point(146, 190)
        Me.TablaIDTextBox.Name = "TablaIDTextBox"
        Me.TablaIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TablaIDTextBox.TabIndex = 140
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Nuevo_Menu_CamposDeTablas)
        Me.Panel3.Controls.Add(Me.Cancelar_Menu_CamposDeTablas)
        Me.Panel3.Controls.Add(Me.Eliminar_Menu_CamposDeTablas)
        Me.Panel3.Controls.Add(Me.Editar_Menu_CamposDeTablas)
        Me.Panel3.Controls.Add(Me.Actualizar_Menu_CamposDeTablas)
        Me.Panel3.Controls.Add(Me.Guardar_Menu_CamposDeTablas)
        Me.Panel3.Location = New System.Drawing.Point(6, 226)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(449, 46)
        Me.Panel3.TabIndex = 141
        '
        'Nuevo_Menu_CamposDeTablas
        '
        Me.Nuevo_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_CamposDeTablas.Image = CType(resources.GetObject("Nuevo_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_CamposDeTablas.Location = New System.Drawing.Point(89, 3)
        Me.Nuevo_Menu_CamposDeTablas.Name = "Nuevo_Menu_CamposDeTablas"
        Me.Nuevo_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_CamposDeTablas.TabIndex = 70
        Me.Nuevo_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_CamposDeTablas
        '
        Me.Cancelar_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_CamposDeTablas.Image = CType(resources.GetObject("Cancelar_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_CamposDeTablas.Location = New System.Drawing.Point(318, 3)
        Me.Cancelar_Menu_CamposDeTablas.Name = "Cancelar_Menu_CamposDeTablas"
        Me.Cancelar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_CamposDeTablas.TabIndex = 75
        Me.Cancelar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_CamposDeTablas
        '
        Me.Eliminar_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_CamposDeTablas.Image = CType(resources.GetObject("Eliminar_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_CamposDeTablas.Location = New System.Drawing.Point(273, 3)
        Me.Eliminar_Menu_CamposDeTablas.Name = "Eliminar_Menu_CamposDeTablas"
        Me.Eliminar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_CamposDeTablas.TabIndex = 72
        Me.Eliminar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Editar_Menu_CamposDeTablas
        '
        Me.Editar_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_CamposDeTablas.Image = CType(resources.GetObject("Editar_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Editar_Menu_CamposDeTablas.Location = New System.Drawing.Point(181, 3)
        Me.Editar_Menu_CamposDeTablas.Name = "Editar_Menu_CamposDeTablas"
        Me.Editar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_CamposDeTablas.TabIndex = 74
        Me.Editar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_CamposDeTablas
        '
        Me.Actualizar_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_CamposDeTablas.Image = CType(resources.GetObject("Actualizar_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_CamposDeTablas.Location = New System.Drawing.Point(227, 3)
        Me.Actualizar_Menu_CamposDeTablas.Name = "Actualizar_Menu_CamposDeTablas"
        Me.Actualizar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_CamposDeTablas.TabIndex = 73
        Me.Actualizar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_CamposDeTablas
        '
        Me.Guardar_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_CamposDeTablas.Image = CType(resources.GetObject("Guardar_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Guardar_Menu_CamposDeTablas.Location = New System.Drawing.Point(135, 3)
        Me.Guardar_Menu_CamposDeTablas.Name = "Guardar_Menu_CamposDeTablas"
        Me.Guardar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_CamposDeTablas.TabIndex = 71
        Me.Guardar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnLimpiar)
        Me.Panel4.Controls.Add(Me.BtnCopiar)
        Me.Panel4.Controls.Add(Me.BtnRemplazar)
        Me.Panel4.Location = New System.Drawing.Point(412, 432)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(347, 50)
        Me.Panel4.TabIndex = 142
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.Location = New System.Drawing.Point(56, 2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(49, 44)
        Me.BtnLimpiar.TabIndex = 172
        Me.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnCopiar
        '
        Me.BtnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCopiar.Image = CType(resources.GetObject("BtnCopiar.Image"), System.Drawing.Image)
        Me.BtnCopiar.Location = New System.Drawing.Point(5, 2)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(49, 44)
        Me.BtnCopiar.TabIndex = 171
        Me.BtnCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCopiar.UseVisualStyleBackColor = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.AllowUserToAddRows = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.AutoGenerateColumns = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9})
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.DataSource = Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Location = New System.Drawing.Point(6, 348)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Name = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.RowHeadersVisible = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.RowTemplate.Height = 27
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Size = New System.Drawing.Size(451, 203)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.TabIndex = 147
        '
        'CampoIDTextBox
        '
        Me.CampoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "CampoID", True))
        Me.CampoIDTextBox.Location = New System.Drawing.Point(144, 657)
        Me.CampoIDTextBox.Name = "CampoIDTextBox"
        Me.CampoIDTextBox.Size = New System.Drawing.Size(103, 20)
        Me.CampoIDTextBox.TabIndex = 148
        '
        'NombreCampoTextBox
        '
        Me.NombreCampoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "NombreCampo", True))
        Me.NombreCampoTextBox.Location = New System.Drawing.Point(6, 291)
        Me.NombreCampoTextBox.Name = "NombreCampoTextBox"
        Me.NombreCampoTextBox.Size = New System.Drawing.Size(449, 20)
        Me.NombreCampoTextBox.TabIndex = 149
        '
        'Cbo_TipoDato
        '
        Me.Cbo_TipoDato.FormattingEnabled = True
        Me.Cbo_TipoDato.Items.AddRange(New Object() {"boolean", "Date", "float", "numeric", "numeric (Clave)", "numeric (Relacionado)", "string", "ultima_actualizacion"})
        Me.Cbo_TipoDato.Location = New System.Drawing.Point(79, 321)
        Me.Cbo_TipoDato.Name = "Cbo_TipoDato"
        Me.Cbo_TipoDato.Size = New System.Drawing.Size(376, 21)
        Me.Cbo_TipoDato.Sorted = True
        Me.Cbo_TipoDato.TabIndex = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Tipo de Dato"
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(144, 679)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(103, 20)
        Me.TipoTextBox.TabIndex = 152
        '
        'PrefijoTextBox
        '
        Me.PrefijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource, "Prefijo", True))
        Me.PrefijoTextBox.Location = New System.Drawing.Point(490, 146)
        Me.PrefijoTextBox.Name = "PrefijoTextBox"
        Me.PrefijoTextBox.Size = New System.Drawing.Size(57, 20)
        Me.PrefijoTextBox.TabIndex = 154
        '
        'SuperiorTextBox
        '
        Me.SuperiorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource, "Superior", True))
        Me.SuperiorTextBox.Location = New System.Drawing.Point(548, 120)
        Me.SuperiorTextBox.Name = "SuperiorTextBox"
        Me.SuperiorTextBox.Size = New System.Drawing.Size(57, 20)
        Me.SuperiorTextBox.TabIndex = 155
        '
        'SufijoTextBox
        '
        Me.SufijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource, "Sufijo", True))
        Me.SufijoTextBox.Location = New System.Drawing.Point(608, 146)
        Me.SufijoTextBox.Name = "SufijoTextBox"
        Me.SufijoTextBox.Size = New System.Drawing.Size(57, 20)
        Me.SufijoTextBox.TabIndex = 156
        '
        'InferiorTextBox
        '
        Me.InferiorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource, "Inferior", True))
        Me.InferiorTextBox.Location = New System.Drawing.Point(548, 169)
        Me.InferiorTextBox.Name = "InferiorTextBox"
        Me.InferiorTextBox.Size = New System.Drawing.Size(57, 20)
        Me.InferiorTextBox.TabIndex = 157
        '
        'PlantillaIDTextBox1
        '
        Me.PlantillaIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "PlantillaID", True))
        Me.PlantillaIDTextBox1.Location = New System.Drawing.Point(149, 27)
        Me.PlantillaIDTextBox1.Name = "PlantillaIDTextBox1"
        Me.PlantillaIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PlantillaIDTextBox1.TabIndex = 158
        '
        'PanelConf
        '
        Me.PanelConf.AutoScroll = True
        Me.PanelConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelConf.Controls.Add(ProyectosYTecnologiasIDLabel)
        Me.PanelConf.Controls.Add(Me.ProyectosYTecnologiasIDTextBox)
        Me.PanelConf.Controls.Add(Me.TextBox2)
        Me.PanelConf.Controls.Add(Me.TextBox1)
        Me.PanelConf.Controls.Add(CampoIndependienteLabel1)
        Me.PanelConf.Controls.Add(Me.CampoIndependienteTextBox1)
        Me.PanelConf.Controls.Add(Me.Label18)
        Me.PanelConf.Controls.Add(TablaIndependienteLabel1)
        Me.PanelConf.Controls.Add(Me.TextBox4)
        Me.PanelConf.Controls.Add(Label17)
        Me.PanelConf.Controls.Add(Me.TablaIndependienteTextBox1)
        Me.PanelConf.Controls.Add(CampoDependienteLabel1)
        Me.PanelConf.Controls.Add(Me.TextBox3)
        Me.PanelConf.Controls.Add(Me.CampoDependienteTextBox1)
        Me.PanelConf.Controls.Add(TablaDependienteLabel1)
        Me.PanelConf.Controls.Add(Me.TablaDependienteTextBox1)
        Me.PanelConf.Controls.Add(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView)
        Me.PanelConf.Controls.Add(ContenidoRelacionLabel)
        Me.PanelConf.Controls.Add(Me.ContenidoRelacionTextBox)
        Me.PanelConf.Controls.Add(RegistroRelacionesTablasIDLabel1)
        Me.PanelConf.Controls.Add(Me.RegistroRelacionesTablasIDTextBox1)
        Me.PanelConf.Controls.Add(Me.Label13)
        Me.PanelConf.Controls.Add(RegistroRelacionesTablasIDLabel)
        Me.PanelConf.Controls.Add(Me.RegistroRelacionesTablasIDTextBox)
        Me.PanelConf.Controls.Add(TipoLabel1)
        Me.PanelConf.Controls.Add(Me.TipoTextBox1)
        Me.PanelConf.Controls.Add(NombreCampoLabel1)
        Me.PanelConf.Controls.Add(Me.NombreCampoTextBox1)
        Me.PanelConf.Controls.Add(CampoIDLabel1)
        Me.PanelConf.Controls.Add(Me.CampoIDTextBox1)
        Me.PanelConf.Controls.Add(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView)
        Me.PanelConf.Controls.Add(TablaIDLabel1)
        Me.PanelConf.Controls.Add(Me.TablaIDTextBox1)
        Me.PanelConf.Controls.Add(NombreTablaLabel2)
        Me.PanelConf.Controls.Add(Me.NombreTablaTextBox2)
        Me.PanelConf.Controls.Add(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView)
        Me.PanelConf.Controls.Add(XTablaLabel)
        Me.PanelConf.Controls.Add(Me.XTablaCheckBox)
        Me.PanelConf.Controls.Add(Me.Button1)
        Me.PanelConf.Controls.Add(ValorRequerimientoLabel1)
        Me.PanelConf.Controls.Add(Me.ValorRequerimientoTextBox2)
        Me.PanelConf.Controls.Add(Me.Label12)
        Me.PanelConf.Controls.Add(RegistroValorRequerimientoIDLabel)
        Me.PanelConf.Controls.Add(Me.RegistroValorRequerimientoIDTextBox)
        Me.PanelConf.Controls.Add(Me.ClavePrincipal)
        Me.PanelConf.Controls.Add(NombreTablaLabel1)
        Me.PanelConf.Controls.Add(Me.NombreTablaTextBox1)
        Me.PanelConf.Controls.Add(MultiReplaceLabel)
        Me.PanelConf.Controls.Add(Me.MultiReplaceTextBox)
        Me.PanelConf.Controls.Add(SeparadorCamposLabel)
        Me.PanelConf.Controls.Add(Me.SeparadorCamposTextBox)
        Me.PanelConf.Controls.Add(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.PanelConf.Controls.Add(Me.Label1)
        Me.PanelConf.Controls.Add(Me.ValorRequerimientoTextBox)
        Me.PanelConf.Controls.Add(Me.Label11)
        Me.PanelConf.Controls.Add(Me.CodigoTextBox)
        Me.PanelConf.Controls.Add(Me.Label10)
        Me.PanelConf.Controls.Add(InferiorLabel)
        Me.PanelConf.Controls.Add(Me.Label9)
        Me.PanelConf.Controls.Add(Me.InferiorTextBox)
        Me.PanelConf.Controls.Add(Me.Label8)
        Me.PanelConf.Controls.Add(SufijoLabel)
        Me.PanelConf.Controls.Add(Me.Label7)
        Me.PanelConf.Controls.Add(Me.SufijoTextBox)
        Me.PanelConf.Controls.Add(Me.Label6)
        Me.PanelConf.Controls.Add(SuperiorLabel)
        Me.PanelConf.Controls.Add(Me.Label5)
        Me.PanelConf.Controls.Add(Me.SuperiorTextBox)
        Me.PanelConf.Controls.Add(PrefijoLabel)
        Me.PanelConf.Controls.Add(Me.Label4)
        Me.PanelConf.Controls.Add(Me.PrefijoTextBox)
        Me.PanelConf.Controls.Add(Me.Label3)
        Me.PanelConf.Controls.Add(PlantillaIDLabel1)
        Me.PanelConf.Controls.Add(Me.PlantillaIDTextBox1)
        Me.PanelConf.Controls.Add(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.PanelConf.Controls.Add(TipoLabel)
        Me.PanelConf.Controls.Add(Me.EnunciadoTextBox)
        Me.PanelConf.Controls.Add(Me.TipoTextBox)
        Me.PanelConf.Controls.Add(EnunciadoLabel)
        Me.PanelConf.Controls.Add(Me.NombreTecnologiaTextBox1)
        Me.PanelConf.Controls.Add(NombreTecnologiaLabel1)
        Me.PanelConf.Controls.Add(NombreTecnologiaLabel)
        Me.PanelConf.Controls.Add(Me.ControlNulos)
        Me.PanelConf.Controls.Add(CampoIDLabel)
        Me.PanelConf.Controls.Add(Me.NombreTecnologiaTextBox)
        Me.PanelConf.Controls.Add(Me.CampoIDTextBox)
        Me.PanelConf.Controls.Add(Me.TablaIDTextBox)
        Me.PanelConf.Controls.Add(TablaIDLabel)
        Me.PanelConf.Controls.Add(Me.PlantillaIDTextBox)
        Me.PanelConf.Controls.Add(Me.TecnologiaIDTextBox)
        Me.PanelConf.Controls.Add(TecnologiaIDLabel)
        Me.PanelConf.Controls.Add(PlantillaIDLabel)
        Me.PanelConf.Controls.Add(Me.TecnologiaID_EliminaRelacion)
        Me.PanelConf.Controls.Add(TecnologiaIDLabel1)
        Me.PanelConf.Controls.Add(Me.ComponenteIDTextBox)
        Me.PanelConf.Controls.Add(ComponenteIDLabel)
        Me.PanelConf.Controls.Add(Me.ProyectoIDTextBox)
        Me.PanelConf.Controls.Add(ProyectoIDLabel)
        Me.PanelConf.Controls.Add(ValorRequerimientoLabel)
        Me.PanelConf.Controls.Add(Me.ValorRequerimientoTextBox1)
        Me.PanelConf.Controls.Add(RequerimientoLabel)
        Me.PanelConf.Controls.Add(Me.RequerimientoTextBox1)
        Me.PanelConf.Controls.Add(Me.RequerimientoTextBox)
        Me.PanelConf.Controls.Add(RequerimientoLabel1)
        Me.PanelConf.Controls.Add(Me.NombreComponenteTextBox)
        Me.PanelConf.Controls.Add(NombreComponenteLabel)
        Me.PanelConf.Location = New System.Drawing.Point(722, 9)
        Me.PanelConf.Name = "PanelConf"
        Me.PanelConf.Size = New System.Drawing.Size(36, 13)
        Me.PanelConf.TabIndex = 159
        '
        'ProyectosYTecnologiasIDTextBox
        '
        Me.ProyectosYTecnologiasIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "ProyectosYTecnologiasID", True))
        Me.ProyectosYTecnologiasIDTextBox.Location = New System.Drawing.Point(294, 47)
        Me.ProyectosYTecnologiasIDTextBox.Name = "ProyectosYTecnologiasIDTextBox"
        Me.ProyectosYTecnologiasIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProyectosYTecnologiasIDTextBox.TabIndex = 194
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource, "ID_TI", True))
        Me.TextBox2.Location = New System.Drawing.Point(665, 475)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(40, 20)
        Me.TextBox2.TabIndex = 193
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource, "ID_TD", True))
        Me.TextBox1.Location = New System.Drawing.Point(665, 416)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(40, 20)
        Me.TextBox1.TabIndex = 192
        '
        'CampoIndependienteTextBox1
        '
        Me.CampoIndependienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource, "CampoIndependiente", True))
        Me.CampoIndependienteTextBox1.Location = New System.Drawing.Point(601, 497)
        Me.CampoIndependienteTextBox1.Name = "CampoIndependienteTextBox1"
        Me.CampoIndependienteTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CampoIndependienteTextBox1.TabIndex = 191
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(271, 230)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 135
        Me.Label18.Text = "Label18"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Requerimiento", True))
        Me.TextBox4.Location = New System.Drawing.Point(355, 263)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(101, 20)
        Me.TextBox4.TabIndex = 132
        '
        'TablaIndependienteTextBox1
        '
        Me.TablaIndependienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource, "TablaIndependiente", True))
        Me.TablaIndependienteTextBox1.Location = New System.Drawing.Point(602, 475)
        Me.TablaIndependienteTextBox1.Name = "TablaIndependienteTextBox1"
        Me.TablaIndependienteTextBox1.Size = New System.Drawing.Size(38, 20)
        Me.TablaIndependienteTextBox1.TabIndex = 190
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Requerimiento", True))
        Me.TextBox3.Location = New System.Drawing.Point(355, 240)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(101, 20)
        Me.TextBox3.TabIndex = 131
        '
        'CampoDependienteTextBox1
        '
        Me.CampoDependienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource, "CampoDependiente", True))
        Me.CampoDependienteTextBox1.Location = New System.Drawing.Point(602, 438)
        Me.CampoDependienteTextBox1.Name = "CampoDependienteTextBox1"
        Me.CampoDependienteTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CampoDependienteTextBox1.TabIndex = 189
        '
        'TablaDependienteTextBox1
        '
        Me.TablaDependienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource, "TablaDependiente", True))
        Me.TablaDependienteTextBox1.Location = New System.Drawing.Point(602, 416)
        Me.TablaDependienteTextBox1.Name = "TablaDependienteTextBox1"
        Me.TablaDependienteTextBox1.Size = New System.Drawing.Size(40, 20)
        Me.TablaDependienteTextBox1.TabIndex = 188
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.AllowUserToAddRows = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.AutoGenerateColumns = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33})
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.DataSource = Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Location = New System.Drawing.Point(711, 360)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Name = "SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView"
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.RowHeadersVisible = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Size = New System.Drawing.Size(223, 157)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.TabIndex = 187
        '
        'ContenidoRelacionTextBox
        '
        Me.ContenidoRelacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource, "ContenidoRelacion", True))
        Me.ContenidoRelacionTextBox.Location = New System.Drawing.Point(602, 360)
        Me.ContenidoRelacionTextBox.Multiline = True
        Me.ContenidoRelacionTextBox.Name = "ContenidoRelacionTextBox"
        Me.ContenidoRelacionTextBox.Size = New System.Drawing.Size(103, 54)
        Me.ContenidoRelacionTextBox.TabIndex = 187
        '
        'RegistroRelacionesTablasIDTextBox1
        '
        Me.RegistroRelacionesTablasIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, "RegistroRelacionesTablasID", True))
        Me.RegistroRelacionesTablasIDTextBox1.Location = New System.Drawing.Point(714, 55)
        Me.RegistroRelacionesTablasIDTextBox1.Name = "RegistroRelacionesTablasIDTextBox1"
        Me.RegistroRelacionesTablasIDTextBox1.Size = New System.Drawing.Size(38, 20)
        Me.RegistroRelacionesTablasIDTextBox1.TabIndex = 186
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(487, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 13)
        Me.Label13.TabIndex = 185
        Me.Label13.Text = "RegistroRelacionesTablas"
        '
        'RegistroRelacionesTablasIDTextBox
        '
        Me.RegistroRelacionesTablasIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource, "RegistroRelacionesTablasID", True))
        Me.RegistroRelacionesTablasIDTextBox.Location = New System.Drawing.Point(714, 29)
        Me.RegistroRelacionesTablasIDTextBox.Name = "RegistroRelacionesTablasIDTextBox"
        Me.RegistroRelacionesTablasIDTextBox.Size = New System.Drawing.Size(38, 20)
        Me.RegistroRelacionesTablasIDTextBox.TabIndex = 184
        '
        'TipoTextBox1
        '
        Me.TipoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource, "Tipo", True))
        Me.TipoTextBox1.Location = New System.Drawing.Point(718, 337)
        Me.TipoTextBox1.Name = "TipoTextBox1"
        Me.TipoTextBox1.Size = New System.Drawing.Size(49, 20)
        Me.TipoTextBox1.TabIndex = 183
        '
        'NombreCampoTextBox1
        '
        Me.NombreCampoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource, "NombreCampo", True))
        Me.NombreCampoTextBox1.Location = New System.Drawing.Point(718, 312)
        Me.NombreCampoTextBox1.Name = "NombreCampoTextBox1"
        Me.NombreCampoTextBox1.Size = New System.Drawing.Size(49, 20)
        Me.NombreCampoTextBox1.TabIndex = 182
        '
        'CampoIDTextBox1
        '
        Me.CampoIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource, "CampoID", True))
        Me.CampoIDTextBox1.Location = New System.Drawing.Point(739, 286)
        Me.CampoIDTextBox1.Name = "CampoIDTextBox1"
        Me.CampoIDTextBox1.Size = New System.Drawing.Size(28, 20)
        Me.CampoIDTextBox1.TabIndex = 181
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.AllowUserToAddRows = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.AutoGenerateColumns = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.DataSource = Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Location = New System.Drawing.Point(608, 208)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Name = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.RowHeadersVisible = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Size = New System.Drawing.Size(159, 75)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.TabIndex = 180
        '
        'TablaIDTextBox1
        '
        Me.TablaIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource, "TablaID", True))
        Me.TablaIDTextBox1.Location = New System.Drawing.Point(574, 234)
        Me.TablaIDTextBox1.Name = "TablaIDTextBox1"
        Me.TablaIDTextBox1.Size = New System.Drawing.Size(28, 20)
        Me.TablaIDTextBox1.TabIndex = 180
        '
        'NombreTablaTextBox2
        '
        Me.NombreTablaTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource, "NombreTabla", True))
        Me.NombreTablaTextBox2.Location = New System.Drawing.Point(574, 208)
        Me.NombreTablaTextBox2.Name = "NombreTablaTextBox2"
        Me.NombreTablaTextBox2.Size = New System.Drawing.Size(28, 20)
        Me.NombreTablaTextBox2.TabIndex = 179
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.AllowUserToAddRows = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.AutoGenerateColumns = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn11})
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.DataSource = Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Location = New System.Drawing.Point(1054, 271)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Name = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.RowHeadersVisible = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Size = New System.Drawing.Size(273, 109)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.TabIndex = 178
        '
        'XTablaCheckBox
        '
        Me.XTablaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "XTabla", True))
        Me.XTablaCheckBox.Location = New System.Drawing.Point(146, 442)
        Me.XTablaCheckBox.Name = "XTablaCheckBox"
        Me.XTablaCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.XTablaCheckBox.TabIndex = 178
        Me.XTablaCheckBox.Text = "CheckBox1"
        Me.XTablaCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 176
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ValorRequerimientoTextBox2
        '
        Me.ValorRequerimientoTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoBindingSource, "ValorRequerimiento", True))
        Me.ValorRequerimientoTextBox2.Location = New System.Drawing.Point(877, 191)
        Me.ValorRequerimientoTextBox2.Name = "ValorRequerimientoTextBox2"
        Me.ValorRequerimientoTextBox2.Size = New System.Drawing.Size(40, 20)
        Me.ValorRequerimientoTextBox2.TabIndex = 175
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 596)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(367, 13)
        Me.Label12.TabIndex = 174
        Me.Label12.Text = "SP_RegistroValorRequerimientos_SegunProyectoRequerimiento"
        '
        'RegistroValorRequerimientoIDTextBox
        '
        Me.RegistroValorRequerimientoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoBindingSource, "RegistroValorRequerimientoID", True))
        Me.RegistroValorRequerimientoIDTextBox.Location = New System.Drawing.Point(180, 614)
        Me.RegistroValorRequerimientoIDTextBox.Name = "RegistroValorRequerimientoIDTextBox"
        Me.RegistroValorRequerimientoIDTextBox.Size = New System.Drawing.Size(67, 20)
        Me.RegistroValorRequerimientoIDTextBox.TabIndex = 173
        '
        'ClavePrincipal
        '
        Me.ClavePrincipal.Location = New System.Drawing.Point(253, 145)
        Me.ClavePrincipal.Name = "ClavePrincipal"
        Me.ClavePrincipal.Size = New System.Drawing.Size(100, 20)
        Me.ClavePrincipal.TabIndex = 172
        '
        'NombreTablaTextBox1
        '
        Me.NombreTablaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, "NombreTabla", True))
        Me.NombreTablaTextBox1.Location = New System.Drawing.Point(146, 211)
        Me.NombreTablaTextBox1.Name = "NombreTablaTextBox1"
        Me.NombreTablaTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.NombreTablaTextBox1.TabIndex = 171
        '
        'MultiReplaceTextBox
        '
        Me.MultiReplaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource, "MultiReplace", True))
        Me.MultiReplaceTextBox.Location = New System.Drawing.Point(667, 165)
        Me.MultiReplaceTextBox.Multiline = True
        Me.MultiReplaceTextBox.Name = "MultiReplaceTextBox"
        Me.MultiReplaceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MultiReplaceTextBox.TabIndex = 170
        '
        'SeparadorCamposTextBox
        '
        Me.SeparadorCamposTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource, "SeparadorCampos", True))
        Me.SeparadorCamposTextBox.Location = New System.Drawing.Point(667, 111)
        Me.SeparadorCamposTextBox.Name = "SeparadorCamposTextBox"
        Me.SeparadorCamposTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SeparadorCamposTextBox.TabIndex = 169
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(874, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "ValorRequerimientoTextBox"
        '
        'ValorRequerimientoTextBox
        '
        Me.ValorRequerimientoTextBox.Location = New System.Drawing.Point(877, 25)
        Me.ValorRequerimientoTextBox.Name = "ValorRequerimientoTextBox"
        Me.ValorRequerimientoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ValorRequerimientoTextBox.TabIndex = 167
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 637)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(389, 13)
        Me.Label11.TabIndex = 166
        Me.Label11.Text = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 546)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Proyectos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 470)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(313, 13)
        Me.Label9.TabIndex = 164
        Me.Label9.Text = "SP_RegistroValorRequerimientos_SEGUN_ProyectoID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(380, 13)
        Me.Label8.TabIndex = 163
        Me.Label8.Text = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(360, 13)
        Me.Label7.TabIndex = 162
        Me.Label7.Text = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Tecnologias"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(413, 13)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 13)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SP_CARGA_TECNOLOGIAS_APLICADAS_"
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.AllowUserToAddRows = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.AutoGenerateColumns = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22})
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.DataSource = Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.Location = New System.Drawing.Point(234, 348)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.Name = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.RowHeadersVisible = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.RowTemplate.Height = 27
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.Size = New System.Drawing.Size(221, 203)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.TabIndex = 160
        '
        'CTI_
        '
        Me.CTI_.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource, "CampoID", True))
        Me.CTI_.Location = New System.Drawing.Point(254, 531)
        Me.CTI_.Name = "CTI_"
        Me.CTI_.Size = New System.Drawing.Size(53, 20)
        Me.CTI_.TabIndex = 161
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.AllowUserToAddRows = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.AutoGenerateColumns = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21})
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.DataSource = Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2BindingSource
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.Location = New System.Drawing.Point(230, 103)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.Name = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.RowHeadersVisible = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.RowTemplate.Height = 27
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.Size = New System.Drawing.Size(225, 121)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView.TabIndex = 162
        '
        'TablaIDDataGridViewTextBoxColumn
        '
        Me.TablaIDDataGridViewTextBoxColumn.DataPropertyName = "TablaID"
        Me.TablaIDDataGridViewTextBoxColumn.HeaderText = "TablaID"
        Me.TablaIDDataGridViewTextBoxColumn.Name = "TablaIDDataGridViewTextBoxColumn"
        Me.TablaIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProyectoIDDataGridViewTextBoxColumn
        '
        Me.ProyectoIDDataGridViewTextBoxColumn.DataPropertyName = "ProyectoID"
        Me.ProyectoIDDataGridViewTextBoxColumn.HeaderText = "ProyectoID"
        Me.ProyectoIDDataGridViewTextBoxColumn.Name = "ProyectoIDDataGridViewTextBoxColumn"
        '
        'NombreTablaDataGridViewTextBoxColumn
        '
        Me.NombreTablaDataGridViewTextBoxColumn.DataPropertyName = "NombreTabla"
        Me.NombreTablaDataGridViewTextBoxColumn.HeaderText = "NombreTabla"
        Me.NombreTablaDataGridViewTextBoxColumn.Name = "NombreTablaDataGridViewTextBoxColumn"
        '
        'TI_
        '
        Me.TI_.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2BindingSource, "TablaID", True))
        Me.TI_.Location = New System.Drawing.Point(298, 199)
        Me.TI_.Name = "TI_"
        Me.TI_.Size = New System.Drawing.Size(39, 20)
        Me.TI_.TabIndex = 184
        '
        'CodigoGeneradoRichTextBox
        '
        Me.CodigoGeneradoRichTextBox.ContextMenuStrip = Me.CM1
        Me.CodigoGeneradoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "CodigoGenerado", True))
        Me.CodigoGeneradoRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoGeneradoRichTextBox.Location = New System.Drawing.Point(412, 25)
        Me.CodigoGeneradoRichTextBox.Name = "CodigoGeneradoRichTextBox"
        Me.CodigoGeneradoRichTextBox.Size = New System.Drawing.Size(348, 404)
        Me.CodigoGeneradoRichTextBox.TabIndex = 185
        Me.CodigoGeneradoRichTextBox.Text = ""
        '
        'TD_
        '
        Me.TD_.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, "TablaID", True))
        Me.TD_.Location = New System.Drawing.Point(79, 199)
        Me.TD_.Name = "TD_"
        Me.TD_.Size = New System.Drawing.Size(50, 20)
        Me.TD_.TabIndex = 185
        '
        'CTD_
        '
        Me.CTD_.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "CampoID", True))
        Me.CTD_.Location = New System.Drawing.Point(25, 531)
        Me.CTD_.Name = "CTD_"
        Me.CTD_.Size = New System.Drawing.Size(50, 20)
        Me.CTD_.TabIndex = 186
        '
        'TipoCTD
        '
        Me.TipoCTD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "Tipo", True))
        Me.TipoCTD.Location = New System.Drawing.Point(81, 531)
        Me.TipoCTD.Name = "TipoCTD"
        Me.TipoCTD.Size = New System.Drawing.Size(50, 20)
        Me.TipoCTD.TabIndex = 187
        '
        'TipoCTI
        '
        Me.TipoCTI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource, "Tipo", True))
        Me.TipoCTI.Location = New System.Drawing.Point(311, 531)
        Me.TipoCTI.Name = "TipoCTI"
        Me.TipoCTI.Size = New System.Drawing.Size(53, 20)
        Me.TipoCTI.TabIndex = 188
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.AllowUserToAddRows = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.AutoGenerateColumns = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.DataSource = Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Location = New System.Drawing.Point(5, 6)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Name = "SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView"
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.RowHeadersVisible = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Size = New System.Drawing.Size(449, 335)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.TabIndex = 184
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(764, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(467, 583)
        Me.TabControl2.TabIndex = 189
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView)
        Me.TabPage3.Controls.Add(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView)
        Me.TabPage3.Controls.Add(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView)
        Me.TabPage3.Controls.Add(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.NombreTablaTextBox)
        Me.TabPage3.Controls.Add(Me.TipoCTI)
        Me.TabPage3.Controls.Add(NombreTablaLabel)
        Me.TabPage3.Controls.Add(Me.TipoCTD)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.NombreCampoTextBox)
        Me.TabPage3.Controls.Add(NombreCampoLabel)
        Me.TabPage3.Controls.Add(Me.CTD_)
        Me.TabPage3.Controls.Add(Me.Cbo_TipoDato)
        Me.TabPage3.Controls.Add(Me.TD_)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.CTI_)
        Me.TabPage3.Controls.Add(TablaIDLabel2)
        Me.TabPage3.Controls.Add(CampoIDLabel2)
        Me.TabPage3.Controls.Add(Me.TI_)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(459, 557)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Tablas y Campos"
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(CampoIndependienteLabel)
        Me.TabPage4.Controls.Add(Me.CampoIndependienteTextBox)
        Me.TabPage4.Controls.Add(TablaIndependienteLabel)
        Me.TabPage4.Controls.Add(Me.TablaIndependienteTextBox)
        Me.TabPage4.Controls.Add(CampoDependienteLabel)
        Me.TabPage4.Controls.Add(Me.CampoDependienteTextBox)
        Me.TabPage4.Controls.Add(TablaDependienteLabel)
        Me.TabPage4.Controls.Add(Me.TablaDependienteTextBox)
        Me.TabPage4.Controls.Add(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(459, 557)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Relaciones de Tabla"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(25, 445)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(409, 13)
        Me.Label14.TabIndex = 189
        Me.Label14.Text = "---------------------------------------------------------------------------------" &
    "-----------------------------------------------------"
        '
        'CampoIndependienteTextBox
        '
        Me.CampoIndependienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, "CampoIndependiente", True))
        Me.CampoIndependienteTextBox.Location = New System.Drawing.Point(8, 529)
        Me.CampoIndependienteTextBox.Name = "CampoIndependienteTextBox"
        Me.CampoIndependienteTextBox.Size = New System.Drawing.Size(444, 20)
        Me.CampoIndependienteTextBox.TabIndex = 188
        '
        'TablaIndependienteTextBox
        '
        Me.TablaIndependienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, "TablaIndependiente", True))
        Me.TablaIndependienteTextBox.Location = New System.Drawing.Point(8, 486)
        Me.TablaIndependienteTextBox.Name = "TablaIndependienteTextBox"
        Me.TablaIndependienteTextBox.Size = New System.Drawing.Size(444, 20)
        Me.TablaIndependienteTextBox.TabIndex = 187
        '
        'CampoDependienteTextBox
        '
        Me.CampoDependienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, "CampoDependiente", True))
        Me.CampoDependienteTextBox.Location = New System.Drawing.Point(8, 415)
        Me.CampoDependienteTextBox.Name = "CampoDependienteTextBox"
        Me.CampoDependienteTextBox.Size = New System.Drawing.Size(444, 20)
        Me.CampoDependienteTextBox.TabIndex = 186
        '
        'TablaDependienteTextBox
        '
        Me.TablaDependienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, "TablaDependiente", True))
        Me.TablaDependienteTextBox.Location = New System.Drawing.Point(8, 369)
        Me.TablaDependienteTextBox.Name = "TablaDependienteTextBox"
        Me.TablaDependienteTextBox.Size = New System.Drawing.Size(444, 20)
        Me.TablaDependienteTextBox.TabIndex = 185
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Panel_Requerimiento)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(459, 557)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Valores Requerimientos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel_Requerimiento
        '
        Me.Panel_Requerimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Requerimiento.Controls.Add(Me.EnunciadoEnRich)
        Me.Panel_Requerimiento.Controls.Add(RequerimientoLabel3)
        Me.Panel_Requerimiento.Controls.Add(Me.RequerimientoLabel4)
        Me.Panel_Requerimiento.Controls.Add(ProyectoIDLabel1)
        Me.Panel_Requerimiento.Controls.Add(Me.ProyectoIDTextBox1)
        Me.Panel_Requerimiento.Controls.Add(RegistroValorRequerimientoIDLabel1)
        Me.Panel_Requerimiento.Controls.Add(Me.RegistroValorRequerimientoIDTextBox1)
        Me.Panel_Requerimiento.Controls.Add(ValorRequerimientoLabel2)
        Me.Panel_Requerimiento.Controls.Add(Me.ValorRequerimientoTextBox3)
        Me.Panel_Requerimiento.Controls.Add(RequerimientoLabel2)
        Me.Panel_Requerimiento.Controls.Add(Me.RequerimientoTextBox2)
        Me.Panel_Requerimiento.Controls.Add(Me.BtnConservarYSeguir)
        Me.Panel_Requerimiento.Controls.Add(Me.BtnCancelarCargue)
        Me.Panel_Requerimiento.Controls.Add(Me.Button2)
        Me.Panel_Requerimiento.Controls.Add(Me.BtnLimpiarValoresRequerimientos)
        Me.Panel_Requerimiento.Controls.Add(Me.ValorRequerimiento)
        Me.Panel_Requerimiento.Controls.Add(Me.BtnEditarValorDeRequerimiento)
        Me.Panel_Requerimiento.Controls.Add(Me.BtnConfirmarValorRequerimiento)
        Me.Panel_Requerimiento.Controls.Add(Me.Label16)
        Me.Panel_Requerimiento.Controls.Add(Me.Lbl_Requerimiento)
        Me.Panel_Requerimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Requerimiento.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Requerimiento.Name = "Panel_Requerimiento"
        Me.Panel_Requerimiento.Size = New System.Drawing.Size(453, 551)
        Me.Panel_Requerimiento.TabIndex = 189
        '
        'BtnCancelarCargue
        '
        Me.BtnCancelarCargue.Image = CType(resources.GetObject("BtnCancelarCargue.Image"), System.Drawing.Image)
        Me.BtnCancelarCargue.Location = New System.Drawing.Point(95, 504)
        Me.BtnCancelarCargue.Name = "BtnCancelarCargue"
        Me.BtnCancelarCargue.Size = New System.Drawing.Size(40, 38)
        Me.BtnCancelarCargue.TabIndex = 139
        Me.ToolTip1.SetToolTip(Me.BtnCancelarCargue, "Cancelar Carga de Datos")
        Me.BtnCancelarCargue.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(3, 504)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 38)
        Me.Button2.TabIndex = 138
        Me.ToolTip1.SetToolTip(Me.Button2, "Iniciar Proceso de Cargue de Requerimientos")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnLimpiarValoresRequerimientos
        '
        Me.BtnLimpiarValoresRequerimientos.Image = CType(resources.GetObject("BtnLimpiarValoresRequerimientos.Image"), System.Drawing.Image)
        Me.BtnLimpiarValoresRequerimientos.Location = New System.Drawing.Point(49, 504)
        Me.BtnLimpiarValoresRequerimientos.Name = "BtnLimpiarValoresRequerimientos"
        Me.BtnLimpiarValoresRequerimientos.Size = New System.Drawing.Size(40, 38)
        Me.BtnLimpiarValoresRequerimientos.TabIndex = 134
        Me.ToolTip1.SetToolTip(Me.BtnLimpiarValoresRequerimientos, "Eliminar Registros de Valores de Requerimientos")
        Me.BtnLimpiarValoresRequerimientos.UseVisualStyleBackColor = True
        '
        'ValorRequerimiento
        '
        Me.ValorRequerimiento.Enabled = False
        Me.ValorRequerimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorRequerimiento.Location = New System.Drawing.Point(3, 472)
        Me.ValorRequerimiento.Name = "ValorRequerimiento"
        Me.ValorRequerimiento.Size = New System.Drawing.Size(395, 26)
        Me.ValorRequerimiento.TabIndex = 133
        '
        'BtnEditarValorDeRequerimiento
        '
        Me.BtnEditarValorDeRequerimiento.Enabled = False
        Me.BtnEditarValorDeRequerimiento.Image = CType(resources.GetObject("BtnEditarValorDeRequerimiento.Image"), System.Drawing.Image)
        Me.BtnEditarValorDeRequerimiento.Location = New System.Drawing.Point(313, 504)
        Me.BtnEditarValorDeRequerimiento.Name = "BtnEditarValorDeRequerimiento"
        Me.BtnEditarValorDeRequerimiento.Size = New System.Drawing.Size(40, 38)
        Me.BtnEditarValorDeRequerimiento.TabIndex = 129
        Me.ToolTip1.SetToolTip(Me.BtnEditarValorDeRequerimiento, "Editar Valor de Requerimiento")
        Me.BtnEditarValorDeRequerimiento.UseVisualStyleBackColor = True
        '
        'BtnConfirmarValorRequerimiento
        '
        Me.BtnConfirmarValorRequerimiento.Enabled = False
        Me.BtnConfirmarValorRequerimiento.Image = CType(resources.GetObject("BtnConfirmarValorRequerimiento.Image"), System.Drawing.Image)
        Me.BtnConfirmarValorRequerimiento.Location = New System.Drawing.Point(404, 466)
        Me.BtnConfirmarValorRequerimiento.Name = "BtnConfirmarValorRequerimiento"
        Me.BtnConfirmarValorRequerimiento.Size = New System.Drawing.Size(40, 38)
        Me.BtnConfirmarValorRequerimiento.TabIndex = 128
        Me.ToolTip1.SetToolTip(Me.BtnConfirmarValorRequerimiento, "Editar Valor de Requerimiento")
        Me.BtnConfirmarValorRequerimiento.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(222, 20)
        Me.Label16.TabIndex = 127
        Me.Label16.Text = "Nombre del Requerimiento"
        '
        'Lbl_Requerimiento
        '
        Me.Lbl_Requerimiento.AutoSize = True
        Me.Lbl_Requerimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Requerimiento", True))
        Me.Lbl_Requerimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Requerimiento.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Requerimiento.Location = New System.Drawing.Point(3, 26)
        Me.Lbl_Requerimiento.Name = "Lbl_Requerimiento"
        Me.Lbl_Requerimiento.Size = New System.Drawing.Size(24, 20)
        Me.Lbl_Requerimiento.TabIndex = 126
        Me.Lbl_Requerimiento.Text = "..."
        '
        'EnunciadoEnRich
        '
        Me.EnunciadoEnRich.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Enunciado", True))
        Me.EnunciadoEnRich.Location = New System.Drawing.Point(3, 49)
        Me.EnunciadoEnRich.Name = "EnunciadoEnRich"
        Me.EnunciadoEnRich.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.EnunciadoEnRich.Size = New System.Drawing.Size(441, 400)
        Me.EnunciadoEnRich.TabIndex = 125
        Me.EnunciadoEnRich.Text = ""
        '
        'Timer_CargueValorRequerimientos
        '
        '
        'BtnConservarYSeguir
        '
        Me.BtnConservarYSeguir.Enabled = False
        Me.BtnConservarYSeguir.Image = CType(resources.GetObject("BtnConservarYSeguir.Image"), System.Drawing.Image)
        Me.BtnConservarYSeguir.Location = New System.Drawing.Point(358, 504)
        Me.BtnConservarYSeguir.Name = "BtnConservarYSeguir"
        Me.BtnConservarYSeguir.Size = New System.Drawing.Size(40, 38)
        Me.BtnConservarYSeguir.TabIndex = 140
        Me.ToolTip1.SetToolTip(Me.BtnConservarYSeguir, "Editar Valor de Requerimiento")
        Me.BtnConservarYSeguir.UseVisualStyleBackColor = True
        '
        'Timer_EdicionValorRequerimiento
        '
        Me.Timer_EdicionValorRequerimiento.Interval = 1000
        '
        'RequerimientoLabel2
        '
        RequerimientoLabel2.AutoSize = True
        RequerimientoLabel2.Location = New System.Drawing.Point(154, 403)
        RequerimientoLabel2.Name = "RequerimientoLabel2"
        RequerimientoLabel2.Size = New System.Drawing.Size(78, 13)
        RequerimientoLabel2.TabIndex = 140
        RequerimientoLabel2.Text = "Requerimiento:"
        '
        'RequerimientoTextBox2
        '
        Me.RequerimientoTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "Requerimiento", True))
        Me.RequerimientoTextBox2.Location = New System.Drawing.Point(238, 400)
        Me.RequerimientoTextBox2.Name = "RequerimientoTextBox2"
        Me.RequerimientoTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.RequerimientoTextBox2.TabIndex = 141
        '
        'ValorRequerimientoLabel2
        '
        ValorRequerimientoLabel2.AutoSize = True
        ValorRequerimientoLabel2.Location = New System.Drawing.Point(127, 428)
        ValorRequerimientoLabel2.Name = "ValorRequerimientoLabel2"
        ValorRequerimientoLabel2.Size = New System.Drawing.Size(105, 13)
        ValorRequerimientoLabel2.TabIndex = 141
        ValorRequerimientoLabel2.Text = "Valor Requerimiento:"
        '
        'ValorRequerimientoTextBox3
        '
        Me.ValorRequerimientoTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "ValorRequerimiento", True))
        Me.ValorRequerimientoTextBox3.Location = New System.Drawing.Point(238, 425)
        Me.ValorRequerimientoTextBox3.Name = "ValorRequerimientoTextBox3"
        Me.ValorRequerimientoTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.ValorRequerimientoTextBox3.TabIndex = 142
        '
        'RegistroValorRequerimientoIDLabel1
        '
        RegistroValorRequerimientoIDLabel1.AutoSize = True
        RegistroValorRequerimientoIDLabel1.Location = New System.Drawing.Point(71, 377)
        RegistroValorRequerimientoIDLabel1.Name = "RegistroValorRequerimientoIDLabel1"
        RegistroValorRequerimientoIDLabel1.Size = New System.Drawing.Size(161, 13)
        RegistroValorRequerimientoIDLabel1.TabIndex = 142
        RegistroValorRequerimientoIDLabel1.Text = "Registro Valor Requerimiento ID:"
        '
        'RegistroValorRequerimientoIDTextBox1
        '
        Me.RegistroValorRequerimientoIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "RegistroValorRequerimientoID", True))
        Me.RegistroValorRequerimientoIDTextBox1.Location = New System.Drawing.Point(238, 374)
        Me.RegistroValorRequerimientoIDTextBox1.Name = "RegistroValorRequerimientoIDTextBox1"
        Me.RegistroValorRequerimientoIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.RegistroValorRequerimientoIDTextBox1.TabIndex = 143
        '
        'ProyectoIDLabel1
        '
        ProyectoIDLabel1.AutoSize = True
        ProyectoIDLabel1.Location = New System.Drawing.Point(166, 351)
        ProyectoIDLabel1.Name = "ProyectoIDLabel1"
        ProyectoIDLabel1.Size = New System.Drawing.Size(66, 13)
        ProyectoIDLabel1.TabIndex = 143
        ProyectoIDLabel1.Text = "Proyecto ID:"
        '
        'ProyectoIDTextBox1
        '
        Me.ProyectoIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "ProyectoID", True))
        Me.ProyectoIDTextBox1.Location = New System.Drawing.Point(238, 348)
        Me.ProyectoIDTextBox1.Name = "ProyectoIDTextBox1"
        Me.ProyectoIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ProyectoIDTextBox1.TabIndex = 144
        '
        'RequerimientoLabel3
        '
        RequerimientoLabel3.AutoSize = True
        RequerimientoLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RequerimientoLabel3.Location = New System.Drawing.Point(3, 451)
        RequerimientoLabel3.Name = "RequerimientoLabel3"
        RequerimientoLabel3.Size = New System.Drawing.Size(113, 16)
        RequerimientoLabel3.TabIndex = 144
        RequerimientoLabel3.Text = "Requerimiento:"
        '
        'RequerimientoLabel4
        '
        Me.RequerimientoLabel4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "Requerimiento", True))
        Me.RequerimientoLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequerimientoLabel4.Location = New System.Drawing.Point(122, 448)
        Me.RequerimientoLabel4.Name = "RequerimientoLabel4"
        Me.RequerimientoLabel4.Size = New System.Drawing.Size(276, 23)
        Me.RequerimientoLabel4.TabIndex = 145
        Me.RequerimientoLabel4.Text = "..."
        Me.RequerimientoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource.DataMember = "SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1"
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataSetTablasYCampos
        '
        Me.DataSetTablasYCampos.DataSetName = "DataSetTablasYCampos"
        Me.DataSetTablasYCampos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "TablaDependiente"
        Me.DataGridViewTextBoxColumn25.HeaderText = "TablaDependiente"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "CampoDependiente"
        Me.DataGridViewTextBoxColumn26.HeaderText = "CampoDependiente"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "TablaIndependiente"
        Me.DataGridViewTextBoxColumn27.HeaderText = "TablaIndependiente"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "CampoIndependiente"
        Me.DataGridViewTextBoxColumn28.HeaderText = "CampoIndependiente"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "RegistroRelacionesTablasID"
        Me.DataGridViewTextBoxColumn29.HeaderText = "RegistroRelacionesTablasID"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "ID_TD"
        Me.DataGridViewTextBoxColumn30.HeaderText = "ID_TD"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "ID_CTD"
        Me.DataGridViewTextBoxColumn31.HeaderText = "ID_CTD"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "ID_TI"
        Me.DataGridViewTextBoxColumn32.HeaderText = "ID_TI"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "ID_CTI"
        Me.DataGridViewTextBoxColumn33.HeaderText = "ID_CTI"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource
        '
        Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource.DataMember = "SP_CARGA_TablasRelacionadas_SEGUN_PlantillaID"
        Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource.DataMember = "SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD"
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource.DataMember = "SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTI"
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource.DataMember = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CampoID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "CampoID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TablaID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "TablaID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NombreCampo"
        Me.DataGridViewTextBoxColumn17.HeaderText = "NombreCampo"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource.DataMember = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TablaID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TablaID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProyectoID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProyectoID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "NombreTabla"
        Me.DataGridViewTextBoxColumn11.HeaderText = "NombreTabla"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'SP_RegistroValorRequerimientos_SegunProyectoRequerimientoBindingSource
        '
        Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoBindingSource.DataMember = "SP_RegistroValorRequerimientos_SegunProyectoRequerimiento"
        Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource.DataMember = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CampoComponentes_Segun_Plantilla_TipoBindingSource
        '
        Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource.DataMember = "SP_CampoComponentes_Segun_Plantilla_Tipo"
        Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource.DataMember = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource.DataMember = "SP_RegistroValorRequerimientos_SEGUN_ProyectoID"
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NombreTabla"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nombre Tabla"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 447
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "NombreTabla"
        Me.DataGridViewTextBoxColumn21.HeaderText = "NombreTabla"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 221
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2BindingSource
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2BindingSource.DataMember = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NombreCampo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nombre Campo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 447
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "NombreCampo"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Nombre Campo Relacionado"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 217
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource.DataMember = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TablaDependiente"
        Me.DataGridViewTextBoxColumn19.HeaderText = "TablaDependiente"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 112
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CampoDependiente"
        Me.DataGridViewTextBoxColumn20.HeaderText = "CampoDependiente"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 112
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TablaIndependiente"
        Me.DataGridViewTextBoxColumn23.HeaderText = "TablaIndependiente"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 112
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "CampoIndependiente"
        Me.DataGridViewTextBoxColumn24.HeaderText = "CampoIndependiente"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 112
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Requerimiento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Requerimiento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 169
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ValorRequerimiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Valor Requerimiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 169
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter.ClearBeforeFill = True
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
        'SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource
        '
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource.DataMember = "SP_RegistroValorRequerimientos_EDICION_INSERTAR"
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter
        '
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource
        '
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource.DataMember = "SP_ELIMINA_RegistroValorRequerimientos_SegunID"
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter
        '
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource.DataMember = "SP_TablasDeProyecto_EDICION_ACTUALIZAR"
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasDeProyecto_EDICION_ELIMINARBindingSource
        '
        Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource.DataMember = "SP_TablasDeProyecto_EDICION_ELIMINAR"
        Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter
        '
        Me.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasDeProyecto_EDICION_INSERTARBindingSource
        '
        Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource.DataMember = "SP_TablasDeProyecto_EDICION_INSERTAR"
        Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasDeProyecto_EDICION_INSERTARTableAdapter
        '
        Me.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource.DataMember = "SP_CamposDeTablas_EDICION_ACTUALIZAR"
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_EDICION_ELIMINARBindingSource
        '
        Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource.DataMember = "SP_CamposDeTablas_EDICION_ELIMINAR"
        Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CamposDeTablas_EDICION_ELIMINARTableAdapter
        '
        Me.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_EDICION_INSERTARBindingSource
        '
        Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource.DataMember = "SP_CamposDeTablas_EDICION_INSERTAR"
        Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CamposDeTablas_EDICION_INSERTARTableAdapter
        '
        Me.SP_CamposDeTablas_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_CampoComponentes_Segun_Plantilla_TipoTableAdapter
        '
        Me.SP_CampoComponentes_Segun_Plantilla_TipoTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroValorRequerimientos_SegunProyectoRequerimientoTableAdapter
        '
        Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter.ClearBeforeFill = True
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2TableAdapter
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2TableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource
        '
        Me.SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource.DataMember = "SP_RegistroRelacionesTablas_EDICION_INSERTAR"
        Me.SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter
        '
        Me.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource
        '
        Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource.DataMember = "SP_RegistroRelacionesTablas_EDICION_ELIMINAR"
        Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter
        '
        Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter.ClearBeforeFill = True
        '
        'SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter
        '
        Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1TableAdapter
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1TableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource.DataMember = "SP_RegistroValorRequerimientos_EDICION_ACTUALIZAR"
        Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource
        '
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource.DataMember = "SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO"
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource.DataSource = Me.DataSetAdministracion
        '
        'DataSetAdministracion
        '
        Me.DataSetAdministracion.DataSetName = "DataSetAdministracion"
        Me.DataSetAdministracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetAdministracion
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Enunciado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Requerimientos"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 180
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NombreComponente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Componente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 142
        '
        'TecnologiasBindingSource
        '
        Me.TecnologiasBindingSource.DataMember = "Tecnologias"
        Me.TecnologiasBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataMember = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataSource = Me.DataSetAdministracion
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DataSetAdministracion
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NombreTecnologia"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Tecnologia"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 195
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Plantilla"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 194
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NombreTecnologia"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre Tecnologia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 178
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre Plantilla"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 186
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NombreProyecto"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nombre Proyecto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 389
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ELIMINA_SEGUN_PROYECTOTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
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
        Me.TableAdapterManager.TecnologiasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TecnologiasTableAdapter
        '
        Me.TecnologiasTableAdapter.ClearBeforeFill = True
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'SP_Proyectos_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource.DataMember = "SP_Proyectos_EDICION_ACTUALIZAR"
        Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Proyectos_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_Proyectos_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_Proyectos_EDICION_ELIMINARBindingSource
        '
        Me.SP_Proyectos_EDICION_ELIMINARBindingSource.DataMember = "SP_Proyectos_EDICION_ELIMINAR"
        Me.SP_Proyectos_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Proyectos_EDICION_ELIMINARTableAdapter
        '
        Me.SP_Proyectos_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_Proyectos_EDICION_INSERTARBindingSource
        '
        Me.SP_Proyectos_EDICION_INSERTARBindingSource.DataMember = "SP_Proyectos_EDICION_INSERTAR"
        Me.SP_Proyectos_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Proyectos_EDICION_INSERTARTableAdapter
        '
        Me.SP_Proyectos_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter
        '
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter.ClearBeforeFill = True
        '
        'SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource
        '
        Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource.DataMember = "SP_ProyectosYTecnologias_EDICION_INSERTAR"
        Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter
        '
        Me.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'ELIMINA_SEGUN_PROYECTOBindingSource
        '
        Me.ELIMINA_SEGUN_PROYECTOBindingSource.DataMember = "ELIMINA_SEGUN_PROYECTO"
        Me.ELIMINA_SEGUN_PROYECTOBindingSource.DataSource = Me.DataSetAdministracion
        '
        'ELIMINA_SEGUN_PROYECTOTableAdapter
        '
        Me.ELIMINA_SEGUN_PROYECTOTableAdapter.ClearBeforeFill = True
        '
        'SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource
        '
        Me.SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource.DataMember = "SP_ProyectosYTecnologias_EDICION_ELIMINAR"
        Me.SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter
        '
        Me.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'FrmReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1234, 591)
        Me.Controls.Add(Me.PanelConf)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(CodigoGeneradoLabel)
        Me.Controls.Add(Me.CodigoGeneradoRichTextBox)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReplace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generación de Codigo"
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_Plantilla.ResumeLayout(False)
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_EliminandoTecnologias.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.PanelAdministracion_.ResumeLayout(False)
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM1.ResumeLayout(False)
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_RelacionesTablas.ResumeLayout(False)
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelConf.ResumeLayout(False)
        Me.PanelConf.PerformLayout()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel_Requerimiento.ResumeLayout(False)
        Me.Panel_Requerimiento.PerformLayout()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CampoComponentes_Segun_Plantilla_TipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Proyectos_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Proyectos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELIMINA_SEGUN_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableAdapterManager As DataSetAdministracionTableAdapters.TableAdapterManager
    Friend WithEvents DataSetAdministracion As DataSetAdministracion
    Friend WithEvents TecnologiasBindingSource As BindingSource
    Friend WithEvents TecnologiasTableAdapter As DataSetAdministracionTableAdapters.TecnologiasTableAdapter
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter As DataSetAdministracionTableAdapters.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView As DataGridView
    Friend WithEvents TecnologiasDataGridView As DataGridView
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ComponenteIDTextBox As TextBox
    Friend WithEvents PlantillaIDTextBox As TextBox
    Friend WithEvents ControlNulos As TextBox
    Friend WithEvents TecnologiaIDTextBox As TextBox
    Friend WithEvents EnunciadoTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProyectosBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As DataSetAdministracionTableAdapters.ProyectosTableAdapter
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents NombreProyectoTextBox As TextBox
    Friend WithEvents ProyectosDataGridView As DataGridView
    Friend WithEvents ProyectoIDTextBox As TextBox
    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Nuevo_Menu_Proyectos As Button
    Friend WithEvents Cancelar_Menu_Proyectos As Button
    Friend WithEvents Eliminar_Menu_Proyectos As Button
    Friend WithEvents Editar_Menu_Proyectos As Button
    Friend WithEvents Actualizar_Menu_Proyectos As Button
    Friend WithEvents Guardar_Menu_Proyectos As Button
    Friend WithEvents SP_Proyectos_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_Proyectos_EDICION_ACTUALIZARTableAdapter As DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_Proyectos_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_Proyectos_EDICION_ELIMINARTableAdapter As DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_Proyectos_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_Proyectos_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_INSERTARTableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource As BindingSource
    Friend WithEvents SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter As DataSetAdministracionTableAdapters.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter
    Friend WithEvents SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView As DataGridView
    Friend WithEvents SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter
    Friend WithEvents NombreTecnologiaTextBox As TextBox
    Friend WithEvents ELIMINA_SEGUN_PROYECTOBindingSource As BindingSource
    Friend WithEvents ELIMINA_SEGUN_PROYECTOTableAdapter As DataSetAdministracionTableAdapters.ELIMINA_SEGUN_PROYECTOTableAdapter
    Friend WithEvents TecnologiaID_EliminaRelacion As TextBox
    Friend WithEvents DataSetTablasYCampos As DataSetTablasYCampos
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSetTablasYCamposTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView As DataGridView
    Friend WithEvents RequerimientoTextBox As TextBox
    Friend WithEvents SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter
    Friend WithEvents SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource As BindingSource
    Friend WithEvents SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource As BindingSource
    Friend WithEvents SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter
    Friend WithEvents SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView As DataGridView
    Friend WithEvents BtnRemplazar As Button
    Friend WithEvents NombreComponenteTextBox As TextBox
    Friend WithEvents NombreTecnologiaTextBox1 As TextBox
    Friend WithEvents RequerimientoTextBox1 As TextBox
    Friend WithEvents ValorRequerimientoTextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Nuevo_Menu_TablasDeProyecto As Button
    Friend WithEvents Cancelar_Menu_TablasDeProyecto As Button
    Friend WithEvents Eliminar_Menu_TablasDeProyecto As Button
    Friend WithEvents Editar_Menu_TablasDeProyecto As Button
    Friend WithEvents Actualizar_Menu_TablasDeProyecto As Button
    Friend WithEvents Guardar_Menu_TablasDeProyecto As Button
    Friend WithEvents NombreTablaTextBox As TextBox
    Friend WithEvents TablaIDTextBox As TextBox
    Friend WithEvents SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_TablasDeProyecto_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_TablasDeProyecto_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Nuevo_Menu_CamposDeTablas As Button
    Friend WithEvents Cancelar_Menu_CamposDeTablas As Button
    Friend WithEvents Eliminar_Menu_CamposDeTablas As Button
    Friend WithEvents Editar_Menu_CamposDeTablas As Button
    Friend WithEvents Actualizar_Menu_CamposDeTablas As Button
    Friend WithEvents Guardar_Menu_CamposDeTablas As Button
    Friend WithEvents Panel4 As Panel

    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView As DataGridView
    Friend WithEvents CampoIDTextBox As TextBox
    Friend WithEvents NombreCampoTextBox As TextBox
    Friend WithEvents SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_CamposDeTablas_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_CamposDeTablas_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_INSERTARTableAdapter
    Friend WithEvents Cbo_TipoDato As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents SP_CampoComponentes_Segun_Plantilla_TipoBindingSource As BindingSource
    Friend WithEvents SP_CampoComponentes_Segun_Plantilla_TipoTableAdapter As DataSetTablasYCamposTableAdapters.SP_CampoComponentes_Segun_Plantilla_TipoTableAdapter
    Friend WithEvents PrefijoTextBox As TextBox
    Friend WithEvents SuperiorTextBox As TextBox
    Friend WithEvents SufijoTextBox As TextBox
    Friend WithEvents InferiorTextBox As TextBox
    Friend WithEvents PlantillaIDTextBox1 As TextBox
    Friend WithEvents PanelConf As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ValorRequerimientoTextBox As TextBox
    Friend WithEvents SeparadorCamposTextBox As TextBox
    Friend WithEvents MultiReplaceTextBox As TextBox
    Friend WithEvents CM1 As ContextMenuStrip
    Friend WithEvents MaximizarCodigoGeneradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCopiar As Button
    Friend WithEvents NombreTablaTextBox1 As TextBox
    Friend WithEvents ClavePrincipal As TextBox
    Friend WithEvents SP_RegistroValorRequerimientos_SegunProyectoRequerimientoBindingSource As BindingSource
    Friend WithEvents SP_RegistroValorRequerimientos_SegunProyectoRequerimientoTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_SegunProyectoRequerimientoTableAdapter
    Friend WithEvents Label12 As Label
    Friend WithEvents RegistroValorRequerimientoIDTextBox As TextBox
    Friend WithEvents ValorRequerimientoTextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents XTablaCheckBox As CheckBox
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter
    Friend WithEvents NombreTablaTextBox2 As TextBox
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents TablaIDTextBox1 As TextBox
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter
    Friend WithEvents TipoTextBox1 As TextBox
    Friend WithEvents NombreCampoTextBox1 As TextBox
    Friend WithEvents CampoIDTextBox1 As TextBox
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents CM_Plantilla As ContextMenuStrip
    Friend WithEvents AgregarPlantillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView As DataGridView
    Friend WithEvents CTI_ As TextBox
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2BindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2TableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2TableAdapter
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID2DataGridView As DataGridView
    Friend WithEvents TablaIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProyectoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreTablaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TI_ As TextBox
    Friend WithEvents Chk_Rel As CheckBox
    Friend WithEvents CodigoGeneradoRichTextBox As RichTextBox
    Friend WithEvents TD_ As TextBox
    Friend WithEvents CTD_ As TextBox
    Friend WithEvents SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter
    Friend WithEvents TipoCTD As TextBox
    Friend WithEvents TipoCTI As TextBox
    Friend WithEvents CM_RelacionesTablas As ContextMenuStrip
    Friend WithEvents CrearRelacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EliminarRelaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource As BindingSource
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter
    Friend WithEvents RegistroRelacionesTablasIDTextBox As TextBox
    Friend WithEvents SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource As BindingSource
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents RegistroRelacionesTablasIDTextBox1 As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents CampoIndependienteTextBox As TextBox
    Friend WithEvents TablaIndependienteTextBox As TextBox
    Friend WithEvents CampoDependienteTextBox As TextBox
    Friend WithEvents TablaDependienteTextBox As TextBox
    Friend WithEvents SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter
    Friend WithEvents ContenidoRelacionTextBox As TextBox
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1BindingSource As BindingSource
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1TableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1TableAdapter
    Friend WithEvents CampoIndependienteTextBox1 As TextBox
    Friend WithEvents TablaIndependienteTextBox1 As TextBox
    Friend WithEvents CampoDependienteTextBox1 As TextBox
    Friend WithEvents TablaDependienteTextBox1 As TextBox
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel_Requerimiento As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Lbl_Requerimiento As Label
    Friend WithEvents EnunciadoEnRich As RichTextBox
    Friend WithEvents BtnConfirmarValorRequerimiento As Button
    Friend WithEvents BtnEditarValorDeRequerimiento As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ValorRequerimiento As TextBox
    Friend WithEvents BtnLimpiarValoresRequerimientos As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer_CargueValorRequerimientos As Timer
    Friend WithEvents BtnCancelarCargue As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents ProyectosYTecnologiasIDTextBox As TextBox
    Friend WithEvents CM_EliminandoTecnologias As ContextMenuStrip
    Friend WithEvents EliminarUna As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents EliminarTodas As ToolStripMenuItem
    Friend WithEvents SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter As DataSetAdministracionTableAdapters.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents MaximizarPaneles As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents MinimizarPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BtnConservarYSeguir As Button
    Friend WithEvents Timer_EdicionValorRequerimiento As Timer
    Friend WithEvents ProyectoIDTextBox1 As TextBox
    Friend WithEvents RegistroValorRequerimientoIDTextBox1 As TextBox
    Friend WithEvents ValorRequerimientoTextBox3 As TextBox
    Friend WithEvents RequerimientoTextBox2 As TextBox
    Friend WithEvents RequerimientoLabel4 As Label
    Friend WithEvents SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter
End Class
