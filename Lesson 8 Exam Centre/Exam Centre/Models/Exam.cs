namespace ExamCentre.Models
{
    public class Exam
    {
        public string subject;
        public List<Student> Students = new List<Student>{};
        public Exam(string subject){
            subject = subject;
        }
    public void AddStudent(Student student)
       {
         Students.Add(student);
       }
    };
}

