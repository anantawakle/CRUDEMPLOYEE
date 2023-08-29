using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEMPLOYEE
{
    public  class Employee
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public double Salary { set; get; }
        public string Position { set; get; }
        public string Company { set; get; }

    }

    public class EmployeeCRUD
    {
        private List<Employee> employeelist;
        public EmployeeCRUD()
        {
            employeelist = new List<Employee>()
            {
                new Employee{Id=1,Name="Ananta",Salary=58000.00,Position="Jr.Softwaredevloper",Company="Vipro"},
                new Employee{Id=2,Name="Akshay",Salary=68000.00,Position="sr.Softwaredevloper",Company="Vi"}
            };
        }
        public List<Employee> GetEmployees()
        {
            return employeelist;
        }

        // get single employee by id//
        public Employee GetEmployeeById(int id)
        {
            // search id in the collection//
            Employee employee = new Employee();
            foreach(Employee e in employeelist)
            {
                if(e.Id==id)// match id in the collection
                {
                    employee = e;
                    break;
                }
            }
            return employee;
        }

        // Addd new Employee//
        public void AddEmployee(Employee e)
        {
            employeelist.Add(e);
        }
        public void UpdateEmployee(Employee e) 
        {
            foreach(Employee e2 in employeelist)
            {
                // e2 cantain old employee data//
                if(e2.Id==e.Id) 
                {
                    e2.Name = e.Name;
                    e2.Salary = e.Salary;
                    e2.Position = e.Position;
                    e2.Company = e.Company;
                    break;
                }
            }
        }
        // remove employee//
        public void DeleteEmployee(int id) 
        {
            foreach (Employee item in employeelist)
            {
                if(item.Id==id) 
                {
                    employeelist.Remove(item);
                    break;
                }
            }
        }

    }
}
