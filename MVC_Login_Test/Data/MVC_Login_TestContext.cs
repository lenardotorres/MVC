using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Login_Test.Models
{
    public class MVC_Login_TestContext : DbContext
    {
        public MVC_Login_TestContext (DbContextOptions<MVC_Login_TestContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Login_Test.Models.Movie> Movie { get; set; }
    }
}
