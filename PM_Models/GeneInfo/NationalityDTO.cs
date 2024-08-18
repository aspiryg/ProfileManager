using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Models.GeneInfo
{
    public class NationalityDTO
    {
        public int Id { get; set; }
        public Guid NationalityCode { get; set; } = Guid.NewGuid();
        public string NationalityName { get; set; } = string.Empty;

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
