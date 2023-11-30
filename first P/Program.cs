using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_P
{
    internal class Program
    {
        public void Addition()
        {
            int a, b, c;
            a=10; b=10; c = a + b;
            Console.WriteLine("Addition=" + c);

        }



        static void Main(string[] args)
        {
            Program p=new Program();
            p.Addition();
            Console.ReadLine();
        }
    }
}
