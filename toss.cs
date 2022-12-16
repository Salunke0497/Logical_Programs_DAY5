using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPograms
{
    internal class toss
    {
        public static void main()
        {
            Console.WriteLine("Press ENTER for TOSS");
            Console.ReadLine();
            Random random = new Random();
            int x = random.Next(2);
            if(x == 0)
            {
                Console.WriteLine("head");
            }else
            {
                Console.WriteLine("tail");
            }
        }
    }
}
