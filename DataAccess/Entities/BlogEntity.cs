﻿namespace DataAccess.Entities
{
    public class BlogEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}