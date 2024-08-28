using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADUserLocations")]
public partial class AduserLocation
{
    [Key]
    [Column("ADUserLocationID")]
    public int AduserLocationId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ADUserID")]
    public int FkAduserId { get; set; }

    [Column("ADUserLocationLongitude", TypeName = "decimal(18, 5)")]
    public decimal? AduserLocationLongitude { get; set; }

    [Column("ADUserLocationLatitude", TypeName = "decimal(18, 5)")]
    public decimal? AduserLocationLatitude { get; set; }

    [Column("ADUserLocationLastDate", TypeName = "datetime")]
    public DateTime? AduserLocationLastDate { get; set; }

    [ForeignKey("FkAduserId")]
    [InverseProperty("AduserLocations")]
    public virtual Aduser FkAduser { get; set; }
}
