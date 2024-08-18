using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.SEA;
using PM_Models.SEA;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class ScoreRepo : IScoreRepo
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public ScoreRepo(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ScoringSystemDTO> CreateScore(ScoringSystemDTO score)
        {
            var newScore = _mapper.Map<ScoringSystemDTO, ScoringSystem>(score);
            var AddedScore = await _context.ScoringSystems.AddAsync(newScore);
            await _context.SaveChangesAsync();
            return _mapper.Map<ScoringSystem, ScoringSystemDTO>(AddedScore.Entity);
        }

        public async Task<ScoringSystemDTO> DeleteScore(int id)
        {
            var score = await _context.ScoringSystems.FindAsync(id);
            if (score == null)
            {
                return new ScoringSystemDTO();
            }
            _context.ScoringSystems.Remove(score);
            await _context.SaveChangesAsync();
            return _mapper.Map<ScoringSystem, ScoringSystemDTO>(score);
        }

        public async Task<ScoringSystemDTO> GetScore(int id)
        {
            var score = await _context.ScoringSystems.FindAsync(id);
            if (score == null)
            {
                return new ScoringSystemDTO();
            }
            return _mapper.Map<ScoringSystem, ScoringSystemDTO>(score);
        }

        public async Task<ScoringSystemDTO> GetScoreByQuestion(int questionID)
        {
            var score = await _context.ScoringSystems.FirstOrDefaultAsync(s => s.QuestionId == questionID);
            if (score == null)
            {
                return new ScoringSystemDTO();
            }
            return _mapper.Map<ScoringSystem, ScoringSystemDTO>(score);
        }

        public async Task<IEnumerable<ScoringSystemDTO>> GetScores()
        {
            var scores = await _context.ScoringSystems.ToListAsync();
            if (scores == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<ScoringSystem>, IEnumerable<ScoringSystemDTO>>(scores);
        }

        public async Task<int> RemoveScore(int id)
        {
            var score = await _context.ScoringSystems.FindAsync(id);
            if (score == null)
            {
                return 0;
            }
            _context.ScoringSystems.Remove(score);
            return await _context.SaveChangesAsync();
        }

        public async Task<ScoringSystemDTO> UpdateScore(ScoringSystemDTO score)
        {
            var newScore = await _context.ScoringSystems.FindAsync(score.Id);
            if (newScore == null)
            {
                return new ScoringSystemDTO();
            }
            _mapper.Map(score, newScore);
            newScore.ModifiedDate = DateTime.Now;
            var updatedScore = _context.ScoringSystems.Update(newScore);
            await _context.SaveChangesAsync();
            return _mapper.Map<ScoringSystem, ScoringSystemDTO>(updatedScore.Entity);
        }
    }
}
