namespace MentorPlatform.Domain
{
    public class Lesson
    {
        public Guid Id { get; set; }

        public Guid CourseId { get; set; } = Guid.Empty;

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
