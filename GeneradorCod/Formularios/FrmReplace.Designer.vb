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
        Dim RequerimientoPlantillaIDLabel As System.Windows.Forms.Label
        Dim ComponenteIDLabel As System.Windows.Forms.Label
        Dim PlantillaIDLabel As System.Windows.Forms.Label
        Dim TecnologiaIDLabel As System.Windows.Forms.Label
        Dim EnunciadoLabel As System.Windows.Forms.Label
        Dim ProyectoIDLabel As System.Windows.Forms.Label
        Dim NombreProyectoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim CodigoGeneradoLabel As System.Windows.Forms.Label
        Dim NombreTecnologiaLabel As System.Windows.Forms.Label
        Dim TecnologiaIDLabel1 As System.Windows.Forms.Label
        Dim RequerimientoLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim NombreComponenteLabel As System.Windows.Forms.Label
        Dim NombreTecnologiaLabel1 As System.Windows.Forms.Label
        Dim RequerimientoLabel1 As System.Windows.Forms.Label
        Dim ValorRequerimientoLabel As System.Windows.Forms.Label
        Dim NombreTablaLabel As System.Windows.Forms.Label
        Dim TablaIDLabel As System.Windows.Forms.Label
        Dim TipoCampoIDLabel As System.Windows.Forms.Label
        Dim GrupoTiposIDLabel As System.Windows.Forms.Label
        Dim CampoIDLabel As System.Windows.Forms.Label
        Dim NombreCampoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReplace))
        Dim TipoLabel As System.Windows.Forms.Label
        Me.BtnBuscarYPintar = New System.Windows.Forms.Button()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAdministracion = New GeneradorCod.DataSetAdministracion()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TecnologiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TecnologiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequerimientoPlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.ComponenteIDTextBox = New System.Windows.Forms.TextBox()
        Me.PlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.ControlNulos = New System.Windows.Forms.TextBox()
        Me.TecnologiaIDTextBox = New System.Windows.Forms.TextBox()
        Me.EnunciadoTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Editar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.ProyectosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProyectoIDTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoGeneradoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTecnologiaTextBox = New System.Windows.Forms.TextBox()
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
        Me.TecnologiaID_EliminaRelacion = New System.Windows.Forms.TextBox()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTablasYCampos = New GeneradorCod.DataSetTablasYCampos()
        Me.RequerimientoTextBox = New System.Windows.Forms.TextBox()
        Me.ValorRequerimientoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter()
        Me.TableAdapterManager1 = New GeneradorCod.DataSetTablasYCamposTableAdapters.TableAdapterManager()
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter()
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter()
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter()
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnRemplazar = New System.Windows.Forms.Button()
        Me.NombreComponenteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTecnologiaTextBox1 = New System.Windows.Forms.TextBox()
        Me.RequerimientoTextBox1 = New System.Windows.Forms.TextBox()
        Me.ValorRequerimientoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Editar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Guardar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.NombreTablaTextBox = New System.Windows.Forms.TextBox()
        Me.TablaIDTextBox = New System.Windows.Forms.TextBox()
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter()
        Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter()
        Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Editar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Guardar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CboTiposDeCampo = New System.Windows.Forms.ComboBox()
        Me.SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter()
        Me.TipoCampoIDTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoTiposIDTextBox = New System.Windows.Forms.TextBox()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampoIDTextBox = New System.Windows.Forms.TextBox()
        Me.NombreCampoTextBox = New System.Windows.Forms.TextBox()
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter()
        Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter()
        Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_INSERTARTableAdapter()
        Me.Cbo_TipoDato = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        RequerimientoPlantillaIDLabel = New System.Windows.Forms.Label()
        ComponenteIDLabel = New System.Windows.Forms.Label()
        PlantillaIDLabel = New System.Windows.Forms.Label()
        TecnologiaIDLabel = New System.Windows.Forms.Label()
        EnunciadoLabel = New System.Windows.Forms.Label()
        ProyectoIDLabel = New System.Windows.Forms.Label()
        NombreProyectoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CodigoGeneradoLabel = New System.Windows.Forms.Label()
        NombreTecnologiaLabel = New System.Windows.Forms.Label()
        TecnologiaIDLabel1 = New System.Windows.Forms.Label()
        RequerimientoLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        NombreComponenteLabel = New System.Windows.Forms.Label()
        NombreTecnologiaLabel1 = New System.Windows.Forms.Label()
        RequerimientoLabel1 = New System.Windows.Forms.Label()
        ValorRequerimientoLabel = New System.Windows.Forms.Label()
        NombreTablaLabel = New System.Windows.Forms.Label()
        TablaIDLabel = New System.Windows.Forms.Label()
        TipoCampoIDLabel = New System.Windows.Forms.Label()
        GrupoTiposIDLabel = New System.Windows.Forms.Label()
        CampoIDLabel = New System.Windows.Forms.Label()
        NombreCampoLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.PanelAdministracion_.SuspendLayout()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Proyectos_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Proyectos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELIMINA_SEGUN_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RequerimientoPlantillaIDLabel
        '
        RequerimientoPlantillaIDLabel.AutoSize = True
        RequerimientoPlantillaIDLabel.Location = New System.Drawing.Point(926, 239)
        RequerimientoPlantillaIDLabel.Name = "RequerimientoPlantillaIDLabel"
        RequerimientoPlantillaIDLabel.Size = New System.Drawing.Size(131, 13)
        RequerimientoPlantillaIDLabel.TabIndex = 119
        RequerimientoPlantillaIDLabel.Text = "Requerimiento Plantilla ID:"
        '
        'ComponenteIDLabel
        '
        ComponenteIDLabel.AutoSize = True
        ComponenteIDLabel.Location = New System.Drawing.Point(973, 207)
        ComponenteIDLabel.Name = "ComponenteIDLabel"
        ComponenteIDLabel.Size = New System.Drawing.Size(84, 13)
        ComponenteIDLabel.TabIndex = 117
        ComponenteIDLabel.Text = "Componente ID:"
        '
        'PlantillaIDLabel
        '
        PlantillaIDLabel.AutoSize = True
        PlantillaIDLabel.Location = New System.Drawing.Point(997, 175)
        PlantillaIDLabel.Name = "PlantillaIDLabel"
        PlantillaIDLabel.Size = New System.Drawing.Size(60, 13)
        PlantillaIDLabel.TabIndex = 115
        PlantillaIDLabel.Text = "Plantilla ID:"
        '
        'TecnologiaIDLabel
        '
        TecnologiaIDLabel.AutoSize = True
        TecnologiaIDLabel.Location = New System.Drawing.Point(980, 121)
        TecnologiaIDLabel.Name = "TecnologiaIDLabel"
        TecnologiaIDLabel.Size = New System.Drawing.Size(77, 13)
        TecnologiaIDLabel.TabIndex = 112
        TecnologiaIDLabel.Text = "Tecnologia ID:"
        '
        'EnunciadoLabel
        '
        EnunciadoLabel.AutoSize = True
        EnunciadoLabel.Location = New System.Drawing.Point(996, 63)
        EnunciadoLabel.Name = "EnunciadoLabel"
        EnunciadoLabel.Size = New System.Drawing.Size(61, 13)
        EnunciadoLabel.TabIndex = 120
        EnunciadoLabel.Text = "Enunciado:"
        '
        'ProyectoIDLabel
        '
        ProyectoIDLabel.AutoSize = True
        ProyectoIDLabel.Location = New System.Drawing.Point(991, 265)
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
        'CodigoGeneradoLabel
        '
        CodigoGeneradoLabel.AutoSize = True
        CodigoGeneradoLabel.Location = New System.Drawing.Point(395, 4)
        CodigoGeneradoLabel.Name = "CodigoGeneradoLabel"
        CodigoGeneradoLabel.Size = New System.Drawing.Size(93, 13)
        CodigoGeneradoLabel.TabIndex = 90
        CodigoGeneradoLabel.Text = "Codigo Generado:"
        '
        'NombreTecnologiaLabel
        '
        NombreTecnologiaLabel.AutoSize = True
        NombreTecnologiaLabel.Location = New System.Drawing.Point(954, 37)
        NombreTecnologiaLabel.Name = "NombreTecnologiaLabel"
        NombreTecnologiaLabel.Size = New System.Drawing.Size(103, 13)
        NombreTecnologiaLabel.TabIndex = 123
        NombreTecnologiaLabel.Text = "Nombre Tecnologia:"
        '
        'TecnologiaIDLabel1
        '
        TecnologiaIDLabel1.AutoSize = True
        TecnologiaIDLabel1.Location = New System.Drawing.Point(924, 148)
        TecnologiaIDLabel1.Name = "TecnologiaIDLabel1"
        TecnologiaIDLabel1.Size = New System.Drawing.Size(133, 13)
        TecnologiaIDLabel1.TabIndex = 124
        TecnologiaIDLabel1.Text = "Tecnologia ID Eliminacion:"
        '
        'RequerimientoLabel
        '
        RequerimientoLabel.AutoSize = True
        RequerimientoLabel.Location = New System.Drawing.Point(1138, 416)
        RequerimientoLabel.Name = "RequerimientoLabel"
        RequerimientoLabel.Size = New System.Drawing.Size(78, 13)
        RequerimientoLabel.TabIndex = 126
        RequerimientoLabel.Text = "Requerimiento:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(1165, 355)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 129
        CodigoLabel.Text = "Codigo:"
        '
        'NombreComponenteLabel
        '
        NombreComponenteLabel.AutoSize = True
        NombreComponenteLabel.Location = New System.Drawing.Point(1165, 313)
        NombreComponenteLabel.Name = "NombreComponenteLabel"
        NombreComponenteLabel.Size = New System.Drawing.Size(110, 13)
        NombreComponenteLabel.TabIndex = 132
        NombreComponenteLabel.Text = "Nombre Componente:"
        '
        'NombreTecnologiaLabel1
        '
        NombreTecnologiaLabel1.AutoSize = True
        NombreTecnologiaLabel1.Location = New System.Drawing.Point(1172, 273)
        NombreTecnologiaLabel1.Name = "NombreTecnologiaLabel1"
        NombreTecnologiaLabel1.Size = New System.Drawing.Size(103, 13)
        NombreTecnologiaLabel1.TabIndex = 133
        NombreTecnologiaLabel1.Text = "Nombre Tecnologia:"
        '
        'RequerimientoLabel1
        '
        RequerimientoLabel1.AutoSize = True
        RequerimientoLabel1.Location = New System.Drawing.Point(1172, 189)
        RequerimientoLabel1.Name = "RequerimientoLabel1"
        RequerimientoLabel1.Size = New System.Drawing.Size(78, 13)
        RequerimientoLabel1.TabIndex = 134
        RequerimientoLabel1.Text = "Requerimiento:"
        '
        'ValorRequerimientoLabel
        '
        ValorRequerimientoLabel.AutoSize = True
        ValorRequerimientoLabel.Location = New System.Drawing.Point(1172, 228)
        ValorRequerimientoLabel.Name = "ValorRequerimientoLabel"
        ValorRequerimientoLabel.Size = New System.Drawing.Size(105, 13)
        ValorRequerimientoLabel.TabIndex = 135
        ValorRequerimientoLabel.Text = "Valor Requerimiento:"
        '
        'NombreTablaLabel
        '
        NombreTablaLabel.AutoSize = True
        NombreTablaLabel.Location = New System.Drawing.Point(591, 75)
        NombreTablaLabel.Name = "NombreTablaLabel"
        NombreTablaLabel.Size = New System.Drawing.Size(77, 13)
        NombreTablaLabel.TabIndex = 138
        NombreTablaLabel.Text = "Nombre Tabla:"
        '
        'TablaIDLabel
        '
        TablaIDLabel.AutoSize = True
        TablaIDLabel.Location = New System.Drawing.Point(1005, 11)
        TablaIDLabel.Name = "TablaIDLabel"
        TablaIDLabel.Size = New System.Drawing.Size(51, 13)
        TablaIDLabel.TabIndex = 139
        TablaIDLabel.Text = "Tabla ID:"
        '
        'TipoCampoIDLabel
        '
        TipoCampoIDLabel.AutoSize = True
        TipoCampoIDLabel.Location = New System.Drawing.Point(1153, 503)
        TipoCampoIDLabel.Name = "TipoCampoIDLabel"
        TipoCampoIDLabel.Size = New System.Drawing.Size(81, 13)
        TipoCampoIDLabel.TabIndex = 144
        TipoCampoIDLabel.Text = "Tipo Campo ID:"
        '
        'GrupoTiposIDLabel
        '
        GrupoTiposIDLabel.AutoSize = True
        GrupoTiposIDLabel.Location = New System.Drawing.Point(1152, 529)
        GrupoTiposIDLabel.Name = "GrupoTiposIDLabel"
        GrupoTiposIDLabel.Size = New System.Drawing.Size(82, 13)
        GrupoTiposIDLabel.TabIndex = 145
        GrupoTiposIDLabel.Text = "Grupo Tipos ID:"
        '
        'CampoIDLabel
        '
        CampoIDLabel.AutoSize = True
        CampoIDLabel.Location = New System.Drawing.Point(1177, 477)
        CampoIDLabel.Name = "CampoIDLabel"
        CampoIDLabel.Size = New System.Drawing.Size(57, 13)
        CampoIDLabel.TabIndex = 147
        CampoIDLabel.Text = "Campo ID:"
        '
        'NombreCampoLabel
        '
        NombreCampoLabel.AutoSize = True
        NombreCampoLabel.Location = New System.Drawing.Point(594, 289)
        NombreCampoLabel.Name = "NombreCampoLabel"
        NombreCampoLabel.Size = New System.Drawing.Size(83, 13)
        NombreCampoLabel.TabIndex = 148
        NombreCampoLabel.Text = "Nombre Campo:"
        '
        'BtnBuscarYPintar
        '
        Me.BtnBuscarYPintar.BackColor = System.Drawing.Color.White
        Me.BtnBuscarYPintar.Location = New System.Drawing.Point(5, 2)
        Me.BtnBuscarYPintar.Name = "BtnBuscarYPintar"
        Me.BtnBuscarYPintar.Size = New System.Drawing.Size(111, 44)
        Me.BtnBuscarYPintar.TabIndex = 90
        Me.BtnBuscarYPintar.Text = "Cargar Valores"
        Me.BtnBuscarYPintar.UseVisualStyleBackColor = False
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5})
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(927, 288)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(183, 71)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 91
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Enunciado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Requerimientos"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 180
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetAdministracion
        '
        'DataSetAdministracion
        '
        Me.DataSetAdministracion.DataSetName = "DataSetAdministracion"
        Me.DataSetAdministracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AllowUserToAddRows = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AutoGenerateColumns = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6})
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.DataSource = Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Location = New System.Drawing.Point(139, 3)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Name = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowHeadersVisible = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Size = New System.Drawing.Size(128, 155)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.TabIndex = 94
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre Plantilla"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataMember = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataSource = Me.DataSetAdministracion
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
        Me.TecnologiasDataGridView.Size = New System.Drawing.Size(130, 155)
        Me.TecnologiasDataGridView.TabIndex = 96
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NombreTecnologia"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre Tecnologia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 130
        '
        'TecnologiasBindingSource
        '
        Me.TecnologiasBindingSource.DataMember = "Tecnologias"
        Me.TecnologiasBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8})
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(1136, 8)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(152, 152)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 98
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NombreComponente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Componente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 142
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetAdministracion
        '
        'RequerimientoPlantillaIDTextBox
        '
        Me.RequerimientoPlantillaIDTextBox.Location = New System.Drawing.Point(1063, 236)
        Me.RequerimientoPlantillaIDTextBox.Name = "RequerimientoPlantillaIDTextBox"
        Me.RequerimientoPlantillaIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.RequerimientoPlantillaIDTextBox.TabIndex = 120
        '
        'ComponenteIDTextBox
        '
        Me.ComponenteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "ComponenteID", True))
        Me.ComponenteIDTextBox.Location = New System.Drawing.Point(1063, 204)
        Me.ComponenteIDTextBox.Name = "ComponenteIDTextBox"
        Me.ComponenteIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.ComponenteIDTextBox.TabIndex = 118
        '
        'PlantillaIDTextBox
        '
        Me.PlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "PlantillaID", True))
        Me.PlantillaIDTextBox.Location = New System.Drawing.Point(1063, 172)
        Me.PlantillaIDTextBox.Name = "PlantillaIDTextBox"
        Me.PlantillaIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.PlantillaIDTextBox.TabIndex = 116
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(1063, 86)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(47, 20)
        Me.ControlNulos.TabIndex = 114
        '
        'TecnologiaIDTextBox
        '
        Me.TecnologiaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "TecnologiaID", True))
        Me.TecnologiaIDTextBox.Location = New System.Drawing.Point(1063, 118)
        Me.TecnologiaIDTextBox.Name = "TecnologiaIDTextBox"
        Me.TecnologiaIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.TecnologiaIDTextBox.TabIndex = 113
        '
        'EnunciadoTextBox
        '
        Me.EnunciadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Enunciado", True))
        Me.EnunciadoTextBox.Location = New System.Drawing.Point(1063, 60)
        Me.EnunciadoTextBox.Name = "EnunciadoTextBox"
        Me.EnunciadoTextBox.Size = New System.Drawing.Size(47, 20)
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 592)
        Me.Panel1.TabIndex = 122
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 403)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(278, 187)
        Me.TabControl1.TabIndex = 124
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(270, 161)
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
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.DataSource = Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Name = "SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView"
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.RowHeadersVisible = False
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Size = New System.Drawing.Size(264, 155)
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.TabIndex = 124
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NombreTecnologia"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Tecnologia"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 137
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Plantilla"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 137
        '
        'SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource
        '
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource.DataMember = "SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO"
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource.DataSource = Me.DataSetAdministracion
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TecnologiasDataGridView)
        Me.TabPage2.Controls.Add(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(270, 161)
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
        Me.PanelAdministracion_.Location = New System.Drawing.Point(8, 3)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(278, 46)
        Me.PanelAdministracion_.TabIndex = 90
        '
        'Nuevo_Menu_Proyectos
        '
        Me.Nuevo_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_Proyectos.Image = CType(resources.GetObject("Nuevo_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_Proyectos.Location = New System.Drawing.Point(4, 3)
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
        Me.Cancelar_Menu_Proyectos.Location = New System.Drawing.Point(233, 3)
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
        Me.Eliminar_Menu_Proyectos.Location = New System.Drawing.Point(188, 3)
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
        Me.Editar_Menu_Proyectos.Location = New System.Drawing.Point(96, 3)
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
        Me.Actualizar_Menu_Proyectos.Location = New System.Drawing.Point(142, 3)
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
        Me.Guardar_Menu_Proyectos.Location = New System.Drawing.Point(50, 3)
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
        Me.DescripcionTextBox.Size = New System.Drawing.Size(278, 105)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DataSetAdministracion
        '
        'NombreProyectoTextBox
        '
        Me.NombreProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "NombreProyecto", True))
        Me.NombreProyectoTextBox.Location = New System.Drawing.Point(8, 68)
        Me.NombreProyectoTextBox.Multiline = True
        Me.NombreProyectoTextBox.Name = "NombreProyectoTextBox"
        Me.NombreProyectoTextBox.Size = New System.Drawing.Size(278, 50)
        Me.NombreProyectoTextBox.TabIndex = 2
        '
        'ProyectosDataGridView
        '
        Me.ProyectosDataGridView.AllowUserToAddRows = False
        Me.ProyectosDataGridView.AutoGenerateColumns = False
        Me.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10})
        Me.ProyectosDataGridView.DataSource = Me.ProyectosBindingSource
        Me.ProyectosDataGridView.Location = New System.Drawing.Point(8, 248)
        Me.ProyectosDataGridView.Name = "ProyectosDataGridView"
        Me.ProyectosDataGridView.RowHeadersVisible = False
        Me.ProyectosDataGridView.Size = New System.Drawing.Size(278, 149)
        Me.ProyectosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NombreProyecto"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nombre Proyecto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 274
        '
        'ProyectoIDTextBox
        '
        Me.ProyectoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "ProyectoID", True))
        Me.ProyectoIDTextBox.Location = New System.Drawing.Point(1063, 262)
        Me.ProyectoIDTextBox.Name = "ProyectoIDTextBox"
        Me.ProyectoIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.ProyectoIDTextBox.TabIndex = 123
        '
        'CodigoGeneradoTextBox
        '
        Me.CodigoGeneradoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "CodigoGenerado", True))
        Me.CodigoGeneradoTextBox.Location = New System.Drawing.Point(302, 22)
        Me.CodigoGeneradoTextBox.Multiline = True
        Me.CodigoGeneradoTextBox.Name = "CodigoGeneradoTextBox"
        Me.CodigoGeneradoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CodigoGeneradoTextBox.Size = New System.Drawing.Size(281, 404)
        Me.CodigoGeneradoTextBox.TabIndex = 91
        '
        'NombreTecnologiaTextBox
        '
        Me.NombreTecnologiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "NombreTecnologia", True))
        Me.NombreTecnologiaTextBox.Location = New System.Drawing.Point(1063, 34)
        Me.NombreTecnologiaTextBox.Name = "NombreTecnologiaTextBox"
        Me.NombreTecnologiaTextBox.Size = New System.Drawing.Size(47, 20)
        Me.NombreTecnologiaTextBox.TabIndex = 124
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
        'TecnologiaID_EliminaRelacion
        '
        Me.TecnologiaID_EliminaRelacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "TecnologiaID", True))
        Me.TecnologiaID_EliminaRelacion.Location = New System.Drawing.Point(1063, 144)
        Me.TecnologiaID_EliminaRelacion.Name = "TecnologiaID_EliminaRelacion"
        Me.TecnologiaID_EliminaRelacion.Size = New System.Drawing.Size(47, 20)
        Me.TecnologiaID_EliminaRelacion.TabIndex = 125
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.AllowUserToAddRows = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.AutoGenerateColumns = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14})
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.DataSource = Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Location = New System.Drawing.Point(591, 117)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Name = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.RowHeadersVisible = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Size = New System.Drawing.Size(281, 117)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.TabIndex = 126
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NombreTabla"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nombre Tabla"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 277
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource.DataMember = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataSetTablasYCampos
        '
        Me.DataSetTablasYCampos.DataSetName = "DataSetTablasYCampos"
        Me.DataSetTablasYCampos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequerimientoTextBox
        '
        Me.RequerimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Requerimiento", True))
        Me.RequerimientoTextBox.Location = New System.Drawing.Point(1222, 413)
        Me.RequerimientoTextBox.Name = "RequerimientoTextBox"
        Me.RequerimientoTextBox.Size = New System.Drawing.Size(66, 20)
        Me.RequerimientoTextBox.TabIndex = 127
        '
        'ValorRequerimientoTextBox
        '
        Me.ValorRequerimientoTextBox.Location = New System.Drawing.Point(1222, 439)
        Me.ValorRequerimientoTextBox.Name = "ValorRequerimientoTextBox"
        Me.ValorRequerimientoTextBox.Size = New System.Drawing.Size(66, 20)
        Me.ValorRequerimientoTextBox.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1114, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Valor Requerimiento"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(1168, 372)
        Me.CodigoTextBox.Multiline = True
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(120, 26)
        Me.CodigoTextBox.TabIndex = 130
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.GruposDeTiposDeDatosTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CamposDeTablas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter = Nothing
        Me.TableAdapterManager1.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_GruposDeTiposDeDatos_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_GruposDeTiposDeDatos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TiposDeCampos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TiposDeCampos_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TiposDeCampos_EDICION_INSERTARTableAdapter = Nothing
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
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource.DataMember = "SP_RegistroValorRequerimientos_SEGUN_ProyectoID"
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.AllowUserToAddRows = False
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.AutoGenerateColumns = False
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.DataSource = Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Location = New System.Drawing.Point(302, 486)
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Name = "SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView"
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.RowHeadersVisible = False
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Size = New System.Drawing.Size(281, 101)
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.TabIndex = 131
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Requerimiento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Requerimiento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 138
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ValorRequerimiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Valor Requerimiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 139
        '
        'BtnRemplazar
        '
        Me.BtnRemplazar.BackColor = System.Drawing.Color.White
        Me.BtnRemplazar.Image = CType(resources.GetObject("BtnRemplazar.Image"), System.Drawing.Image)
        Me.BtnRemplazar.Location = New System.Drawing.Point(225, 2)
        Me.BtnRemplazar.Name = "BtnRemplazar"
        Me.BtnRemplazar.Size = New System.Drawing.Size(49, 44)
        Me.BtnRemplazar.TabIndex = 132
        Me.BtnRemplazar.UseVisualStyleBackColor = False
        '
        'NombreComponenteTextBox
        '
        Me.NombreComponenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "NombreComponente", True))
        Me.NombreComponenteTextBox.Location = New System.Drawing.Point(1168, 332)
        Me.NombreComponenteTextBox.Name = "NombreComponenteTextBox"
        Me.NombreComponenteTextBox.Size = New System.Drawing.Size(120, 20)
        Me.NombreComponenteTextBox.TabIndex = 133
        '
        'NombreTecnologiaTextBox1
        '
        Me.NombreTecnologiaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "NombreTecnologia", True))
        Me.NombreTecnologiaTextBox1.Location = New System.Drawing.Point(1168, 289)
        Me.NombreTecnologiaTextBox1.Name = "NombreTecnologiaTextBox1"
        Me.NombreTecnologiaTextBox1.Size = New System.Drawing.Size(120, 20)
        Me.NombreTecnologiaTextBox1.TabIndex = 134
        '
        'RequerimientoTextBox1
        '
        Me.RequerimientoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "Requerimiento", True))
        Me.RequerimientoTextBox1.Location = New System.Drawing.Point(1168, 205)
        Me.RequerimientoTextBox1.Name = "RequerimientoTextBox1"
        Me.RequerimientoTextBox1.Size = New System.Drawing.Size(120, 20)
        Me.RequerimientoTextBox1.TabIndex = 135
        '
        'ValorRequerimientoTextBox1
        '
        Me.ValorRequerimientoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "ValorRequerimiento", True))
        Me.ValorRequerimientoTextBox1.Location = New System.Drawing.Point(1168, 244)
        Me.ValorRequerimientoTextBox1.Name = "ValorRequerimientoTextBox1"
        Me.ValorRequerimientoTextBox1.Size = New System.Drawing.Size(120, 20)
        Me.ValorRequerimientoTextBox1.TabIndex = 136
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Nuevo_Menu_TablasDeProyecto)
        Me.Panel2.Controls.Add(Me.Cancelar_Menu_TablasDeProyecto)
        Me.Panel2.Controls.Add(Me.Eliminar_Menu_TablasDeProyecto)
        Me.Panel2.Controls.Add(Me.Editar_Menu_TablasDeProyecto)
        Me.Panel2.Controls.Add(Me.Actualizar_Menu_TablasDeProyecto)
        Me.Panel2.Controls.Add(Me.Guardar_Menu_TablasDeProyecto)
        Me.Panel2.Location = New System.Drawing.Point(591, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 46)
        Me.Panel2.TabIndex = 138
        '
        'Nuevo_Menu_TablasDeProyecto
        '
        Me.Nuevo_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Nuevo_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_TablasDeProyecto.Location = New System.Drawing.Point(5, 3)
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
        Me.Cancelar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(234, 3)
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
        Me.Eliminar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(189, 3)
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
        Me.Editar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(97, 3)
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
        Me.Actualizar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(143, 3)
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
        Me.Guardar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(51, 3)
        Me.Guardar_Menu_TablasDeProyecto.Name = "Guardar_Menu_TablasDeProyecto"
        Me.Guardar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_TablasDeProyecto.TabIndex = 71
        Me.Guardar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'NombreTablaTextBox
        '
        Me.NombreTablaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, "NombreTabla", True))
        Me.NombreTablaTextBox.Location = New System.Drawing.Point(591, 91)
        Me.NombreTablaTextBox.Name = "NombreTablaTextBox"
        Me.NombreTablaTextBox.Size = New System.Drawing.Size(281, 20)
        Me.NombreTablaTextBox.TabIndex = 139
        '
        'TablaIDTextBox
        '
        Me.TablaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, "TablaID", True))
        Me.TablaIDTextBox.Location = New System.Drawing.Point(1062, 8)
        Me.TablaIDTextBox.Name = "TablaIDTextBox"
        Me.TablaIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.TablaIDTextBox.TabIndex = 140
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
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Nuevo_Menu_CamposDeTablas)
        Me.Panel3.Controls.Add(Me.Cancelar_Menu_CamposDeTablas)
        Me.Panel3.Controls.Add(Me.Eliminar_Menu_CamposDeTablas)
        Me.Panel3.Controls.Add(Me.Editar_Menu_CamposDeTablas)
        Me.Panel3.Controls.Add(Me.Actualizar_Menu_CamposDeTablas)
        Me.Panel3.Controls.Add(Me.Guardar_Menu_CamposDeTablas)
        Me.Panel3.Location = New System.Drawing.Point(591, 240)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(281, 46)
        Me.Panel3.TabIndex = 141
        '
        'Nuevo_Menu_CamposDeTablas
        '
        Me.Nuevo_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_CamposDeTablas.Image = CType(resources.GetObject("Nuevo_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_CamposDeTablas.Location = New System.Drawing.Point(5, 3)
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
        Me.Cancelar_Menu_CamposDeTablas.Location = New System.Drawing.Point(234, 3)
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
        Me.Eliminar_Menu_CamposDeTablas.Location = New System.Drawing.Point(189, 3)
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
        Me.Editar_Menu_CamposDeTablas.Location = New System.Drawing.Point(97, 3)
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
        Me.Actualizar_Menu_CamposDeTablas.Location = New System.Drawing.Point(143, 3)
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
        Me.Guardar_Menu_CamposDeTablas.Location = New System.Drawing.Point(51, 3)
        Me.Guardar_Menu_CamposDeTablas.Name = "Guardar_Menu_CamposDeTablas"
        Me.Guardar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_CamposDeTablas.TabIndex = 71
        Me.Guardar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnBuscarYPintar)
        Me.Panel4.Controls.Add(Me.BtnRemplazar)
        Me.Panel4.Location = New System.Drawing.Point(302, 432)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(281, 50)
        Me.Panel4.TabIndex = 142
        '
        'CboTiposDeCampo
        '
        Me.CboTiposDeCampo.DataSource = Me.SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource
        Me.CboTiposDeCampo.DisplayMember = "NombreTipo"
        Me.CboTiposDeCampo.FormattingEnabled = True
        Me.CboTiposDeCampo.Location = New System.Drawing.Point(1136, 163)
        Me.CboTiposDeCampo.Name = "CboTiposDeCampo"
        Me.CboTiposDeCampo.Size = New System.Drawing.Size(152, 21)
        Me.CboTiposDeCampo.TabIndex = 143
        Me.CboTiposDeCampo.ValueMember = "NombreTipo"
        '
        'SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource
        '
        Me.SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource.DataMember = "SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposID"
        Me.SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter
        '
        Me.SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter.ClearBeforeFill = True
        '
        'TipoCampoIDTextBox
        '
        Me.TipoCampoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "GrupoTiposID", True))
        Me.TipoCampoIDTextBox.Location = New System.Drawing.Point(1240, 500)
        Me.TipoCampoIDTextBox.Name = "TipoCampoIDTextBox"
        Me.TipoCampoIDTextBox.Size = New System.Drawing.Size(48, 20)
        Me.TipoCampoIDTextBox.TabIndex = 145
        '
        'GrupoTiposIDTextBox
        '
        Me.GrupoTiposIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "GrupoTiposID", True))
        Me.GrupoTiposIDTextBox.Location = New System.Drawing.Point(1240, 526)
        Me.GrupoTiposIDTextBox.Name = "GrupoTiposIDTextBox"
        Me.GrupoTiposIDTextBox.Size = New System.Drawing.Size(48, 20)
        Me.GrupoTiposIDTextBox.TabIndex = 146
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource.DataMember = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.AllowUserToAddRows = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.AutoGenerateColumns = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9})
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.DataSource = Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Location = New System.Drawing.Point(591, 362)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Name = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.RowHeadersVisible = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Size = New System.Drawing.Size(281, 225)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.TabIndex = 147
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NombreCampo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nombre Campo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 277
        '
        'CampoIDTextBox
        '
        Me.CampoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "CampoID", True))
        Me.CampoIDTextBox.Location = New System.Drawing.Point(1240, 474)
        Me.CampoIDTextBox.Name = "CampoIDTextBox"
        Me.CampoIDTextBox.Size = New System.Drawing.Size(48, 20)
        Me.CampoIDTextBox.TabIndex = 148
        '
        'NombreCampoTextBox
        '
        Me.NombreCampoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "NombreCampo", True))
        Me.NombreCampoTextBox.Location = New System.Drawing.Point(591, 305)
        Me.NombreCampoTextBox.Name = "NombreCampoTextBox"
        Me.NombreCampoTextBox.Size = New System.Drawing.Size(281, 20)
        Me.NombreCampoTextBox.TabIndex = 149
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
        'Cbo_TipoDato
        '
        Me.Cbo_TipoDato.FormattingEnabled = True
        Me.Cbo_TipoDato.Items.AddRange(New Object() {"boolean", "Date", "numeric", "string"})
        Me.Cbo_TipoDato.Location = New System.Drawing.Point(669, 335)
        Me.Cbo_TipoDato.Name = "Cbo_TipoDato"
        Me.Cbo_TipoDato.Size = New System.Drawing.Size(203, 21)
        Me.Cbo_TipoDato.Sorted = True
        Me.Cbo_TipoDato.TabIndex = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(594, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Tipo de Dato"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(1203, 555)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 151
        TipoLabel.Text = "Tipo:"
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(1240, 552)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(48, 20)
        Me.TipoTextBox.TabIndex = 152
        '
        'FrmReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 592)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cbo_TipoDato)
        Me.Controls.Add(NombreCampoLabel)
        Me.Controls.Add(Me.NombreCampoTextBox)
        Me.Controls.Add(CampoIDLabel)
        Me.Controls.Add(Me.CampoIDTextBox)
        Me.Controls.Add(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView)
        Me.Controls.Add(GrupoTiposIDLabel)
        Me.Controls.Add(Me.GrupoTiposIDTextBox)
        Me.Controls.Add(TipoCampoIDLabel)
        Me.Controls.Add(Me.TipoCampoIDTextBox)
        Me.Controls.Add(Me.CboTiposDeCampo)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CodigoGeneradoTextBox)
        Me.Controls.Add(TablaIDLabel)
        Me.Controls.Add(Me.TablaIDTextBox)
        Me.Controls.Add(NombreTablaLabel)
        Me.Controls.Add(Me.NombreTablaTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(ValorRequerimientoLabel)
        Me.Controls.Add(Me.ValorRequerimientoTextBox1)
        Me.Controls.Add(RequerimientoLabel1)
        Me.Controls.Add(Me.RequerimientoTextBox1)
        Me.Controls.Add(NombreTecnologiaLabel1)
        Me.Controls.Add(Me.NombreTecnologiaTextBox1)
        Me.Controls.Add(NombreComponenteLabel)
        Me.Controls.Add(Me.NombreComponenteTextBox)
        Me.Controls.Add(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ValorRequerimientoTextBox)
        Me.Controls.Add(RequerimientoLabel)
        Me.Controls.Add(Me.RequerimientoTextBox)
        Me.Controls.Add(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView)
        Me.Controls.Add(TecnologiaIDLabel1)
        Me.Controls.Add(Me.TecnologiaID_EliminaRelacion)
        Me.Controls.Add(NombreTecnologiaLabel)
        Me.Controls.Add(Me.NombreTecnologiaTextBox)
        Me.Controls.Add(CodigoGeneradoLabel)
        Me.Controls.Add(ProyectoIDLabel)
        Me.Controls.Add(Me.ProyectoIDTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(EnunciadoLabel)
        Me.Controls.Add(Me.EnunciadoTextBox)
        Me.Controls.Add(RequerimientoPlantillaIDLabel)
        Me.Controls.Add(Me.RequerimientoPlantillaIDTextBox)
        Me.Controls.Add(ComponenteIDLabel)
        Me.Controls.Add(Me.ComponenteIDTextBox)
        Me.Controls.Add(PlantillaIDLabel)
        Me.Controls.Add(Me.PlantillaIDTextBox)
        Me.Controls.Add(Me.ControlNulos)
        Me.Controls.Add(TecnologiaIDLabel)
        Me.Controls.Add(Me.TecnologiaIDTextBox)
        Me.Controls.Add(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.Controls.Add(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.Name = "FrmReplace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.PanelAdministracion_.ResumeLayout(False)
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Proyectos_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Proyectos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELIMINA_SEGUN_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuscarYPintar As Button
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
    Friend WithEvents RequerimientoPlantillaIDTextBox As TextBox
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
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents CodigoGeneradoTextBox As TextBox
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
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter
    Friend WithEvents NombreTecnologiaTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
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
    Friend WithEvents ValorRequerimientoTextBox As TextBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents NombreTablaTextBox As TextBox
    Friend WithEvents TablaIDTextBox As TextBox
    Friend WithEvents SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_TablasDeProyecto_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_TablasDeProyecto_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Nuevo_Menu_CamposDeTablas As Button
    Friend WithEvents Cancelar_Menu_CamposDeTablas As Button
    Friend WithEvents Eliminar_Menu_CamposDeTablas As Button
    Friend WithEvents Editar_Menu_CamposDeTablas As Button
    Friend WithEvents Actualizar_Menu_CamposDeTablas As Button
    Friend WithEvents Guardar_Menu_CamposDeTablas As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CboTiposDeCampo As ComboBox
    Friend WithEvents SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource As BindingSource
    Friend WithEvents SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_TiposDeCampos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter
    Friend WithEvents TipoCampoIDTextBox As TextBox
    Friend WithEvents GrupoTiposIDTextBox As TextBox
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
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
End Class
