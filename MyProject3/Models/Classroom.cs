namespace MyProject3.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public string ClassName { get; set; } = string.Empty;

        // קשר יחיד-רבים: לכיתה אחת יש רשימת תלמידים
        public List<Student> Students { get; set; } = new List<Student>();
    }
}