namespace ExamCentre.Models
{
   public class Student
   {
      public int CandidateNumber { get; set; }
      private string _studentName; 
      public int[] Score { get; set; }

      public Student(int candidateNumber, string studentName, int[] score)
      {
         CandidateNumber = candidateNumber;
         _studentName=studentName; 
         Score = score;
      }
      public void PrintStudentDetails()
      {
         Console.WriteLine($"Candidate Number : {CandidateNumber},Score: {string.Join(",",Score)}");
      }

   }
}