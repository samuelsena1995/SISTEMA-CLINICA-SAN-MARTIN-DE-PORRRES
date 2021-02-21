namespace Capa_Presentacion.Usuario
{
    partial class Frm_Usuario_Nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuario_Nuevo));
            this.lbl = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.cbestado_Usuario = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_codigo_usuario = new System.Windows.Forms.TextBox();
            this.txtNombre_Rol = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTCOPIA_USUARIO = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.errNombreUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errContraseña)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl.Location = new System.Drawing.Point(14, 38);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(80, 27);
            this.lbl.TabIndex = 120;
            this.lbl.Text = "label1";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.White;
            this.btnCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.Black;
            this.btnCANCELAR.Location = new System.Drawing.Point(415, 449);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(95, 34);
            this.btnCANCELAR.TabIndex = 118;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_usuario);
            this.groupBox2.Controls.Add(this.cbestado_Usuario);
            this.groupBox2.Controls.Add(this.lblestado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.txtobservacion);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_codigo_usuario);
            this.groupBox2.Controls.Add(this.txtNombre_Rol);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 362);
            this.groupBox2.TabIndex = 119;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS USUARIO";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 126;
            this.label2.Text = "Usuario*";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(145, 90);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(239, 22);
            this.txt_usuario.TabIndex = 125;
            // 
            // cbestado_Usuario
            // 
            this.cbestado_Usuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbestado_Usuario.FormattingEnabled = true;
            this.cbestado_Usuario.Items.AddRange(new object[] {
            "Todos",
            "Habilitado",
            "Deshabilitado"});
            this.cbestado_Usuario.Location = new System.Drawing.Point(145, 272);
            this.cbestado_Usuario.Name = "cbestado_Usuario";
            this.cbestado_Usuario.Size = new System.Drawing.Size(162, 27);
            this.cbestado_Usuario.TabIndex = 4;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblestado.Location = new System.Drawing.Point(24, 272);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(50, 17);
            this.lblestado.TabIndex = 112;
            this.lblestado.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 111;
            this.label3.Text = "Contraseña*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(23, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 109;
            this.label1.Text = "Observacion";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(145, 126);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(239, 22);
            this.txtContraseña.TabIndex = 2;
            // 
            // txtobservacion
            // 
            this.txtobservacion.Location = new System.Drawing.Point(145, 162);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(327, 104);
            this.txtobservacion.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label16.Location = new System.Drawing.Point(22, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 104;
            this.label16.Text = "Codigo*";
            // 
            // txt_codigo_usuario
            // 
            this.txt_codigo_usuario.Location = new System.Drawing.Point(145, 17);
            this.txt_codigo_usuario.Name = "txt_codigo_usuario";
            this.txt_codigo_usuario.Size = new System.Drawing.Size(148, 22);
            this.txt_codigo_usuario.TabIndex = 0;
            // 
            // txtNombre_Rol
            // 
            this.txtNombre_Rol.Location = new System.Drawing.Point(145, 53);
            this.txtNombre_Rol.Name = "txtNombre_Rol";
            this.txtNombre_Rol.Size = new System.Drawing.Size(239, 22);
            this.txtNombre_Rol.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(22, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nombre*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTCOPIA_USUARIO);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(1, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 51);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            // 
            // TXTCOPIA_USUARIO
            // 
            this.TXTCOPIA_USUARIO.Enabled = false;
            this.TXTCOPIA_USUARIO.Location = new System.Drawing.Point(224, 17);
            this.TXTCOPIA_USUARIO.Name = "TXTCOPIA_USUARIO";
            this.TXTCOPIA_USUARIO.Size = new System.Drawing.Size(173, 22);
            this.TXTCOPIA_USUARIO.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(168, 18);
            this.checkBox1.TabIndex = 123;
            this.checkBox1.Text = "Autorización como usuario";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACEPTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACEPTAR.ForeColor = System.Drawing.Color.Black;
            this.btnACEPTAR.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_save_1608823;
            this.btnACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACEPTAR.Location = new System.Drawing.Point(311, 449);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(98, 34);
            this.btnACEPTAR.TabIndex = 1;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnACEPTAR.UseVisualStyleBackColor = false;
            this.btnACEPTAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // errNombreUsuario
            // 
            this.errNombreUsuario.ContainerControl = this;
            // 
            // errUsuario
            // 
            this.errUsuario.ContainerControl = this;
            // 
            // errContraseña
            // 
            this.errContraseña.ContainerControl = this;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.Gray;
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(530, 32);
            this.panelBarraTitulo.TabIndex = 124;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(502, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Visible = false;
            // 
            // Frm_Usuario_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 495);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Usuario_Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Usuario_Nuevo";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Usuario_Nuevo_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Usuario_Nuevo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errContraseña)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox cbestado_Usuario;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txt_codigo_usuario;
        public System.Windows.Forms.TextBox txtNombre_Rol;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errNombreUsuario;
        private System.Windows.Forms.ErrorProvider errUsuario;
        private System.Windows.Forms.ErrorProvider errContraseña;
        public System.Windows.Forms.TextBox TXTCOPIA_USUARIO;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_usuario;
    }
}