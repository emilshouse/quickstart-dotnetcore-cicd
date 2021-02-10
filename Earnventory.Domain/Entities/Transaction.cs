using System;
using System.ComponentModel.DataAnnotations;

namespace Earnventory.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }
        
        [Required]
        public string Action { get; set; }
    }
}