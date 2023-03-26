using System;

namespace Quiz_Programacao.Entities
{
    public class Pergunta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Verdadeiro { get; set; }
    }
}