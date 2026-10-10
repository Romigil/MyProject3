namespace MyProject3.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}