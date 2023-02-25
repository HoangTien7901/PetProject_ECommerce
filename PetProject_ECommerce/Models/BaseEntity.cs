using System;
using System.ComponentModel.DataAnnotations;

namespace PetProject_ECommerce.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Guid? CreatorId { get; set; }

        public bool Pubished { get; set; }
    }
}
