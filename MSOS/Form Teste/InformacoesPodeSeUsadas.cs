using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class InformacoesPodeSeUsadas
    {
        //public static string ConsultaCategoriaMarca(string [] IdCategoriaMArca)
        //{
        //    try
        //    {
        //        string ConversaoValores = IdCategoriaMArca;

        //        int quantElementosVetor = IdCategoriaMArca.Length;

        //        int QEVetor = quantElementosVetor / 2;

        //        int[] QuantElementos = new int[QEVetor]; //9

        //        int posicao = 0;

        //        Boolean finalizador = false;

        //        while (finalizador == false)
        //        {
        //            int i = 0;

        //            string VetorStringNumero = "";

        //            StringBuilder sb = new StringBuilder(IdCategoriaMArca);

        //            int quantString = IdCategoriaMArca.Length;

        //            string StringTeste = IdCategoriaMArca;


        //            for (i = 0; i <= quantString - 1; i++)
        //            {
        //                if (StringTeste[i] == ';')
        //                {
        //                    string Temp = "";

        //                    Temp = sb.ToString();

        //                    StringBuilder NumeroPosicao = new StringBuilder(Temp);

        //                    NumeroPosicao.Remove(i, quantString - i);

        //                    VetorStringNumero = NumeroPosicao.ToString();

        //                    StringBuilder StringVerificar = new StringBuilder(Temp);

        //                    StringVerificar.Remove(0, i+1);

        //                    IdCategoriaMArca = StringVerificar.ToString();

        //                    int inteiro = int.Parse(VetorStringNumero);

        //                    QuantElementos[posicao] = inteiro;

        //                    posicao++;

        //                    finalizador = false;

        //                    break;
        //                }                       

        //            }
        //        }

        //        return ConversaoValores;
        //    }

        //    catch (Exception exp)
        //    {
        //        return exp.ToString();
        //    }
        //}
    }
}
