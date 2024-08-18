using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_DataAccess.StagesClasses
{
    public class StageTypes
    {
        [Key]
        public int StageID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Group { get; set; } = string.Empty;
        public string Parent { get; set; } = string.Empty;
        public int Order { get; set; }
        // Responsibility
        public string Responsible { get; set; } = string.Empty;
        public string AssignedTo { get; set; } = string.Empty;
        public string AssignedBy { get; set; } = string.Empty;
        // Time Frame
        public int Duration { get; set; } = 0;
        public string DurationType { get; set; } = string.Empty;
        public string DurationUnit { get; set; } = string.Empty;
        // Audit Fields
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public bool IsModified { get; set; } = false;

    }
}
