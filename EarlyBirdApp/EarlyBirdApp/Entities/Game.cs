using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyBirdApp.Entities
{
    public class Game
    {
        public Game()
        {
            Matches = new List<Match>();
        }
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }
        public Guid TeamOneID { get; set; }
        public Team TeamOne { get; set; }
        public Guid TeamTwoID { get; set; }
        public Team TeamTwo { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
