﻿namespace _5.Querying.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte[]? Photo { get; set; }
        public decimal? Height { get; set; }
        public float? Weight { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}