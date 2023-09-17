using MediatR;
using ToDo.System.Domain.Entities;

namespace ToDo.System.Application.ToDo.Requests
{
    public class CreateTodoRequest : IRequest<Todo>
    {
        public string? TodoRequest { get; set; }
    }
}
