using System;

namespace ToDo.Core.Interfaces
{
    public interface IToDoValidator
    {
        bool IsValidTitle(string title);

        bool IsValidDescription(string description);
    }
}