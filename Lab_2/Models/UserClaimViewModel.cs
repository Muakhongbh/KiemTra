using System.Security.Claims;

namespace Lab_2.Models
{
    public class UserClaimViewModel
    {
        // khai báo contractir 
        public UserClaimViewModel()
        {
            Claims = new List<UserClaim>();
        }
        public string UserId { get; set; }
        public List<UserClaim> Claims { get; set; }
    }
}
