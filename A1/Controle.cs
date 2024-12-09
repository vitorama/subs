using Microsoft.AspNetCore.Mvc;

{
    [ApiController]
    [Route("api/aluno")]
    public class Controle : Controle
    {
        private static readonly List<Aluno> Alunos = new();

        [HttpPost("cadastrar")]
        public IActionResult CadastrarAluno([FromBody] Aluno aluno)
        {
            aluno.Id = Alunos.Count + 1;
            Alunos.Add(aluno);
            return Ok(aluno);
        }
    }
}
