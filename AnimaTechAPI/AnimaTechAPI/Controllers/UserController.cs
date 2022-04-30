using Microsoft.AspNetCore.Mvc;
using FluentResults;
using AnimaTechAPI.Services;

namespace AnimaTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private Service _service;

        [HttpGet]
        public ActionResult<Usuario> Get([FromQuery] string Name)
        {
            var projectDTO = _service.GetByName(Name);
            if (projectDTO.Name == null)
                return BadRequest(projectDTO);
            return Ok(projectDTO);
        }


    }
}
