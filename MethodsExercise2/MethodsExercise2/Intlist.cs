
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
{
    class Intlist
    {
        public Intlist()
        {

            Items = new List<Item>();
            //first int
            List<int> numOne = new List<int>() { 5 };
            //second int
            List<int> numTwo = new List<int>() { 8 };

            foreach (int num in numOne)
            {
                foreach (int num2 in numTwo)
                {


                    Item item = new Item();
                    item.numOne = num;
                    item.numTwo = num2;
                    Items.Add(item);
                }
            }
        }
        public List<Item> Cards { get; set; }
        public List<Item> Items { get; private set; }
    }

}
