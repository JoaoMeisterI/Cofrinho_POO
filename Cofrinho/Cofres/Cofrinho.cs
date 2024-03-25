using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofrinho.Cofres
{
    internal class Cofre
    {
        public List<Moeda> listaMoedas { get; set; } = new List<Moeda>();


        public void AdicionarMoeda(Moeda moeda)
        {
            try
            {
                listaMoedas.Add(moeda);
            }
            catch
            {
                Console.WriteLine("Valor digitado não corresponde com uma moeda, favor verificar \n");
            }
        }
        public void RemoveMoeda(Moeda moeda)
        {
            try
            {
                listaMoedas.Remove(moeda);
            }
            catch
            {
                Console.WriteLine("Valor digitado não corresponde com uma moeda, favor verificar \n");
            }
        }
        public void ListarMoedas()
        {
            try
            {
                int cont = 1;
                foreach (var moeda in listaMoedas)
                {
                    Console.WriteLine($"{cont} - Moeda = {moeda.Valor} Tipo = {moeda.Tipo}");
                    cont += 1;
                }
                Console.WriteLine("\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao Listar as moedas: {ex}");
            }

        }
        public List<int> CriaListaNumeros()
        {
            List<int> listaIndice = new List<int>();
            int tamanhoListaMoedas = listaMoedas.Count();
            for (int i = 0; i <= tamanhoListaMoedas; i++)
            {
                listaIndice.Add(i);
            }
            return listaIndice;
        }
        public double TotalConversaoReais()
        {
            try
            {
                double Total = 0;
                foreach (var moeda in listaMoedas)
                {
                    Total += moeda.Converter();
                }
                return Total;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }
    }
}
