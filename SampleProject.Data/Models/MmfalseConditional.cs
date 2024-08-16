using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMFalseConditionals")]
public partial class MmfalseConditional
{
    [Key]
    [Column("MMFalseConditionalID")]
    public int MmfalseConditionalId { get; set; }

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

    [Column("MMFalseConditionalNo")]
    [StringLength(100)]
    public string MmfalseConditionalNo { get; set; }

    [Column("MMFalseConditionalDate", TypeName = "datetime")]
    public DateTime? MmfalseConditionalDate { get; set; }

    [Column("MMFalseConditionalStatus")]
    [StringLength(100)]
    public string MmfalseConditionalStatus { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(100)]
    public string AcobjectType { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("MMFalseConditionalWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalWoodQty { get; set; }

    [Column("FK_HRReceiverEmployeeID")]
    public int? FkHrreceiverEmployeeId { get; set; }

    [Column("FK_HRCheckerEmployeeID")]
    public int? FkHrcheckerEmployeeId { get; set; }

    [Column("MMFalseConditionalPercentNorm", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalPercentNorm { get; set; }

    [Column("MMFalseConditionalPONo")]
    [StringLength(100)]
    public string MmfalseConditionalPono { get; set; }

    [Column("MMFalseConditionalSerialNo")]
    [StringLength(100)]
    public string MmfalseConditionalSerialNo { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("MMFalseConditionalResult")]
    [StringLength(100)]
    public string MmfalseConditionalResult { get; set; }

    [Column("MMFalseConditionalCondition")]
    [StringLength(100)]
    public string MmfalseConditionalCondition { get; set; }

    [Column("MMFalseConditionalDesc")]
    [StringLength(500)]
    public string MmfalseConditionalDesc { get; set; }

    [Column("MMFalseConditionalHyperLink")]
    [StringLength(500)]
    public string MmfalseConditionalHyperLink { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmfalseConditionals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrcheckerEmployeeId")]
    [InverseProperty("MmfalseConditionalFkHrcheckerEmployees")]
    public virtual Hremployee FkHrcheckerEmployee { get; set; }

    [ForeignKey("FkHrreceiverEmployeeId")]
    [InverseProperty("MmfalseConditionalFkHrreceiverEmployees")]
    public virtual Hremployee FkHrreceiverEmployee { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmfalseConditionals")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [InverseProperty("FkMmfalseConditional")]
    public virtual ICollection<MmfalseConditionalDetail> MmfalseConditionalDetails { get; set; } = new List<MmfalseConditionalDetail>();

    [InverseProperty("FkMmfalseConditional")]
    public virtual ICollection<MmfalseConditionalItem> MmfalseConditionalItems { get; set; } = new List<MmfalseConditionalItem>();
}
