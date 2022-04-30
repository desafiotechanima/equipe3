using AnimaTechAPI.Models;
using AnimaTechAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AnimaTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private Service _service = new Service();
    
        [HttpGet]
        public ActionResult<List<Publicacao>> Get()
        {
            var posts = _service.GetAll();
            if (posts.Count == 0)
                return BadRequest();
    
            return Ok(posts);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Publicacao post)
        {
            var publicacao = _service.Post(post);
            if (publicacao == null)
                return BadRequest("Dados fora do padrão desejado ou usuario já existente.\n " + JsonConvert.SerializeObject(publicacao));
            else
                return Ok("Publicação cadastrado com sucesso.\n " + JsonConvert.SerializeObject(publicacao.Titulo));
        }
    }    
}
