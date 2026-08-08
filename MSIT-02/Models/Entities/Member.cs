using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
 
        public class Member : User
        {
            public override IEnumerable<string> GetMenuPermissions()
                => new[] { "我的行程", "裝備清單", "討論區" };
        }
    public class EventLeader : User
    {
        public override IEnumerable<string> GetMenuPermissions()
            => new[] { "活動管理","我的行程", "裝備清單", "討論區" };
    }
    public class Admin : User
    {
        public override IEnumerable<string> GetMenuPermissions()
            => new[] { "會員管理",
                "活動與違規審核",
                "步道資料庫維護",
                "系統公告發布",
                "數據統計",
                "我的行程",
                "討論區"};
    }
}
