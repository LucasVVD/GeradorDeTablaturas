using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTablaturas.Entities
{
    internal class Tablature
    {
        public string[] Tuning { get; set; }
        private int Rows { get; set; }
        private int Columns { get; set; }

        public Tablature(string[] tuning, int columns)
        {
            Tuning = tuning;
            Rows = tuning.Length;
            Columns = columns;
        }

        public void GenerateTablature()
        {
            try
            {
                string[,] traces = new string[Rows, Columns];

                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        traces[i, j] = "-";
                    }
                }
                Console.WriteLine("Gerando tabalhatura...");
                ShowUpdated(traces);
                Console.WriteLine();
                Console.WriteLine("selecione uma linha e uma coluna para editar:");
                if (int.TryParse(Console.ReadLine(), out int selectedRow) && selectedRow > 0 && selectedRow <= Rows)
                {
                    if (int.TryParse(Console.ReadLine(), out int selectedColumns) && selectedColumns > 0 && selectedColumns <= Columns)
                    {
                        Console.WriteLine("Insira o texto:");
                        string text = Console.ReadLine();
                        if (selectedColumns + text.Length - 1 <= Columns)
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                traces[selectedRow - 1, selectedColumns - 1 + i] = text[i].ToString();
                            }
                        }
                        else
                        {
                            Console.WriteLine("O texto é muito longo para caber nesta coluna. Tente novamente.");
                        }

                        ShowUpdated(traces);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void ShowUpdated(string[,] traces)
        {
            for (int i = 0; i < Rows; i++)
            {
                Console.Write($"\n{Tuning[i]}|");
                for (int j = 0; j < Columns; j++)
                {
                    Task.Delay(200).Wait();
                    Console.Write(traces[i, j]);
                }
                Console.Write("|");
            }
        }
    }
}
