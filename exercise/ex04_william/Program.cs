using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_william
{
    class FarmAnimal
    {
        
        static string animalName;
        static string animalType;
        static string products;
        public FarmAnimal()
        {
            animalName = "";
        }
        public FarmAnimal(string type, string name)
        {
            animalName = name;
            animalType = type;
            switch(type)
            {
                case "pig":
                    products = "pork chops and barbeque ribs";
                    break;
                case "horse":
                    products = "horse power to your wagon";
                    break;
                case "chicken":
                    products = "buffalo wild wings and chiken nuggets";
                    break;
                case "cow":
                    products = "smoke briskets and jerkies";
                    break;
            }
        }
        public void speaks()
        {
            switch (animalType)
            {
                case "pig":
                    Console.WriteLine($"{animalName}: four legs good! two legs bad!!");
                    break;
                case "horse":
                    Console.WriteLine($"{animalName}: I am an American Thoroughbred race horse and a winner of the American Triple Crown!");
                    break;
                case "chicken":
                    Console.WriteLine($"{animalName}: Buck cluck, Buck cluck!!!");
                    break;
                case "cow":
                    Console.WriteLine($"{animalName}: I need more beer!");
                    break;
            }
        }
        public void eats()
        {
            switch (animalType)
            {
                case "pig":
                    Console.WriteLine($"{animalName} is a {animalType} so he/she eats corn and drinks muddy water");
                    break;
                case "horse":
                    Console.WriteLine($"{animalName} is a {animalType} so he/she eats hay and drinks water from stream");
                    break;
                case "chicken":
                    Console.WriteLine($"{animalName} is a {animalType} so he/she eats earthwarms and drinks rain water");
                    break;
                case "cow":
                    Console.WriteLine($"{animalName} is a {animalType} so he/she eats grass and drinks beer");
                    break;
            }
        }
        public void produces()
        {
            switch (animalType)
            {
                case "pig":
                    Console.WriteLine($"{animalName} is a {animalType} so he/she contributes {products}");
                    break;
                case "horse":
                    Console.WriteLine($"{animalName} is a {animalType} so he/she contributes {products}");
                    break;
                case "chicken":
                    Console.WriteLine($"{animalName} is a {animalType} so he/she contributes {products}");
                    break;
                case "cow":
                    Console.WriteLine($"{animalName} is a {animalType} so he/she contributes {products}");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            FarmAnimal Snowball = new FarmAnimal("pig", "Snowball");
            Snowball.speaks();
            Snowball.eats();
            Snowball.produces();
            Console.WriteLine("=================================================");
            FarmAnimal chickenLittle = new FarmAnimal("chicken", "Chicken Little");
            chickenLittle.speaks();
            chickenLittle.eats();
            chickenLittle.produces();
            Console.WriteLine("=================================================");
            FarmAnimal warAdmiral = new FarmAnimal("horse", "War Admiral");
            warAdmiral.speaks();
            warAdmiral.eats();
            warAdmiral.produces();
            Console.WriteLine("=================================================");
            FarmAnimal emma = new FarmAnimal("cow", "Emma");
            emma.speaks();
            emma.eats();
            emma.produces();
            Console.WriteLine("=================================================");
        }
    }
}
