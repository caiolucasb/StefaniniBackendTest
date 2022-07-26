namespace ST.CrossCutting.DTO
{
    public class PersonTO
    {
        public PersonTO() { }

        public PersonTO(int id, string name, int age, string cpf, int cityId) 
        {
            Id = id;
            Name = name;
            Age = age;
            CPF = cpf;
            CityId = cityId;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string CPF { get; set; } = null!;
        public int CityId { get; set; }
    }
}
