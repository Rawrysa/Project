using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project.BusinessLayer
{
    class Technician : Employee
    {
        private string job_description;
        public string Job_Description { get; set; }
        private string availability;
        public string Availability { get; set; }

        public DataTable ViewTechnicians()
        {
            return new DataHandler().ViewTechnicians();
        }

        public int AddTechnician()
        {
            return new DataHandler().AddTechnician(Name,Surname,PhoneNumber,Job_Description,Employee_ID);
        }

        public DataTable SearchTechnician()
        {
            return new DataHandler().SearchTechnician(Employee_ID);
        }

        public void UpdateTechnician()
        {
            new DataHandler().UpdateTechnician(Name,Surname,PhoneNumber,Job_Description,Employee_ID);
        }

        public void TechnicianAvailability()
        {
            new DataHandler().TechnicianAvailability(Employee_ID,Availability);
        }
    }
}
