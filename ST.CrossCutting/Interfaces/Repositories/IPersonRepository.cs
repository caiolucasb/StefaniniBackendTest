using ST.CrossCutting.DTO;

namespace ST.CrossCutting.Interfaces.Repositories
{
    public interface IPersonRepository
    {
        Task PostPerson(PersonTO person);
        Task<PersonTO> GetPerson(int id);
        Task UpdatePerson(PersonTO person);
        Task DeletePerson(int id);
        Task<CityTO> GetCity(int id);
        Task PostCity(CityTO city);
        Task UpdateCity(CityTO city);
    }
}
