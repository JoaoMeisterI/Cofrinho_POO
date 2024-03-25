using System;
using System.Threading;
using Cofrinho.Cofres;

namespace Cofrinho.Menus
{
    internal class MenuOpcao3 : Menu
    {
        public override void MostrarMenu(Cofre cofrinho)
        {
            string titulo = "OPÇÃO 3 - LISTAR MOEDAS - ";
            MostraBemVindo(titulo);
            Thread.Sleep(1000);
            if (cofrinho.listaMoedas.Count == 0)
            {
                Console.WriteLine("A lista de moedas está vazia");
            }
            else
            {
                cofrinho.ListarMoedas();
                Thread.Sleep(2000);
            }
        }
    }
}
