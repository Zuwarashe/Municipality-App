// File: Issue.cs
using System;

namespace Municipality_App
{
    // Class to represent a reported issue
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MediaPath { get; set; }
    }
}
