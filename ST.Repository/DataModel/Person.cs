namespace ST.Repository.DataModel
{
    public class Person
    {
        public Person()
        {
        }
        public Person(int id, string name, string cpf, int age, int cityId)
        {
            Id = id;
            Name = name;
            CPF = cpf;
            Age = age;
            CityId = cityId;
        }
        public Person(string name, string cpf, int age, int cityId)
        {
            Name = name;
            CPF = cpf;
            Age = age;
            CityId = cityId;
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string CPF { get; set; } = null!;
        public int Age { get; set; }
        public int CityId { get; set; }
        public City City { get; set; } = null!;
    }
}
