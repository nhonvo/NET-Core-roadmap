﻿namespace _10ExercisesEncapsulation._5Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(int id, string name, string title, string author)
        {
            Id = id;
            Name = name;
            Title = title;
            Author = author;
        }

    }
}