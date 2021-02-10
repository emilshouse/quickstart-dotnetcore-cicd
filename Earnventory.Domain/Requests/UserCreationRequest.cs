using System.ComponentModel.DataAnnotations;

namespace Earnventory.Domain.Requests
{
    public class UserCreationRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string OtherNames { get; set; }
    }
}