using LearnGit.Models;

namespace LearnGit.Managers
{
    public class StudentManager
    {
        public void AddStudent()
        {
            var student = new Student()
            {
                Class = "class 1",
                Id = 1,
                Name = "Ahmed",
                Subjects = new List<int>() { 1, 2, 3 }
            };

            Console.WriteLine(student);
        }
    }
}
