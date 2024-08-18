using PM_Models.StageModels;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface IStatusRepo
    {
        public Task<StageStatusDTO> CreateStatus(StageStatusDTO status);
        public Task<StageStatusDTO> UpdateStatus(StageStatusDTO status);
        public Task<StageStatusDTO> GetStatus(int id);
        public Task<IEnumerable<StageStatusDTO>> GetStatuses();
        public Task<StageStatusDTO> DeleteStatus(int id);
        public Task<int> RemoveStatus(int id);
        // Search for statuses by name
        public Task<IEnumerable<StageStatusDTO>> SearchStatuses(string name);
        // Remove Status from the system
    }
}
