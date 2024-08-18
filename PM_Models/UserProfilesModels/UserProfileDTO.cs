using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Models.UserProfilesModels
{
    public class UserProfileDTO
    {
        [Key]
        public int ID { get; set; }
        public Guid UserID { get; set; } = Guid.NewGuid();
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; } = string.Empty;
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; } = string.Empty;
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; } = string.Empty;
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number is required.")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid Phone Number.")]
        public string Phone { get; set; } = string.Empty;
        // Date of Birth is less than or equal to the current date
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; } = string.Empty;
        [Display(Name = "City")]
        public string City { get; set; } = string.Empty;
        [Display(Name = "State")]
        public string State { get; set; } = string.Empty;
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; } = string.Empty;
        [Display(Name = "Country")]
        public string Country { get; set; } = string.Empty;
        [Display(Name = "Notes")]
        public string Notes { get; set; } = string.Empty;
        // System fields
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
        public bool IsModified { get; set; } = false;
        // User's role and Type
        // User Type: Patient, Referrer, Admin
        [Display(Name = "User Type")]
        [Required(ErrorMessage = "User Type is required.")]
        public string UserType { get; set; } = string.Empty;
        [Display(Name = "Role")]
        public string Role { get; set; } = string.Empty;
    }
}
