using Powers.DynamicSearchTerm.Attributes;
using System;

namespace Powers.DynamicSearchTerm.Samples.Shared
{
    public class User
    {
        public Guid Id { get; set; }

        [FuzzySearch]
        public string Name { get; set; } = null!;

        public string Account { get; set; } = null!;

        public string Password { get; set; } = null!;

        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }
    }
}