using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;

namespace DateSystem
{
    public partial class FormRelatorioRegistroSemSubRegistro : Form
    {


        public FormRelatorioRegistroSemSubRegistro()
        {
            InitializeComponent();
        }
        public FormRelatorioRegistroSemSubRegistro(string txtNumeroDoRegistro, 
            string txtDataSolicitacaoProcesso, string txtNomeRegistro, string txtNumeroRegistro,
            string txtTipo_logradouro, string txtNomeContato, string txtTelefoneRegistro,
            string maskedtxtTelefoneContato, string txtOrigemRegistro, string txtDataContatoRegistro)
        {
            try
            {
                InitializeComponent();

                

                reportViewerRelatorioSemSubRegistro.LocalReport.DataSources.Clear();
                //reportViewerRelatorioSemSubRegistro.LocalReport.ReportEmbeddedResource = "DateSystem.ReportRelatorioRegistroSemSubRegistro.rdlc";
                reportViewerRelatorioSemSubRegistro.LocalReport.ReportEmbeddedResource = "DateSystem.D_LicitaçãoeComercial.FormeRelatorios.ReportRelatorioRegistroSemSubRegistro.rdlc";
                

                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[10];
                p[0] = new Microsoft.Reporting.WinForms.ReportParameter("txtNumeroRegistro1", txtNumeroDoRegistro);
                p[1] = new Microsoft.Reporting.WinForms.ReportParameter("txtDataSolicitacaoProcesso1", txtDataSolicitacaoProcesso);
                p[2] = new Microsoft.Reporting.WinForms.ReportParameter("txtNomeRegistro1", txtNomeRegistro);
                p[3] = new Microsoft.Reporting.WinForms.ReportParameter("txtNumeroClienteRegistro1", txtNumeroRegistro);
                p[4] = new Microsoft.Reporting.WinForms.ReportParameter("EnderencoGerado1", txtTipo_logradouro);
                p[5] = new Microsoft.Reporting.WinForms.ReportParameter("txtTelefone1", txtTelefoneRegistro);
                p[6] = new Microsoft.Reporting.WinForms.ReportParameter("txtDataContato1", txtDataContatoRegistro);
                p[7] = new Microsoft.Reporting.WinForms.ReportParameter("txtContato1", txtNomeContato);
                p[8] = new Microsoft.Reporting.WinForms.ReportParameter("txtTelefoneContato1", maskedtxtTelefoneContato);
                p[9] = new Microsoft.Reporting.WinForms.ReportParameter("txtOrigemRegistro1", txtOrigemRegistro);

                reportViewerRelatorioSemSubRegistro.LocalReport.SetParameters(p);
                reportViewerRelatorioSemSubRegistro.LocalReport.Refresh();
                reportViewerRelatorioSemSubRegistro.RefreshReport();
            }
            catch (Exception e)
            {
                e.ToString();
            }

        }

        private void FormRelatorioRegistroSemSubRegistro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MSOSTESTEDataSet.R_RegistroGeradosSub' table. You can move, or remove it, as needed.
            //this.R_RegistroGeradosSubTableAdapter.Fill(this.MSOSTESTEDataSet.R_RegistroGeradosSub);
            // TODO: This line of code loads data into the 'MSOSTESTEDataSet.R_RegistroGeradosSub' table. You can move, or remove it, as needed.
            //this.R_RegistroGeradosSubTableAdapter.Fill(this.MSOSTESTEDataSet.R_RegistroGeradosSub);

            this.reportViewerRelatorioSemSubRegistro.RefreshReport();

        }

        private void FormRelatorioRegistroSemSubRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void reportViewerRelatorioSemSubRegistro_Load(object sender, EventArgs e)
        {

        }

        private void buttonFecharCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
