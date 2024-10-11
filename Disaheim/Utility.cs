using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
       
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        double Price;
        public double GetValueOfAmulet(Amulet amulet)
        {
            
         
            switch (amulet.Quality)
            {
                case Level.low:
                    Price = 12.5;
                    break;

                case Level.high:
                    Price = 27.5;
                    break;

                case Level.medium:
                    Price = 20.0;
                        break;
 
            }return Price;
        }
    }

}
