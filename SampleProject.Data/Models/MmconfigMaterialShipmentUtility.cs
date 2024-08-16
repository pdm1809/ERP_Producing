using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMConfigMaterialShipmentUtilitys")]
public partial class MmconfigMaterialShipmentUtility
{
    [Key]
    [Column("MMConfigMaterialShipmentUtilityID")]
    public int MmconfigMaterialShipmentUtilityId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("MMConfigMaterialShipmentUtilityType")]
    [StringLength(50)]
    public string MmconfigMaterialShipmentUtilityType { get; set; }
}
