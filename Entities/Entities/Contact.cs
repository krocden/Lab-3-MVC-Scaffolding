using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contact
    {
        // Get & Set for Contact Class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhoneNum { get; set; }
        public string HomePhoneNum { get; set; }
        public string BusinessPhoneNum { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public Boolean Active { get; set; }
    }
}
