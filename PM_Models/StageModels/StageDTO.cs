using PM_Models.PatientModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Models.StageModels
{
    public class StageDTO
    {
        public int ID { get; set; }

        // Patient ID
        public int Patient_Id { get; set; }

        // Stage number
        [Display(Name = "Stage Number")]
        public int StageNumber { get; set; }
        [Display(Name = "Stage Type")]
        public string StageType { get; set; } = string.Empty;

        // Unique Global Identifier
        public Guid StageID { get; set; } = Guid.NewGuid();
        // Stage Name
        [Display(Name = "Stage Name")]
        [Required(ErrorMessage = "Stage Name is required")]
        public string StageName { get; set; } = string.Empty;
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        // Stage Status
        [Display(Name = "Stage Status")]
        public string StageStatus { get; set; } = string.Empty;
        [Display(Name = "Stage Status ID")]
        public int StageStatusID { get; set; }
        [Display(Name = "Stage Color")]
        public string StageColor { get; set; } = string.Empty;
        [Display(Name = "Stage Icon")]
        public string StageIcon { get; set; } = string.Empty;
        [Display(Name = "Stage Order")]
        public int StageOrder { get; set; }
        [Display(Name = "Stage Group")]
        public string StageGroup { get; set; } = string.Empty;
        [Display(Name = "Stage Group Parent")]
        public string StageGroupParent { get; set; } = string.Empty;
        // Assignee
        [Display(Name = "Responsible")]
        public string Responsible { get; set; } = string.Empty;
        [Display(Name = "Assigned To")]
        public string AssignedTo { get; set; } = string.Empty;
        [Display(Name = "Assigned By")]
        public string AssignedBy { get; set; } = string.Empty;
        [Display(Name = "Actual Assignee")]
        public string ActualAssignee { get; set; } = string.Empty;
        [Display(Name = "Assigned Date")]
        public DateTime AssignedDate { get; set; }
        // Start Date
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Actual Start Date")]
        public DateTime ActualStartDate { get; set; }
        // Due Date
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }
        // Completion Date
        [Display(Name = "Completion Date")]
        public DateTime CompletionDate { get; set; }

        // Stage Status parameters
        [Display(Name = "Is Completed")]
        public bool IsCompleted { get; set; } = false;
        [Display(Name = "Is Started")]
        public bool IsStarted { get; set; } = false;
        [Display(Name = "Is Cancelled")]
        public bool IsCancelled { get; set; } = false;
        [Display(Name = "Is Assigned")]
        public bool IsAssigned { get; set; } = false;
        [Display(Name = "Is Overdue")]
        public bool IsOverdue { get; set; } = false;
        [Display(Name = "Is Current Stage")]
        public bool IsCurrentStage { get; set; } = false;
        [Display(Name = "Is Next Stage")]
        public bool IsNextStage { get; set; } = false;


        // Notes
        [Display(Name = "Notes")]
        public string Notes { get; set; } = string.Empty;
        // System generated fields
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public bool IsModified { get; set; } = false;


        // Navigation Properties
        [Display(Name = "Patient")]
        public PatientDTO Patient { get; set; } = new PatientDTO();

        // Methods
        public string GetStageStatus(int statusId)
        {
            // Get the status of the stage

            //1   Pending
            //2   In Progress
            //3   Completed
            //4   Cancelled
            //5   Rejected
            //6   Approved
            //7   On Hold
            //8   Not Started
            //9   Not Applicable
            //10  Not Required
            //11  Not Available


            return statusId switch
            {
                1 => "Pending",
                2 => "In Progress",
                3 => "Completed",
                4 => "Cancelled",
                5 => "Rejected",
                6 => "Approved",
                7 => "On Hold",
                8 => "Not Started",
                9 => "Not Applicable",
                10 => "Not Required",
                11 => "Not Available",
                _ => "Not Available",
            };
        }

    }
}
