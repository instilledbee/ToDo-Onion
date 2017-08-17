using System.Collections.Generic;
using Todo.Core.Models;

namespace Todo.Core.Interfaces
{
    public interface ITodoRepository : IRepository<int, TodoItem>
    {
    }
}
