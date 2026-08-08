using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public class UserAchievement
    {
        public long UserId { get; set; }
        public long AchievementId { get; set; }
        public DateTime UnlockedAt { get; set; }
        public User User { get; set; }
        public Achievement Achievement { get; set; }
    }
}