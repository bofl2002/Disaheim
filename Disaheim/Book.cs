using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise 
    {
        public string ItemId;
        public string Title;
        public double Price;

        public Book (string itemId) : base(itemId)
        {
            ItemId = itemId;
            
        }
        public Book(string itemId, string title) : base(itemId)
        {
            ItemId = itemId;
            Title = title;
            
        }
        public Book(string itemId, string title, double price) : base(itemId) 
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
        public override double GetValue()
        {
            return Price;
        }
    }
    

}
