namespace WebApplication12.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gallery")]
    public partial class gallery
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public string link { get; set; }
    }
}
