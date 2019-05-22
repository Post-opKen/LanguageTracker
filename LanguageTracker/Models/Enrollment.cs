using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LanguageTracker.Models
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Student ID")]
        [Column(TypeName = "nvarchar(9)")]
        public String SID { get; set; }
        

        [ForeignKey("ClassID")]
        [Display(Name = "Class ID")]
        [Column(TypeName = "varchar(4)")]
        public String ClassID { get; set; }

        [Display(Name = "Quarter")]
        [Column(TypeName = "varchar(4)")]
        public String YearQuarterID { get; set; }
    }
}
