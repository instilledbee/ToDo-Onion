using System.Collections.Generic;
using ToDo.Core.Models;

namespace ToDo.Core.Interfaces
{
    public interface IToDoManager
    {
        ToDoItem Get(int id);

        ToDoItem Create(string title, string description);

        IEnumerable<ToDoItem> GetAll();

        bool Update(ToDoItem item);

        bool Delete(int id);
    }
}