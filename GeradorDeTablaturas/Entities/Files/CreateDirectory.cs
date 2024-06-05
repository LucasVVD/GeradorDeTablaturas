using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTablaturas.Entities.Files
{
    internal class CreateDirectory
    {
        static string DefaultFolderName { get; set; } = "tablature";
        static string MyDocumentsPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static void CreateDefaultFolder()
        {
            string fullPath = Path.Combine(MyDocumentsPath, FirstLetterToUpperCase(DefaultFolderName));
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }
            else
            {
                Console.WriteLine("Pasta ja existente");
            }
        }

        static string FirstLetterToUpperCase(string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
        }
    }
}
