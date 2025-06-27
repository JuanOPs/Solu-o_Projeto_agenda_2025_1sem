namespace Projeto_agenda_2025_1sem.teste
{
    partial class frmTesteVizualisa
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Agenda1 = new Projeto_agenda_2025_1sem.Dados.DataSet_Agenda();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_agenda_2025_1sem.Relatórios.RelatorioPessoas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(725, 410);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Agenda1
            // 
            this.dataSet_Agenda1.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmTesteVizualisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTesteVizualisa";
            this.Text = "frmTesteVizualisa";
            this.Load += new System.EventHandler(this.frmTesteVizualisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dados.DataSet_Agenda dataSet_Agenda1;
    }
}