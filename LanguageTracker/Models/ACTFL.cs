using System;
using System.Collections.Generic;

namespace LanguageTracker.Models
{
    public partial class ACTFL
    {
        public int ID { get; set; }

        [Display(Name = "Quarter")]
        public string YearQuarterID { get; set; }
        public string Language { get; set; }

        [Display(Name = "Item")]
        public string ItemNumber { get; set; }

        [Display(Name = "Student ID")]
        public string SID { get; set; }

        public string Reading { get; set; }

        public string Writing { get; set; }

        public string Speaking { get; set; }
        public string Listening { get; set; }

        public virtual Enrollment S { get; set; }
    }
}
