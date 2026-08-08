using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public class GroupScoring
    {
        public long GroupId { get; set; }   // FK -> Event_Data(別組模組)
        public long UserId { get; set; }
        public string AttendanceStatus { get; set; }
        public User User { get; set; }
    }
}