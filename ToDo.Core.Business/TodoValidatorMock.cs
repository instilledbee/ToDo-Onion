using System;
using System.Collections.Generic;
using Todo.Core.Interfaces;
using Todo.Core.Models;

namespace Todo.Core.Business
{
    public class TodoValidatorMock : ITodoValidator
    {
        // Business rule: To-do descriptions are optional
        public bool IsValidDescription(string description) =>
            // descriptions are optional
            true;

        // Business rule: To-do titles should not be empty
        public bool IsValidTitle(string title) => !String.IsNullOrEmpty(title);
    }
}
