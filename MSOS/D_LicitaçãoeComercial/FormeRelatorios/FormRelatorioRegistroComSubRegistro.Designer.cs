namespace DateSystem
{
    partial class FormRelatorioRegistroComSubRegistro
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.R_RegistroGeradosSubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MSOSTESTEDataSet = new DateSystem.MSOSTESTEDataSet();
            this.reportViewerRegistroComSubRegistro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.R_RegistroGeradosSubTableAdapter = new DateSystem.MSOSTESTEDataSetTableAdapters.R_RegistroGeradosSubTableAdapter();
            this.buttonFecharCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.R_RegistroGeradosSubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MSOSTESTEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // R_RegistroGeradosSubBindingSource
            // 
            this.R_RegistroGeradosSubBindingSource.DataMember = "R_RegistroGeradosSub";
            this.R_RegistroGeradosSubBindingSource.DataSource = this.MSOSTESTEDataSet;
            // 
            // MSOSTESTEDataSet
            // 
            this.MSOSTESTEDataSet.DataSetName = "MSOSTESTEDataSet";
            this.MSOSTESTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerRegistroComSubRegistro
            // 
            this.reportViewerRegistroComSubRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetSubRegistro";
            reportDataSource1.Value = this.R_RegistroGeradosSubBindingSource;
            this.reportViewerRegistroComSubRegistro.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRegistroComSubRegistro.LocalReport.ReportEmbeddedResource = "DateSystem.ReportRelatorioRegistroComSubRegistro.rdlc";
            this.reportViewerRegistroComSubRegistro.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRegistroComSubRegistro.Name = "reportViewerRegistroComSubRegistro";
            this.reportViewerRegistroComSubRegistro.Size = new System.Drawing.Size(793, 934);
            this.reportViewerRegistroComSubRegistro.TabIndex = 0;
            // 
            // R_RegistroGeradosSubTableAdapter
            // 
            this.R_RegistroGeradosSubTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFecharCliente
            // 
            this.buttonFecharCliente.Location = new System.Drawing.Point(766, 0);
            this.buttonFecharCliente.Name = "buttonFecharCliente";
            this.buttonFecharCliente.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharCliente.TabIndex = 100;
            this.buttonFecharCliente.Text = "F";
            this.buttonFecharCliente.UseVisualStyleBackColor = true;
            this.buttonFecharCliente.Click += new System.EventHandler(this.buttonFecharCliente_Click);
            // 
            // FormRelatorioRegistroComSubRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 934);
            this.ControlBox = false;
            this.Controls.Add(this.buttonFecharCliente);
            this.Controls.Add(this.reportViewerRegistroComSubRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorioRegistroComSubRegistro";
            this.Text = "Relatório do Registro Com Sub Registro";
            this.Load += new System.EventHandler(this.FormRelatorioRegistroComSubRegistro_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormRelatorioRegistroComSubRegistro_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.R_RegistroGeradosSubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MSOSTESTEDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRegistroComSubRegistro;
        private System.Windows.Forms.BindingSource R_RegistroGeradosSubBindingSource;
        private MSOSTESTEDataSet MSOSTESTEDataSet;
        private MSOSTESTEDataSetTableAdapters.R_RegistroGeradosSubTableAdapter R_RegistroGeradosSubTableAdapter;
        private System.Windows.Forms.Button buttonFecharCliente;
    }
}