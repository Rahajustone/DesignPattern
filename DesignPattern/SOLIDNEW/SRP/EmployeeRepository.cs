using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLIDNEW.SRP
{
    internal class EmployeeRepository
    {
        public EmployeeRepository()
        {
        }

        public void GetAllEmployee()
        {
            // functionality goes here
            Console.WriteLine("GetAllEmployee");
        }

        public void Insert(Object employeeObject)
        {
            // functionality goes here
            Console.WriteLine("Add employee");
        }

        public void Delete(Object employeeObject)
        {
            Console.WriteLine("Delete an employee");
        }

        public void Update(Object employeeObject)
        {
            Console.WriteLine("Update Employee");
        }


        // This will break the Single Responsiblity Principle 
        public void Export(string filePath)
        {
            Console.WriteLine("Export the file path");
        }
    }

    class Export 
    {
        public void ExportEmployee(string filePath)
        {
            Console.WriteLine("Export the file path");
        }

    }
}
