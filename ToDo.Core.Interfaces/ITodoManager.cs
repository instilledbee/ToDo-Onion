using System.Collections.Generic;
using Todo.Core.Models;

namespace Todo.Core.Interfaces
{
    public interface ITodoManager
    {
        TodoItem Get(int id);

        TodoItem Create(string title, string description);

        IEnumerable<TodoItem> GetAll();

        bool Update(TodoItem item);

        bool Delete(int id);
    }
}