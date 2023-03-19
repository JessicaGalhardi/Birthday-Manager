using Friends.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Domain.Interfaces
{
    public interface IMessage
    {
        void Create(Message message);
    }
}
