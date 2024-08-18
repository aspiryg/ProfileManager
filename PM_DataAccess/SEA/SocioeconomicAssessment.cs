using PM_DataAccess.GeneInfo;
using PM_DataAccess.PatientClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_DataAccess.SEA
{
    public class SocioeconomicAssessment
    {
        [Key]
        public int Id { get; set; }
        public Guid SocioeconomicAssessmentCode { get; set; }
        // Navigation Properties
        public int PatientID { get; set; }
        [ForeignKey("PatientID")]
        public Patient Patient { get; set; }
        // Nationality
        public int NationalityID { get; set; }
        [ForeignKey("NationalityID")]
        public Nationality Nationality { get; set; }
        // Employment
        public string EmploymentStatus { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public string EmploymentType { get; set; } = string.Empty;
        public int WorkingFamilyMembers { get; set; }

        // Education
        public string EducationLevel { get; set; } = string.Empty;
        // Income
        [Column(TypeName = "decimal(18, 2)")]
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
        public Surgery Surgery { get; set; }

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
