﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency: JobField //extends JobField class
    {
        //FIELDS HAVE BEEN COMMENTED OUT BECAUSE JOBFIELD CONTAINS ALL COMMON CODE

        //private int Id { get; set; }
        //private static int nextId = 1;
        //private string Value { get; set; }

        //// TODO: Change the fields to auto-implemented properties.

        //public CoreCompetency()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        //public CoreCompetency(string value) : this()
        //{
        //    Value = value;
        //}

        //public override bool Equals(object obj)
        //{
        //    return obj is CoreCompetency competency &&
        //           Id == competency.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
        public CoreCompetency(string value) : base(value)//empty constructor
        {
        }
    }
    
}
