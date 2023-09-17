namespace ToDo.System.Domain.Entities
{
    public class Category
    {
        public String? Name { get; }

        public DateTime? CreatedAt { get; }

        public DateTime? UpdatedAt { get; }

        public Category()
        {
        }

        public Category(String name)
        {
            this.Name = name;
            CreatedAt = DateTime.Now;
        }
    }
}
