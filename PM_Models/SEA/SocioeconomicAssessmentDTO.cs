using PM_Models.GeneInfo;
using PM_Models.PatientModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Models.SEA
{
    public class SocioeconomicAssessmentDTO
    {
        public int Id { get; set; }
        public Guid SocioeconomicAssessmentCode { get; set; } = Guid.NewGuid();
        public int PatientID { get; set; }
        public PatientDTO Patient { get; set; }
        // Nationality
        [Required]
        [Display(Name = "Nationality")]
        public int NationalityID { get; set; }
        public NationalityDTO Nationality { get; set; }
        // Employment
        [Required]
        [Display(Name = "Employment Status")]
        public string EmploymentStatus { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public string EmploymentType { get; set; } = string.Empty;

        [Display(Name = "Working Family Members")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int WorkingFamilyMembers { get; set; }

        // Education
        [Display(Name = "Education Level")]
        public string EducationLevel { get; set; } = string.Empty;
        // Income
        [Display(Name = "Monthly Income")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid decimal Number")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal MonthlyIncome { get; set; }
        public string IncomeSource { get; set; } = string.Empty;
        public bool AbilityToAffordEssentialNeeds { get; set; } = false;
        // 
        public bool UNRWARegistered { get; set; } = false;
        public string UNRWARegistrationNumber { get; set; } = string.Empty;
        public bool UNCHRRegistered { get; set; } = false;
        public string UNCHRRegistrationNumber { get; set; } = string.Empty;
        public bool MOSARegistered { get; set; } = false;
        public string MOSARegistrationNumber { get; set; } = string.Empty;
        public bool OtherRegistered { get; set; } = false;
        public string OtherRegistrationName { get; set; } = string.Empty;
        public string OtherRegistrationNumber { get; set; } = string.Empty;

        // Family
        public string MaritalStatus { get; set; } = string.Empty;
        public int NumberOfFamilyMembers { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfDependents { get; set; }
        public bool IsHeadOfHousehold { get; set; } = false;

        // Disability
        public bool HasDisability { get; set; } = false;
        public string DisabilityType { get; set; } = string.Empty;
        public string DisabilityDescription { get; set; } = string.Empty;
        public string DisabilitySeverity { get; set; } = string.Empty;
        // Housing
        public string HousingStatus { get; set; } = string.Empty;
        public string HousingType { get; set; } = string.Empty;

        // insurance
        public bool HasHealthInsurance { get; set; } = false;
        public string InsuranceType { get; set; } = string.Empty;
        public string InsuranceCompany { get; set; } = string.Empty;
        public string InsurancePolicyNumber { get; set; } = string.Empty;
        // Comments
        public string Comments { get; set; } = string.Empty;
        // Surgery Info
        public int SurgeryId { get; set; } 
        public SurgeryDTO Surgery { get; set; }
        // Additional Info
        public string AdditionalInfo { get; set; } = string.Empty;

        // System Generated Fields
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public bool IsModified { get; set; } = false;
    }
}
