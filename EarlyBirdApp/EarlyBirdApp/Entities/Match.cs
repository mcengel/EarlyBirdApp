using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyBirdApp.Entities
{
    public class Match
    {
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public bool IsQuiz { get; set; }
        public string Rules { get; set; }

    }
}
