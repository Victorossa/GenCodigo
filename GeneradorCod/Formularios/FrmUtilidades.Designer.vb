<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtilidades
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtilidades))
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_ = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_ = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_ = New System.Windows.Forms.Button()
        Me.Editar_Menu_ = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_ = New System.Windows.Forms.Button()
        Me.Guardar_Menu_ = New System.Windows.Forms.Button()
        Me.PanelAdministracion_.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelAdministracion_
        '
        Me.PanelAdministracion_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdministracion_.Controls.Add(Me.Nuevo_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Cancelar_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Eliminar_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Editar_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Actualizar_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Guardar_Menu_)
        Me.PanelAdministracion_.Location = New System.Drawing.Point(261, 202)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(278, 46)
        Me.PanelAdministracion_.TabIndex = 90
        '
        'Nuevo_Menu_
        '
        Me.Nuevo_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_.Image = CType(resources.GetObject("Nuevo_Menu_.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_.Name = "Nuevo_Menu_"
        Me.Nuevo_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_.TabIndex = 70
        Me.Nuevo_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_
        '
        Me.Cancelar_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_.Image = CType(resources.GetObject("Cancelar_Menu_.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_.Name = "Cancelar_Menu_"
        Me.Cancelar_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_.TabIndex = 75
        Me.Cancelar_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_
        '
        Me.Eliminar_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_.Image = CType(resources.GetObject("Eliminar_Menu_.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_.Name = "Eliminar_Menu_"
        Me.Eliminar_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_.TabIndex = 72
        Me.Eliminar_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_.UseVisualStyleBackColor = True
        '
        'Editar_Menu_
        '
        Me.Editar_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_.Image = CType(resources.GetObject("Editar_Menu_.Image"), System.Drawing.Image)
        Me.Editar_Menu_.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_.Name = "Editar_Menu_"
        Me.Editar_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_.TabIndex = 74
        Me.Editar_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_
        '
        Me.Actualizar_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_.Image = CType(resources.GetObject("Actualizar_Menu_.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_.Name = "Actualizar_Menu_"
        Me.Actualizar_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_.TabIndex = 73
        Me.Actualizar_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_
        '
        Me.Guardar_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_.Image = CType(resources.GetObject("Guardar_Menu_.Image"), System.Drawing.Image)
        Me.Guardar_Menu_.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_.Name = "Guardar_Menu_"
        Me.Guardar_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_.TabIndex = 71
        Me.Guardar_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_.UseVisualStyleBackColor = True
        '
        'FrmUtilidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelAdministracion_)
        Me.Name = "FrmUtilidades"
        Me.Text = "FrmUtilidades"
        Me.PanelAdministracion_.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Nuevo_Menu_ As Button
    Friend WithEvents Cancelar_Menu_ As Button
    Friend WithEvents Eliminar_Menu_ As Button
    Friend WithEvents Editar_Menu_ As Button
    Friend WithEvents Actualizar_Menu_ As Button
    Friend WithEvents Guardar_Menu_ As Button
End Class
