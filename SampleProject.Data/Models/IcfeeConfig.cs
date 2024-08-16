using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICFeeConfigs")]
public partial class IcfeeConfig
{
    [Key]
    [Column("ICFeeConfigID")]
    public int IcfeeConfigId { get; set; }

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

    [Required]
    [Column("ICFeeConfigName")]
    [StringLength(100)]
    public string IcfeeConfigName { get; set; }

    [Column("ICFeeConfigAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcfeeConfigAmount { get; set; }

    [Column("ICFeeType")]
    [StringLength(50)]
    public string IcfeeType { get; set; }

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("ICFeeConfigContCal")]
    public bool? IcfeeConfigContCal { get; set; }

    [Column("ICTerminalType")]
    [StringLength(50)]
    public string IcterminalType { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICPeriod")]
    [StringLength(50)]
    public string Icperiod { get; set; }

    [Column("ICFeeConfigVAT", TypeName = "decimal(18, 5)")]
    public decimal? IcfeeConfigVat { get; set; }

    [Column("ICFeeConfigNo")]
    [StringLength(100)]
    public string IcfeeConfigNo { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [InverseProperty("FkIcfeeConfig")]
    public virtual ICollection<ApfeePaymentFeeConfig> ApfeePaymentFeeConfigs { get; set; } = new List<ApfeePaymentFeeConfig>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("IcfeeConfigs")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkGelocationId")]
    [InverseProperty("IcfeeConfigs")]
    public virtual Gelocation FkGelocation { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcfeeConfigs")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }
}
