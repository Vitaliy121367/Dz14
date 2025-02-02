namespace Dz14
{
    public class Buyer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Buyer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"Id: {Id}\nBuyer: {Name}";
        }
        public int CompareTo(Buyer? other)
        {
            if (Id < other.Id)
            {
                return -1;
            }
            if (Id > other.Id)
            {
                return 1;
            }
            return 0;
        }
    }
}
