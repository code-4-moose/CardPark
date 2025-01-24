using ProjectCardPark1.Data;
using ProjectCardPark1.Domain;

namespace ProjectCardPark1.IService
{
    public interface IUserService
    {
        User Save(User oUser);

        User GetSavedUser();

    }
}
