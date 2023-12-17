using Lab15_C.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lab15_C.Controllers
{
    [ApiController]

    [Route("api/[controller]/[action]")]
    public class PeopleController : ControllerBase
    {
    [Authorize]
    [HttpGet(Name = "Get")]
        public IEnumerable<PersonResponse> Get()
        {
            List<PersonResponse> personas = new List<PersonResponse>();

            for (int i = 1; i <= 5; i++) 
            {
                PersonResponse persona = new PersonResponse();
                persona.FirstName = "Persona" + i;
                persona.LastName = "Apellido" + i; 
                
                personas.Add(persona);
            }
            return personas;
        }
        [HttpGet(Name = "Get2")]
        public IEnumerable<PersonResponse> Get2()
        {
            List<PersonResponse> personas = new List<PersonResponse>();
            for (int i = 1; i <= 5; i++)
            {
                PersonResponse persona = new PersonResponse();
                persona.FirstName = "Persona" + i;
                persona.LastName = "Apellido" + i;

                personas.Add(persona);
            }
            return personas;
        }
    }
}
