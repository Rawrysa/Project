using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Service
    {
        public DataTable ViewServices()
        {
            return new DataHandler().ViewServices();
        }
    }
}
