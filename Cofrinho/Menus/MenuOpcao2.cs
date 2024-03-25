using System;
using System.Collections.Generic;
using System.Threading;
using Cofrinho.Cofres;

namespace Cofrinho.Menus
{
    internal class MenuOpcao2 : Menu
    {
        public override void MostrarMenu(Cofre cofrinho)
        {
            string titulo = "OPÇÃO 2 - REMOVER MOEDAS - ";
            MostraBemVindo(titulo);
            Thread.Sleep(1000);
            List<int> opcoes = cofrinho.CriaListaNumeros();
            Console.WriteLine("Segue as moedas disponíveis no cofre ");
            cofrinho.ListarMoedas();
            Console.WriteLine("Digite qual moeda você quer excluir pelo índice numérico\n");
            Console.WriteLine("Resposta: \n");
            try
            {
                int resIndice;
                if (!int.TryParse(Console.ReadLine(), out resIndice))
                {
                    Console.WriteLine("Valor digitado não é numérico");
                    return;
                }

                if (!opcoes.Contains(resIndice))
                {
                    Console.WriteLine("Não existe esse índice na lista, favor revise sua resposta !");
                }
                else
                {
                    Moeda moeda = cofrinho.listaMoedas[resIndice - 1];
                    cofrinho.RemoveMoeda(moeda);
                    Console.WriteLine("Moeda removida com sucesso!");
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
