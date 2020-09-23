using EarlyBirdApp.DataAccess;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyBirdApp.Entities
{
    public class PlayerGameList
    {
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
