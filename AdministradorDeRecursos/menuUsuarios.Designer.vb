<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuUsuarios
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
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.listaUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnDesactivar = New System.Windows.Forms.Button()
        CType(Me.listaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(597, 378)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(116, 31)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "Crear Usuario"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lista de los usuarios"
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(69, 378)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'listaUsuarios
        '
        Me.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaUsuarios.Location = New System.Drawing.Point(69, 107)
        Me.listaUsuarios.Name = "listaUsuarios"
        Me.listaUsuarios.Size = New System.Drawing.Size(555, 239)
        Me.listaUsuarios.TabIndex = 3
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(692, 107)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(127, 40)
        Me.btnActualizar.TabIndex = 4
        Me.btnActualizar.Text = "Actualizar Usuario"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnDesactivar
        '
        Me.btnDesactivar.Location = New System.Drawing.Point(692, 167)
        Me.btnDesactivar.Name = "btnDesactivar"
        Me.btnDesactivar.Size = New System.Drawing.Size(127, 37)
        Me.btnDesactivar.TabIndex = 5
        Me.btnDesactivar.Text = "Desactivar"
        Me.btnDesactivar.UseVisualStyleBackColor = True
        '
        'menuUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(908, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDesactivar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.listaUsuarios)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCrear)
        Me.Name = "menuUsuarios"
        Me.Tag = ""
        Me.Text = "Usuarios"
        CType(Me.listaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCrear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents listaUsuarios As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnDesactivar As Button
End Class
