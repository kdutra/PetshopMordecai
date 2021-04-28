using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetshopMordecai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceiroController : ControllerBase
    {
        // GET: api/<VendasController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "financeiro1", "financeiro2" };
        }
    }
}
