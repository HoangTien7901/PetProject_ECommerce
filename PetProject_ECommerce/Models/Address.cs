using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetProject_ECommerce.Models
{
    public class Address : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string AddressLine { get; set; }
        public string Phone { get; set; }
        public int Status { get; set; }
    }
}
