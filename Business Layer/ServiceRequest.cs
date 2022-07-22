using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class ServiceRequest
    {
        private int request_id;
        public int Request_ID { get; set; }
        private int service_id;
        public int Service_ID { get; set; }
        private int client_id;
        public int Client_ID { get; set; }

        public DataTable ViewRequest()
        {
            return new DataHandler().ViewRequests();
        }

        public int NewRequest()
        {
            return new DataHandler().NewRequest(Client_ID,Service_ID);
        }

        public void RemoveRequest()
        {
            new DataHandler().RemoveRequest(Request_ID);
        }
    }
}
