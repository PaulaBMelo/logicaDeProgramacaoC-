using System;

namespace SomaEMedia 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            console.WriteLine("Quantos números você deseja digitar?")
            int quantidadeDeValores = int.Parse(console.ReadLine());

            var listaDeValores = coletarValores(quantidadeDeValores);

            console.WriteLine($"A soma dos valores é de {CalcularSoma(listaDeValores)}");
            console.WriteLine($"A média dos valores é de {CalcularMedia(listaDeValores)}");
        }

        static List<decimal> coletarValores(int quantidadeValores)
        {
            List<decimal> listaDeValores = new List<decimal> (quantidadeValores);

            for (i = 0; i < quantidadeValores; i++) {
                console.WriteLine($"Digite o valor {i+1}");
                listaDeValores.Add(decimal.Parse(console.ReadLine()));
            }
            return listaDeValores;
        }

        static decimal CalcularSoma (List<decimal> listaDeValores) 
        {
            decimal valorTotal = 0;

            foreach (decimal valor in listaDeValores)
            {
                valorTotal += valor;
            }

            return valorTotal;
        }

        static decimal CalcularMedia (List<decimal> listaDeValores) 
        {
            decimal valorTotal = 0;
            decimal media = 0;

            foreach (decimal valor in listaDeValores)
            {
                valorTotal += valor;
                media = valorTotal / listaDeValores.Count;
            }

            return media;
        }
    }

}
