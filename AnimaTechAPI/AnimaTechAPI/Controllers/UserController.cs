using Microsoft.AspNetCore.Mvc;
using FluentResults;
using AnimaTechAPI.Services;
using AnimaTechAPI.Models;
using Newtonsoft.Json;

namespace AnimaTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private Service _service = new Service();

        [HttpGet]
        public ActionResult<Usuario> Get([FromQuery] string Email)
        {
            var user = _service.GetByEmail(Email);
            if (user == null || user.Nome == null)
                return BadRequest("Usuário não localizado, verifique o email.\n " + Email);

            return Ok(user);
        }
        [HttpPost]
        public ActionResult Post([FromBody] Usuario user)
        {
            var usuario = _service.PostUser(user);
            if (usuario == null)
                return BadRequest("Dados fora do padrão desejado ou usuario já existente.\n " + JsonConvert.SerializeObject(user));
            else
                return Ok("Usuario cadastrado com sucesso.\n " + JsonConvert.SerializeObject(usuario.Email));
        }
    }
}
