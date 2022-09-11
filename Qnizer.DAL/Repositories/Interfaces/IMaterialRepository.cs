using System.Linq.Expressions;
using Qnizer.DAL.Entities;

namespace Qnizer.DAL.Repositories.Interfaces
{
    public interface IMaterialRepository
    {
        List<Material> GetMaterials();
        List<Material> GetMaterials(Expression<Func<Material, bool>> predicate);
        Material GetMaterial(string id);
        Material GetMaterial(Expression<Func<Material, bool>> predicate);
        void AddMaterial(Material material);
        void UpdateMaterial(Material material);
        void RemoveMaterial(Material material);
    }
}