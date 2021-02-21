namespace Capa_Presentacion.INTERNACION
{
    partial class FRM_ASIGNACION_SALA_REGISTRAR
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
            this.errCodigoSala = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigoInternacion = new System.Windows.Forms.TextBox();
            this.txtNombreSala = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodigoSala = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaAsignacionSala = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarSala = new System.Windows.Forms.Button();
            this.errNOMBREPaciente = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.errCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.errOcupacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnACEPTAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errCodigoSala)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNOMBREPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOcupacion)).BeginInit();
            this.SuspendLayout();
            // 
            // errCodigoSala
            // 
            this.errCodigoSala.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Codigo Sala*";
            // 
            // txtcodigoInternacion
            // 
            this.txtcodigoInternacion.BackColor = System.Drawing.Color.White;
            this.txtcodigoInternacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigoInternacion.Enabled = false;
            this.txtcodigoInternacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoInternacion.Location = new System.Drawing.Point(93, 19);
            this.txtcodigoInternacion.Name = "txtcodigoInternacion";
            this.txtcodigoInternacion.Size = new System.Drawing.Size(73, 27);
            this.txtcodigoInternacion.TabIndex = 30;
            // 
            // txtNombreSala
            // 
            this.txtNombreSala.BackColor = System.Drawing.Color.White;
            this.txtNombreSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreSala.Enabled = false;
            this.txtNombreSala.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSala.Location = new System.Drawing.Point(119, 134);
            this.txtNombreSala.MaxLength = 50;
            this.txtNombreSala.Name = "txtNombreSala";
            this.txtNombreSala.ShortcutsEnabled = false;
            this.txtNombreSala.Size = new System.Drawing.Size(327, 27);
            this.txtNombreSala.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCodigoSala);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBuscarSala);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreSala);
            this.groupBox1.Location = new System.Drawing.Point(18, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 226);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Estado*";
            // 
            // lblCodigoSala
            // 
            this.lblCodigoSala.AutoSize = true;
            this.lblCodigoSala.Location = new System.Drawing.Point(9, 123);
            this.lblCodigoSala.Name = "lblCodigoSala";
            this.lblCodigoSala.Size = new System.Drawing.Size(35, 13);
            this.lblCodigoSala.TabIndex = 35;
            this.lblCodigoSala.Text = "label5";
            this.lblCodigoSala.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtFechaAsignacionSala);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPaciente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtcodigoInternacion);
            this.groupBox2.Location = new System.Drawing.Point(6, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 109);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha*";
            // 
            // dtFechaAsignacionSala
            // 
            this.dtFechaAsignacionSala.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaAsignacionSala.Location = new System.Drawing.Point(320, 16);
            this.dtFechaAsignacionSala.Name = "dtFechaAsignacionSala";
            this.dtFechaAsignacionSala.Size = new System.Drawing.Size(100, 20);
            this.dtFechaAsignacionSala.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Paciente*";
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.Color.White;
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(93, 59);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(267, 27);
            this.txtPaciente.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Código*";
            // 
            // btnBuscarSala
            // 
            this.btnBuscarSala.BackgroundImage = global::Capa_Presentacion.Properties.Resources.search_26px;
            this.btnBuscarSala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarSala.FlatAppearance.BorderSize = 0;
            this.btnBuscarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSala.Location = new System.Drawing.Point(456, 134);
            this.btnBuscarSala.Name = "btnBuscarSala";
            this.btnBuscarSala.Size = new System.Drawing.Size(33, 27);
            this.btnBuscarSala.TabIndex = 0;
            this.btnBuscarSala.UseVisualStyleBackColor = true;
            this.btnBuscarSala.Click += new System.EventHandler(this.btnBuscarSala_Click);
            // 
            // errNOMBREPaciente
            // 
            this.errNOMBREPaciente.ContainerControl = this;
            // 
            // errDescripcion
            // 
            this.errDescripcion.ContainerControl = this;
            // 
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajadores.ForeColor = System.Drawing.Color.Black;
            this.lblTrabajadores.Location = new System.Drawing.Point(12, 34);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(486, 33);
            this.lblTrabajadores.TabIndex = 47;
            this.lblTrabajadores.Text = "REGISTRAR ASIGNACION DE SALA";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.White;
            this.btnCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.Black;
            this.btnCANCELAR.Location = new System.Drawing.Point(422, 304);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(95, 34);
            this.btnCANCELAR.TabIndex = 45;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // errCelular
            // 
            this.errCelular.ContainerControl = this;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.Gray;
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(536, 32);
            this.panelBarraTitulo.TabIndex = 46;
            // 
            // errOcupacion
            // 
            this.errOcupacion.ContainerControl = this;
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
            this.btnACEPTAR.Location = new System.Drawing.Point(314, 304);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(98, 34);
            this.btnACEPTAR.TabIndex = 44;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnACEPTAR.UseVisualStyleBackColor = false;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // FRM_ASIGNACION_SALA_REGISTRAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.lblTrabajadores);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ASIGNACION_SALA_REGISTRAR";
            this.Text = "FRM_ASIGNACION_SALA_REGISTRAR";
            this.Load += new System.EventHandler(this.FRM_ASIGNACION_SALA_REGISTRAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errCodigoSala)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNOMBREPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOcupacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errCodigoSala;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtFechaAsignacionSala;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtcodigoInternacion;
        private System.Windows.Forms.Button btnBuscarSala;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNombreSala;
        public System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.Label lblTrabajadores;
        public System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.ErrorProvider errNOMBREPaciente;
        private System.Windows.Forms.ErrorProvider errDescripcion;
        private System.Windows.Forms.ErrorProvider errCelular;
        private System.Windows.Forms.ErrorProvider errOcupacion;
        public System.Windows.Forms.Label lblCodigoSala;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}