using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialWebAPi.Models
{
    public class SocialDBContext:DbContext
    {
        public SocialDBContext(DbContextOptions<SocialDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
       

    }
}
