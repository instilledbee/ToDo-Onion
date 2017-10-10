using Nancy;
using Nancy.ModelBinding;
using ToDo.Core.Interfaces;
using ToDo.Core.Models;

namespace ToDo.Service.Modules
{
    public class ToDoModule : NancyModule
    {
        public ToDoModule(IToDoManager manager)
        {
            Get("/items/{id}", args => manager.Get(args.id));
            Post("/items/{id}", args => manager.Complete(args.id));
            
            Get("/items", args => manager.GetAll());
            Post("/items", args => manager.Modify(this.Bind<ToDoItem>()));
            Put("/items", args => manager.Create(this.Bind<ToDoItem>()));
        }
    }
}