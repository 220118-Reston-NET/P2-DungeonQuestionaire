using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using BL;
using Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnemyController : ControllerBase
    {
        private readonly IEnemyBL _quesbl;
        public EnemyController(IEnemyBL p_quesbl)
        {
            _quesbl = p_quesbl;
        }


        /// <summary>
        /// Gets All Enemies
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllEnemies")]
        public async Task<IActionResult> GetAllEnemies()
        {
            try
            {
                return Ok(await _quesbl.GetAllEnemies());
            }
            catch(SqlException)
            {
                return NotFound();
            }
        }


        
        /// <summary>
        /// Adds Enemy
        /// </summary>
        /// <param name="p_Enemy"></param>
        /// <returns></returns>
        [HttpPost("AddEnemy")]
        public async Task<IActionResult> AddEnemy([FromBody]Enemy p_enemy)
        {
            try
            {
                return Ok(await _quesbl.AddEnemy(p_enemy));
            }
            catch(SqlException)
            {
                return NotFound();
            }
        }


        /// <summary>
        /// Updates Enemy
        /// </summary>
        /// <param name="p_Enemy"></param>
        /// <returns></returns>
        [HttpPut("UpdateEnemy")]
        public async Task<IActionResult> UpdateEnemy([FromBody] Enemy p_enemy)
        {
            try
            {
                return Ok(await _quesbl.UpdateEnemy(p_enemy));
            }
            catch(SqlException)
            {
                return NotFound();
            }

        }


        /// <summary>
        /// Deletes Enemy
        /// </summary>
        /// <param name="p_Enemy"></param>
        /// <returns></returns>
        [HttpDelete("DeleteEnemy")]
        public async Task<IActionResult> DeleteEnemy([FromBody] Enemy p_enemy)
        {
            try
            {
                return Ok(await _quesbl.DeleteEnemy(p_enemy));
            }
            catch(SqlException)
            {
                return NotFound();
            }

        }




    }
}
