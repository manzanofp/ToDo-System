using MediatR;
using ToDo.System.Application.ToDo.Requests;
using ToDo.System.Domain.Entities;

namespace ToDo.System.Application.ToDo.Handler
{
    public class CreateTodoRequestHandler : IRequestHandler<CreateTodoRequest, Todo>
    {
        public async Task<Todo> Handle(CreateTodoRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
