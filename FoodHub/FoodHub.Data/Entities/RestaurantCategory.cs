namespace FoodHub.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantCategory")]
    public partial class RestaurantCategory
    {
        [Key]
        public int RestCategId { get; set; }

        public long? RestaurantId { get; set; }

        public int? CategoryId { get; set; }

        public virtual MasterCategory MasterCategory { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
