using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MSIT_02.Models.Entities
{
    using System.ComponentModel.DataAnnotations; 

    public class SkillTag
    {
        [Key]
        public long TagId { get; set; }

        public string Category { get; set; }
        public string TagName { get; set; }
        public long? ParentTagId { get; set; }
        public string UnlockCondition { get; set; }

        public virtual SkillTag ParentTag { get; set; }
        public virtual ICollection<SkillTag> ChildTags { get; set; } = new List<SkillTag>();
        public virtual ICollection<UserSkillTag> UserSkillTags { get; set; } = new List<UserSkillTag>();
    }
}