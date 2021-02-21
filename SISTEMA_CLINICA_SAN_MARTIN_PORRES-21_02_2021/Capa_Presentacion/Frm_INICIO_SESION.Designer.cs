namespace Capa_Presentacion
{
    partial class Frm_INICIO_SESION
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
            this.pcbxVERCONTRA = new System.Windows.Forms.PictureBox();
            this.lblMINIMIZAR = new System.Windows.Forms.Label();
            this.lblSALIR = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbldesencriptacion = new System.Windows.Forms.Label();
            this.lblINICIODESESION = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxVERCONTRA)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxVERCONTRA
            // 
            this.pcbxVERCONTRA.Location = new System.Drawing.Point(342, 163);
            this.pcbxVERCONTRA.Name = "pcbxVERCONTRA";
            this.pcbxVERCONTRA.Size = new System.Drawing.Size(31, 28);
            this.pcbxVERCONTRA.TabIndex = 18;
            this.pcbxVERCONTRA.TabStop = false;
            // 
            // lblMINIMIZAR
            // 
            this.lblMINIMIZAR.AutoSize = true;
            this.lblMINIMIZAR.BackColor = System.Drawing.Color.Transparent;
            this.lblMINIMIZAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMINIMIZAR.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMINIMIZAR.ForeColor = System.Drawing.Color.Black;
            this.lblMINIMIZAR.Location = new System.Drawing.Point(317, 3);
            this.lblMINIMIZAR.Name = "lblMINIMIZAR";
            this.lblMINIMIZAR.Size = new System.Drawing.Size(24, 27);
            this.lblMINIMIZAR.TabIndex = 16;
            this.lblMINIMIZAR.Text = "_";
            // 
            // lblSALIR
            // 
            this.lblSALIR.AutoSize = true;
            this.lblSALIR.BackColor = System.Drawing.Color.Transparent;
            this.lblSALIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSALIR.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSALIR.ForeColor = System.Drawing.Color.Black;
            this.lblSALIR.Location = new System.Drawing.Point(347, 3);
            this.lblSALIR.Name = "lblSALIR";
            this.lblSALIR.Size = new System.Drawing.Size(26, 27);
            this.lblSALIR.TabIndex = 17;
            this.lblSALIR.Text = "X";
            this.lblSALIR.Click += new System.EventHandler(this.lblSALIR_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(52, 171);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(284, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(53, 111);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(284, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "USUARIO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(52, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "ACCEDER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(408, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 160);
            this.listBox1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(440, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "ACCEDER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbldesencriptacion
            // 
            this.lbldesencriptacion.AutoSize = true;
            this.lbldesencriptacion.Location = new System.Drawing.Point(163, 78);
            this.lbldesencriptacion.Name = "lbldesencriptacion";
            this.lbldesencriptacion.Size = new System.Drawing.Size(35, 13);
            this.lbldesencriptacion.TabIndex = 21;
            this.lbldesencriptacion.Text = "label1";
            this.lbldesencriptacion.Visible = false;
            // 
            // lblINICIODESESION
            // 
            this.lblINICIODESESION.AutoSize = true;
            this.lblINICIODESESION.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINICIODESESION.ForeColor = System.Drawing.Color.Black;
            this.lblINICIODESESION.Location = new System.Drawing.Point(92, 40);
            this.lblINICIODESESION.Name = "lblINICIODESESION";
            this.lblINICIODESESION.Size = new System.Drawing.Size(213, 29);
            this.lblINICIODESESION.TabIndex = 15;
            this.lblINICIODESESION.Text = "INICIO DE SESIÓN";
            // 
            // Frm_INICIO_SESION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(393, 318);
            this.Controls.Add(this.lblINICIODESESION);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbldesencriptacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMINIMIZAR);
            this.Controls.Add(this.lblSALIR);
            this.Controls.Add(this.pcbxVERCONTRA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_INICIO_SESION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_INICIO_SESION";
            this.Load += new System.EventHandler(this.Frm_INICIO_SESION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxVERCONTRA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbxVERCONTRA;
        private System.Windows.Forms.Label lblMINIMIZAR;
        private System.Windows.Forms.Label lblSALIR;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbldesencriptacion;
        private System.Windows.Forms.Label lblINICIODESESION;
    }
}