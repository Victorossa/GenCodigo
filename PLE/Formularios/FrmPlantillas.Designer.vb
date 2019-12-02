<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPlantillas
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
        Dim TecnologiaIDLabel As System.Windows.Forms.Label
        Dim NombreTecnologiaLabel As System.Windows.Forms.Label
        Dim OrdenLabel As System.Windows.Forms.Label
        Dim NombrePlantillaLabel As System.Windows.Forms.Label
        Dim PlantillaIDLabel As System.Windows.Forms.Label
        Dim XTablaLabel As System.Windows.Forms.Label
        Dim NombreComponenteLabel As System.Windows.Forms.Label
        Dim XTablaLabel1 As System.Windows.Forms.Label
        Dim ComponenteIDLabel As System.Windows.Forms.Label
        Dim RequerimientoLabel As System.Windows.Forms.Label
        Dim EnunciadoLabel As System.Windows.Forms.Label
        Dim OrdenDePeticionLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlantillas))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim RequerimientoPlantillaIDLabel As System.Windows.Forms.Label
        Me.Panel_Tecnologias = New System.Windows.Forms.Panel()
        Me.TecnologiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TecnologiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPlantillas = New PLE.DataSetPlantillas()
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.Editar_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Tecnologias = New System.Windows.Forms.Button()
        Me.NombreTecnologiaTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComponenteIDTextBox = New System.Windows.Forms.TextBox()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.XTablaTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ControlNulos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TecnologiaIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVEdicionPosicion = New System.Windows.Forms.DataGridView()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView = New System.Windows.Forms.DataGridView()
        Me.Orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.XTablaCheckBox = New System.Windows.Forms.CheckBox()
        Me.NombreComponenteTextBox = New System.Windows.Forms.TextBox()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancelar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Nuevo_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.Editar_Menu_Componentes = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.BtnFuentes = New System.Windows.Forms.Button()
        Me.BtnDerecha = New System.Windows.Forms.Button()
        Me.BtnCentrar = New System.Windows.Forms.Button()
        Me.BtnIzquierda = New System.Windows.Forms.Button()
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
        Me.RBPermitirEspacios = New System.Windows.Forms.RadioButton()
        Me.BtnRemplazar = New System.Windows.Forms.Button()
        Me.BtnBajarFuente = New System.Windows.Forms.Button()
        Me.BtnSubirFuente = New System.Windows.Forms.Button()
        Me.ContenidoComponenteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BtnBuscarYPintar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBuscado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRemplazarPor = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.TecnologiasTableAdapter = New PLE.DataSetPlantillasTableAdapters.TecnologiasTableAdapter()
        Me.TableAdapterManager = New PLE.DataSetPlantillasTableAdapters.TableAdapterManager()
        Me.SP_Tecnologias_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter()
        Me.SP_Tecnologias_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Tecnologias_EDICION_ELIMINARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Tecnologias_EDICION_ELIMINARTableAdapter()
        Me.SP_Tecnologias_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Tecnologias_EDICION_INSERTARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Tecnologias_EDICION_INSERTARTableAdapter()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter()
        Me.SP_Plantillas_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Plantillas_EDICION_ACTUALIZARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Plantillas_EDICION_ACTUALIZARTableAdapter()
        Me.SP_Plantillas_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Plantillas_EDICION_ELIMINARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Plantillas_EDICION_ELIMINARTableAdapter()
        Me.SP_Plantillas_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Plantillas_EDICION_INSERTARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Plantillas_EDICION_INSERTARTableAdapter()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.SP_Componentes_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Componentes_EDICION_ACTUALIZARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Componentes_EDICION_ACTUALIZARTableAdapter()
        Me.SP_Componentes_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Componentes_EDICION_ELIMINARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Componentes_EDICION_ELIMINARTableAdapter()
        Me.SP_Componentes_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Componentes_EDICION_INSERTARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_Componentes_EDICION_INSERTARTableAdapter()
        Me.SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter()
        Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter()
        Me.SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New PLE.DataSetPlantillasTableAdapters.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RequerimientoPlantillaIDTextBox = New System.Windows.Forms.TextBox()
        TecnologiaIDLabel = New System.Windows.Forms.Label()
        NombreTecnologiaLabel = New System.Windows.Forms.Label()
        OrdenLabel = New System.Windows.Forms.Label()
        NombrePlantillaLabel = New System.Windows.Forms.Label()
        PlantillaIDLabel = New System.Windows.Forms.Label()
        XTablaLabel = New System.Windows.Forms.Label()
        NombreComponenteLabel = New System.Windows.Forms.Label()
        XTablaLabel1 = New System.Windows.Forms.Label()
        ComponenteIDLabel = New System.Windows.Forms.Label()
        RequerimientoLabel = New System.Windows.Forms.Label()
        EnunciadoLabel = New System.Windows.Forms.Label()
        OrdenDePeticionLabel = New System.Windows.Forms.Label()
        RequerimientoPlantillaIDLabel = New System.Windows.Forms.Label()
        Me.Panel_Tecnologias.SuspendLayout()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPlantillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdministracion_.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVEdicionPosicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        CType(Me.SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TecnologiaIDLabel
        '
        TecnologiaIDLabel.AutoSize = True
        TecnologiaIDLabel.Location = New System.Drawing.Point(21, 52)
        TecnologiaIDLabel.Name = "TecnologiaIDLabel"
        TecnologiaIDLabel.Size = New System.Drawing.Size(77, 13)
        TecnologiaIDLabel.TabIndex = 0
        TecnologiaIDLabel.Text = "Tecnologia ID:"
        '
        'NombreTecnologiaLabel
        '
        NombreTecnologiaLabel.AutoSize = True
        NombreTecnologiaLabel.Location = New System.Drawing.Point(4, 54)
        NombreTecnologiaLabel.Name = "NombreTecnologiaLabel"
        NombreTecnologiaLabel.Size = New System.Drawing.Size(133, 19)
        NombreTecnologiaLabel.TabIndex = 0
        NombreTecnologiaLabel.Text = "Nombre Tecnologia:"
        '
        'OrdenLabel
        '
        OrdenLabel.AutoSize = True
        OrdenLabel.Location = New System.Drawing.Point(326, 50)
        OrdenLabel.Name = "OrdenLabel"
        OrdenLabel.Size = New System.Drawing.Size(51, 19)
        OrdenLabel.TabIndex = 122
        OrdenLabel.Text = "Orden:"
        '
        'NombrePlantillaLabel
        '
        NombrePlantillaLabel.AutoSize = True
        NombrePlantillaLabel.Location = New System.Drawing.Point(2, 50)
        NombrePlantillaLabel.Name = "NombrePlantillaLabel"
        NombrePlantillaLabel.Size = New System.Drawing.Size(114, 19)
        NombrePlantillaLabel.TabIndex = 121
        NombrePlantillaLabel.Text = "Nombre Plantilla:"
        '
        'PlantillaIDLabel
        '
        PlantillaIDLabel.AutoSize = True
        PlantillaIDLabel.Location = New System.Drawing.Point(38, 98)
        PlantillaIDLabel.Name = "PlantillaIDLabel"
        PlantillaIDLabel.Size = New System.Drawing.Size(60, 13)
        PlantillaIDLabel.TabIndex = 3
        PlantillaIDLabel.Text = "Plantilla ID:"
        '
        'XTablaLabel
        '
        XTablaLabel.AutoSize = True
        XTablaLabel.Location = New System.Drawing.Point(3, 238)
        XTablaLabel.Name = "XTablaLabel"
        XTablaLabel.Size = New System.Drawing.Size(69, 19)
        XTablaLabel.TabIndex = 97
        XTablaLabel.Text = "Por Tabla:"
        '
        'NombreComponenteLabel
        '
        NombreComponenteLabel.AutoSize = True
        NombreComponenteLabel.Location = New System.Drawing.Point(5, 106)
        NombreComponenteLabel.Name = "NombreComponenteLabel"
        NombreComponenteLabel.Size = New System.Drawing.Size(89, 19)
        NombreComponenteLabel.TabIndex = 96
        NombreComponenteLabel.Text = "Componente"
        '
        'XTablaLabel1
        '
        XTablaLabel1.AutoSize = True
        XTablaLabel1.Location = New System.Drawing.Point(54, 173)
        XTablaLabel1.Name = "XTablaLabel1"
        XTablaLabel1.Size = New System.Drawing.Size(44, 13)
        XTablaLabel1.TabIndex = 8
        XTablaLabel1.Text = "XTabla:"
        '
        'ComponenteIDLabel
        '
        ComponenteIDLabel.AutoSize = True
        ComponenteIDLabel.Location = New System.Drawing.Point(14, 147)
        ComponenteIDLabel.Name = "ComponenteIDLabel"
        ComponenteIDLabel.Size = New System.Drawing.Size(84, 13)
        ComponenteIDLabel.TabIndex = 11
        ComponenteIDLabel.Text = "Componente ID:"
        '
        'RequerimientoLabel
        '
        RequerimientoLabel.AutoSize = True
        RequerimientoLabel.Location = New System.Drawing.Point(5, 127)
        RequerimientoLabel.Name = "RequerimientoLabel"
        RequerimientoLabel.Size = New System.Drawing.Size(101, 19)
        RequerimientoLabel.TabIndex = 112
        RequerimientoLabel.Text = "Requerimiento:"
        '
        'EnunciadoLabel
        '
        EnunciadoLabel.AutoSize = True
        EnunciadoLabel.Location = New System.Drawing.Point(4, 49)
        EnunciadoLabel.Name = "EnunciadoLabel"
        EnunciadoLabel.Size = New System.Drawing.Size(76, 19)
        EnunciadoLabel.TabIndex = 116
        EnunciadoLabel.Text = "Enunciado:"
        '
        'OrdenDePeticionLabel
        '
        OrdenDePeticionLabel.AutoSize = True
        OrdenDePeticionLabel.Location = New System.Drawing.Point(676, 128)
        OrdenDePeticionLabel.Name = "OrdenDePeticionLabel"
        OrdenDePeticionLabel.Size = New System.Drawing.Size(48, 19)
        OrdenDePeticionLabel.TabIndex = 114
        OrdenDePeticionLabel.Text = "Orden"
        '
        'Panel_Tecnologias
        '
        Me.Panel_Tecnologias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Tecnologias.Controls.Add(Me.TecnologiasDataGridView)
        Me.Panel_Tecnologias.Controls.Add(Me.PanelAdministracion_)
        Me.Panel_Tecnologias.Controls.Add(NombreTecnologiaLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.NombreTecnologiaTextBox)
        Me.Panel_Tecnologias.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Tecnologias.Location = New System.Drawing.Point(5, 0)
        Me.Panel_Tecnologias.Name = "Panel_Tecnologias"
        Me.Panel_Tecnologias.Size = New System.Drawing.Size(382, 259)
        Me.Panel_Tecnologias.TabIndex = 0
        '
        'TecnologiasDataGridView
        '
        Me.TecnologiasDataGridView.AllowUserToAddRows = False
        Me.TecnologiasDataGridView.AutoGenerateColumns = False
        Me.TecnologiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TecnologiasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.TecnologiasDataGridView.DataSource = Me.TecnologiasBindingSource
        Me.TecnologiasDataGridView.Location = New System.Drawing.Point(4, 107)
        Me.TecnologiasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TecnologiasDataGridView.Name = "TecnologiasDataGridView"
        Me.TecnologiasDataGridView.RowHeadersVisible = False
        Me.TecnologiasDataGridView.RowTemplate.Height = 27
        Me.TecnologiasDataGridView.Size = New System.Drawing.Size(373, 142)
        Me.TecnologiasDataGridView.TabIndex = 92
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreTecnologia"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Tecnologia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 370
        '
        'TecnologiasBindingSource
        '
        Me.TecnologiasBindingSource.DataMember = "Tecnologias"
        Me.TecnologiasBindingSource.DataSource = Me.DataSetPlantillas
        '
        'DataSetPlantillas
        '
        Me.DataSetPlantillas.DataSetName = "DataSetPlantillas"
        Me.DataSetPlantillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.PanelAdministracion_.Location = New System.Drawing.Point(4, 5)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(373, 46)
        Me.PanelAdministracion_.TabIndex = 91
        '
        'Nuevo_Menu_Tecnologias
        '
        Me.Nuevo_Menu_Tecnologias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_Tecnologias.Image = CType(resources.GetObject("Nuevo_Menu_Tecnologias.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_Tecnologias.Location = New System.Drawing.Point(10, 3)
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
        Me.Cancelar_Menu_Tecnologias.Location = New System.Drawing.Point(320, 3)
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
        Me.Eliminar_Menu_Tecnologias.Location = New System.Drawing.Point(259, 3)
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
        Me.Editar_Menu_Tecnologias.Location = New System.Drawing.Point(133, 3)
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
        Me.Actualizar_Menu_Tecnologias.Location = New System.Drawing.Point(196, 3)
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
        Me.Guardar_Menu_Tecnologias.Location = New System.Drawing.Point(72, 3)
        Me.Guardar_Menu_Tecnologias.Name = "Guardar_Menu_Tecnologias"
        Me.Guardar_Menu_Tecnologias.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_Tecnologias.TabIndex = 71
        Me.Guardar_Menu_Tecnologias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_Tecnologias.UseVisualStyleBackColor = True
        '
        'NombreTecnologiaTextBox
        '
        Me.NombreTecnologiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "NombreTecnologia", True))
        Me.NombreTecnologiaTextBox.Location = New System.Drawing.Point(4, 76)
        Me.NombreTecnologiaTextBox.Name = "NombreTecnologiaTextBox"
        Me.NombreTecnologiaTextBox.Size = New System.Drawing.Size(373, 24)
        Me.NombreTecnologiaTextBox.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(RequerimientoPlantillaIDLabel)
        Me.Panel1.Controls.Add(Me.RequerimientoPlantillaIDTextBox)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(ComponenteIDLabel)
        Me.Panel1.Controls.Add(Me.ComponenteIDTextBox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(XTablaLabel1)
        Me.Panel1.Controls.Add(Me.XTablaTextBox)
        Me.Panel1.Controls.Add(PlantillaIDLabel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PlantillaIDTextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ControlNulos)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(TecnologiaIDLabel)
        Me.Panel1.Controls.Add(Me.TecnologiaIDTextBox)
        Me.Panel1.Location = New System.Drawing.Point(1327, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 470)
        Me.Panel1.TabIndex = 1
        '
        'ComponenteIDTextBox
        '
        Me.ComponenteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "ComponenteID", True))
        Me.ComponenteIDTextBox.Location = New System.Drawing.Point(104, 144)
        Me.ComponenteIDTextBox.Name = "ComponenteIDTextBox"
        Me.ComponenteIDTextBox.Size = New System.Drawing.Size(51, 20)
        Me.ComponenteIDTextBox.TabIndex = 12
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetPlantillas
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Componentes"
        '
        'XTablaTextBox
        '
        Me.XTablaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "XTabla", True))
        Me.XTablaTextBox.Location = New System.Drawing.Point(104, 170)
        Me.XTablaTextBox.Name = "XTablaTextBox"
        Me.XTablaTextBox.Size = New System.Drawing.Size(53, 20)
        Me.XTablaTextBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Plantillas"
        '
        'PlantillaIDTextBox
        '
        Me.PlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "PlantillaID", True))
        Me.PlantillaIDTextBox.Location = New System.Drawing.Point(104, 95)
        Me.PlantillaIDTextBox.Name = "PlantillaIDTextBox"
        Me.PlantillaIDTextBox.Size = New System.Drawing.Size(51, 20)
        Me.PlantillaIDTextBox.TabIndex = 4
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataMember = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataSource = Me.DataSetPlantillas
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Control Nulos"
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(104, 3)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(51, 20)
        Me.ControlNulos.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tecnologias"
        '
        'TecnologiaIDTextBox
        '
        Me.TecnologiaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "TecnologiaID", True))
        Me.TecnologiaIDTextBox.Location = New System.Drawing.Point(104, 49)
        Me.TecnologiaIDTextBox.Name = "TecnologiaIDTextBox"
        Me.TecnologiaIDTextBox.Size = New System.Drawing.Size(51, 20)
        Me.TecnologiaIDTextBox.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DGVEdicionPosicion)
        Me.Panel2.Controls.Add(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView)
        Me.Panel2.Controls.Add(OrdenLabel)
        Me.Panel2.Controls.Add(Me.OrdenTextBox)
        Me.Panel2.Controls.Add(NombrePlantillaLabel)
        Me.Panel2.Controls.Add(Me.NombrePlantillaTextBox)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!)
        Me.Panel2.Location = New System.Drawing.Point(5, 265)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(382, 316)
        Me.Panel2.TabIndex = 2
        '
        'DGVEdicionPosicion
        '
        Me.DGVEdicionPosicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEdicionPosicion.Location = New System.Drawing.Point(4, 128)
        Me.DGVEdicionPosicion.Name = "DGVEdicionPosicion"
        Me.DGVEdicionPosicion.Size = New System.Drawing.Size(373, 183)
        Me.DGVEdicionPosicion.TabIndex = 125
        Me.DGVEdicionPosicion.Visible = False
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AllowUserToAddRows = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AutoGenerateColumns = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Orden, Me.DataGridViewTextBoxColumn4, Me.Column1})
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.DataSource = Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Location = New System.Drawing.Point(3, 102)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Name = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowHeadersVisible = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowTemplate.Height = 27
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Size = New System.Drawing.Size(374, 209)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.TabIndex = 120
        '
        'Orden
        '
        Me.Orden.DataPropertyName = "Orden"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Orden.DefaultCellStyle = DataGridViewCellStyle4
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
        'OrdenTextBox
        '
        Me.OrdenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "Orden", True))
        Me.OrdenTextBox.Location = New System.Drawing.Point(344, 72)
        Me.OrdenTextBox.Name = "OrdenTextBox"
        Me.OrdenTextBox.Size = New System.Drawing.Size(33, 24)
        Me.OrdenTextBox.TabIndex = 124
        Me.OrdenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NombrePlantillaTextBox
        '
        Me.NombrePlantillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "NombrePlantilla", True))
        Me.NombrePlantillaTextBox.Location = New System.Drawing.Point(4, 72)
        Me.NombrePlantillaTextBox.Name = "NombrePlantillaTextBox"
        Me.NombrePlantillaTextBox.Size = New System.Drawing.Size(334, 24)
        Me.NombrePlantillaTextBox.TabIndex = 123
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
        Me.Panel4.Location = New System.Drawing.Point(4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(373, 44)
        Me.Panel4.TabIndex = 90
        '
        'ChkMover
        '
        Me.ChkMover.AutoSize = True
        Me.ChkMover.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMover.Location = New System.Drawing.Point(279, 15)
        Me.ChkMover.Name = "ChkMover"
        Me.ChkMover.Size = New System.Drawing.Size(15, 14)
        Me.ChkMover.TabIndex = 118
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
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.Panel6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!)
        Me.Panel6.Location = New System.Drawing.Point(393, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(182, 581)
        Me.Panel6.TabIndex = 97
        '
        'XTablaCheckBox
        '
        Me.XTablaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "XTabla", True))
        Me.XTablaCheckBox.Location = New System.Drawing.Point(79, 238)
        Me.XTablaCheckBox.Name = "XTablaCheckBox"
        Me.XTablaCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.XTablaCheckBox.TabIndex = 98
        Me.XTablaCheckBox.UseVisualStyleBackColor = True
        '
        'NombreComponenteTextBox
        '
        Me.NombreComponenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "NombreComponente", True))
        Me.NombreComponenteTextBox.Location = New System.Drawing.Point(3, 127)
        Me.NombreComponenteTextBox.Multiline = True
        Me.NombreComponenteTextBox.Name = "NombreComponenteTextBox"
        Me.NombreComponenteTextBox.Size = New System.Drawing.Size(174, 108)
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
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(0, 263)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(180, 316)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 97
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NombreComponente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Componente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 175
        '
        'Cancelar_Menu_Componentes
        '
        Me.Cancelar_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_Componentes.Image = CType(resources.GetObject("Cancelar_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_Componentes.Location = New System.Drawing.Point(122, 44)
        Me.Cancelar_Menu_Componentes.Name = "Cancelar_Menu_Componentes"
        Me.Cancelar_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_Componentes.TabIndex = 75
        Me.Cancelar_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_Componentes.UseVisualStyleBackColor = True
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
        'Eliminar_Menu_Componentes
        '
        Me.Eliminar_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_Componentes.Image = CType(resources.GetObject("Eliminar_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_Componentes.Location = New System.Drawing.Point(70, 57)
        Me.Eliminar_Menu_Componentes.Name = "Eliminar_Menu_Componentes"
        Me.Eliminar_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_Componentes.TabIndex = 72
        Me.Eliminar_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_Componentes.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_Componentes
        '
        Me.Guardar_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_Componentes.Image = CType(resources.GetObject("Guardar_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Guardar_Menu_Componentes.Location = New System.Drawing.Point(70, 5)
        Me.Guardar_Menu_Componentes.Name = "Guardar_Menu_Componentes"
        Me.Guardar_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_Componentes.TabIndex = 71
        Me.Guardar_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_Componentes.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_Componentes
        '
        Me.Actualizar_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_Componentes.Image = CType(resources.GetObject("Actualizar_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_Componentes.Location = New System.Drawing.Point(137, 5)
        Me.Actualizar_Menu_Componentes.Name = "Actualizar_Menu_Componentes"
        Me.Actualizar_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_Componentes.TabIndex = 73
        Me.Actualizar_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_Componentes.UseVisualStyleBackColor = True
        '
        'Editar_Menu_Componentes
        '
        Me.Editar_Menu_Componentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_Componentes.Image = CType(resources.GetObject("Editar_Menu_Componentes.Image"), System.Drawing.Image)
        Me.Editar_Menu_Componentes.Location = New System.Drawing.Point(15, 44)
        Me.Editar_Menu_Componentes.Name = "Editar_Menu_Componentes"
        Me.Editar_Menu_Componentes.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_Componentes.TabIndex = 74
        Me.Editar_Menu_Componentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_Componentes.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!)
        Me.TabControl1.Location = New System.Drawing.Point(583, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(738, 581)
        Me.TabControl1.TabIndex = 117
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnColor)
        Me.TabPage1.Controls.Add(Me.BtnFuentes)
        Me.TabPage1.Controls.Add(Me.BtnDerecha)
        Me.TabPage1.Controls.Add(Me.BtnCentrar)
        Me.TabPage1.Controls.Add(Me.BtnIzquierda)
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
        Me.TabPage1.Controls.Add(Me.RBPermitirEspacios)
        Me.TabPage1.Controls.Add(Me.BtnRemplazar)
        Me.TabPage1.Controls.Add(Me.BtnBajarFuente)
        Me.TabPage1.Controls.Add(Me.BtnSubirFuente)
        Me.TabPage1.Controls.Add(Me.ContenidoComponenteRichTextBox)
        Me.TabPage1.Controls.Add(Me.BtnBuscarYPintar)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TxtBuscado)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TxtRemplazarPor)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(729, 549)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Busqueda y Remplazo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnColor
        '
        Me.BtnColor.Location = New System.Drawing.Point(644, 515)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(75, 28)
        Me.BtnColor.TabIndex = 135
        Me.BtnColor.Text = "Color"
        Me.BtnColor.UseVisualStyleBackColor = True
        '
        'BtnFuentes
        '
        Me.BtnFuentes.Location = New System.Drawing.Point(13, 515)
        Me.BtnFuentes.Name = "BtnFuentes"
        Me.BtnFuentes.Size = New System.Drawing.Size(75, 28)
        Me.BtnFuentes.TabIndex = 134
        Me.BtnFuentes.Text = "Fuente"
        Me.BtnFuentes.UseVisualStyleBackColor = True
        '
        'BtnDerecha
        '
        Me.BtnDerecha.Location = New System.Drawing.Point(408, 515)
        Me.BtnDerecha.Name = "BtnDerecha"
        Me.BtnDerecha.Size = New System.Drawing.Size(75, 28)
        Me.BtnDerecha.TabIndex = 133
        Me.BtnDerecha.Text = "Derecha"
        Me.BtnDerecha.UseVisualStyleBackColor = True
        '
        'BtnCentrar
        '
        Me.BtnCentrar.Location = New System.Drawing.Point(327, 515)
        Me.BtnCentrar.Name = "BtnCentrar"
        Me.BtnCentrar.Size = New System.Drawing.Size(75, 28)
        Me.BtnCentrar.TabIndex = 132
        Me.BtnCentrar.Text = "Centrar"
        Me.BtnCentrar.UseVisualStyleBackColor = True
        '
        'BtnIzquierda
        '
        Me.BtnIzquierda.Location = New System.Drawing.Point(246, 515)
        Me.BtnIzquierda.Name = "BtnIzquierda"
        Me.BtnIzquierda.Size = New System.Drawing.Size(75, 28)
        Me.BtnIzquierda.TabIndex = 131
        Me.BtnIzquierda.Text = "Izquierda"
        Me.BtnIzquierda.UseVisualStyleBackColor = True
        '
        'BtnTablaPluralMinuscula
        '
        Me.BtnTablaPluralMinuscula.BackColor = System.Drawing.Color.White
        Me.BtnTablaPluralMinuscula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTablaPluralMinuscula.Location = New System.Drawing.Point(616, 61)
        Me.BtnTablaPluralMinuscula.Name = "BtnTablaPluralMinuscula"
        Me.BtnTablaPluralMinuscula.Size = New System.Drawing.Size(102, 43)
        Me.BtnTablaPluralMinuscula.TabIndex = 130
        Me.BtnTablaPluralMinuscula.Text = "{{{TPlurMin}}}"
        Me.BtnTablaPluralMinuscula.UseVisualStyleBackColor = False
        '
        'BtnMayusculaAMinuscula
        '
        Me.BtnMayusculaAMinuscula.BackColor = System.Drawing.Color.White
        Me.BtnMayusculaAMinuscula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMayusculaAMinuscula.Location = New System.Drawing.Point(532, 62)
        Me.BtnMayusculaAMinuscula.Name = "BtnMayusculaAMinuscula"
        Me.BtnMayusculaAMinuscula.Size = New System.Drawing.Size(78, 43)
        Me.BtnMayusculaAMinuscula.TabIndex = 129
        Me.BtnMayusculaAMinuscula.Text = "{{{A=>-a}}}"
        Me.BtnMayusculaAMinuscula.UseVisualStyleBackColor = False
        '
        'BtnTablaPlural
        '
        Me.BtnTablaPlural.BackColor = System.Drawing.Color.White
        Me.BtnTablaPlural.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTablaPlural.Location = New System.Drawing.Point(448, 62)
        Me.BtnTablaPlural.Name = "BtnTablaPlural"
        Me.BtnTablaPlural.Size = New System.Drawing.Size(78, 43)
        Me.BtnTablaPlural.TabIndex = 128
        Me.BtnTablaPlural.Text = "{{{TPlur}}}"
        Me.BtnTablaPlural.UseVisualStyleBackColor = False
        '
        'BtnTablaMinuscula
        '
        Me.BtnTablaMinuscula.BackColor = System.Drawing.Color.White
        Me.BtnTablaMinuscula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTablaMinuscula.Location = New System.Drawing.Point(363, 62)
        Me.BtnTablaMinuscula.Name = "BtnTablaMinuscula"
        Me.BtnTablaMinuscula.Size = New System.Drawing.Size(79, 43)
        Me.BtnTablaMinuscula.TabIndex = 127
        Me.BtnTablaMinuscula.Text = "{{{Tmin}}}"
        Me.BtnTablaMinuscula.UseVisualStyleBackColor = False
        '
        'BtnImprimeClavePrincipal
        '
        Me.BtnImprimeClavePrincipal.BackColor = System.Drawing.Color.White
        Me.BtnImprimeClavePrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimeClavePrincipal.Location = New System.Drawing.Point(573, 7)
        Me.BtnImprimeClavePrincipal.Name = "BtnImprimeClavePrincipal"
        Me.BtnImprimeClavePrincipal.Size = New System.Drawing.Size(77, 43)
        Me.BtnImprimeClavePrincipal.TabIndex = 126
        Me.BtnImprimeClavePrincipal.Text = "{{{Clave}}}"
        Me.BtnImprimeClavePrincipal.UseVisualStyleBackColor = False
        '
        'BtnImprimeTabla
        '
        Me.BtnImprimeTabla.BackColor = System.Drawing.Color.White
        Me.BtnImprimeTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimeTabla.Location = New System.Drawing.Point(487, 7)
        Me.BtnImprimeTabla.Name = "BtnImprimeTabla"
        Me.BtnImprimeTabla.Size = New System.Drawing.Size(80, 43)
        Me.BtnImprimeTabla.TabIndex = 125
        Me.BtnImprimeTabla.Text = "{{{Tabla}}}"
        Me.BtnImprimeTabla.UseVisualStyleBackColor = False
        '
        'BtnImprimeCampos
        '
        Me.BtnImprimeCampos.BackColor = System.Drawing.Color.White
        Me.BtnImprimeCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimeCampos.Location = New System.Drawing.Point(268, 62)
        Me.BtnImprimeCampos.Name = "BtnImprimeCampos"
        Me.BtnImprimeCampos.Size = New System.Drawing.Size(89, 43)
        Me.BtnImprimeCampos.TabIndex = 124
        Me.BtnImprimeCampos.Text = "{{{Campos}}}"
        Me.BtnImprimeCampos.UseVisualStyleBackColor = False
        '
        'BtnGuardarCodigo
        '
        Me.BtnGuardarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardarCodigo.Image = CType(resources.GetObject("BtnGuardarCodigo.Image"), System.Drawing.Image)
        Me.BtnGuardarCodigo.Location = New System.Drawing.Point(669, 6)
        Me.BtnGuardarCodigo.Name = "BtnGuardarCodigo"
        Me.BtnGuardarCodigo.Size = New System.Drawing.Size(49, 44)
        Me.BtnGuardarCodigo.TabIndex = 123
        Me.BtnGuardarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        'RBPermitirEspacios
        '
        Me.RBPermitirEspacios.AutoSize = True
        Me.RBPermitirEspacios.Location = New System.Drawing.Point(251, 86)
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
        Me.BtnRemplazar.Location = New System.Drawing.Point(323, 7)
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
        Me.BtnBajarFuente.Location = New System.Drawing.Point(432, 7)
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
        Me.BtnSubirFuente.Location = New System.Drawing.Point(377, 7)
        Me.BtnSubirFuente.Name = "BtnSubirFuente"
        Me.BtnSubirFuente.Size = New System.Drawing.Size(49, 43)
        Me.BtnSubirFuente.TabIndex = 116
        Me.BtnSubirFuente.UseVisualStyleBackColor = False
        '
        'ContenidoComponenteRichTextBox
        '
        Me.ContenidoComponenteRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Codigo", True))
        Me.ContenidoComponenteRichTextBox.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContenidoComponenteRichTextBox.Location = New System.Drawing.Point(3, 111)
        Me.ContenidoComponenteRichTextBox.Name = "ContenidoComponenteRichTextBox"
        Me.ContenidoComponenteRichTextBox.Size = New System.Drawing.Size(716, 398)
        Me.ContenidoComponenteRichTextBox.TabIndex = 115
        Me.ContenidoComponenteRichTextBox.Text = ""
        '
        'BtnBuscarYPintar
        '
        Me.BtnBuscarYPintar.BackColor = System.Drawing.Color.White
        Me.BtnBuscarYPintar.Image = CType(resources.GetObject("BtnBuscarYPintar.Image"), System.Drawing.Image)
        Me.BtnBuscarYPintar.Location = New System.Drawing.Point(268, 7)
        Me.BtnBuscarYPintar.Name = "BtnBuscarYPintar"
        Me.BtnBuscarYPintar.Size = New System.Drawing.Size(49, 43)
        Me.BtnBuscarYPintar.TabIndex = 99
        Me.BtnBuscarYPintar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 19)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Buscar"
        '
        'TxtBuscado
        '
        Me.TxtBuscado.Location = New System.Drawing.Point(6, 24)
        Me.TxtBuscado.Name = "TxtBuscado"
        Me.TxtBuscado.Size = New System.Drawing.Size(216, 24)
        Me.TxtBuscado.TabIndex = 104
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Remplazar por:"
        '
        'TxtRemplazarPor
        '
        Me.TxtRemplazarPor.Location = New System.Drawing.Point(6, 79)
        Me.TxtRemplazarPor.Name = "TxtRemplazarPor"
        Me.TxtRemplazarPor.Size = New System.Drawing.Size(216, 24)
        Me.TxtRemplazarPor.TabIndex = 105
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.TabPage2.Controls.Add(Me.RequerimientoTextBox)
        Me.TabPage2.Controls.Add(RequerimientoLabel)
        Me.TabPage2.Controls.Add(Me.OrdenDePeticionTextBox)
        Me.TabPage2.Controls.Add(EnunciadoLabel)
        Me.TabPage2.Controls.Add(OrdenDePeticionLabel)
        Me.TabPage2.Controls.Add(Me.EnunciadoTextBox)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(730, 549)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Requerimientos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RequerimientoTextBox
        '
        Me.RequerimientoTextBox.Location = New System.Drawing.Point(7, 148)
        Me.RequerimientoTextBox.Name = "RequerimientoTextBox"
        Me.RequerimientoTextBox.Size = New System.Drawing.Size(669, 24)
        Me.RequerimientoTextBox.TabIndex = 113
        '
        'OrdenDePeticionTextBox
        '
        Me.OrdenDePeticionTextBox.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdenDePeticionTextBox.Location = New System.Drawing.Point(682, 148)
        Me.OrdenDePeticionTextBox.Name = "OrdenDePeticionTextBox"
        Me.OrdenDePeticionTextBox.Size = New System.Drawing.Size(40, 27)
        Me.OrdenDePeticionTextBox.TabIndex = 115
        Me.OrdenDePeticionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EnunciadoTextBox
        '
        Me.EnunciadoTextBox.Location = New System.Drawing.Point(7, 69)
        Me.EnunciadoTextBox.Multiline = True
        Me.EnunciadoTextBox.Name = "EnunciadoTextBox"
        Me.EnunciadoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EnunciadoTextBox.Size = New System.Drawing.Size(717, 48)
        Me.EnunciadoTextBox.TabIndex = 117
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
        Me.Panel5.Size = New System.Drawing.Size(717, 41)
        Me.Panel5.TabIndex = 111
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
        Me.TableAdapterManager.SP_Componentes_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tecnologias_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tecnologias_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.TecnologiasTableAdapter = Me.TecnologiasTableAdapter
        Me.TableAdapterManager.UpdateOrder = PLE.DataSetPlantillasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_Tecnologias_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_Tecnologias_EDICION_ACTUALIZARBindingSource.DataMember = "SP_Tecnologias_EDICION_ACTUALIZAR"
        Me.SP_Tecnologias_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_Tecnologias_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_Tecnologias_EDICION_ELIMINARBindingSource
        '
        Me.SP_Tecnologias_EDICION_ELIMINARBindingSource.DataMember = "SP_Tecnologias_EDICION_ELIMINAR"
        Me.SP_Tecnologias_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_Tecnologias_EDICION_ELIMINARTableAdapter
        '
        Me.SP_Tecnologias_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_Tecnologias_EDICION_INSERTARBindingSource
        '
        Me.SP_Tecnologias_EDICION_INSERTARBindingSource.DataMember = "SP_Tecnologias_EDICION_INSERTAR"
        Me.SP_Tecnologias_EDICION_INSERTARBindingSource.DataSource = Me.DataSetPlantillas
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
        Me.SP_Plantillas_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_Plantillas_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_Plantillas_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_Plantillas_EDICION_ELIMINARBindingSource
        '
        Me.SP_Plantillas_EDICION_ELIMINARBindingSource.DataMember = "SP_Plantillas_EDICION_ELIMINAR"
        Me.SP_Plantillas_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_Plantillas_EDICION_ELIMINARTableAdapter
        '
        Me.SP_Plantillas_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_Plantillas_EDICION_INSERTARBindingSource
        '
        Me.SP_Plantillas_EDICION_INSERTARBindingSource.DataMember = "SP_Plantillas_EDICION_INSERTAR"
        Me.SP_Plantillas_EDICION_INSERTARBindingSource.DataSource = Me.DataSetPlantillas
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
        Me.SP_Componentes_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_Componentes_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_Componentes_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_Componentes_EDICION_ELIMINARBindingSource
        '
        Me.SP_Componentes_EDICION_ELIMINARBindingSource.DataMember = "SP_Componentes_EDICION_ELIMINAR"
        Me.SP_Componentes_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_Componentes_EDICION_ELIMINARTableAdapter
        '
        Me.SP_Componentes_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_Componentes_EDICION_INSERTARBindingSource
        '
        Me.SP_Componentes_EDICION_INSERTARBindingSource.DataMember = "SP_Componentes_EDICION_INSERTAR"
        Me.SP_Componentes_EDICION_INSERTARBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_Componentes_EDICION_INSERTARTableAdapter
        '
        Me.SP_Componentes_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource
        '
        Me.SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource.DataMember = "SP_RequerimientosPlantillas_EDICION_INSERTAR"
        Me.SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter
        '
        Me.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource.DataMember = "SP_RequerimientosPlantillas_EDICION_ACTUALIZAR"
        Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource
        '
        Me.SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource.DataMember = "SP_RequerimientosPlantillas_EDICION_ELIMINAR"
        Me.SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter
        '
        Me.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetPlantillas
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(20, 257)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RequerimientoPlantillaID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RequerimientoPlantillaID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PlantillaID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PlantillaID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Enunciado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Enunciado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Requerimiento"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Requerimiento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "OrdenDePeticion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "OrdenDePeticion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Requerimientos"
        '
        'RequerimientoPlantillaIDLabel
        '
        RequerimientoPlantillaIDLabel.AutoSize = True
        RequerimientoPlantillaIDLabel.Location = New System.Drawing.Point(-33, 219)
        RequerimientoPlantillaIDLabel.Name = "RequerimientoPlantillaIDLabel"
        RequerimientoPlantillaIDLabel.Size = New System.Drawing.Size(131, 13)
        RequerimientoPlantillaIDLabel.TabIndex = 14
        RequerimientoPlantillaIDLabel.Text = "Requerimiento Plantilla ID:"
        '
        'RequerimientoPlantillaIDTextBox
        '
        Me.RequerimientoPlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "RequerimientoPlantillaID", True))
        Me.RequerimientoPlantillaIDTextBox.Location = New System.Drawing.Point(104, 216)
        Me.RequerimientoPlantillaIDTextBox.Name = "RequerimientoPlantillaIDTextBox"
        Me.RequerimientoPlantillaIDTextBox.Size = New System.Drawing.Size(51, 20)
        Me.RequerimientoPlantillaIDTextBox.TabIndex = 15
        '
        'FrmPlantillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1497, 585)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_Tecnologias)
        Me.Name = "FrmPlantillas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plantillas de Proyectos"
        Me.Panel_Tecnologias.ResumeLayout(False)
        Me.Panel_Tecnologias.PerformLayout()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPlantillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdministracion_.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVEdicionPosicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
        CType(Me.SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Tecnologias As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSetPlantillas As DataSetPlantillas
    Friend WithEvents TecnologiasBindingSource As BindingSource
    Friend WithEvents TecnologiasTableAdapter As DataSetPlantillasTableAdapters.TecnologiasTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPlantillasTableAdapters.TableAdapterManager
    Friend WithEvents NombreTecnologiaTextBox As TextBox
    Friend WithEvents TecnologiaIDTextBox As TextBox
    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Nuevo_Menu_Tecnologias As Button
    Friend WithEvents Cancelar_Menu_Tecnologias As Button
    Friend WithEvents Eliminar_Menu_Tecnologias As Button
    Friend WithEvents Editar_Menu_Tecnologias As Button
    Friend WithEvents Actualizar_Menu_Tecnologias As Button
    Friend WithEvents Guardar_Menu_Tecnologias As Button
    Friend WithEvents TecnologiasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SP_Tecnologias_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_Tecnologias_EDICION_ACTUALIZARTableAdapter As DataSetPlantillasTableAdapters.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_Tecnologias_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_Tecnologias_EDICION_ELIMINARTableAdapter As DataSetPlantillasTableAdapters.SP_Tecnologias_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_Tecnologias_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_Tecnologias_EDICION_INSERTARTableAdapter As DataSetPlantillasTableAdapters.SP_Tecnologias_EDICION_INSERTARTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents ControlNulos As TextBox
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter As DataSetPlantillasTableAdapters.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ChkMover As CheckBox
    Friend WithEvents BtnBajarFila As Button
    Friend WithEvents Nuevo_Menu_Plantillas As Button
    Friend WithEvents BtnSubirFila As Button
    Friend WithEvents Cancelar_Menu_Plantillas As Button
    Friend WithEvents Eliminar_Menu_Plantillas As Button
    Friend WithEvents Editar_Menu_Plantillas As Button
    Friend WithEvents Actualizar_Menu_Plantillas As Button
    Friend WithEvents Guardar_Menu_Plantillas As Button
    Friend WithEvents DGVEdicionPosicion As DataGridView
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView As DataGridView
    Friend WithEvents Orden As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents OrdenTextBox As TextBox
    Friend WithEvents NombrePlantillaTextBox As TextBox
    Friend WithEvents SP_Plantillas_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_EDICION_ACTUALIZARTableAdapter As DataSetPlantillasTableAdapters.SP_Plantillas_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_Plantillas_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_EDICION_ELIMINARTableAdapter As DataSetPlantillasTableAdapters.SP_Plantillas_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_Plantillas_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_EDICION_INSERTARTableAdapter As DataSetPlantillasTableAdapters.SP_Plantillas_EDICION_INSERTARTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents PlantillaIDTextBox As TextBox
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetPlantillasTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents Panel6 As Panel
    Friend WithEvents XTablaCheckBox As CheckBox
    Friend WithEvents NombreComponenteTextBox As TextBox
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Cancelar_Menu_Componentes As Button
    Friend WithEvents Nuevo_Menu_Componentes As Button
    Friend WithEvents Eliminar_Menu_Componentes As Button
    Friend WithEvents Guardar_Menu_Componentes As Button
    Friend WithEvents Actualizar_Menu_Componentes As Button
    Friend WithEvents Editar_Menu_Componentes As Button
    Friend WithEvents SP_Componentes_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_Componentes_EDICION_ACTUALIZARTableAdapter As DataSetPlantillasTableAdapters.SP_Componentes_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_Componentes_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_Componentes_EDICION_ELIMINARTableAdapter As DataSetPlantillasTableAdapters.SP_Componentes_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_Componentes_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_Componentes_EDICION_INSERTARTableAdapter As DataSetPlantillasTableAdapters.SP_Componentes_EDICION_INSERTARTableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnTablaPluralMinuscula As Button
    Friend WithEvents BtnMayusculaAMinuscula As Button
    Friend WithEvents BtnTablaPlural As Button
    Friend WithEvents BtnTablaMinuscula As Button
    Friend WithEvents BtnImprimeClavePrincipal As Button
    Friend WithEvents BtnImprimeTabla As Button
    Friend WithEvents BtnImprimeCampos As Button
    Friend WithEvents BtnGuardarCodigo As Button
    Friend WithEvents BtnSubirRemplazado As Button
    Friend WithEvents BtnLimpiarRemplazar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents RBPermitirEspacios As RadioButton
    Friend WithEvents BtnRemplazar As Button
    Friend WithEvents BtnBajarFuente As Button
    Friend WithEvents BtnSubirFuente As Button
    Friend WithEvents ContenidoComponenteRichTextBox As RichTextBox
    Friend WithEvents BtnBuscarYPintar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBuscado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRemplazarPor As TextBox
    Friend WithEvents XTablaTextBox As TextBox
    Friend WithEvents ComponenteIDTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnColor As Button
    Friend WithEvents BtnFuentes As Button
    Friend WithEvents BtnDerecha As Button
    Friend WithEvents BtnCentrar As Button
    Friend WithEvents BtnIzquierda As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Nuevo_Menu_RequerimientosPlantillas As Button
    Friend WithEvents Cancelar_Menu_RequerimientosPlantillas As Button
    Friend WithEvents Eliminar_Menu_RequerimientosPlantillas As Button
    Friend WithEvents Editar_Menu_RequerimientosPlantillas As Button
    Friend WithEvents Actualizar_Menu_RequerimientosPlantillas As Button
    Friend WithEvents Guardar_Menu_RequerimientosPlantillas As Button
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter As DataSetPlantillasTableAdapters.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter
    Friend WithEvents RequerimientoTextBox As TextBox
    Friend WithEvents OrdenDePeticionTextBox As TextBox
    Friend WithEvents EnunciadoTextBox As TextBox
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter As DataSetPlantillasTableAdapters.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter As DataSetPlantillasTableAdapters.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetPlantillasTableAdapters.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents RequerimientoPlantillaIDTextBox As TextBox
    Friend WithEvents Label6 As Label
End Class
