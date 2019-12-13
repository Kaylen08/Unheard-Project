using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnheardApi.Data;
using UnheardApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace UnheardApi.Controllers
{
    [Route("[controller]")]
    [Microsoft.AspNetCore.Mvc.ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll() =>
            _context.UserInfo.ToList();

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(long id)
        {
            var user = await _context.UserInfo.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public async Task<ActionResult<User>> Create(User user)
        {
            _context.UserInfo.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = user.ID }, user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, User user)
        {
            if (id != user.ID)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var user = await _context.UserInfo.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _context.UserInfo.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}