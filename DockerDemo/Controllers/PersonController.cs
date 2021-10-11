using DockerDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            using (var context = new ApplicationDbContext())
            {
                
                // get all
                return context.People.ToList();
            }
        }
    }
}
