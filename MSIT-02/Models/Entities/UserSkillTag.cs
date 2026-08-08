using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public class UserSkillTag
    {
        public long UserId { get; set; }
        public long TagId { get; set; }
        public string Source { get; set; }
        public User User { get; set; }
        public SkillTag SkillTag { get; set; }
    }
}