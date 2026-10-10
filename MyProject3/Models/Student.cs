namespace MyProject3.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        // מפתח זר לכיתה (קשר 1:N - לכל תלמיד יש כיתה אחת)
        public int? ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }

        // קשר רבים-רבים לקורסים דרך טבלת הקישור
        public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}