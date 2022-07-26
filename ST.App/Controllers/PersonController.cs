using Microsoft.AspNetCore.Mvc;
using ST.CrossCutting.Interfaces.Repositories;
using ST.CrossCutting.DTO;

namespace ST.App.Controllers
{
    [ApiController]
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
        public async Task<PersonTO> GetPerson(int id)
        {
            return await _personRepository.ReadPerson(id);
        }
        [HttpPost("Person")]
        public async Task PostPerson([FromBody] PersonTO person)
        {
            await _personRepository.CreatePerson(person);
        }
        [HttpPut("Person/{id}")]
        public async Task PutPerson(int id,[FromBody] PersonTO person)
        {
            await _personRepository.UpdatePerson(id,person);
        }
        [HttpDelete("Person")]
        public async Task DeletePerson(int id)
        {
            await _personRepository.DeletePerson(id);
        }
        [HttpGet("City/{id}")]
        public async Task<CityTO> GetCity(int id)
        {
            return await _personRepository.ReadCity(id);
        }
        [HttpPost("City")]
        public async Task PostCity([FromBody] CityTO city)
        {
            await _personRepository.CreateCity(city);
        }
        [HttpPut("City")]
        public async Task PutCity(int id,[FromBody] CityTO city)
        {
            await _personRepository.UpdateCity(id, city);
        }
    }
}