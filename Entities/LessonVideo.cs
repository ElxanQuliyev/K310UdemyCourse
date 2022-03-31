﻿namespace Entities
{
    public class LessonVideo
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string VideoUrl { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public int LessonId { get; set; }
    }
}
