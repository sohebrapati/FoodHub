namespace FoodHub.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Restaurant")]
    public partial class Restaurant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Restaurant()
        {
            RestaurantCategory = new HashSet<RestaurantCategory>();
        }

        public long RestaurantId { get; set; }

        [Required]
        [StringLength(100)]
        public string RestaurantName { get; set; }

        public int CityId { get; set; }

        [StringLength(25)]
        public string Region { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(12)]
        public string Pincode { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public TimeSpan? DeliveryHrsFrom { get; set; }

        public TimeSpan? DeliveryHrsTo { get; set; }

        [StringLength(15)]
        public string MobileNo { get; set; }

        [StringLength(15)]
        public string LandlineNo { get; set; }

        [StringLength(10)]
        public string PriceBucket { get; set; }

        public bool? IsActive { get; set; }

        public virtual MasterCity MasterCity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantCategory> RestaurantCategory { get; set; }
    }
}
