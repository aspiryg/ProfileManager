using PM_Models.PatientModels;

namespace ProfileManager_Web.Business.Repositories.IRepositories
{
    public interface IPatientRepo
    {
        public Task<PatientDTO> CreatePatient (PatientDTO patient);
        public Task<PatientDTO> UpdatePatient(PatientDTO patient);
        public Task<PatientDTO> GetPatient(int patientID);
        public Task<PatientDTO> GetPatientByCode(string patientCode);
        public Task<IEnumerable<PatientDTO>> GetAllPatients();
        public Task<bool> DeletePatient(int patientID);
        // Search for patients by name
        public Task<IEnumerable<PatientDTO>> SearchPatients(string name);
        // Remove Patient from the system

    }
}
