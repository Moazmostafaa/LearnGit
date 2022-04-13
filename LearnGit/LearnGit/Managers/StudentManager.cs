using LearnGit.Models;

namespace LearnGit.Managers
{
    public class StudentManager
    {
        public void AddStudent()
        {
            var student = new Student()
            {
                Class = "class 8",
                Id = 2,
                Name = "mohamed",
                Subjects = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            };

            Console.WriteLine(student);
        }
    }
}
