using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.PatientClasses;
using PM_DataAccess.StagesClasses;
using PM_Models.PatientModels;
using PM_Models.StageModels;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class PatientRepo : IPatientRepo
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public PatientRepo(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<PatientDTO> CreatePatient(PatientDTO patient)
        {
            var patientObj = _mapper.Map<PatientDTO, Patient>(patient);
            patientObj.CreatedDate = DateTime.Now;
            var CreatedPatient = await _db.Patients.AddAsync(patientObj);
            await _db.SaveChangesAsync();
            return _mapper.Map<Patient, PatientDTO>(CreatedPatient.Entity);
        }

        public async Task<bool> DeletePatient(int patientID)
        {
            // Remove the patient from the system and remove all the stages associated with the patient
            var patient = await _db.Patients.FindAsync(patientID);
            if (patient != null)
            {
                var stages = await _db.Stages.Where(s => s.Patient_Id == patientID).ToListAsync();
                if (stages != null)
                {
                    _db.Stages.RemoveRange(stages);
                }
                _db.Patients.Remove(patient);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<PatientDTO>> GetAllPatients()
        {
            var patients = await _db.Patients.Include(u => u.Stages).ToListAsync();
            if (patients != null)
            {
                return _mapper.Map<IEnumerable<Patient>, IEnumerable<PatientDTO>>(patients);
            }
            return [];
        }

        public async Task<StageDTO> GetCurrentStage(int patientID)
        {
            var stages = await _db.Stages.Where(s => s.Patient_Id == patientID).ToListAsync();
            if (stages != null)
            {
                var currentStage = stages.FirstOrDefault(s => s.IsCurrentStage);
                if (currentStage != null)
                {
                    return _mapper.Map<Stage, StageDTO>(currentStage);
                }
                return new StageDTO();
            }
            return new StageDTO();
        }

        public async Task<StageDTO> GetNextStage(int patientID)
        {
            var stages = await _db.Stages.Where(s => s.Patient_Id == patientID).ToListAsync();
            if (stages != null)
            {
                var nextStage = stages.FirstOrDefault(s => s.IsNextStage);
                if (nextStage != null)
                {
                    return _mapper.Map<Stage, StageDTO>(nextStage);
                }
                return new StageDTO();
            }
            return new StageDTO();
        }

        public async Task<PatientDTO> GetPatient(int patientID)
        {
            var patient = await _db.Patients.Include(s => s.Stages).FirstOrDefaultAsync(p => p.PatientID == patientID);
            if (patient != null)
            {
                return _mapper.Map<Patient, PatientDTO>(patient);
            }
            return new PatientDTO();
        }

        public async Task<PatientDTO> GetPatientByCode(string patientCode)
        {
            var patient = await _db.Patients.Include(s => s.Stages).FirstOrDefaultAsync(p => p.PatientCode == patientCode);
            if (patient != null)
            {
                return _mapper.Map<Patient, PatientDTO>(patient);
            }
            return new PatientDTO();
        }

        public async Task<int> GetPatientId()
        {
            // Get the last patient ID
            var lastPatient = await _db.Patients.OrderByDescending(p => p.PatientID).FirstOrDefaultAsync();
            if (lastPatient != null)
            {
                return lastPatient.PatientID;
            }
            return 0;
        }

        public async Task<IEnumerable<StageDTO>> GetPatientStages(int patientID)
        {
            // Search the stages table based on the patient ID
            var stages = await _db.Stages.Where(s => s.Patient_Id == patientID).ToListAsync();
            if (stages != null)
            {
                return _mapper.Map<IEnumerable<Stage>, IEnumerable<StageDTO>>(stages);
            }
            return [];
        }

        public async Task<StageStatusDTO> GetPatientStatus(int patientID)
        {
            var patient = await _db.Patients.FindAsync(patientID);
            if (patient != null)
            {
                var status = await _db.StageStatuses.FindAsync(patient.StatusID);
                if (status != null)
                {
                    return _mapper.Map<StageStatus, StageStatusDTO>(status);
                }
                return new StageStatusDTO();
            }
            return new StageStatusDTO();
        }

        public async Task<IEnumerable<PatientDTO>> SearchPatients(string name)
        {
            var patients = await _db.Patients.Where(p => p.FirstName.Contains(name) || p.LastName.Contains(name)).ToListAsync();
            if (patients != null)
            {
                return _mapper.Map<IEnumerable<Patient>, IEnumerable<PatientDTO>>(patients);
            }
            return [];
        }

        public async Task<PatientDTO> UpdatePatient(PatientDTO patient)
        {
            var patientObj = await _db.Patients.FindAsync(patient.PatientID);
            if (patientObj == null)
            {
                return new PatientDTO();
            }
            patientObj.ModifiedDate = DateTime.Now;
            patientObj.ModifiedBy = patient.ModifiedBy;
            patientObj.FirstName = patient.FirstName;
            patientObj.LastName = patient.LastName;
            patientObj.MiddleName = patient.MiddleName;
            patientObj.DOB = patient.DOB;
            patientObj.AddressLine1 = patient.AddressLine1;
            patientObj.AddressLine2 = patient.AddressLine2;
            patientObj.City = patient.City;
            patientObj.State = patient.State;
            patientObj.ZipCode = patient.ZipCode;
            patientObj.Country = patient.Country;
            patientObj.PhoneNumber = patient.PhoneNumber;
            patientObj.Email = patient.Email;
            patientObj.StageID = patient.StageID;
            patientObj.StatusID = patient.StatusID;
            var updatedPatient = _db.Patients.Update(patientObj);
            await _db.SaveChangesAsync();
            return _mapper.Map<Patient, PatientDTO>(updatedPatient.Entity);
        }
    }
}
