using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id=1,
                Nome="Marcos",
                Sobrenome="Almeida",
                Telefone="12121212"
            },
            new Aluno(){
                Id=2,
                Nome="Marta",
                Sobrenome="Almeida",
                Telefone="12121212"
            },
            new Aluno(){
                Id=3,
                Nome="Laura",
                Sobrenome="Almeida",
                Telefone="12121212"
            }
        };

        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }
    }
}