using ST.CrossCutting.Interfaces.Services;
using ST.CrossCutting.Interfaces.Repositories;
using ST.CrossCutting.DTO;
using ST.CrossCutting.Models;

namespace ST.Service.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<ReturnObject<PersonTO>> GetPerson(int id)
        {
            try
            {
                var person = await _personRepository.ReadPerson(id);

                if (id == 0 || person == null)
                {
                    return new ReturnObject<PersonTO>(false, Message.EmptyERRO, null);
                }

                return new ReturnObject<PersonTO>(true, String.Empty , person);
            }
            catch (Exception ex)
            {
                return new ReturnObject<PersonTO>(false, Message.ERRO, null);
            }
        }
        public async Task<ReturnObject<PersonTO>> PostPerson(PersonTO person)
        {
            try
            {
                if(person.CityId == 0 || person.Name == "" || person.CPF == "" || person.Age == 0)
                {
                    return new ReturnObject<PersonTO>(false, Message.WrongParmsERRO, null);
                }
                await _personRepository.CreatePerson(person);
                return new ReturnObject<PersonTO>(true, String.Empty, null);
            }
            catch (Exception ex)
            {
                return new ReturnObject<PersonTO>(false, Message.ERRO, null);
            }
            
        }
        public async Task<ReturnObject<PersonTO>> PutPerson(int id, PersonTO person)
        {
            try
            {
                if (person.CityId == 0 || person.Name == "" || person.CPF == "" || person.Age == 0)
                {
                    return new ReturnObject<PersonTO>(false, Message.WrongParmsERRO, null);
                }
                await _personRepository.UpdatePerson(id, person);
                return new ReturnObject<PersonTO>(true, String.Empty, null);
            }
            catch (Exception ex)
            {
                return new ReturnObject<PersonTO>(false, Message.ERRO, null);
            }
        }
        public async Task<ReturnObject<PersonTO>> DeletePerson(int id)
        {
            try
            {
                if(id == 0)
                {
                    return new ReturnObject<PersonTO>(false, Message.EmptyERRO, null);
                }
                await _personRepository.DeletePerson(id);
                return new ReturnObject<PersonTO>(true, String.Empty, null);
            }
            catch (Exception ex)
            {
                return new ReturnObject<PersonTO>(false, Message.ERRO, null);
            }
        }
        public async Task<ReturnObject<CityTO>> GetCity(int id)
        {
            try
            {
                var city = await _personRepository.ReadCity(id);
                if (id == 0 || city == null)
                {
                    return new ReturnObject<CityTO>(false, Message.EmptyERRO, null);
                }
                return new ReturnObject<CityTO>(true, String.Empty, city);

            }
            catch (Exception ex)
            {
                return new ReturnObject<CityTO>(false, Message.ERRO, null);
            }
        }
        public async Task<ReturnObject<CityTO>> PostCity(CityTO city)
        {
            try
            {
                if (city.Name == "" || city.UF == "")
                {
                    return new ReturnObject<CityTO>(false, Message.WrongParmsERRO, null);
                }
                await _personRepository.CreateCity(city);
                return new ReturnObject<CityTO>(true, String.Empty, null);
            }
            catch (Exception ex)
            {
                return new ReturnObject<CityTO>(false, Message.ERRO, null);
            }
        }
        public async Task<ReturnObject<CityTO>> PutCity(int id, CityTO city)
        {
            try
            {
                if (city.Name == "" || city.UF == "")
                {
                    return new ReturnObject<CityTO>(false, Message.WrongParmsERRO, null);
                }
                await _personRepository.UpdateCity(id, city);
                return new ReturnObject<CityTO>(true, String.Empty, null);
            }
            catch (Exception ex)
            {
                return new ReturnObject<CityTO>(false, Message.ERRO, null);
            }
        }
    }
}
