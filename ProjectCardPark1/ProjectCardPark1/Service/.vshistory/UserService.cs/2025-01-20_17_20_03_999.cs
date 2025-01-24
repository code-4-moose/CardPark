using Dapper;
using ProjectCardPark1.Data;
using ProjectCardPark1.IService;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using ProjectCardPark1.Domain;



namespace ProjectCardPark1.Service
{
    public class UserService : IUserService
    {
        User _oUser = new User(); 
        public User GetSavedStudent()
        {
            _oUser = new User();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                var StudentId = 9;
                var oStudents = con.Query<Student>("SELECT * FROM Students WHERE StudentId = @StudentId", new{ StudentId }).ToList();

                if (oStudents != null && oStudents.Count > 0)
                {
                    _oStudent = oStudents.FirstOrDefault();
                }
            }
            return _oStudent;
        }

        public Student Save(Student oStudent)
        {
            _oStudent = new Student();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();

                var oStudents = con.Query<Student>("SP_Student",
                    this.SetParameters(oStudent),
                    commandType:CommandType.StoredProcedure);

                if (oStudents != null && oStudents.Count() > 0)
                {
                    _oStudent = oStudents.FirstOrDefault();
                }
            }
            return _oStudent;
        }

        private DynamicParameters SetParameters(Student oStudent)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@StudentId", oStudent.StudentId);
            parameters.Add("@Name", oStudent.Name);
            parameters.Add("@Roll", oStudent.Roll);
            parameters.Add("@Photo", oStudent.Photo);
            return parameters;
        }
    }
}
