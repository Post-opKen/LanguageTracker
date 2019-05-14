using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTracker.Controllers
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sid { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
    }
}
