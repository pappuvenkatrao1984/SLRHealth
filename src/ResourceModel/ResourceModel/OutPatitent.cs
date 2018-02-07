using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceModel
{
    public class OutPatitentDetails
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
    }

    public class OutPatient : OutPatitentDetails
    {
        public int OpNumber { get; set; }
    }
}
