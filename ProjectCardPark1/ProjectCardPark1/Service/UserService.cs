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
        public User GetSavedUser()
        {
            _oUser = new User();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                var Id = 1;
                var oUser = con.Query<User>("SELECT * FROM User WHERE Id = @Id", new{ Id }).ToList();

                if (oUser != null && oUser.Count > 0)
                {
                    _oUser = oUser.FirstOrDefault();
                }
            }
            return _oUser;
        }


        public User Save(User oUser)
        {
            _oUser = new User();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                    
                var oUsers = con.Query<User>("SP_User",
                    this.SetParameters(oUser),
                    commandType:CommandType.StoredProcedure);

                if (oUsers != null && oUsers.Count() > 0)
                {
                    _oUser = oUsers.FirstOrDefault();
                }
            }
            return _oUser;
        }

        private DynamicParameters SetParameters(User oUser)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", oUser.Id);
            parameters.Add("@UserId", oUser.UserId);
            parameters.Add("@Name", oUser.Name);
            parameters.Add("@Address", oUser.Address);
            parameters.Add("@Contact", oUser.Contact);
            parameters.Add("@Stars", oUser.Stars);
            parameters.Add("@RatingId", oUser.RatingId);
            parameters.Add("@ListingId", oUser.ListingId);
            parameters.Add("@DateCreated", oUser.DateCreated);
            parameters.Add("@DateUpdated", oUser.DateUpdated);
            parameters.Add("@CreatedBy", oUser.CreatedBy);
            parameters.Add("@UpdatedBy", oUser.UpdatedBy);
            parameters.Add("@ProfileImage", oUser.ProfileImage);
            parameters.Add("@ProfileImageUrl", oUser.ProfileImageUrl);

            return parameters;
        }
    }
}
