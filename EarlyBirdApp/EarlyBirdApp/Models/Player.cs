using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyBirdApp.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string Name { get; set; }
        public int PlayedGames { get; set; }
        public string Nickname { get; set; }

        public int? Salt { get; set; }

        //public int TeamId { get; set; }
        //public virtual Team Team { get; set; }
    }
}
