using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using BL;
using Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionBL _quesbl;
        public QuestionController(IQuestionBL p_quesbl)
        {
            _quesbl = p_quesbl;
        }


        /// <summary>
        /// Gets All Questions
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllQuestions")]
        public async Task<IActionResult> GetAllQuestions()
        {
            try
            {
                return Ok(await _quesbl.GetAllQuestions());
            }
            catch(SqlException)
            {
                return NotFound();
            }
        }


        
        /// <summary>
        /// Adds Question
        /// </summary>
        /// <param name="p_question"></param>
        /// <returns></returns>
        [HttpPost("AddQuestion")]
        public async Task<IActionResult> AddQuestion([FromBody]Question p_question)
        {
            try
            {
                return Ok(await _quesbl.AddQuestion(p_question));
            }
            catch(SqlException)
            {
                return NotFound();
            }
        }


        /// <summary>
        /// Updates Question
        /// </summary>
        /// <param name="p_question"></param>
        /// <returns></returns>
        [HttpPut("UpdateQuestion")]
        public async Task<IActionResult> UpdateQuestion([FromBody] Question p_question)
        {
            try
            {
                return Ok(await _quesbl.UpdateQuestion(p_question));
            }
            catch(SqlException)
            {
                return NotFound();
            }

        }


        /// <summary>
        /// Deletes Question
        /// </summary>
        /// <param name="p_question"></param>
        /// <returns></returns>
        [HttpDelete("DeleteQuestion")]
        public async Task<IActionResult> DeleteQuestion([FromBody] Question p_question)
        {
            try
            {
                return Ok(await _quesbl.DeleteQuestion(p_question));
            }
            catch(SqlException)
            {
                return NotFound();
            }

        }
    }
}
