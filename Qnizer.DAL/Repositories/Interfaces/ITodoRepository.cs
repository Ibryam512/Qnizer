using System.Linq.Expressions;
using Qnizer.DAL.Entities;

namespace Qnizer.DAL.Repositories.Interfaces
{
    public interface ITodoRepository
    {
        List<Todo> GetTodos();
        List<Todo> GetTodos(Expression<Func<Todo, bool>> predicate);
        Todo GetTodo(string id);
        Todo GetTodo(Expression<Func<Todo, bool>> predicate);
        void AddTodo(Todo todo);
        void UpdateTodo(Todo todo);
        void RemoveTodo(Todo todo);
    }
}