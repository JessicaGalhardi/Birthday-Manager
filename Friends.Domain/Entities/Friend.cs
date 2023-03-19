using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Domain.Entities
{
    public class Friend
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public int FoneNumber { get; set; }
        public bool IsActive { get; set; }

        public DateTime Birthday { get; set; }

    }
}
