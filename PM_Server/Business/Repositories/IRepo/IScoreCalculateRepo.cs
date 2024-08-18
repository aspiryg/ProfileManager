namespace PM_Server.Business.Repositories.IRepo
{
    public interface IScoreCalculateRepo
    {
        Task<int> CalculateScore(int questionId,string answer);
    }
}
