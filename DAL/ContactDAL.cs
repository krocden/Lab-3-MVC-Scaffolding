using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ContactDAL
    {
        public static int LastId = 0;

        public static List<Contact> contactList = new List<Contact>()
        {
            new Contact(){Id = 1,FirstName = "TEST",LastName = "TEST",MobilePhoneNum = "TEST",HomePhoneNum = "TEST",
                BusinessPhoneNum = "TEST",Address = "TEST", Note = "TEST1",Active= true}
        };
        
    }
}
