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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.ComponenteIDTextBox = New System.Windows.Forms.TextBox()
        Me.BtnBuscarYPintar = New System.Windows.Forms.Button()
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
        Me.BtnCambiarCodYGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdministracion_.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        TecnologiaIDLabel.Location = New System.Drawing.Point(604, 326)
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
        PlantillaIDLabel.Location = New System.Drawing.Point(622, 358)
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
        ComponenteIDLabel.Location = New System.Drawing.Point(591, 390)
        ComponenteIDLabel.Name = "ComponenteIDLabel"
        ComponenteIDLabel.Size = New System.Drawing.Size(107, 18)
        ComponenteIDLabel.TabIndex = 97
        ComponenteIDLabel.Text = "Componente ID:"
        '
        'RequerimientoLabel
        '
        RequerimientoLabel.AutoSize = True
        RequerimientoLabel.Location = New System.Drawing.Point(770, 587)
        RequerimientoLabel.Name = "RequerimientoLabel"
        RequerimientoLabel.Size = New System.Drawing.Size(102, 18)
        RequerimientoLabel.TabIndex = 106
        RequerimientoLabel.Text = "Requerimiento:"
        '
        'OrdenDePeticionLabel
        '
        OrdenDePeticionLabel.AutoSize = True
        OrdenDePeticionLabel.Location = New System.Drawing.Point(993, 516)
        OrdenDePeticionLabel.Name = "OrdenDePeticionLabel"
        OrdenDePeticionLabel.Size = New System.Drawing.Size(46, 18)
        OrdenDePeticionLabel.TabIndex = 107
        OrdenDePeticionLabel.Text = "Orden"
        '
        'EnunciadoLabel
        '
        EnunciadoLabel.AutoSize = True
        EnunciadoLabel.Location = New System.Drawing.Point(769, 516)
        EnunciadoLabel.Name = "EnunciadoLabel"
        EnunciadoLabel.Size = New System.Drawing.Size(75, 18)
        EnunciadoLabel.TabIndex = 108
        EnunciadoLabel.Text = "Enunciado:"
        '
        'RequerimientoPlantillaIDLabel
        '
        RequerimientoPlantillaIDLabel.AutoSize = True
        RequerimientoPlantillaIDLabel.Location = New System.Drawing.Point(529, 422)
        RequerimientoPlantillaIDLabel.Name = "RequerimientoPlantillaIDLabel"
        RequerimientoPlantillaIDLabel.Size = New System.Drawing.Size(169, 18)
        RequerimientoPlantillaIDLabel.TabIndex = 110
        RequerimientoPlantillaIDLabel.Text = "Requerimiento Plantilla ID:"
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.TecnologiaIDTextBox.Location = New System.Drawing.Point(704, 323)
        Me.TecnologiaIDTextBox.Name = "TecnologiaIDTextBox"
        Me.TecnologiaIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TecnologiaIDTextBox.TabIndex = 91
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(704, 291)
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
        Me.Panel1.Size = New System.Drawing.Size(294, 640)
        Me.Panel1.TabIndex = 93
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(NombrePlantillaLabel)
        Me.Panel3.Controls.Add(Me.NombrePlantillaTextBox)
        Me.Panel3.Controls.Add(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 219)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(290, 414)
        Me.Panel3.TabIndex = 94
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
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Location = New System.Drawing.Point(0, 100)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Name = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowHeadersVisible = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Size = New System.Drawing.Size(290, 314)
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
        Me.PlantillaIDTextBox.Location = New System.Drawing.Point(704, 355)
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
        Me.Panel6.Size = New System.Drawing.Size(146, 640)
        Me.Panel6.TabIndex = 96
        '
        'NombreComponenteTextBox
        '
        Me.NombreComponenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "NombreComponente", True))
        Me.NombreComponenteTextBox.Location = New System.Drawing.Point(4, 105)
        Me.NombreComponenteTextBox.Multiline = True
        Me.NombreComponenteTextBox.Name = "NombreComponenteTextBox"
        Me.NombreComponenteTextBox.Size = New System.Drawing.Size(139, 96)
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
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(0, 290)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(144, 348)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 97
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NombreComponente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Componente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 142
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(446, 59)
        Me.CodigoTextBox.Multiline = True
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CodigoTextBox.Size = New System.Drawing.Size(593, 178)
        Me.CodigoTextBox.TabIndex = 97
        '
        'ComponenteIDTextBox
        '
        Me.ComponenteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "ComponenteID", True))
        Me.ComponenteIDTextBox.Location = New System.Drawing.Point(704, 387)
        Me.ComponenteIDTextBox.Name = "ComponenteIDTextBox"
        Me.ComponenteIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ComponenteIDTextBox.TabIndex = 98
        '
        'BtnBuscarYPintar
        '
        Me.BtnBuscarYPintar.BackColor = System.Drawing.Color.White
        Me.BtnBuscarYPintar.Image = CType(resources.GetObject("BtnBuscarYPintar.Image"), System.Drawing.Image)
        Me.BtnBuscarYPintar.Location = New System.Drawing.Point(996, 590)
        Me.BtnBuscarYPintar.Name = "BtnBuscarYPintar"
        Me.BtnBuscarYPintar.Size = New System.Drawing.Size(49, 44)
        Me.BtnBuscarYPintar.TabIndex = 99
        Me.BtnBuscarYPintar.UseVisualStyleBackColor = False
        '
        'TxtBuscado
        '
        Me.TxtBuscado.Location = New System.Drawing.Point(446, 27)
        Me.TxtBuscado.Name = "TxtBuscado"
        Me.TxtBuscado.Size = New System.Drawing.Size(291, 26)
        Me.TxtBuscado.TabIndex = 104
        '
        'TxtRemplazarPor
        '
        Me.TxtRemplazarPor.Location = New System.Drawing.Point(746, 27)
        Me.TxtRemplazarPor.Name = "TxtRemplazarPor"
        Me.TxtRemplazarPor.Size = New System.Drawing.Size(293, 26)
        Me.TxtRemplazarPor.TabIndex = 105
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6})
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(445, 474)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(321, 161)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 107
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Requerimiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Requerimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 317
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1.DataMember = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1.DataSource = Me.DataSetAdministracion
        '
        'RequerimientoTextBox
        '
        Me.RequerimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, "Requerimiento", True))
        Me.RequerimientoTextBox.Location = New System.Drawing.Point(772, 608)
        Me.RequerimientoTextBox.Multiline = True
        Me.RequerimientoTextBox.Name = "RequerimientoTextBox"
        Me.RequerimientoTextBox.Size = New System.Drawing.Size(221, 26)
        Me.RequerimientoTextBox.TabIndex = 107
        '
        'OrdenDePeticionTextBox
        '
        Me.OrdenDePeticionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, "OrdenDePeticion", True))
        Me.OrdenDePeticionTextBox.Location = New System.Drawing.Point(999, 536)
        Me.OrdenDePeticionTextBox.Name = "OrdenDePeticionTextBox"
        Me.OrdenDePeticionTextBox.Size = New System.Drawing.Size(40, 26)
        Me.OrdenDePeticionTextBox.TabIndex = 108
        '
        'EnunciadoTextBox
        '
        Me.EnunciadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1, "Enunciado", True))
        Me.EnunciadoTextBox.Location = New System.Drawing.Point(772, 536)
        Me.EnunciadoTextBox.Multiline = True
        Me.EnunciadoTextBox.Name = "EnunciadoTextBox"
        Me.EnunciadoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EnunciadoTextBox.Size = New System.Drawing.Size(221, 48)
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
        Me.Panel5.Location = New System.Drawing.Point(772, 474)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(267, 41)
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
        Me.RequerimientoPlantillaIDTextBox.Location = New System.Drawing.Point(704, 419)
        Me.RequerimientoPlantillaIDTextBox.Name = "RequerimientoPlantillaIDTextBox"
        Me.RequerimientoPlantillaIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RequerimientoPlantillaIDTextBox.TabIndex = 111
        '
        'BtnCambiarCodYGuardar
        '
        Me.BtnCambiarCodYGuardar.Location = New System.Drawing.Point(891, 3)
        Me.BtnCambiarCodYGuardar.Name = "BtnCambiarCodYGuardar"
        Me.BtnCambiarCodYGuardar.Size = New System.Drawing.Size(148, 23)
        Me.BtnCambiarCodYGuardar.TabIndex = 112
        Me.BtnCambiarCodYGuardar.Text = "Cambiar y Actualizar"
        Me.BtnCambiarCodYGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(449, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Buscar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(746, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Remplazar por:"
        '
        'FrmTecnologias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 640)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCambiarCodYGuardar)
        Me.Controls.Add(RequerimientoPlantillaIDLabel)
        Me.Controls.Add(Me.RequerimientoPlantillaIDTextBox)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(EnunciadoLabel)
        Me.Controls.Add(Me.EnunciadoTextBox)
        Me.Controls.Add(OrdenDePeticionLabel)
        Me.Controls.Add(Me.OrdenDePeticionTextBox)
        Me.Controls.Add(RequerimientoLabel)
        Me.Controls.Add(Me.RequerimientoTextBox)
        Me.Controls.Add(Me.TxtRemplazarPor)
        Me.Controls.Add(Me.TxtBuscado)
        Me.Controls.Add(Me.BtnBuscarYPintar)
        Me.Controls.Add(ComponenteIDLabel)
        Me.Controls.Add(Me.ComponenteIDTextBox)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(PlantillaIDLabel)
        Me.Controls.Add(Me.PlantillaIDTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ControlNulos)
        Me.Controls.Add(TecnologiaIDLabel)
        Me.Controls.Add(Me.TecnologiaIDTextBox)
        Me.Controls.Add(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
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
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents SP_Componentes_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_Componentes_EDICION_ACTUALIZARTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_Componentes_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_Componentes_EDICION_ELIMINARTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_Componentes_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_Componentes_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_EDICION_INSERTARTableAdapter
    Friend WithEvents ComponenteIDTextBox As TextBox
    Friend WithEvents BtnBuscarYPintar As Button
    Friend WithEvents TxtBuscado As TextBox
    Friend WithEvents TxtRemplazarPor As TextBox
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource1 As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents RequerimientoTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
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
    Friend WithEvents BtnCambiarCodYGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
