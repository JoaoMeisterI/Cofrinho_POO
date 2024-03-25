using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofrinho
{
    class Dolar : Moeda
    {
        public Dolar(double valor) : base(valor)
        {
            Tipo = "Dolar";
        }
        //
        public override void Info()
        {
            Console.Write($"Tipo da Moeda: {Tipo} --- Valor: {base.Valor} $ ");
        }
        //
        public override double Converter()
        {
            try
            {
                double valorCotacaoEuro = 5;
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
