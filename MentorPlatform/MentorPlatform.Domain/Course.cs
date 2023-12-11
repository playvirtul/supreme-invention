namespace MentorPlatform.Domain
{
    public class Course
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public List<Lesson>? Lessons { get; set; }
    }
}
