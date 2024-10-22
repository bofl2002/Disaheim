using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace UtilityLib
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

        double price;       
        public double GetValueOfCourse(Course course)
        {
            if (course.DurationInMinutes <= 0)
            {
                throw new ArgumentException("Course duration cannot be negative");
            }

            int fullhours = course.DurationInMinutes / 60;
            int remainingMinutes = course.DurationInMinutes % 60;

            int totalHours = fullhours + (remainingMinutes > 0 ? 1 : 0);
            double value = totalHours * price;
            return value;
        }
    }

}
