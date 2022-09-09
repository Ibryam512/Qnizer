using System;

namespace Qnizer.DAL.Entities
{
    public class Class : BaseEntity
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public string SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}