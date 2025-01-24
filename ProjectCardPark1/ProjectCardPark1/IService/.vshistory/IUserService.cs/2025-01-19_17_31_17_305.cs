using ImagesUploadDisplayDB.Data;

namespace ImagesUploadDisplayDB.IService
{
    public interface IStudentService
    {
        Student Save(Student oStudent);

        Student GetSavedStudent();

    }
}
