using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        public int Id { get; } //made public, added get
        private static int nextId = 1;
        public string Value { get; set; } //made public, added get/set

        // TODO: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
    
}
