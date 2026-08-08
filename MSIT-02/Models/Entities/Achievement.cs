using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public class Achievement
    {
        public long AchievementId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Rarity { get; set; }
        public string ConditionType { get; set; }
        public string ConditionValue { get; set; }
        public ICollection<UserAchievement> UserAchievements { get; set; } = new List<UserAchievement>();
        //紀錄這項成就被哪些會員解鎖過
        //public IAchievementCondition BuildCondition()
        //    => AchievementConditionFactory.Create(ConditionType, ConditionValue);
        //把資料庫的文字條件，轉物件
    }
}