using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll_15_01
{
    class Program
    {
        static void Main(string[] args)
        {//programm kuhu saab sisestada N+1 erinevat sõna. Kui kasutaja sisetab erimärgi -1 siis programm 
         //lõpetab kasutajalt uute sõnade küsimise. Seejärel kuvab kasutajale komadega eraldatuna kõik 
         //sisestatud sõnad ning valib nendest välja ühe suvalise.
            var sõnad = new List<string>();
            while (true)
            {
                Console.WriteLine("Sisesta sõna, väljumiseks -1.");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                { Console.WriteLine("Viga sisestamisel."); }
                if (input == "-1")
                {
                    Console.WriteLine("väljun"); break;
                    
                }
                sõnad.Add(input);
                if (input == " ")
                    sõnad.Remove(input);
                else if (input == "")
                    sõnad.Remove(input);
            }
            Console.WriteLine(string.Join(", ", sõnad));
            var randomIndex = new Random().Next(0, sõnad.Count -1);
            Console.WriteLine("Mina valin neist ühe juhusliku: " );
            Console.WriteLine(sõnad [randomIndex]);
            Console.WriteLine("Press any key ");
            Console.ReadLine();
        }
    }
}
