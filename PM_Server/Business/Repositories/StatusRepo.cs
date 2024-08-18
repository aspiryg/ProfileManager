using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.StagesClasses;
using PM_Models.StageModels;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class StatusRepo : IStatusRepo
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public StatusRepo(ApplicationDbContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<StageStatusDTO> CreateStatus(StageStatusDTO status)
        {
            var statusObj = _mapper.Map<StageStatusDTO, StageStatus>(status);
            statusObj.CreatedDate = DateTime.Now;
            var CreatedStatus = await _db.StageStatuses.AddAsync(statusObj);
            await _db.SaveChangesAsync();
            return _mapper.Map<StageStatus, StageStatusDTO>(CreatedStatus.Entity);
        }

        public async Task<StageStatusDTO> DeleteStatus(int id)
        {
            var status = await _db.StageStatuses.FindAsync(id);
            if (status == null)
            {
                return new StageStatusDTO();
            }
            status.IsDeleted = true;
            status.ModifiedDate = DateTime.Now;
            var statusDeleted = _db.StageStatuses.Update(status);
            await _db.SaveChangesAsync();
            return _mapper.Map<StageStatus, StageStatusDTO>(statusDeleted.Entity);
        }

        public async Task<StageStatusDTO> GetStatus(int id)
        {
            var status = await _db.StageStatuses.FindAsync(id);
            if (status == null)
            {
                return new StageStatusDTO();
            }
            return _mapper.Map<StageStatus, StageStatusDTO>(status);
        }

        public async Task<IEnumerable<StageStatusDTO>> GetStatuses()
        {
            var statuses = await _db.StageStatuses.ToListAsync();
            if (statuses == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<StageStatus>, IEnumerable<StageStatusDTO>>(statuses);
        }

        public async Task<int> RemoveStatus(int id)
        {
            var status = await _db.StageStatuses.FindAsync(id);
            if (status == null)
            {
                return 0;
            }
            _db.StageStatuses.Remove(status);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<StageStatusDTO>> SearchStatuses(string name)
        {
            var statuses = await _db.StageStatuses.Where(s => s.Status.Contains(name)).ToListAsync();
            if (statuses == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<StageStatus>, IEnumerable<StageStatusDTO>>(statuses);
        }

        public async Task<StageStatusDTO> UpdateStatus(StageStatusDTO status)
        {
            var statusObj = _mapper.Map<StageStatusDTO, StageStatus>(status);
            statusObj.ModifiedDate = DateTime.Now;
            var updatedStatus = _db.StageStatuses.Update(statusObj);
            await _db.SaveChangesAsync();
            return _mapper.Map<StageStatus, StageStatusDTO>(updatedStatus.Entity);
        }
    }
}
