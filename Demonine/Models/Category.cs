using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonine.Models
{
    public class Category : Course
    {
        public int CategoryId { get; set; }

        public override void CourseDetails()
        {
            Console.WriteLine("Category Class: Developement" + " , C# Course ");
        }

    }
}
