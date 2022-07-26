using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Repository.DataModel
{
    public class Person
    {
        public Person()
        {
        }
        public Person(int id, string name, int age, string cpf,  int cityId)
        {
            Id = id;
            Name = name;
            Age = age;
            CPF = cpf;
            CityId = cityId;
        }
        public Person(string name, int age, string cpf, int cityId)
        {
            Name = name;
            Age = age;
            CPF = cpf;
            CityId = cityId;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string CPF { get; set; } = null!;
        public int CityId { get; set; }
        public City City { get; set; } = null!;
    }
}
