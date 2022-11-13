using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserConstants
    {
        public static List<UserModel> Users = new()
            {
                    new UserModel()
                    { 
                        Username="abhishek",
                        Password="abhishek_admin",
                        Role="Admin"
                    }
            };
    }
}
