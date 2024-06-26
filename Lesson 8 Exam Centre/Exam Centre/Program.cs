using System;
using System.Collections.Generic;
using ExamCentre.Models;
namespace ExamCentre
{ 
    class Program
    {
     static void Main(string[] args)
         {
            var exam = new Exam ("Bioinformatics");
            
            var student1 = new Student(3314, "Ama", new int[] { 85, 90, 78 });
            var student2 = new Student(3315, "Jess", new int[] { 88, 92, 80 });

           exam.AddStudent(student1);
           exam.AddStudent(student2);

           exam.MarkPaper(3315, new int[] { 55 });
           exam.MarkPaper(3314, new int[]{ 70 });

           Console.WriteLine($"Exam Subject : {exam.Subject}");
           
            foreach (var student in exam.Students)
            {
                student.PrintStudentDetails();
            }
   

         }
    }
} 

    