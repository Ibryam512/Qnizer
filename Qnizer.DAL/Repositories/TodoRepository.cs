using Qnizer.DAL.Entities;
using Qnizer.DAL.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Qnizer.DAL.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly QnizerDbContext _context;

        public TodoRepository(QnizerDbContext context)
        {
            this._context = context;
        }

        public List<Todo> GetTodos() => this._context.Todos.ToList();

        public List<Todo> GetTodos(Expression<Func<Todo, bool>> predicate) => this._context.Todos.Where(predicate).ToList();

        public Todo GetTodo(string id) => this._context.Todos.SingleOrDefault(x => x.Id == id);

        public Todo GetTodo(Expression<Func<Todo, bool>> predicate) => this._context.Todos.SingleOrDefault(predicate);

        public void AddTodo(Todo todo)
        {
            this._context.Todos.Add(todo);
            this._context.SaveChanges();
        }

        public void UpdateTodo(Todo todo)
        {
            this._context.Todos.Update(todo);
            this._context.SaveChanges();
        }

        public void RemoveTodo(Todo todo)
        {
            this._context.Todos.Remove(todo);
            this._context.SaveChanges();
        }
    }
}