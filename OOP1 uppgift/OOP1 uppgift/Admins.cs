using OOP1uppgift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1uppgift
{
     class Admin : Users
    {

        public Admin(string username, string password):base(username, password)
        {
           
            
          var arrAdmin = new Admin[]
          {
            new Admin("Simon","lösen")
          };
          
        }

    }
}
