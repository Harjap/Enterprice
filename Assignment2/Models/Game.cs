namespace assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GamesID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
    }
}
