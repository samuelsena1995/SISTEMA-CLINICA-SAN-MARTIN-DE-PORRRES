namespace Capa_Presentacion
{
    partial class Frm_Pantalla_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("FICHA PACIENTE");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("SINTOMAS");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("MEDICACION");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ESTUDIO DE LABORATORIO");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ESTUDIO POR IMAGENES");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("EVOLUCION MEDICA", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("INTERNACIÓN", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("EVOLUCION MEDICA");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("TRATAMIENTO");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("SOAP", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("FUNCIONARIOS");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("MÉDICO");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("TIPOS DE SALA");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("SALAS");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("PARAMETROS Y CONFIGURACIÓN", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("REPORTES PARA CONTROL");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("REPORTES PARA GERENCIA");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("REPORTES", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("USUARIOS");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("ASIGNACION DE PERMISOS");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("ADMINISTRACION DE BITACORAS");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("ADMINISTRACION", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pantalla_principal));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtPermisoPrinciapl = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblsam = new System.Windows.Forms.Label();
            this.txtsami = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1USUARIO = new System.Windows.Forms.ToolStripLabel();
            this.ID_USUARIOS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel_menu_Strip = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.internacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eVOLUCIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eVOLUCIONMEDICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRATAMIENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosYConfiguracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUNCIONARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPOSDESALAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sala = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESPARACONTROLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESPARAGERENCIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSIGNACIONDEPERMISOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINISTRACIONDEBITACORASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.LBL_FP002 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.LB_FP001 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel_fondo = new System.Windows.Forms.Panel();
            this.eSTUDIOLABORATORIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPermisoPrinciapl)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_form.SuspendLayout();
            this.panel_menu_Strip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel_fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.FullRowSelect = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node27";
            treeNode1.Text = "FICHA PACIENTE";
            treeNode2.Name = "Node30";
            treeNode2.Text = "SINTOMAS";
            treeNode3.Name = "Node31";
            treeNode3.Text = "MEDICACION";
            treeNode4.Name = "Node32";
            treeNode4.Text = "ESTUDIO DE LABORATORIO";
            treeNode5.Name = "Node33";
            treeNode5.Text = "ESTUDIO POR IMAGENES";
            treeNode6.Checked = true;
            treeNode6.Name = "Node29";
            treeNode6.Text = "EVOLUCION MEDICA";
            treeNode7.Checked = true;
            treeNode7.Name = "Node26";
            treeNode7.Text = "INTERNACIÓN";
            treeNode8.Name = "Node2";
            treeNode8.Text = "EVOLUCION MEDICA";
            treeNode9.Name = "Node3";
            treeNode9.Text = "TRATAMIENTO";
            treeNode10.Name = "Node1";
            treeNode10.Text = "SOAP";
            treeNode11.Checked = true;
            treeNode11.Name = "Node17";
            treeNode11.Text = "FUNCIONARIOS";
            treeNode12.Checked = true;
            treeNode12.Name = "Node18";
            treeNode12.Text = "MÉDICO";
            treeNode13.Checked = true;
            treeNode13.Name = "Node19";
            treeNode13.Text = "TIPOS DE SALA";
            treeNode14.Checked = true;
            treeNode14.Name = "Node20";
            treeNode14.Text = "SALAS";
            treeNode15.Name = "Node16";
            treeNode15.Text = "PARAMETROS Y CONFIGURACIÓN";
            treeNode16.Checked = true;
            treeNode16.Name = "Node14";
            treeNode16.Text = "REPORTES PARA CONTROL";
            treeNode17.Checked = true;
            treeNode17.Name = "Node15";
            treeNode17.Text = "REPORTES PARA GERENCIA";
            treeNode18.ImageKey = "iconfinder_print_16087991.png";
            treeNode18.Name = "Node9";
            treeNode18.SelectedImageIndex = 1;
            treeNode18.Text = "REPORTES";
            treeNode19.Checked = true;
            treeNode19.Name = "Node10";
            treeNode19.Text = "USUARIOS";
            treeNode20.Name = "Node11";
            treeNode20.Text = "ASIGNACION DE PERMISOS";
            treeNode21.Name = "Node13";
            treeNode21.Text = "ADMINISTRACION DE BITACORAS";
            treeNode22.ImageIndex = 2;
            treeNode22.Name = "Node8";
            treeNode22.SelectedImageIndex = 2;
            treeNode22.Text = "ADMINISTRACION";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode10,
            treeNode15,
            treeNode18,
            treeNode22});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(401, 486);
            this.treeView1.TabIndex = 0;
            this.treeView1.Visible = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.EnabledChanged += new System.EventHandler(this.treeView1_EnabledChanged);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_document_text_settings_103330.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_print_16087991.png");
            this.imageList1.Images.SetKeyName(2, "iconfinder_Setting01_928428.png");
            this.imageList1.Images.SetKeyName(3, "lista de labora - copia2.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 537);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.dtPermisoPrinciapl);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblsam);
            this.panel2.Controls.Add(this.txtsami);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Controls.Add(this.ID_USUARIOS);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 563);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtPermisoPrinciapl
            // 
            this.dtPermisoPrinciapl.AllowUserToAddRows = false;
            this.dtPermisoPrinciapl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPermisoPrinciapl.Location = new System.Drawing.Point(891, 36);
            this.dtPermisoPrinciapl.Name = "dtPermisoPrinciapl";
            this.dtPermisoPrinciapl.Size = new System.Drawing.Size(240, 275);
            this.dtPermisoPrinciapl.TabIndex = 54;
            this.dtPermisoPrinciapl.Visible = false;
            this.dtPermisoPrinciapl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPermisoPrinciapl_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblsam
            // 
            this.lblsam.AutoSize = true;
            this.lblsam.Location = new System.Drawing.Point(453, 105);
            this.lblsam.Name = "lblsam";
            this.lblsam.Size = new System.Drawing.Size(41, 15);
            this.lblsam.TabIndex = 56;
            this.lblsam.Text = "label1";
            // 
            // txtsami
            // 
            this.txtsami.Location = new System.Drawing.Point(753, 54);
            this.txtsami.Name = "txtsami";
            this.txtsami.Size = new System.Drawing.Size(100, 21);
            this.txtsami.TabIndex = 55;
            this.txtsami.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(146)))));
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel1USUARIO});
            this.toolStrip2.Location = new System.Drawing.Point(0, 538);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1139, 25);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 51;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1USUARIO
            // 
            this.toolStripLabel1USUARIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripLabel1USUARIO.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1USUARIO.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1USUARIO.Name = "toolStripLabel1USUARIO";
            this.toolStripLabel1USUARIO.Size = new System.Drawing.Size(691, 22);
            this.toolStripLabel1USUARIO.Text = "                                                                                 " +
    "                                      Usuario : ";
            this.toolStripLabel1USUARIO.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ID_USUARIOS
            // 
            this.ID_USUARIOS.AutoSize = true;
            this.ID_USUARIOS.Location = new System.Drawing.Point(433, 179);
            this.ID_USUARIOS.Name = "ID_USUARIOS";
            this.ID_USUARIOS.Size = new System.Drawing.Size(41, 15);
            this.ID_USUARIOS.TabIndex = 2;
            this.ID_USUARIOS.Text = "label2";
            this.ID_USUARIOS.Click += new System.EventHandler(this.ID_USUARIOS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(410, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_form
            // 
            this.panel_form.Controls.Add(this.panel_menu_Strip);
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(0, 30);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(1139, 563);
            this.panel_form.TabIndex = 2;
            // 
            // panel_menu_Strip
            // 
            this.panel_menu_Strip.Controls.Add(this.menuStrip1);
            this.panel_menu_Strip.Controls.Add(this.panel2);
            this.panel_menu_Strip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.panel_menu_Strip.Name = "panel_menu_Strip";
            this.panel_menu_Strip.Size = new System.Drawing.Size(1139, 563);
            this.panel_menu_Strip.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internacionToolStripMenuItem,
            this.sOAPToolStripMenuItem,
            this.parametrosYConfiguracionToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1139, 26);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // internacionToolStripMenuItem
            // 
            this.internacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pACIENTEToolStripMenuItem,
            this.eVOLUCIONToolStripMenuItem});
            this.internacionToolStripMenuItem.Name = "internacionToolStripMenuItem";
            this.internacionToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.internacionToolStripMenuItem.Text = "Internacion";
            this.internacionToolStripMenuItem.Click += new System.EventHandler(this.internacionToolStripMenuItem_Click_1);
            // 
            // pACIENTEToolStripMenuItem
            // 
            this.pACIENTEToolStripMenuItem.Name = "pACIENTEToolStripMenuItem";
            this.pACIENTEToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pACIENTEToolStripMenuItem.Text = "PACIENTE";
            this.pACIENTEToolStripMenuItem.Visible = false;
            this.pACIENTEToolStripMenuItem.Click += new System.EventHandler(this.pACIENTEToolStripMenuItem_Click);
            // 
            // eVOLUCIONToolStripMenuItem
            // 
            this.eVOLUCIONToolStripMenuItem.Name = "eVOLUCIONToolStripMenuItem";
            this.eVOLUCIONToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.eVOLUCIONToolStripMenuItem.Text = "INTERNACION";
            this.eVOLUCIONToolStripMenuItem.Click += new System.EventHandler(this.eVOLUCIONToolStripMenuItem_Click);
            // 
            // sOAPToolStripMenuItem
            // 
            this.sOAPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eVOLUCIONMEDICAToolStripMenuItem,
            this.tRATAMIENTOToolStripMenuItem,
            this.eSTUDIOLABORATORIOToolStripMenuItem});
            this.sOAPToolStripMenuItem.Name = "sOAPToolStripMenuItem";
            this.sOAPToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.sOAPToolStripMenuItem.Text = "SOAP";
            // 
            // eVOLUCIONMEDICAToolStripMenuItem
            // 
            this.eVOLUCIONMEDICAToolStripMenuItem.Name = "eVOLUCIONMEDICAToolStripMenuItem";
            this.eVOLUCIONMEDICAToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.eVOLUCIONMEDICAToolStripMenuItem.Text = "EVOLUCION MEDICA";
            this.eVOLUCIONMEDICAToolStripMenuItem.Click += new System.EventHandler(this.eVOLUCIONMEDICAToolStripMenuItem_Click);
            // 
            // tRATAMIENTOToolStripMenuItem
            // 
            this.tRATAMIENTOToolStripMenuItem.Name = "tRATAMIENTOToolStripMenuItem";
            this.tRATAMIENTOToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.tRATAMIENTOToolStripMenuItem.Text = "TRATAMIENTO";
            // 
            // parametrosYConfiguracionToolStripMenuItem
            // 
            this.parametrosYConfiguracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fUNCIONARIOSToolStripMenuItem,
            this.medicoToolStripMenuItem,
            this.tIPOSDESALAToolStripMenuItem,
            this.sala});
            this.parametrosYConfiguracionToolStripMenuItem.Name = "parametrosYConfiguracionToolStripMenuItem";
            this.parametrosYConfiguracionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.parametrosYConfiguracionToolStripMenuItem.Text = "Parametros y configuracion";
            this.parametrosYConfiguracionToolStripMenuItem.Click += new System.EventHandler(this.parametrosYConfiguracionToolStripMenuItem_Click);
            // 
            // fUNCIONARIOSToolStripMenuItem
            // 
            this.fUNCIONARIOSToolStripMenuItem.Name = "fUNCIONARIOSToolStripMenuItem";
            this.fUNCIONARIOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fUNCIONARIOSToolStripMenuItem.Text = "FUNCIONARIO";
            this.fUNCIONARIOSToolStripMenuItem.Visible = false;
            this.fUNCIONARIOSToolStripMenuItem.Click += new System.EventHandler(this.fUNCIONARIOSToolStripMenuItem_Click);
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medicoToolStripMenuItem.Text = "MEDICO";
            this.medicoToolStripMenuItem.Visible = false;
            this.medicoToolStripMenuItem.Click += new System.EventHandler(this.cARGOSToolStripMenuItem_Click);
            // 
            // tIPOSDESALAToolStripMenuItem
            // 
            this.tIPOSDESALAToolStripMenuItem.Name = "tIPOSDESALAToolStripMenuItem";
            this.tIPOSDESALAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tIPOSDESALAToolStripMenuItem.Text = "TIPOS DE SALA";
            this.tIPOSDESALAToolStripMenuItem.Visible = false;
            this.tIPOSDESALAToolStripMenuItem.Click += new System.EventHandler(this.tIPOSDESALAToolStripMenuItem_Click);
            // 
            // sala
            // 
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(180, 22);
            this.sala.Text = "SALA";
            this.sala.Visible = false;
            this.sala.Click += new System.EventHandler(this.sALASToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEPORTESPARACONTROLToolStripMenuItem,
            this.rEPORTESPARAGERENCIAToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // rEPORTESPARACONTROLToolStripMenuItem
            // 
            this.rEPORTESPARACONTROLToolStripMenuItem.Name = "rEPORTESPARACONTROLToolStripMenuItem";
            this.rEPORTESPARACONTROLToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.rEPORTESPARACONTROLToolStripMenuItem.Text = "REPORTES PARA CONTROL";
            this.rEPORTESPARACONTROLToolStripMenuItem.Click += new System.EventHandler(this.rEPORTESPARACONTROLToolStripMenuItem_Click);
            // 
            // rEPORTESPARAGERENCIAToolStripMenuItem
            // 
            this.rEPORTESPARAGERENCIAToolStripMenuItem.Name = "rEPORTESPARAGERENCIAToolStripMenuItem";
            this.rEPORTESPARAGERENCIAToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.rEPORTESPARAGERENCIAToolStripMenuItem.Text = "REPORTES PARA GERENCIA";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.aSIGNACIONDEPERMISOSToolStripMenuItem,
            this.aDMINISTRACIONDEBITACORASToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.administracionToolStripMenuItem.Text = "Administracion";
            this.administracionToolStripMenuItem.Click += new System.EventHandler(this.administracionToolStripMenuItem_Click);
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            this.uSUARIOSToolStripMenuItem.Visible = false;
            this.uSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOSToolStripMenuItem_Click);
            // 
            // aSIGNACIONDEPERMISOSToolStripMenuItem
            // 
            this.aSIGNACIONDEPERMISOSToolStripMenuItem.Name = "aSIGNACIONDEPERMISOSToolStripMenuItem";
            this.aSIGNACIONDEPERMISOSToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.aSIGNACIONDEPERMISOSToolStripMenuItem.Text = "ASIGNACION DE PERMISOS";
            this.aSIGNACIONDEPERMISOSToolStripMenuItem.Visible = false;
            // 
            // aDMINISTRACIONDEBITACORASToolStripMenuItem
            // 
            this.aDMINISTRACIONDEBITACORASToolStripMenuItem.Name = "aDMINISTRACIONDEBITACORASToolStripMenuItem";
            this.aDMINISTRACIONDEBITACORASToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.aDMINISTRACIONDEBITACORASToolStripMenuItem.Text = "ADMINISTRACION DE BITACORAS";
            this.aDMINISTRACIONDEBITACORASToolStripMenuItem.Visible = false;
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.Red;
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.LBL_FP002);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.LB_FP001);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1139, 30);
            this.panelBarraTitulo.TabIndex = 31;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo_Paint);
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Location = new System.Drawing.Point(1063, 7);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // LBL_FP002
            // 
            this.LBL_FP002.AutoSize = true;
            this.LBL_FP002.Location = new System.Drawing.Point(684, 12);
            this.LBL_FP002.Name = "LBL_FP002";
            this.LBL_FP002.Size = new System.Drawing.Size(50, 15);
            this.LBL_FP002.TabIndex = 60;
            this.LBL_FP002.Text = "FP_002";
            this.LBL_FP002.Visible = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_maximize_1954538;
            this.btnMaximizar.Location = new System.Drawing.Point(1087, 7);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // LB_FP001
            // 
            this.LB_FP001.AutoSize = true;
            this.LB_FP001.Location = new System.Drawing.Point(617, 12);
            this.LB_FP001.Name = "LB_FP001";
            this.LB_FP001.Size = new System.Drawing.Size(50, 15);
            this.LB_FP001.TabIndex = 59;
            this.LB_FP001.Text = "FP_001";
            this.LB_FP001.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1111, 7);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel_fondo
            // 
            this.panel_fondo.Controls.Add(this.panel_form);
            this.panel_fondo.Controls.Add(this.panelBarraTitulo);
            this.panel_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fondo.Location = new System.Drawing.Point(0, 0);
            this.panel_fondo.Name = "panel_fondo";
            this.panel_fondo.Size = new System.Drawing.Size(1139, 593);
            this.panel_fondo.TabIndex = 3;
            // 
            // eSTUDIOLABORATORIOToolStripMenuItem
            // 
            this.eSTUDIOLABORATORIOToolStripMenuItem.Name = "eSTUDIOLABORATORIOToolStripMenuItem";
            this.eSTUDIOLABORATORIOToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.eSTUDIOLABORATORIOToolStripMenuItem.Text = "ESTUDIO LABORATORIO";
            this.eSTUDIOLABORATORIOToolStripMenuItem.Click += new System.EventHandler(this.eSTUDIOLABORATORIOToolStripMenuItem_Click);
            // 
            // Frm_Pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 593);
            this.Controls.Add(this.panel_fondo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Pantalla_principal";
            this.Text = "CLINICA SAN MARTIN DE PORRES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Pantalla_principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Pantalla_principal_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Pantalla_principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPermisoPrinciapl)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_form.ResumeLayout(false);
            this.panel_menu_Strip.ResumeLayout(false);
            this.panel_menu_Strip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel_fondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Panel panel_menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Panel panel_fondo;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESPARACONTROLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESPARAGERENCIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eVOLUCIONToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem aSIGNACIONDEPERMISOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRACIONDEBITACORASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eVOLUCIONMEDICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRATAMIENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1USUARIO;
        public System.Windows.Forms.Label ID_USUARIOS;
        public System.Windows.Forms.TextBox txtsami;
        public System.Windows.Forms.Label lblsam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dtPermisoPrinciapl;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem parametrosYConfiguracionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem internacionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem fUNCIONARIOSToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tIPOSDESALAToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sala;
        public System.Windows.Forms.ToolStripMenuItem pACIENTEToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.Label LBL_FP002;
        private System.Windows.Forms.Label LB_FP001;
        private System.Windows.Forms.ToolStripMenuItem eSTUDIOLABORATORIOToolStripMenuItem;
    }
}