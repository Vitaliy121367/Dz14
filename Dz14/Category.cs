namespace Dz14
{
    public class Category
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"\tCategory\nId: {Id}\nCategory: {Name}";
        }
    }
}
