using ST.Repository.Context;
using ST.Repository.DataModel;
using ST.CrossCutting.Interfaces.Repositories;
using ST.CrossCutting.DTO;
using Microsoft.EntityFrameworkCore;

namespace ST.Repository.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonContext _personContext;
        public PersonRepository(PersonContext personContext)
        {
            _personContext = personContext;
        }
        public async Task PostPerson(PersonTO person)
        {
            var personData = new Person(person.Name, person.CPF, person.Age, person.CityId);
            await _personContext.AddAsync(personData);
            await _personContext.SaveChangesAsync();
        }
        public async Task<PersonTO> GetPerson(int id)
        {
            var personData = await _personContext.People.Where(x => x.Id == id).FirstOrDefaultAsync() ?? new Person();
            var personTO = new PersonTO(personData.Id,  personData.Name, personData.Age, personData.CPF, personData.CityId);
            return personTO;
        }
        public async Task UpdatePerson(PersonTO person)
        {
            var personData = new Person(person.Name, person.CPF, person.Age, person.CityId);
            _personContext.People.Update(personData);
            await _personContext.SaveChangesAsync();
        }
        public async Task DeletePerson(int id)
        {
            var personData = await _personContext.People.Where(x => x.Id == id).FirstOrDefaultAsync();
            _personContext.People.Remove(personData);
        }
        public async Task<CityTO> GetCity(int id)
        {
            var cityData = await _personContext.Cities.Where(x => x.Id == id).FirstOrDefaultAsync() ?? new City();
            var cityTO = new CityTO(cityData.Id, cityData.Name, cityData.UF);
            return cityTO;
        }
        public async Task PostCity(CityTO city)
        {
            var cityData = new City(city.Name, city.UF);
            await _personContext.AddAsync(cityData);
            await _personContext.SaveChangesAsync();
        }
        public async Task UpdateCity(CityTO city)
        {
            var cityData = new City(city.Name, city.UF);
            _personContext.Cities.Update(cityData);
            await _personContext.SaveChangesAsync();
        }
    }
}
