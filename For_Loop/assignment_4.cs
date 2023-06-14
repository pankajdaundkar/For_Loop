using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{//Accept the number & print its table 
    internal class assignment_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i*n1);
            }
        }
    }
}
