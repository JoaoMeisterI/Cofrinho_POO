using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofrinho
{
    class Euro : Moeda
    {
        public Euro(double valor) : base(valor)
        {
            Tipo = "Euro";
        }
        //
        public override void Info()
        {
            Console.Write($"Tipo da Moeda: {Tipo} --- Valor: {base.Valor} € ");
        }
        //
        public override double Converter()
        {
            try
            {
                double valorCotacaoEuro = 5.41;
                double valorEmReal = Valor * valorCotacaoEuro;
                return valorEmReal;
            }
            catch
            {
                return 0;
            }
           
            
        }
    }
}
