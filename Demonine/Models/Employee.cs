using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demonine.Models;

namespace Demonine.Models
{
    public class Employee
    {
        private string emailAddress;
        //Prop
        public string Emailaddress
        {
            get { return emailAddress; }
            set
            {
                if (value.Contains("@"))
                {
                    emailAddress = value;
                }
                else
                {
                    Console.WriteLine("Invalid Email Address");
                }
            }
        }
        public void GetEmailAddres()
        {
            Console.WriteLine("My Email is " + emailAddress);
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }

        //Object List of Employee
        List<Employee> employees = new List<Employee>();


        //AddEmployee
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        //GetEmployee
        public void GetEmployess()
        {
            foreach(var emp in employees)
            {
                Console.WriteLine("ID: "+emp.Id+"\n Name: "+emp.Name+"\n Email: "+emp.Email+" \n Age: "+emp.Age);
            }
        }



    }
}

#region anotherMethod
//public void AddEmployee(int id , string name, string email, int age)
//{

//employees.Add(new Employee { Id=id, Name = name, Email = email, Age = age});

//}

#endregion
