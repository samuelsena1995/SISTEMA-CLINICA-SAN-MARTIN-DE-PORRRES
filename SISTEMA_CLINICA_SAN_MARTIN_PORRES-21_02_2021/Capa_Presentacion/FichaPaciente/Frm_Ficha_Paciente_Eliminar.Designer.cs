namespace Capa_Presentacion.FichaPaciente
{
    partial class Frm_Ficha_Paciente_Eliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ficha_Paciente_Eliminar));
            this.txtDatosReferencia = new System.Windows.Forms.TextBox();
            this.cbsExo = new System.Windows.Forms.ComboBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.errNOMBRE = new System.Windows.Forms.ErrorProvider(this.components);
            this.errOcupacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.groupBoxDATOS = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.errCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNOMBRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOcupacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDescripcion)).BeginInit();
            this.groupBoxDATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCelular)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDatosReferencia
            // 
            this.txtDatosReferencia.BackColor = System.Drawing.Color.White;
            this.txtDatosReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatosReferencia.Enabled = false;
            this.txtDatosReferencia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosReferencia.Location = new System.Drawing.Point(151, 150);
            this.txtDatosReferencia.MaxLength = 160;
            this.txtDatosReferencia.Multiline = true;
            this.txtDatosReferencia.Name = "txtDatosReferencia";
            this.txtDatosReferencia.ShortcutsEnabled = false;
            this.txtDatosReferencia.Size = new System.Drawing.Size(301, 84);
            this.txtDatosReferencia.TabIndex = 36;
            this.txtDatosReferencia.Text = "hola a todos como estan todos estamos deguastando una riquisima sopa de la casera" +
    " en el torno este es un dia ermoso";
            // 
            // cbsExo
            // 
            this.cbsExo.Enabled = false;
            this.cbsExo.FormattingEnabled = true;
            this.cbsExo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENIMO",
            "OTROS"});
            this.cbsExo.Location = new System.Drawing.Point(331, 113);
            this.cbsExo.Name = "cbsExo";
            this.cbsExo.Size = new System.Drawing.Size(121, 26);
            this.cbsExo.TabIndex = 35;
            this.cbsExo.Text = "MASCULINO";
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(523, 32);
            this.panelBarraTitulo.TabIndex = 45;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Capa_Presentacion.Properties.Resources._1954538_24;
            this.btnMaximizar.Location = new System.Drawing.Point(471, 6);
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
            this.btnCerrar.Location = new System.Drawing.Point(495, 6);
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
            this.btnRestaurar.Location = new System.Drawing.Point(447, 6);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 6;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(125, 113);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(113, 26);
            this.dtFecha.TabIndex = 34;
            // 
            // errNOMBRE
            // 
            this.errNOMBRE.ContainerControl = this;
            // 
            // errOcupacion
            // 
            this.errOcupacion.ContainerControl = this;
            // 
            // errDescripcion
            // 
            this.errDescripcion.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Datos Referencia";
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.BackColor = System.Drawing.Color.White;
            this.txtCODIGO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCODIGO.Enabled = false;
            this.txtCODIGO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCODIGO.Location = new System.Drawing.Point(126, 27);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(73, 27);
            this.txtCODIGO.TabIndex = 0;
            // 
            // groupBoxDATOS
            // 
            this.groupBoxDATOS.BackColor = System.Drawing.Color.White;
            this.groupBoxDATOS.Controls.Add(this.label3);
            this.groupBoxDATOS.Controls.Add(this.txtDatosReferencia);
            this.groupBoxDATOS.Controls.Add(this.cbsExo);
            this.groupBoxDATOS.Controls.Add(this.dtFecha);
            this.groupBoxDATOS.Controls.Add(this.label2);
            this.groupBoxDATOS.Controls.Add(this.label1);
            this.groupBoxDATOS.Controls.Add(this.label9);
            this.groupBoxDATOS.Controls.Add(this.txtobservacion);
            this.groupBoxDATOS.Controls.Add(this.label5);
            this.groupBoxDATOS.Controls.Add(this.txtNOMBRE);
            this.groupBoxDATOS.Controls.Add(this.lblestado);
            this.groupBoxDATOS.Controls.Add(this.cbESTADO);
            this.groupBoxDATOS.Controls.Add(this.label4);
            this.groupBoxDATOS.Controls.Add(this.txtCODIGO);
            this.groupBoxDATOS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDATOS.Location = new System.Drawing.Point(18, 72);
            this.groupBoxDATOS.Name = "groupBoxDATOS";
            this.groupBoxDATOS.Size = new System.Drawing.Size(489, 407);
            this.groupBoxDATOS.TabIndex = 47;
            this.groupBoxDATOS.TabStop = false;
            this.groupBoxDATOS.Text = "Visualización de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Sexo*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Observación";
            // 
            // txtobservacion
            // 
            this.txtobservacion.BackColor = System.Drawing.Color.White;
            this.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservacion.Enabled = false;
            this.txtobservacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacion.Location = new System.Drawing.Point(126, 252);
            this.txtobservacion.MaxLength = 160;
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.ShortcutsEnabled = false;
            this.txtobservacion.Size = new System.Drawing.Size(327, 106);
            this.txtobservacion.TabIndex = 28;
            this.txtobservacion.Text = "hola a todos como estan todos estamos deguastando una riquisima sopa de la casera" +
    " en el torno este es un dia ermoso para ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre*";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.BackColor = System.Drawing.Color.White;
            this.txtNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNOMBRE.Enabled = false;
            this.txtNOMBRE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOMBRE.Location = new System.Drawing.Point(126, 67);
            this.txtNOMBRE.MaxLength = 50;
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.ShortcutsEnabled = false;
            this.txtNOMBRE.Size = new System.Drawing.Size(327, 27);
            this.txtNOMBRE.TabIndex = 1;
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
            this.cbESTADO.Enabled = false;
            this.cbESTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbESTADO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbESTADO.FormattingEnabled = true;
            this.cbESTADO.Location = new System.Drawing.Point(126, 364);
            this.cbESTADO.Name = "cbESTADO";
            this.cbESTADO.Size = new System.Drawing.Size(161, 27);
            this.cbESTADO.TabIndex = 3;
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
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajadores.ForeColor = System.Drawing.Color.Black;
            this.lblTrabajadores.Location = new System.Drawing.Point(12, 34);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(384, 35);
            this.lblTrabajadores.TabIndex = 46;
            this.lblTrabajadores.Text = "ANÁLISIS LABORATORIO";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.White;
            this.btnCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.Black;
            this.btnCANCELAR.Location = new System.Drawing.Point(412, 485);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(95, 34);
            this.btnCANCELAR.TabIndex = 44;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // errCelular
            // 
            this.errCelular.ContainerControl = this;
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
            this.btnACEPTAR.Location = new System.Drawing.Point(304, 485);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(98, 34);
            this.btnACEPTAR.TabIndex = 43;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnACEPTAR.UseVisualStyleBackColor = false;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // Frm_Ficha_Paciente_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 530);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.groupBoxDATOS);
            this.Controls.Add(this.lblTrabajadores);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnACEPTAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Ficha_Paciente_Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Ficha_Paciente_Eliminar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Ficha_Paciente_Eliminar_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNOMBRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOcupacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDescripcion)).EndInit();
            this.groupBoxDATOS.ResumeLayout(false);
            this.groupBoxDATOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCelular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtDatosReferencia;
        public System.Windows.Forms.ComboBox cbsExo;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        public System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ErrorProvider errNOMBRE;
        public System.Windows.Forms.GroupBox groupBoxDATOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNOMBRE;
        public System.Windows.Forms.Label lblestado;
        public System.Windows.Forms.ComboBox cbESTADO;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Label lblTrabajadores;
        public System.Windows.Forms.Button btnCANCELAR;
        public System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.ErrorProvider errOcupacion;
        private System.Windows.Forms.ErrorProvider errDescripcion;
        private System.Windows.Forms.ErrorProvider errCelular;
    }
}