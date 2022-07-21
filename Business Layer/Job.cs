using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Job
    {
        private int job_id;
        public int Job_ID { get; set; }
        private int service_id;
        public int Service_ID { get; set; }
        private int client_id;
        public int Client_ID { get; set; }
        private int technician_id;
        public int Technician_ID { get; set; }
        private string priority;
        public string Priority { get; set; }


        public DataTable ViewJobs()
        {
            return new DataHandler().ViewJobs();
        }

        public int NewJob()
        {
            return new DataHandler().NewJob(Priority,Technician_ID,Client_ID,Service_ID);
        }

        public void CloseJob()
        {
            new DataHandler().CloseJob(Job_ID);
        }

        public DataTable TrackJob()
        {
            return new DataHandler().TrackJob(Job_ID);
        }

        public void EscalateJob()
        {
            new DataHandler().EscalateJob(Job_ID,Priority);
        }

        public void ReassignJob()
        {
            new DataHandler().ReassignJob(Job_ID,Technician_ID);
        }
    }
}
