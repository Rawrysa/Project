using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    class Employee
    {
        private string name;
        public string Name { get; set; }
        private string surname;
        public string Surname { get; set; }
        private string phonenumber;
        public string PhoneNumber { get; set; }
        private int branch;
        public int Branch { get; set; }
        private int employee_id;
        public int Employee_ID { get; set; }

        public int AddEmployee()
        {
            return new DataHandler().AddEmployee(Employee_ID, Branch);
        }

        public void DeleteEmployee()
        {
            new DataHandler().DeleteEmployee(Employee_ID);
        }
    }

}
