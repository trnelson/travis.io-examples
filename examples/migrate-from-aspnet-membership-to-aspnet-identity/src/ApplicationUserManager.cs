using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Travis.IO.Examples
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager() : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
            this.PasswordHasher = new SqlPasswordHasher();
        }
    }
}