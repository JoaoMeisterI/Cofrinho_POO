using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofrinho
{
    abstract class Moeda
    {
        public string Tipo;
        public double Valor { get; set; }
        protected Moeda(double valor)
        {
            Valor = valor;
            Tipo = "";
        }
        //
        public virtual void Info()
        {
            Console.Write($"Tipo: Moeda --- Valor: {Valor} ");
        }
        //
        public virtual double Converter()
        {
            Console.WriteLine($"Valor ainda não tem um tipo para ser convertido");
            return Valor;
        }
    }
}
