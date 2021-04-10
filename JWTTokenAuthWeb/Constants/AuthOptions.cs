using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace JWTTokenAuthWeb.Constants
{
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthServer";    // token issuer
        public const string AUDIENCE = "MyAuthClient";  // token consumer
        private const string KEY = "mysupersecret_secretkey!123";   // cipher key
        public const int LIFETIME = 1;  // token lifetime - 1 minute

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
