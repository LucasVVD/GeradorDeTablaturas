using GeradorDeTablaturas.Entities;

namespace GeradorDeTablaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apenas um protótipo por enquanto;

            Console.Write("Digite sua afinação (separado de 'espaços'): ");
            string[] tuning = Console.ReadLine().ToUpper().Split(' ');
            int tablatureLength = int.Parse(Console.ReadLine());
            Tablature tabs = new Tablature(tuning, tablatureLength);
            tabs.GenerateTablature();
        }
    }
}