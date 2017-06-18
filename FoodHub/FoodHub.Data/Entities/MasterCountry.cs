namespace FoodHub.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterCountry")]
    public partial class MasterCountry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterCountry()
        {
            MasterCity = new HashSet<MasterCity>();
        }

        [Key]
        public int CountryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CountryName { get; set; }

        [Required]
        [StringLength(2)]
        public string CountryShortName { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        [StringLength(1)]
        public string CurrencyDecimalSeparator { get; set; }

        public byte? CurrencyNumDigitsAfterDecimal { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeZone { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterCity> MasterCity { get; set; }
    }
}
