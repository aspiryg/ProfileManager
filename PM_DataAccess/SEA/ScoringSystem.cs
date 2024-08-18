﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_DataAccess.SEA
{
    public class ScoringSystem
    {
        [Key]
        public int Id { get; set; }
        public Guid ScoringSystemCode { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string QuestionType { get; set; } = string.Empty;
        public string Answer { get; set; }
        public int Score { get; set; }
        public string Oprator { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;
        public int CaseId { get; set; } 
        public int Weight { get; set; }
        public string Description { get; set; } = string.Empty;



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