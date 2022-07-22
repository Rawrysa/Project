using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class Service
    {
        public DataTable ViewServices()
        {
            return new DataHandler().ViewServices();
        }
    }
}
