namespace FoodHub.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MasterCategoryImages
    {
        [Key]
        public long CategoryImageId { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(500)]
        public string ImageURL { get; set; }

        public virtual MasterCategory MasterCategory { get; set; }
    }
}
