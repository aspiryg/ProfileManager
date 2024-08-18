using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.GeneInfo;
using PM_Models.GeneInfo;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class SurgeryRepo : ISurgeryRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public SurgeryRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<SurgeryDTO> AddSurgery(SurgeryDTO surgery)
        {
            throw new NotImplementedException();
        }

        public Task<SurgeryDTO> DeleteSurgery(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SurgeryDTO>> GetAllSurgeries()
        {
            var surgeries = await _context.Surgeries.ToListAsync();
            if (surgeries == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<Surgery> ,IEnumerable<SurgeryDTO>>(surgeries);
        }

        public Task<SurgeryDTO> GetSurgeryByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Task<SurgeryDTO> GetSurgeryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SurgeryDTO> GetSurgeryByPatient(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SurgeryDTO> UpdateSurgery(SurgeryDTO surgery)
        {
            throw new NotImplementedException();
        }
    }
}
