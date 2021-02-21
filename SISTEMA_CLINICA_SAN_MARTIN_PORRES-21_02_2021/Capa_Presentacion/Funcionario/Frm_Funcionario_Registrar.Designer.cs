namespace Capa_Presentacion.Funcionario
{
    partial class Frm_Funcionario_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Funcionario_Registrar));
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.errNOMBRE = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.errNcelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.groupBoxDATOS = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtocupacion = new System.Windows.Forms.TextBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.errOcupacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errNOMBRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNcelular)).BeginInit();
            this.groupBoxDATOS.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errOcupacion)).BeginInit();
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
            this.btnACEPTAR.Location = new System.Drawing.Point(268, 490);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(98, 34);
            this.btnACEPTAR.TabIndex = 0;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnACEPTAR.UseVisualStyleBackColor = false;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Observación";
            // 
            // errNOMBRE
            // 
            this.errNOMBRE.ContainerControl = this;
            // 
            // txtobservacion
            // 
            this.txtobservacion.BackColor = System.Drawing.Color.White;
            this.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacion.Location = new System.Drawing.Point(129, 231);
            this.txtobservacion.MaxLength = 160;
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.ShortcutsEnabled = false;
            this.txtobservacion.Size = new System.Drawing.Size(327, 106);
            this.txtobservacion.TabIndex = 5;
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
            this.lblestado.Location = new System.Drawing.Point(21, 355);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(56, 19);
            this.lblestado.TabIndex = 8;
            this.lblestado.Text = "Estado";
            // 
            // cbESTADO
            // 
            this.cbESTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbESTADO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbESTADO.FormattingEnabled = true;
            this.cbESTADO.Location = new System.Drawing.Point(119, 355);
            this.cbESTADO.Name = "cbESTADO";
            this.cbESTADO.Size = new System.Drawing.Size(161, 27);
            this.cbESTADO.TabIndex = 6;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Capa_Presentacion.Properties.Resources._1954538_24;
            this.btnMaximizar.Location = new System.Drawing.Point(476, 6);
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
            this.btnCerrar.Location = new System.Drawing.Point(500, 6);
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
            this.btnRestaurar.Location = new System.Drawing.Point(452, 6);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 6;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
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
            this.lblTrabajadores.Location = new System.Drawing.Point(12, 36);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(384, 35);
            this.lblTrabajadores.TabIndex = 36;
            this.lblTrabajadores.Text = "ANÁLISIS LABORATORIO";
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
            // errNcelular
            // 
            this.errNcelular.ContainerControl = this;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.White;
            this.btnCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.Black;
            this.btnCANCELAR.Location = new System.Drawing.Point(376, 490);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(95, 34);
            this.btnCANCELAR.TabIndex = 1;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // groupBoxDATOS
            // 
            this.groupBoxDATOS.BackColor = System.Drawing.Color.White;
            this.groupBoxDATOS.Controls.Add(this.label2);
            this.groupBoxDATOS.Controls.Add(this.txtcelular);
            this.groupBoxDATOS.Controls.Add(this.label1);
            this.groupBoxDATOS.Controls.Add(this.txtocupacion);
            this.groupBoxDATOS.Controls.Add(this.label9);
            this.groupBoxDATOS.Controls.Add(this.txtobservacion);
            this.groupBoxDATOS.Controls.Add(this.label5);
            this.groupBoxDATOS.Controls.Add(this.txtNOMBRE);
            this.groupBoxDATOS.Controls.Add(this.lblestado);
            this.groupBoxDATOS.Controls.Add(this.cbESTADO);
            this.groupBoxDATOS.Controls.Add(this.label4);
            this.groupBoxDATOS.Controls.Add(this.txtCODIGO);
            this.groupBoxDATOS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDATOS.Location = new System.Drawing.Point(18, 84);
            this.groupBoxDATOS.Name = "groupBoxDATOS";
            this.groupBoxDATOS.Size = new System.Drawing.Size(489, 400);
            this.groupBoxDATOS.TabIndex = 37;
            this.groupBoxDATOS.TabStop = false;
            this.groupBoxDATOS.Text = "Visualización de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nº Celular*";
            // 
            // txtcelular
            // 
            this.txtcelular.BackColor = System.Drawing.Color.White;
            this.txtcelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcelular.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(126, 168);
            this.txtcelular.MaxLength = 8;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.ShortcutsEnabled = false;
            this.txtcelular.Size = new System.Drawing.Size(100, 27);
            this.txtcelular.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ocupación*";
            // 
            // txtocupacion
            // 
            this.txtocupacion.BackColor = System.Drawing.Color.White;
            this.txtocupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtocupacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtocupacion.Location = new System.Drawing.Point(126, 118);
            this.txtocupacion.MaxLength = 50;
            this.txtocupacion.Name = "txtocupacion";
            this.txtocupacion.ShortcutsEnabled = false;
            this.txtocupacion.Size = new System.Drawing.Size(189, 27);
            this.txtocupacion.TabIndex = 2;
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(528, 32);
            this.panelBarraTitulo.TabIndex = 35;
            // 
            // errOcupacion
            // 
            this.errOcupacion.ContainerControl = this;
            // 
            // Frm_Funcionario_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 536);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.lblTrabajadores);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.groupBoxDATOS);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Funcionario_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Funcionario_Registrar";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Funcionario_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Funcionario_Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errNOMBRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNcelular)).EndInit();
            this.groupBoxDATOS.ResumeLayout(false);
            this.groupBoxDATOS.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errOcupacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errNOMBRE;
        private System.Windows.Forms.Label lblTrabajadores;
        public System.Windows.Forms.Button btnCANCELAR;
        public System.Windows.Forms.GroupBox groupBoxDATOS;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtocupacion;
        public System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNOMBRE;
        public System.Windows.Forms.Label lblestado;
        public System.Windows.Forms.ComboBox cbESTADO;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.ErrorProvider errNcelular;
        private System.Windows.Forms.ErrorProvider errOcupacion;
    }
}