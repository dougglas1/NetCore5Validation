using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore5Validation.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5Validation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet("{codigo}")]
        public IActionResult GetByCodigo(int codigo)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Inserir(Categoria categoria)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Atualizar(Categoria categoria)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Remover(int codigo)
        {
            return Ok();
        }
    }
}
