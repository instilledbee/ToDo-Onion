using System;

namespace ToDo.Core.Models
{
    public class ToDoItem
    {
        public int? ID { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsComplete { get; set; }
    }
}
