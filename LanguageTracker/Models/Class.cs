using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTracker.Models
{
    public class Class
    {
        //column names
        [Display(Name = "Quarter")]
        [Column(TypeName = "nvarchar(10)")]
        public string YearQuarterID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Class ID")]
        [Column(TypeName = "nvarchar(8)")]
        public string ClassID { get; set; }

        [Display(Name = "Item")]
        [Column(TypeName = "nvarchar(4)")]
        public int ItemNumber { get; set; }

        [Display(Name = "Course")]
        [Column(TypeName = "nvarchar(10)")]
        public string CourseID { get; set; }

        [Display(Name = "Instructor")]
        [Column(TypeName = "nvarchar(30)")]
        public string InstructorName { get; set; }
    }
}
