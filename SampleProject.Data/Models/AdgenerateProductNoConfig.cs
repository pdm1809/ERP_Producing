using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADGenerateProductNoConfigs")]
public partial class AdgenerateProductNoConfig
{
    [Key]
    [Column("ADGenerateProductNoConfigID")]
    public int AdgenerateProductNoConfigId { get; set; }

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

    [Column("ADGenerateProductNoConfigIsProductNo")]
    public bool? AdgenerateProductNoConfigIsProductNo { get; set; }

    [Column("ADGenerateProductNoConfigIsDepartmentNo")]
    public bool? AdgenerateProductNoConfigIsDepartmentNo { get; set; }

    [Column("ADGenerateProductNoConfigIsProductGroupNo")]
    public bool? AdgenerateProductNoConfigIsProductGroupNo { get; set; }

    [Column("ADGenerateProductNoConfigIsPrefixYear")]
    public bool? AdgenerateProductNoConfigIsPrefixYear { get; set; }

    [Column("ADGenerateProductNoConfigPrefix")]
    [StringLength(50)]
    public string AdgenerateProductNoConfigPrefix { get; set; }

    [Column("ADGenerateProductNoConfigLength")]
    public int? AdgenerateProductNoConfigLength { get; set; }

    [Column("ADGenerateProductNoConfigStart")]
    public int? AdgenerateProductNoConfigStart { get; set; }

    [Column("ADGenerateProductNoConfigCode01Combo")]
    [StringLength(256)]
    public string AdgenerateProductNoConfigCode01Combo { get; set; }

    [Column("ADGenerateProductNoConfigCode02Combo")]
    [StringLength(256)]
    public string AdgenerateProductNoConfigCode02Combo { get; set; }

    [Column("ADGenerateProductNoConfigCode03Combo")]
    [StringLength(256)]
    public string AdgenerateProductNoConfigCode03Combo { get; set; }

    [Column("ADGenerateProductNoConfigCode04Combo")]
    [StringLength(256)]
    public string AdgenerateProductNoConfigCode04Combo { get; set; }

    [Column("ADGenerateProductNoConfigCode05Combo")]
    [StringLength(256)]
    public string AdgenerateProductNoConfigCode05Combo { get; set; }

    [Column("ADGenerateProductNoConfigCode06Combo")]
    [StringLength(256)]
    public string AdgenerateProductNoConfigCode06Combo { get; set; }

    [Column("ADGenerateProductNoConfigCode07Combo")]
    [StringLength(256)]
    public string AdgenerateProductNoConfigCode07Combo { get; set; }

    [Column("ADGenerateProductNoConfigCode08Combo")]
    [StringLength(256)]
    public string AdgenerateProductNoConfigCode08Combo { get; set; }

    [Column("ADGenerateProductNoConfigCode09Combo")]
    [StringLength(256)]
    public string AdgenerateProductNoConfigCode09Combo { get; set; }

    [Column("ADGenerateProductNoConfigCode10Combo")]
    [StringLength(256)]
    public string AdgenerateProductNoConfigCode10Combo { get; set; }

    [Column("ADGenerateProductNoConfigIsActive")]
    public int? AdgenerateProductNoConfigIsActive { get; set; }
}
