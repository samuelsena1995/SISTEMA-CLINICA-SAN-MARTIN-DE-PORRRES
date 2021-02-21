namespace Capa_Presentacion.INTERNACION
{
    partial class Frm_Internacion_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Internacion_Registrar));
            this.errOcupacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.groupBoxDATOS = new System.Windows.Forms.GroupBox();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscarPaciente = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfecha_nacicmeintoPaciente = new System.Windows.Forms.TextBox();
            this.txtnombrepaciente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigopaciente = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTCODIGOINTERNACION = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.btnBuscarMedico = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombreFuncionario = new System.Windows.Forms.TextBox();
            this.txtcodigoFuncionario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombremedico = new System.Windows.Forms.TextBox();
            this.txtcodigomedico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errNcelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.errNOMBRE = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnACEPTAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errOcupacion)).BeginInit();
            this.groupBoxDATOS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNcelular)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNOMBRE)).BeginInit();
            this.SuspendLayout();
            // 
            // errOcupacion
            // 
            this.errOcupacion.ContainerControl = this;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.White;
            this.btnCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.Black;
            this.btnCANCELAR.Location = new System.Drawing.Point(537, 601);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(95, 34);
            this.btnCANCELAR.TabIndex = 39;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // groupBoxDATOS
            // 
            this.groupBoxDATOS.BackColor = System.Drawing.Color.White;
            this.groupBoxDATOS.Controls.Add(this.cbestado);
            this.groupBoxDATOS.Controls.Add(this.label12);
            this.groupBoxDATOS.Controls.Add(this.label11);
            this.groupBoxDATOS.Controls.Add(this.txtdescripcion);
            this.groupBoxDATOS.Controls.Add(this.groupBox1);
            this.groupBoxDATOS.Controls.Add(this.groupBox3);
            this.groupBoxDATOS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDATOS.Location = new System.Drawing.Point(18, 72);
            this.groupBoxDATOS.Name = "groupBoxDATOS";
            this.groupBoxDATOS.Size = new System.Drawing.Size(636, 523);
            this.groupBoxDATOS.TabIndex = 42;
            this.groupBoxDATOS.TabStop = false;
            this.groupBoxDATOS.Text = "Visualización de datos";
            // 
            // cbestado
            // 
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.cbestado.Location = new System.Drawing.Point(111, 469);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(108, 26);
            this.cbestado.TabIndex = 28;
            this.cbestado.Text = "Habilitado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 469);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "Estado*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Descripción";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(111, 365);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(506, 87);
            this.txtdescripcion.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscarPaciente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtfecha_nacicmeintoPaciente);
            this.groupBox1.Controls.Add(this.txtnombrepaciente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcodigopaciente);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXTCODIGOINTERNACION);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 179);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnbuscarPaciente
            // 
            this.btnbuscarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscarPaciente.BackgroundImage = global::Capa_Presentacion.Properties.Resources.search_26px;
            this.btnbuscarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnbuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnbuscarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnbuscarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnbuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarPaciente.Location = new System.Drawing.Point(566, 120);
            this.btnbuscarPaciente.Name = "btnbuscarPaciente";
            this.btnbuscarPaciente.Size = new System.Drawing.Size(42, 32);
            this.btnbuscarPaciente.TabIndex = 24;
            this.btnbuscarPaciente.UseVisualStyleBackColor = false;
            this.btnbuscarPaciente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(237, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha Nacimiento";
            // 
            // txtfecha_nacicmeintoPaciente
            // 
            this.txtfecha_nacicmeintoPaciente.Location = new System.Drawing.Point(377, 75);
            this.txtfecha_nacicmeintoPaciente.Name = "txtfecha_nacicmeintoPaciente";
            this.txtfecha_nacicmeintoPaciente.Size = new System.Drawing.Size(126, 26);
            this.txtfecha_nacicmeintoPaciente.TabIndex = 22;
            // 
            // txtnombrepaciente
            // 
            this.txtnombrepaciente.Location = new System.Drawing.Point(173, 124);
            this.txtnombrepaciente.Name = "txtnombrepaciente";
            this.txtnombrepaciente.Size = new System.Drawing.Size(199, 26);
            this.txtnombrepaciente.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nombre Paciente*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha*";
            // 
            // txtcodigopaciente
            // 
            this.txtcodigopaciente.Location = new System.Drawing.Point(103, 72);
            this.txtcodigopaciente.Name = "txtcodigopaciente";
            this.txtcodigopaciente.Size = new System.Drawing.Size(100, 26);
            this.txtcodigopaciente.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(325, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código*";
            // 
            // TXTCODIGOINTERNACION
            // 
            this.TXTCODIGOINTERNACION.Location = new System.Drawing.Point(103, 25);
            this.TXTCODIGOINTERNACION.Name = "TXTCODIGOINTERNACION";
            this.TXTCODIGOINTERNACION.Size = new System.Drawing.Size(100, 26);
            this.TXTCODIGOINTERNACION.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código*";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarFuncionario);
            this.groupBox3.Controls.Add(this.btnBuscarMedico);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtnombreFuncionario);
            this.groupBox3.Controls.Add(this.txtcodigoFuncionario);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtnombremedico);
            this.groupBox3.Controls.Add(this.txtcodigomedico);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(624, 139);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.BackgroundImage = global::Capa_Presentacion.Properties.Resources.search_26px;
            this.btnBuscarFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(572, 75);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(45, 34);
            this.btnBuscarFuncionario.TabIndex = 26;
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // btnBuscarMedico
            // 
            this.btnBuscarMedico.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMedico.BackgroundImage = global::Capa_Presentacion.Properties.Resources.search_26px;
            this.btnBuscarMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarMedico.FlatAppearance.BorderSize = 0;
            this.btnBuscarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMedico.Location = new System.Drawing.Point(566, 25);
            this.btnBuscarMedico.Name = "btnBuscarMedico";
            this.btnBuscarMedico.Size = new System.Drawing.Size(45, 34);
            this.btnBuscarMedico.TabIndex = 25;
            this.btnBuscarMedico.UseVisualStyleBackColor = false;
            this.btnBuscarMedico.Click += new System.EventHandler(this.btnBuscarMedico_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Funcionario*";
            // 
            // txtnombreFuncionario
            // 
            this.txtnombreFuncionario.Location = new System.Drawing.Point(325, 83);
            this.txtnombreFuncionario.Name = "txtnombreFuncionario";
            this.txtnombreFuncionario.Size = new System.Drawing.Size(215, 26);
            this.txtnombreFuncionario.TabIndex = 17;
            // 
            // txtcodigoFuncionario
            // 
            this.txtcodigoFuncionario.Location = new System.Drawing.Point(84, 85);
            this.txtcodigoFuncionario.Name = "txtcodigoFuncionario";
            this.txtcodigoFuncionario.Size = new System.Drawing.Size(85, 26);
            this.txtcodigoFuncionario.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Código*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre Médico*";
            // 
            // txtnombremedico
            // 
            this.txtnombremedico.Location = new System.Drawing.Point(325, 30);
            this.txtnombremedico.Name = "txtnombremedico";
            this.txtnombremedico.Size = new System.Drawing.Size(215, 26);
            this.txtnombremedico.TabIndex = 13;
            // 
            // txtcodigomedico
            // 
            this.txtcodigomedico.Location = new System.Drawing.Point(84, 30);
            this.txtcodigomedico.Name = "txtcodigomedico";
            this.txtcodigomedico.Size = new System.Drawing.Size(85, 26);
            this.txtcodigomedico.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código*";
            // 
            // errNcelular
            // 
            this.errNcelular.ContainerControl = this;
            // 
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajadores.ForeColor = System.Drawing.Color.Black;
            this.lblTrabajadores.Location = new System.Drawing.Point(12, 34);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(331, 35);
            this.lblTrabajadores.TabIndex = 41;
            this.lblTrabajadores.Text = "Registrar Internación";
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.Gray;
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(673, 32);
            this.panelBarraTitulo.TabIndex = 40;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Capa_Presentacion.Properties.Resources._1954538_24;
            this.btnMaximizar.Location = new System.Drawing.Point(621, 6);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(645, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Visible = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_window_minimize_1954552;
            this.btnRestaurar.Location = new System.Drawing.Point(597, 6);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 6;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            // 
            // errNOMBRE
            // 
            this.errNOMBRE.ContainerControl = this;
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACEPTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACEPTAR.ForeColor = System.Drawing.Color.Black;
            this.btnACEPTAR.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_save_1608823;
            this.btnACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACEPTAR.Location = new System.Drawing.Point(429, 601);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(98, 34);
            this.btnACEPTAR.TabIndex = 38;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnACEPTAR.UseVisualStyleBackColor = false;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // Frm_Internacion_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 655);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.lblTrabajadores);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.groupBoxDATOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Internacion_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Internacion_Registrar";
            this.Load += new System.EventHandler(this.Frm_Internacion_Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errOcupacion)).EndInit();
            this.groupBoxDATOS.ResumeLayout(false);
            this.groupBoxDATOS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNcelular)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNOMBRE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errOcupacion;
        public System.Windows.Forms.Button btnCANCELAR;
        public System.Windows.Forms.GroupBox groupBoxDATOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTrabajadores;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        public System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.ErrorProvider errNcelular;
        private System.Windows.Forms.ErrorProvider errNOMBRE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtcodigopaciente;
        public System.Windows.Forms.TextBox txtnombremedico;
        public System.Windows.Forms.TextBox txtcodigomedico;
        public System.Windows.Forms.Button btnbuscarPaciente;
        public System.Windows.Forms.TextBox txtfecha_nacicmeintoPaciente;
        public System.Windows.Forms.TextBox txtnombrepaciente;
        public System.Windows.Forms.Button btnBuscarFuncionario;
        public System.Windows.Forms.Button btnBuscarMedico;
        public System.Windows.Forms.TextBox txtnombreFuncionario;
        public System.Windows.Forms.TextBox txtcodigoFuncionario;
        public System.Windows.Forms.TextBox TXTCODIGOINTERNACION;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox cbestado;
    }
}