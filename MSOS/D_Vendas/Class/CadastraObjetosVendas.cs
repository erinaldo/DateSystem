using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class CadastraObjetosVendas
    {
        public CadastraObjetosVendas()
        {
            this.IdUnidadeMedida = 0;
            this.QuantidadeUsada = 0;
        }
        public CadastraObjetosVendas(int ID_UNIDADE_MEDIDA, int QUANTIDADE_USADA)
        {

            this.IdUnidadeMedida = ID_UNIDADE_MEDIDA;
            this.QuantidadeUsada = QUANTIDADE_USADA;
        }

        private int ID_UNIDADE_MEDIDA;
        public int IdUnidadeMedida
        {
            get
            {
                return this.ID_UNIDADE_MEDIDA;

            }
            set
            {
                this.ID_UNIDADE_MEDIDA = value;
            }
        }
        private int QUANTIDADE_USADA;
        public int QuantidadeUsada
        {
            get
            {
                return this.QUANTIDADE_USADA;

            }
            set
            {
                this.QUANTIDADE_USADA = value;
            }
        }
    }
}
