namespace Capa_Presentacion.Reporte
{
    partial class Frm_USUARIO_Reporte
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
            this.crystalReportViewer_USUARIO = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_USUARIO
            // 
            this.crystalReportViewer_USUARIO.ActiveViewIndex = -1;
            this.crystalReportViewer_USUARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_USUARIO.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_USUARIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_USUARIO.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_USUARIO.Name = "crystalReportViewer_USUARIO";
            this.crystalReportViewer_USUARIO.Size = new System.Drawing.Size(680, 570);
            this.crystalReportViewer_USUARIO.TabIndex = 0;
            this.crystalReportViewer_USUARIO.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_USUARIO_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 570);
            this.Controls.Add(this.crystalReportViewer_USUARIO);
            this.Name = "Frm_USUARIO_Reporte";
            this.Text = "Frm_USUARIO_Reporte";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_USUARIO_Reporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_USUARIO;
    }
}