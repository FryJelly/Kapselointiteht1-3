using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Amplifier
    {
        public int volume;
        public int Volume
        {
            get { return volume; }
            set {
                if (value <= 100 && value >= 0)
                {
                    volume = value;
                    Console.WriteLine("The volume is now at: " + volume);

                }
                else
                {
                    if (value > 100)
                    {
                        Console.WriteLine("The volume is too damn high!");
                        Console.WriteLine("The volume is now at: " + volume);
                    }
                    else
                    {
                        if (value < 0)
                        {
                            Console.WriteLine("The volume is too damn low!");
                            Console.WriteLine("The volume is now at: " + volume);
                        }
                        else
                        {
                        }
                    }
                }
            }
        }

        public int Changevolume()
        {
            int number;
            Console.Write("Enter volume (0-100): ");
            int.TryParse(Console.ReadLine(), out number);
            Volume = number;
            return Volume;
        }
    }
}
