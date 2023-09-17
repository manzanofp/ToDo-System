using ToDo.System.Domain.Entities;

namespace ToDo.System.Domain.Tests
{
    public class CategoryTests
    {
        [Fact]
        public void CanCreateCategory()
        {
            var category = new Category("CategoryName");
            Assert.Equal("CategoryName", category.Name);
            Assert.Equal(DateTime.Now.ToShortDateString(), category.CreatedAt?.ToShortDateString());
            Assert.Null(category.UpdatedAt);
        }

        [Fact]
        public void CanCreateEmptyCategory()
        {
            var category = new Category();
            Assert.Null(category.Name);
            Assert.Null(category.CreatedAt);
            Assert.Null(category.UpdatedAt);
        }
    }
}
