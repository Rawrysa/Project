using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    class Validator
    {
        public bool NotNull(object thisobject)
        {
            bool notnull = true;

            foreach (var item in thisobject.GetType().GetProperties())
            {
                if (item.GetValue(item, null).ToString() == "")
                {
                    notnull = false;
                }
            }

            return notnull;
        }
    }
}
