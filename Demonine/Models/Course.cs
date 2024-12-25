using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonine.Models
{
    public class Course
    {
        //Overload : Same name, Dif par or Datatype
       
        public int Id { get; set; }
        public string CourseName { get; set; }

        public virtual void CourseDetails()
        {
            Console.WriteLine("Course Class: Default Value");
        }
    }
}
