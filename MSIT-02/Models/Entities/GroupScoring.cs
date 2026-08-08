using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MSIT_02.Models.Entities
{
    public class GroupScoring
    {
        [Key, Column(Order = 0)]
        public long GroupId { get; set; }   // FK -> Event_Data(別組模組)
        [Key, Column(Order = 1)]
        public long UserId { get; set; }
        public string AttendanceStatus { get; set; }
        public User User { get; set; }
    }
}