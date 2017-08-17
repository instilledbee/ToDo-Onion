using Nancy;
using Nancy.ModelBinding;
using Todo.Core.Interfaces;
using Todo.Core.Models;

namespace Todo.Service.Modules
{
    public class TodoModule : NancyModule
    {
        public TodoModule(ITodoManager manager)
        {
            Get("/items/{id}", args => manager.Get(args.id));
            Get("/items", args => manager.GetAll());
            Post("/items", args => manager.Update(this.Bind<TodoItem>()));
        }
    }
}