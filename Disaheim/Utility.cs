using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;
using System.Reflection.Emit;

namespace Disaheim
{
    public class Utility
    {   
        int fullhours = 0;
        public double LowQualityValue = 12.5;
        public double MediumQualityValue = 20.0;
        public double HighQualityValue = 27.5;
       

        /*
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
        }*/

        double price = 875.00;       
        public double GetValueOfCourse(Course course)
        {
            double value;
            if (course.DurationInMinutes <= 0)
            {
                value = 0;
                
            }

            fullhours = course.DurationInMinutes / 60;
            int remainingMinutes = course.DurationInMinutes % 60;

            int totalHours = fullhours + (remainingMinutes > 0 ? 1 : 0);
            value = totalHours * price;
            return value;
        }

        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            
                if (merchandise is Book book)
                {
                    return book.Price;
                }
           
                else if (merchandise is Amulet amulet)
                {
                    switch (amulet.Quality)
                {
                    case Level.low:
                        return LowQualityValue;
                    case Level.medium:
                        return MediumQualityValue;
                    case Level.high:
                        return HighQualityValue;
                     default:
                        return 0;
                        

                }

                             }
        return 0;
        }
    }

}
