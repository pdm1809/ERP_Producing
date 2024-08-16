using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEGenerateProductNoConfigs")]
public partial class GegenerateProductNoConfig
{
    [Key]
    [Column("GEGenerateProductNoConfigID")]
    public int GegenerateProductNoConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int FkIcdepartmentId { get; set; }

    [Column("GEGenerateProductNoConfigIsProductNo")]
    public bool? GegenerateProductNoConfigIsProductNo { get; set; }

    [Column("GEGenerateProductNoConfigIsDepartmentNo")]
    public bool? GegenerateProductNoConfigIsDepartmentNo { get; set; }

    [Column("GEGenerateProductNoConfigIsProductGroupNo")]
    public bool? GegenerateProductNoConfigIsProductGroupNo { get; set; }

    [Column("GEGenerateProductNoConfigIsPrefixYear")]
    public bool? GegenerateProductNoConfigIsPrefixYear { get; set; }

    [Column("GEGenerateProductNoConfigPrefix")]
    [StringLength(50)]
    public string GegenerateProductNoConfigPrefix { get; set; }

    [Column("GEGenerateProductNoConfigLength")]
    public int? GegenerateProductNoConfigLength { get; set; }

    [Column("GEGenerateProductNoConfigStart")]
    public int? GegenerateProductNoConfigStart { get; set; }

    [Column("GEGenerateProductNoConfigJoinCharacter")]
    [StringLength(50)]
    public string GegenerateProductNoConfigJoinCharacter { get; set; }

    [Column("GEGenerateProductNoConfigCode01Combo")]
    [StringLength(256)]
    public string GegenerateProductNoConfigCode01Combo { get; set; }

    [Column("GEGenerateProductNoConfigCode02Combo")]
    [StringLength(256)]
    public string GegenerateProductNoConfigCode02Combo { get; set; }

    [Column("GEGenerateProductNoConfigCode03Combo")]
    [StringLength(256)]
    public string GegenerateProductNoConfigCode03Combo { get; set; }

    [Column("GEGenerateProductNoConfigCode04Combo")]
    [StringLength(256)]
    public string GegenerateProductNoConfigCode04Combo { get; set; }

    [Column("GEGenerateProductNoConfigCode05Combo")]
    [StringLength(256)]
    public string GegenerateProductNoConfigCode05Combo { get; set; }

    [Column("GEGenerateProductNoConfigCode06Combo")]
    [StringLength(256)]
    public string GegenerateProductNoConfigCode06Combo { get; set; }

    [Column("GEGenerateProductNoConfigCode07Combo")]
    [StringLength(256)]
    public string GegenerateProductNoConfigCode07Combo { get; set; }

    [Column("GEGenerateProductNoConfigCode08Combo")]
    [StringLength(256)]
    public string GegenerateProductNoConfigCode08Combo { get; set; }

    [Column("GEGenerateProductNoConfigCode09Combo")]
    [StringLength(256)]
    public string GegenerateProductNoConfigCode09Combo { get; set; }

    [Column("GEGenerateProductNoConfigCode10Combo")]
    [StringLength(256)]
    public string GegenerateProductNoConfigCode10Combo { get; set; }

    [Column("GEGenerateProductNoConfigIsActive")]
    public bool? GegenerateProductNoConfigIsActive { get; set; }

    [Column("GEGenerateProductNoConfigGroupLevels")]
    public int? GegenerateProductNoConfigGroupLevels { get; set; }
}
