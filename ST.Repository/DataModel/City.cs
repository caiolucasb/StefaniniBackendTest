namespace ST.Repository.DataModel
{
    public class City
    {
        public City()
        {
            Person = new List<Person>();
        }
        public City(string name, string uf)
        {
            Name = name;
            UF = uf;
            Person = new List<Person>();
        }
        public City(string name, string uf, List<Person> list)
        {
            Name = name;
            UF = uf;
            Person = list;
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string UF { get; set; } = null!;
        public ICollection<Person> Person { get; set; }
    }
}
