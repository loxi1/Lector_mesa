<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTrabajador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodTrabajador = New System.Windows.Forms.TextBox()
        Me.ClaveTrabajador = New System.Windows.Forms.TextBox()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.buttonCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código Trabajador :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password :"
        '
        'txtCodTrabajador
        '
        Me.txtCodTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTrabajador.Location = New System.Drawing.Point(287, 13)
        Me.txtCodTrabajador.Name = "txtCodTrabajador"
        Me.txtCodTrabajador.Size = New System.Drawing.Size(180, 38)
        Me.txtCodTrabajador.TabIndex = 0
        '
        'ClaveTrabajador
        '
        Me.ClaveTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClaveTrabajador.Location = New System.Drawing.Point(287, 60)
        Me.ClaveTrabajador.Name = "ClaveTrabajador"
        Me.ClaveTrabajador.Size = New System.Drawing.Size(180, 38)
        Me.ClaveTrabajador.TabIndex = 1
        '
        'ButtonOk
        '
        Me.ButtonOk.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOk.ForeColor = System.Drawing.Color.White
        Me.ButtonOk.Location = New System.Drawing.Point(115, 135)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(131, 47)
        Me.ButtonOk.TabIndex = 4
        Me.ButtonOk.Text = "Aceptar"
        Me.ButtonOk.UseVisualStyleBackColor = False
        '
        'buttonCancelar
        '
        Me.buttonCancelar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.buttonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonCancelar.ForeColor = System.Drawing.Color.White
        Me.buttonCancelar.Location = New System.Drawing.Point(262, 135)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(148, 47)
        Me.buttonCancelar.TabIndex = 5
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = False
        '
        'FormTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 212)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.ClaveTrabajador)
        Me.Controls.Add(Me.txtCodTrabajador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTrabajador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormTrabajador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodTrabajador As TextBox
    Friend WithEvents ClaveTrabajador As TextBox
    Friend WithEvents ButtonOk As Button
    Friend WithEvents buttonCancelar As Button
End Class
