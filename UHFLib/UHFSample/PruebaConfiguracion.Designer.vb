<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PruebaConfiguracion
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxInventoryEx = New System.Windows.Forms.GroupBox()
        Me.tablaContenedorTimbrado = New System.Windows.Forms.TableLayoutPanel()
        Me.tabaLadoTimbrado = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.op = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.corte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hoja_marcacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subcorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_rfid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLimpiarRFID = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cantidadRFID = New System.Windows.Forms.Label()
        Me.MsnVincular = New System.Windows.Forms.Label()
        Me.dgvTagList = New System.Windows.Forms.DataGridView()
        Me.clnEPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodBarras = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pruebaCodigos = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnStopInventoryEx = New System.Windows.Forms.Button()
        Me.cbxInventory = New System.Windows.Forms.ComboBox()
        Me.btnStartInventoryEx = New System.Windows.Forms.Button()
        Me.gbxInventoryEx.SuspendLayout()
        Me.tablaContenedorTimbrado.SuspendLayout()
        Me.tabaLadoTimbrado.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvTagList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInventoryEx
        '
        Me.gbxInventoryEx.Controls.Add(Me.tablaContenedorTimbrado)
        Me.gbxInventoryEx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxInventoryEx.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.gbxInventoryEx.Location = New System.Drawing.Point(0, 0)
        Me.gbxInventoryEx.Margin = New System.Windows.Forms.Padding(0)
        Me.gbxInventoryEx.Name = "gbxInventoryEx"
        Me.gbxInventoryEx.Size = New System.Drawing.Size(1200, 700)
        Me.gbxInventoryEx.TabIndex = 9
        Me.gbxInventoryEx.TabStop = False
        '
        'tablaContenedorTimbrado
        '
        Me.tablaContenedorTimbrado.ColumnCount = 1
        Me.tablaContenedorTimbrado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaContenedorTimbrado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tablaContenedorTimbrado.Controls.Add(Me.tabaLadoTimbrado, 0, 0)
        Me.tablaContenedorTimbrado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaContenedorTimbrado.Location = New System.Drawing.Point(3, 16)
        Me.tablaContenedorTimbrado.Margin = New System.Windows.Forms.Padding(0)
        Me.tablaContenedorTimbrado.Name = "tablaContenedorTimbrado"
        Me.tablaContenedorTimbrado.RowCount = 1
        Me.tablaContenedorTimbrado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaContenedorTimbrado.Size = New System.Drawing.Size(1194, 681)
        Me.tablaContenedorTimbrado.TabIndex = 30
        '
        'tabaLadoTimbrado
        '
        Me.tabaLadoTimbrado.ColumnCount = 1
        Me.tabaLadoTimbrado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tabaLadoTimbrado.Controls.Add(Me.DataGridView1, 0, 3)
        Me.tabaLadoTimbrado.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tabaLadoTimbrado.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.tabaLadoTimbrado.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.tabaLadoTimbrado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabaLadoTimbrado.Location = New System.Drawing.Point(0, 0)
        Me.tabaLadoTimbrado.Margin = New System.Windows.Forms.Padding(0)
        Me.tabaLadoTimbrado.Name = "tabaLadoTimbrado"
        Me.tabaLadoTimbrado.RowCount = 4
        Me.tabaLadoTimbrado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.0!))
        Me.tabaLadoTimbrado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.tabaLadoTimbrado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.0!))
        Me.tabaLadoTimbrado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.0!))
        Me.tabaLadoTimbrado.Size = New System.Drawing.Size(1194, 681)
        Me.tabaLadoTimbrado.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.op, Me.corte, Me.hoja_marcacion, Me.subcorte, Me.talla, Me.cod_talla, Me.linea, Me.id_talla, Me.fecha, Me.id_rfid})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(3, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1188, 486)
        Me.DataGridView1.TabIndex = 41
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
        'hoja_marcacion
        '
        Me.hoja_marcacion.HeaderText = "HM"
        Me.hoja_marcacion.Name = "hoja_marcacion"
        Me.hoja_marcacion.ReadOnly = True
        '
        'subcorte
        '
        Me.subcorte.HeaderText = "Sub_Corte"
        Me.subcorte.Name = "subcorte"
        Me.subcorte.ReadOnly = True
        '
        'talla
        '
        Me.talla.HeaderText = "Talla"
        Me.talla.Name = "talla"
        Me.talla.ReadOnly = True
        '
        'cod_talla
        '
        Me.cod_talla.HeaderText = "Cod_Talla"
        Me.cod_talla.Name = "cod_talla"
        Me.cod_talla.ReadOnly = True
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
        'id_rfid
        '
        Me.id_rfid.HeaderText = "RFID"
        Me.id_rfid.Name = "id_rfid"
        Me.id_rfid.ReadOnly = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnLimpiarRFID, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClear, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cantidadRFID, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MsnVincular, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvTagList, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CodBarras, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1194, 143)
        Me.TableLayoutPanel1.TabIndex = 44
        '
        'btnLimpiarRFID
        '
        Me.btnLimpiarRFID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpiarRFID.Location = New System.Drawing.Point(480, 57)
        Me.btnLimpiarRFID.Name = "btnLimpiarRFID"
        Me.btnLimpiarRFID.Size = New System.Drawing.Size(173, 48)
        Me.btnLimpiarRFID.TabIndex = 51
        Me.btnLimpiarRFID.Text = "Limpiar"
        Me.btnLimpiarRFID.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(480, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(173, 48)
        Me.btnClear.TabIndex = 50
        Me.btnClear.Text = "Nuevo Timbrado"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'cantidadRFID
        '
        Me.cantidadRFID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cantidadRFID.AutoSize = True
        Me.cantidadRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cantidadRFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidadRFID.Location = New System.Drawing.Point(659, 3)
        Me.cantidadRFID.Margin = New System.Windows.Forms.Padding(3)
        Me.cantidadRFID.Name = "cantidadRFID"
        Me.TableLayoutPanel1.SetRowSpan(Me.cantidadRFID, 2)
        Me.cantidadRFID.Size = New System.Drawing.Size(113, 102)
        Me.cantidadRFID.TabIndex = 48
        Me.cantidadRFID.Text = "0"
        Me.cantidadRFID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MsnVincular
        '
        Me.MsnVincular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MsnVincular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel1.SetColumnSpan(Me.MsnVincular, 3)
        Me.MsnVincular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsnVincular.Location = New System.Drawing.Point(3, 111)
        Me.MsnVincular.Margin = New System.Windows.Forms.Padding(3)
        Me.MsnVincular.Name = "MsnVincular"
        Me.MsnVincular.Size = New System.Drawing.Size(769, 29)
        Me.MsnVincular.TabIndex = 28
        Me.MsnVincular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvTagList
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        Me.dgvTagList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTagList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTagList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTagList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTagList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTagList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTagList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnEPC, Me.clnTID, Me.clnCount})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTagList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTagList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTagList.EnableHeadersVisualStyles = False
        Me.dgvTagList.GridColor = System.Drawing.Color.LightGray
        Me.dgvTagList.Location = New System.Drawing.Point(778, 3)
        Me.dgvTagList.Name = "dgvTagList"
        Me.dgvTagList.ReadOnly = True
        Me.dgvTagList.RowHeadersVisible = False
        Me.TableLayoutPanel1.SetRowSpan(Me.dgvTagList, 3)
        Me.dgvTagList.RowTemplate.Height = 24
        Me.dgvTagList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTagList.Size = New System.Drawing.Size(413, 137)
        Me.dgvTagList.TabIndex = 47
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
        'CodBarras
        '
        Me.CodBarras.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodBarras.Location = New System.Drawing.Point(3, 39)
        Me.CodBarras.Name = "CodBarras"
        Me.TableLayoutPanel1.SetRowSpan(Me.CodBarras, 2)
        Me.CodBarras.Size = New System.Drawing.Size(471, 30)
        Me.CodBarras.TabIndex = 25
        Me.CodBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblTotalCount, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pruebaCodigos, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 143)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1194, 40)
        Me.TableLayoutPanel2.TabIndex = 46
        '
        'lblTotalCount
        '
        Me.lblTotalCount.AutoSize = True
        Me.lblTotalCount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTotalCount.Location = New System.Drawing.Point(241, 20)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(53, 20)
        Me.lblTotalCount.TabIndex = 48
        Me.lblTotalCount.Text = "0"
        Me.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label3.Location = New System.Drawing.Point(3, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 20)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Timbradas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'pruebaCodigos
        '
        Me.pruebaCodigos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pruebaCodigos.AutoSize = True
        Me.pruebaCodigos.Location = New System.Drawing.Point(618, 13)
        Me.pruebaCodigos.Name = "pruebaCodigos"
        Me.pruebaCodigos.Size = New System.Drawing.Size(14, 13)
        Me.pruebaCodigos.TabIndex = 49
        Me.pruebaCodigos.Text = "~"
        Me.pruebaCodigos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnStopInventoryEx, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cbxInventory, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnStartInventoryEx, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 183)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1194, 6)
        Me.TableLayoutPanel3.TabIndex = 47
        '
        'btnStopInventoryEx
        '
        Me.btnStopInventoryEx.Location = New System.Drawing.Point(3, 3)
        Me.btnStopInventoryEx.Name = "btnStopInventoryEx"
        Me.btnStopInventoryEx.Size = New System.Drawing.Size(65, 1)
        Me.btnStopInventoryEx.TabIndex = 30
        Me.btnStopInventoryEx.TabStop = False
        Me.btnStopInventoryEx.Text = "Stop"
        Me.btnStopInventoryEx.UseVisualStyleBackColor = True
        Me.btnStopInventoryEx.Visible = False
        '
        'cbxInventory
        '
        Me.cbxInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxInventory.FormattingEnabled = True
        Me.cbxInventory.Location = New System.Drawing.Point(790, 2)
        Me.cbxInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxInventory.Name = "cbxInventory"
        Me.cbxInventory.Size = New System.Drawing.Size(93, 21)
        Me.cbxInventory.TabIndex = 34
        Me.cbxInventory.Visible = False
        '
        'btnStartInventoryEx
        '
        Me.btnStartInventoryEx.Location = New System.Drawing.Point(397, 3)
        Me.btnStartInventoryEx.Name = "btnStartInventoryEx"
        Me.btnStartInventoryEx.Size = New System.Drawing.Size(65, 1)
        Me.btnStartInventoryEx.TabIndex = 29
        Me.btnStartInventoryEx.TabStop = False
        Me.btnStartInventoryEx.Text = "Start"
        Me.btnStartInventoryEx.UseVisualStyleBackColor = True
        Me.btnStartInventoryEx.Visible = False
        '
        'PruebaConfiguracion
        '
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.gbxInventoryEx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PruebaConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de RFID"
        Me.gbxInventoryEx.ResumeLayout(False)
        Me.tablaContenedorTimbrado.ResumeLayout(False)
        Me.tabaLadoTimbrado.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvTagList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxInventoryEx As GroupBox
    Friend WithEvents tablaContenedorTimbrado As TableLayoutPanel
    Friend WithEvents tabaLadoTimbrado As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnLimpiarRFID As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cantidadRFID As Label
    Friend WithEvents MsnVincular As Label
    Friend WithEvents dgvTagList As DataGridView
    Friend WithEvents clnEPC As DataGridViewTextBoxColumn
    Friend WithEvents clnTID As DataGridViewTextBoxColumn
    Friend WithEvents clnCount As DataGridViewTextBoxColumn
    Friend WithEvents CodBarras As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnStopInventoryEx As Button
    Friend WithEvents cbxInventory As ComboBox
    Friend WithEvents btnStartInventoryEx As Button
    Friend WithEvents pruebaCodigos As Label
    Friend WithEvents op As DataGridViewTextBoxColumn
    Friend WithEvents corte As DataGridViewTextBoxColumn
    Friend WithEvents hoja_marcacion As DataGridViewTextBoxColumn
    Friend WithEvents subcorte As DataGridViewTextBoxColumn
    Friend WithEvents talla As DataGridViewTextBoxColumn
    Friend WithEvents cod_talla As DataGridViewTextBoxColumn
    Friend WithEvents linea As DataGridViewTextBoxColumn
    Friend WithEvents id_talla As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents id_rfid As DataGridViewTextBoxColumn
End Class