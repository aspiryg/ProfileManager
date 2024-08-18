using PM_Models.GeneInfo;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface ISurgeryRepo
    {
        Task<IEnumerable<SurgeryDTO>> GetAllSurgeries();
        Task<SurgeryDTO> GetSurgeryById(int id);
        Task<SurgeryDTO> GetSurgeryByCode(string code);
        Task<SurgeryDTO> AddSurgery(SurgeryDTO surgery);
        Task<SurgeryDTO> UpdateSurgery(SurgeryDTO surgery);
        Task<SurgeryDTO> DeleteSurgery(int id);
        Task<SurgeryDTO> GetSurgeryByPatient(int id);
    }
}
