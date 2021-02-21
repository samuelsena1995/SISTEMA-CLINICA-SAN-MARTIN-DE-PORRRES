namespace Capa_Presentacion.Reporte
{
    partial class Frm_Caja_Reporte_SALA
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
            this.crystalReportViewer_SALA = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_SALA
            // 
            this.crystalReportViewer_SALA.ActiveViewIndex = -1;
            this.crystalReportViewer_SALA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_SALA.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_SALA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_SALA.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_SALA.Name = "crystalReportViewer_SALA";
            this.crystalReportViewer_SALA.Size = new System.Drawing.Size(721, 593);
            this.crystalReportViewer_SALA.TabIndex = 0;
            this.crystalReportViewer_SALA.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Caja_Reporte_SALA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 593);
            this.Controls.Add(this.crystalReportViewer_SALA);
            this.Name = "Frm_Caja_Reporte_SALA";
            this.Text = "Frm_Caja_Reporte_SALA";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Caja_Reporte_SALA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_SALA;
    }
}