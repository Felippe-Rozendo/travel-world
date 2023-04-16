using System.ComponentModel.DataAnnotations;

namespace travel_world_api.Model.Auth
{
    public class LoginModelRequest
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = String.Empty;
    }
}
