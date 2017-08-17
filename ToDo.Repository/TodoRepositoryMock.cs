using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Core.Interfaces;
using Todo.Core.Models;

namespace Todo.Repository
{
    public class TodoRepositoryMock : ITodoRepository
    {
        private IList<TodoItem> context;

        public TodoRepositoryMock()
        {
            context = new List<TodoItem>();
            CreateMockData(context);
        }

        public bool Delete(int id)
        {
            return false;
        }

        public TodoItem Get(int id)
        {
            return context.Where(x => x.ID == id).SingleOrDefault();
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return context;
        }

        public TodoItem Save(TodoItem entity)
        {
            if (!entity.ID.HasValue) 
            {
                entity.ID = context.Count;
            }

            context[entity.ID.Value] = entity;

            return context[entity.ID.Value];
        }

        private void CreateMockData(IList<TodoItem> db)
        {
            db.Add(new TodoItem() {
                ID = 0,
                Title = "Update Design Document",
                Description = "Lorem ipsum dolor sit amet",
                IsComplete = false
            });

            db.Add(new TodoItem() {
                ID = 1,
                Title = "Create Webservice",
                Description = "Create To-Do Webservice",
                IsComplete = false
            });

            db.Add(new TodoItem() {
                ID = 2,
                Title = "Test",
                Description = "qwertyasdfgh",
                IsComplete = true
            });
        }
    }
}
