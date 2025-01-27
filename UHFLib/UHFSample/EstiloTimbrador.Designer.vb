<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EstiloTimbrador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tablaContenedorTimbrado = New System.Windows.Forms.TableLayoutPanel()
        Me.tablaContenedorLectorRFID = New System.Windows.Forms.TableLayoutPanel()
        Me.MsnVincular = New System.Windows.Forms.Label()
        Me.tablaContenedorCodBarras = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.CodBarras = New System.Windows.Forms.TextBox()
        Me.tablaContenedorRFID = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLimpiarRFID = New System.Windows.Forms.Button()
        Me.dgvTagList = New System.Windows.Forms.DataGridView()
        Me.clnEPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tablaContenedorBtn = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxInventory = New System.Windows.Forms.ComboBox()
        Me.btnStopInventoryEx = New System.Windows.Forms.Button()
        Me.btnStartInventoryEx = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.op = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.corte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subcorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tablaContenedorContadorTimbrado = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.tablaContenedorTimbrado.SuspendLayout()
        Me.tablaContenedorLectorRFID.SuspendLayout()
        Me.tablaContenedorCodBarras.SuspendLayout()
        Me.tablaContenedorRFID.SuspendLayout()
        CType(Me.dgvTagList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tablaContenedorBtn.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tablaContenedorContadorTimbrado.SuspendLayout()
        Me.SuspendLayout()
        '
        'tablaContenedorTimbrado
        '
        Me.tablaContenedorTimbrado.ColumnCount = 2
        Me.tablaContenedorTimbrado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tablaContenedorTimbrado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tablaContenedorTimbrado.Controls.Add(Me.tablaContenedorLectorRFID, 0, 0)
        Me.tablaContenedorTimbrado.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.tablaContenedorTimbrado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaContenedorTimbrado.Location = New System.Drawing.Point(0, 0)
        Me.tablaContenedorTimbrado.Margin = New System.Windows.Forms.Padding(0)
        Me.tablaContenedorTimbrado.Name = "tablaContenedorTimbrado"
        Me.tablaContenedorTimbrado.RowCount = 1
        Me.tablaContenedorTimbrado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaContenedorTimbrado.Size = New System.Drawing.Size(1126, 675)
        Me.tablaContenedorTimbrado.TabIndex = 0
        '
        'tablaContenedorLectorRFID
        '
        Me.tablaContenedorLectorRFID.ColumnCount = 1
        Me.tablaContenedorLectorRFID.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaContenedorLectorRFID.Controls.Add(Me.MsnVincular, 0, 1)
        Me.tablaContenedorLectorRFID.Controls.Add(Me.tablaContenedorCodBarras, 0, 0)
        Me.tablaContenedorLectorRFID.Controls.Add(Me.tablaContenedorRFID, 0, 2)
        Me.tablaContenedorLectorRFID.Controls.Add(Me.tablaContenedorBtn, 0, 3)
        Me.tablaContenedorLectorRFID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaContenedorLectorRFID.Location = New System.Drawing.Point(0, 0)
        Me.tablaContenedorLectorRFID.Margin = New System.Windows.Forms.Padding(0)
        Me.tablaContenedorLectorRFID.Name = "tablaContenedorLectorRFID"
        Me.tablaContenedorLectorRFID.RowCount = 5
        Me.tablaContenedorLectorRFID.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablaContenedorLectorRFID.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.tablaContenedorLectorRFID.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.tablaContenedorLectorRFID.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tablaContenedorLectorRFID.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tablaContenedorLectorRFID.Size = New System.Drawing.Size(450, 675)
        Me.tablaContenedorLectorRFID.TabIndex = 0
        '
        'MsnVincular
        '
        Me.MsnVincular.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MsnVincular.AutoSize = True
        Me.MsnVincular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsnVincular.Location = New System.Drawing.Point(3, 67)
        Me.MsnVincular.Name = "MsnVincular"
        Me.MsnVincular.Size = New System.Drawing.Size(107, 20)
        Me.MsnVincular.TabIndex = 29
        Me.MsnVincular.Text = "MsnVincular"
        Me.MsnVincular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tablaContenedorCodBarras
        '
        Me.tablaContenedorCodBarras.ColumnCount = 2
        Me.tablaContenedorCodBarras.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.tablaContenedorCodBarras.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablaContenedorCodBarras.Controls.Add(Me.btnClear, 0, 0)
        Me.tablaContenedorCodBarras.Controls.Add(Me.CodBarras, 0, 0)
        Me.tablaContenedorCodBarras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaContenedorCodBarras.Location = New System.Drawing.Point(3, 3)
        Me.tablaContenedorCodBarras.Name = "tablaContenedorCodBarras"
        Me.tablaContenedorCodBarras.RowCount = 1
        Me.tablaContenedorCodBarras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaContenedorCodBarras.Size = New System.Drawing.Size(444, 61)
        Me.tablaContenedorCodBarras.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClear.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(336, 18)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 25)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Nuevo Timbrado"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'CodBarras
        '
        Me.CodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodBarras.Location = New System.Drawing.Point(3, 3)
        Me.CodBarras.Name = "CodBarras"
        Me.CodBarras.Size = New System.Drawing.Size(299, 30)
        Me.CodBarras.TabIndex = 26
        '
        'tablaContenedorRFID
        '
        Me.tablaContenedorRFID.ColumnCount = 2
        Me.tablaContenedorRFID.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.tablaContenedorRFID.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablaContenedorRFID.Controls.Add(Me.btnLimpiarRFID, 0, 0)
        Me.tablaContenedorRFID.Controls.Add(Me.dgvTagList, 0, 0)
        Me.tablaContenedorRFID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaContenedorRFID.Location = New System.Drawing.Point(3, 90)
        Me.tablaContenedorRFID.Name = "tablaContenedorRFID"
        Me.tablaContenedorRFID.RowCount = 1
        Me.tablaContenedorRFID.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaContenedorRFID.Size = New System.Drawing.Size(444, 75)
        Me.tablaContenedorRFID.TabIndex = 30
        '
        'btnLimpiarRFID
        '
        Me.btnLimpiarRFID.Location = New System.Drawing.Point(336, 3)
        Me.btnLimpiarRFID.Name = "btnLimpiarRFID"
        Me.btnLimpiarRFID.Size = New System.Drawing.Size(46, 25)
        Me.btnLimpiarRFID.TabIndex = 41
        Me.btnLimpiarRFID.Text = "Limpiar"
        Me.btnLimpiarRFID.UseVisualStyleBackColor = True
        '
        'dgvTagList
        '
        Me.dgvTagList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTagList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnEPC, Me.clnTID, Me.clnCount})
        Me.dgvTagList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTagList.Location = New System.Drawing.Point(3, 3)
        Me.dgvTagList.Name = "dgvTagList"
        Me.dgvTagList.RowTemplate.Height = 24
        Me.dgvTagList.Size = New System.Drawing.Size(327, 69)
        Me.dgvTagList.TabIndex = 40
        '
        'clnEPC
        '
        Me.clnEPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clnEPC.FillWeight = 40.0!
        Me.clnEPC.HeaderText = "RFID"
        Me.clnEPC.Name = "clnEPC"
        Me.clnEPC.ReadOnly = True
        '
        'clnTID
        '
        Me.clnTID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clnTID.FillWeight = 40.0!
        Me.clnTID.HeaderText = "TID"
        Me.clnTID.Name = "clnTID"
        Me.clnTID.ReadOnly = True
        '
        'clnCount
        '
        Me.clnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clnCount.FillWeight = 20.0!
        Me.clnCount.HeaderText = "CANTIDAD"
        Me.clnCount.Name = "clnCount"
        Me.clnCount.ReadOnly = True
        '
        'tablaContenedorBtn
        '
        Me.tablaContenedorBtn.ColumnCount = 3
        Me.tablaContenedorBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tablaContenedorBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tablaContenedorBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tablaContenedorBtn.Controls.Add(Me.btnStartInventoryEx, 0, 0)
        Me.tablaContenedorBtn.Controls.Add(Me.cbxInventory, 0, 0)
        Me.tablaContenedorBtn.Controls.Add(Me.btnStopInventoryEx, 2, 0)
        Me.tablaContenedorBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaContenedorBtn.Location = New System.Drawing.Point(3, 171)
        Me.tablaContenedorBtn.Name = "tablaContenedorBtn"
        Me.tablaContenedorBtn.RowCount = 1
        Me.tablaContenedorBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaContenedorBtn.Size = New System.Drawing.Size(444, 27)
        Me.tablaContenedorBtn.TabIndex = 31
        '
        'cbxInventory
        '
        Me.cbxInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxInventory.FormattingEnabled = True
        Me.cbxInventory.Location = New System.Drawing.Point(2, 2)
        Me.cbxInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxInventory.Name = "cbxInventory"
        Me.cbxInventory.Size = New System.Drawing.Size(33, 21)
        Me.cbxInventory.TabIndex = 35
        Me.cbxInventory.Visible = False
        '
        'btnStopInventoryEx
        '
        Me.btnStopInventoryEx.Location = New System.Drawing.Point(299, 3)
        Me.btnStopInventoryEx.Name = "btnStopInventoryEx"
        Me.btnStopInventoryEx.Size = New System.Drawing.Size(68, 21)
        Me.btnStopInventoryEx.TabIndex = 36
        Me.btnStopInventoryEx.TabStop = False
        Me.btnStopInventoryEx.Text = "Stop"
        Me.btnStopInventoryEx.UseVisualStyleBackColor = True
        Me.btnStopInventoryEx.Visible = False
        '
        'btnStartInventoryEx
        '
        Me.btnStartInventoryEx.Location = New System.Drawing.Point(153, 3)
        Me.btnStartInventoryEx.Name = "btnStartInventoryEx"
        Me.btnStartInventoryEx.Size = New System.Drawing.Size(67, 21)
        Me.btnStartInventoryEx.TabIndex = 38
        Me.btnStartInventoryEx.TabStop = False
        Me.btnStartInventoryEx.Text = "Start"
        Me.btnStartInventoryEx.UseVisualStyleBackColor = True
        Me.btnStartInventoryEx.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tablaContenedorContadorTimbrado, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(453, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(670, 669)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.op, Me.corte, Me.subcorte, Me.talla, Me.linea, Me.id_talla, Me.fecha})
        Me.TableLayoutPanel2.SetColumnSpan(Me.DataGridView1, 3)
        Me.DataGridView1.Location = New System.Drawing.Point(3, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(664, 460)
        Me.DataGridView1.TabIndex = 38
        '
        'op
        '
        Me.op.HeaderText = "OP"
        Me.op.Name = "op"
        Me.op.ReadOnly = True
        '
        'corte
        '
        Me.corte.HeaderText = "Corte"
        Me.corte.Name = "corte"
        Me.corte.ReadOnly = True
        '
        'subcorte
        '
        Me.subcorte.HeaderText = "Sub Corte"
        Me.subcorte.Name = "subcorte"
        Me.subcorte.ReadOnly = True
        '
        'talla
        '
        Me.talla.HeaderText = "Talla"
        Me.talla.Name = "talla"
        Me.talla.ReadOnly = True
        '
        'linea
        '
        Me.linea.HeaderText = "Linea"
        Me.linea.Name = "linea"
        Me.linea.ReadOnly = True
        '
        'id_talla
        '
        Me.id_talla.HeaderText = "ID"
        Me.id_talla.Name = "id_talla"
        Me.id_talla.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'tablaContenedorContadorTimbrado
        '
        Me.tablaContenedorContadorTimbrado.ColumnCount = 2
        Me.tablaContenedorContadorTimbrado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablaContenedorContadorTimbrado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.tablaContenedorContadorTimbrado.Controls.Add(Me.lblTotalCount, 0, 0)
        Me.tablaContenedorContadorTimbrado.Controls.Add(Me.Label3, 0, 0)
        Me.tablaContenedorContadorTimbrado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaContenedorContadorTimbrado.Location = New System.Drawing.Point(3, 3)
        Me.tablaContenedorContadorTimbrado.Name = "tablaContenedorContadorTimbrado"
        Me.tablaContenedorContadorTimbrado.RowCount = 1
        Me.tablaContenedorContadorTimbrado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaContenedorContadorTimbrado.Size = New System.Drawing.Size(664, 60)
        Me.tablaContenedorContadorTimbrado.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label3.Location = New System.Drawing.Point(3, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Timbradas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotalCount
        '
        Me.lblTotalCount.AutoSize = True
        Me.lblTotalCount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTotalCount.Location = New System.Drawing.Point(169, 40)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(492, 20)
        Me.lblTotalCount.TabIndex = 2
        Me.lblTotalCount.Text = "0"
        Me.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'EstiloTimbrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 675)
        Me.Controls.Add(Me.tablaContenedorTimbrado)
        Me.Name = "EstiloTimbrador"
        Me.Text = "EstiloTimbrador"
        Me.tablaContenedorTimbrado.ResumeLayout(False)
        Me.tablaContenedorLectorRFID.ResumeLayout(False)
        Me.tablaContenedorLectorRFID.PerformLayout()
        Me.tablaContenedorCodBarras.ResumeLayout(False)
        Me.tablaContenedorCodBarras.PerformLayout()
        Me.tablaContenedorRFID.ResumeLayout(False)
        CType(Me.dgvTagList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tablaContenedorBtn.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tablaContenedorContadorTimbrado.ResumeLayout(False)
        Me.tablaContenedorContadorTimbrado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tablaContenedorTimbrado As TableLayoutPanel
    Friend WithEvents tablaContenedorLectorRFID As TableLayoutPanel
    Friend WithEvents tablaContenedorCodBarras As TableLayoutPanel
    Friend WithEvents CodBarras As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents MsnVincular As Label
    Friend WithEvents tablaContenedorRFID As TableLayoutPanel
    Friend WithEvents dgvTagList As DataGridView
    Friend WithEvents clnEPC As DataGridViewTextBoxColumn
    Friend WithEvents clnTID As DataGridViewTextBoxColumn
    Friend WithEvents clnCount As DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiarRFID As Button
    Friend WithEvents tablaContenedorBtn As TableLayoutPanel
    Friend WithEvents cbxInventory As ComboBox
    Friend WithEvents btnStopInventoryEx As Button
    Friend WithEvents btnStartInventoryEx As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents op As DataGridViewTextBoxColumn
    Friend WithEvents corte As DataGridViewTextBoxColumn
    Friend WithEvents subcorte As DataGridViewTextBoxColumn
    Friend WithEvents talla As DataGridViewTextBoxColumn
    Friend WithEvents linea As DataGridViewTextBoxColumn
    Friend WithEvents id_talla As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents tablaContenedorContadorTimbrado As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalCount As Label
End Class
