using PM_Models.GeneInfo;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface INationalityRepo
    {
        public Task<NationalityDTO> CreateNationality(NationalityDTO nationality);
        public Task<NationalityDTO> UpdateNationality(NationalityDTO nationalityDTO);
        public Task<IEnumerable<NationalityDTO>> GetAllNationalities();
        public Task<bool> Remove(int id);
        public Task<NationalityDTO> Get(int id);
    }
}
