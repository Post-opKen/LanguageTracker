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
		public LanguageTrackerContext(DbContextOptions<LanguageTrackerContext> options)
			: base(options)
		{
		}

		public DbSet<LanguageTracker.Models.Class> Class { get; set; }

		public DbSet<LanguageTracker.Models.Student> Student { get; set; }

		public DbSet<LanguageTracker.Models.Enrollment> Enrollment { get; set; }
	}
}
