using Microsoft.AspNetCore.Mvc;
using ST.CrossCutting.Interfaces.Repositories;
using ST.CrossCutting.DTO;

namespace ST.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonRepository _personRepository;

        public PersonController(ILogger<PersonController> logger, IPersonRepository personRepository)
        {
            _logger = logger;
            _personRepository = personRepository;
        }

        [HttpGet("Person/{id}")]
        public async Task<PersonTO> Get(int id)
        {
            return await _personRepository.GetPerson(id);
        }
    }
}