using ControleDeDespesas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ControleDeDespesas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //List all People
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return new List<Person>();
        }

        //new Person
        [HttpPost]
        public JsonContent Create(string document, string name, string password, Role role)
        {
            var person = new Person(document, name, password, role);
            return JsonContent.Create(person);
        }

        //Update a Person

        //Remove a Person

    }
}
