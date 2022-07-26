using ST.CrossCutting.DTO;

namespace ST.CrossCutting.Interfaces.Repositories
{
    public interface IPersonRepository
    {
        Task CreatePerson(PersonTO person);
        Task<PersonTO> ReadPerson(int id);
        Task UpdatePerson(int id, PersonTO person);
        Task DeletePerson(int id);
        Task<CityTO> ReadCity(int id);
        Task CreateCity(CityTO city);
        Task UpdateCity(int id,CityTO city);
    }
}
