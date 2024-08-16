using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GERegions")]
public partial class Geregion
{
    [Key]
    [Column("GERegionID")]
    public int GeregionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("GERegionCode")]
    [StringLength(50)]
    public string GeregionCode { get; set; }

    [Required]
    [Column("GERegionName")]
    [StringLength(256)]
    public string GeregionName { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("Geregions")]
    public virtual Gecountry FkGecountry { get; set; }

    [InverseProperty("FkGeregion")]
    public virtual ICollection<GestateProvince> GestateProvinces { get; set; } = new List<GestateProvince>();
}
