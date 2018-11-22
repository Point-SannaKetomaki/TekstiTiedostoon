using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekstiTiedostoon_SKe_Pv02Harj02
{
    class Program
    {
        static void Main(string[] args)
        {
            string polku = @"C:\Users\OWNER\Google Drive\PointCollege\Kurssi_05_Ohjelmoinnin jatkokurssi\Tekstiharjoitus.txt";
            string nimi = "";

            if (File.Exists(polku))
            {
                string aiempiNimi = File.ReadAllText(polku);
                Console.WriteLine($"Aiemmin kirjoitettu nimi on {aiempiNimi}");
            }
            

            Console.Write("Anna nimi: ");
            nimi = Console.ReadLine();
            File.WriteAllText(polku, nimi);
            Console.WriteLine("Nimi on tallennettu muistiin.");

            
            
            Console.ReadLine();

        }
    }
}
