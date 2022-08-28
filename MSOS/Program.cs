using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;

namespace DateSystem
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                //UpdateCheckInfo info;
                var lingua = new CultureInfo("pt-BR");
                Thread.CurrentThread.CurrentCulture = lingua;
                Thread.CurrentThread.CurrentUICulture = lingua;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new FormPrincipal());
                //Application.Run(new FormLoginUsuario());
                //Application.Run(new FormCadastraProdutos());

                //ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                //object versao = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                //versao.ToString();
                //info = ad.CheckForDetailedUpdate();

                //Application.Run(new FormTeste());


                //Teste
                FormLoginUsuario LoginUsuario = new FormLoginUsuario();
                LoginUsuario.ShowDialog();
                if (LoginUsuario.logado == true)
                {
                    LoginUsuario.Nome.ToString();
                    LoginUsuario.connectionString.ToString();
                    LoginUsuario.BaseDados.ToString();

                    Application.Run(new FormPrincipal(LoginUsuario.Nome.ToString(), LoginUsuario.connectionString.ToString()));
                   
                    // Application.Run(new FormPrincipal(LoginUsuario.Nome.ToString(), LoginUsuario.connectionString.ToString(), LoginUsuario.BaseDados.ToString()));
                }



            }
            catch (Exception Ex)
            {
                Ex.ToString();
            }
            //catch(DeploymentDownloadException ex)
            //{
            //    MessageBox.Show("Error1 " + ex.Message, "Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    return;
            //}
            //catch(InvalidDeploymentException ide)
            //{
            //    MessageBox.Show("error2 " + ide.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //catch(InvalidOperationException ioe)
            //{
            //    MessageBox.Show("error3 " + ioe.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }
    }
}
