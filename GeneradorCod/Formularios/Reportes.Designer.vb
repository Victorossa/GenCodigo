<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes
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
        Dim ProyectoIDLabel As System.Windows.Forms.Label
        Dim NombreProyectoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim NombreProyectoLabel2 As System.Windows.Forms.Label
        Dim CANT_ENTIDADESLabel As System.Windows.Forms.Label
        Dim TIEMPO_FALSELabel As System.Windows.Forms.Label
        Dim TIEMPO_TRUELabel As System.Windows.Forms.Label
        Dim GranTotalLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SP_Proyectos_SEGUN_ProyectoIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetReportes = New GeneradorCod.DataSetReportes()
        Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Vista_Para_Metricas_Suma_TrueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_Cant_Tablas_ProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Vista_Para_Metricas_Suma_FalseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAdministracion = New GeneradorCod.DataSetAdministracion()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager = New GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager()
        Me.ProyectosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProyectoIDTextBox = New System.Windows.Forms.TextBox()
        Me.NombreProyectoLabel1 = New System.Windows.Forms.Label()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.NombreProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.CANT_ENTIDADESTextBox = New System.Windows.Forms.TextBox()
        Me.TIEMPO_FALSETextBox = New System.Windows.Forms.TextBox()
        Me.TIEMPO_TRUETextBox = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_Proyectos_SEGUN_ProyectoIDTableAdapter = New GeneradorCod.DataSetReportesTableAdapters.SP_Proyectos_SEGUN_ProyectoIDTableAdapter()
        Me.TableAdapterManager1 = New GeneradorCod.DataSetReportesTableAdapters.TableAdapterManager()
        Me.SP_TablasDeProyecto_Cant_Tablas_ProyectoTableAdapter = New GeneradorCod.DataSetReportesTableAdapters.SP_TablasDeProyecto_Cant_Tablas_ProyectoTableAdapter()
        Me.SP_Vista_Para_Metricas_Suma_FalseTableAdapter = New GeneradorCod.DataSetReportesTableAdapters.SP_Vista_Para_Metricas_Suma_FalseTableAdapter()
        Me.SP_Vista_Para_Metricas_Suma_TrueTableAdapter = New GeneradorCod.DataSetReportesTableAdapters.SP_Vista_Para_Metricas_Suma_TrueTableAdapter()
        Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOTableAdapter = New GeneradorCod.DataSetReportesTableAdapters.SP_TOTALIZA_TIEMPO_POR_PROYECTOTableAdapter()
        Me.GranTotalTextBox = New System.Windows.Forms.TextBox()
        ProyectoIDLabel = New System.Windows.Forms.Label()
        NombreProyectoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        NombreProyectoLabel2 = New System.Windows.Forms.Label()
        CANT_ENTIDADESLabel = New System.Windows.Forms.Label()
        TIEMPO_FALSELabel = New System.Windows.Forms.Label()
        TIEMPO_TRUELabel = New System.Windows.Forms.Label()
        GranTotalLabel = New System.Windows.Forms.Label()
        CType(Me.SP_Proyectos_SEGUN_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Vista_Para_Metricas_Suma_TrueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_Cant_Tablas_ProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Vista_Para_Metricas_Suma_FalseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProyectoIDLabel
        '
        ProyectoIDLabel.AutoSize = True
        ProyectoIDLabel.Location = New System.Drawing.Point(629, 329)
        ProyectoIDLabel.Name = "ProyectoIDLabel"
        ProyectoIDLabel.Size = New System.Drawing.Size(66, 13)
        ProyectoIDLabel.TabIndex = 1
        ProyectoIDLabel.Text = "Proyecto ID:"
        '
        'NombreProyectoLabel
        '
        NombreProyectoLabel.AutoSize = True
        NombreProyectoLabel.Font = New System.Drawing.Font("Candara Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreProyectoLabel.Location = New System.Drawing.Point(12, 9)
        NombreProyectoLabel.Name = "NombreProyectoLabel"
        NombreProyectoLabel.Size = New System.Drawing.Size(158, 23)
        NombreProyectoLabel.TabIndex = 3
        NombreProyectoLabel.Text = "Nombre Proyecto:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Candara Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(12, 285)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(73, 15)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'NombreProyectoLabel2
        '
        NombreProyectoLabel2.AutoSize = True
        NombreProyectoLabel2.Location = New System.Drawing.Point(603, 355)
        NombreProyectoLabel2.Name = "NombreProyectoLabel2"
        NombreProyectoLabel2.Size = New System.Drawing.Size(92, 13)
        NombreProyectoLabel2.TabIndex = 9
        NombreProyectoLabel2.Text = "Nombre Proyecto:"
        '
        'CANT_ENTIDADESLabel
        '
        CANT_ENTIDADESLabel.AutoSize = True
        CANT_ENTIDADESLabel.Location = New System.Drawing.Point(591, 381)
        CANT_ENTIDADESLabel.Name = "CANT_ENTIDADESLabel"
        CANT_ENTIDADESLabel.Size = New System.Drawing.Size(104, 13)
        CANT_ENTIDADESLabel.TabIndex = 11
        CANT_ENTIDADESLabel.Text = "CANT ENTIDADES:"
        '
        'TIEMPO_FALSELabel
        '
        TIEMPO_FALSELabel.AutoSize = True
        TIEMPO_FALSELabel.Location = New System.Drawing.Point(608, 407)
        TIEMPO_FALSELabel.Name = "TIEMPO_FALSELabel"
        TIEMPO_FALSELabel.Size = New System.Drawing.Size(87, 13)
        TIEMPO_FALSELabel.TabIndex = 13
        TIEMPO_FALSELabel.Text = "TIEMPO FALSE:"
        '
        'TIEMPO_TRUELabel
        '
        TIEMPO_TRUELabel.AutoSize = True
        TIEMPO_TRUELabel.Location = New System.Drawing.Point(611, 433)
        TIEMPO_TRUELabel.Name = "TIEMPO_TRUELabel"
        TIEMPO_TRUELabel.Size = New System.Drawing.Size(84, 13)
        TIEMPO_TRUELabel.TabIndex = 16
        TIEMPO_TRUELabel.Text = "TIEMPO TRUE:"
        '
        'GranTotalLabel
        '
        GranTotalLabel.AutoSize = True
        GranTotalLabel.Location = New System.Drawing.Point(635, 459)
        GranTotalLabel.Name = "GranTotalLabel"
        GranTotalLabel.Size = New System.Drawing.Size(60, 13)
        GranTotalLabel.TabIndex = 19
        GranTotalLabel.Text = "Gran Total:"
        '
        'SP_Proyectos_SEGUN_ProyectoIDBindingSource
        '
        Me.SP_Proyectos_SEGUN_ProyectoIDBindingSource.DataMember = "SP_Proyectos_SEGUN_ProyectoID"
        Me.SP_Proyectos_SEGUN_ProyectoIDBindingSource.DataSource = Me.DataSetReportes
        '
        'DataSetReportes
        '
        Me.DataSetReportes.DataSetName = "DataSetReportes"
        Me.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_TOTALIZA_TIEMPO_POR_PROYECTOBindingSource
        '
        Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOBindingSource.DataMember = "SP_TOTALIZA_TIEMPO_POR_PROYECTO"
        Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOBindingSource.DataSource = Me.DataSetReportes
        '
        'SP_Vista_Para_Metricas_Suma_TrueBindingSource
        '
        Me.SP_Vista_Para_Metricas_Suma_TrueBindingSource.DataMember = "SP_Vista_Para_Metricas_Suma_True"
        Me.SP_Vista_Para_Metricas_Suma_TrueBindingSource.DataSource = Me.DataSetReportes
        '
        'SP_TablasDeProyecto_Cant_Tablas_ProyectoBindingSource
        '
        Me.SP_TablasDeProyecto_Cant_Tablas_ProyectoBindingSource.DataMember = "SP_TablasDeProyecto_Cant_Tablas_Proyecto"
        Me.SP_TablasDeProyecto_Cant_Tablas_ProyectoBindingSource.DataSource = Me.DataSetReportes
        '
        'SP_Vista_Para_Metricas_Suma_FalseBindingSource
        '
        Me.SP_Vista_Para_Metricas_Suma_FalseBindingSource.DataMember = "SP_Vista_Para_Metricas_Suma_False"
        Me.SP_Vista_Para_Metricas_Suma_FalseBindingSource.DataSource = Me.DataSetReportes
        '
        'DataSetAdministracion
        '
        Me.DataSetAdministracion.DataSetName = "DataSetAdministracion"
        Me.DataSetAdministracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DataSetAdministracion
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ELIMINA_SEGUN_PROYECTOTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasMetricas_EDICION_EDITAR_SEGUN_PLANTILLATableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasMetricas_EDICION_INSERTARTableAdapter = Nothing
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
        Me.TableAdapterManager.TecnologiasTableAdapter = Nothing
        Me.TableAdapterManager.TiposTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProyectosDataGridView
        '
        Me.ProyectosDataGridView.AllowUserToAddRows = False
        Me.ProyectosDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProyectosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.ProyectosDataGridView.DataSource = Me.ProyectosBindingSource
        Me.ProyectosDataGridView.Location = New System.Drawing.Point(12, 98)
        Me.ProyectosDataGridView.Name = "ProyectosDataGridView"
        Me.ProyectosDataGridView.RowHeadersVisible = False
        Me.ProyectosDataGridView.Size = New System.Drawing.Size(334, 184)
        Me.ProyectosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreProyecto"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Proyecto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 330
        '
        'ProyectoIDTextBox
        '
        Me.ProyectoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "ProyectoID", True))
        Me.ProyectoIDTextBox.Location = New System.Drawing.Point(701, 326)
        Me.ProyectoIDTextBox.Name = "ProyectoIDTextBox"
        Me.ProyectoIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProyectoIDTextBox.TabIndex = 2
        '
        'NombreProyectoLabel1
        '
        Me.NombreProyectoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "NombreProyecto", True))
        Me.NombreProyectoLabel1.Font = New System.Drawing.Font("Candara Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreProyectoLabel1.Location = New System.Drawing.Point(12, 32)
        Me.NombreProyectoLabel1.Name = "NombreProyectoLabel1"
        Me.NombreProyectoLabel1.Size = New System.Drawing.Size(334, 63)
        Me.NombreProyectoLabel1.TabIndex = 4
        Me.NombreProyectoLabel1.Text = "..."
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Candara Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(12, 303)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(334, 218)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'NombreProyectoTextBox
        '
        Me.NombreProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Proyectos_SEGUN_ProyectoIDBindingSource, "NombreProyecto", True))
        Me.NombreProyectoTextBox.Location = New System.Drawing.Point(701, 352)
        Me.NombreProyectoTextBox.Name = "NombreProyectoTextBox"
        Me.NombreProyectoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreProyectoTextBox.TabIndex = 10
        '
        'CANT_ENTIDADESTextBox
        '
        Me.CANT_ENTIDADESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_Cant_Tablas_ProyectoBindingSource, "CANT_ENTIDADES", True))
        Me.CANT_ENTIDADESTextBox.Location = New System.Drawing.Point(701, 378)
        Me.CANT_ENTIDADESTextBox.Name = "CANT_ENTIDADESTextBox"
        Me.CANT_ENTIDADESTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CANT_ENTIDADESTextBox.TabIndex = 12
        '
        'TIEMPO_FALSETextBox
        '
        Me.TIEMPO_FALSETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Vista_Para_Metricas_Suma_FalseBindingSource, "TIEMPO_FALSE", True))
        Me.TIEMPO_FALSETextBox.Location = New System.Drawing.Point(701, 404)
        Me.TIEMPO_FALSETextBox.Name = "TIEMPO_FALSETextBox"
        Me.TIEMPO_FALSETextBox.Size = New System.Drawing.Size(100, 20)
        Me.TIEMPO_FALSETextBox.TabIndex = 14
        '
        'TIEMPO_TRUETextBox
        '
        Me.TIEMPO_TRUETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Vista_Para_Metricas_Suma_TrueBindingSource, "TIEMPO_TRUE", True))
        Me.TIEMPO_TRUETextBox.Location = New System.Drawing.Point(701, 430)
        Me.TIEMPO_TRUETextBox.Name = "TIEMPO_TRUETextBox"
        Me.TIEMPO_TRUETextBox.Size = New System.Drawing.Size(100, 20)
        Me.TIEMPO_TRUETextBox.TabIndex = 17
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_Proyectos_SEGUN_ProyectoIDBindingSource
        ReportDataSource2.Name = "DS_TotalTiempo"
        ReportDataSource2.Value = Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOBindingSource
        ReportDataSource3.Name = "DataSet2"
        ReportDataSource3.Value = Me.SP_Vista_Para_Metricas_Suma_TrueBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GeneradorCod.ReportEstimacion.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(352, 32)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(799, 489)
        Me.ReportViewer1.TabIndex = 18
        '
        'SP_Proyectos_SEGUN_ProyectoIDTableAdapter
        '
        Me.SP_Proyectos_SEGUN_ProyectoIDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = GeneradorCod.DataSetReportesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_TablasDeProyecto_Cant_Tablas_ProyectoTableAdapter
        '
        Me.SP_TablasDeProyecto_Cant_Tablas_ProyectoTableAdapter.ClearBeforeFill = True
        '
        'SP_Vista_Para_Metricas_Suma_FalseTableAdapter
        '
        Me.SP_Vista_Para_Metricas_Suma_FalseTableAdapter.ClearBeforeFill = True
        '
        'SP_Vista_Para_Metricas_Suma_TrueTableAdapter
        '
        Me.SP_Vista_Para_Metricas_Suma_TrueTableAdapter.ClearBeforeFill = True
        '
        'SP_TOTALIZA_TIEMPO_POR_PROYECTOTableAdapter
        '
        Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOTableAdapter.ClearBeforeFill = True
        '
        'GranTotalTextBox
        '
        Me.GranTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOBindingSource, "GranTotal", True))
        Me.GranTotalTextBox.Location = New System.Drawing.Point(701, 456)
        Me.GranTotalTextBox.Name = "GranTotalTextBox"
        Me.GranTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GranTotalTextBox.TabIndex = 20
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 541)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(GranTotalLabel)
        Me.Controls.Add(Me.GranTotalTextBox)
        Me.Controls.Add(TIEMPO_TRUELabel)
        Me.Controls.Add(Me.TIEMPO_TRUETextBox)
        Me.Controls.Add(TIEMPO_FALSELabel)
        Me.Controls.Add(Me.TIEMPO_FALSETextBox)
        Me.Controls.Add(CANT_ENTIDADESLabel)
        Me.Controls.Add(Me.CANT_ENTIDADESTextBox)
        Me.Controls.Add(NombreProyectoLabel2)
        Me.Controls.Add(Me.NombreProyectoTextBox)
        Me.Controls.Add(Me.ProyectosDataGridView)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(NombreProyectoLabel)
        Me.Controls.Add(Me.NombreProyectoLabel1)
        Me.Controls.Add(ProyectoIDLabel)
        Me.Controls.Add(Me.ProyectoIDTextBox)
        Me.Name = "Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.SP_Proyectos_SEGUN_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Vista_Para_Metricas_Suma_TrueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_Cant_Tablas_ProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Vista_Para_Metricas_Suma_FalseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetAdministracion As DataSetAdministracion
    Friend WithEvents ProyectosBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As DataSetAdministracionTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAdministracionTableAdapters.TableAdapterManager
    Friend WithEvents ProyectosDataGridView As DataGridView
    Friend WithEvents ProyectoIDTextBox As TextBox
    Friend WithEvents NombreProyectoLabel1 As Label
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataSetReportes As DataSetReportes
    Friend WithEvents SP_Proyectos_SEGUN_ProyectoIDBindingSource As BindingSource
    Friend WithEvents SP_Proyectos_SEGUN_ProyectoIDTableAdapter As DataSetReportesTableAdapters.SP_Proyectos_SEGUN_ProyectoIDTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSetReportesTableAdapters.TableAdapterManager
    Friend WithEvents NombreProyectoTextBox As TextBox
    Friend WithEvents SP_TablasDeProyecto_Cant_Tablas_ProyectoBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_Cant_Tablas_ProyectoTableAdapter As DataSetReportesTableAdapters.SP_TablasDeProyecto_Cant_Tablas_ProyectoTableAdapter
    Friend WithEvents CANT_ENTIDADESTextBox As TextBox
    Friend WithEvents SP_Vista_Para_Metricas_Suma_FalseBindingSource As BindingSource
    Friend WithEvents SP_Vista_Para_Metricas_Suma_FalseTableAdapter As DataSetReportesTableAdapters.SP_Vista_Para_Metricas_Suma_FalseTableAdapter
    Friend WithEvents TIEMPO_FALSETextBox As TextBox
    Friend WithEvents SP_Vista_Para_Metricas_Suma_TrueBindingSource As BindingSource
    Friend WithEvents SP_Vista_Para_Metricas_Suma_TrueTableAdapter As DataSetReportesTableAdapters.SP_Vista_Para_Metricas_Suma_TrueTableAdapter
    Friend WithEvents TIEMPO_TRUETextBox As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_TOTALIZA_TIEMPO_POR_PROYECTOBindingSource As BindingSource
    Friend WithEvents SP_TOTALIZA_TIEMPO_POR_PROYECTOTableAdapter As DataSetReportesTableAdapters.SP_TOTALIZA_TIEMPO_POR_PROYECTOTableAdapter
    Friend WithEvents GranTotalTextBox As TextBox
End Class
