﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlertaMsnError
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.icon_error = New System.Windows.Forms.PictureBox()
        Me.TituloAviso = New System.Windows.Forms.Label()
        Me.DescripcionAviso = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.FranjaAbajo = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.icon_error, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.icon_error, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TituloAviso, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionAviso, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAceptar, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FranjaAbajo, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(468, 302)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'icon_error
        '
        Me.icon_error.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.icon_error.Image = Global.UHF_Sample.My.Resources.Resources.eliminar_90
        Me.icon_error.Location = New System.Drawing.Point(189, 27)
        Me.icon_error.Margin = New System.Windows.Forms.Padding(0)
        Me.icon_error.Name = "icon_error"
        Me.icon_error.Size = New System.Drawing.Size(90, 90)
        Me.icon_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon_error.TabIndex = 0
        Me.icon_error.TabStop = False
        '
        'TituloAviso
        '
        Me.TituloAviso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TituloAviso.AutoSize = True
        Me.TituloAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloAviso.Location = New System.Drawing.Point(187, 151)
        Me.TituloAviso.Name = "TituloAviso"
        Me.TituloAviso.Size = New System.Drawing.Size(93, 31)
        Me.TituloAviso.TabIndex = 1
        Me.TituloAviso.Text = "Ups..."
        Me.TituloAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescripcionAviso
        '
        Me.DescripcionAviso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DescripcionAviso.AutoSize = True
        Me.DescripcionAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionAviso.Location = New System.Drawing.Point(167, 203)
        Me.DescripcionAviso.Name = "DescripcionAviso"
        Me.DescripcionAviso.Size = New System.Drawing.Size(134, 22)
        Me.DescripcionAviso.TabIndex = 2
        Me.DescripcionAviso.Text = "¡Algo Salio Mal!"
        Me.DescripcionAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Location = New System.Drawing.Point(178, 243)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(112, 48)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'FranjaAbajo
        '
        Me.FranjaAbajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FranjaAbajo.ColumnCount = 1
        Me.FranjaAbajo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FranjaAbajo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.FranjaAbajo.Location = New System.Drawing.Point(0, 294)
        Me.FranjaAbajo.Margin = New System.Windows.Forms.Padding(0)
        Me.FranjaAbajo.Name = "FranjaAbajo"
        Me.FranjaAbajo.RowCount = 1
        Me.FranjaAbajo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FranjaAbajo.Size = New System.Drawing.Size(468, 8)
        Me.FranjaAbajo.TabIndex = 4
        '
        'FormAlertaMsnError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 302)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAlertaMsnError"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAlertaMsnError"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.icon_error, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents icon_error As PictureBox
    Friend WithEvents TituloAviso As Label
    Friend WithEvents DescripcionAviso As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents FranjaAbajo As TableLayoutPanel
End Class
