using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    class Logins
    {
        public string username { get; set; }
        public string password { get; set; }

        static List<object> myusers = new List<object>();

        public void Populate()
        {
            Logins user1 = new Logins(); user1.username = "test"; user1.password = "password";
            Logins user2 = new Logins(); user2.username = "admin"; user2.password = "password";

            myusers.Add(user1);
            myusers.Add(user2);
        }

        public bool ValidateUser()
        {
            bool found = false;

            foreach (var item in myusers)
            {
                if (item.GetType().GetProperty("username").GetValue(item,null).ToString() == username && item.GetType().GetProperty("password").GetValue(item,null).ToString() == password)
                {
                    found = true;
                }
            }

            return found;
        }
    }
}
