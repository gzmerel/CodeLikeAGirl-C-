using System.Collections.Generic;
using System;

namespace ExamCentre.Models
{
    public class Exam
    {
        public string Subject{get; set;}
        public List<Student> Students {get; set;}
        public Exam(string subject)
        {
            Subject = subject;
            Students= new List<Student>();
        }
    public void AddStudent(Student student)
       {
         Students.Add(student);
       }
    public void MarkPaper (int CandidateNumber, int[] scores)
        {
            var student = Students.Find( s => s.CandidateNumber == CandidateNumber) ;
            if (student != null)
            {
                student.Score = scores;
            }
            else 
            {
                Console.WriteLine($"Student with candidate number {CandidateNumber} not found.");
            }
        }
    
    }
}

