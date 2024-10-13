using DependencyInjection.Services;

namespace DependencyInjection.Managers
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        // Constructor Injection ile Teacher'ı alıyoruz
        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        } 

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();  // Teacher'ın GetInfo metodunu çağırıyoruz
        }
    }
}
