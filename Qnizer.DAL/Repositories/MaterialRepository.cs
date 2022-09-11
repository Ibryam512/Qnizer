using Qnizer.DAL.Entities;
using Qnizer.DAL.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Qnizer.DAL.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly QnizerDbContext _context;

        public MaterialRepository(QnizerDbContext context)
        {
            this._context = context;
        }

        public List<Material> GetMaterials() => this._context.Materials.ToList();

        public List<Material> GetMaterials(Expression<Func<Material, bool>> predicate) => this._context.Materials.Where(predicate).ToList();

        public Material GetMaterial(string id) => this._context.Materials.SingleOrDefault(x => x.Id == id);

        public Material GetMaterial(Expression<Func<Material, bool>> predicate) => this._context.Materials.SingleOrDefault(predicate);

        public void AddMaterial(Material material)
        {
            this._context.Materials.Add(material);
            this._context.SaveChanges();
        }

        public void UpdateMaterial(Material material)
        {
            this._context.Materials.Update(material);
            this._context.SaveChanges();
        }

        public void RemoveMaterial(Material material)
        {
            this._context.Materials.Remove(material);
            this._context.SaveChanges();
        }
    }
}