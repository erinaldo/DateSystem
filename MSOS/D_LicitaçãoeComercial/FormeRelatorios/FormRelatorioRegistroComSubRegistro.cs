using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateSystem
{
    public partial class FormRelatorioRegistroComSubRegistro : Form
    {
        private string IDREGISTRO = "";
        public string IdRegistro
        {
            get
            {
                return this.IDREGISTRO;

            }
            set
            {
                this.IDREGISTRO = value;
            }
        }
        private string DATASOLICITACAOPROCESSO = "";
        public string DataSolicitacaoProcesso
        {
            get
            {
                return this.DATASOLICITACAOPROCESSO;

            }
            set
            {
                this.DATASOLICITACAOPROCESSO = value;
            }
        }
        private string NOMEREGISTRO = "";
        public string NomeRegistro
        {
            get
            {
                return this.NOMEREGISTRO;

            }
            set
            {
                this.NOMEREGISTRO = value;
            }
        }
        private string NUMEROREGISTRO = "";
        public string NumeroRegistro
        {
            get
            {
                return this.NUMEROREGISTRO;

            }
            set
            {
                this.NUMEROREGISTRO = value;
            }
        }
        private string ENDERECOGERADO = "";
        public string EnderencoGerado1
        {
            get
            {
                return this.ENDERECOGERADO;

            }
            set
            {
                this.ENDERECOGERADO = value;
            }
        }
        private string TELEFONEREGISTO = "";
        public string TelefoneRegistro
        {
            get
            {
                return this.TELEFONEREGISTO;

            }
            set
            {
                this.TELEFONEREGISTO = value;
            }
        }
        private string DATACONTATOREGISTRO = "";
        public string DataContatoRegistro
        {
            get
            {
                return this.DATACONTATOREGISTRO;

            }
            set
            {
                this.DATACONTATOREGISTRO = value;
            }
        }
        private string NOMECONTATO = "";
        public string NomeContato
        {
            get
            {
                return this.NOMECONTATO;

            }
            set
            {
                this.NOMECONTATO = value;
            }
        }
        private string TELEFONECONTATO = "";
        public string TelefoneContato
        {
            get
            {
                return this.TELEFONECONTATO;

            }
            set
            {
                this.TELEFONECONTATO = value;
            }
        }
        private string ORIGEMREGISTRO = "";
        public string OrigemRegistro
        {
            get
            {
                return this.ORIGEMREGISTRO;

            }
            set
            {
                this.ORIGEMREGISTRO = value;
            }
        }
        private string CONNETIONSTRING = "";
        public string connetionString
        {
            get
            {
                return this.CONNETIONSTRING;

            }
            set
            {
                this.CONNETIONSTRING = value;
            }
        }

        public FormRelatorioRegistroComSubRegistro()
        {
            InitializeComponent();
        }
        public FormRelatorioRegistroComSubRegistro(string txtNumeroDoRegistro,
            string txtDataSolicitacaoProcesso, string txtNomeRegistro, string txtNumeroRegistro,
            string EnderencoGerado, string  txtNomeContato, string txtTelefoneRegistro,string maskedtxtTelefoneContato,
            string txtOrigemRegistro, string txtDataContatoRegistro, string connetionString1)
        {
            try
            {
                InitializeComponent();

                IdRegistro = txtNumeroDoRegistro;
                DataSolicitacaoProcesso = txtDataSolicitacaoProcesso;
                NomeContato = txtNomeRegistro;
                NumeroRegistro = txtNumeroRegistro;
                EnderencoGerado1 = EnderencoGerado;
                NomeContato = txtNomeContato;
                TelefoneRegistro = txtTelefoneRegistro;
                TelefoneContato = maskedtxtTelefoneContato;
                OrigemRegistro = txtOrigemRegistro;
                DataContatoRegistro = txtDataContatoRegistro;
                connetionString = connetionString1;



                //reportViewerRegistroComSubRegistro.LocalReport.DataSources.Clear();
                //reportViewerRegistroComSubRegistro.LocalReport.ReportEmbeddedResource = "DateSystem.ReportRelatorioRegistroComSubRegistro.rdlc";
                reportViewerRegistroComSubRegistro.LocalReport.ReportEmbeddedResource = "DateSystem.D_LicitaçãoeComercial.FormeRelatorios.ReportRelatorioRegistroComSubRegistro.rdlc";

                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[10];
                p[0] = new Microsoft.Reporting.WinForms.ReportParameter("txtNumeroRegistro1", txtNumeroDoRegistro);
                p[1] = new Microsoft.Reporting.WinForms.ReportParameter("txtDataSolicitacaoProcesso1", txtDataSolicitacaoProcesso);
                p[2] = new Microsoft.Reporting.WinForms.ReportParameter("txtNomeRegistro1", txtNomeRegistro);
                p[3] = new Microsoft.Reporting.WinForms.ReportParameter("txtNumeroClienteRegistro1", txtNumeroRegistro);
                p[4] = new Microsoft.Reporting.WinForms.ReportParameter("EnderencoGerado1", EnderencoGerado);
                p[5] = new Microsoft.Reporting.WinForms.ReportParameter("txtTelefone1", txtTelefoneRegistro);
                p[6] = new Microsoft.Reporting.WinForms.ReportParameter("txtDataContato1", txtDataContatoRegistro);
                p[7] = new Microsoft.Reporting.WinForms.ReportParameter("txtContato1", txtNomeContato);
                p[8] = new Microsoft.Reporting.WinForms.ReportParameter("txtTelefoneContato1", maskedtxtTelefoneContato);
                p[9] = new Microsoft.Reporting.WinForms.ReportParameter("txtOrigemRegistro1", txtOrigemRegistro);

                reportViewerRegistroComSubRegistro.LocalReport.SetParameters(p);
                reportViewerRegistroComSubRegistro.LocalReport.Refresh();
                reportViewerRegistroComSubRegistro.RefreshReport();
            }
            catch (Exception e)
            {
                e.ToString();
            }

        }

        private void FormRelatorioRegistroComSubRegistro_Load(object sender, EventArgs e)
        {
            try
            {
                this.R_RegistroGeradosSubTableAdapter.Fill(this.MSOSTESTEDataSet.R_RegistroGeradosSub, int.Parse(this.IdRegistro));
                this.reportViewerRegistroComSubRegistro.RefreshReport();
            }
            catch(Exception ex)
            {
                ex.ToString();
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.R_RegistroGeradosSubTableAdapter.Fill(this.MSOSTESTEDataSet.R_RegistroGeradosSub, this.IdRegistro);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FormRelatorioRegistroComSubRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void buttonFecharCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
