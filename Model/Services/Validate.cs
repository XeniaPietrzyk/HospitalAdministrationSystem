using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class Validate
    {
        public int GenerateId(Context context)
        {
            var id = context.Physicians.Count + context.Admins.Count + context.Nurses.Count + 1;
            return id;
        }

        public bool UserNameKeyValidate(string userName, Context context)
        {
            if (context.LoginPassword.ContainsKey(userName))
            {
                return false;
            }
            return true;
        }
    }
}
