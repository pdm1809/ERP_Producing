using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEStreets")]
public partial class Gestreet
{
    [Key]
    [Column("GEStreetID")]
    public int GestreetId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("GEStreetCode")]
    [StringLength(50)]
    public string GestreetCode { get; set; }

    [Required]
    [Column("GEStreetName")]
    [StringLength(256)]
    public string GestreetName { get; set; }

    [Column("FK_GEWardID")]
    public int? FkGewardId { get; set; }

    [InverseProperty("FkGedeliveryStreet")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [ForeignKey("FkGewardId")]
    [InverseProperty("Gestreets")]
    public virtual Geward FkGeward { get; set; }
}
