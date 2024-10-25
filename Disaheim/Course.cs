using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        int fullhours = 0;
        public static double CourseHourValue = 875.00;
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }


        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }
        public Course(string name)
        {
            Name = name;

        }
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }
        public  double GetValue()
        {
            double value;
            if (DurationInMinutes <= 0)
            {
                value = 0;

            }

            fullhours = DurationInMinutes / 60;
            int remainingMinutes = DurationInMinutes % 60;

            int totalHours = fullhours + (remainingMinutes > 0 ? 1 : 0);
            value = totalHours * CourseHourValue;
            return value;
        }
    }
}
