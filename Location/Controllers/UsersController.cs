using Location.Data;
using Location.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Route("GetUser")]

        public async Task<List<Users>> GetUsers([FromServices] DataContext context)
        {
            return context.tblUsers.ToList();
        }

        [HttpPost]
        [Route("AddUser")]
        public async Task<ActionResult<Users>> AddUsers([FromServices] DataContext context, [FromBody] Users modelUsers)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.tblUsers.Add(modelUsers);
                    await context.SaveChangesAsync();
                    return modelUsers;
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpDelete]
        [Route("RemoveUser/{Id}")]
        public async Task RemoveUsers([FromServices] DataContext context, [FromRoute] string Id)
        {
            try
            {
                var film = context.tblUsers.FirstOrDefault(e => e.Id == Id);
                context.tblUsers.Remove(film);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }
        [HttpPut]
        [Route("UpdateUser/{Id}")]
        public async Task UpdateUsers([FromServices] DataContext context, [FromRoute] string Id, [FromBody] Users modelUsers)
        {
            try
            {
                var users = context.tblUsers.FirstOrDefault(e => e.Id == Id);
                users.Name = modelUsers.Name;


                context.tblUsers.Update(users);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }

        }
    }
}

