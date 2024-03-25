using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofrinho
{
    class Real : Moeda 
    {
        public Real(double valor) : base(valor)
        {
            Valor = valor;
            Tipo = "Real";
        }
        //
        public override void Info()
        {
            Console.Write($"Tipo da Moeda: {Tipo} --- Valor: {base.Valor} R$ ");
        }
        //
        public override double Converter()
        {
            return Valor;
        }
    }
}
