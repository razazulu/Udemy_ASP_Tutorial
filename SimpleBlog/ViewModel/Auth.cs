using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.ViewModel
{
    public class AuthLogin
    {
        [Required]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}