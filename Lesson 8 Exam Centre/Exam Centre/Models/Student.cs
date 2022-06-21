namespace ExamCentre.Models
{
   public class Student
   {
      public Student(string studentName , int candidateNumber ){}
      public int candidateNumber;
      private string studentName;
      public int[] score = Enumerable.Range(1,100).ToArray();
   };
}
