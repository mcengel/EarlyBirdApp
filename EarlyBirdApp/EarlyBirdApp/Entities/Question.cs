using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyBirdApp.Entities
{
    public class Question
    {
        public Guid ID { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
    }
}
