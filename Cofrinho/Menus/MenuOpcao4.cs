using System;
using System.Threading;
using Cofrinho.Cofres;

namespace Cofrinho.Menus
{
    internal class MenuOpcao4 : Menu
    {
        public override void MostrarMenu(Cofre cofrinho)
        {
            string titulo = "OPÇÃO 4 - TOTAL VALOR DAS MOEDAS CONVERTIDAS EM REAIS - ";
            MostraBemVindo(titulo);
            double total = cofrinho.TotalConversaoReais();
            Console.WriteLine($"O total do valor em Reais = {total} R$ \n");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}
