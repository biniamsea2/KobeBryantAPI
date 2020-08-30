using KobeAPI.Models;
using KobeAPI.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KobeController : ControllerBase
    {
        private readonly IKobe _context;

        public KobeController(IKobe kobe)
        {
            _context = kobe;
        }

        //GET api/records
        [HttpGet]
        public ActionResult <IEnumerable<Kobe>> GetAllRecords()
        {
            var kobeRecords = _context.GetAllRecords();
            return Ok(kobeRecords);
        }

        //GET api/record/{id}
        //these are two different end points
        [HttpGet("{id}")]
        public ActionResult <Kobe> GetRecordbyId(int id)
        {
            var kobeRecord = _context.GetOneRecord(id);
            return Ok(kobeRecord);

        }
    }
}
