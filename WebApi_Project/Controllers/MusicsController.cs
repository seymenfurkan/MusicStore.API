using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MusicsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("list")]
        public IActionResult GetAll()
        {
            var list = _context.Musics.ToList();
            return Ok(list);
        }

        [HttpPost("add")]
        public IActionResult AddMusic(Music newMusic)
        {
            
            _context.Musics.Add(newMusic);
            var list = _context.Musics.ToList();
            if (list.Count > 0)
            {
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("delete")]
        public IActionResult DeleteMusic(int id)
        {
           var deleteToMusic = _context.Musics.Find(id);
            if (deleteToMusic is  null)
            {
                return BadRequest();
            }
            _context.Remove(deleteToMusic);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult UpdateMusic(Music music , int id)
        {
            var updateToMusic = _context.Musics.Find(music.Id);
            if (updateToMusic is null)
            {
                return BadRequest($"Bu id ({id}) ile eşleşen veri bulunamadı !");
            }
            updateToMusic.Musician = music.Musician;
            updateToMusic.Name = music.Name;
            _context.Update(updateToMusic);
            _context.SaveChanges();
            return Ok();
        }


    }
}

