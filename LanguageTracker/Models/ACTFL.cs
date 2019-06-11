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
		[Column(TypeName = "string(10)")]
		public string YearQuarterID { get; set; }

		[Column(TypeName = "string(10)")]
		public string Language { get; set; }

		[Key]
		[ForeignKey("ItemNumber")]
		[Display(Name = "Item")]
		[Column(TypeName = "string(4)")]
		public string ItemNumber { get; set; }

		[Key]
		[ForeignKey("SID")]
		[Display(Name = "Student ID")]
		[Column(TypeName = "string(9)")]
		public string SID { get; set; }

		[Display(Name = "Proficiency Area")]
		[Column(TypeName = "string(10)")]
		public string PROF_TYPE { get; set; }

		[Display(Name = "Proficiency Level")]
		[Column(TypeName = "string(10)")]
		public string PROF_LVL { get; set; }

		[Display(Name = "Proficiency Score")]
		[Column(TypeName = "string(2)")]
		public string PROF_SCR { get; set; }
	}
}
