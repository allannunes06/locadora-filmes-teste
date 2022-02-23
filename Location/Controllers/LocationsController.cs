using Location.Data;
using Location.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.Controllers
{
    public class LocationsController : ControllerBase
    {
        [HttpGet]
        [Route("GetLocations")]
        public async Task<List<Locations>> GetLocations([FromServices] DataContext context)
        {
            return context.tblLocations.ToList();
        }

        [HttpPost]
        [Route("AddLocations")]
        public async Task<ActionResult<Locations>> AddLocacao([FromServices] DataContext context, [FromBody] Locations model)
        {
            DateTime dataDevolution;

            if (ModelState.IsValid)
            {
                context.tblLocations.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("RemoveLocations/{id}")]
        public async Task RemoveLocations([FromServices] DataContext context, [FromRoute] string Id)
        {
            try
            {
                var film = context.tblLocations.FirstOrDefault(e => e.Id == Id);
                context.tblLocations.Remove(film);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }


        [HttpPut]
        [Route("UpdateLocations/{id}")]
        public async Task UpdateLocations([FromServices] DataContext context, [FromRoute] string Id, [FromBody] Locations model)
        {
            try
            {
                var locations = context.tblLocations.FirstOrDefault(e => e.Id == Id);
                locations.IdUsers = model.IdUsers;
                locations.IdFilm = model.IdFilm;
                locations.DataLocations = model.DataLocations;

                context.tblLocations.Update(locations);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }
    }
}

