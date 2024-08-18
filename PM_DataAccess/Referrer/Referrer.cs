using PM_DataAccess.PatientClasses;
using PM_DataAccess.UserProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_DataAccess.Referrer
{
    public class Referrer : UserProfile
    {
        // Navigation property for the Referrer's patients
        public List<Patient> Patients { get; set; } = [];
    }
}
