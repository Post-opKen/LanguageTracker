using System;

namespace LanguageTracker.Models
{
    internal class DisplayAttribute : Attribute
    {
        public string Name { get; set; }
    }
}