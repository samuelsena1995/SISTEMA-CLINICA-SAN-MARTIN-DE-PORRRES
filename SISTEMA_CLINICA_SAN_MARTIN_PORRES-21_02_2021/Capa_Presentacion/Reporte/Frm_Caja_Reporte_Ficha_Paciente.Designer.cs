namespace Capa_Presentacion.Reporte
{
    partial class Frm_Caja_Reporte_Ficha_Paciente
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
            this.crystalReportViewerPaciente = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerPaciente
            // 
            this.crystalReportViewerPaciente.ActiveViewIndex = -1;
            this.crystalReportViewerPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerPaciente.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerPaciente.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerPaciente.Name = "crystalReportViewerPaciente";
            this.crystalReportViewerPaciente.Size = new System.Drawing.Size(630, 600);
            this.crystalReportViewerPaciente.TabIndex = 0;
            this.crystalReportViewerPaciente.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Caja_Reporte_Ficha_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(630, 600);
            this.Controls.Add(this.crystalReportViewerPaciente);
            this.Name = "Frm_Caja_Reporte_Ficha_Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Caja_Reporte_Ficha_Paciente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Caja_Reporte_Ficha_Paciente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerPaciente;
    }
}