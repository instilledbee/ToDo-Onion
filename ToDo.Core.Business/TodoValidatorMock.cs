using System;
using System.Collections.Generic;
using ToDo.Core.Interfaces;
using ToDo.Core.Models;

namespace ToDo.Core.Business
{
    public class ToDoValidatorMock : IToDoValidator
    {
        // Business rule: To-do descriptions are optional
        public bool IsValidDescription(string description) =>
            // descriptions are optional
            true;

        // Business rule: To-do titles should not be empty
        public bool IsValidTitle(string title) => !String.IsNullOrEmpty(title);
    }
}
