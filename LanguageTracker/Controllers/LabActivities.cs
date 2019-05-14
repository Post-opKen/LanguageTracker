using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTracker.Controllers
{
    public class LabActivities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sid { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public string activity { get; set; }
        public string staff_levels { get; set; }
    }
}
