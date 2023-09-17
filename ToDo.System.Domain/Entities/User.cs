namespace ToDo.System.Domain.Entities
{
    public class User
    {
        public String Name { get; }

        public String Email { get; }

        public String Sms { get; }

        public DateTime? CreatedAt { get; }

        public DateTime? UpdatedAt { get; }

        public List<Todo> Todos { get; } = new List<Todo>();

        public List<Comment> Comments { get; } = new List<Comment>();

        public User()
        {
        }

        public User(String Name, String Email, String Sms)
        {
            this.Name = Name;
            this.Email = Email;
            this.Sms = Sms;
            CreatedAt = DateTime.Now;
        }
    }
}
