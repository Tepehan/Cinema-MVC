using Business.Concrete;
using DataAccesLayer;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity.Infrastructure;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
      
        FilmManagerBL filmManagerBL = new FilmManagerBL(new EfFilmDal());

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return filmManagerBL.ListBL();
           
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Film film = filmManagerBL.GetByIdBL(id);
            if (film == null)
            {
                return NotFound();
            }

            return Ok(film);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Film film)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            filmManagerBL.AddBL(film);

            return CreatedAtRoute("DefaultApi", new { id = film.filmId }, film);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Film film)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != film.filmId)
            {
                return BadRequest();
            }

           

            try
            {
                filmManagerBL.UpdateBL(film);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (filmManagerBL.GetByIdBL(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            Film film = filmManagerBL.GetByIdBL(id);
            if (film == null)
            {
                return NotFound();
            }

            filmManagerBL.DeleteBL(film);

            return Ok(film);
        }
    }
}
