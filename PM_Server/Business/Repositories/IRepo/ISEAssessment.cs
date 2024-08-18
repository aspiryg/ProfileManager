using PM_Models.SEA;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface ISEAssessment
    {
        Task<SocioeconomicAssessmentDTO> AddSEA(SocioeconomicAssessmentDTO sea);
        Task<SocioeconomicAssessmentDTO> GetSEA(int id);
        Task<SocioeconomicAssessmentDTO> GetSEAByPatientID(int patientID);
        Task<SocioeconomicAssessmentDTO> UpdateSEA(SocioeconomicAssessmentDTO sea);
        Task<bool> DeleteSEA(int id);
        Task<bool> DeleteSEAByPatientID(int patientID);
        // Get all SEAs
        Task<IEnumerable<SocioeconomicAssessmentDTO>> GetSEAs();
        // Check if SEA exists
        Task<bool> SEAExists(int id);
        Task<bool> SEAExistsByPatientID(int patientID);
    }
}
