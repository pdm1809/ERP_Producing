using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectLocations")]
public partial class PmprojectLocation
{
    [Key]
    [Column("PMProjectLocationID")]
    public int PmprojectLocationId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("FK_GEStateProvinceID")]
    public int? FkGestateProvinceId { get; set; }

    [Column("FK_GEDistrictID")]
    public int? FkGedistrictId { get; set; }

    [Column("PMProjectLocationName")]
    [StringLength(256)]
    public string PmprojectLocationName { get; set; }

    [Column("PMProjectLocationAddress")]
    [StringLength(512)]
    public string PmprojectLocationAddress { get; set; }

    [ForeignKey("FkGedistrictId")]
    [InverseProperty("PmprojectLocations")]
    public virtual Gedistrict FkGedistrict { get; set; }

    [ForeignKey("FkGelocationId")]
    [InverseProperty("PmprojectLocations")]
    public virtual Gelocation FkGelocation { get; set; }

    [ForeignKey("FkGestateProvinceId")]
    [InverseProperty("PmprojectLocations")]
    public virtual GestateProvince FkGestateProvince { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmprojectLocations")]
    public virtual Pmproject FkPmproject { get; set; }
}
