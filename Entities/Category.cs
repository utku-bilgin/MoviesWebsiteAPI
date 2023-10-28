using Core.BaseEntities;

namespace Entities
{
    public class Category : BaseEntity
    {
        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public Category()
        {
            Movies = new HashSet<Movie>();
        }
    }
}
