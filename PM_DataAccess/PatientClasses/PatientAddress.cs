using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_DataAccess.PatientClasses
{
    public class PatientAddress
    {
        public int Id { get; set; }
        public Guid AddressCode { get; set; } = Guid.NewGuid();
        public int PatientID { get; set; }

        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
