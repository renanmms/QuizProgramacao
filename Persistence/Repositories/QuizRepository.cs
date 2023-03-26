using System.Data.SqlClient;
using Dapper;
using Quiz_Programacao.Entities;

namespace Quiz_Programacao.Persistence.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public QuizRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("QuizProgramacao");
        }

        public List<Pergunta> ObterPerguntas()
        {
            var parametros = new DynamicParameters();
            
            using(var db = new SqlConnection(connectionString)){
                var sql = @$"
                    select
                        id_pergunta as Id,
                        pergunta_descricao as Descricao
                    from
                        quiz; 
                ";

                return db.Query<Pergunta>(sql).ToList();
            }
        }
    }
}