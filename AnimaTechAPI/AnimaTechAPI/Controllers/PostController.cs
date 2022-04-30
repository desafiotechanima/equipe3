using AnimaTechAPI.Models;
using AnimaTechAPI.Services;
using Microsoft.AspNetCore.Mvc;

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
    }    
}
