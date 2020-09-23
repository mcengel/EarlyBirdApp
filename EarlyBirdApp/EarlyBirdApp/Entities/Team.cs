using EarlyBirdApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyBirdApp.Entities
{
    public class Team
    {
        public Team()
        {
            Players = new List<Player>();
        }
        public Guid ID { get; set; }
        public ICollection<Player> Players { get; set; }

    }
}
