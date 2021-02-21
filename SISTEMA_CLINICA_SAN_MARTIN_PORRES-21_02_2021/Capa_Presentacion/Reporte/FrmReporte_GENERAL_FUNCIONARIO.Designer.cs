namespace Capa_Presentacion.Reporte
{
    partial class FrmReporte_GENERAL_FUNCIONARIO
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
            this.crystalReportViewerFUNCIONARIO = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerFUNCIONARIO
            // 
            this.crystalReportViewerFUNCIONARIO.ActiveViewIndex = -1;
            this.crystalReportViewerFUNCIONARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerFUNCIONARIO.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerFUNCIONARIO.DisplayStatusBar = false;
            this.crystalReportViewerFUNCIONARIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerFUNCIONARIO.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerFUNCIONARIO.Name = "crystalReportViewerFUNCIONARIO";
            this.crystalReportViewerFUNCIONARIO.Size = new System.Drawing.Size(659, 546);
            this.crystalReportViewerFUNCIONARIO.TabIndex = 0;
            // 
            // FrmReporte_GENERAL_FUNCIONARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(659, 546);
            this.Controls.Add(this.crystalReportViewerFUNCIONARIO);
            this.Name = "FrmReporte_GENERAL_FUNCIONARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporte_GENERAL_FUNCIONARIO";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmReporte_GENERAL_FUNCIONARIO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerFUNCIONARIO;
    }
}