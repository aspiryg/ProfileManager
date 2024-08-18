using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.GeneInfo;
using PM_Models.GeneInfo;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class NationalityRepo : INationalityRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public NationalityRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<NationalityDTO> CreateNationality(NationalityDTO nationality)
        {
            throw new NotImplementedException();
        }

        public Task<NationalityDTO> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<NationalityDTO>> GetAllNationalities()
        {
            var nationalities = await _context.Nationalities.ToListAsync();
            if (nationalities == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<Nationality>, IEnumerable<NationalityDTO>>(nationalities);
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<NationalityDTO> UpdateNationality(NationalityDTO nationalityDTO)
        {
            throw new NotImplementedException();
        }
    }
}
