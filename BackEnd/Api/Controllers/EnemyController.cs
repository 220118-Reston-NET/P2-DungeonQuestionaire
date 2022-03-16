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
        private readonly IEnemyBL _enemybl;
        public EnemyController(IEnemyBL p_enemybl)
        {
            _enemybl = p_enemybl;
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
                Log.Information("Successfully retrieved a list of all enemies from enemies.");
                return Ok(await _enemybl.GetAllEnemies());
            }
            catch(SqlException)
            {
                Log.Information("Failed to retrieve a list of enemies from database");
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
                Log.Information("Successfully added an enemy to the database");
                return Ok(await _enemybl.AddEnemy(p_enemy));
            }
            catch(SqlException)
            {
                Log.Information("Failed to add an enemy to the database");
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
                Log.Information("Successfully updated an enemy's information in the database");
                return Ok(await _enemybl.UpdateEnemy(p_enemy));
            }
            catch(SqlException)
            {
                Log.Information("Failed to update an enemy's information in the database");
                return NotFound();
            }

        }


        /// <summary>
        /// Deletes Enemy
        /// </summary>
        /// <param name="p_Enemy"></param>
        /// <returns></returns>
        [HttpDelete("DeleteEnemy")]
        public async Task<IActionResult> DeleteEnemy(Enemy p_enemy)
        {
            try
            {
                Log.Information("Successfully deleted an enemy's information from the database");
                return Ok(await _enemybl.DeleteEnemy(p_enemy));
            }
            catch(SqlException)
            {
                Log.Information("Failed to delete an enemy's information fromt he database");
                return NotFound();
            }

        }




    }
}
