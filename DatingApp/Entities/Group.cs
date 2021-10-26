using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppAPI.Entities
{
    public class Group
    {
        public string Name { get; set; }
        public ICollection<Connection> Connections { get; set; } = new List<Connection>();

        public Group()
        {
        }

        public Group(string name)
        {
            Name = name;
        }
    }
}
