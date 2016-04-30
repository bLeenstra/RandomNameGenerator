using System;
using System.Security.Cryptography;

namespace RandomNameGenerator
{
    public class Person
    {
        public string Name;
        public Gender Sex;
        public Login UserInfo;

        public void SetLoginInfo()
        {
            UserInfo = new Login();
            Random rng = new Random();
            UserInfo.Username = Name + rng.Next(00,99).ToString("##");

            using (Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(UserInfo.Username, Program.SaltSize, Program.Iterations))
            {
                byte[] passwordBytes = deriveBytes.GetBytes(Program.KeySize);
                UserInfo.Password = Convert.ToBase64String(passwordBytes);
            }
            
        }
    }
}