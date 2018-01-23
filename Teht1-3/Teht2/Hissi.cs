/*Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin. 
 * Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja siirtämään hissi haluttuun kerrokseen 
 * (tässä tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on). 
 * Muista, että Dynamon hissi voi olla vain kerroksissa 1-5. Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Hissi
    {
        public int elevator;
        public int Elevator
        {
            get;
            set;
        }

        public int FloorNumber()
        {
            int number;
            Console.Write("Enter floor number: ");
            int.TryParse(Console.ReadLine(), out number);
            if (number <= 5 && number >= 1)
            {
                elevator = number;
                Console.WriteLine("Elevator is now on floor number: " + elevator);
                
            }
            else
            {
                if (number >= 6)
                {
                    Console.WriteLine("Too big!");
                    Console.WriteLine("Elevator is now on floor number: " + elevator);
                }
                else
                {
                    if (number <= 0)
                    {
                        Console.WriteLine("Too small!");
                        Console.WriteLine("Elevator is now on floor number: " + elevator);
                    }
                    else
                    {
                    }
                }
            }
                    return Elevator;
        }
    }
}

