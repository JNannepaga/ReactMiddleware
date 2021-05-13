using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace SchoolManagement.Web
{
    public class TokenManager
    {
        private static string Secret = "U0NIT09MTUFOQUdFTUVOVF9LRVlATUFMSVBTLkNPTQ=="; //SCHOOLMANAGEMENT_KEY @MALIPS.COM

        public static string GenerateToken(string userName, string role)
        {
            byte[] key = Convert.FromBase64String(Secret);
            
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims: new[] 
                { 
                    new Claim(type: ClaimTypes.Name, value: userName),
                    new Claim(type: ClaimTypes.Role, value: role)
                }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(
                                            key: securityKey,
                                            algorithm: SecurityAlgorithms.HmacSha256)
            };

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken token = handler.CreateJwtSecurityToken(tokenDescriptor);
            return handler.WriteToken(token);
        } 

        public static ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtsecurityToken = (JwtSecurityToken)tokenHandler.ReadJwtToken(token);
                if (jwtsecurityToken == null)
                    return null;

                byte[] key = Convert.FromBase64String(Secret);
                TokenValidationParameters tokenValidationParams = new TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };

                SecurityToken securityToken;

                ClaimsPrincipal claimsPrincipal = tokenHandler.ValidateToken(token, tokenValidationParams, out securityToken);
                return claimsPrincipal;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}