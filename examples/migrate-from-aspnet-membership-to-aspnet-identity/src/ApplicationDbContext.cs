using Microsoft.AspNet.Identity.EntityFramework;

namespace Travis.IO.Examples
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("MyConnectionString", throwIfV1Schema: false)
        {
        }
    }
}