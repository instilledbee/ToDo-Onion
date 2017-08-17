using System;

namespace Todo.Core.Models
{
    public class TodoItem
    {
        public int? ID { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsComplete { get; set; }
    }
}
