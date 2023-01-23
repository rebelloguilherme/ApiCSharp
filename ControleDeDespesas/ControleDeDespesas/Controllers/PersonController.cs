using ControleDeDespesas.Domain.Models;
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
        public ActionResult<List<Person>> Get()
        {
            var people = new List<Person>();
            var role = new Role();
            role.Permission = Permission.Admin;

            var person = new Person("0123456789", "Edivan", "012345", role);
            people.Add(person);
            return people;
        }

        //new Person
        [HttpPost]
        public JsonContent Create(string document, string name, string password, Role role)
        {
            var person = new Person(document, name, password, role);
            return JsonContent.Create(person);
        }

        //Update a Person
        [HttpPost]
        public JsonContent Update(Person person)
        {
            //seach person related
            //person that suposed to be found
            var personFound = new Person("0123456789", "Edivan", "012345", new Role() { Permission = Permission.Admin });

            if (person.Id == personFound.Id)
            {
                if (person.Name != personFound.Name)
                {
                    personFound.Name = person.Name;
                }
                if (person.Password != personFound.Password)
                {
                    personFound.Password = person.Password;
                }
            }
            return JsonContent.Create(personFound);
        }

        //Remove a Person
        [HttpPost]
        public JsonContent Delete(Guid id)
        {
            //seach person related
            //person that suposed to be found
            var personFound = new Person("0123456789", "Edivan", "012345", new Role() { Permission = Permission.Admin });

            if (personFound.Id == id)
            {
                return JsonResult(
            }
            return JsonContent.Create(personFound);
        }
    }
}
