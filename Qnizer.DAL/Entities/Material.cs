namespace Qnizer.DAL.Entities
{
    public class Material : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}