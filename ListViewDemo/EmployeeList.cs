using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewDemo
{
    class EmployeeList
    {
        public Employee[] GetEmployees(int number)
        {
            Employee[] employees = new Employee[number];
            String[] position = { "Supervisor", "Operador", "Gerente", "Diretor" };
            Random rdn = new Random();

            for (int i = 0; i < number; i++)
            {
                var name = Guid.NewGuid().ToString().Substring(0, 10);

                var newEmployee = new Employee(
                name,
                position[rdn.Next(0, 3)],
                name + "@gmail.com"    
                );
                employees[i] = newEmployee;
            }
            return employees;
        }
    }
}