using System;

namespace Todo.Core.Interfaces
{
    public interface ITodoValidator
    {
        bool IsValidTitle(string title);

        bool IsValidDescription(string description);
    }
}