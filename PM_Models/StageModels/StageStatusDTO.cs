﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Models.StageModels
{
    public class StageStatusDTO
    {
        public int ID { get; set; }
        [Display(Name = "Status")]
        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; } = string.Empty;
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Color")]
        public string Color { get; set; } = string.Empty;
        [Display(Name = "Icon")]
        public string Icon { get; set; } = string.Empty;

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