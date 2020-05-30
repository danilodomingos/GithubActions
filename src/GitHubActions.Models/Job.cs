using System;

namespace GitHubActions.Models
{
    public class Job
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
    }
}