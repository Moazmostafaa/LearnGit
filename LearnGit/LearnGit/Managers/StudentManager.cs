using LearnGit.Models;

namespace LearnGit.Managers
{
    public class StudentManager
    {
        public void AddStudent()
        {
            var student = new Student()
            {
                Class = "class 5",
                Id = 1,
                Name = "mohamed",
                Subjects = new List<int>() { 1, 2, 3, 9,10 }
            };

            Console.WriteLine(student);
        }
    }
}
