using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.Referrer;
using PM_Models.ReferrerModels;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class ReferrerRepo : IReferrerRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ReferrerRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ReferrerDTO> CreateReferrer(ReferrerDTO referrer)
        {
            var newReferrer = _mapper.Map<ReferrerDTO, Referrer>(referrer);
            newReferrer.CreatedDate = DateTime.Now;
            var ReferrerCreated = await _context.Referrers.AddAsync(newReferrer);
            await _context.SaveChangesAsync();
            return _mapper.Map<Referrer,ReferrerDTO>(ReferrerCreated.Entity);
        }

        public async Task<ReferrerDTO> DeleteReferrer(int id)
        {
            var referrer = await _context.Referrers.FindAsync(id);
            if (referrer == null)
            {
                return new ReferrerDTO();
            }
            referrer.IsDeleted = true;
            referrer.ModifiedDate = DateTime.Now;
            var ReferrerDeleted = _context.Referrers.Update(referrer);
            await _context.SaveChangesAsync();
            return _mapper.Map<Referrer, ReferrerDTO>(ReferrerDeleted.Entity);
        }

        public async Task<ReferrerDTO> GetReferrer(int id)
        {
            var referrer = await _context.Referrers.FindAsync(id);
            if (referrer == null)
            {
                return new ReferrerDTO();
            }
            return _mapper.Map<Referrer, ReferrerDTO>(referrer);
        }

        public async Task<IEnumerable<ReferrerDTO>> GetReferrers()
        {
            var referrers = await _context.Referrers.ToListAsync();
            if (referrers == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<Referrer>, IEnumerable<ReferrerDTO>>(referrers);
        }

        public async Task<ReferrerDTO> UpdateReferrer(ReferrerDTO referrer)
        {
            var referrerToUpdate = await _context.Referrers.FindAsync(referrer.ID);
            if (referrerToUpdate == null)
            {
                return new ReferrerDTO();
            }
            referrerToUpdate = _mapper.Map<ReferrerDTO, Referrer>(referrer);
            referrerToUpdate.ModifiedDate = DateTime.Now;
            referrerToUpdate.IsModified = true;
            referrerToUpdate.ModifiedBy = "System";
            var ReferrerUpdated = _context.Referrers.Update(referrerToUpdate);
            await _context.SaveChangesAsync();
            return _mapper.Map<Referrer, ReferrerDTO>(ReferrerUpdated.Entity);
        }
    }
}
