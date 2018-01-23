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
            get { return elevator; }
            set
            {

                if (value <= 6 && value >= 1)
                {
                    value = elevator;
                }
            }
        }
    }
}
