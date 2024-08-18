using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_DataAccess.PatientClasses
{
    public class PatientPhoneNumber
    {
        public int Id { get; set; }
        public Guid PhoneNumberCode { get; set; } = Guid.NewGuid();
        public int PatientID { get; set; }

        public string CountryCode { get; set; } = string.Empty;
        public string AreaCode { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Extension { get; set; } = string.Empty;
        public string PhoneType { get; set; } = string.Empty;
    }
}
