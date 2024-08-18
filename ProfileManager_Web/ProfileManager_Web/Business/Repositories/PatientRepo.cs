using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.PatientClasses;
using PM_Models.PatientModels;
using ProfileManager_Web.Business.Repositories.IRepositories;
using ProfileManager_Web.Data;

namespace ProfileManager_Web.Business.Repositories
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
            var patientObj = _mapper.Map<PatientDTO,Patient>(patient);
            patientObj.CreatedDate = DateTime.Now;
            var CreatedPatient = await _db.Patients.AddAsync(patientObj);
            await _db.SaveChangesAsync();
            return _mapper.Map<Patient,PatientDTO>(CreatedPatient.Entity);
        }

        public async Task<bool> DeletePatient(int patientID)
        {
            var patient = await _db.Patients.FindAsync(patientID);
            if (patient != null)
            {
                _db.Patients.Remove(patient);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<PatientDTO>> GetAllPatients()
        {
            var patients = await _db.Patients.ToListAsync();
            if(patients != null)
            {
                return _mapper.Map<IEnumerable<Patient>, IEnumerable<PatientDTO>>(patients);
            }
            return [];
        }

        public async Task<PatientDTO> GetPatient(int patientID)
        {
            var patient = await _db.Patients.FindAsync(patientID);
            if (patient != null)
            {
                return _mapper.Map<Patient, PatientDTO>(patient);
            }
            return new PatientDTO();
        }

        public async Task<PatientDTO> GetPatientByCode(string patientCode)
        {
            var patient = await _db.Patients.FirstOrDefaultAsync(p => p.PatientCode == patientCode);
            if (patient != null)
            {
                return _mapper.Map<Patient, PatientDTO>(patient);
            }
            return new PatientDTO();
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
            var patientObj = _mapper.Map<PatientDTO, Patient>(patient);
            patientObj.ModifiedDate = DateTime.Now;
            var updatedPatient = _db.Patients.Update(patientObj);
            await _db.SaveChangesAsync();
            return _mapper.Map<Patient, PatientDTO>(updatedPatient.Entity);
        }
    }
}
