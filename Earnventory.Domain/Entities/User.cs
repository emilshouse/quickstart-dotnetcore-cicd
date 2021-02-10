using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Earnventory.Domain.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [JsonIgnore]
        [Required]
        public  byte[] Salt { get; set; }
        [Required]
        public bool Blocked { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
        public DateTime? PasswordResetAt { get; set; }
        [JsonIgnore]
        [Required]
        public  byte[] Password { get; set; }
        
        public ICollection<Transaction> Transactions { get; set; }
    }
}