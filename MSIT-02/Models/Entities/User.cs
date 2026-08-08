using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public abstract class User
    {
        public long UserId { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccountStatus { get; set; }
        public string imgUrl { get; set; }
        public string AvatarBlurState { get; set; }
        public string Bio { get; set; }
        public long CurrentLevelId { get; set; }
        public int TotalXp { get; set; }
        public string RegionPreference { get; set; }
        public string DifficultyPreference { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastActiveAt { get; set; }

        // 對應資料庫的外鍵關聯
        public Level CurrentLevel { get; set; }
        public ICollection<UserAchievement> UserAchievements { get; set; } = new List<UserAchievement>();
        public ICollection<UserSkillTag> UserSkillTags { get; set; } = new List<UserSkillTag>();
        public ICollection<HikeRecord> HikeRecords { get; set; } = new List<HikeRecord>();

        public abstract IEnumerable<string> GetMenuPermissions();
    }
  
}