using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Tank
    {
        private string name, type;
        private int crewcount;
        private float speed, speedmax;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int CrewCount
        {
            get { return crewcount; }
            set
            {
                if (value <= 6 && value >= 2)
                {
                    crewcount = value;
                }
                else crewcount = 0;
            }
        }
        public float Speed
        {
            get { return speed; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    speed = value;
                }


            }
        }
        public float SpeedMax
        {
            get
            {
                return speedmax;
            }
            set { speedmax = 100; }
        }

        public float AccelerateTo()
        {
            Console.Write("Accelerate to: ");
            Speed = float.Parse(Console.ReadLine());

            return Speed;
        }
        public float SlowTo()
        {
            
            Console.Write("Slow to: ");
            Speed = float.Parse(Console.ReadLine());

            return Speed;
        }
        public void PrintData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Crewcount: " + CrewCount);
            Console.WriteLine("Speed: " + Speed);
        }
    }
}
