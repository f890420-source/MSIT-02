using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public class HikeRecord
    {
        public long RecordId { get; set; }
        public long UserId { get; set; }
        public long MountainId { get; set; }   // 屬於別組模組,先放 long,不強行參照別人的類別
        public DateTime HikeDate { get; set; }
        public int CompanionCount { get; set; }
        public string Note { get; set; }
        public bool Verified { get; set; }
        public User User { get; set; }
    }
}