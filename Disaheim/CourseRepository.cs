using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        Utility utility = new Utility();
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Name == name)
                {
                    return courses[i];
                }


            }
            return null;
        }
        public double GetTotalValue()
        {
            double total = 0;

            for (int i = 0; i < courses.Count; i++)
            {
               

                if (utility.GetValueOfCourse(courses[i]) > 0)
                {
                    total = total + utility.GetValueOfCourse(courses[i]);
                }
            }
            return total;
        }


    }
}
