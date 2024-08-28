using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductConfigRates")]
public partial class IcproductConfigRate
{
    [Key]
    [Column("ICProductConfigRateID")]
    public int IcproductConfigRateId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_STModuleID")]
    public int? FkStmoduleId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductConfigRateType")]
    [StringLength(50)]
    public string IcproductConfigRateType { get; set; }

    [Column("ICProductConfigRateValue", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConfigRateValue { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductConfigRates")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcproductConfigRates")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkStmoduleId")]
    [InverseProperty("IcproductConfigRates")]
    public virtual Stmodule FkStmodule { get; set; }
}
