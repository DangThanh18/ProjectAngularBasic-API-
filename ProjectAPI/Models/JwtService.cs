﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProjectAPI.Models
{
    public class JwtService
    {
        //public string SecretKey {  get; set; }
        //public int TokenDuration { get; set; }
        //private readonly IConfiguration config;

        //public JwtService(IConfiguration _config)
        //{
        //    config = _config;
        //    this.SecretKey = config.GetSection("jwtConfig").GetSection("Key").Value;
        //    this.TokenDuration = Int32.Parse(config.GetSection("jwtConfig").GetSection("Duration").Value);
        //}

        //public string GenerateToken(User user)
        //{
        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.SecretKey));
        //    var signature = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //    var payload = new[]
        //    {
        //        new Claim("id", user.UserID.ToString()),
        //        new Claim("username", user.UserName),
        //        new Claim("password", user.PassWord),
        //        new Claim("email", user.Email),
        //        new Claim("mobile", user.PhoneNumber),
        //        new Claim("gender", user.Gender),
        //        new Claim("userType", user.UserType.ToString()),
        //    };

        //    var jwtToken = new JwtSecurityToken(
        //        issuer: "localhost",
        //        audience: "localhost",
        //        claims: payload,
        //        expires: DateTime.Now.AddMinutes(TokenDuration),
        //        signingCredentials: signature);

        //    return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        //}
    }
}
