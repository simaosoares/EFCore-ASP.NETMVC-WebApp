namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    /// <summary>
    /// This entity uses the classnameID pattern instead of ID by itself.
    /// 
    /// The question mark after the Grade type declaration indicates that the Grade property is nullable. 
    /// A grade that's null is different from a zero grade -- null means a grade isn't known or hasn't been assigned yet.
    /// 
    /// Entity Framework interprets a property as a foreign key property if it's named <navigation property name><primary key property name> 
    /// (for example, StudentID for the Student navigation property since the Student entity's primary key is ID). 
    /// Foreign key properties can also be named simply <primary key property name> (for example, CourseID since the Course entity's primary key is CourseID).
    /// </summary>
    public class Enrollment
    {        
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}