using Microsoft.AspNetCore.Mvc;
using ST.CrossCutting.Interfaces.Services;
using ST.CrossCutting.DTO;
using ST.CrossCutting.Models;

namespace ST.App.Controllers
{
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("Person/{id}")]
        public async Task<ReturnObject<PersonTO>> GetPerson(int id)
        {
            return await _personService.GetPerson(id);
        }
        [HttpPost("Person")]
        public async Task<ReturnObject<PersonTO>> PostPerson([FromBody] PersonTO person)
        {
            return await _personService.PostPerson(person);
        }
        [HttpPut("Person/{id}")]
        public async Task<ReturnObject<PersonTO>> PutPerson(int id,[FromBody] PersonTO person)
        {
            return await _personService.PutPerson(id,person);
        }
        [HttpDelete("Person")]
        public async Task<ReturnObject<PersonTO>> DeletePerson(int id)
        {
            return await _personService.DeletePerson(id);
        }
        [HttpGet("City/{id}")]
        public async Task<ReturnObject<CityTO>> GetCity(int id)
        {
            return await _personService.GetCity(id);
        }
        [HttpPost("City")]
        public async Task<ReturnObject<CityTO>> PostCity([FromBody] CityTO city)
        {
            return await _personService.PostCity(city);
        }
        [HttpPut("City")]
        public async Task<ReturnObject<CityTO>> PutCity(int id,[FromBody] CityTO city)
        {
            return await _personService.PutCity(id, city);
        }
    }
}