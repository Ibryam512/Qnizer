using Qnizer.DAL.Entities;
using Qnizer.DAL.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Qnizer.DAL.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly QnizerDbContext _context;

        public SubjectRepository(QnizerDbContext context)
        {
            this._context = context;
        }

        public List<Subject> GetSubjects() => this._context.Subjects.ToList();

        public List<Subject> GetSubjects(Expression<Func<Subject, bool>> predicate) => this._context.Subjects.Where(predicate).ToList();

        public Subject GetSubject(string id) => this._context.Subjects.SingleOrDefault(x => x.Id == id);

        public Subject GetSubject(Expression<Func<Subject, bool>> predicate) => this._context.Subjects.SingleOrDefault(predicate);

        public void AddSubject(Subject subject)
        {
            this._context.Subjects.Add(subject);
            this._context.SaveChanges();
        }

        public void UpdateSubject(Subject subject)
        {
            this._context.Subjects.Update(subject);
            this._context.SaveChanges();
        }

        public void RemoveSubject(Subject subject)
        {
            this._context.Subjects.Remove(subject);
            this._context.SaveChanges();
        }
    }
}