using ToDo.System.Domain.Entities;

namespace ToDo.System.Domain.Tests
{
    public class UserTests
    {
        [Fact]
        public void CanCreateUser()
        {
            var user = new User("Felipe Manzano", "felipemanzano@email.com", "55+ 11 12345 6789");
            Assert.Equal("Felipe Manzano", user.Name);
            Assert.Equal("felipemanzano@email.com", user.Email);
            Assert.Equal("55+ 11 12345 6789", user.Sms);
            Assert.Equal(DateTime.Now.ToShortDateString(), user.CreatedAt?.ToShortDateString());
            Assert.Null(user.UpdatedAt);
            Assert.Empty(user.Todos);
            Assert.Empty(user.Comments);
        }


        [Fact]
        public void CanCreateEmptyUser()
        {
            var user = new User();
            Assert.Null(user.Name);
            Assert.Null(user.Email);
            Assert.Null(user.Sms);
            Assert.Null(user.CreatedAt);
            Assert.Null(user.UpdatedAt);
            Assert.Empty(user.Todos);
            Assert.Empty(user.Comments);
        }
    }
}
