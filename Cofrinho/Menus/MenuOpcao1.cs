using System;
using System.Collections.Generic;
using System.Threading;
using Cofrinho.Cofres;
//
namespace Cofrinho.Menus
{
    internal class MenuOpcao1 : Menu
    {
        public override void MostrarMenu(Cofre cofrinho)
        {
            string titulo = "OPÇÃO 1 - ADICIONAR MOEDAS - ";
            MostraBemVindo(titulo);
            Thread.Sleep(1000);
            List<string> opcoes = new List<string> { "1", "2", "3" };
            Console.WriteLine("Qual tipo de moeda você quer adicionar ?");
            Console.WriteLine("1 - EURO  (€) ");
            Console.WriteLine("2 - DOLAR ($) ");
            Console.WriteLine("3 - REAL (R$) ");
            Console.WriteLine("Resposta: \n");
            string tipoMoeda = Console.ReadLine();
            if (!opcoes.Contains(tipoMoeda))
            {
                Console.WriteLine($"A opção {tipoMoeda} não existe dentro das opções");
            }
            else
            {
                Console.WriteLine("Qual o valor que você quer depositar ?");
                Console.WriteLine("Resposta :  \n");
                try
                {
                    double valorDepositado = double.Parse(Console.ReadLine());
                    switch (tipoMoeda)
                    {
                        case "1":
                            Moeda euro = new Euro(valorDepositado);
                            cofrinho.AdicionarMoeda(euro);
                            Console.WriteLine($"Moeda = {euro.Valor} € , Adicionado com sucesso\n");
                            break;
                        case "2":
                            Moeda dolar = new Dolar(valorDepositado);
                            cofrinho.AdicionarMoeda(dolar);
                            Console.WriteLine($"Moeda = {dolar.Valor} $ , Adicionado com sucesso\n");
                            break;
                        case "3":
                            Moeda real = new Real(valorDepositado);
                            cofrinho.AdicionarMoeda(real);
                            Console.WriteLine($"Moeda = {real.Valor} R$ , Adicionado com sucesso\n");
                            break;
                        default:
                            Console.WriteLine("Não foi possível adicionar a moeda");
                            break;
                    }
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor digitado não é numérico");
                }
            }
        }
    }
}
