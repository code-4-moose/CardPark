using ProjectCardPark1.Data;
using ProjectCardPark1.Domain;
using ProjectCardPark1.IService;

namespace ProjectCardPark1.PageClass
{
    public class UserPage
    {
        IUserService _userService = null;
        public UserPage(IUserService userService)
        {
            _userService = userService;
        }

        public string SaveInformations(byte[] fileBytes, User oUser)
        {
            oUser.ProfileImage = fileBytes;
            oUser = _userService.Save(oUser);
            if(oUser.Id > 0)
            {
                return "Saved";
            }
            return "Failed";
        }

        public User GetSavedUser()
        {
            var User = _userService.GetSavedUser();
            User.ProfileImage = this.GetImage(Convert.ToBase64String(User.ProfileImage));
            User.ProfileImageUrl = string.Format("data:image/jpg;base64," + Convert.ToBase64String(User.ProfileImage));
            return User;
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
