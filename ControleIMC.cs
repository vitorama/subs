using Microsoft.AspNetCore.Mvc;

{
    [ApiController]
    [Route("api/imc")]
    public class ControleIMC : ControllerBase
    {
        private static readonly List<IMC> IMCs = new();

        [HttpPost("cadastrar")]
        public IActionResult CadastrarIMC([FromBody] IMC imc)
        {
            imc.Id = IMCs.Count + 1;
            IMCs.Add(imc);
            return Ok(imc);
        }

        [HttpGet("listar")]
        public IActionResult ListarIMCs()
        {
            return Ok(IMCs);
        }

        [HttpGet("listarporaluno/{alunoId}")]
        public IActionResult ListarIMCsPorAluno(int alunoId)
        {
            var imcsAluno = IMCs.Where(imc => imc.AlunoId == alunoId).ToList();
            return Ok(imcsAluno);
        }

        [HttpPut("alterar/{id}")]
        public IActionResult AlterarIMC(int id, [FromBody] IMC novoImc)
        {
            var imc = IMCs.FirstOrDefault(i => i.Id == id);
            if (imc == null)
            {
                return NotFound();
            }

            imc.Peso = novoImc.Peso;
            imc.Altura = novoImc.Altura;
            return Ok(imc);
        }
    }
}
