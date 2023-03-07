using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Service
{
    public class FriendsDbContextFactory : IDesignTimeDbContextFactory<FriendsDbContext>
    {
        public FriendsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FriendsDbContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database= friends_mvc");

            return new FriendsDbContext(optionsBuilder.Options);

        }
    }
}
