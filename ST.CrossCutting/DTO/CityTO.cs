namespace ST.CrossCutting.DTO
{
    public class CityTO
    {
        public CityTO() { }

        public CityTO(int id, string name, string uf)
        {
            Id = id;
            Name = name;
            UF = uf;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string UF { get; set; } = null!;
    }
}
