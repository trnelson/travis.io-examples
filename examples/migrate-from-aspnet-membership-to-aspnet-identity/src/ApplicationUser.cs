using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Travis.IO.Examples
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime CreatedOnUtc { get; set; }

        public ApplicationUser()
        {
            CreatedOnUtc = DateTime.UtcNow;
        }
    }
}