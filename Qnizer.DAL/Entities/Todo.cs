using Qnizer.Common.Enums;

namespace Qnizer.DAL.Entities
{
    public class Todo : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TodoStatus Status { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}