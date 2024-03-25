using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofrinho.Cofres;

namespace Cofrinho
{
    abstract class Menu
    {
        public virtual void MostrarMenu(Cofre cofrinho)
        {
            Console.WriteLine("Menu Principal");
        }
        public static string RetornaOpcao()
        {
            try
            {
                string opcao;
                Console.WriteLine("Qual opção você deseja realizar ? \n");
                Console.WriteLine("1 - Adicionar Moedas ");
                Console.WriteLine("2 - Remover Moedas ");
                Console.WriteLine("3 - Listar Total de Moedas ");
                Console.WriteLine("4 - Calcular Total de Moedas no cofre (Em reais)");
                Console.WriteLine("5 - Sair do Programa Cofrinho $$ \n");
                Console.WriteLine("Resposta: ");
                opcao = Console.ReadLine();
                //
                //
                return opcao;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "";
            }
        }
        public static void MostraBemVindo(string titulo)
        {
            int quantidadeTitulo = titulo.Length;
            string quantidadeAsterisco = new string('*', quantidadeTitulo);
            Console.WriteLine(quantidadeAsterisco);
            Console.WriteLine(titulo);
            Console.WriteLine(quantidadeAsterisco + "\n");
        }
    }
}
