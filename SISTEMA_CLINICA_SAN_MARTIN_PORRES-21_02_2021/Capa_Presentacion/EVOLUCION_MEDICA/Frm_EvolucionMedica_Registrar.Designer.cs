namespace Capa_Presentacion.EVOLUCION_MEDICA
{
    partial class Frm_EvolucionMedica_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EvolucionMedica_Registrar));
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.errNOMBRE = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.errOcupacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodigointernacion = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.groupBoxDATOS = new System.Windows.Forms.GroupBox();
            this.lblcodigousario = new System.Windows.Forms.Label();
            this.lblcodigomedico = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtccodigomedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigousuario = new System.Windows.Forms.TextBox();
            this.errCelular = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errNOMBRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOcupacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            this.groupBoxDATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCelular)).BeginInit();
            this.SuspendLayout();
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
            this.btnACEPTAR.Location = new System.Drawing.Point(339, 495);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(106, 34);
            this.btnACEPTAR.TabIndex = 43;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnACEPTAR.UseVisualStyleBackColor = false;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // errNOMBRE
            // 
            this.errNOMBRE.ContainerControl = this;
            // 
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajadores.ForeColor = System.Drawing.Color.Black;
            this.lblTrabajadores.Location = new System.Drawing.Point(12, 38);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(297, 33);
            this.lblTrabajadores.TabIndex = 46;
            this.lblTrabajadores.Text = "EVOLUCIÓN MEDICA";
            // 
            // errOcupacion
            // 
            this.errOcupacion.ContainerControl = this;
            // 
            // errDescripcion
            // 
            this.errDescripcion.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Descripcion*";
            // 
            // txtobservacion
            // 
            this.txtobservacion.BackColor = System.Drawing.Color.White;
            this.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacion.Location = new System.Drawing.Point(149, 252);
            this.txtobservacion.MaxLength = 160;
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.ShortcutsEnabled = false;
            this.txtobservacion.Size = new System.Drawing.Size(327, 106);
            this.txtobservacion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Internacion*";
            // 
            // txtcodigointernacion
            // 
            this.txtcodigointernacion.BackColor = System.Drawing.Color.White;
            this.txtcodigointernacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigointernacion.Enabled = false;
            this.txtcodigointernacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigointernacion.Location = new System.Drawing.Point(149, 67);
            this.txtcodigointernacion.MaxLength = 50;
            this.txtcodigointernacion.Name = "txtcodigointernacion";
            this.txtcodigointernacion.ShortcutsEnabled = false;
            this.txtcodigointernacion.Size = new System.Drawing.Size(327, 27);
            this.txtcodigointernacion.TabIndex = 3;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(18, 367);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(65, 19);
            this.lblestado.TabIndex = 8;
            this.lblestado.Text = "Estado*";
            // 
            // cbESTADO
            // 
            this.cbESTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbESTADO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbESTADO.FormattingEnabled = true;
            this.cbESTADO.Location = new System.Drawing.Point(126, 364);
            this.cbESTADO.Name = "cbESTADO";
            this.cbESTADO.Size = new System.Drawing.Size(161, 27);
            this.cbESTADO.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código*";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.White;
            this.btnCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.Black;
            this.btnCANCELAR.Location = new System.Drawing.Point(461, 495);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(106, 34);
            this.btnCANCELAR.TabIndex = 44;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.BackColor = System.Drawing.Color.White;
            this.txtCODIGO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCODIGO.Enabled = false;
            this.txtCODIGO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCODIGO.Location = new System.Drawing.Point(149, 27);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(73, 27);
            this.txtCODIGO.TabIndex = 2;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Capa_Presentacion.Properties.Resources._1954538_24;
            this.btnMaximizar.Location = new System.Drawing.Point(534, 6);
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
            this.btnCerrar.Location = new System.Drawing.Point(558, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Visible = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_window_minimize_1954552;
            this.btnRestaurar.Location = new System.Drawing.Point(510, 6);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 6;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(586, 32);
            this.panelBarraTitulo.TabIndex = 45;
            // 
            // groupBoxDATOS
            // 
            this.groupBoxDATOS.BackColor = System.Drawing.Color.White;
            this.groupBoxDATOS.Controls.Add(this.lblcodigousario);
            this.groupBoxDATOS.Controls.Add(this.lblcodigomedico);
            this.groupBoxDATOS.Controls.Add(this.button1);
            this.groupBoxDATOS.Controls.Add(this.label2);
            this.groupBoxDATOS.Controls.Add(this.txtccodigomedico);
            this.groupBoxDATOS.Controls.Add(this.label1);
            this.groupBoxDATOS.Controls.Add(this.txtcodigousuario);
            this.groupBoxDATOS.Controls.Add(this.label9);
            this.groupBoxDATOS.Controls.Add(this.txtobservacion);
            this.groupBoxDATOS.Controls.Add(this.label5);
            this.groupBoxDATOS.Controls.Add(this.txtcodigointernacion);
            this.groupBoxDATOS.Controls.Add(this.lblestado);
            this.groupBoxDATOS.Controls.Add(this.cbESTADO);
            this.groupBoxDATOS.Controls.Add(this.label4);
            this.groupBoxDATOS.Controls.Add(this.txtCODIGO);
            this.groupBoxDATOS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDATOS.Location = new System.Drawing.Point(18, 82);
            this.groupBoxDATOS.Name = "groupBoxDATOS";
            this.groupBoxDATOS.Size = new System.Drawing.Size(549, 407);
            this.groupBoxDATOS.TabIndex = 47;
            this.groupBoxDATOS.TabStop = false;
            this.groupBoxDATOS.Text = "Visualización de datos";
            this.groupBoxDATOS.Enter += new System.EventHandler(this.groupBoxDATOS_Enter);
            // 
            // lblcodigousario
            // 
            this.lblcodigousario.AutoSize = true;
            this.lblcodigousario.Location = new System.Drawing.Point(96, 125);
            this.lblcodigousario.Name = "lblcodigousario";
            this.lblcodigousario.Size = new System.Drawing.Size(44, 18);
            this.lblcodigousario.TabIndex = 36;
            this.lblcodigousario.Text = "label3";
            this.lblcodigousario.Visible = false;
            // 
            // lblcodigomedico
            // 
            this.lblcodigomedico.AutoSize = true;
            this.lblcodigomedico.Location = new System.Drawing.Point(99, 172);
            this.lblcodigomedico.Name = "lblcodigomedico";
            this.lblcodigomedico.Size = new System.Drawing.Size(44, 18);
            this.lblcodigomedico.TabIndex = 35;
            this.lblcodigomedico.Text = "label3";
            this.lblcodigomedico.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Capa_Presentacion.Properties.Resources.search_26px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(492, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Medico*";
            // 
            // txtccodigomedico
            // 
            this.txtccodigomedico.BackColor = System.Drawing.Color.White;
            this.txtccodigomedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtccodigomedico.Enabled = false;
            this.txtccodigomedico.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtccodigomedico.Location = new System.Drawing.Point(149, 169);
            this.txtccodigomedico.MaxLength = 50;
            this.txtccodigomedico.Name = "txtccodigomedico";
            this.txtccodigomedico.ShortcutsEnabled = false;
            this.txtccodigomedico.Size = new System.Drawing.Size(327, 27);
            this.txtccodigomedico.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Usuario*";
            // 
            // txtcodigousuario
            // 
            this.txtcodigousuario.BackColor = System.Drawing.Color.White;
            this.txtcodigousuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigousuario.Enabled = false;
            this.txtcodigousuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigousuario.Location = new System.Drawing.Point(149, 116);
            this.txtcodigousuario.MaxLength = 50;
            this.txtcodigousuario.Name = "txtcodigousuario";
            this.txtcodigousuario.ShortcutsEnabled = false;
            this.txtcodigousuario.Size = new System.Drawing.Size(327, 27);
            this.txtcodigousuario.TabIndex = 30;
            // 
            // errCelular
            // 
            this.errCelular.ContainerControl = this;
            // 
            // Frm_EvolucionMedica_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 539);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.lblTrabajadores);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.groupBoxDATOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EvolucionMedica_Registrar";
            this.Text = "Frm_EvolucionMedica_Registrar";
            this.Load += new System.EventHandler(this.Frm_EvolucionMedica_Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errNOMBRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOcupacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.groupBoxDATOS.ResumeLayout(false);
            this.groupBoxDATOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCelular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.ErrorProvider errNOMBRE;
        private System.Windows.Forms.Label lblTrabajadores;
        public System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        public System.Windows.Forms.GroupBox groupBoxDATOS;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtccodigomedico;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtcodigousuario;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtcodigointernacion;
        public System.Windows.Forms.Label lblestado;
        public System.Windows.Forms.ComboBox cbESTADO;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.ErrorProvider errOcupacion;
        private System.Windows.Forms.ErrorProvider errDescripcion;
        private System.Windows.Forms.ErrorProvider errCelular;
        public System.Windows.Forms.Label lblcodigousario;
        public System.Windows.Forms.Label lblcodigomedico;
        public System.Windows.Forms.Button button1;
    }
}