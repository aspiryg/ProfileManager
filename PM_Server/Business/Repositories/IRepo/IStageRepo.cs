using PM_DataAccess.StagesClasses;
using PM_Models.StageModels;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface IStageRepo
    {
        public Task<StageDTO> CreateStage(StageDTO stage, int patientID);
        public Task<StageDTO> UpdateStage(StageDTO stage);
        public Task<StageDTO> GetStage(int id);
        public Task<IEnumerable<StageDTO>> GetStages();
        public Task<StageDTO> DeleteStage(int id);
        public Task<int> RemoveStage(int id);
        // Search for stages by name
        public Task<IEnumerable<StageDTO>> SearchStages(string name);
        // Remove Stage from the system

        // Load all the stage types
        public Task<IEnumerable<StageTypeDTO>> GetStageTypes();
        // Get Stage by patient ID and order
        public Task<StageDTO> GetStageByPatientAndOrder(int patientID, int order);
    }
}
