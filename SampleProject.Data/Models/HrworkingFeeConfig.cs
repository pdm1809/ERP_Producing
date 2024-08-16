using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRWorkingFeeConfigs")]
public partial class HrworkingFeeConfig
{
    [Key]
    [Column("HRWorkingFeeConfigID")]
    public int HrworkingFeeConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("HRWorkingFeeConfigNo")]
    [StringLength(50)]
    public string HrworkingFeeConfigNo { get; set; }

    [Column("HRWorkingFeeConfigDesc")]
    [StringLength(512)]
    public string HrworkingFeeConfigDesc { get; set; }

    [Column("HRWorkingFeeConfigCost", TypeName = "decimal(18, 5)")]
    public decimal? HrworkingFeeConfigCost { get; set; }

    [Column("HRWorkingFeeConfigVehicleType")]
    [StringLength(50)]
    public string HrworkingFeeConfigVehicleType { get; set; }

    [Column("FK_GEStateProvinceID")]
    public int? FkGestateProvinceId { get; set; }

    [Column("FK_HRCostTypeConfigID")]
    public int? FkHrcostTypeConfigId { get; set; }

    [Column("HRWorkingFeeConfigAudienceGroup")]
    [StringLength(256)]
    public string HrworkingFeeConfigAudienceGroup { get; set; }

    [ForeignKey("FkGestateProvinceId")]
    [InverseProperty("HrworkingFeeConfigs")]
    public virtual GestateProvince FkGestateProvince { get; set; }

    [ForeignKey("FkHrcostTypeConfigId")]
    [InverseProperty("HrworkingFeeConfigs")]
    public virtual HrcostTypeConfig FkHrcostTypeConfig { get; set; }
}
