using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Friends.Domain.Entities;
using Friends.Domain.Interfaces;

namespace Friends.Service.Services
{
    public class FriendsListService : IFriendsListService
    {
        private readonly FriendsDbContext _dbContext;
        public FriendsListService(FriendsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Friend> GetAll()
        {
           return _dbContext.friends.ToList();
        }

        public IList<Friend> GetSelected(List<int> selected)
        {
            return _dbContext.friends.Where(friend => selected.Contains(friend.Id)).ToList();
        }
    }
}
