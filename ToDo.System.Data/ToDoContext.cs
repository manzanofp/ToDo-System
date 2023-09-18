using Microsoft.EntityFrameworkCore;

namespace ToDo.System.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public class User
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }
    }
}