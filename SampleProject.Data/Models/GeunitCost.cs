using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEUnitCosts")]
public partial class GeunitCost
{
    [Key]
    [Column("GEUnitCostID")]
    public int GeunitCostId { get; set; }

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

    [Column("GEUnitCostNo")]
    [StringLength(50)]
    public string GeunitCostNo { get; set; }

    [Column("GEUnitCostName")]
    [StringLength(50)]
    public string GeunitCostName { get; set; }

    [InverseProperty("FkGeunitCost")]
    public virtual ICollection<ApfeePaymentFeeConfig> ApfeePaymentFeeConfigs { get; set; } = new List<ApfeePaymentFeeConfig>();

    [InverseProperty("FkGeunitCost")]
    public virtual ICollection<IcreceiptItemContFee> IcreceiptItemContFees { get; set; } = new List<IcreceiptItemContFee>();
}
