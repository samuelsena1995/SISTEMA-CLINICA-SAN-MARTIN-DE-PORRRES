namespace Capa_Presentacion.Reporte
{
    partial class Frm_Reporte_Medico_caja
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
            this.crystalReportViewer_Medico = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_Medico
            // 
            this.crystalReportViewer_Medico.ActiveViewIndex = -1;
            this.crystalReportViewer_Medico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_Medico.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_Medico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_Medico.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_Medico.Name = "crystalReportViewer_Medico";
            this.crystalReportViewer_Medico.Size = new System.Drawing.Size(569, 515);
            this.crystalReportViewer_Medico.TabIndex = 0;
            this.crystalReportViewer_Medico.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Reporte_Medico_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(569, 515);
            this.Controls.Add(this.crystalReportViewer_Medico);
            this.Name = "Frm_Reporte_Medico_caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Reporte_Medico";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Reporte_Medico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_Medico;
    }
}