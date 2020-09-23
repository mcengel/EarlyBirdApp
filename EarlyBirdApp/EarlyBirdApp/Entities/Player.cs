using SQLite;
using System;

namespace EarlyBirdApp.DataAccess
{
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
