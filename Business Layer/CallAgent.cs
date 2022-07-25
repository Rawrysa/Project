using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class CallAgent : Employee
    {

        public DataTable ViewAgents()
        {
            return new DataHandler().ViewAgents();
        }

        public void AddTechnician()
        {
            new DataHandler().AddAgent(Name, Surname, PhoneNumber, Employee_ID);
        }

        public DataTable SearchTechnician()
        {
            return new DataHandler().SearchAgent(Employee_ID);
        }

        public void UpdateTechnician()
        {
            new DataHandler().UpdateAgent(Name, Surname, PhoneNumber, Employee_ID);
        }
    }
}
