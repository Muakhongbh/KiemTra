using System.Security.Claims;

namespace Lab_2.Models
{
    public static class ClaimStore
    {
        public static List<Claim> GetClaims()
        {
            return new List<Claim>()
            {
                new Claim("Create","Create"),
                new Claim("Edit","Edit"),
                new Claim("Dalete","Dalete"),
            };
        }
    }
}
