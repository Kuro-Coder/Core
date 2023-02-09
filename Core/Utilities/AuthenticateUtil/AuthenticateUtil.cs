using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

//need install System.IdentityModel.Tokens.Jwt package
namespace Core.Utilities.AuthenticateUtil
{
    /// <summary>
    /// برای تنظیمات امنیتی برنامه 
    /// </summary>
    public class AuthenticateUtil : IAuthenticateUtil
    {
        private readonly IConfiguration _configuration;
        public AuthenticateUtil(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateToken(int userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = GetTokenKey(_configuration);
            var tokenTimeOut = GetTokenTimeOut(_configuration);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("userId", userId.ToString()),
                }),

                Expires = DateTime.UtcNow.AddMinutes(tokenTimeOut),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


        private byte[] GetTokenKey(IConfiguration configuration)
        {
            //need Microsoft.Extensions.Configuration.Binder for use configuration.GetValue<>();
            var symmetricKey = Encoding.UTF8.GetBytes(configuration.GetValue<string>("TokenKey"));
            return symmetricKey;
        }

        private int GetTokenTimeOut(IConfiguration configuration)
        {
            //need Microsoft.Extensions.Configuration.Binder for use configuration.GetValue<>();
            var symmetricKey = configuration.GetValue<int>("TokenTimeOut");
            return symmetricKey;
        }
    }
}
