using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using BL;
using DL;
using System.Data.SqlClient;

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
            try
            {
                return Ok(await _repo.GetAllPlayers());

            }
            catch (SqlException)
            {
                return NotFound();
            }
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
            try
            {
                return Created("Player Created Successfully", await _repo.AddPlayer(p_Player));

            }
            catch (SqlException)
            {
                return NotFound();
            }
        }

        // PUT: api/Player/5
        [HttpPut("UpdatePlayer")]
        public async Task<IActionResult> Put([FromBody] Player p_Player)
        {
            try
            {
                return Ok(await _repo.UpdatePlayer(p_Player));

            }
            catch (SqlException)
            {
                return NotFound();
            }
        }

        // DELETE: api/Player/5
        [HttpDelete("DeletePlayer")]
        public async Task<IActionResult> Delete(Player p_Player)
        {
            try
            {
                return Ok(await _repo.DeletePlayer(p_Player));

            }
            catch (SqlException)
            {
                return NotFound();
            }
        }
    }
}
