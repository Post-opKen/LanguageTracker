using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LanguageTracker.Controllers;
using LanguageTracker.Models;

namespace LanguageTracker.Models
{
    public class LanguageTrackerContext : DbContext
    {
        public LanguageTrackerContext (DbContextOptions<LanguageTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<LanguageTracker.Controllers.Students> Students { get; set; }

        public DbSet<LanguageTracker.Controllers.Instructors> Instructors { get; set; }

        public DbSet<LanguageTracker.Controllers.LabActivities> LabActivities { get; set; }

        public DbSet<LanguageTracker.Controllers.LabHours> LabHours { get; set; }

        public DbSet<LanguageTracker.Models.Class> Class { get; set; }

        public DbSet<LanguageTracker.Models.Student> Student { get; set; }

        public DbSet<LanguageTracker.Models.Enrollment> Enrollment { get; set; }

        public DbSet<LanguageTracker.Models.ACTFL> ACTFL { get; set; }
    }
}
