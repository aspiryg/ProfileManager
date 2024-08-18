using PM_Models.PatientModels;
using PM_Models.UserProfilesModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Models.ReferrerModels
{
    public class ReferrerDTO : UserProfileDTO
    {
        // Navigation property for the Referrer's patients
        public List<PatientDTO> Patients { get; set; } = [];
    }
}
