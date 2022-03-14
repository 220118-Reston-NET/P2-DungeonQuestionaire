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
        /// <summary>
        /// Gets All Players
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// Add Player
        /// </summary>
        /// <param name="p_Player"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Updates Player
        /// </summary>
        /// <param name="p_Player"></param>
        /// <returns></returns>
        [HttpPut("UpdatePlayer")]
        public async Task<IActionResult> Put(string SpriteImgurl, int PlayerHP, int EnemyCurrentlyFighting, string UserEmail, int UserVictories)
        {
            try
            {
                await _repo.UpdatePlayer(SpriteImgurl, PlayerHP, EnemyCurrentlyFighting, UserEmail, UserVictories);
                return Ok("Player Updated Successfully");

            }
            catch (SqlException)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Deletes Player
        /// </summary>
        /// <param name="p_Player"></param>
        /// <returns></returns>
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
