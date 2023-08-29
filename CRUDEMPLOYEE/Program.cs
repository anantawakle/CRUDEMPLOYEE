using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEMPLOYEE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            EmployeeCRUD crud = new EmployeeCRUD();
            do
            {
                Console.WriteLine("____________________________________");
                Console.WriteLine("1.Employee List");
                Console.WriteLine("2.Get Employee By Id");
                Console.WriteLine("3.Add Employee");
                Console.WriteLine("4.Update Employee");
                Console.WriteLine("5.Delect Employee");
                Console.WriteLine("Select your option");
                int option=Convert.ToInt32(Console.ReadLine());
               switch (option) 
               {
                    case 1:
                        List<Employee>list=crud.GetEmployees();
                        Console.WriteLine("Id\t Name\t Salary\t Position\t Company");
                        foreach (Employee employee in list)
                        {
                            Console.WriteLine($"{employee.Id} \t{employee.Name} \t{employee.Salary}\t{employee.Position}\t{employee.Company}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the employee id");
                        int id=Convert.ToInt32(Console.ReadLine());
                        Employee e=crud.GetEmployeeById(id);
                        Console.WriteLine($" Id\t Name\t Salary\t Position\t Company");
                        Console.WriteLine($"{e.Id}\t {e.Name}\t{e.Salary} {e.Position}\t{e.Company}");
                        break;
                    case 3:
                        Employee e1=new Employee();
                        Console.WriteLine("Enter the employee id");
                        e1.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the emplolyee name");
                        e1.Name=Console.ReadLine();
                        Console.WriteLine("Enter the employee salary");
                        e1.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the position of employee");
                        e1.Position=Console.ReadLine();
                        Console.WriteLine("Enter the company of employee");
                        e1.Company=Console.ReadLine();
                        crud.AddEmployee(e1);
                        Console.WriteLine("employee saved");
                        break;
                    case 4:
                        Employee e2=new Employee();
                        Console.WriteLine("Enter the emplou=yee id");
                        e2.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the employee name");
                        e2.Name=Console.ReadLine();
                        Console.WriteLine("Enter the employee salary");
                        e2.Salary=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" Enter the employee position");
                        e2.Position=Console.ReadLine();
                        Console.WriteLine("Enter the company name");
                        e2.Company=Console.ReadLine();
                        crud.UpdateEmployee(e2);
                        break;
                    case 5:
                        Console.WriteLine("Enter the employee id");
                        int id2=Convert.ToInt32(Console.ReadLine());
                        crud.DeleteEmployee(id2);
                        Console.WriteLine($" {id2} Employee delet");
                        break;





                }
                Console.WriteLine("Press 1 for continue");
                no=Convert.ToInt32(Console.ReadLine());

            }
            while (no == 1);
        }
    }
}
