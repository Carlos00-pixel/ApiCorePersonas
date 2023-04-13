using ApiCorePersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCorePersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        List<Persona> personas;

        public PersonasController()
        {
            this.personas = new List<Persona>
            {
                new Persona { IdPersona = 1, Nombre = "Luis", Email = "luis@gmail.com", Edad = 40 },
                new Persona { IdPersona = 2, Nombre = "Carlos", Email = "carlos@gmail.com", Edad = 12 },
                new Persona { IdPersona = 3, Nombre = "Lucia", Email = "lucia@gmail.com", Edad = 20 },
                new Persona { IdPersona = 4, Nombre = "Javat", Email = "javat@gmail.com", Edad = 30 },
                new Persona { IdPersona = 5, Nombre = "Paco", Email = "paco@gmail.com", Edad = 45 }
            };
        }

        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            return this.personas;
        }

        //PARA PODER UTILIZAR EL METODO GET(ID)
        //DEBEMOS DECORAR CON EL SIGUIENTE ATRIBUTO
        // [HttpGet("{id}")]
        [HttpGet("{id}")]
        public ActionResult<Persona> FindPersona(int id)
        {
            return this.personas.FirstOrDefault(x => x.IdPersona == id);
        }
    }
}
