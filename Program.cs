using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            foodType ovo = new foodType("Jagoda",4, 6, 4);
            Console.WriteLine(ovo.ToString());

            Console.ReadKey();
        }
        

    }
}
