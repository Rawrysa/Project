using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Call
    {
        private string call_date;
        public string Call_Date { get; set; }
        private string call_duration;
        public string Call_Duration { get; set; }
        private string client_phonenumber;
        public string Client_Phonenumber { get; set; }
        private string client_problem;
        public string Client_Problem { get; set; }
        private int client_id;
        public int Client_ID { get; set; }

        public DataTable ViewCalls()
        {
            return new DataHandler().ViewCalls();
        }

        public int NewCall()
        {
            return new DataHandler().NewCall(Call_Date,Call_Duration,Client_Phonenumber,Client_Problem,Client_ID);
        }
    }
}
