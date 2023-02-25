using System;
using System.ComponentModel.DataAnnotations;

namespace PetProject_ECommerce.Models
{
    public class ProductPicture : BaseEntity
    {
        [StringLength(maximumLength: 500)]
        public string PictureUrl { get; set; }

        [StringLength(maximumLength: 100)]
        public string Title { get; set; }
        public Boolean IsDefault { get; set; }
        public int SortOrder { get; set; }
        public Guid? ProductId { get; set; }
        public Product Product { get; set; }
    }
}
