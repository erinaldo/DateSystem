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
    public partial class FormEditarOsTexto : Form
    {
        public FormEditarOsTexto(string txtOrigemChamado1, string txtServicoExecutado1)
        {
            InitializeComponent();
            txtOrigemChamado.Text = txtOrigemChamado1;
            txtServicoExecutado.Text = txtServicoExecutado1;
        }

        private void FormEditarOsTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
