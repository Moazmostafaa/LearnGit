﻿namespace LearnGit.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public List<int> Subjects { get; set; }
    }
}
