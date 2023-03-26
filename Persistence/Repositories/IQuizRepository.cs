using Quiz_Programacao.Models;

namespace Quiz_Programacao.Persistence
{
    public interface IQuizRepository
    {
        List<PerguntaViewModel> ObterPerguntas();
    }
}