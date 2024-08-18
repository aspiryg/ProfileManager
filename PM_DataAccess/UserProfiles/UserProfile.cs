using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_DataAccess.UserProfiles
{
    public class UserProfile
    {
        [Key]
        public int ID { get; set; }
        // Unique Global Identifier
        public Guid UserID { get; set; } = Guid.NewGuid();
        // Name of the user (First and Last)
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        // Email of the user
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        // Phone number of the user
        public string Phone { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        // Address of the user
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        // Notes about the user
        public string Notes { get; set; } = string.Empty;
        // System generated fields
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
        public bool IsModified { get; set; } = false;
        // User's role and Type
        public string UserType { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
