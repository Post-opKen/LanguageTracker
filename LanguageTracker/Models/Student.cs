using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageTracker.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Student ID")]
        [Column(TypeName = "nvarchar(9)")]
        public String SID { get; set; }

        [Display(Name = "Student Name")]
        [Column(TypeName = "nvarchar(22)")]
        public String FullName { get; set; }
    }
}
