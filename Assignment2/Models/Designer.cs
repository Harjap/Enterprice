namespace assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Designer")]
    public partial class Designer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DesignerID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }
    }
}
