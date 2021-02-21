namespace Capa_Presentacion.NODULO_REPORTE_CONTROL
{
    partial class Frm_ReporteControlMostrarGlobal
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
            this.crystalReportViewerGlobal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerGlobal
            // 
            this.crystalReportViewerGlobal.ActiveViewIndex = -1;
            this.crystalReportViewerGlobal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerGlobal.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerGlobal.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerGlobal.Name = "crystalReportViewerGlobal";
            this.crystalReportViewerGlobal.Size = new System.Drawing.Size(740, 529);
            this.crystalReportViewerGlobal.TabIndex = 0;
            // 
            // Frm_ReporteControlMostrarGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 529);
            this.Controls.Add(this.crystalReportViewerGlobal);
            this.Name = "Frm_ReporteControlMostrarGlobal";
            this.Text = "Frm_ReporteControlMostrarGlobal";
            this.Load += new System.EventHandler(this.Frm_ReporteControlMostrarGlobal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerGlobal;
    }
}