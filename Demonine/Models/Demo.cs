using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonine.Models
{
    public class Demo
    {
        private string name;
        
        //Function SetName
        public void SetName(string Name)
        {
            name = Name;
        }


        //GetName
        public string GetName()
        {
            return name;
        }

    }
}
