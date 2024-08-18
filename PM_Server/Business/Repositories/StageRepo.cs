using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.StagesClasses;
using PM_Models.StageModels;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class StageRepo : IStageRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public StageRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<StageDTO> CreateStage(StageDTO stage, int patientID)
        {
            var stageObj = _mapper.Map<StageDTO, Stage>(stage);
            stageObj.Patient_Id = patientID;
            stageObj.CreatedDate = DateTime.Now;
            var CreatedStage = await _context.Stages.AddAsync(stageObj);
            await _context.SaveChangesAsync();
            return _mapper.Map<Stage, StageDTO>(CreatedStage.Entity);
        }

        public async Task<StageDTO> DeleteStage(int id)
        {
            var stage = await _context.Stages.FindAsync(id);
            if (stage == null)
            {
                return new StageDTO();
            }
            stage.IsDeleted = true;
            stage.ModifiedDate = DateTime.Now;
            var stageDeleted = _context.Stages.Update(stage);
            await _context.SaveChangesAsync();
            return _mapper.Map<Stage, StageDTO>(stageDeleted.Entity);
        }

        public async Task<StageDTO> GetStage(int id)
        {
            var stage = await _context.Stages.FindAsync(id);
            if (stage == null)
            {
                return new StageDTO();
            }
            return _mapper.Map<Stage, StageDTO>(stage);
        }

        public async Task<StageDTO> GetStageByPatientAndOrder(int patientID, int order)
        {
            var stage = await _context.Stages.Where(s => s.Patient_Id == patientID && s.StageOrder == order).FirstOrDefaultAsync();
            if (stage == null)
            {
                return new StageDTO();
            }
            return _mapper.Map<Stage, StageDTO>(stage);
        }

        public async Task<IEnumerable<StageDTO>> GetStages()
        {
            var stages = await _context.Stages.ToListAsync();
            if (stages == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<Stage>, IEnumerable<StageDTO>>(stages);
        }

        public async Task<IEnumerable<StageTypeDTO>> GetStageTypes()
        {
            var stageTypes = await _context.StageTypes.ToListAsync();
            if (stageTypes == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<StageTypes>, IEnumerable<StageTypeDTO>>(stageTypes);
        }

        public async Task<int> RemoveStage(int id)
        {
            var stage = await _context.Stages.FindAsync(id);
            if (stage == null)
            {
                return 0;
            }
            _context.Stages.Remove(stage);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<StageDTO>> SearchStages(string name)
        {
            var stages = await _context.Stages.Where(s => s.StageName.Contains(name)).ToListAsync();
            if (stages == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<Stage>, IEnumerable<StageDTO>>(stages);
        }

        public async Task<StageDTO> UpdateStage(StageDTO stage)
        {
            var stageToUpdate = await _context.Stages.FindAsync(stage.ID);
            if (stageToUpdate == null)
            {
                return new StageDTO();
            }
            // update the stage with the new values by mapping the new values to the stageToUpdate object
            _mapper.Map(stage, stageToUpdate);
            stageToUpdate.ModifiedDate = DateTime.Now;
            stageToUpdate.IsModified = true;
            var stageUpdated = _context.Stages.Update(stageToUpdate);
            await _context.SaveChangesAsync();
            return _mapper.Map<Stage, StageDTO>(stageUpdated.Entity);
        }
    }
}
