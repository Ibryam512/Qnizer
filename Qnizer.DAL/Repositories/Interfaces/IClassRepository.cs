using System.Linq.Expressions;
using Qnizer.DAL.Entities;

namespace Qnizer.DAL.Repositories.Interfaces
{
    public interface IClassRepository
    {
        List<Class> GetClasses();
        List<Class> GetClasses(Expression<Func<Class, bool>> predicate);
        Class GetClass(string id);
        Class GetClass(Expression<Func<Class, bool>> predicate);
        void AddClass(Class clss);
        void UpdateClass(Class clss);
        void RemoveClass(Class clss);
    }
}