using System.ComponentModel.DataAnnotations;

namespace Lab15_C.Request
{
    public class UserRequest
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
