using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class OsImagem
    {
        public OsImagem()
        {
            this.IdOsImagem = 0;
            this.IdOs = 0;
            this.Imagem = null;
        }
        public OsImagem(int ID_OS_IMAGEM, int ID_OS, byte[] IMAGEM)
        {
            this.IdOsImagem = ID_OS_IMAGEM;
            this.IdOs = ID_OS;
            this.Imagem = IMAGEM;
        }

        private int ID_OS_IMAGEM;
        public int IdOsImagem
        {
            get
            {
                return this.ID_OS_IMAGEM;

            }
            set
            {
                this.ID_OS_IMAGEM = value;
            }
        }

        private int ID_OS;
        public int IdOs
        {
            get
            {
                return this.ID_OS;

            }
            set
            {
                this.ID_OS = value;
            }
        }
        private byte[] IMAGEM;
        public byte[] Imagem
        {
            get
            {
                return this.IMAGEM;

            }
            set
            {
                this.IMAGEM = value;
            }
        }
    }
}
