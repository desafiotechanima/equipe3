using AnimaTechAPI.Models;
using AnimaTechAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AnimaTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private Service _service = new Service();

        [HttpGet]
        public ActionResult<List<Playlist>> Get()
        {
            var playlists = _service.GetPlaylists();
            if (playlists.Count == 0)
                return BadRequest("Nenhuma playlist encontrada.");
            return Ok(playlists);
        }
        [HttpPost]
        public ActionResult Post([FromBody] Playlist playlist)
        {
            var play = _service.PostPlaylist(playlist);
            if (play == null)
                return BadRequest("Dados fora do padrão desejado ou playlist já existente.\n " + JsonConvert.SerializeObject(playlist));
            else
                return Ok("Playlist cadastrada com sucesso.\n " + JsonConvert.SerializeObject(play.Nome));
        }
    }
}
