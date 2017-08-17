using System;
using System.Collections.Generic;
using Todo.Core.Interfaces;
using Todo.Core.Models;

namespace Todo.Core.Business
{
    public class TodoManagerMock : ITodoManager
    {
        private ITodoValidator _validator;
        private ITodoRepository _repository;

        public TodoManagerMock(ITodoValidator validator, ITodoRepository repository)
        {
            _validator = validator;
            _repository = repository;
        }

        public TodoItem Create(string title, string description)
        {
            if (_validator.IsValidTitle(title) && _validator.IsValidDescription(description))
            {
                var newItem = new TodoItem()
                {
                    Title = title,
                    Description = description
                };

                return _repository.Save(newItem);
            }
            else
            {
                throw new Exception("Invalud input");
            }
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public TodoItem Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Update(TodoItem item)
        {
            var updatedEntity = _repository.Save(item);

            return updatedEntity.ID == item.ID;
        }
    }
}