using System.Linq.Expressions;
using Qnizer.DAL.Entities;

namespace Qnizer.DAL.Repositories.Interfaces
{
    public interface ISubjectRepository
    {
        List<Subject> GetSubjects();
        List<Subject> GetSubjects(Expression<Func<Subject, bool>> predicate);
        Subject GetSubject(string id);
        Subject GetSubject(Expression<Func<Subject, bool>> predicate);
        void AddSubject(Subject subject);
        void UpdateSubject(Subject subject);
        void RemoveSubject(Subject subject);
    }
}