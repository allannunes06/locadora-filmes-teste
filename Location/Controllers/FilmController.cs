using Location.Data;
using Location.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.Controllers
{
    public class FilmController : ControllerBase
    {
        [HttpGet]
        [Route("GetFilm")]

        public async Task<List<Film>> GetFilm([FromServices] DataContext context)
        {
            return context.tblFilm.ToList();
        }

        [HttpPost]
        [Route("AddFilm")]
        public async Task<ActionResult<Film>> AddFilme([FromServices] DataContext context, [FromBody] Film model)
        {
            if (ModelState.IsValid)
            {
                context.tblFilm.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("RemoveFilm/{id}")]
        public async Task RemoveFilm([FromServices] DataContext context, [FromRoute] string Id)
        {
            try
            {
                var film = context.tblFilm.FirstOrDefault(e => e.Id == Id);
                context.tblFilm.Remove(film);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }

        [HttpPut]
        [Route("UpdateFilm/{id}")]
        public async Task UpdateFilm([FromServices] DataContext context, [FromRoute] string Id, [FromBody] Film model)
        {
            try
            {
                var film = context.tblFilm.FirstOrDefault(e => e.Id == Id);
                film.Title = model.Title;

                context.tblFilm.Update(film);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }
    }
}
