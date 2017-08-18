using System;
using System.Collections.Generic;
using ToDo.Core.Interfaces;
using ToDo.Core.Models;

namespace ToDo.Core.Business
{
    public class ToDoManagerMock : IToDoManager
    {
        private IToDoValidator _validator;
        private IToDoRepository _repository;

        public ToDoManagerMock(IToDoValidator validator, IToDoRepository repository)
        {
            _validator = validator;
            _repository = repository;
        }

        public ToDoItem Create(string title, string description)
        {
            if (_validator.IsValidTitle(title) && _validator.IsValidDescription(description))
            {
                var newItem = new ToDoItem()
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

        public ToDoItem Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Update(ToDoItem item)
        {
            var updatedEntity = _repository.Save(item);

            return updatedEntity.ID == item.ID;
        }
    }
}