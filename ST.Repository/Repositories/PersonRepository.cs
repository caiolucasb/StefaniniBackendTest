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
        public async Task CreatePerson(PersonTO person)
        {
            var personData = new Person(person.Name, person.Age, person.CPF, person.CityId);
            await _personContext.AddAsync(personData);
            await _personContext.SaveChangesAsync();
        }
        public async Task<PersonTO> ReadPerson(int id)
        {
            var personData = await _personContext.People.Where(x => x.Id == id).FirstOrDefaultAsync() ?? new Person();
            var personTO = new PersonTO(personData.Id,  personData.Name, personData.Age, personData.CPF, personData.CityId);
            return personTO;
        }
        public async Task UpdatePerson(int id,PersonTO person)
        {
            var personData = await _personContext.People.Where(x => x.Id == id).FirstOrDefaultAsync();
            if(personData != null)
            {
                personData.Name = person.Name;
                personData.Age = person.Age;
                personData.CPF = person.CPF;
                personData.CityId = person.CityId;

                _personContext.People.Update(personData);
            }
            await _personContext.SaveChangesAsync();
        }
        public async Task DeletePerson(int id)
        {
            var personData = await _personContext.People.Where(x => x.Id == id).FirstOrDefaultAsync();
            _personContext.People.Remove(personData);
            await _personContext.SaveChangesAsync();
        }
        public async Task<CityTO> ReadCity(int id)
        {
            var cityData = await _personContext.Cities.Where(x => x.Id == id).FirstOrDefaultAsync() ?? new City();
            var cityTO = new CityTO(cityData.Id, cityData.Name, cityData.UF);
            return cityTO;
        }
        public async Task CreateCity(CityTO city)
        {
            var cityData = new City(city.Name, city.UF);
            await _personContext.AddAsync(cityData);
            await _personContext.SaveChangesAsync();
        }
        public async Task UpdateCity(int id,CityTO city)
        {
            var cityData = await _personContext.Cities.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (cityData != null)
            {
                cityData.Name = city.Name;
                cityData.UF = city.UF;
                _personContext.Cities.Update(cityData);
            }
            await _personContext.SaveChangesAsync();
        }
    }
}
