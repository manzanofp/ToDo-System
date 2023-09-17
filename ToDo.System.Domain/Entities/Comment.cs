namespace ToDo.System.Domain.Entities
{
    public class Comment
    {
        public String Body { get; }

        public DateTime? CreatedDate { get; }

        public DateTime? UpdatedDate { get; }

        public User User { get; }

        public Todo Todo { get; }

        public Comment()
        {
        }

        public Comment(String body, User user, Todo todo)
        {
            this.Body = body;
            CreatedDate = DateTime.Now;
            this.User = user;
            this.Todo = todo;
        }
    }
}
