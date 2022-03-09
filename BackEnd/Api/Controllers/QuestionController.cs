using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using BL;

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

        // // GET: api/Question
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET: api/Question/5
        // [HttpGet("GetAllQuestions")]
        // public async Task<IActionResult> GetAllQuestions( )
        // {
        //     try
        //     {
        //         return Ok(await _quesbl.GetAllQuestion());
        //     }
        //     catch(SqlException)
        //     {
        //         return NotFound();
        //     }
        // }


        // POST: api/Question
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Question/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Question/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
