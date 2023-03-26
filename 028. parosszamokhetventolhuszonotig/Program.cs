using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028.parosszamokhetventolhuszonotig
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 70; i > 24; i--)
            {
                if (i % 2 == 0)

                    Console.WriteLine(i);
            }

            Console.ReadKey();

        }

    }
}
