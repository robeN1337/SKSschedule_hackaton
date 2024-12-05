using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.Models;

public partial class User
{
    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fio { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public int? GroupId { get; set; }

    public int RoleId { get; set; }

    public virtual Group? Group { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();

}

public interface ITokenService
{
    string CreateToken(string UserLogin);
}

public class TokenService : ITokenService
{

    private readonly SymmetricSecurityKey _key;
    public TokenService(IConfiguration config)
    {
        _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"]!));
    }

    public string CreateToken(string UserLogin)
    {
        var claims = new List<Claim>{
         new Claim(JwtRegisteredClaimNames.Name, UserLogin)
       };

        var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

        var tokenDecriptor = new SecurityTokenDescriptor()
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = creds
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDecriptor);
        return tokenHandler.WriteToken(token);

    }
}
