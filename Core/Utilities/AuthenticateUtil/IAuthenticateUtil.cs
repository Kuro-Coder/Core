
using F4ST.Common.Containers;

namespace Core.Utilities.AuthenticateUtil
{
    //add F4ST.Common package for use ISingleton
    public interface IAuthenticateUtil : ISingleton
    {
        string CreateToken(int userId);
    }
}
