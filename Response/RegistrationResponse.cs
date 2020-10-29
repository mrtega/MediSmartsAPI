using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediSmartsAPI.Response
{
    public class RegistrationResponse
    {
        public Guid Id { get; set; }
        public long Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
    }
}
