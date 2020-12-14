using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DanskeIT.UnitTesting.Demo.Models;

namespace DanskeIT.UnitTesting.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            var customers = new List<Customer>();
            return Ok(customers);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Customer> Get(int id)
        {
            return Ok(new Customer {Name = "Test Customer"});
        }

        [HttpPost]
        public IActionResult Create([FromBody] Customer customer)
        {
            return Ok(new {Message = "Created"});
        }

        [HttpPut("{id:int}")]
        public IActionResult Update([FromBody] Customer customer, int id)
        {
            return Ok(new {Message = "Updated"});
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            if (id < 100)
            {
                return Ok(new {Message = "Deleted"});
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}
