using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageTracker.Models
{
    public class LanguageTrackerACTFLContext : DBContext
    {
        public DbSet<Class> Class { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<ACTFL> ACTFL { get; set; }

    }
}
