using Microsoft.AspNetCore.Identity;

namespace Qnizer.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string University { get; set; }
        public string Year { get; set; }
        public List<Todo> Todos { get; set; }
        public List<Class> Classes { get; set; }
        public List<Material> Materials { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}