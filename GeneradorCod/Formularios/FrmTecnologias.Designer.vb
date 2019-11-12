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
        Dim PlantillaIDLabel As System.Windows.Forms.Label
        Dim NombreComponenteLabel As System.Windows.Forms.Label
        Dim ComponenteIDLabel As System.Windows.Forms.Label
        Dim RequerimientoLabel As System.Windows.Forms.Label
        Dim OrdenDePeticionLabel As System.Windows.Forms.Label
        Dim EnunciadoLabel As System.Windows.Forms.Label
        Dim RequerimientoPlantillaIDLabel As System.Windows.Forms.Label
        Dim NombreGrupoTipoDeDatoLabel As System.Windows.Forms.Label
        Dim GrupoTiposIDLabel As System.Windows.Forms.Label
        Dim NombreGrupoTipoDeDatoLabel1 As System.Windows.Forms.Label
        Dim GrupoTiposIDLabel1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTecnologias))
        Me.TecnologiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cbo_GruposDeCampos = New System.Windows.Forms.ComboBox()
        Me.GruposDeTiposDeDatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTablasYCampos = New GeneradorCod.DataSetTablasYCampos()
        Me.NombrePlantillaTextBox = New System.Windows.Forms.TextBox()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.Editar_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Plantillas = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.Nuevo_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Editar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.NombreComponenteTextBox = New System.Windows.Forms.TextBox()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.EnunciadoTextBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.Editar_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
        Me.Guardar_Menu_RequerimientosPlantillas = New System.Windows.Forms.Button()
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
        Me.RequerimientoPlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrupoTiposIDTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnGuardarCodigo = New System.Windows.Forms.Button()
        Me.BtnSubirRemplazado = New System.Windows.Forms.Button()
        Me.BtnLimpiarRemplazar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.RBPermitirEspacios = New System.Windows.Forms.RadioButton()
        Me.BtnRemplazar = New System.Windows.Forms.Button()
        Me.BtnBajarFuente = New System.Windows.Forms.Button()
        Me.BtnSubirFuente = New System.Windows.Forms.Button()
        Me.ContenidoComponenteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BtnBuscarYPintar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_GruposDeTiposDeDatos = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_GruposDeTiposDeDatos = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_GruposDeTiposDeDatos = New System.Windows.Forms.Button()
        Me.Editar_Menu_GruposDeTiposDeDatos = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_GruposDeTiposDeDatos = New System.Windows.Forms.Button()
        Me.Guardar_Menu_GruposDeTiposDeDatos = New System.Windows.Forms.Button()
        Me.NombreGrupoTipoDeDatoTextBox = New System.Windows.Forms.TextBox()
        Me.GruposDeTiposDeDatosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GruposDeTiposDeDatosTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.GruposDeTiposDeDatosTableAdapter()
        Me.TableAdapterManager1 = New GeneradorCod.DataSetTablasYCamposTableAdapters.TableAdapterManager()
        Me.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARTableAdapter()
        Me.SP_GruposDeTiposDeDatos_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_GruposDeTiposDeDatos_EDICION_ELIMINARTableAdapter()
        Me.SP_GruposDeTiposDeDatos_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_GruposDeTiposDeDatos_EDICION_INSERTARTableAdapter()
        Me.GrupoTiposIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_GruposDeTiposDeDatos_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_GruposDeTiposDeDatos_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter()
        Me.NombreGrupoTipoDeDatoTextBox1 = New System.Windows.Forms.TextBox()
        Me.GrupoTiposIDTextBox2 = New System.Windows.Forms.TextBox()
        NombreTecnologiaLabel = New System.Windows.Forms.Label()
        TecnologiaIDLabel = New System.Windows.Forms.Label()
        NombrePlantillaLabel = New System.Windows.Forms.Label()
        PlantillaIDLabel = New System.Windows.Forms.Label()
        NombreComponenteLabel = New System.Windows.Forms.Label()
        ComponenteIDLabel = New System.Windows.Forms.Label()
        RequerimientoLabel = New System.Windows.Forms.Label()
        OrdenDePeticionLabel = New System.Windows.Forms.Label()
        EnunciadoLabel = New System.Windows.Forms.Label()
        RequerimientoPlantillaIDLabel = New System.Windows.Forms.Label()
        NombreGrupoTipoDeDatoLabel = New System.Windows.Forms.Label()
        GrupoTiposIDLabel = New System.Windows.Forms.Label()
        NombreGrupoTipoDeDatoLabel1 = New System.Windows.Forms.Label()
        GrupoTiposIDLabel1 = New System.Windows.Forms.Label()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdministracion_.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GruposDeTiposDeDatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
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
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GruposDeTiposDeDatosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_GruposDeTiposDeDatos_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_GruposDeTiposDeDatos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        TecnologiaIDLabel.AutoSize = True
        TecnologiaIDLabel.Location = New System.Drawing.Point(771, 359)
        TecnologiaIDLabel.Name = "TecnologiaIDLabel"
        TecnologiaIDLabel.Size = New System.Drawing.Size(94, 18)
        TecnologiaIDLabel.TabIndex = 90
        TecnologiaIDLabel.Text = "Tecnologia ID:"
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
        'PlantillaIDLabel
        '
        PlantillaIDLabel.AutoSize = True
        PlantillaIDLabel.Location = New System.Drawing.Point(789, 391)
        PlantillaIDLabel.Name = "PlantillaIDLabel"
        PlantillaIDLabel.Size = New System.Drawing.Size(76, 18)
        PlantillaIDLabel.TabIndex = 93
        PlantillaIDLabel.Text = "Plantilla ID:"
        '
        'NombreComponenteLabel
        '
        NombreComponenteLabel.AutoSize = True
        NombreComponenteLabel.Location = New System.Drawing.Point(27, 86)
        NombreComponenteLabel.Name = "NombreComponenteLabel"
        NombreComponenteLabel.Size = New System.Drawing.Size(87, 18)
        NombreComponenteLabel.TabIndex = 96
        NombreComponenteLabel.Text = "Componente"
        '
        'ComponenteIDLabel
        '
        ComponenteIDLabel.AutoSize = True
        ComponenteIDLabel.Location = New System.Drawing.Point(758, 423)
        ComponenteIDLabel.Name = "ComponenteIDLabel"
        ComponenteIDLabel.Size = New System.Drawing.Size(107, 18)
        ComponenteIDLabel.TabIndex = 97
        ComponenteIDLabel.Text = "Componente ID:"
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
        OrdenDePeticionLabel.Location = New System.Drawing.Point(554, 130)
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
        'RequerimientoPlantillaIDLabel
        '
        RequerimientoPlantillaIDLabel.AutoSize = True
        RequerimientoPlantillaIDLabel.Location = New System.Drawing.Point(696, 455)
        RequerimientoPlantillaIDLabel.Name = "RequerimientoPlantillaIDLabel"
        RequerimientoPlantillaIDLabel.Size = New System.Drawing.Size(169, 18)
        RequerimientoPlantillaIDLabel.TabIndex = 110
        RequerimientoPlantillaIDLabel.Text = "Requerimiento Plantilla ID:"
        '
        'NombreGrupoTipoDeDatoLabel
        '
        NombreGrupoTipoDeDatoLabel.AutoSize = True
        NombreGrupoTipoDeDatoLabel.Location = New System.Drawing.Point(5, 56)
        NombreGrupoTipoDeDatoLabel.Name = "NombreGrupoTipoDeDatoLabel"
        NombreGrupoTipoDeDatoLabel.Size = New System.Drawing.Size(184, 18)
        NombreGrupoTipoDeDatoLabel.TabIndex = 101
        NombreGrupoTipoDeDatoLabel.Text = "Nombre Grupo Tipo De Dato:"
        '
        'GrupoTiposIDLabel
        '
        GrupoTiposIDLabel.AutoSize = True
        GrupoTiposIDLabel.Location = New System.Drawing.Point(763, 487)
        GrupoTiposIDLabel.Name = "GrupoTiposIDLabel"
        GrupoTiposIDLabel.Size = New System.Drawing.Size(102, 18)
        GrupoTiposIDLabel.TabIndex = 116
        GrupoTiposIDLabel.Text = "Grupo Tipos ID:"
        '
        'NombreGrupoTipoDeDatoLabel1
        '
        NombreGrupoTipoDeDatoLabel1.AutoSize = True
        NombreGrupoTipoDeDatoLabel1.Location = New System.Drawing.Point(681, 519)
        NombreGrupoTipoDeDatoLabel1.Name = "NombreGrupoTipoDeDatoLabel1"
        NombreGrupoTipoDeDatoLabel1.Size = New System.Drawing.Size(184, 18)
        NombreGrupoTipoDeDatoLabel1.TabIndex = 118
        NombreGrupoTipoDeDatoLabel1.Text = "Nombre Grupo Tipo De Dato:"
        '
        'GrupoTiposIDLabel1
        '
        GrupoTiposIDLabel1.AutoSize = True
        GrupoTiposIDLabel1.Location = New System.Drawing.Point(763, 263)
        GrupoTiposIDLabel1.Name = "GrupoTiposIDLabel1"
        GrupoTiposIDLabel1.Size = New System.Drawing.Size(102, 18)
        GrupoTiposIDLabel1.TabIndex = 119
        GrupoTiposIDLabel1.Text = "Grupo Tipos ID:"
        '
        'TecnologiasDataGridView
        '
        Me.TecnologiasDataGridView.AllowUserToAddRows = False
        Me.TecnologiasDataGridView.AutoGenerateColumns = False
        Me.TecnologiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TecnologiasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.TecnologiasDataGridView.DataSource = Me.TecnologiasBindingSource
        Me.TecnologiasDataGridView.Location = New System.Drawing.Point(5, 103)
        Me.TecnologiasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TecnologiasDataGridView.Name = "TecnologiasDataGridView"
        Me.TecnologiasDataGridView.RowHeadersVisible = False
        Me.TecnologiasDataGridView.Size = New System.Drawing.Size(281, 108)
        Me.TecnologiasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreTecnologia"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Tecnologia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 277
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
        Me.NombreTecnologiaTextBox.Location = New System.Drawing.Point(5, 75)
        Me.NombreTecnologiaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreTecnologiaTextBox.Name = "NombreTecnologiaTextBox"
        Me.NombreTecnologiaTextBox.Size = New System.Drawing.Size(281, 22)
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
        Me.PanelAdministracion_.Location = New System.Drawing.Point(6, 10)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(278, 46)
        Me.PanelAdministracion_.TabIndex = 90
        '
        'Nuevo_Menu_Tecnologias
        '
        Me.Nuevo_Menu_Tecnologias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_Tecnologias.Image = CType(resources.GetObject("Nuevo_Menu_Tecnologias.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_Tecnologias.Location = New System.Drawing.Point(4, 3)
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
        Me.Cancelar_Menu_Tecnologias.Location = New System.Drawing.Point(233, 3)
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
        Me.Eliminar_Menu_Tecnologias.Location = New System.Drawing.Point(188, 3)
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
        Me.Editar_Menu_Tecnologias.Location = New System.Drawing.Point(96, 3)
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
        Me.Actualizar_Menu_Tecnologias.Location = New System.Drawing.Point(142, 3)
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
        Me.Guardar_Menu_Tecnologias.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_Tecnologias.Name = "Guardar_Menu_Tecnologias"
        Me.Guardar_Menu_Tecnologias.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_Tecnologias.TabIndex = 71
        Me.Guardar_Menu_Tecnologias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_Tecnologias.UseVisualStyleBackColor = True
        '
        'TecnologiaIDTextBox
        '
        Me.TecnologiaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "TecnologiaID", True))
        Me.TecnologiaIDTextBox.Location = New System.Drawing.Point(871, 356)
        Me.TecnologiaIDTextBox.Name = "TecnologiaIDTextBox"
        Me.TecnologiaIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TecnologiaIDTextBox.TabIndex = 91
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(871, 292)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(100, 26)
        Me.ControlNulos.TabIndex = 92
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 603)
        Me.Panel1.TabIndex = 93
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Cbo_GruposDeCampos)
        Me.Panel3.Controls.Add(NombrePlantillaLabel)
        Me.Panel3.Controls.Add(Me.NombrePlantillaTextBox)
        Me.Panel3.Controls.Add(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 219)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(305, 380)
        Me.Panel3.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 14)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Grupo de Campos Para Esta Plantilla"
        '
        'Cbo_GruposDeCampos
        '
        Me.Cbo_GruposDeCampos.DataSource = Me.GruposDeTiposDeDatosBindingSource
        Me.Cbo_GruposDeCampos.DisplayMember = "NombreGrupoTipoDeDato"
        Me.Cbo_GruposDeCampos.FormattingEnabled = True
        Me.Cbo_GruposDeCampos.Location = New System.Drawing.Point(6, 112)
        Me.Cbo_GruposDeCampos.Name = "Cbo_GruposDeCampos"
        Me.Cbo_GruposDeCampos.Size = New System.Drawing.Size(278, 22)
        Me.Cbo_GruposDeCampos.TabIndex = 115
        Me.Cbo_GruposDeCampos.ValueMember = "NombreGrupoTipoDeDato"
        '
        'GruposDeTiposDeDatosBindingSource
        '
        Me.GruposDeTiposDeDatosBindingSource.DataMember = "GruposDeTiposDeDatos"
        Me.GruposDeTiposDeDatosBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataSetTablasYCampos
        '
        Me.DataSetTablasYCampos.DataSetName = "DataSetTablasYCampos"
        Me.DataSetTablasYCampos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombrePlantillaTextBox
        '
        Me.NombrePlantillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "NombrePlantilla", True))
        Me.NombrePlantillaTextBox.Location = New System.Drawing.Point(6, 69)
        Me.NombrePlantillaTextBox.Name = "NombrePlantillaTextBox"
        Me.NombrePlantillaTextBox.Size = New System.Drawing.Size(278, 22)
        Me.NombrePlantillaTextBox.TabIndex = 95
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataMember = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AllowUserToAddRows = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AutoGenerateColumns = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4})
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.DataSource = Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Location = New System.Drawing.Point(6, 140)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Name = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowHeadersVisible = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Size = New System.Drawing.Size(278, 241)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.TabIndex = 94
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre Plantilla"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 277
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Nuevo_Menu_Plantillas)
        Me.Panel4.Controls.Add(Me.Cancelar_Menu_Plantillas)
        Me.Panel4.Controls.Add(Me.Eliminar_Menu_Plantillas)
        Me.Panel4.Controls.Add(Me.Editar_Menu_Plantillas)
        Me.Panel4.Controls.Add(Me.Actualizar_Menu_Plantillas)
        Me.Panel4.Controls.Add(Me.Guardar_Menu_Plantillas)
        Me.Panel4.Location = New System.Drawing.Point(6, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(278, 46)
        Me.Panel4.TabIndex = 89
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.PanelAdministracion_)
        Me.Panel2.Controls.Add(NombreTecnologiaLabel)
        Me.Panel2.Controls.Add(Me.TecnologiasDataGridView)
        Me.Panel2.Controls.Add(Me.NombreTecnologiaTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 219)
        Me.Panel2.TabIndex = 94
        '
        'PlantillaIDTextBox
        '
        Me.PlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "PlantillaID", True))
        Me.PlantillaIDTextBox.Location = New System.Drawing.Point(871, 388)
        Me.PlantillaIDTextBox.Name = "PlantillaIDTextBox"
        Me.PlantillaIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.PlantillaIDTextBox.TabIndex = 94
        '
        'Nuevo_Menu_Componentes
        '
        Me.Nuevo_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_Componentes.Image = CType(resources.GetObject("Nuevo_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_Componentes.Location = New System.Drawing.Point(2, 5)
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
        Me.Cancelar_Menu_Componentes.Location = New System.Drawing.Point(100, 44)
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
        Me.Eliminar_Menu_Componentes.Location = New System.Drawing.Point(52, 44)
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
        Me.Editar_Menu_Componentes.Location = New System.Drawing.Point(2, 44)
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
        Me.Actualizar_Menu_Componentes.Location = New System.Drawing.Point(100, 5)
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
        Me.Guardar_Menu_Componentes.Location = New System.Drawing.Point(52, 5)
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
        Me.Panel6.Controls.Add(Me.NombreComponenteTextBox)
        Me.Panel6.Controls.Add(NombreComponenteLabel)
        Me.Panel6.Controls.Add(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.Panel6.Controls.Add(Me.Cancelar_Menu_Componentes)
        Me.Panel6.Controls.Add(Me.Nuevo_Menu_Componentes)
        Me.Panel6.Controls.Add(Me.Eliminar_Menu_Componentes)
        Me.Panel6.Controls.Add(Me.Guardar_Menu_Componentes)
        Me.Panel6.Controls.Add(Me.Actualizar_Menu_Componentes)
        Me.Panel6.Controls.Add(Me.Editar_Menu_Componentes)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(294, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(146, 603)
        Me.Panel6.TabIndex = 96
        '
        'NombreComponenteTextBox
        '
        Me.NombreComponenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "NombreComponente", True))
        Me.NombreComponenteTextBox.Location = New System.Drawing.Point(3, 105)
        Me.NombreComponenteTextBox.Multiline = True
        Me.NombreComponenteTextBox.Name = "NombreComponenteTextBox"
        Me.NombreComponenteTextBox.Size = New System.Drawing.Size(139, 146)
        Me.NombreComponenteTextBox.TabIndex = 97
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5})
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(0, 259)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(144, 342)
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
        Me.ComponenteIDTextBox.Location = New System.Drawing.Point(871, 420)
        Me.ComponenteIDTextBox.Name = "ComponenteIDTextBox"
        Me.ComponenteIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ComponenteIDTextBox.TabIndex = 98
        '
        'TxtBuscado
        '
        Me.TxtBuscado.Location = New System.Drawing.Point(6, 24)
        Me.TxtBuscado.Name = "TxtBuscado"
        Me.TxtBuscado.Size = New System.Drawing.Size(257, 26)
        Me.TxtBuscado.TabIndex = 104
        '
        'TxtRemplazarPor
        '
        Me.TxtRemplazarPor.Location = New System.Drawing.Point(6, 79)
        Me.TxtRemplazarPor.Name = "TxtRemplazarPor"
        Me.TxtRemplazarPor.Size = New System.Drawing.Size(257, 26)
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
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(594, 391)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 107
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Requerimiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Requerimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 590
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
        Me.RequerimientoTextBox.Size = New System.Drawing.Size(548, 26)
        Me.RequerimientoTextBox.TabIndex = 107
        '
        'OrdenDePeticionTextBox
        '
        Me.OrdenDePeticionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, "OrdenDePeticion", True))
        Me.OrdenDePeticionTextBox.Location = New System.Drawing.Point(560, 150)
        Me.OrdenDePeticionTextBox.Name = "OrdenDePeticionTextBox"
        Me.OrdenDePeticionTextBox.Size = New System.Drawing.Size(40, 26)
        Me.OrdenDePeticionTextBox.TabIndex = 108
        '
        'EnunciadoTextBox
        '
        Me.EnunciadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, "Enunciado", True))
        Me.EnunciadoTextBox.Location = New System.Drawing.Point(6, 71)
        Me.EnunciadoTextBox.Multiline = True
        Me.EnunciadoTextBox.Name = "EnunciadoTextBox"
        Me.EnunciadoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EnunciadoTextBox.Size = New System.Drawing.Size(594, 48)
        Me.EnunciadoTextBox.TabIndex = 109
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Nuevo_Menu_RequerimientosPlantillas)
        Me.Panel5.Controls.Add(Me.Cancelar_Menu_RequerimientosPlantillas)
        Me.Panel5.Controls.Add(Me.Eliminar_Menu_RequerimientosPlantillas)
        Me.Panel5.Controls.Add(Me.Editar_Menu_RequerimientosPlantillas)
        Me.Panel5.Controls.Add(Me.Actualizar_Menu_RequerimientosPlantillas)
        Me.Panel5.Controls.Add(Me.Guardar_Menu_RequerimientosPlantillas)
        Me.Panel5.Location = New System.Drawing.Point(6, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(594, 41)
        Me.Panel5.TabIndex = 110
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
        'TecnologiasTableAdapter
        '
        Me.TecnologiasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager.TecnologiasTableAdapter = Me.TecnologiasTableAdapter
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
        'RequerimientoPlantillaIDTextBox
        '
        Me.RequerimientoPlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, "RequerimientoPlantillaID", True))
        Me.RequerimientoPlantillaIDTextBox.Location = New System.Drawing.Point(871, 452)
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
        'GrupoTiposIDTextBox
        '
        Me.GrupoTiposIDTextBox.Location = New System.Drawing.Point(871, 324)
        Me.GrupoTiposIDTextBox.Name = "GrupoTiposIDTextBox"
        Me.GrupoTiposIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.GrupoTiposIDTextBox.TabIndex = 115
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(444, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(610, 607)
        Me.TabControl1.TabIndex = 116
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnGuardarCodigo)
        Me.TabPage1.Controls.Add(Me.BtnSubirRemplazado)
        Me.TabPage1.Controls.Add(Me.BtnLimpiarRemplazar)
        Me.TabPage1.Controls.Add(Me.BtnLimpiar)
        Me.TabPage1.Controls.Add(Me.RBPermitirEspacios)
        Me.TabPage1.Controls.Add(Me.BtnRemplazar)
        Me.TabPage1.Controls.Add(Me.BtnBajarFuente)
        Me.TabPage1.Controls.Add(Me.BtnSubirFuente)
        Me.TabPage1.Controls.Add(Me.ContenidoComponenteRichTextBox)
        Me.TabPage1.Controls.Add(Me.BtnBuscarYPintar)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtBuscado)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtRemplazarPor)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(602, 576)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Busqueda y Remplazo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnGuardarCodigo
        '
        Me.BtnGuardarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardarCodigo.Image = CType(resources.GetObject("BtnGuardarCodigo.Image"), System.Drawing.Image)
        Me.BtnGuardarCodigo.Location = New System.Drawing.Point(547, 6)
        Me.BtnGuardarCodigo.Name = "BtnGuardarCodigo"
        Me.BtnGuardarCodigo.Size = New System.Drawing.Size(49, 44)
        Me.BtnGuardarCodigo.TabIndex = 123
        Me.BtnGuardarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardarCodigo.UseVisualStyleBackColor = True
        '
        'BtnSubirRemplazado
        '
        Me.BtnSubirRemplazado.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnSubirRemplazado.Location = New System.Drawing.Point(288, 27)
        Me.BtnSubirRemplazado.Name = "BtnSubirRemplazado"
        Me.BtnSubirRemplazado.Size = New System.Drawing.Size(18, 23)
        Me.BtnSubirRemplazado.TabIndex = 122
        Me.BtnSubirRemplazado.UseVisualStyleBackColor = False
        '
        'BtnLimpiarRemplazar
        '
        Me.BtnLimpiarRemplazar.BackColor = System.Drawing.Color.Red
        Me.BtnLimpiarRemplazar.Location = New System.Drawing.Point(269, 81)
        Me.BtnLimpiarRemplazar.Name = "BtnLimpiarRemplazar"
        Me.BtnLimpiarRemplazar.Size = New System.Drawing.Size(18, 23)
        Me.BtnLimpiarRemplazar.TabIndex = 121
        Me.BtnLimpiarRemplazar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Red
        Me.BtnLimpiar.Location = New System.Drawing.Point(269, 27)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(18, 23)
        Me.BtnLimpiar.TabIndex = 120
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'RBPermitirEspacios
        '
        Me.RBPermitirEspacios.AutoSize = True
        Me.RBPermitirEspacios.Location = New System.Drawing.Point(295, 86)
        Me.RBPermitirEspacios.Name = "RBPermitirEspacios"
        Me.RBPermitirEspacios.Size = New System.Drawing.Size(14, 13)
        Me.RBPermitirEspacios.TabIndex = 119
        Me.RBPermitirEspacios.TabStop = True
        Me.RBPermitirEspacios.UseVisualStyleBackColor = True
        '
        'BtnRemplazar
        '
        Me.BtnRemplazar.BackColor = System.Drawing.Color.White
        Me.BtnRemplazar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemplazar.Image = CType(resources.GetObject("BtnRemplazar.Image"), System.Drawing.Image)
        Me.BtnRemplazar.Location = New System.Drawing.Point(440, 7)
        Me.BtnRemplazar.Name = "BtnRemplazar"
        Me.BtnRemplazar.Size = New System.Drawing.Size(49, 43)
        Me.BtnRemplazar.TabIndex = 118
        Me.BtnRemplazar.Text = "-"
        Me.BtnRemplazar.UseVisualStyleBackColor = False
        '
        'BtnBajarFuente
        '
        Me.BtnBajarFuente.BackColor = System.Drawing.Color.White
        Me.BtnBajarFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBajarFuente.Image = CType(resources.GetObject("BtnBajarFuente.Image"), System.Drawing.Image)
        Me.BtnBajarFuente.Location = New System.Drawing.Point(497, 62)
        Me.BtnBajarFuente.Name = "BtnBajarFuente"
        Me.BtnBajarFuente.Size = New System.Drawing.Size(49, 43)
        Me.BtnBajarFuente.TabIndex = 117
        Me.BtnBajarFuente.Text = "-"
        Me.BtnBajarFuente.UseVisualStyleBackColor = False
        '
        'BtnSubirFuente
        '
        Me.BtnSubirFuente.BackColor = System.Drawing.Color.White
        Me.BtnSubirFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubirFuente.Image = CType(resources.GetObject("BtnSubirFuente.Image"), System.Drawing.Image)
        Me.BtnSubirFuente.Location = New System.Drawing.Point(389, 62)
        Me.BtnSubirFuente.Name = "BtnSubirFuente"
        Me.BtnSubirFuente.Size = New System.Drawing.Size(49, 43)
        Me.BtnSubirFuente.TabIndex = 116
        Me.BtnSubirFuente.UseVisualStyleBackColor = False
        '
        'ContenidoComponenteRichTextBox
        '
        Me.ContenidoComponenteRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Codigo", True))
        Me.ContenidoComponenteRichTextBox.Location = New System.Drawing.Point(3, 111)
        Me.ContenidoComponenteRichTextBox.Name = "ContenidoComponenteRichTextBox"
        Me.ContenidoComponenteRichTextBox.Size = New System.Drawing.Size(593, 459)
        Me.ContenidoComponenteRichTextBox.TabIndex = 115
        Me.ContenidoComponenteRichTextBox.Text = ""
        '
        'BtnBuscarYPintar
        '
        Me.BtnBuscarYPintar.BackColor = System.Drawing.Color.White
        Me.BtnBuscarYPintar.Image = CType(resources.GetObject("BtnBuscarYPintar.Image"), System.Drawing.Image)
        Me.BtnBuscarYPintar.Location = New System.Drawing.Point(335, 7)
        Me.BtnBuscarYPintar.Name = "BtnBuscarYPintar"
        Me.BtnBuscarYPintar.Size = New System.Drawing.Size(49, 43)
        Me.BtnBuscarYPintar.TabIndex = 99
        Me.BtnBuscarYPintar.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.TabPage2.Controls.Add(Me.RequerimientoTextBox)
        Me.TabPage2.Controls.Add(RequerimientoLabel)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.OrdenDePeticionTextBox)
        Me.TabPage2.Controls.Add(EnunciadoLabel)
        Me.TabPage2.Controls.Add(OrdenDePeticionLabel)
        Me.TabPage2.Controls.Add(Me.EnunciadoTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(609, 576)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Requerimientos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Controls.Add(NombreGrupoTipoDeDatoLabel)
        Me.TabPage3.Controls.Add(Me.NombreGrupoTipoDeDatoTextBox)
        Me.TabPage3.Controls.Add(Me.GruposDeTiposDeDatosDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(609, 576)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Grupos de Campos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Nuevo_Menu_GruposDeTiposDeDatos)
        Me.Panel7.Controls.Add(Me.Cancelar_Menu_GruposDeTiposDeDatos)
        Me.Panel7.Controls.Add(Me.Eliminar_Menu_GruposDeTiposDeDatos)
        Me.Panel7.Controls.Add(Me.Editar_Menu_GruposDeTiposDeDatos)
        Me.Panel7.Controls.Add(Me.Actualizar_Menu_GruposDeTiposDeDatos)
        Me.Panel7.Controls.Add(Me.Guardar_Menu_GruposDeTiposDeDatos)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(603, 46)
        Me.Panel7.TabIndex = 103
        '
        'Nuevo_Menu_GruposDeTiposDeDatos
        '
        Me.Nuevo_Menu_GruposDeTiposDeDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_GruposDeTiposDeDatos.Image = CType(resources.GetObject("Nuevo_Menu_GruposDeTiposDeDatos.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_GruposDeTiposDeDatos.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_GruposDeTiposDeDatos.Name = "Nuevo_Menu_GruposDeTiposDeDatos"
        Me.Nuevo_Menu_GruposDeTiposDeDatos.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_GruposDeTiposDeDatos.TabIndex = 70
        Me.Nuevo_Menu_GruposDeTiposDeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_GruposDeTiposDeDatos.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_GruposDeTiposDeDatos
        '
        Me.Cancelar_Menu_GruposDeTiposDeDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_GruposDeTiposDeDatos.Image = CType(resources.GetObject("Cancelar_Menu_GruposDeTiposDeDatos.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_GruposDeTiposDeDatos.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_GruposDeTiposDeDatos.Name = "Cancelar_Menu_GruposDeTiposDeDatos"
        Me.Cancelar_Menu_GruposDeTiposDeDatos.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_GruposDeTiposDeDatos.TabIndex = 75
        Me.Cancelar_Menu_GruposDeTiposDeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_GruposDeTiposDeDatos.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_GruposDeTiposDeDatos
        '
        Me.Eliminar_Menu_GruposDeTiposDeDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_GruposDeTiposDeDatos.Image = CType(resources.GetObject("Eliminar_Menu_GruposDeTiposDeDatos.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_GruposDeTiposDeDatos.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_GruposDeTiposDeDatos.Name = "Eliminar_Menu_GruposDeTiposDeDatos"
        Me.Eliminar_Menu_GruposDeTiposDeDatos.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_GruposDeTiposDeDatos.TabIndex = 72
        Me.Eliminar_Menu_GruposDeTiposDeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_GruposDeTiposDeDatos.UseVisualStyleBackColor = True
        '
        'Editar_Menu_GruposDeTiposDeDatos
        '
        Me.Editar_Menu_GruposDeTiposDeDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_GruposDeTiposDeDatos.Image = CType(resources.GetObject("Editar_Menu_GruposDeTiposDeDatos.Image"), System.Drawing.Image)
        Me.Editar_Menu_GruposDeTiposDeDatos.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_GruposDeTiposDeDatos.Name = "Editar_Menu_GruposDeTiposDeDatos"
        Me.Editar_Menu_GruposDeTiposDeDatos.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_GruposDeTiposDeDatos.TabIndex = 74
        Me.Editar_Menu_GruposDeTiposDeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_GruposDeTiposDeDatos.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_GruposDeTiposDeDatos
        '
        Me.Actualizar_Menu_GruposDeTiposDeDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_GruposDeTiposDeDatos.Image = CType(resources.GetObject("Actualizar_Menu_GruposDeTiposDeDatos.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_GruposDeTiposDeDatos.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_GruposDeTiposDeDatos.Name = "Actualizar_Menu_GruposDeTiposDeDatos"
        Me.Actualizar_Menu_GruposDeTiposDeDatos.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_GruposDeTiposDeDatos.TabIndex = 73
        Me.Actualizar_Menu_GruposDeTiposDeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_GruposDeTiposDeDatos.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_GruposDeTiposDeDatos
        '
        Me.Guardar_Menu_GruposDeTiposDeDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_GruposDeTiposDeDatos.Image = CType(resources.GetObject("Guardar_Menu_GruposDeTiposDeDatos.Image"), System.Drawing.Image)
        Me.Guardar_Menu_GruposDeTiposDeDatos.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_GruposDeTiposDeDatos.Name = "Guardar_Menu_GruposDeTiposDeDatos"
        Me.Guardar_Menu_GruposDeTiposDeDatos.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_GruposDeTiposDeDatos.TabIndex = 71
        Me.Guardar_Menu_GruposDeTiposDeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_GruposDeTiposDeDatos.UseVisualStyleBackColor = True
        '
        'NombreGrupoTipoDeDatoTextBox
        '
        Me.NombreGrupoTipoDeDatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GruposDeTiposDeDatosBindingSource, "NombreGrupoTipoDeDato", True))
        Me.NombreGrupoTipoDeDatoTextBox.Location = New System.Drawing.Point(192, 52)
        Me.NombreGrupoTipoDeDatoTextBox.Name = "NombreGrupoTipoDeDatoTextBox"
        Me.NombreGrupoTipoDeDatoTextBox.Size = New System.Drawing.Size(412, 26)
        Me.NombreGrupoTipoDeDatoTextBox.TabIndex = 102
        '
        'GruposDeTiposDeDatosDataGridView
        '
        Me.GruposDeTiposDeDatosDataGridView.AllowUserToAddRows = False
        Me.GruposDeTiposDeDatosDataGridView.AutoGenerateColumns = False
        Me.GruposDeTiposDeDatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GruposDeTiposDeDatosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.GruposDeTiposDeDatosDataGridView.DataSource = Me.GruposDeTiposDeDatosBindingSource
        Me.GruposDeTiposDeDatosDataGridView.Location = New System.Drawing.Point(6, 84)
        Me.GruposDeTiposDeDatosDataGridView.Name = "GruposDeTiposDeDatosDataGridView"
        Me.GruposDeTiposDeDatosDataGridView.RowHeadersVisible = False
        Me.GruposDeTiposDeDatosDataGridView.Size = New System.Drawing.Size(598, 126)
        Me.GruposDeTiposDeDatosDataGridView.TabIndex = 101
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombreGrupoTipoDeDato"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre Grupo Tipo De Dato"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 594
        '
        'GruposDeTiposDeDatosTableAdapter
        '
        Me.GruposDeTiposDeDatosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.GruposDeTiposDeDatosTableAdapter = Me.GruposDeTiposDeDatosTableAdapter
        Me.TableAdapterManager1.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter = Nothing
        Me.TableAdapterManager1.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARTableAdapter = Me.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARTableAdapter
        Me.TableAdapterManager1.SP_GruposDeTiposDeDatos_EDICION_ELIMINARTableAdapter = Me.SP_GruposDeTiposDeDatos_EDICION_ELIMINARTableAdapter
        Me.TableAdapterManager1.SP_GruposDeTiposDeDatos_EDICION_INSERTARTableAdapter = Me.SP_GruposDeTiposDeDatos_EDICION_INSERTARTableAdapter
        Me.TableAdapterManager1.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = GeneradorCod.DataSetTablasYCamposTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_GruposDeTiposDeDatos_EDICION_ELIMINARTableAdapter
        '
        Me.SP_GruposDeTiposDeDatos_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_GruposDeTiposDeDatos_EDICION_INSERTARTableAdapter
        '
        Me.SP_GruposDeTiposDeDatos_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'GrupoTiposIDTextBox1
        '
        Me.GrupoTiposIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GruposDeTiposDeDatosBindingSource, "GrupoTiposID", True))
        Me.GrupoTiposIDTextBox1.Location = New System.Drawing.Point(871, 484)
        Me.GrupoTiposIDTextBox1.Name = "GrupoTiposIDTextBox1"
        Me.GrupoTiposIDTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.GrupoTiposIDTextBox1.TabIndex = 117
        '
        'SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARBindingSource.DataMember = "SP_GruposDeTiposDeDatos_EDICION_ACTUALIZAR"
        Me.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_GruposDeTiposDeDatos_EDICION_ELIMINARBindingSource
        '
        Me.SP_GruposDeTiposDeDatos_EDICION_ELIMINARBindingSource.DataMember = "SP_GruposDeTiposDeDatos_EDICION_ELIMINAR"
        Me.SP_GruposDeTiposDeDatos_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_GruposDeTiposDeDatos_EDICION_INSERTARBindingSource
        '
        Me.SP_GruposDeTiposDeDatos_EDICION_INSERTARBindingSource.DataMember = "SP_GruposDeTiposDeDatos_EDICION_INSERTAR"
        Me.SP_GruposDeTiposDeDatos_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource
        '
        Me.SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource.DataMember = "SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposID"
        Me.SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter
        '
        Me.SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter.ClearBeforeFill = True
        '
        'NombreGrupoTipoDeDatoTextBox1
        '
        Me.NombreGrupoTipoDeDatoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource, "NombreGrupoTipoDeDato", True))
        Me.NombreGrupoTipoDeDatoTextBox1.Location = New System.Drawing.Point(871, 516)
        Me.NombreGrupoTipoDeDatoTextBox1.Name = "NombreGrupoTipoDeDatoTextBox1"
        Me.NombreGrupoTipoDeDatoTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.NombreGrupoTipoDeDatoTextBox1.TabIndex = 119
        '
        'GrupoTiposIDTextBox2
        '
        Me.GrupoTiposIDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "GrupoTiposID", True))
        Me.GrupoTiposIDTextBox2.Location = New System.Drawing.Point(871, 260)
        Me.GrupoTiposIDTextBox2.Name = "GrupoTiposIDTextBox2"
        Me.GrupoTiposIDTextBox2.Size = New System.Drawing.Size(100, 26)
        Me.GrupoTiposIDTextBox2.TabIndex = 120
        '
        'FrmTecnologias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 603)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(GrupoTiposIDLabel1)
        Me.Controls.Add(Me.GrupoTiposIDTextBox2)
        Me.Controls.Add(NombreGrupoTipoDeDatoLabel1)
        Me.Controls.Add(Me.NombreGrupoTipoDeDatoTextBox1)
        Me.Controls.Add(GrupoTiposIDLabel)
        Me.Controls.Add(Me.GrupoTiposIDTextBox1)
        Me.Controls.Add(Me.GrupoTiposIDTextBox)
        Me.Controls.Add(RequerimientoPlantillaIDLabel)
        Me.Controls.Add(Me.RequerimientoPlantillaIDTextBox)
        Me.Controls.Add(ComponenteIDLabel)
        Me.Controls.Add(Me.ComponenteIDTextBox)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(PlantillaIDLabel)
        Me.Controls.Add(Me.PlantillaIDTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ControlNulos)
        Me.Controls.Add(TecnologiaIDLabel)
        Me.Controls.Add(Me.TecnologiaIDTextBox)
        Me.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Italic)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmTecnologias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tecnologias"
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdministracion_.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GruposDeTiposDeDatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.GruposDeTiposDeDatosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_GruposDeTiposDeDatos_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_GruposDeTiposDeDatos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
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
    Friend WithEvents EnunciadoTextBox As TextBox
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Cbo_GruposDeCampos As ComboBox
    Friend WithEvents GrupoTiposIDTextBox As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ContenidoComponenteRichTextBox As RichTextBox
    Friend WithEvents BtnSubirFuente As Button
    Friend WithEvents BtnBuscarYPintar As Button
    Friend WithEvents BtnRemplazar As Button
    Friend WithEvents BtnBajarFuente As Button
    Friend WithEvents RBPermitirEspacios As RadioButton
    Friend WithEvents BtnSubirRemplazado As Button
    Friend WithEvents BtnLimpiarRemplazar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardarCodigo As Button
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataSetTablasYCampos As DataSetTablasYCampos
    Friend WithEvents GruposDeTiposDeDatosBindingSource As BindingSource
    Friend WithEvents GruposDeTiposDeDatosTableAdapter As DataSetTablasYCamposTableAdapters.GruposDeTiposDeDatosTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSetTablasYCamposTableAdapters.TableAdapterManager
    Friend WithEvents NombreGrupoTipoDeDatoTextBox As TextBox
    Friend WithEvents GruposDeTiposDeDatosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Nuevo_Menu_GruposDeTiposDeDatos As Button
    Friend WithEvents Cancelar_Menu_GruposDeTiposDeDatos As Button
    Friend WithEvents Eliminar_Menu_GruposDeTiposDeDatos As Button
    Friend WithEvents Editar_Menu_GruposDeTiposDeDatos As Button
    Friend WithEvents Actualizar_Menu_GruposDeTiposDeDatos As Button
    Friend WithEvents Guardar_Menu_GruposDeTiposDeDatos As Button
    Friend WithEvents GrupoTiposIDTextBox1 As TextBox
    Friend WithEvents SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_GruposDeTiposDeDatos_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_GruposDeTiposDeDatos_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_GruposDeTiposDeDatos_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_GruposDeTiposDeDatos_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_GruposDeTiposDeDatos_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_GruposDeTiposDeDatos_EDICION_INSERTARTableAdapter
    Friend WithEvents SP_GruposDeTiposDeDatos_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDBindingSource As BindingSource
    Friend WithEvents SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_GruposDeTiposDeDatos_BUSQUEDA_SEGUN_PARAMETRO_GrupoTiposIDTableAdapter
    Friend WithEvents NombreGrupoTipoDeDatoTextBox1 As TextBox
    Friend WithEvents GrupoTiposIDTextBox2 As TextBox
End Class
