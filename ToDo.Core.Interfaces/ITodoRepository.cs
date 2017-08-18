using System.Collections.Generic;
using ToDo.Core.Models;

namespace ToDo.Core.Interfaces
{
    public interface IToDoRepository : IRepository<int, ToDoItem>
    {
    }
}
