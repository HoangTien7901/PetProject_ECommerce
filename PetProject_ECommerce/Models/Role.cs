using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetProject_ECommerce.Models
{
    public class Role : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        public int Status { get; set; }

        public ICollection<UserRole> Users { get; set; }
    }
}
