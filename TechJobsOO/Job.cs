﻿using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job (string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString() //consider making this a dictionary with Key, Value Pairs--or is that complicating things too much??          
        {
            string output = "";

            if (Name.Equals(""))
            {
                Name = "Data not available";
            }
            if (EmployerName.Value.Equals("") || EmployerName.Value == null)
            {
                EmployerName.Value = "Data not available";
            }
            if (EmployerLocation.Value.Equals("") || EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobCoreCompetency.Value.Equals("") || JobCoreCompetency.Value == null)
            {
                JobCoreCompetency.Value = "Data not available";
            }
            if (JobType.Value.Equals("") || JobType.Value == null)
            {
                JobType.Value = "Data not available";
            }

            output = $"\n ID: {Id} \n Name: {Name} \n Employer: {EmployerName.Value} \n Location: {EmployerLocation.Value} \n Position Type: {JobType.Value} \n Core Competency: {JobCoreCompetency.Value} \n";

            return output;
        }
    }
}
