using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyBirdApp.Entities
{
    public class GameMatchList
    {
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }
        public Guid MatchId { get; set; }
        public Match Match { get; set; }

    }
}
