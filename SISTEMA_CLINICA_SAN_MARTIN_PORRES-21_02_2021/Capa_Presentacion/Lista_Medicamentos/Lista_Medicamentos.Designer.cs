﻿namespace Capa_Presentacion.Lista_Medicamentos
{
    partial class Lista_Medicamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tODOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustpELIMINAR = new System.Windows.Forms.ToolStripMenuItem();
            this.menustpCAMBIARESTADO = new System.Windows.Forms.ToolStripMenuItem();
            this.menustpEDITAR = new System.Windows.Forms.ToolStripMenuItem();
            this.menustpNUEVO = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_maximize_1954538;
            this.btnMaximizar.Location = new System.Drawing.Point(816, 4);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 22;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Capa_Presentacion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(843, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.TabStop = false;
            // 
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajadores.ForeColor = System.Drawing.Color.Black;
            this.lblTrabajadores.Location = new System.Drawing.Point(6, 58);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(447, 35);
            this.lblTrabajadores.TabIndex = 18;
            this.lblTrabajadores.Text = "LISTADO DE MEDICAMENTOS";
            this.lblTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.Location = new System.Drawing.Point(12, 212);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(850, 327);
            this.dgvLista.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Capa_Presentacion.Properties.Resources.iconfinder_67_111124;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(745, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 27);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFiltroEstado);
            this.groupBox1.Controls.Add(this.cbFiltro);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 93);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de búsqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar por";
            // 
            // cbFiltroEstado
            // 
            this.cbFiltroEstado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroEstado.FormattingEnabled = true;
            this.cbFiltroEstado.Items.AddRange(new object[] {
            "Todos",
            "Habilitado",
            "Deshabilitado"});
            this.cbFiltroEstado.Location = new System.Drawing.Point(560, 51);
            this.cbFiltroEstado.Name = "cbFiltroEstado";
            this.cbFiltroEstado.Size = new System.Drawing.Size(162, 27);
            this.cbFiltroEstado.TabIndex = 6;
            this.cbFiltroEstado.Text = "Todos";
            // 
            // cbFiltro
            // 
            this.cbFiltro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nombre",
            "Descripcion"});
            this.cbFiltro.Location = new System.Drawing.Point(323, 51);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(218, 27);
            this.cbFiltro.TabIndex = 3;
            this.cbFiltro.Text = "Nombre";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(19, 51);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(278, 27);
            this.txtBusqueda.TabIndex = 0;
            // 
            // tODOSToolStripMenuItem
            // 
            this.tODOSToolStripMenuItem.Name = "tODOSToolStripMenuItem";
            this.tODOSToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.tODOSToolStripMenuItem.Text = "Lista de Análisis de Laboratorio";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tODOSToolStripMenuItem});
            this.informesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.informesToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_print_16087991;
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.consultarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.consultarToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_67_111124;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // menustpELIMINAR
            // 
            this.menustpELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.menustpELIMINAR.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_icons_delete_1564502;
            this.menustpELIMINAR.Name = "menustpELIMINAR";
            this.menustpELIMINAR.Size = new System.Drawing.Size(98, 24);
            this.menustpELIMINAR.Text = "Eliminar";
            // 
            // menustpCAMBIARESTADO
            // 
            this.menustpCAMBIARESTADO.ForeColor = System.Drawing.Color.Black;
            this.menustpCAMBIARESTADO.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_UI_Basic_GLYPH_48_4733376;
            this.menustpCAMBIARESTADO.Name = "menustpCAMBIARESTADO";
            this.menustpCAMBIARESTADO.Size = new System.Drawing.Size(157, 24);
            this.menustpCAMBIARESTADO.Text = "Cambiar Estado";
            // 
            // menustpEDITAR
            // 
            this.menustpEDITAR.ForeColor = System.Drawing.Color.Black;
            this.menustpEDITAR.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_081_Pen_183209;
            this.menustpEDITAR.Name = "menustpEDITAR";
            this.menustpEDITAR.Size = new System.Drawing.Size(81, 24);
            this.menustpEDITAR.Text = "Editar";
            // 
            // menustpNUEVO
            // 
            this.menustpNUEVO.ForeColor = System.Drawing.Color.Black;
            this.menustpNUEVO.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_add_70px_510874;
            this.menustpNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menustpNUEVO.Name = "menustpNUEVO";
            this.menustpNUEVO.Size = new System.Drawing.Size(84, 24);
            this.menustpNUEVO.Text = "Nuevo";
            this.menustpNUEVO.Click += new System.EventHandler(this.menustpNUEVO_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustpNUEVO,
            this.menustpEDITAR,
            this.menustpCAMBIARESTADO,
            this.menustpELIMINAR,
            this.consultarToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Capa_Presentacion.Properties.Resources.iconfinder_window_minimize_19545521;
            this.btnRestaurar.Location = new System.Drawing.Point(790, 4);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 23;
            this.btnRestaurar.TabStop = false;
            // 
            // Lista_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 545);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTrabajadores);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_Medicamentos";
            this.Text = "Lista_Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblTrabajadores;
        public System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFiltroEstado;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ToolStripMenuItem tODOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menustpELIMINAR;
        private System.Windows.Forms.ToolStripMenuItem menustpCAMBIARESTADO;
        private System.Windows.Forms.ToolStripMenuItem menustpEDITAR;
        private System.Windows.Forms.ToolStripMenuItem menustpNUEVO;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox btnRestaurar;
    }
}