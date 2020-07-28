using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz04
{
    class Firearm
    {
        public static void fire(string gun)
        {
            switch(gun)
            {
                case "Shotgun":
                    Console.WriteLine($"I am a shotgun and I go Boom.");
                    break;
                case "Rifle":
                    Console.WriteLine($"I am a Rifle and I go Bam.");
                    break;
                case "Pistol":
                    Console.WriteLine($"I am a Pistol and I go Pop.");
                    break;
                default:
                    Console.WriteLine($"Wrong gun.");
                    break;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp quiz 4.");
            Firearm Shotgun = new Firearm();
            Firearm.fire("Shotgun");
            Firearm Rifle = new Firearm();
            Firearm.fire("Rifle");
            Firearm Pistol = new Firearm();
            Firearm.fire("Pistol");
        }
    }
}
