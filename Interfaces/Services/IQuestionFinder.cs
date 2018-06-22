using Interfaces.Entities;

namespace Interfaces.Services
{
    public interface IQuestionFinder
    {
        IQuestion GetQuestion(ICard card, ICategory category);
    }
}