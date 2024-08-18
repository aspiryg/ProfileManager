using PM_Models.PatientModels;
using PM_Models.StageModels;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface IPatientRepo
    {
        public Task<PatientDTO> CreatePatient(PatientDTO patient);
        public Task<PatientDTO> UpdatePatient(PatientDTO patient);
        public Task<PatientDTO> GetPatient(int patientID);
        public Task<PatientDTO> GetPatientByCode(string patientCode);
        public Task<IEnumerable<PatientDTO>> GetAllPatients();
        public Task<bool> DeletePatient(int patientID);
        // Search for patients by name
        public Task<IEnumerable<PatientDTO>> SearchPatients(string name);
        // Remove Patient from the system

        // Get the Current Stage of a Patient
        public Task<StageDTO> GetCurrentStage(int patientID);
        // Get the Patient current status
        public Task<StageStatusDTO> GetPatientStatus(int patientID);
        // Get the Patient Next Stage
        public Task<StageDTO> GetNextStage(int patientID);
        // Get all the stages of a patient
        public Task<IEnumerable<StageDTO>> GetPatientStages(int patientID);

        // Get patient Id
        public Task<int> GetPatientId();
    }
}
