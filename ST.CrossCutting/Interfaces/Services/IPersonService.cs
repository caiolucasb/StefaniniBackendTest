using ST.CrossCutting.DTO;
using ST.CrossCutting.Models;

namespace ST.CrossCutting.Interfaces.Services
{
    public interface IPersonService
    {
        Task<ReturnObject<PersonTO>> GetPerson(int id);
        Task<ReturnObject<PersonTO>> PostPerson(PersonTO person);
        Task<ReturnObject<PersonTO>> PutPerson(int id, PersonTO person);
        Task<ReturnObject<PersonTO>> DeletePerson(int id);
        Task<ReturnObject<CityTO>> GetCity(int id);
        Task<ReturnObject<CityTO>> PostCity(CityTO city);
        Task<ReturnObject<CityTO>> PutCity(int id, CityTO city);
    }
}