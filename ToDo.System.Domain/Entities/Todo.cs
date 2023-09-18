namespace ToDo.System.Domain.Entities
{
    public class Todo
    {
        public String Title { get; }

        public String Description { get; }

        public DateTime? CreationAt { get; }

        private Boolean Done { get; set; }

        public DateTime? FinishedAt { get; }

        public DateTime? UpdatedAt { get; private set; }

        public List<Category> Categories { get; } = new List<Category>();

        public List<Comment> Comments { get; } = new List<Comment>();

        public User User { get; }

        public DateTime? Deadline { get; set; }

        public Todo()
        {
            CreationAt = null;
        }

        public Todo(string title, string description, User user)
        {
            this.Title = title;
            this.Description = description;
            CreationAt = DateTime.Now;
            Done = false;
            this.User = user;
        }

        public void Check()
        {
            Done = true;
            UpdatedAt = DateTime.Now;
        }

        public Boolean IsDone()
        {
            return this.Done;
        }

        public void Uncheck()
        {
            Done = false;
            UpdatedAt = DateTime.Now;
        }

        public bool IsDeadline()
        {
            var now = DateTime.Now;

            return now >= Deadline;
        }
    }
}
