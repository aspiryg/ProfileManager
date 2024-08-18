using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Models.GeneInfo
{
    public class SurgeryDTO
    {
        public int Id { get; set; }
        public Guid SurgeryCode { get; set; } = Guid.NewGuid();
        public string SurgeryName { get; set; } = string.Empty;
        public string SurgeryDescription { get; set; } = string.Empty;
        public string SurgeryType { get; set; } = string.Empty;
        public string SurgeryCategory { get; set; } = string.Empty;

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
