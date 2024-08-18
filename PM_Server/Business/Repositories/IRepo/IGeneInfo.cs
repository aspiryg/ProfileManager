using PM_Models.GeneInfo;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface IGeneInfo
    {
        // Employment Status Methods
        Task<IEnumerable<EmploymentStatusDTO>> GetAllEmpStatus();
        Task<EmploymentStatusDTO> CreateEmpStatus(EmploymentStatusDTO empStatus);
        Task<bool> DeleteEmpStatus(int id);

        // Employment Type Methods
        Task<IEnumerable<EmploymentTypeDTO>> GetAllEmpType();
        Task<EmploymentTypeDTO> CreateEmpType(EmploymentTypeDTO empType);
        Task<bool> DeleteEmpType(int id);
    }
}
