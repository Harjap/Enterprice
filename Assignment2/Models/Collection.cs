namespace assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Collection")]
    public partial class Collection
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CollectionID { get; set; }

        public int GameID { get; set; }

        public int DesignerID { get; set; }

        [Required]
        [StringLength(400)]
        public string Description { get; set; }
        [Column(TypeName="numeric")]
        [DisplayFormat(DataFormatString="{0:c}")]
        public int Price { get; set; }
    }
}
