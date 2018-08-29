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
            List<int> numOne = new List<int>() { 1, 2, 3, 4 };
            List<int> numTwo = new List<int>()
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            
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