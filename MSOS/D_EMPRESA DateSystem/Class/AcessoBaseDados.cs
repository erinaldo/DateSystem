using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class AcessoBaseDados
    {
        public AcessoBaseDados()
        {
            this.IdAcessoBaseDados = 0;
            this.Servidor = "";
            this.BaseDados = "";
            this.Nome = "";
            this.Senha="";
            this.IdTemp = 0;
        }
        public AcessoBaseDados(int IDACESSOBASEDADOS, string SERVIDOR,string BASEDADOS,string NOME,string SENHA,int IDTEMP)
        {
            this.IdAcessoBaseDados = IDACESSOBASEDADOS;
            this.Servidor = SERVIDOR;
            this.BaseDados = BASEDADOS;
            this.Nome = NOME;
            this.Senha = SENHA;
            this.IdTemp = IDTEMP;
        }

        private int IDACESSOBASEDADOS;
        public int IdAcessoBaseDados
        {
            get
            {
                return this.IDACESSOBASEDADOS;

            }
            set
            {
                this.IDACESSOBASEDADOS = value;
            }
        }

        private string SERVIDOR;
        public string Servidor
        {
            get
            {
                return this.SERVIDOR;

            }
            set
            {
                this.SERVIDOR = value;
            }
        }
        private string BASEDADOS;
        public string BaseDados
        {
            get
            {
                return this.BASEDADOS;

            }
            set
            {
                this.BASEDADOS = value;
            }
        }
        private string NOME;
        public string Nome
        {
            get
            {
                return this.NOME;

            }
            set
            {
                this.NOME = value;
            }
        }
        private string SENHA;
        public string Senha
        {
            get
            {
                return this.SENHA;

            }
            set
            {
                this.SENHA = value;
            }
        }
        private int IDTEMP;
        public int IdTemp
        {
            get
            {
                return this.IDTEMP;

            }
            set
            {
                this.IDTEMP = value;
            }
        }
    }
}
