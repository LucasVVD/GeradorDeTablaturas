namespace GeradorDeTablaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apenas um protótipo por enquanto;

            string[] standardTuning = Console.ReadLine().Split(' ');
            for (int i = 0; i < standardTuning.Length; i++)
            {
                Console.Write($"\n{standardTuning[i]}|");
                for (int j = 0; j < 100; j++)
                {
                    Console.Write("-");
                }
                Console.Write("|");
            }
            Console.WriteLine();
        }
    }
}