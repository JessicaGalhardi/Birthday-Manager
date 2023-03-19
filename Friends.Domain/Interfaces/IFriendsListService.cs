using Friends.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Domain.Interfaces
{
    public interface IFriendsListService 
    {
        IList<Friend> GetAll();

        IList<Friend> GetSelected(List<int> selected);
    }
}
