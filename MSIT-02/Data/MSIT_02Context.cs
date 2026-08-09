using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MSIT_02.Models.Entities;

namespace MSIT_02.Data
{
    public class MSIT_02Context : DbContext
    {
       
        public MSIT_02Context() : base("name=MSIT_02Context")
        {
        }

        public DbSet<Level> Levels { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }
        public DbSet<SkillTag> SkillTags { get; set; }
        public DbSet<UserSkillTag> UserSkillTags { get; set; }
        public DbSet<HikeRecord> HikeRecords { get; set; }
        public DbSet<GroupScoring> GroupScoring { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // 設定 User 的 TPH(Table-Per-Hierarchy)繼承:
            // 資料庫還是只有一張 users 表,用 Role 欄位的值決定
            // 查詢出來時要 new 成哪一個子類別
            modelBuilder.Entity<User>()
                .Map<Member>(m => m.Requires("Role").HasValue("一般會員"))
                .Map<EventLeader>(m => m.Requires("Role").HasValue("團主"))
                .Map<Admin>(m => m.Requires("Role").HasValue("管理員"));
        }
    }
}
