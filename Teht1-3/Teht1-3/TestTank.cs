using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            Console.WriteLine("TestTank");
            Tank test = new Tank();

            test.Name = "TestTank 9000";
            test.Type = "Panther";

            Console.Write("Insert CrewCount: ");
            test.CrewCount = int.Parse(Console.ReadLine());
            test.PrintData();

            test.AccelerateTo();
            test.SlowTo();
            
            test.PrintData();
            
        }
    }
}
