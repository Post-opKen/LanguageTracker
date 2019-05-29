using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTracker.Models
{
    public class ACTFL
    {

        /*[Key]
        public int Id { get; set; }*/

        [Key]
        [ForeignKey("YearQuarterID")]
        [Display(Name = "Quarter")]
        [Column(TypeName = "nvarchar(10)")]
        public nvarchar YearQuarterID { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public nvarchar Language { get; set; }

        [Key]
        [ForeignKey("ItemNumber")]
        [Display(Name = "Item")]
        [Column(TypeName = "nvarchar(4)")]
        public nvarchar ItemNumber { get; set; }

        [Key]
        [ForeignKey("SID")]
        [Display(Name = "Student ID")]
        [Column(TypeName = "nvarchar(9)")]
        public nvarchar SID { get; set; }

        [Display(Name = "Proficiency Area")]
        [Column(TypeName = "nvarchar(10)")]
        public nvarchar PROF_TYPE { get; set; }

        [Display(Name = "Proficiency Level")]
        [Column(TypeName = "nvarchar(10)")]
        public nvarchar PROF_LVL { get; set; }

        [Display(Name = "Proficiency Score")]
        [Column(TypeName = "nvarchar(2)")]
        public nvarchar PROF_SCR { get; set; }
    }
}
