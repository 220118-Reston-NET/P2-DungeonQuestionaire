using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using BL;

using DL;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        private IPlayerBL _repo;
        public PlayerController(IPlayerBL p_repo)
        {

            _repo = p_repo;
        }
        // GET: api/Player
        [HttpGet("GetAllPlayers")]
        public async Task<IActionResult> GetAllPlayers()
        {
            return Ok(await _repo.GetAllPlayers());
        }

        // GET: api/Player/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Player
        [HttpPost("AddPlayer")]
        public async Task<IActionResult> Post([FromBody] Player p_Player)
        {
            return Ok(await _repo.AddPlayer(p_Player));
        }

        // PUT: api/Player/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Player/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
