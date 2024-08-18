using PM_Models.SEA;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface IScoreRepo
    {
        public Task<ScoringSystemDTO> CreateScore(ScoringSystemDTO score);
        public Task<ScoringSystemDTO> UpdateScore(ScoringSystemDTO score);
        public Task<ScoringSystemDTO> GetScore(int id);
        public Task<IEnumerable<ScoringSystemDTO>> GetScores();
        public Task<ScoringSystemDTO> DeleteScore(int id);
        public Task<int> RemoveScore(int id);
        // Get Scoring algorithm by question ID
        public Task<ScoringSystemDTO> GetScoreByQuestion(int questionID);
    }
}
