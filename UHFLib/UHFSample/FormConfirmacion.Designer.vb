<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfirmacion
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
        Me.tbContConfirmacion = New System.Windows.Forms.TableLayoutPanel()
        Me.TituloAviso = New System.Windows.Forms.Label()
        Me.DescripcionAviso = New System.Windows.Forms.Label()
        Me.FranjaAbajo = New System.Windows.Forms.TableLayoutPanel()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbContConfirmacion.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbContConfirmacion
        '
        Me.tbContConfirmacion.ColumnCount = 1
        Me.tbContConfirmacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbContConfirmacion.Controls.Add(Me.TituloAviso, 0, 1)
        Me.tbContConfirmacion.Controls.Add(Me.DescripcionAviso, 0, 2)
        Me.tbContConfirmacion.Controls.Add(Me.FranjaAbajo, 0, 4)
        Me.tbContConfirmacion.Controls.Add(Me.tableLayoutPanel2, 0, 3)
        Me.tbContConfirmacion.Controls.Add(Me.pictureBox1, 0, 0)
        Me.tbContConfirmacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbContConfirmacion.Location = New System.Drawing.Point(0, 0)
        Me.tbContConfirmacion.Name = "tbContConfirmacion"
        Me.tbContConfirmacion.RowCount = 5
        Me.tbContConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tbContConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tbContConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tbContConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tbContConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tbContConfirmacion.Size = New System.Drawing.Size(454, 310)
        Me.tbContConfirmacion.TabIndex = 4
        '
        'TituloAviso
        '
        Me.TituloAviso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TituloAviso.AutoSize = True
        Me.TituloAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloAviso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TituloAviso.Location = New System.Drawing.Point(126, 159)
        Me.TituloAviso.Name = "TituloAviso"
        Me.TituloAviso.Size = New System.Drawing.Size(202, 31)
        Me.TituloAviso.TabIndex = 1
        Me.TituloAviso.Text = "¿Está seguro?"
        Me.TituloAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescripcionAviso
        '
        Me.DescripcionAviso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DescripcionAviso.AutoSize = True
        Me.DescripcionAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionAviso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DescripcionAviso.Location = New System.Drawing.Point(125, 216)
        Me.DescripcionAviso.Name = "DescripcionAviso"
        Me.DescripcionAviso.Size = New System.Drawing.Size(203, 22)
        Me.DescripcionAviso.TabIndex = 2
        Me.DescripcionAviso.Text = "¡No podrás revertir esto!"
        Me.DescripcionAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FranjaAbajo
        '
        Me.FranjaAbajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FranjaAbajo.ColumnCount = 1
        Me.FranjaAbajo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FranjaAbajo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.FranjaAbajo.Location = New System.Drawing.Point(0, 305)
        Me.FranjaAbajo.Margin = New System.Windows.Forms.Padding(0)
        Me.FranjaAbajo.Name = "FranjaAbajo"
        Me.FranjaAbajo.RowCount = 1
        Me.FranjaAbajo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FranjaAbajo.Size = New System.Drawing.Size(454, 5)
        Me.FranjaAbajo.TabIndex = 4
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.btnAceptar, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.btnCancelar, 1, 0)
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(0, 255)
        Me.tableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(454, 50)
        Me.tableLayoutPanel2.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAceptar.AutoSize = True
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(34, 5)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.btnAceptar.Size = New System.Drawing.Size(158, 40)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Si, Desvincular"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(269, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.btnCancelar.Size = New System.Drawing.Size(142, 40)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "No, Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox1.Location = New System.Drawing.Point(177, 25)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.pictureBox1.TabIndex = 6
        Me.pictureBox1.TabStop = False
        '
        'FormConfirmacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 310)
        Me.Controls.Add(Me.tbContConfirmacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormConfirmacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormConfirmacion"
        Me.tbContConfirmacion.ResumeLayout(False)
        Me.tbContConfirmacion.PerformLayout()
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbContConfirmacion As TableLayoutPanel
    Friend WithEvents TituloAviso As Label
    Friend WithEvents DescripcionAviso As Label
    Friend WithEvents FranjaAbajo As TableLayoutPanel
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents btnAceptar As Button
    Private WithEvents btnCancelar As Button
    Private WithEvents pictureBox1 As PictureBox
End Class
