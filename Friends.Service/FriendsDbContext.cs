using Friends.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Friends.Domain.Entities;

namespace Friends.Service
{
    public class FriendsDbContext : DbContext
    {
        public FriendsDbContext(DbContextOptions contextOptions): base(contextOptions) { }
            

        public DbSet<Friend> friends { get; set; }

        public DbSet<Message> messages { get; set; }
    }

 
}