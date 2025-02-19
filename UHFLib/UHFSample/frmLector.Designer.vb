<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLector
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLector))
        Me.pnlConnect = New System.Windows.Forms.Panel()
        Me.lblRomVersion = New System.Windows.Forms.Label()
        Me.lblSdkVersion = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnWifiSetting = New System.Windows.Forms.Button()
        Me.cbxBaudrate = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxPort = New System.Windows.Forms.ComboBox()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tpPerformance = New System.Windows.Forms.TabPage()
        Me.tablaContenConf = New System.Windows.Forms.TableLayoutPanel()
        Me.gbxEPCSettings = New System.Windows.Forms.GroupBox()
        Me.btnGetSessionTarget = New System.Windows.Forms.Button()
        Me.cbxSession = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cbxTarget = New System.Windows.Forms.ComboBox()
        Me.btnSetSessionTarget = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnGetQValue = New System.Windows.Forms.Button()
        Me.cbxQValue = New System.Windows.Forms.ComboBox()
        Me.btnSetQValue = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnGetActiveMode = New System.Windows.Forms.Button()
        Me.btnSetActiveMode = New System.Windows.Forms.Button()
        Me.cbxActiveMode = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.gbxScanMode = New System.Windows.Forms.GroupBox()
        Me.btnGetScanMode = New System.Windows.Forms.Button()
        Me.btnSetScanMode = New System.Windows.Forms.Button()
        Me.cbxScanMode = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnGetInvnetoryRoundInterval = New System.Windows.Forms.Button()
        Me.nudInventoryRoundInterval = New System.Windows.Forms.NumericUpDown()
        Me.btnSetInvnetoryRoundInterval = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnGetRemoveThreshold = New System.Windows.Forms.Button()
        Me.nudTagRemoveThreshold = New System.Windows.Forms.NumericUpDown()
        Me.btnSetRemoveThreshold = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGetTagPresentRepeatInterval = New System.Windows.Forms.Button()
        Me.nudTagPresentRepeatInterval = New System.Windows.Forms.NumericUpDown()
        Me.btnSetTagPresentRepeatInterval = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBoxLinkFrequency = New System.Windows.Forms.GroupBox()
        Me.btnGetLinkFrequency = New System.Windows.Forms.Button()
        Me.cbxLinkFrequency = New System.Windows.Forms.ComboBox()
        Me.btnSetLinkFrequency = New System.Windows.Forms.Button()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.GroupBoxRxDecode = New System.Windows.Forms.GroupBox()
        Me.btnGetRxDecode = New System.Windows.Forms.Button()
        Me.btnSetRxDecode = New System.Windows.Forms.Button()
        Me.cbxRxDecode = New System.Windows.Forms.ComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGetRfSensitivity = New System.Windows.Forms.Button()
        Me.lblRfSensitivity = New System.Windows.Forms.Label()
        Me.btnSetRfSensitivity = New System.Windows.Forms.Button()
        Me.tbRfSensitivity = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGetRfPower = New System.Windows.Forms.Button()
        Me.btnSetRfPower = New System.Windows.Forms.Button()
        Me.tbRfPower = New System.Windows.Forms.TrackBar()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblRfPower = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbJapanFrequency = New System.Windows.Forms.GroupBox()
        Me.cb923_2 = New System.Windows.Forms.CheckBox()
        Me.cb923_0 = New System.Windows.Forms.CheckBox()
        Me.cb922_8 = New System.Windows.Forms.CheckBox()
        Me.cb922_6 = New System.Windows.Forms.CheckBox()
        Me.cb922_4 = New System.Windows.Forms.CheckBox()
        Me.cb922_2 = New System.Windows.Forms.CheckBox()
        Me.cb922_0 = New System.Windows.Forms.CheckBox()
        Me.cb921_8 = New System.Windows.Forms.CheckBox()
        Me.cb921_6 = New System.Windows.Forms.CheckBox()
        Me.cb921_4 = New System.Windows.Forms.CheckBox()
        Me.cb921_2 = New System.Windows.Forms.CheckBox()
        Me.cb921_0 = New System.Windows.Forms.CheckBox()
        Me.cb920_8 = New System.Windows.Forms.CheckBox()
        Me.cb920_6 = New System.Windows.Forms.CheckBox()
        Me.cb920_4 = New System.Windows.Forms.CheckBox()
        Me.cb919_2 = New System.Windows.Forms.CheckBox()
        Me.cb918_0 = New System.Windows.Forms.CheckBox()
        Me.cb916_8 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbTaiwanFrequency = New System.Windows.Forms.GroupBox()
        Me.cb920_25 = New System.Windows.Forms.CheckBox()
        Me.cb922_25 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnGetFrequency = New System.Windows.Forms.Button()
        Me.btnSetFrequency = New System.Windows.Forms.Button()
        Me.tpInventory = New System.Windows.Forms.TabPage()
        Me.gbxInventoryEx = New System.Windows.Forms.GroupBox()
        Me.tablaContenedorTimbrado = New System.Windows.Forms.TableLayoutPanel()
        Me.tabaLadoTimbrado = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.op = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.corte = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.pruebaCodigos = New System.Windows.Forms.Label()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnStopInventoryEx = New System.Windows.Forms.Button()
        Me.cbxInventory = New System.Windows.Forms.ComboBox()
        Me.btnStartInventoryEx = New System.Windows.Forms.Button()
        Me.tpSearch = New System.Windows.Forms.TabPage()
        Me.gbxBuscarPrenda = New System.Windows.Forms.GroupBox()
        Me.tablaBuscarPrenda = New System.Windows.Forms.TableLayoutPanel()
        Me.ContenedorBuscarPrenda = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BuscarCodBarras = New System.Windows.Forms.TextBox()
        Me.MsnBusquedaPrenda = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.tpPapper = New System.Windows.Forms.TabPage()
        Me.TablaContenedorHM = New System.Windows.Forms.TableLayoutPanel()
        Me.tabaCabecera = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxOP = New System.Windows.Forms.TextBox()
        Me.LabelOP = New System.Windows.Forms.Label()
        Me.BtnBuscarHM = New System.Windows.Forms.Button()
        Me.TextBoxHM = New System.Windows.Forms.TextBox()
        Me.LabelHM = New System.Windows.Forms.Label()
        Me.BtnLimpiarHM = New System.Windows.Forms.Button()
        Me.tableCabecera = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_op = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_shipTo = New System.Windows.Forms.Label()
        Me.lbl_Despacho = New System.Windows.Forms.Label()
        Me.lbl_empaque = New System.Windows.Forms.Label()
        Me.lbl_HM = New System.Windows.Forms.Label()
        Me.lbl_po = New System.Windows.Forms.Label()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.lbl_Reserva = New System.Windows.Forms.Label()
        Me.lbl_Prenda = New System.Windows.Forms.Label()
        Me.lbl_direccion_1 = New System.Windows.Forms.Label()
        Me.lbl_direccion_2 = New System.Windows.Forms.Label()
        Me.lbl_Tolerancia = New System.Windows.Forms.Label()
        Me.lbl_Estilo = New System.Windows.Forms.Label()
        Me.lbl_Observacion = New System.Windows.Forms.Label()
        Me.lbl_Certificado = New System.Windows.Forms.Label()
        Me.lbl_NKit = New System.Windows.Forms.Label()
        Me.text_norpd = New System.Windows.Forms.Label()
        Me.text_npocl = New System.Windows.Forms.Label()
        Me.text_nhjmr = New System.Windows.Forms.Label()
        Me.text_sesthm = New System.Windows.Forms.Label()
        Me.text_sreserva = New System.Windows.Forms.Label()
        Me.text_cclnt = New System.Windows.Forms.Label()
        Me.text_ttrcr = New System.Windows.Forms.Label()
        Me.text_tdscr = New System.Windows.Forms.Label()
        Me.text_temporada = New System.Windows.Forms.Label()
        Me.lbl_SitDespacho = New System.Windows.Forms.Label()
        Me.text_tdrcc = New System.Windows.Forms.Label()
        Me.txt_Direccion_2 = New System.Windows.Forms.Label()
        Me.text_clgren = New System.Windows.Forms.Label()
        Me.lbl_fEntrega = New System.Windows.Forms.Label()
        Me.text_fentr = New System.Windows.Forms.Label()
        Me.lbl_BillTo = New System.Windows.Forms.Label()
        Me.text_tlgen = New System.Windows.Forms.Label()
        Me.text_ptlrnc = New System.Windows.Forms.Label()
        Me.text_cestcl = New System.Windows.Forms.Label()
        Me.text_testcl = New System.Windows.Forms.Label()
        Me.text_flgdes = New System.Windows.Forms.Label()
        Me.text_tvia = New System.Windows.Forms.Label()
        Me.txt_nro_kit = New System.Windows.Forms.Label()
        Me.text_nro_certificado = New System.Windows.Forms.Label()
        Me.text_totros = New System.Windows.Forms.Label()
        Me.text_tfrmem = New System.Windows.Forms.Label()
        Me.text_cod_lugrent_cobro = New System.Windows.Forms.Label()
        Me.txt_BillToDet = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.pnlConnect.SuspendLayout
        Me.tabControl.SuspendLayout
        Me.tpPerformance.SuspendLayout
        Me.tablaContenConf.SuspendLayout
        Me.gbxEPCSettings.SuspendLayout
        Me.GroupBox8.SuspendLayout
        Me.gbxScanMode.SuspendLayout
        Me.GroupBox5.SuspendLayout
        CType(Me.nudInventoryRoundInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout
        CType(Me.nudTagRemoveThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout
        CType(Me.nudTagPresentRepeatInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxLinkFrequency.SuspendLayout
        Me.GroupBoxRxDecode.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.tbRfSensitivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout
        CType(Me.tbRfPower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout
        Me.gbJapanFrequency.SuspendLayout
        Me.gbTaiwanFrequency.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.tpInventory.SuspendLayout
        Me.gbxInventoryEx.SuspendLayout
        Me.tablaContenedorTimbrado.SuspendLayout
        Me.tabaLadoTimbrado.SuspendLayout
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.dgvTagList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.tpSearch.SuspendLayout
        Me.gbxBuscarPrenda.SuspendLayout
        Me.tablaBuscarPrenda.SuspendLayout
        Me.ContenedorBuscarPrenda.SuspendLayout
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPapper.SuspendLayout
        Me.TablaContenedorHM.SuspendLayout
        Me.tabaCabecera.SuspendLayout
        Me.tableCabecera.SuspendLayout
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout
        '
        'pnlConnect
        '
        Me.pnlConnect.Controls.Add(Me.lblRomVersion)
        Me.pnlConnect.Controls.Add(Me.lblSdkVersion)
        Me.pnlConnect.Controls.Add(Me.btnConnect)
        Me.pnlConnect.Controls.Add(Me.btnWifiSetting)
        Me.pnlConnect.Controls.Add(Me.cbxBaudrate)
        Me.pnlConnect.Controls.Add(Me.Label2)
        Me.pnlConnect.Controls.Add(Me.Label1)
        Me.pnlConnect.Controls.Add(Me.cbxPort)
        Me.pnlConnect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlConnect.Location = New System.Drawing.Point(0, 673)
        Me.pnlConnect.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.pnlConnect.Name = "pnlConnect"
        Me.pnlConnect.Size = New System.Drawing.Size(1203, 76)
        Me.pnlConnect.TabIndex = 1
        '
        'lblRomVersion
        '
        Me.lblRomVersion.AutoSize = True
        Me.lblRomVersion.Location = New System.Drawing.Point(273, 13)
        Me.lblRomVersion.Name = "lblRomVersion"
        Me.lblRomVersion.Size = New System.Drawing.Size(73, 13)
        Me.lblRomVersion.TabIndex = 8
        Me.lblRomVersion.Text = "ROM Version:"
        '
        'lblSdkVersion
        '
        Me.lblSdkVersion.AutoSize = True
        Me.lblSdkVersion.Location = New System.Drawing.Point(23, 13)
        Me.lblSdkVersion.Name = "lblSdkVersion"
        Me.lblSdkVersion.Size = New System.Drawing.Size(70, 13)
        Me.lblSdkVersion.TabIndex = 7
        Me.lblSdkVersion.Text = "SDK Version:"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(460, 36)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(98, 27)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Conectar"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnWifiSetting
        '
        Me.btnWifiSetting.Enabled = False
        Me.btnWifiSetting.Location = New System.Drawing.Point(15, 37)
        Me.btnWifiSetting.Name = "btnWifiSetting"
        Me.btnWifiSetting.Size = New System.Drawing.Size(95, 27)
        Me.btnWifiSetting.TabIndex = 5
        Me.btnWifiSetting.Text = "Wi-Fi Setting"
        Me.btnWifiSetting.UseVisualStyleBackColor = True
        '
        'cbxBaudrate
        '
        Me.cbxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBaudrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbxBaudrate.FormattingEnabled = True
        Me.cbxBaudrate.Location = New System.Drawing.Point(350, 39)
        Me.cbxBaudrate.Name = "cbxBaudrate"
        Me.cbxBaudrate.Size = New System.Drawing.Size(84, 23)
        Me.cbxBaudrate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Baudrate :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Port :"
        '
        'cbxPort
        '
        Me.cbxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbxPort.FormattingEnabled = True
        Me.cbxPort.Location = New System.Drawing.Point(151, 39)
        Me.cbxPort.Name = "cbxPort"
        Me.cbxPort.Size = New System.Drawing.Size(130, 23)
        Me.cbxPort.TabIndex = 1
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tpPerformance)
        Me.tabControl.Controls.Add(Me.tpInventory)
        Me.tabControl.Controls.Add(Me.tpSearch)
        Me.tabControl.Controls.Add(Me.tpPapper)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.ItemSize = New System.Drawing.Size(150, 40)
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(1203, 673)
        Me.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControl.TabIndex = 8
        Me.tabControl.TabStop = False
        '
        'tpPerformance
        '
        Me.tpPerformance.Controls.Add(Me.tablaContenConf)
        Me.tpPerformance.Location = New System.Drawing.Point(4, 44)
        Me.tpPerformance.Name = "tpPerformance"
        Me.tpPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPerformance.Size = New System.Drawing.Size(1195, 625)
        Me.tpPerformance.TabIndex = 3
        Me.tpPerformance.Text = "Configuración"
        Me.tpPerformance.UseVisualStyleBackColor = True
        Me.tpPerformance.Visible = False
        '
        'tablaContenConf
        '
        Me.tablaContenConf.ColumnCount = 2
        Me.tablaContenConf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablaContenConf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablaContenConf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tablaContenConf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tablaContenConf.Controls.Add(Me.gbxEPCSettings, 0, 5)
        Me.tablaContenConf.Controls.Add(Me.GroupBox8, 1, 4)
        Me.tablaContenConf.Controls.Add(Me.gbxScanMode, 1, 3)
        Me.tablaContenConf.Controls.Add(Me.GroupBox5, 1, 2)
        Me.tablaContenConf.Controls.Add(Me.GroupBox4, 0, 3)
        Me.tablaContenConf.Controls.Add(Me.GroupBox2, 0, 2)
        Me.tablaContenConf.Controls.Add(Me.GroupBoxLinkFrequency, 1, 1)
        Me.tablaContenConf.Controls.Add(Me.GroupBoxRxDecode, 0, 1)
        Me.tablaContenConf.Controls.Add(Me.GroupBox1, 1, 0)
        Me.tablaContenConf.Controls.Add(Me.GroupBox3, 0, 0)
        Me.tablaContenConf.Controls.Add(Me.TableLayoutPanel5, 0, 4)
        Me.tablaContenConf.Controls.Add(Me.TableLayoutPanel4, 0, 5)
        Me.tablaContenConf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaContenConf.Location = New System.Drawing.Point(3, 3)
        Me.tablaContenConf.Name = "tablaContenConf"
        Me.tablaContenConf.RowCount = 6
        Me.tablaContenConf.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tablaContenConf.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tablaContenConf.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tablaContenConf.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tablaContenConf.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tablaContenConf.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablaContenConf.Size = New System.Drawing.Size(1189, 619)
        Me.tablaContenConf.TabIndex = 1
        '
        'gbxEPCSettings
        '
        Me.gbxEPCSettings.Controls.Add(Me.btnGetSessionTarget)
        Me.gbxEPCSettings.Controls.Add(Me.cbxSession)
        Me.gbxEPCSettings.Controls.Add(Me.Label33)
        Me.gbxEPCSettings.Controls.Add(Me.cbxTarget)
        Me.gbxEPCSettings.Controls.Add(Me.btnSetSessionTarget)
        Me.gbxEPCSettings.Controls.Add(Me.Label32)
        Me.gbxEPCSettings.Controls.Add(Me.btnGetQValue)
        Me.gbxEPCSettings.Controls.Add(Me.cbxQValue)
        Me.gbxEPCSettings.Controls.Add(Me.btnSetQValue)
        Me.gbxEPCSettings.Controls.Add(Me.Label31)
        Me.gbxEPCSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxEPCSettings.Location = New System.Drawing.Point(597, 498)
        Me.gbxEPCSettings.Name = "gbxEPCSettings"
        Me.gbxEPCSettings.Size = New System.Drawing.Size(589, 77)
        Me.gbxEPCSettings.TabIndex = 36
        Me.gbxEPCSettings.TabStop = False
        Me.gbxEPCSettings.Text = "Configurar EPC"
        '
        'btnGetSessionTarget
        '
        Me.btnGetSessionTarget.Location = New System.Drawing.Point(422, 46)
        Me.btnGetSessionTarget.Name = "btnGetSessionTarget"
        Me.btnGetSessionTarget.Size = New System.Drawing.Size(60, 25)
        Me.btnGetSessionTarget.TabIndex = 29
        Me.btnGetSessionTarget.Text = "Obtener"
        Me.btnGetSessionTarget.UseVisualStyleBackColor = True
        '
        'cbxSession
        '
        Me.cbxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSession.FormattingEnabled = True
        Me.cbxSession.Location = New System.Drawing.Point(58, 48)
        Me.cbxSession.Name = "cbxSession"
        Me.cbxSession.Size = New System.Drawing.Size(107, 21)
        Me.cbxSession.TabIndex = 28
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(7, 51)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 13)
        Me.Label33.TabIndex = 27
        Me.Label33.Text = "Sesión :"
        '
        'cbxTarget
        '
        Me.cbxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTarget.FormattingEnabled = True
        Me.cbxTarget.Location = New System.Drawing.Point(235, 48)
        Me.cbxTarget.Name = "cbxTarget"
        Me.cbxTarget.Size = New System.Drawing.Size(107, 21)
        Me.cbxTarget.TabIndex = 26
        '
        'btnSetSessionTarget
        '
        Me.btnSetSessionTarget.Location = New System.Drawing.Point(349, 46)
        Me.btnSetSessionTarget.Name = "btnSetSessionTarget"
        Me.btnSetSessionTarget.Size = New System.Drawing.Size(70, 25)
        Me.btnSetSessionTarget.TabIndex = 25
        Me.btnSetSessionTarget.Text = "Establecer"
        Me.btnSetSessionTarget.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(188, 51)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(50, 13)
        Me.Label32.TabIndex = 24
        Me.Label32.Text = "Targeta :"
        '
        'btnGetQValue
        '
        Me.btnGetQValue.Location = New System.Drawing.Point(422, 14)
        Me.btnGetQValue.Name = "btnGetQValue"
        Me.btnGetQValue.Size = New System.Drawing.Size(60, 25)
        Me.btnGetQValue.TabIndex = 21
        Me.btnGetQValue.Text = "Obtener"
        Me.btnGetQValue.UseVisualStyleBackColor = True
        '
        'cbxQValue
        '
        Me.cbxQValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxQValue.FormattingEnabled = True
        Me.cbxQValue.Location = New System.Drawing.Point(133, 16)
        Me.cbxQValue.Name = "cbxQValue"
        Me.cbxQValue.Size = New System.Drawing.Size(208, 21)
        Me.cbxQValue.TabIndex = 14
        '
        'btnSetQValue
        '
        Me.btnSetQValue.Location = New System.Drawing.Point(348, 14)
        Me.btnSetQValue.Name = "btnSetQValue"
        Me.btnSetQValue.Size = New System.Drawing.Size(70, 25)
        Me.btnSetQValue.TabIndex = 1
        Me.btnSetQValue.Text = "Establecer"
        Me.btnSetQValue.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(78, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 13)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Valor Q:"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnGetActiveMode)
        Me.GroupBox8.Controls.Add(Me.btnSetActiveMode)
        Me.GroupBox8.Controls.Add(Me.cbxActiveMode)
        Me.GroupBox8.Controls.Add(Me.Label44)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(597, 399)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(589, 51)
        Me.GroupBox8.TabIndex = 34
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Modo activo de inventario"
        '
        'btnGetActiveMode
        '
        Me.btnGetActiveMode.Location = New System.Drawing.Point(422, 16)
        Me.btnGetActiveMode.Name = "btnGetActiveMode"
        Me.btnGetActiveMode.Size = New System.Drawing.Size(60, 25)
        Me.btnGetActiveMode.TabIndex = 25
        Me.btnGetActiveMode.Text = "Obtener"
        Me.btnGetActiveMode.UseVisualStyleBackColor = True
        '
        'btnSetActiveMode
        '
        Me.btnSetActiveMode.Location = New System.Drawing.Point(348, 16)
        Me.btnSetActiveMode.Name = "btnSetActiveMode"
        Me.btnSetActiveMode.Size = New System.Drawing.Size(70, 25)
        Me.btnSetActiveMode.TabIndex = 15
        Me.btnSetActiveMode.Text = "Establecer"
        Me.btnSetActiveMode.UseVisualStyleBackColor = True
        '
        'cbxActiveMode
        '
        Me.cbxActiveMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxActiveMode.FormattingEnabled = True
        Me.cbxActiveMode.Location = New System.Drawing.Point(132, 18)
        Me.cbxActiveMode.Name = "cbxActiveMode"
        Me.cbxActiveMode.Size = New System.Drawing.Size(209, 21)
        Me.cbxActiveMode.TabIndex = 14
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(52, 22)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(69, 13)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "Modo activo:"
        '
        'gbxScanMode
        '
        Me.gbxScanMode.Controls.Add(Me.btnGetScanMode)
        Me.gbxScanMode.Controls.Add(Me.btnSetScanMode)
        Me.gbxScanMode.Controls.Add(Me.cbxScanMode)
        Me.gbxScanMode.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxScanMode.Location = New System.Drawing.Point(597, 300)
        Me.gbxScanMode.Name = "gbxScanMode"
        Me.gbxScanMode.Size = New System.Drawing.Size(589, 49)
        Me.gbxScanMode.TabIndex = 31
        Me.gbxScanMode.TabStop = False
        Me.gbxScanMode.Text = "Modo de escaneo"
        '
        'btnGetScanMode
        '
        Me.btnGetScanMode.Location = New System.Drawing.Point(422, 13)
        Me.btnGetScanMode.Name = "btnGetScanMode"
        Me.btnGetScanMode.Size = New System.Drawing.Size(60, 25)
        Me.btnGetScanMode.TabIndex = 30
        Me.btnGetScanMode.Text = "Obtener"
        Me.btnGetScanMode.UseVisualStyleBackColor = True
        '
        'btnSetScanMode
        '
        Me.btnSetScanMode.Location = New System.Drawing.Point(349, 13)
        Me.btnSetScanMode.Name = "btnSetScanMode"
        Me.btnSetScanMode.Size = New System.Drawing.Size(70, 25)
        Me.btnSetScanMode.TabIndex = 29
        Me.btnSetScanMode.Text = "Establecer"
        Me.btnSetScanMode.UseVisualStyleBackColor = True
        '
        'cbxScanMode
        '
        Me.cbxScanMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxScanMode.FormattingEnabled = True
        Me.cbxScanMode.Location = New System.Drawing.Point(133, 15)
        Me.cbxScanMode.Name = "cbxScanMode"
        Me.cbxScanMode.Size = New System.Drawing.Size(208, 21)
        Me.cbxScanMode.TabIndex = 28
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.btnGetInvnetoryRoundInterval)
        Me.GroupBox5.Controls.Add(Me.nudInventoryRoundInterval)
        Me.GroupBox5.Controls.Add(Me.btnSetInvnetoryRoundInterval)
        Me.GroupBox5.Controls.Add(Me.Label38)
        Me.GroupBox5.Location = New System.Drawing.Point(597, 201)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(589, 49)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        '
        'btnGetInvnetoryRoundInterval
        '
        Me.btnGetInvnetoryRoundInterval.Location = New System.Drawing.Point(422, 14)
        Me.btnGetInvnetoryRoundInterval.Name = "btnGetInvnetoryRoundInterval"
        Me.btnGetInvnetoryRoundInterval.Size = New System.Drawing.Size(60, 25)
        Me.btnGetInvnetoryRoundInterval.TabIndex = 20
        Me.btnGetInvnetoryRoundInterval.Text = "Obtener"
        Me.btnGetInvnetoryRoundInterval.UseVisualStyleBackColor = True
        '
        'nudInventoryRoundInterval
        '
        Me.nudInventoryRoundInterval.Location = New System.Drawing.Point(219, 14)
        Me.nudInventoryRoundInterval.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.nudInventoryRoundInterval.Name = "nudInventoryRoundInterval"
        Me.nudInventoryRoundInterval.Size = New System.Drawing.Size(120, 20)
        Me.nudInventoryRoundInterval.TabIndex = 19
        '
        'btnSetInvnetoryRoundInterval
        '
        Me.btnSetInvnetoryRoundInterval.Location = New System.Drawing.Point(347, 14)
        Me.btnSetInvnetoryRoundInterval.Name = "btnSetInvnetoryRoundInterval"
        Me.btnSetInvnetoryRoundInterval.Size = New System.Drawing.Size(70, 25)
        Me.btnSetInvnetoryRoundInterval.TabIndex = 18
        Me.btnSetInvnetoryRoundInterval.Text = "Establecer"
        Me.btnSetInvnetoryRoundInterval.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 20)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(170, 13)
        Me.Label38.TabIndex = 12
        Me.Label38.Text = "Inventory Round Interval (1=10ms)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.btnGetRemoveThreshold)
        Me.GroupBox4.Controls.Add(Me.nudTagRemoveThreshold)
        Me.GroupBox4.Controls.Add(Me.btnSetRemoveThreshold)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 300)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(588, 49)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        '
        'btnGetRemoveThreshold
        '
        Me.btnGetRemoveThreshold.Location = New System.Drawing.Point(422, 13)
        Me.btnGetRemoveThreshold.Name = "btnGetRemoveThreshold"
        Me.btnGetRemoveThreshold.Size = New System.Drawing.Size(60, 25)
        Me.btnGetRemoveThreshold.TabIndex = 20
        Me.btnGetRemoveThreshold.Text = "Obtener"
        Me.btnGetRemoveThreshold.UseVisualStyleBackColor = True
        '
        'nudTagRemoveThreshold
        '
        Me.nudTagRemoveThreshold.Location = New System.Drawing.Point(219, 14)
        Me.nudTagRemoveThreshold.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.nudTagRemoveThreshold.Name = "nudTagRemoveThreshold"
        Me.nudTagRemoveThreshold.Size = New System.Drawing.Size(120, 20)
        Me.nudTagRemoveThreshold.TabIndex = 19
        '
        'btnSetRemoveThreshold
        '
        Me.btnSetRemoveThreshold.Location = New System.Drawing.Point(347, 13)
        Me.btnSetRemoveThreshold.Name = "btnSetRemoveThreshold"
        Me.btnSetRemoveThreshold.Size = New System.Drawing.Size(70, 25)
        Me.btnSetRemoveThreshold.TabIndex = 18
        Me.btnSetRemoveThreshold.Text = "Establecer"
        Me.btnSetRemoveThreshold.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 20)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(207, 13)
        Me.Label37.TabIndex = 12
        Me.Label37.Text = "Tag Remove Threshold (Inventory Round)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnGetTagPresentRepeatInterval)
        Me.GroupBox2.Controls.Add(Me.nudTagPresentRepeatInterval)
        Me.GroupBox2.Controls.Add(Me.btnSetTagPresentRepeatInterval)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 49)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'btnGetTagPresentRepeatInterval
        '
        Me.btnGetTagPresentRepeatInterval.Location = New System.Drawing.Point(422, 14)
        Me.btnGetTagPresentRepeatInterval.Name = "btnGetTagPresentRepeatInterval"
        Me.btnGetTagPresentRepeatInterval.Size = New System.Drawing.Size(60, 25)
        Me.btnGetTagPresentRepeatInterval.TabIndex = 21
        Me.btnGetTagPresentRepeatInterval.Text = "Obtener"
        Me.btnGetTagPresentRepeatInterval.UseVisualStyleBackColor = True
        '
        'nudTagPresentRepeatInterval
        '
        Me.nudTagPresentRepeatInterval.Location = New System.Drawing.Point(219, 15)
        Me.nudTagPresentRepeatInterval.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.nudTagPresentRepeatInterval.Name = "nudTagPresentRepeatInterval"
        Me.nudTagPresentRepeatInterval.Size = New System.Drawing.Size(120, 20)
        Me.nudTagPresentRepeatInterval.TabIndex = 20
        '
        'btnSetTagPresentRepeatInterval
        '
        Me.btnSetTagPresentRepeatInterval.Location = New System.Drawing.Point(347, 14)
        Me.btnSetTagPresentRepeatInterval.Name = "btnSetTagPresentRepeatInterval"
        Me.btnSetTagPresentRepeatInterval.Size = New System.Drawing.Size(70, 25)
        Me.btnSetTagPresentRepeatInterval.TabIndex = 18
        Me.btnSetTagPresentRepeatInterval.Text = "Establecer"
        Me.btnSetTagPresentRepeatInterval.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(9, 20)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(202, 13)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "Tag Premite Repetir Intervalos (1=100ms)"
        '
        'GroupBoxLinkFrequency
        '
        Me.GroupBoxLinkFrequency.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLinkFrequency.Controls.Add(Me.btnGetLinkFrequency)
        Me.GroupBoxLinkFrequency.Controls.Add(Me.cbxLinkFrequency)
        Me.GroupBoxLinkFrequency.Controls.Add(Me.btnSetLinkFrequency)
        Me.GroupBoxLinkFrequency.Controls.Add(Me.Label50)
        Me.GroupBoxLinkFrequency.Location = New System.Drawing.Point(597, 102)
        Me.GroupBoxLinkFrequency.Name = "GroupBoxLinkFrequency"
        Me.GroupBoxLinkFrequency.Size = New System.Drawing.Size(589, 49)
        Me.GroupBoxLinkFrequency.TabIndex = 27
        Me.GroupBoxLinkFrequency.TabStop = False
        '
        'btnGetLinkFrequency
        '
        Me.btnGetLinkFrequency.Location = New System.Drawing.Point(422, 18)
        Me.btnGetLinkFrequency.Name = "btnGetLinkFrequency"
        Me.btnGetLinkFrequency.Size = New System.Drawing.Size(60, 25)
        Me.btnGetLinkFrequency.TabIndex = 17
        Me.btnGetLinkFrequency.Text = "Obtener"
        Me.btnGetLinkFrequency.UseVisualStyleBackColor = True
        '
        'cbxLinkFrequency
        '
        Me.cbxLinkFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLinkFrequency.FormattingEnabled = True
        Me.cbxLinkFrequency.Location = New System.Drawing.Point(97, 21)
        Me.cbxLinkFrequency.Name = "cbxLinkFrequency"
        Me.cbxLinkFrequency.Size = New System.Drawing.Size(242, 21)
        Me.cbxLinkFrequency.TabIndex = 13
        '
        'btnSetLinkFrequency
        '
        Me.btnSetLinkFrequency.Location = New System.Drawing.Point(346, 18)
        Me.btnSetLinkFrequency.Name = "btnSetLinkFrequency"
        Me.btnSetLinkFrequency.Size = New System.Drawing.Size(70, 25)
        Me.btnSetLinkFrequency.TabIndex = 16
        Me.btnSetLinkFrequency.Text = "Establecer"
        Me.btnSetLinkFrequency.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(6, 25)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(83, 13)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "Link Frecuencia"
        '
        'GroupBoxRxDecode
        '
        Me.GroupBoxRxDecode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxRxDecode.Controls.Add(Me.btnGetRxDecode)
        Me.GroupBoxRxDecode.Controls.Add(Me.btnSetRxDecode)
        Me.GroupBoxRxDecode.Controls.Add(Me.cbxRxDecode)
        Me.GroupBoxRxDecode.Controls.Add(Me.Label49)
        Me.GroupBoxRxDecode.Location = New System.Drawing.Point(3, 102)
        Me.GroupBoxRxDecode.Name = "GroupBoxRxDecode"
        Me.GroupBoxRxDecode.Size = New System.Drawing.Size(588, 49)
        Me.GroupBoxRxDecode.TabIndex = 26
        Me.GroupBoxRxDecode.TabStop = False
        '
        'btnGetRxDecode
        '
        Me.btnGetRxDecode.Location = New System.Drawing.Point(422, 13)
        Me.btnGetRxDecode.Name = "btnGetRxDecode"
        Me.btnGetRxDecode.Size = New System.Drawing.Size(60, 25)
        Me.btnGetRxDecode.TabIndex = 17
        Me.btnGetRxDecode.Text = "Obtener"
        Me.btnGetRxDecode.UseVisualStyleBackColor = True
        '
        'btnSetRxDecode
        '
        Me.btnSetRxDecode.Location = New System.Drawing.Point(346, 13)
        Me.btnSetRxDecode.Name = "btnSetRxDecode"
        Me.btnSetRxDecode.Size = New System.Drawing.Size(70, 25)
        Me.btnSetRxDecode.TabIndex = 16
        Me.btnSetRxDecode.Text = "Establecer"
        Me.btnSetRxDecode.UseVisualStyleBackColor = True
        '
        'cbxRxDecode
        '
        Me.cbxRxDecode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRxDecode.FormattingEnabled = True
        Me.cbxRxDecode.Location = New System.Drawing.Point(97, 15)
        Me.cbxRxDecode.Name = "cbxRxDecode"
        Me.cbxRxDecode.Size = New System.Drawing.Size(242, 21)
        Me.cbxRxDecode.TabIndex = 13
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(6, 20)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(79, 13)
        Me.Label49.TabIndex = 12
        Me.Label49.Text = "Decodificar RX"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnGetRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.lblRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.btnSetRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.tbRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(597, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 58)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'btnGetRfSensitivity
        '
        Me.btnGetRfSensitivity.Location = New System.Drawing.Point(538, 15)
        Me.btnGetRfSensitivity.Name = "btnGetRfSensitivity"
        Me.btnGetRfSensitivity.Size = New System.Drawing.Size(60, 25)
        Me.btnGetRfSensitivity.TabIndex = 20
        Me.btnGetRfSensitivity.Text = "Obtener"
        Me.btnGetRfSensitivity.UseVisualStyleBackColor = True
        '
        'lblRfSensitivity
        '
        Me.lblRfSensitivity.AutoSize = True
        Me.lblRfSensitivity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRfSensitivity.Location = New System.Drawing.Point(387, 21)
        Me.lblRfSensitivity.Name = "lblRfSensitivity"
        Me.lblRfSensitivity.Size = New System.Drawing.Size(64, 21)
        Me.lblRfSensitivity.TabIndex = 19
        Me.lblRfSensitivity.Text = "Nivel 1"
        '
        'btnSetRfSensitivity
        '
        Me.btnSetRfSensitivity.Location = New System.Drawing.Point(463, 15)
        Me.btnSetRfSensitivity.Name = "btnSetRfSensitivity"
        Me.btnSetRfSensitivity.Size = New System.Drawing.Size(70, 25)
        Me.btnSetRfSensitivity.TabIndex = 18
        Me.btnSetRfSensitivity.Text = "Establecer"
        Me.btnSetRfSensitivity.UseVisualStyleBackColor = True
        '
        'tbRfSensitivity
        '
        Me.tbRfSensitivity.AutoSize = False
        Me.tbRfSensitivity.Location = New System.Drawing.Point(94, 15)
        Me.tbRfSensitivity.Maximum = 14
        Me.tbRfSensitivity.Minimum = 1
        Me.tbRfSensitivity.Name = "tbRfSensitivity"
        Me.tbRfSensitivity.Size = New System.Drawing.Size(284, 33)
        Me.tbRfSensitivity.TabIndex = 14
        Me.tbRfSensitivity.Value = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "RF Sensibilidad : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnGetRfPower)
        Me.GroupBox3.Controls.Add(Me.btnSetRfPower)
        Me.GroupBox3.Controls.Add(Me.tbRfPower)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.lblRfPower)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(588, 58)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'btnGetRfPower
        '
        Me.btnGetRfPower.Location = New System.Drawing.Point(531, 15)
        Me.btnGetRfPower.Name = "btnGetRfPower"
        Me.btnGetRfPower.Size = New System.Drawing.Size(60, 25)
        Me.btnGetRfPower.TabIndex = 18
        Me.btnGetRfPower.Text = "Obtener"
        Me.btnGetRfPower.UseVisualStyleBackColor = True
        '
        'btnSetRfPower
        '
        Me.btnSetRfPower.Location = New System.Drawing.Point(458, 15)
        Me.btnSetRfPower.Name = "btnSetRfPower"
        Me.btnSetRfPower.Size = New System.Drawing.Size(70, 25)
        Me.btnSetRfPower.TabIndex = 17
        Me.btnSetRfPower.Text = "Establecer"
        Me.btnSetRfPower.UseVisualStyleBackColor = True
        '
        'tbRfPower
        '
        Me.tbRfPower.AutoSize = False
        Me.tbRfPower.Location = New System.Drawing.Point(97, 15)
        Me.tbRfPower.Maximum = 27
        Me.tbRfPower.Minimum = 1
        Me.tbRfPower.Name = "tbRfPower"
        Me.tbRfPower.Size = New System.Drawing.Size(284, 33)
        Me.tbRfPower.TabIndex = 13
        Me.tbRfPower.Value = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(31, 23)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 13)
        Me.Label28.TabIndex = 11
        Me.Label28.Text = "RF Potencia : "
        '
        'lblRfPower
        '
        Me.lblRfPower.AutoSize = True
        Me.lblRfPower.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRfPower.Location = New System.Drawing.Point(387, 21)
        Me.lblRfPower.Name = "lblRfPower"
        Me.lblRfPower.Size = New System.Drawing.Size(58, 21)
        Me.lblRfPower.TabIndex = 14
        Me.lblRfPower.Text = "1 dBm"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.gbJapanFrequency, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.gbTaiwanFrequency, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 396)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(594, 99)
        Me.TableLayoutPanel5.TabIndex = 33
        '
        'gbJapanFrequency
        '
        Me.gbJapanFrequency.Controls.Add(Me.cb923_2)
        Me.gbJapanFrequency.Controls.Add(Me.cb923_0)
        Me.gbJapanFrequency.Controls.Add(Me.cb922_8)
        Me.gbJapanFrequency.Controls.Add(Me.cb922_6)
        Me.gbJapanFrequency.Controls.Add(Me.cb922_4)
        Me.gbJapanFrequency.Controls.Add(Me.cb922_2)
        Me.gbJapanFrequency.Controls.Add(Me.cb922_0)
        Me.gbJapanFrequency.Controls.Add(Me.cb921_8)
        Me.gbJapanFrequency.Controls.Add(Me.cb921_6)
        Me.gbJapanFrequency.Controls.Add(Me.cb921_4)
        Me.gbJapanFrequency.Controls.Add(Me.cb921_2)
        Me.gbJapanFrequency.Controls.Add(Me.cb921_0)
        Me.gbJapanFrequency.Controls.Add(Me.cb920_8)
        Me.gbJapanFrequency.Controls.Add(Me.cb920_6)
        Me.gbJapanFrequency.Controls.Add(Me.cb920_4)
        Me.gbJapanFrequency.Controls.Add(Me.cb919_2)
        Me.gbJapanFrequency.Controls.Add(Me.cb918_0)
        Me.gbJapanFrequency.Controls.Add(Me.cb916_8)
        Me.gbJapanFrequency.Controls.Add(Me.Button1)
        Me.gbJapanFrequency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbJapanFrequency.Location = New System.Drawing.Point(2, 2)
        Me.gbJapanFrequency.Margin = New System.Windows.Forms.Padding(2)
        Me.gbJapanFrequency.Name = "gbJapanFrequency"
        Me.gbJapanFrequency.Padding = New System.Windows.Forms.Padding(2)
        Me.gbJapanFrequency.Size = New System.Drawing.Size(441, 95)
        Me.gbJapanFrequency.TabIndex = 32
        Me.gbJapanFrequency.TabStop = False
        Me.gbJapanFrequency.Text = "Japon"
        '
        'cb923_2
        '
        Me.cb923_2.AutoSize = True
        Me.cb923_2.Location = New System.Drawing.Point(127, 70)
        Me.cb923_2.Name = "cb923_2"
        Me.cb923_2.Size = New System.Drawing.Size(53, 17)
        Me.cb923_2.TabIndex = 34
        Me.cb923_2.Text = "923.2"
        Me.cb923_2.UseVisualStyleBackColor = True
        '
        'cb923_0
        '
        Me.cb923_0.AutoSize = True
        Me.cb923_0.Location = New System.Drawing.Point(184, 70)
        Me.cb923_0.Name = "cb923_0"
        Me.cb923_0.Size = New System.Drawing.Size(53, 17)
        Me.cb923_0.TabIndex = 33
        Me.cb923_0.Text = "923.0"
        Me.cb923_0.UseVisualStyleBackColor = True
        '
        'cb922_8
        '
        Me.cb922_8.AutoSize = True
        Me.cb922_8.Location = New System.Drawing.Point(363, 46)
        Me.cb922_8.Name = "cb922_8"
        Me.cb922_8.Size = New System.Drawing.Size(53, 17)
        Me.cb922_8.TabIndex = 32
        Me.cb922_8.Text = "922.8"
        Me.cb922_8.UseVisualStyleBackColor = True
        '
        'cb922_6
        '
        Me.cb922_6.AutoSize = True
        Me.cb922_6.Location = New System.Drawing.Point(304, 46)
        Me.cb922_6.Name = "cb922_6"
        Me.cb922_6.Size = New System.Drawing.Size(53, 17)
        Me.cb922_6.TabIndex = 31
        Me.cb922_6.Text = "922.6"
        Me.cb922_6.UseVisualStyleBackColor = True
        '
        'cb922_4
        '
        Me.cb922_4.AutoSize = True
        Me.cb922_4.Location = New System.Drawing.Point(244, 46)
        Me.cb922_4.Name = "cb922_4"
        Me.cb922_4.Size = New System.Drawing.Size(53, 17)
        Me.cb922_4.TabIndex = 30
        Me.cb922_4.Text = "922.4"
        Me.cb922_4.UseVisualStyleBackColor = True
        '
        'cb922_2
        '
        Me.cb922_2.AutoSize = True
        Me.cb922_2.Location = New System.Drawing.Point(184, 46)
        Me.cb922_2.Name = "cb922_2"
        Me.cb922_2.Size = New System.Drawing.Size(53, 17)
        Me.cb922_2.TabIndex = 29
        Me.cb922_2.Text = "922.2"
        Me.cb922_2.UseVisualStyleBackColor = True
        '
        'cb922_0
        '
        Me.cb922_0.AutoSize = True
        Me.cb922_0.Location = New System.Drawing.Point(127, 46)
        Me.cb922_0.Name = "cb922_0"
        Me.cb922_0.Size = New System.Drawing.Size(53, 17)
        Me.cb922_0.TabIndex = 28
        Me.cb922_0.Text = "922.0"
        Me.cb922_0.UseVisualStyleBackColor = True
        '
        'cb921_8
        '
        Me.cb921_8.AutoSize = True
        Me.cb921_8.Location = New System.Drawing.Point(70, 46)
        Me.cb921_8.Name = "cb921_8"
        Me.cb921_8.Size = New System.Drawing.Size(53, 17)
        Me.cb921_8.TabIndex = 27
        Me.cb921_8.Text = "921.8"
        Me.cb921_8.UseVisualStyleBackColor = True
        '
        'cb921_6
        '
        Me.cb921_6.AutoSize = True
        Me.cb921_6.Location = New System.Drawing.Point(7, 46)
        Me.cb921_6.Name = "cb921_6"
        Me.cb921_6.Size = New System.Drawing.Size(53, 17)
        Me.cb921_6.TabIndex = 26
        Me.cb921_6.Text = "921.6"
        Me.cb921_6.UseVisualStyleBackColor = True
        '
        'cb921_4
        '
        Me.cb921_4.AutoSize = True
        Me.cb921_4.Location = New System.Drawing.Point(70, 70)
        Me.cb921_4.Name = "cb921_4"
        Me.cb921_4.Size = New System.Drawing.Size(53, 17)
        Me.cb921_4.TabIndex = 25
        Me.cb921_4.Text = "921.4"
        Me.cb921_4.UseVisualStyleBackColor = True
        '
        'cb921_2
        '
        Me.cb921_2.AutoSize = True
        Me.cb921_2.Location = New System.Drawing.Point(7, 70)
        Me.cb921_2.Name = "cb921_2"
        Me.cb921_2.Size = New System.Drawing.Size(53, 17)
        Me.cb921_2.TabIndex = 24
        Me.cb921_2.Text = "921.2"
        Me.cb921_2.UseVisualStyleBackColor = True
        '
        'cb921_0
        '
        Me.cb921_0.AutoSize = True
        Me.cb921_0.Location = New System.Drawing.Point(363, 22)
        Me.cb921_0.Name = "cb921_0"
        Me.cb921_0.Size = New System.Drawing.Size(53, 17)
        Me.cb921_0.TabIndex = 23
        Me.cb921_0.Text = "921.0"
        Me.cb921_0.UseVisualStyleBackColor = True
        '
        'cb920_8
        '
        Me.cb920_8.AutoSize = True
        Me.cb920_8.Location = New System.Drawing.Point(304, 22)
        Me.cb920_8.Name = "cb920_8"
        Me.cb920_8.Size = New System.Drawing.Size(53, 17)
        Me.cb920_8.TabIndex = 22
        Me.cb920_8.Text = "920.8"
        Me.cb920_8.UseVisualStyleBackColor = True
        '
        'cb920_6
        '
        Me.cb920_6.AutoSize = True
        Me.cb920_6.Location = New System.Drawing.Point(244, 22)
        Me.cb920_6.Name = "cb920_6"
        Me.cb920_6.Size = New System.Drawing.Size(53, 17)
        Me.cb920_6.TabIndex = 21
        Me.cb920_6.Text = "920.6"
        Me.cb920_6.UseVisualStyleBackColor = True
        '
        'cb920_4
        '
        Me.cb920_4.AutoSize = True
        Me.cb920_4.Location = New System.Drawing.Point(184, 22)
        Me.cb920_4.Name = "cb920_4"
        Me.cb920_4.Size = New System.Drawing.Size(53, 17)
        Me.cb920_4.TabIndex = 20
        Me.cb920_4.Text = "920.4"
        Me.cb920_4.UseVisualStyleBackColor = True
        '
        'cb919_2
        '
        Me.cb919_2.AutoSize = True
        Me.cb919_2.Location = New System.Drawing.Point(127, 22)
        Me.cb919_2.Name = "cb919_2"
        Me.cb919_2.Size = New System.Drawing.Size(53, 17)
        Me.cb919_2.TabIndex = 19
        Me.cb919_2.Text = "919.2"
        Me.cb919_2.UseVisualStyleBackColor = True
        '
        'cb918_0
        '
        Me.cb918_0.AutoSize = True
        Me.cb918_0.Location = New System.Drawing.Point(70, 22)
        Me.cb918_0.Name = "cb918_0"
        Me.cb918_0.Size = New System.Drawing.Size(53, 17)
        Me.cb918_0.TabIndex = 18
        Me.cb918_0.Text = "918.0"
        Me.cb918_0.UseVisualStyleBackColor = True
        '
        'cb916_8
        '
        Me.cb916_8.AutoSize = True
        Me.cb916_8.Location = New System.Drawing.Point(7, 22)
        Me.cb916_8.Name = "cb916_8"
        Me.cb916_8.Size = New System.Drawing.Size(53, 17)
        Me.cb916_8.TabIndex = 17
        Me.cb916_8.Text = "916.8"
        Me.cb916_8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 25)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Set Frequency"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbTaiwanFrequency
        '
        Me.gbTaiwanFrequency.Controls.Add(Me.cb920_25)
        Me.gbTaiwanFrequency.Controls.Add(Me.cb922_25)
        Me.gbTaiwanFrequency.Controls.Add(Me.Button2)
        Me.gbTaiwanFrequency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbTaiwanFrequency.Location = New System.Drawing.Point(447, 2)
        Me.gbTaiwanFrequency.Margin = New System.Windows.Forms.Padding(2)
        Me.gbTaiwanFrequency.Name = "gbTaiwanFrequency"
        Me.gbTaiwanFrequency.Padding = New System.Windows.Forms.Padding(2)
        Me.gbTaiwanFrequency.Size = New System.Drawing.Size(145, 95)
        Me.gbTaiwanFrequency.TabIndex = 19
        Me.gbTaiwanFrequency.TabStop = False
        Me.gbTaiwanFrequency.Text = "Taiwan"
        '
        'cb920_25
        '
        Me.cb920_25.AutoSize = True
        Me.cb920_25.Location = New System.Drawing.Point(7, 22)
        Me.cb920_25.Name = "cb920_25"
        Me.cb920_25.Size = New System.Drawing.Size(59, 17)
        Me.cb920_25.TabIndex = 24
        Me.cb920_25.Text = "920.25"
        Me.cb920_25.UseVisualStyleBackColor = True
        '
        'cb922_25
        '
        Me.cb922_25.AutoSize = True
        Me.cb922_25.Location = New System.Drawing.Point(70, 22)
        Me.cb922_25.Name = "cb922_25"
        Me.cb922_25.Size = New System.Drawing.Size(59, 17)
        Me.cb922_25.TabIndex = 23
        Me.cb922_25.Text = "922.25"
        Me.cb922_25.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(432, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 25)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Set Frequency"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnGetFrequency, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnSetFrequency, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 498)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(588, 118)
        Me.TableLayoutPanel4.TabIndex = 35
        '
        'btnGetFrequency
        '
        Me.btnGetFrequency.Location = New System.Drawing.Point(444, 3)
        Me.btnGetFrequency.Name = "btnGetFrequency"
        Me.btnGetFrequency.Size = New System.Drawing.Size(70, 25)
        Me.btnGetFrequency.TabIndex = 23
        Me.btnGetFrequency.Text = "Obtener"
        Me.btnGetFrequency.UseVisualStyleBackColor = True
        '
        'btnSetFrequency
        '
        Me.btnSetFrequency.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetFrequency.Location = New System.Drawing.Point(368, 3)
        Me.btnSetFrequency.Name = "btnSetFrequency"
        Me.btnSetFrequency.Size = New System.Drawing.Size(70, 25)
        Me.btnSetFrequency.TabIndex = 22
        Me.btnSetFrequency.Text = "Establecer"
        Me.btnSetFrequency.UseVisualStyleBackColor = True
        '
        'tpInventory
        '
        Me.tpInventory.Controls.Add(Me.gbxInventoryEx)
        Me.tpInventory.Location = New System.Drawing.Point(4, 44)
        Me.tpInventory.Name = "tpInventory"
        Me.tpInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInventory.Size = New System.Drawing.Size(1195, 625)
        Me.tpInventory.TabIndex = 2
        Me.tpInventory.Text = "Vincular"
        Me.tpInventory.UseVisualStyleBackColor = True
        '
        'gbxInventoryEx
        '
        Me.gbxInventoryEx.Controls.Add(Me.tablaContenedorTimbrado)
        Me.gbxInventoryEx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxInventoryEx.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.gbxInventoryEx.Location = New System.Drawing.Point(3, 3)
        Me.gbxInventoryEx.Margin = New System.Windows.Forms.Padding(0)
        Me.gbxInventoryEx.Name = "gbxInventoryEx"
        Me.gbxInventoryEx.Size = New System.Drawing.Size(1189, 619)
        Me.gbxInventoryEx.TabIndex = 8
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
        Me.tablaContenedorTimbrado.Size = New System.Drawing.Size(1183, 600)
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
        Me.tabaLadoTimbrado.Size = New System.Drawing.Size(1183, 600)
        Me.tabaLadoTimbrado.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.op, Me.corte, Me.subcorte, Me.talla, Me.cod_talla, Me.linea, Me.id_talla, Me.fecha, Me.id_rfid})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(3, 171)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1177, 426)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1183, 126)
        Me.TableLayoutPanel1.TabIndex = 44
        '
        'btnLimpiarRFID
        '
        Me.btnLimpiarRFID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpiarRFID.Location = New System.Drawing.Point(476, 50)
        Me.btnLimpiarRFID.Name = "btnLimpiarRFID"
        Me.btnLimpiarRFID.Size = New System.Drawing.Size(171, 41)
        Me.btnLimpiarRFID.TabIndex = 51
        Me.btnLimpiarRFID.Text = "Limpiar"
        Me.btnLimpiarRFID.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(476, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(171, 41)
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
        Me.cantidadRFID.ForeColor = System.Drawing.Color.Red
        Me.cantidadRFID.Location = New System.Drawing.Point(653, 3)
        Me.cantidadRFID.Margin = New System.Windows.Forms.Padding(3)
        Me.cantidadRFID.Name = "cantidadRFID"
        Me.TableLayoutPanel1.SetRowSpan(Me.cantidadRFID, 2)
        Me.cantidadRFID.Size = New System.Drawing.Size(112, 88)
        Me.cantidadRFID.TabIndex = 48
        Me.cantidadRFID.Text = "0"
        Me.cantidadRFID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MsnVincular
        '
        Me.MsnVincular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MsnVincular.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.MsnVincular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.MsnVincular, 3)
        Me.MsnVincular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsnVincular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MsnVincular.Location = New System.Drawing.Point(3, 97)
        Me.MsnVincular.Margin = New System.Windows.Forms.Padding(3)
        Me.MsnVincular.Name = "MsnVincular"
        Me.MsnVincular.Size = New System.Drawing.Size(762, 26)
        Me.MsnVincular.TabIndex = 28
        Me.MsnVincular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvTagList
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvTagList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTagList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTagList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTagList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTagList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTagList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTagList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnEPC, Me.clnTID, Me.clnCount})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTagList.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTagList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTagList.EnableHeadersVisualStyles = False
        Me.dgvTagList.GridColor = System.Drawing.Color.LightGray
        Me.dgvTagList.Location = New System.Drawing.Point(771, 3)
        Me.dgvTagList.Name = "dgvTagList"
        Me.dgvTagList.ReadOnly = True
        Me.dgvTagList.RowHeadersVisible = False
        Me.TableLayoutPanel1.SetRowSpan(Me.dgvTagList, 3)
        Me.dgvTagList.RowTemplate.Height = 24
        Me.dgvTagList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTagList.Size = New System.Drawing.Size(409, 120)
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
        Me.CodBarras.ForeColor = System.Drawing.Color.Gray
        Me.CodBarras.Location = New System.Drawing.Point(3, 32)
        Me.CodBarras.Name = "CodBarras"
        Me.TableLayoutPanel1.SetRowSpan(Me.CodBarras, 2)
        Me.CodBarras.Size = New System.Drawing.Size(467, 30)
        Me.CodBarras.TabIndex = 25
        Me.CodBarras.Text = "Codigo de Barras..."
        Me.CodBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pruebaCodigos, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTotalCount, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 126)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1183, 36)
        Me.TableLayoutPanel2.TabIndex = 46
        '
        'pruebaCodigos
        '
        Me.pruebaCodigos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pruebaCodigos.AutoSize = True
        Me.pruebaCodigos.Location = New System.Drawing.Point(672, 11)
        Me.pruebaCodigos.Name = "pruebaCodigos"
        Me.pruebaCodigos.Size = New System.Drawing.Size(14, 13)
        Me.pruebaCodigos.TabIndex = 50
        Me.pruebaCodigos.Text = "~"
        Me.pruebaCodigos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.pruebaCodigos.Visible = False
        '
        'lblTotalCount
        '
        Me.lblTotalCount.AutoSize = True
        Me.lblTotalCount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTotalCount.ForeColor = System.Drawing.Color.Red
        Me.lblTotalCount.Location = New System.Drawing.Point(357, 16)
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
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(348, 20)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "La Cantidad De Prendas Timbradas Es:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 162)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1183, 6)
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
        Me.cbxInventory.Location = New System.Drawing.Point(782, 2)
        Me.cbxInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxInventory.Name = "cbxInventory"
        Me.cbxInventory.Size = New System.Drawing.Size(93, 21)
        Me.cbxInventory.TabIndex = 34
        Me.cbxInventory.Visible = False
        '
        'btnStartInventoryEx
        '
        Me.btnStartInventoryEx.Location = New System.Drawing.Point(393, 3)
        Me.btnStartInventoryEx.Name = "btnStartInventoryEx"
        Me.btnStartInventoryEx.Size = New System.Drawing.Size(65, 1)
        Me.btnStartInventoryEx.TabIndex = 29
        Me.btnStartInventoryEx.TabStop = False
        Me.btnStartInventoryEx.Text = "Start"
        Me.btnStartInventoryEx.UseVisualStyleBackColor = True
        Me.btnStartInventoryEx.Visible = False
        '
        'tpSearch
        '
        Me.tpSearch.Controls.Add(Me.gbxBuscarPrenda)
        Me.tpSearch.Location = New System.Drawing.Point(4, 44)
        Me.tpSearch.Name = "tpSearch"
        Me.tpSearch.Size = New System.Drawing.Size(1195, 625)
        Me.tpSearch.TabIndex = 4
        Me.tpSearch.Text = "Consulta Prenda"
        Me.tpSearch.UseVisualStyleBackColor = True
        '
        'gbxBuscarPrenda
        '
        Me.gbxBuscarPrenda.Controls.Add(Me.tablaBuscarPrenda)
        Me.gbxBuscarPrenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxBuscarPrenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBuscarPrenda.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.gbxBuscarPrenda.Location = New System.Drawing.Point(0, 0)
        Me.gbxBuscarPrenda.Margin = New System.Windows.Forms.Padding(0)
        Me.gbxBuscarPrenda.Name = "gbxBuscarPrenda"
        Me.gbxBuscarPrenda.Size = New System.Drawing.Size(1195, 625)
        Me.gbxBuscarPrenda.TabIndex = 0
        Me.gbxBuscarPrenda.TabStop = False
        '
        'tablaBuscarPrenda
        '
        Me.tablaBuscarPrenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablaBuscarPrenda.ColumnCount = 1
        Me.tablaBuscarPrenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaBuscarPrenda.Controls.Add(Me.ContenedorBuscarPrenda, 0, 0)
        Me.tablaBuscarPrenda.Controls.Add(Me.MsnBusquedaPrenda, 0, 1)
        Me.tablaBuscarPrenda.Controls.Add(Me.DataGridView2, 0, 2)
        Me.tablaBuscarPrenda.Location = New System.Drawing.Point(6, 19)
        Me.tablaBuscarPrenda.Margin = New System.Windows.Forms.Padding(0)
        Me.tablaBuscarPrenda.Name = "tablaBuscarPrenda"
        Me.tablaBuscarPrenda.RowCount = 3
        Me.tablaBuscarPrenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablaBuscarPrenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tablaBuscarPrenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.tablaBuscarPrenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tablaBuscarPrenda.Size = New System.Drawing.Size(1189, 606)
        Me.tablaBuscarPrenda.TabIndex = 0
        '
        'ContenedorBuscarPrenda
        '
        Me.ContenedorBuscarPrenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContenedorBuscarPrenda.ColumnCount = 3
        Me.ContenedorBuscarPrenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.ContenedorBuscarPrenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.ContenedorBuscarPrenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.ContenedorBuscarPrenda.Controls.Add(Me.Label5, 0, 0)
        Me.ContenedorBuscarPrenda.Controls.Add(Me.BuscarCodBarras, 1, 0)
        Me.ContenedorBuscarPrenda.Location = New System.Drawing.Point(0, 0)
        Me.ContenedorBuscarPrenda.Margin = New System.Windows.Forms.Padding(0)
        Me.ContenedorBuscarPrenda.Name = "ContenedorBuscarPrenda"
        Me.ContenedorBuscarPrenda.RowCount = 1
        Me.ContenedorBuscarPrenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ContenedorBuscarPrenda.Size = New System.Drawing.Size(1189, 60)
        Me.ContenedorBuscarPrenda.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(135, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código Barras"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BuscarCodBarras
        '
        Me.BuscarCodBarras.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscarCodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarCodBarras.ForeColor = System.Drawing.Color.Gray
        Me.BuscarCodBarras.Location = New System.Drawing.Point(264, 15)
        Me.BuscarCodBarras.Name = "BuscarCodBarras"
        Me.BuscarCodBarras.Size = New System.Drawing.Size(707, 30)
        Me.BuscarCodBarras.TabIndex = 1
        Me.BuscarCodBarras.Text = "Codigo de Barras..."
        '
        'MsnBusquedaPrenda
        '
        Me.MsnBusquedaPrenda.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MsnBusquedaPrenda.AutoSize = True
        Me.MsnBusquedaPrenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsnBusquedaPrenda.ForeColor = System.Drawing.Color.Red
        Me.MsnBusquedaPrenda.Location = New System.Drawing.Point(3, 66)
        Me.MsnBusquedaPrenda.Name = "MsnBusquedaPrenda"
        Me.MsnBusquedaPrenda.Size = New System.Drawing.Size(0, 17)
        Me.MsnBusquedaPrenda.TabIndex = 1
        Me.MsnBusquedaPrenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(3, 93)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1183, 510)
        Me.DataGridView2.TabIndex = 2
        '
        'tpPapper
        '
        Me.tpPapper.Controls.Add(Me.TablaContenedorHM)
        Me.tpPapper.Location = New System.Drawing.Point(4, 44)
        Me.tpPapper.Name = "tpPapper"
        Me.tpPapper.Size = New System.Drawing.Size(1195, 625)
        Me.tpPapper.TabIndex = 5
        Me.tpPapper.Text = "Hoja de Marcación"
        Me.tpPapper.UseVisualStyleBackColor = True
        '
        'TablaContenedorHM
        '
        Me.TablaContenedorHM.ColumnCount = 1
        Me.TablaContenedorHM.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TablaContenedorHM.Controls.Add(Me.tabaCabecera, 0, 0)
        Me.TablaContenedorHM.Controls.Add(Me.tableCabecera, 0, 1)
        Me.TablaContenedorHM.Controls.Add(Me.DataGridView3, 0, 3)
        Me.TablaContenedorHM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablaContenedorHM.Location = New System.Drawing.Point(0, 0)
        Me.TablaContenedorHM.Name = "TablaContenedorHM"
        Me.TablaContenedorHM.RowCount = 4
        Me.TablaContenedorHM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TablaContenedorHM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.TablaContenedorHM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TablaContenedorHM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TablaContenedorHM.Size = New System.Drawing.Size(1195, 625)
        Me.TablaContenedorHM.TabIndex = 2
        '
        'tabaCabecera
        '
        Me.tabaCabecera.ColumnCount = 6
        Me.tabaCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tabaCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tabaCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.tabaCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabaCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
        Me.tabaCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
        Me.tabaCabecera.Controls.Add(Me.TextBoxOP, 1, 0)
        Me.tabaCabecera.Controls.Add(Me.LabelOP, 0, 0)
        Me.tabaCabecera.Controls.Add(Me.BtnBuscarHM, 4, 0)
        Me.tabaCabecera.Controls.Add(Me.TextBoxHM, 3, 0)
        Me.tabaCabecera.Controls.Add(Me.LabelHM, 2, 0)
        Me.tabaCabecera.Controls.Add(Me.BtnLimpiarHM, 5, 0)
        Me.tabaCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabaCabecera.Location = New System.Drawing.Point(0, 0)
        Me.tabaCabecera.Margin = New System.Windows.Forms.Padding(0)
        Me.tabaCabecera.Name = "tabaCabecera"
        Me.tabaCabecera.RowCount = 1
        Me.tabaCabecera.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tabaCabecera.Size = New System.Drawing.Size(1195, 62)
        Me.tabaCabecera.TabIndex = 0
        '
        'TextBoxOP
        '
        Me.TextBoxOP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxOP.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxOP.Location = New System.Drawing.Point(218, 21)
        Me.TextBoxOP.Name = "TextBoxOP"
        Me.TextBoxOP.Size = New System.Drawing.Size(292, 20)
        Me.TextBoxOP.TabIndex = 2
        Me.TextBoxOP.Text = "Nro OP..."
        '
        'LabelOP
        '
        Me.LabelOP.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelOP.AutoSize = True
        Me.LabelOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOP.Location = New System.Drawing.Point(176, 24)
        Me.LabelOP.Name = "LabelOP"
        Me.LabelOP.Size = New System.Drawing.Size(36, 13)
        Me.LabelOP.TabIndex = 0
        Me.LabelOP.Text = "O.P.:"
        Me.LabelOP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnBuscarHM
        '
        Me.BtnBuscarHM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnBuscarHM.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarHM.Location = New System.Drawing.Point(828, 21)
        Me.BtnBuscarHM.Name = "BtnBuscarHM"
        Me.BtnBuscarHM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnBuscarHM.Size = New System.Drawing.Size(49, 20)
        Me.BtnBuscarHM.TabIndex = 4
        Me.BtnBuscarHM.Text = "Buscar"
        '
        'TextBoxHM
        '
        Me.TextBoxHM.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxHM.Enabled = False
        Me.TextBoxHM.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxHM.Location = New System.Drawing.Point(623, 21)
        Me.TextBoxHM.Name = "TextBoxHM"
        Me.TextBoxHM.Size = New System.Drawing.Size(113, 20)
        Me.TextBoxHM.TabIndex = 3
        Me.TextBoxHM.Text = "H. M...."
        '
        'LabelHM
        '
        Me.LabelHM.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelHM.AutoSize = True
        Me.LabelHM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHM.Location = New System.Drawing.Point(579, 24)
        Me.LabelHM.Name = "LabelHM"
        Me.LabelHM.Size = New System.Drawing.Size(38, 13)
        Me.LabelHM.TabIndex = 1
        Me.LabelHM.Text = "H.M.:"
        Me.LabelHM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnLimpiarHM
        '
        Me.BtnLimpiarHM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLimpiarHM.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiarHM.Location = New System.Drawing.Point(1054, 19)
        Me.BtnLimpiarHM.Name = "BtnLimpiarHM"
        Me.BtnLimpiarHM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnLimpiarHM.Size = New System.Drawing.Size(52, 23)
        Me.BtnLimpiarHM.TabIndex = 5
        Me.BtnLimpiarHM.Text = "Limpiar"
        Me.BtnLimpiarHM.UseVisualStyleBackColor = True
        '
        'tableCabecera
        '
        Me.tableCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.tableCabecera.ColumnCount = 10
        Me.tableCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableCabecera.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableCabecera.Controls.Add(Me.lbl_op, 0, 0)
        Me.tableCabecera.Controls.Add(Me.lbl_cliente, 0, 1)
        Me.tableCabecera.Controls.Add(Me.lbl_shipTo, 0, 2)
        Me.tableCabecera.Controls.Add(Me.lbl_Despacho, 0, 5)
        Me.tableCabecera.Controls.Add(Me.lbl_empaque, 0, 6)
        Me.tableCabecera.Controls.Add(Me.lbl_HM, 2, 0)
        Me.tableCabecera.Controls.Add(Me.lbl_po, 4, 0)
        Me.tableCabecera.Controls.Add(Me.lbl_Estado, 6, 0)
        Me.tableCabecera.Controls.Add(Me.lbl_Reserva, 8, 0)
        Me.tableCabecera.Controls.Add(Me.lbl_Prenda, 6, 1)
        Me.tableCabecera.Controls.Add(Me.lbl_direccion_1, 6, 2)
        Me.tableCabecera.Controls.Add(Me.lbl_direccion_2, 6, 3)
        Me.tableCabecera.Controls.Add(Me.lbl_Tolerancia, 2, 4)
        Me.tableCabecera.Controls.Add(Me.lbl_Estilo, 4, 4)
        Me.tableCabecera.Controls.Add(Me.lbl_Observacion, 5, 6)
        Me.tableCabecera.Controls.Add(Me.lbl_Certificado, 5, 5)
        Me.tableCabecera.Controls.Add(Me.lbl_NKit, 3, 5)
        Me.tableCabecera.Controls.Add(Me.text_norpd, 1, 0)
        Me.tableCabecera.Controls.Add(Me.text_npocl, 5, 0)
        Me.tableCabecera.Controls.Add(Me.text_nhjmr, 3, 0)
        Me.tableCabecera.Controls.Add(Me.text_sesthm, 7, 0)
        Me.tableCabecera.Controls.Add(Me.text_sreserva, 9, 0)
        Me.tableCabecera.Controls.Add(Me.text_cclnt, 1, 1)
        Me.tableCabecera.Controls.Add(Me.text_ttrcr, 2, 1)
        Me.tableCabecera.Controls.Add(Me.text_tdscr, 7, 1)
        Me.tableCabecera.Controls.Add(Me.text_temporada, 8, 1)
        Me.tableCabecera.Controls.Add(Me.lbl_SitDespacho, 8, 4)
        Me.tableCabecera.Controls.Add(Me.text_tdrcc, 7, 2)
        Me.tableCabecera.Controls.Add(Me.txt_Direccion_2, 7, 3)
        Me.tableCabecera.Controls.Add(Me.text_clgren, 1, 2)
        Me.tableCabecera.Controls.Add(Me.lbl_fEntrega, 0, 4)
        Me.tableCabecera.Controls.Add(Me.text_fentr, 1, 4)
        Me.tableCabecera.Controls.Add(Me.lbl_BillTo, 0, 3)
        Me.tableCabecera.Controls.Add(Me.text_tlgen, 2, 2)
        Me.tableCabecera.Controls.Add(Me.text_ptlrnc, 3, 4)
        Me.tableCabecera.Controls.Add(Me.text_cestcl, 5, 4)
        Me.tableCabecera.Controls.Add(Me.text_testcl, 6, 4)
        Me.tableCabecera.Controls.Add(Me.text_flgdes, 9, 4)
        Me.tableCabecera.Controls.Add(Me.text_tvia, 1, 5)
        Me.tableCabecera.Controls.Add(Me.txt_nro_kit, 4, 5)
        Me.tableCabecera.Controls.Add(Me.text_nro_certificado, 6, 5)
        Me.tableCabecera.Controls.Add(Me.text_totros, 6, 6)
        Me.tableCabecera.Controls.Add(Me.text_tfrmem, 1, 6)
        Me.tableCabecera.Controls.Add(Me.text_cod_lugrent_cobro, 1, 3)
        Me.tableCabecera.Controls.Add(Me.txt_BillToDet, 2, 3)
        Me.tableCabecera.Location = New System.Drawing.Point(0, 62)
        Me.tableCabecera.Margin = New System.Windows.Forms.Padding(0)
        Me.tableCabecera.Name = "tableCabecera"
        Me.tableCabecera.Padding = New System.Windows.Forms.Padding(3)
        Me.tableCabecera.RowCount = 7
        Me.tableCabecera.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.26531!))
        Me.tableCabecera.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.26531!))
        Me.tableCabecera.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.26531!))
        Me.tableCabecera.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.26531!))
        Me.tableCabecera.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.26531!))
        Me.tableCabecera.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.26531!))
        Me.tableCabecera.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816!))
        Me.tableCabecera.Size = New System.Drawing.Size(1195, 300)
        Me.tableCabecera.TabIndex = 1
        '
        'lbl_op
        '
        Me.lbl_op.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_op.AutoSize = True
        Me.lbl_op.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_op.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_op.Location = New System.Drawing.Point(6, 3)
        Me.lbl_op.Name = "lbl_op"
        Me.lbl_op.Size = New System.Drawing.Size(112, 39)
        Me.lbl_op.TabIndex = 0
        Me.lbl_op.Text = "OP:"
        Me.lbl_op.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cliente
        '
        Me.lbl_cliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.Location = New System.Drawing.Point(6, 42)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(112, 39)
        Me.lbl_cliente.TabIndex = 1
        Me.lbl_cliente.Text = "Cliente:"
        Me.lbl_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_shipTo
        '
        Me.lbl_shipTo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_shipTo.AutoSize = True
        Me.lbl_shipTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_shipTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shipTo.Location = New System.Drawing.Point(6, 81)
        Me.lbl_shipTo.Name = "lbl_shipTo"
        Me.lbl_shipTo.Size = New System.Drawing.Size(112, 39)
        Me.lbl_shipTo.TabIndex = 2
        Me.lbl_shipTo.Text = "Ship TO:"
        Me.lbl_shipTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Despacho
        '
        Me.lbl_Despacho.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Despacho.AutoSize = True
        Me.lbl_Despacho.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_Despacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Despacho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Despacho.Location = New System.Drawing.Point(6, 198)
        Me.lbl_Despacho.Name = "lbl_Despacho"
        Me.lbl_Despacho.Size = New System.Drawing.Size(112, 39)
        Me.lbl_Despacho.TabIndex = 5
        Me.lbl_Despacho.Text = "Via Despacho:"
        Me.lbl_Despacho.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_empaque
        '
        Me.lbl_empaque.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empaque.AutoSize = True
        Me.lbl_empaque.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_empaque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empaque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_empaque.Location = New System.Drawing.Point(6, 237)
        Me.lbl_empaque.Name = "lbl_empaque"
        Me.lbl_empaque.Size = New System.Drawing.Size(112, 60)
        Me.lbl_empaque.TabIndex = 6
        Me.lbl_empaque.Text = "Empaque:"
        Me.lbl_empaque.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_HM
        '
        Me.lbl_HM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_HM.AutoSize = True
        Me.lbl_HM.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_HM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HM.Location = New System.Drawing.Point(242, 3)
        Me.lbl_HM.Name = "lbl_HM"
        Me.lbl_HM.Size = New System.Drawing.Size(112, 39)
        Me.lbl_HM.TabIndex = 7
        Me.lbl_HM.Text = "HM:"
        Me.lbl_HM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_po
        '
        Me.lbl_po.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_po.AutoSize = True
        Me.lbl_po.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_po.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_po.Location = New System.Drawing.Point(478, 3)
        Me.lbl_po.Name = "lbl_po"
        Me.lbl_po.Size = New System.Drawing.Size(112, 39)
        Me.lbl_po.TabIndex = 8
        Me.lbl_po.Text = "PO:"
        Me.lbl_po.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Estado
        '
        Me.lbl_Estado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Estado.Location = New System.Drawing.Point(714, 3)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(112, 39)
        Me.lbl_Estado.TabIndex = 9
        Me.lbl_Estado.Text = "Estado:"
        Me.lbl_Estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Reserva
        '
        Me.lbl_Reserva.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Reserva.AutoSize = True
        Me.lbl_Reserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_Reserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Reserva.Location = New System.Drawing.Point(950, 3)
        Me.lbl_Reserva.Name = "lbl_Reserva"
        Me.lbl_Reserva.Size = New System.Drawing.Size(112, 39)
        Me.lbl_Reserva.TabIndex = 10
        Me.lbl_Reserva.Text = "Reserva:"
        Me.lbl_Reserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Prenda
        '
        Me.lbl_Prenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Prenda.AutoSize = True
        Me.lbl_Prenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_Prenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prenda.Location = New System.Drawing.Point(714, 42)
        Me.lbl_Prenda.Name = "lbl_Prenda"
        Me.lbl_Prenda.Size = New System.Drawing.Size(112, 39)
        Me.lbl_Prenda.TabIndex = 11
        Me.lbl_Prenda.Text = "Prenda:"
        Me.lbl_Prenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_direccion_1
        '
        Me.lbl_direccion_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_direccion_1.AutoSize = True
        Me.lbl_direccion_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_direccion_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion_1.Location = New System.Drawing.Point(714, 81)
        Me.lbl_direccion_1.Name = "lbl_direccion_1"
        Me.lbl_direccion_1.Size = New System.Drawing.Size(112, 39)
        Me.lbl_direccion_1.TabIndex = 12
        Me.lbl_direccion_1.Text = "Dirección:"
        Me.lbl_direccion_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_direccion_2
        '
        Me.lbl_direccion_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_direccion_2.AutoSize = True
        Me.lbl_direccion_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_direccion_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion_2.Location = New System.Drawing.Point(714, 120)
        Me.lbl_direccion_2.Name = "lbl_direccion_2"
        Me.lbl_direccion_2.Size = New System.Drawing.Size(112, 39)
        Me.lbl_direccion_2.TabIndex = 13
        Me.lbl_direccion_2.Text = "Dirección:"
        Me.lbl_direccion_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Tolerancia
        '
        Me.lbl_Tolerancia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Tolerancia.AutoSize = True
        Me.lbl_Tolerancia.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_Tolerancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tolerancia.Location = New System.Drawing.Point(242, 159)
        Me.lbl_Tolerancia.Name = "lbl_Tolerancia"
        Me.lbl_Tolerancia.Size = New System.Drawing.Size(112, 39)
        Me.lbl_Tolerancia.TabIndex = 14
        Me.lbl_Tolerancia.Text = "Tolerancia:"
        Me.lbl_Tolerancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Estilo
        '
        Me.lbl_Estilo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Estilo.AutoSize = True
        Me.lbl_Estilo.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_Estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Estilo.Location = New System.Drawing.Point(478, 159)
        Me.lbl_Estilo.Name = "lbl_Estilo"
        Me.lbl_Estilo.Size = New System.Drawing.Size(112, 39)
        Me.lbl_Estilo.TabIndex = 15
        Me.lbl_Estilo.Text = "Estilo:"
        Me.lbl_Estilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Observacion
        '
        Me.lbl_Observacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Observacion.AutoSize = True
        Me.lbl_Observacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_Observacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Observacion.Location = New System.Drawing.Point(596, 237)
        Me.lbl_Observacion.Name = "lbl_Observacion"
        Me.lbl_Observacion.Size = New System.Drawing.Size(112, 60)
        Me.lbl_Observacion.TabIndex = 18
        Me.lbl_Observacion.Text = "Observación:"
        Me.lbl_Observacion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Certificado
        '
        Me.lbl_Certificado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Certificado.AutoSize = True
        Me.lbl_Certificado.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_Certificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Certificado.Location = New System.Drawing.Point(596, 198)
        Me.lbl_Certificado.Name = "lbl_Certificado"
        Me.lbl_Certificado.Size = New System.Drawing.Size(112, 39)
        Me.lbl_Certificado.TabIndex = 17
        Me.lbl_Certificado.Text = "Certificado:"
        Me.lbl_Certificado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_NKit
        '
        Me.lbl_NKit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_NKit.AutoSize = True
        Me.lbl_NKit.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_NKit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NKit.Location = New System.Drawing.Point(360, 198)
        Me.lbl_NKit.Name = "lbl_NKit"
        Me.lbl_NKit.Size = New System.Drawing.Size(112, 39)
        Me.lbl_NKit.TabIndex = 19
        Me.lbl_NKit.Text = "N° KIT:"
        Me.lbl_NKit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'text_norpd
        '
        Me.text_norpd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_norpd.AutoSize = True
        Me.text_norpd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.text_norpd.Location = New System.Drawing.Point(124, 3)
        Me.text_norpd.Name = "text_norpd"
        Me.text_norpd.Size = New System.Drawing.Size(112, 39)
        Me.text_norpd.TabIndex = 20
        Me.text_norpd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_npocl
        '
        Me.text_npocl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_npocl.AutoSize = True
        Me.text_npocl.Location = New System.Drawing.Point(596, 3)
        Me.text_npocl.Name = "text_npocl"
        Me.text_npocl.Size = New System.Drawing.Size(112, 39)
        Me.text_npocl.TabIndex = 21
        Me.text_npocl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_nhjmr
        '
        Me.text_nhjmr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_nhjmr.AutoSize = True
        Me.text_nhjmr.Location = New System.Drawing.Point(360, 3)
        Me.text_nhjmr.Name = "text_nhjmr"
        Me.text_nhjmr.Size = New System.Drawing.Size(112, 39)
        Me.text_nhjmr.TabIndex = 22
        Me.text_nhjmr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_sesthm
        '
        Me.text_sesthm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_sesthm.AutoSize = True
        Me.text_sesthm.Location = New System.Drawing.Point(832, 3)
        Me.text_sesthm.Name = "text_sesthm"
        Me.text_sesthm.Size = New System.Drawing.Size(112, 39)
        Me.text_sesthm.TabIndex = 23
        Me.text_sesthm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_sreserva
        '
        Me.text_sreserva.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_sreserva.AutoSize = True
        Me.text_sreserva.Location = New System.Drawing.Point(1068, 3)
        Me.text_sreserva.Name = "text_sreserva"
        Me.text_sreserva.Size = New System.Drawing.Size(121, 39)
        Me.text_sreserva.TabIndex = 24
        Me.text_sreserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_cclnt
        '
        Me.text_cclnt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_cclnt.AutoSize = True
        Me.text_cclnt.Location = New System.Drawing.Point(124, 42)
        Me.text_cclnt.Name = "text_cclnt"
        Me.text_cclnt.Size = New System.Drawing.Size(112, 39)
        Me.text_cclnt.TabIndex = 25
        Me.text_cclnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_ttrcr
        '
        Me.text_ttrcr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_ttrcr.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.text_ttrcr, 4)
        Me.text_ttrcr.Location = New System.Drawing.Point(242, 42)
        Me.text_ttrcr.Name = "text_ttrcr"
        Me.text_ttrcr.Size = New System.Drawing.Size(466, 39)
        Me.text_ttrcr.TabIndex = 26
        Me.text_ttrcr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_tdscr
        '
        Me.text_tdscr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_tdscr.AutoSize = True
        Me.text_tdscr.Location = New System.Drawing.Point(832, 42)
        Me.text_tdscr.Name = "text_tdscr"
        Me.text_tdscr.Size = New System.Drawing.Size(112, 39)
        Me.text_tdscr.TabIndex = 27
        Me.text_tdscr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_temporada
        '
        Me.text_temporada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_temporada.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.text_temporada, 2)
        Me.text_temporada.Location = New System.Drawing.Point(950, 42)
        Me.text_temporada.Name = "text_temporada"
        Me.text_temporada.Size = New System.Drawing.Size(239, 39)
        Me.text_temporada.TabIndex = 28
        Me.text_temporada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_SitDespacho
        '
        Me.lbl_SitDespacho.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SitDespacho.AutoSize = True
        Me.lbl_SitDespacho.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_SitDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SitDespacho.Location = New System.Drawing.Point(950, 159)
        Me.lbl_SitDespacho.Name = "lbl_SitDespacho"
        Me.lbl_SitDespacho.Size = New System.Drawing.Size(112, 39)
        Me.lbl_SitDespacho.TabIndex = 16
        Me.lbl_SitDespacho.Text = "Sit Despacho:"
        Me.lbl_SitDespacho.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'text_tdrcc
        '
        Me.text_tdrcc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_tdrcc.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.text_tdrcc, 3)
        Me.text_tdrcc.Location = New System.Drawing.Point(832, 81)
        Me.text_tdrcc.Name = "text_tdrcc"
        Me.text_tdrcc.Size = New System.Drawing.Size(357, 39)
        Me.text_tdrcc.TabIndex = 29
        Me.text_tdrcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Direccion_2
        '
        Me.txt_Direccion_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_2.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.txt_Direccion_2, 3)
        Me.txt_Direccion_2.Location = New System.Drawing.Point(832, 120)
        Me.txt_Direccion_2.Name = "txt_Direccion_2"
        Me.txt_Direccion_2.Size = New System.Drawing.Size(357, 39)
        Me.txt_Direccion_2.TabIndex = 30
        Me.txt_Direccion_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_clgren
        '
        Me.text_clgren.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_clgren.AutoSize = True
        Me.text_clgren.Location = New System.Drawing.Point(124, 81)
        Me.text_clgren.Name = "text_clgren"
        Me.text_clgren.Size = New System.Drawing.Size(112, 39)
        Me.text_clgren.TabIndex = 31
        Me.text_clgren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_fEntrega
        '
        Me.lbl_fEntrega.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_fEntrega.AutoSize = True
        Me.lbl_fEntrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_fEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fEntrega.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_fEntrega.Location = New System.Drawing.Point(6, 159)
        Me.lbl_fEntrega.Name = "lbl_fEntrega"
        Me.lbl_fEntrega.Size = New System.Drawing.Size(112, 39)
        Me.lbl_fEntrega.TabIndex = 3
        Me.lbl_fEntrega.Text = "F. Entrega:"
        Me.lbl_fEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'text_fentr
        '
        Me.text_fentr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_fentr.AutoSize = True
        Me.text_fentr.Location = New System.Drawing.Point(124, 159)
        Me.text_fentr.Name = "text_fentr"
        Me.text_fentr.Size = New System.Drawing.Size(112, 39)
        Me.text_fentr.TabIndex = 32
        Me.text_fentr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_BillTo
        '
        Me.lbl_BillTo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_BillTo.AutoSize = True
        Me.lbl_BillTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lbl_BillTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillTo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_BillTo.Location = New System.Drawing.Point(6, 120)
        Me.lbl_BillTo.Name = "lbl_BillTo"
        Me.lbl_BillTo.Size = New System.Drawing.Size(112, 39)
        Me.lbl_BillTo.TabIndex = 33
        Me.lbl_BillTo.Text = "Bill TO:"
        Me.lbl_BillTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'text_tlgen
        '
        Me.text_tlgen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_tlgen.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.text_tlgen, 4)
        Me.text_tlgen.Location = New System.Drawing.Point(242, 81)
        Me.text_tlgen.Name = "text_tlgen"
        Me.text_tlgen.Size = New System.Drawing.Size(466, 39)
        Me.text_tlgen.TabIndex = 34
        Me.text_tlgen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_ptlrnc
        '
        Me.text_ptlrnc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_ptlrnc.AutoSize = True
        Me.text_ptlrnc.Location = New System.Drawing.Point(360, 159)
        Me.text_ptlrnc.Name = "text_ptlrnc"
        Me.text_ptlrnc.Size = New System.Drawing.Size(112, 39)
        Me.text_ptlrnc.TabIndex = 35
        Me.text_ptlrnc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_cestcl
        '
        Me.text_cestcl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_cestcl.AutoSize = True
        Me.text_cestcl.Location = New System.Drawing.Point(596, 159)
        Me.text_cestcl.Name = "text_cestcl"
        Me.text_cestcl.Size = New System.Drawing.Size(112, 39)
        Me.text_cestcl.TabIndex = 36
        Me.text_cestcl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_testcl
        '
        Me.text_testcl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_testcl.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.text_testcl, 2)
        Me.text_testcl.Location = New System.Drawing.Point(714, 159)
        Me.text_testcl.Name = "text_testcl"
        Me.text_testcl.Size = New System.Drawing.Size(230, 39)
        Me.text_testcl.TabIndex = 37
        Me.text_testcl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_flgdes
        '
        Me.text_flgdes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_flgdes.AutoSize = True
        Me.text_flgdes.Location = New System.Drawing.Point(1068, 159)
        Me.text_flgdes.Name = "text_flgdes"
        Me.text_flgdes.Size = New System.Drawing.Size(121, 39)
        Me.text_flgdes.TabIndex = 38
        Me.text_flgdes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_tvia
        '
        Me.text_tvia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_tvia.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.text_tvia, 2)
        Me.text_tvia.Location = New System.Drawing.Point(124, 198)
        Me.text_tvia.Name = "text_tvia"
        Me.text_tvia.Size = New System.Drawing.Size(230, 39)
        Me.text_tvia.TabIndex = 39
        Me.text_tvia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_nro_kit
        '
        Me.txt_nro_kit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nro_kit.AutoSize = True
        Me.txt_nro_kit.Location = New System.Drawing.Point(478, 198)
        Me.txt_nro_kit.Name = "txt_nro_kit"
        Me.txt_nro_kit.Size = New System.Drawing.Size(112, 39)
        Me.txt_nro_kit.TabIndex = 40
        Me.txt_nro_kit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_nro_certificado
        '
        Me.text_nro_certificado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_nro_certificado.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.text_nro_certificado, 4)
        Me.text_nro_certificado.Location = New System.Drawing.Point(714, 198)
        Me.text_nro_certificado.Name = "text_nro_certificado"
        Me.text_nro_certificado.Size = New System.Drawing.Size(475, 39)
        Me.text_nro_certificado.TabIndex = 41
        Me.text_nro_certificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_totros
        '
        Me.text_totros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_totros.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.text_totros, 4)
        Me.text_totros.Location = New System.Drawing.Point(714, 237)
        Me.text_totros.Name = "text_totros"
        Me.text_totros.Size = New System.Drawing.Size(475, 60)
        Me.text_totros.TabIndex = 42
        '
        'text_tfrmem
        '
        Me.text_tfrmem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_tfrmem.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.text_tfrmem, 4)
        Me.text_tfrmem.Location = New System.Drawing.Point(124, 237)
        Me.text_tfrmem.Name = "text_tfrmem"
        Me.text_tfrmem.Size = New System.Drawing.Size(466, 60)
        Me.text_tfrmem.TabIndex = 43
        '
        'text_cod_lugrent_cobro
        '
        Me.text_cod_lugrent_cobro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_cod_lugrent_cobro.AutoSize = True
        Me.text_cod_lugrent_cobro.Location = New System.Drawing.Point(124, 120)
        Me.text_cod_lugrent_cobro.Name = "text_cod_lugrent_cobro"
        Me.text_cod_lugrent_cobro.Size = New System.Drawing.Size(112, 39)
        Me.text_cod_lugrent_cobro.TabIndex = 44
        Me.text_cod_lugrent_cobro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_BillToDet
        '
        Me.txt_BillToDet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_BillToDet.AutoSize = True
        Me.tableCabecera.SetColumnSpan(Me.txt_BillToDet, 4)
        Me.txt_BillToDet.Location = New System.Drawing.Point(242, 120)
        Me.txt_BillToDet.Name = "txt_BillToDet"
        Me.txt_BillToDet.Size = New System.Drawing.Size(466, 39)
        Me.txt_BillToDet.TabIndex = 45
        Me.txt_BillToDet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView3.Location = New System.Drawing.Point(3, 377)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(1189, 245)
        Me.DataGridView3.TabIndex = 2
        '
        'frmLector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1203, 749)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.pnlConnect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TS800 Sample"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlConnect.ResumeLayout(False)
        Me.pnlConnect.PerformLayout
        Me.tabControl.ResumeLayout(False)
        Me.tpPerformance.ResumeLayout(False)
        Me.tablaContenConf.ResumeLayout(False)
        Me.gbxEPCSettings.ResumeLayout(False)
        Me.gbxEPCSettings.PerformLayout
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout
        Me.gbxScanMode.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout
        CType(Me.nudInventoryRoundInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout
        CType(Me.nudTagRemoveThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout
        CType(Me.nudTagPresentRepeatInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxLinkFrequency.ResumeLayout(False)
        Me.GroupBoxLinkFrequency.PerformLayout
        Me.GroupBoxRxDecode.ResumeLayout(False)
        Me.GroupBoxRxDecode.PerformLayout
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout
        CType(Me.tbRfSensitivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout
        CType(Me.tbRfPower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.gbJapanFrequency.ResumeLayout(False)
        Me.gbJapanFrequency.PerformLayout
        Me.gbTaiwanFrequency.ResumeLayout(False)
        Me.gbTaiwanFrequency.PerformLayout
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.tpInventory.ResumeLayout(False)
        Me.gbxInventoryEx.ResumeLayout(False)
        Me.tablaContenedorTimbrado.ResumeLayout(False)
        Me.tabaLadoTimbrado.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.dgvTagList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tpSearch.ResumeLayout(False)
        Me.gbxBuscarPrenda.ResumeLayout(False)
        Me.tablaBuscarPrenda.ResumeLayout(False)
        Me.tablaBuscarPrenda.PerformLayout
        Me.ContenedorBuscarPrenda.ResumeLayout(False)
        Me.ContenedorBuscarPrenda.PerformLayout
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPapper.ResumeLayout(False)
        Me.TablaContenedorHM.ResumeLayout(False)
        Me.tabaCabecera.ResumeLayout(False)
        Me.tabaCabecera.PerformLayout
        Me.tableCabecera.ResumeLayout(False)
        Me.tableCabecera.PerformLayout
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlConnect As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbxBaudrate As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnWifiSetting As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tpPerformance As System.Windows.Forms.TabPage
    Friend WithEvents lblRomVersion As Label
    Friend WithEvents lblSdkVersion As Label
    Friend WithEvents tpInventory As TabPage
    Friend WithEvents gbxInventoryEx As GroupBox
    Friend WithEvents tpSearch As TabPage
    Friend WithEvents gbxBuscarPrenda As GroupBox
    Friend WithEvents tablaBuscarPrenda As TableLayoutPanel
    Friend WithEvents ContenedorBuscarPrenda As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents BuscarCodBarras As TextBox
    Friend WithEvents MsnBusquedaPrenda As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents tpPapper As TabPage
    Friend WithEvents TablaContenedorHM As TableLayoutPanel
    Friend WithEvents tabaCabecera As TableLayoutPanel
    Friend WithEvents TextBoxOP As TextBox
    Friend WithEvents LabelOP As Label
    Friend WithEvents BtnBuscarHM As Button
    Friend WithEvents TextBoxHM As TextBox
    Friend WithEvents LabelHM As Label
    Friend WithEvents tableCabecera As TableLayoutPanel
    Friend WithEvents lbl_op As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_shipTo As Label
    Friend WithEvents lbl_Despacho As Label
    Friend WithEvents lbl_empaque As Label
    Friend WithEvents lbl_HM As Label
    Friend WithEvents lbl_po As Label
    Friend WithEvents lbl_Estado As Label
    Friend WithEvents lbl_Reserva As Label
    Friend WithEvents lbl_Prenda As Label
    Friend WithEvents lbl_direccion_1 As Label
    Friend WithEvents lbl_direccion_2 As Label
    Friend WithEvents lbl_Tolerancia As Label
    Friend WithEvents lbl_Estilo As Label
    Friend WithEvents lbl_Observacion As Label
    Friend WithEvents lbl_Certificado As Label
    Friend WithEvents lbl_NKit As Label
    Friend WithEvents text_norpd As Label
    Friend WithEvents text_npocl As Label
    Friend WithEvents text_nhjmr As Label
    Friend WithEvents text_sesthm As Label
    Friend WithEvents text_sreserva As Label
    Friend WithEvents text_cclnt As Label
    Friend WithEvents text_ttrcr As Label
    Friend WithEvents text_tdscr As Label
    Friend WithEvents text_temporada As Label
    Friend WithEvents lbl_SitDespacho As Label
    Friend WithEvents text_tdrcc As Label
    Friend WithEvents txt_Direccion_2 As Label
    Friend WithEvents text_clgren As Label
    Friend WithEvents lbl_fEntrega As Label
    Friend WithEvents text_fentr As Label
    Friend WithEvents lbl_BillTo As Label
    Friend WithEvents text_tlgen As Label
    Friend WithEvents text_ptlrnc As Label
    Friend WithEvents text_cestcl As Label
    Friend WithEvents text_testcl As Label
    Friend WithEvents text_flgdes As Label
    Friend WithEvents text_tvia As Label
    Friend WithEvents txt_nro_kit As Label
    Friend WithEvents text_nro_certificado As Label
    Friend WithEvents text_totros As Label
    Friend WithEvents text_tfrmem As Label
    Friend WithEvents text_cod_lugrent_cobro As Label
    Friend WithEvents txt_BillToDet As Label
    Friend WithEvents BtnLimpiarHM As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents tablaContenConf As TableLayoutPanel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btnGetActiveMode As Button
    Friend WithEvents btnSetActiveMode As Button
    Friend WithEvents cbxActiveMode As ComboBox
    Friend WithEvents Label44 As Label
    Friend WithEvents gbJapanFrequency As GroupBox
    Friend WithEvents cb923_2 As CheckBox
    Friend WithEvents cb923_0 As CheckBox
    Friend WithEvents cb922_8 As CheckBox
    Friend WithEvents cb922_6 As CheckBox
    Friend WithEvents cb922_4 As CheckBox
    Friend WithEvents cb922_2 As CheckBox
    Friend WithEvents cb922_0 As CheckBox
    Friend WithEvents cb921_8 As CheckBox
    Friend WithEvents cb921_6 As CheckBox
    Friend WithEvents cb921_4 As CheckBox
    Friend WithEvents cb921_2 As CheckBox
    Friend WithEvents cb921_0 As CheckBox
    Friend WithEvents cb920_8 As CheckBox
    Friend WithEvents cb920_6 As CheckBox
    Friend WithEvents cb920_4 As CheckBox
    Friend WithEvents cb919_2 As CheckBox
    Friend WithEvents cb918_0 As CheckBox
    Friend WithEvents cb916_8 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents gbxScanMode As GroupBox
    Friend WithEvents btnGetScanMode As Button
    Friend WithEvents btnSetScanMode As Button
    Friend WithEvents cbxScanMode As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnGetInvnetoryRoundInterval As Button
    Friend WithEvents nudInventoryRoundInterval As NumericUpDown
    Friend WithEvents btnSetInvnetoryRoundInterval As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnGetRemoveThreshold As Button
    Friend WithEvents nudTagRemoveThreshold As NumericUpDown
    Friend WithEvents btnSetRemoveThreshold As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGetTagPresentRepeatInterval As Button
    Friend WithEvents nudTagPresentRepeatInterval As NumericUpDown
    Friend WithEvents btnSetTagPresentRepeatInterval As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents GroupBoxLinkFrequency As GroupBox
    Friend WithEvents btnGetLinkFrequency As Button
    Friend WithEvents cbxLinkFrequency As ComboBox
    Friend WithEvents btnSetLinkFrequency As Button
    Friend WithEvents Label50 As Label
    Friend WithEvents GroupBoxRxDecode As GroupBox
    Friend WithEvents btnGetRxDecode As Button
    Friend WithEvents btnSetRxDecode As Button
    Friend WithEvents cbxRxDecode As ComboBox
    Friend WithEvents Label49 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGetRfSensitivity As Button
    Friend WithEvents lblRfSensitivity As Label
    Friend WithEvents btnSetRfSensitivity As Button
    Friend WithEvents tbRfSensitivity As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnGetRfPower As Button
    Friend WithEvents btnSetRfPower As Button
    Friend WithEvents tbRfPower As TrackBar
    Friend WithEvents Label28 As Label
    Friend WithEvents lblRfPower As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents gbTaiwanFrequency As GroupBox
    Friend WithEvents cb920_25 As CheckBox
    Friend WithEvents cb922_25 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSetFrequency As Button
    Friend WithEvents CodBarras As TextBox
    Friend WithEvents btnStopInventoryEx As Button
    Friend WithEvents cbxInventory As ComboBox
    Friend WithEvents btnStartInventoryEx As Button
    Friend WithEvents tablaContenedorTimbrado As TableLayoutPanel
    Friend WithEvents tabaLadoTimbrado As TableLayoutPanel
    Friend WithEvents MsnVincular As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents dgvTagList As DataGridView
    Friend WithEvents clnEPC As DataGridViewTextBoxColumn
    Friend WithEvents clnTID As DataGridViewTextBoxColumn
    Friend WithEvents clnCount As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnGetFrequency As Button
    Friend WithEvents cantidadRFID As Label
    Friend WithEvents gbxEPCSettings As GroupBox
    Friend WithEvents btnGetSessionTarget As Button
    Friend WithEvents cbxSession As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents cbxTarget As ComboBox
    Friend WithEvents btnSetSessionTarget As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents btnGetQValue As Button
    Friend WithEvents cbxQValue As ComboBox
    Friend WithEvents btnSetQValue As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents btnLimpiarRFID As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents pruebaCodigos As Label
    Friend WithEvents op As DataGridViewTextBoxColumn
    Friend WithEvents corte As DataGridViewTextBoxColumn
    Friend WithEvents subcorte As DataGridViewTextBoxColumn
    Friend WithEvents talla As DataGridViewTextBoxColumn
    Friend WithEvents cod_talla As DataGridViewTextBoxColumn
    Friend WithEvents linea As DataGridViewTextBoxColumn
    Friend WithEvents id_talla As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents id_rfid As DataGridViewTextBoxColumn
End Class