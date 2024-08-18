using PM_Models.ReferrerModels;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface IReferrerRepo
    {
        public Task<ReferrerDTO> CreateReferrer(ReferrerDTO referrer);
        public Task<ReferrerDTO> GetReferrer(int id);
        public Task<IEnumerable<ReferrerDTO>> GetReferrers();
        public Task<ReferrerDTO> UpdateReferrer(ReferrerDTO referrer);
        public Task<ReferrerDTO> DeleteReferrer(int id);
    }
}
