using PM_DataAccess.StagesClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_DataAccess.PatientClasses
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        // Patient's unique code
        public string PatientCode { get; set; } = Guid.NewGuid().ToString();
        // Patient's Name (First, Middle, Last)
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        // Patient's date of birth
        public DateTime DOB { get; set; }
        // Patient Contact Information
        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        // System Information
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;

        // Current Stage
        public int StageID { get; set; }

        // Current Status of the patient

        public int StatusID { get; set; }
        // Navigation for Stages
        public IEnumerable<Stage> Stages { get; set; } = new List<Stage>();

        // Patient Image URL
        public string ImageURL { get; set; } = string.Empty;
    }
}
