using ToDo.System.Domain.Entities;

namespace ToDo.System.Domain.Tests
{
    public class TodoTests
    {
        private Todo todo = new Todo();

        [Fact]
        public void CanCreateTodo()
        {
            var todo = new Todo("Title", "Description", new User());
            Assert.Equal("Title", todo.Title);
            Assert.Equal("Description", todo.Description);
            Assert.Equal(DateTime.Now.ToShortDateString(), todo.CreationAt?.ToShortDateString());
            Assert.False(todo.IsDone());
            Assert.Null(todo.FinishedAt);
            Assert.Null(todo.UpdatedAt);
            Assert.Empty(todo.Categories);
            Assert.Empty(todo.Comments);
            Assert.NotNull(todo.User);
            Assert.Null(todo.Deadline);
        }

        [Fact]
        public void CanCreateEmptyTodo()
        {
            Assert.Null(todo.Title);
            Assert.Null(todo.Description);
            Assert.Null(todo.CreationAt);
            Assert.Null(todo.UpdatedAt);
            Assert.False(todo.IsDone());
            Assert.Empty(todo.Categories);
            Assert.Empty(todo.Comments);
            Assert.Null(todo.User);
            Assert.Null(todo.Deadline);
        }

        [Fact]
        public void AfterCheck_willDone()
        {
            todo.Check();
            Assert.True(todo.IsDone());
            Assert.Equal(DateTime.Now.ToShortDateString(), todo.UpdatedAt?.ToShortDateString());
        }


        [Fact]
        public void AfterUncheck_IsNotDone()
        {
            todo.Uncheck();
            Assert.False(todo.IsDone());
            Assert.Equal(DateTime.Now.ToShortDateString(), todo.UpdatedAt?.ToShortDateString());
        }

        [Fact]
        public void AfterCheckAndUncheck_IsNotDone()
        {
            todo.Check();
            Assert.True(todo.IsDone());

            todo.Uncheck();
            Assert.False(todo.IsDone());
        }

        [Fact]
        public void AfterGetDateNow_willDeadlineWhenDateNowGreatherThanDeadline()
        {
            todo.Deadline = DateTime.Now.AddHours(-1);
            Assert.True(todo.IsDeadline());
        }

        [Fact]
        public void AfterGetDateNow_willDeadlineWhenDateNowLessThanDeadline()
        {
            todo.Deadline = DateTime.Now.AddHours(1);
            Assert.False(todo.IsDeadline());
        }
    }
}
