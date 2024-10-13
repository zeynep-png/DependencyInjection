namespace DependencyInjection.Services
{
    public interface ITeacher
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetInfo();
    }
}
