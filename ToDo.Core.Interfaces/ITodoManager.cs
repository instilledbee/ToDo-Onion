using System.Collections.Generic;
using ToDo.Core.Models;

namespace ToDo.Core.Interfaces
{
    public interface IToDoManager
    {
        ToDoItem Get(int id);

        ToDoItem Create(string title, string description);

        IEnumerable<ToDoItem> GetAll();

        bool Modify(ToDoItem item);

        bool Delete(int id);

        bool Complete(int id);
    }
}