using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LanguageTracker.Models
{
    public static class SeedDataClass
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LanguageTrackerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LanguageTrackerContext>>()))
            {
             
                if (context.Class.Any())
                {
                    return;   // DB has been seeded
                }

                context.Class.AddRange(
                    new Class
                    {
                        YearQuarterID = "B782",
                        ClassID = "2249B782",
                        ItemNumber = 2249,
                        CourseID = "CHIN&121",
                        InstructorName = "LIANG F"
                    },

                    new Class
                    {
                        YearQuarterID = "B782",
                        ClassID = "4559B782",
                        ItemNumber = 4559,
                        CourseID = "FRCH&121",
                        InstructorName = "LUENGO L"
                    },

                    new Class
                    {
                        YearQuarterID = "B782",
                        ClassID = "4563B782",
                        ItemNumber = 4563,
                        CourseID = "FRCH&121",
                        InstructorName = "LUENGO L"
                    },

                    new Class
                    {
                        YearQuarterID = "B782",
                        ClassID = "4655B782",
                        ItemNumber = 4655,
                        CourseID = "GERM&121",
                        InstructorName = "MUMPOWER P"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}