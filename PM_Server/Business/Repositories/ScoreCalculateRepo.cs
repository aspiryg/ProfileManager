using AutoMapper;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class ScoreCalculateRepo : IScoreCalculateRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ScoreCalculateRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public Task<int> CalculateScore(int questionId, string answer)
        {
            // get the question type from the database
            var questionType = _context.ScoringSystems.FirstOrDefault(x => x.QuestionId == questionId).QuestionType;
            if (questionType != null)
            {
                switch (questionType)
                {

                    case "Choices":
                        var choices = _context.ScoringSystems.Where(x => x.QuestionId == questionId).ToList();
                        foreach (var choice in choices)
                        {
                            if (choice.Answer == answer)
                            {
                                return Task.FromResult(choice.Score);
                            }
                        }
                        break;
                    case "Number":
                        // make sure the answer is in the correct format
                        if (!int.TryParse(answer, out _))
                        {
                            return Task.FromResult(0);
                        }
                        // compare the answer with the rang of answers in the database based on the operator and return the score
                        var numbers = _context.ScoringSystems.Where(x => x.QuestionId == questionId).ToList();
                        foreach (var number in numbers)
                        {
                            // check the answer to answer in the database based on all possible operators
                            if (number.Oprator == "Equal")
                            {
                                if (int.Parse(answer) == int.Parse(number.Answer))
                                {
                                    return Task.FromResult(number.Score);
                                }
                            }
                            else if (number.Oprator == "GreaterThan")
                            {
                                if (int.Parse(answer) > int.Parse(number.Answer))
                                {
                                    return Task.FromResult(number.Score);
                                }
                            }
                            else if (number.Oprator == "LessThan")
                            {
                                if (int.Parse(answer) < int.Parse(number.Answer))
                                {
                                    return Task.FromResult(number.Score);
                                }
                            }
                            else if (number.Oprator == "GreaterThanOrEqual")
                            {
                                if (int.Parse(answer) >= int.Parse(number.Answer))
                                {
                                    return Task.FromResult(number.Score);
                                }
                            }
                            else if (number.Oprator == "LessThanOrEqual")
                            {
                                if (int.Parse(answer) <= int.Parse(number.Answer))
                                {
                                    return Task.FromResult(number.Score);
                                }
                            }
                            else if (number.Oprator == "NotEqual")
                            {
                                if (int.Parse(answer) != int.Parse(number.Answer))
                                {
                                    return Task.FromResult(number.Score);
                                }
                            }

                        }
                        break;
                    case "bool":
                        var booleans = _context.ScoringSystems.Where(x => x.QuestionId == questionId).ToList();
                        foreach (var boolean in booleans)
                        {
                            if (bool.Parse(answer) == bool.Parse(boolean.Answer))
                            {
                                return Task.FromResult(boolean.Score);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            return Task.FromResult(0);
        }
    }
}
