using System;
using System.Collections.Generic;
using System.Text;

namespace AppTest
{
    public class GroupBehavior
    {
        public string Description { get; set; }

        public List<Behavior> Behaviors { get; set; }
    }

    public class Behavior
    {
        public string Description { get; set; }
        public List<Level> Levels { get; set; }
    }

    public class Level
    {
        public string Description { get; set; }
    }
}
