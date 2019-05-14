using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTracker.Controllers
{
    public class LabHours
    {
        [Key]
        public int Id { get; set; }
        public string instructors { get; set; }
        public int sid { get; set; }
        public int total_days { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime total_hours { get; set; }
    }
}
