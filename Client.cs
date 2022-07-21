using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Client 
    {
        private int client_id;
        public int Client_ID { get; set; }
        private string name;
        public  string Name { get; set; }
        private string surname;
        public string Surname { get; set; }
        private int contract_id;
        public int Contract_ID { get; set; }
        private string address;
        public string Address { get; set; }
        private string phonenumber;
        public string Phonenumber { get; set; }
        private string client_type;
        public string Client_Type { get; set; }

        public DataTable ViewClients()
        {
            return new DataHandler().ViewClients();
        }

        public int AddClient()
        {
            return new DataHandler().AddClient(Name,Surname,Phonenumber,Address,Client_Type,Contract_ID);
        }

        public DataTable SearchClient()
        {
            return new DataHandler().SearchClient(Client_ID);
        }

        public void UpdateTechnician()
        {
            new DataHandler().UpdateClient(Client_ID,Name, Surname, Phonenumber, Address, Client_Type,Contract_ID);
        }

        public DataTable ClientAgreement()
        {
            return new DataHandler().ClientAgreement(Client_ID);
        }

    }
}
