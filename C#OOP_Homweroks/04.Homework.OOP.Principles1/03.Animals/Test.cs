using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Test
    {
        static void Main(string[] args)
        {
            var frog1 = new Frog(25, "jaba1", true);
            var frog2 = new Frog(20, "jaba2", false);
            var frog3 = new Frog(25, "jaba3", true);
            var frog4 = new Frog(20, "jaba4", false);
            var allFrogs=new Frog[]{frog1,frog2,frog3,frog4};

            var dog1 = new Dog(30, "kuche1", true);
            var dog2 = new Dog(30, "kuche2", true);
            var dog3 = new Dog(30, "kuche3", true);
            var allDogs=new Dog[]{dog1,dog2,dog3};

            var randomCat1 = new Cat(5, "random kotka1", false);
            var randomCat2 = new Cat(13, "random kotka2", false);
            var randomCat3 = new Cat(5, "random kotka3",true);
            var allCats=new Cat[]{randomCat1,randomCat2,randomCat3};

            var femaleCat1 = new Kitten(5, "jenska kotka1");
            var femaleCat2 = new Kitten(43, "jenska kotka2");
            var femaleCat3 = new Kitten(56, "jenska kotka3");
            var allFemaleCats=new Kitten[]{femaleCat1,femaleCat2,femaleCat3};

            var maleCat1 = new TomCat(5, "mujka kotka1");
            var maleCat2 = new TomCat(6, "mujka kotka2");
            var maleCat3 = new TomCat(200, "mujka kotka3");
            var allMaleCats=new TomCat[]{maleCat1,maleCat2,maleCat3};

            var frogs = allFrogs.Average(x => x.Age);
            Console.WriteLine("The avergae age of frogs is: {0}",frogs);

            var dogs = allDogs.Average(x => x.Age);
            Console.WriteLine("The avergae age of dogs is: {0}", dogs);

            var cats = allCats.Average(x => x.Age);
            Console.WriteLine("The avergae age of  random cats is: {0}", cats);

            var femaleCats = allFemaleCats.Average(x => x.Age);
            Console.WriteLine("The avergae age of female cats(Kittens) is: {0}", femaleCats);

            var maleCats = allMaleCats.Average(x => x.Age);
            Console.WriteLine("The avergae age of male cats(Tomcats) is: {0}", maleCats);
            Console.WriteLine(randomCat1.MakeSound());
        }
    }
}
