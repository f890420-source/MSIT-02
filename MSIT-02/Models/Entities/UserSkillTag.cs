using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public class UserSkillTag
    {
        [Key, Column(Order = 0)]
        public long UserId { get; set; }
        [Key, Column(Order = 1)]
        public long TagId { get; set; }
        public string Source { get; set; }
        public User User { get; set; }
        public SkillTag SkillTagId { get; set; }
    }
}