namespace Registrar.Models
{
  public class Student
  {
    public string StudentName {get; set;}
    public int StudentId {get; set;}
    public int CourseId {get; set;}
    public Course Course { get; set; }
  }
}
