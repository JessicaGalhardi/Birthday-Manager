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

        public void Create(Friend friend)
        {
            _dbContext.friends.Add(friend);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var friend = _dbContext.friends.First(f => f.Id == id);
            _dbContext.friends.Remove(friend);
            _dbContext.SaveChanges();
        }

        public void Update(Friend friend)
        {

            _dbContext.friends.Update(friend);
            _dbContext.SaveChanges();
        }

        public Friend Get(int id)
        {
            return _dbContext.friends.First(f => f.Id == id);
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
