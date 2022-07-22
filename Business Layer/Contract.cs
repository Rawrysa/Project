using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class Contract : Call
    {
        private int contract_id;
        public int Contract_ID { get; set; }
        private string availability;
        public string Availability { get; set; }

        public DataTable ViewContracts()
        {
            return new DataHandler().ViewContracts();
        }

        public void ContractAvailability()
        {
            new DataHandler().ContractAvailability(Contract_ID, Availability);
        }

        public DataTable ContractPerformance()
        {
            return new DataHandler().ContractPerformance(Contract_ID);
        }
    }
}
