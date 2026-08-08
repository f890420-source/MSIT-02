using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public class UserAchievement
    {
        [Key, Column(Order = 0)]
        public long UserId { get; set; }
        [Key, Column(Order = 1)]
        public long AchievementId { get; set; }
        public DateTime UnlockedAt { get; set; }
        public User User { get; set; }
        public Achievement Achievement { get; set; }
    }
}