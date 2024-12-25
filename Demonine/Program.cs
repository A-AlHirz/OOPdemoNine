//object class
#region Demo
using Demonine.Models;

Demo d1 = new Demo();
Console.WriteLine("Enter your name: ");
d1.SetName(Console.ReadLine());

Console.WriteLine("Welcome " + d1.GetName());
#endregion

#region VaildEmail

Employee emp = new Employee();
Console.WriteLine("Enter Email Address: ");
emp.Emailaddress = Console.ReadLine();

#endregion

#region Employee
//object employee class
Console.WriteLine("Enter number of employees: ");
int count=count=Convert.ToInt32(Console.ReadLine());
Employee emp = new Employee();

for (int i = 1; i <= count; i++)
{
    Console.WriteLine("Enter Employee ID: " + i);
    int EmployeeNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Employee Name: " + i);
    string EmployeeName = Console.ReadLine();

    Console.WriteLine("Enter Employee Email: " + i);
    string EmailAddress = Console.ReadLine();

    Console.WriteLine("Enter Employee Age: " + i);
    int EmployeeAge = Convert.ToInt32(Console.ReadLine());

    //Add New Employee
   emp= new Employee { Id = EmployeeNumber, Name = EmployeeName, Email = EmailAddress, Age = EmployeeAge };

    emp.AddEmployee(emp);

}
Console.WriteLine("Employee Id  Employee Name  Email  Age ");
emp.GetEmployess();

#endregion