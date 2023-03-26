using System;
using Quiz_Programacao.Entities;

namespace Quiz_Programacao.Persistence
{
    public interface IQuizRepository
    {
        List<Pergunta> ObterPerguntas();
    }
}