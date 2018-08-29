using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Intlist intlist = new Intlist();
            

            foreach (Item item in intlist.Items)
            {
                Console.WriteLine("Enter an integar.");
                int myInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(item.numOne * item.numTwo + myInt);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public static Intlist Shuffle(Intlist intlist)
        {
            List<Item> TempList = new List<Item>();
            Random random = new Random();
            while (intlist.Items.Count > 0)
            {
                int randomIndex = random.Next(0, intlist.Items.Count);
                TempList.Add(intlist.Cards[randomIndex]);
                intlist.Items.RemoveAt(randomIndex);
            }
            intlist.Cards = TempList;
            return intlist;
        }
    }
}