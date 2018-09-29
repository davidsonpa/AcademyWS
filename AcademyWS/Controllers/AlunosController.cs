using AcademyWS;
using System.Web.Http;

namespace AcademyWs.Controllers
{

    public class AlunosController : ApiController
    {
        Connection db = new Connection();

        [HttpGet]
        [ActionName("list")]
        public IHttpActionResult GetAlunos()
        {
            var alunos = db.Alunos;
            return Ok(alunos);
        }


        [HttpGet]
        [ActionName("Autenticar")]
        public IHttpActionResult AutenticaAluno(string email, string senha)
        {
            if (email == "" || senha == "")
                BadRequest("E-mail ou Senha não informados, verifique");

            /*DbSqlQuery<Aluno> aluno = db.alunos.SqlQuery("Select idaluno, email, senha from aluno where email = @email");
            foreach (var ret in aluno)
            {
                if (aluno == null)
                    return NotFound();
                if (ret.email != email || ret.senha != senha)
                    return NotFound();

                return Json(aluno);
            }*/

            Aluno aluno = db.Alunos.Find(email);
                if (aluno == null)
                    return NotFound();
                if (aluno.email != email || aluno.senha != senha)
                    return NotFound();

                return Ok(aluno.email);
        }

    }
}
