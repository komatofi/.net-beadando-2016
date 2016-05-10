using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    //Komáromi Kristóf GWPC55
    
    //Generikus metódus. 2 tetszőleges típusu adatot megcserél     
    class Program
    {
        static public void Swap<T>(ref T x,ref T y)
        {
            T tmp = x;
            x = y;
            y = tmp;
        }

        static void Main(string[] args)
        {



            SortedList<string, int> sorted = new SortedList<string, int>();
            sorted.Add("Peter", 1);
            sorted.Add("Balazs", 2);
            sorted.Add("Ferenc", 3);
            sorted.Add("Jakab", 4);
            sorted.Add("Daniel", 5);
            sorted.Add("Adam", 6);
            sorted.Add("Levente", 7);
            sorted.Add("Tamas", 8);
            sorted.Add("Kristof", 9);
            sorted.Add("Gergo", 10);
            sorted.Add("Akos", 11);
            sorted.Add("Zoltan", 12);
            sorted.Add("Mate", 13);
            sorted.Add("Janos", 14);
            sorted.Add("Laszlo", 15);



            int x = 15;
            int y = 14;
            Console.WriteLine("Ennyien vannak jelenleg a Sorted List-ben:{0}",x);
            Console.WriteLine(" ");


            Console.WriteLine("Sorted List tartalma: ");
            foreach (var pair in sorted)
            {
                Console.WriteLine("{0},{1}", pair.Key,pair.Value);
            }
            Console.WriteLine(" ");

            Console.WriteLine("a rendezett listában Gergo indexe:");
            int index1 = sorted.IndexOfKey("Gergo");
            Console.WriteLine("Gergo indexe (key) = " + index1);
            Console.WriteLine(" ");

            int index2 = sorted.IndexOfValue(6);
            Console.WriteLine("A megírt lista 6odik elemenek indexe a rendezett listaban(value) = " + index2);
            Console.WriteLine(" ");



            Console.WriteLine("Megnézi, van-e Agoston a sortedListbe,mivel nincs így false-sal tér vissza");
            bool contains1 = sorted.ContainsKey("Agoston");
            Console.WriteLine("contains Agoston = " + contains1);
            Console.WriteLine(" ");

            Console.WriteLine("SortedListben Janos value-jának sorszáma:");
            int value;
            if (sorted.TryGetValue("Janos", out value))
            {
                Console.WriteLine("Janos value = " + value);
                Console.WriteLine(" ");
            }

            Console.WriteLine("Levente torlesre kerul a listabol.");
            sorted.Remove("Levente");
            Console.WriteLine(" ");

            //az x=15 helyére beteszi az y=14 értékét, ezután az X-et iratja ki.
            Program.Swap<int>(ref x, ref y);
            Console.WriteLine("levente nélkül ennyien vannak a Sorted Listben: {0}",x);
            Console.WriteLine(" ");

            Console.WriteLine("levente nelkuli lista:");
            foreach (var pair in sorted)
            {
                Console.WriteLine(pair);
            }






            Console.ReadLine();
        }
    }
}
