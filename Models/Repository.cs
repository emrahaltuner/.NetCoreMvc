namespace basics.Models
{
    public class Repository
    {
        public static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
        {
            new Course() {Id=1, Title= "Aspnet Kursu",Image="1.webp", Description="Harika bir kurs"},
            new Course() {Id=2, Title= "Php Kursu",Image="2.webp", Description="Harika bir kurs"},
            new Course() {Id=3, Title= "django Kursu",Image="3.webp", Description="Harika bir kurs"},
             new Course() {Id=4, Title= "javascript Kursu",Image="1.webp", Description="Harika bir kurs"},
        };
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}