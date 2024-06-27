using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace Reddit.Models
{
    public class User :IdentityUser
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        public virtual ICollection<Community>? SubscribedCommunities { get; set; } = new List<Community>();

        public virtual ICollection<Community>? OwnedCommunities { get; set; } = new List<Community>();
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

    }
}