using Qnizer.DAL.Entities;
using Qnizer.DAL.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Qnizer.DAL.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly QnizerDbContext _context;

        public ClassRepository(QnizerDbContext context)
        {
            this._context = context;
        }

        public List<Class> GetClasses() => this._context.Classes.ToList();

        public List<Class> GetClasses(Expression<Func<Class, bool>> predicate) => this._context.Classes.Where(predicate).ToList();

        public Class GetClass(string id) => this._context.Classes.SingleOrDefault(x => x.Id == id);

        public Class GetClass(Expression<Func<Class, bool>> predicate) => this._context.Classes.SingleOrDefault(predicate);

        public void AddClass(Class clss)
        {
            this._context.Classes.Add(clss);
            this._context.SaveChanges();
        }

        public void UpdateClass(Class clss)
        {
            this._context.Classes.Update(clss);
            this._context.SaveChanges();
        }

        public void RemoveClass(Class clss)
        {
            this._context.Classes.Remove(clss);
            this._context.SaveChanges();
        }
    }
}