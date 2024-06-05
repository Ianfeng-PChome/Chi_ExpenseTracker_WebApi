using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chi_ExpenseTracker_Repesitory.Models
{
    public partial class UserEntity
    {
        [Key]
        public string UserId { get; set; } = null!;

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string? RefreshToken { get; set; }

        public string? Role { get; set; }
    }
}


