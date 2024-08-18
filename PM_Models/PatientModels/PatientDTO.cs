using PM_Models.StageModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Models.PatientModels
{
    public class PatientDTO
    {
        public int PatientID { get; set; }
        public string PatientCode { get; set; } = Guid.NewGuid().ToString();
        // Error: The FirstName field is required.
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
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
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;

        // Current Stage information
        [Display(Name = "Stage")]
        public int StageID { get; set; }


        // Current Status of the patient
        [Display(Name = "Status")]
        public int StatusID { get; set; }
        public StageStatusDTO CurrentStatus { get; set; } = new StageStatusDTO();

        // Navigation for Stages
        public IEnumerable<StageDTO> Stages { get; set; } = new List<StageDTO>();


        // Patient Image URL
        public string ImageURL { get; set; } = string.Empty;
    }
}
