using eAppointmentServer.Application.Services;
using eAppointmentServer.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Infrastructure.Services
{
    internal sealed  class JwtProvider : IJwtProvider
    {
        public string CreateToken(AppUser user)
        {
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.FullName),
                new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                 new Claim("UserName", user.UserName ?? string.Empty),
            };
            DateTime expires = DateTime.Now.AddDays(1);
            var keyString = string.Join("-", Guid.NewGuid(), Guid.NewGuid());
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyString));

            SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha256);
            //token ayarı:
            JwtSecurityToken securityToken = new(
                issuer: "Furkan Aydemir",
                audience: "eAppointment",
                claims: claims,
                notBefore: DateTime.Now,
                expires: expires,
                signingCredentials: signingCredentials);

            JwtSecurityTokenHandler handler = new();
            string token = handler.WriteToken(securityToken);

            return token;

        }
    }
}
