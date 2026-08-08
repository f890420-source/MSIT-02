using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public class Level
    {
        public long LevelId { get; set; }
        public string LevelName { get; set; }
        public int MinXp { get; set; }
        public int MaxXp { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}