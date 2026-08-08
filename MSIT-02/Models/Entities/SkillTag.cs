using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public class SkillTag
    {
        public long TagId { get; set; }
        public string Category { get; set; }
        public string TagName { get; set; }
        public long? ParentTagId { get; set; }        // 可為 NULL,對應自我參照
        public string UnlockCondition { get; set; }

        public SkillTag ParentTag { get; set; }
        public ICollection<SkillTag> ChildTags { get; set; } = new List<SkillTag>();
        public ICollection<UserSkillTag> UserSkillTags { get; set; } = new List<UserSkillTag>();
    }
}