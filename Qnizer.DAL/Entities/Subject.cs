namespace Qnizer.DAL.Entities
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public List<Class> Classes { get; set; }
        public List<Material> Materials { get; set; }
    }
}