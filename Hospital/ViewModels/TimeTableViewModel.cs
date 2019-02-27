using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.ViewModels
{
    public class TimeTableViewModel
    {
        public int Id { get; set; }
        public string UserFName { get; set; }
        public string UserSName { get; set; }
        public string UserLName { get; set; }
        public string UserYear { get; set; }
        public string SpecialtyName { get; set; }
        public DateTime Monday { get; set; }
        public DateTime Tuesday { get; set; }
        public DateTime Thirsday { get; set; }
        public DateTime Wednesday { get; set; }
        public DateTime Friday { get; set; }
    }
}
