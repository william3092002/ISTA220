using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_william
{
    class Program
    {
        static void Main(string[] args)
        {
            doWork();
        }

        private static void doWork()
        {
            Archer Ashe = new Archer();
            Ashe.Mission();
            Ashe.Attack("yasuo");
            Ashe.Defend();
            Ashe.Travel();

            Console.WriteLine();

            Samurai Yasuo = new Samurai();
            Yasuo.Mission();
            Yasuo.Attack("ashe");
            Yasuo.Defend();
            Yasuo.Travel();

            Console.WriteLine();

            Bowmaster Trsitana = new Bowmaster();
            Trsitana.Mission();
            Trsitana.Attack("Yasuo");
            Trsitana.Defend();
            Trsitana.Travel();

            Console.WriteLine();

            Spearman Pantheon = new Spearman();
            Pantheon.Mission();
            Pantheon.Attack("Klad");
            Pantheon.Defend();
            Pantheon.Travel();

            Console.WriteLine();

            Calvary Klad = new Calvary();
            Klad.Mission();
            Klad.Attack("Ashe");
            Klad.Defend();
            Klad.Travel();

            Console.WriteLine();
            

        }

    }
}
