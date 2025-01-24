using ImagesUploadDisplayDB.Data;
using ImagesUploadDisplayDB.IService;

namespace ImagesUploadDisplayDB.PageClass
{
    public class StudentPage
    {
        IStudentService _studentService = null;
        public StudentPage(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public string SaveInformations(byte[] fileBytes, Student oStudent)
        {
            oStudent.Photo = fileBytes;
            oStudent = _studentService.Save(oStudent);
            if(oStudent.StudentId > 0)
            {
                return "Saved";
            }
            return "Failed";
        }

        public Student GetSavedStudent()
        {
            var student = _studentService.GetSavedStudent();
            student.Photo = this.GetImage(Convert.ToBase64String(student.Photo));
            student.ImageURL = string.Format("data:image/jpg;base64," + Convert.ToBase64String(student.Photo));
            return student;
        }

        public byte[] GetImage(string sBase64String)
        {
            byte[] bytes = null;
            if (!string.IsNullOrEmpty(sBase64String))
            {
                bytes=Convert.FromBase64String(sBase64String);
            }
            return bytes;

        }
    }
}
