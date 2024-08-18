using PM_DataAccess.PatientClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_DataAccess.StagesClasses
{
    public class Stage
    {
        [Key]
        public int ID { get; set; }
        // Patient ID
        public int Patient_Id { get; set; }
        // Unique Global Identifier
        public Guid StageID { get; set; } = Guid.NewGuid();
        // Stage number
        public int StageNumber { get; set; }
        public string StageType { get; set; } = string.Empty;
        // Stage Name
        public string StageName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Stage Status
        public int StageStatusID { get; set; }
        public string StageStatus { get; set; } = string.Empty;
        public string StageColor { get; set; } = string.Empty;
        public string StageIcon { get; set; } = string.Empty;
        // Stage Order
        public int StageOrder { get; set; }
        public string StageGroup { get; set; } = string.Empty;
        public string StageGroupParent { get; set; } = string.Empty;
        // Assignee
        public string Responsible { get; set; } = string.Empty;
        public string AssignedTo { get; set; } = string.Empty;
        public string AssignedBy { get; set; } = string.Empty;
        public string ActualAssignee { get; set; } = string.Empty;
        public DateTime AssignedDate { get; set; }
        // Start Date
        public DateTime StartDate { get; set; }
        public DateTime ActualStartDate { get; set; }
        // Due Date
        public DateTime DueDate { get; set; }
        // Completion Date
        public DateTime CompletionDate { get; set; }

        // Stage Status parameters
        public bool IsCompleted { get; set; } = false;
        public bool IsStarted { get; set; } = false;
        public bool IsCancelled { get; set; } = false;
        public bool IsAssigned { get; set; } = false;
        public bool IsOverdue { get; set; } = false;
        public bool IsCurrentStage { get; set; } = false;
        public bool IsNextStage { get; set; } = false;

        // Notes
        public string Notes { get; set; } = string.Empty;
        // System generated fields
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public bool IsModified { get; set; } = false;
    }
}
