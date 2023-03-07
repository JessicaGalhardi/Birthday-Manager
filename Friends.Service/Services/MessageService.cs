using Friends.Domain.Entities;
using Friends.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Service.Services
{
    public class MessageService : IMessage
    {

        public readonly FriendsDbContext _friendsDbContext;

        public MessageService(FriendsDbContext friendsDbContext)
        {
            _friendsDbContext = friendsDbContext;
        }

        //setting the void for creating a message for the helper
        public void Create(Message message)
        {
            _friendsDbContext.messages.Add(message);
            _friendsDbContext.SaveChanges();
        }
    }
}
