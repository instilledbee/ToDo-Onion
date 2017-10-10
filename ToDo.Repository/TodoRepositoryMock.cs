using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Core.Interfaces;
using ToDo.Core.Models;

namespace ToDo.Repository
{
    public class ToDoRepositoryMock : IToDoRepository
    {
        private IList<ToDoItem> context;

        public ToDoRepositoryMock()
        {
            context = new List<ToDoItem>();
            CreateMockData(context);
        }

        public bool Delete(int id)
        {
            return false;
        }

        public ToDoItem Get(int id)
        {
            return context.Where(x => x.ID == id).SingleOrDefault();
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            return context;
        }

        public ToDoItem Save(ToDoItem entity)
        {
            if (!entity.ID.HasValue) 
            {
                entity.ID = context.Count;
                context.Add(entity);
            }
            else 
            {
                 context[entity.ID.Value] = entity;
            }

            return context[entity.ID.Value];
        }

        private void CreateMockData(IList<ToDoItem> db)
        {
            db.Add(new ToDoItem() {
                ID = 0,
                Title = "Update Design Document",
                Description = "Lorem ipsum dolor sit amet",
                IsComplete = false
            });

            db.Add(new ToDoItem() {
                ID = 1,
                Title = "Create Webservice",
                Description = "Create To-Do Webservice",
                IsComplete = false
            });

            db.Add(new ToDoItem() {
                ID = 2,
                Title = "Test",
                Description = "qwertyasdfgh",
                IsComplete = true
            });
        }
    }
}
