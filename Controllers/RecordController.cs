using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial.Models;

namespace record_manager_api.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/records")]
    public class RecordController : Controller
    {

        private readonly RecordContext _context;

        public RecordController(RecordContext context) {
            _context = context;
        }

        // GET api/v1/records
        [HttpGet]
        public async Task<IActionResult> getAll() {
            var records = await _context.Records.ToListAsync();
            
            return Ok(records); 
        }

    }
}
