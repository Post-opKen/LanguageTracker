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

        [Display(Name = "Proficiency Area")]
        public string PROF_TYPE { get; set; }

        [Display(Name = "Proficiency Level")]
        public string PROF_LVL { get; set; }

        [Display(Name = "Proficiency Score")]
        public string PROF_SCR { get; set; }

        public virtual Enrollment S { get; set; }
    }
}
