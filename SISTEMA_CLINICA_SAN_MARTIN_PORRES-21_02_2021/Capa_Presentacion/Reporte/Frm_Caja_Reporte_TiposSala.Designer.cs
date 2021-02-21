namespace Capa_Presentacion.Reporte
{
    partial class Frm_Caja_Reporte_TiposSala
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
            this.crystalReportViewerTiposSala = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerTiposSala
            // 
            this.crystalReportViewerTiposSala.ActiveViewIndex = -1;
            this.crystalReportViewerTiposSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTiposSala.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerTiposSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerTiposSala.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerTiposSala.Name = "crystalReportViewerTiposSala";
            this.crystalReportViewerTiposSala.Size = new System.Drawing.Size(640, 538);
            this.crystalReportViewerTiposSala.TabIndex = 0;
            this.crystalReportViewerTiposSala.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Caja_Reporte_TiposSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(640, 538);
            this.Controls.Add(this.crystalReportViewerTiposSala);
            this.Name = "Frm_Caja_Reporte_TiposSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Caja_Reporte_TiposSala";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Caja_Reporte_TiposSala_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTiposSala;
    }
}