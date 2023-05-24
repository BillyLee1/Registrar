using System.Collections.Generic;
using MySqlConnector;

namespace Registrar.Models
{
  public class Student
  {
    public string StudentName {get; set;}
    public int StudentId {get; set;}

    public Student(string name, int id)
    {
      StudentName = name;
      StudentId = id;
    }
  }
}
