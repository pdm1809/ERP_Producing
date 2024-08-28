using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICAdjustments")]
[Microsoft.EntityFrameworkCore.Index("IcadjustmentNo", "IcadjustmentDate", "FkBrbranchId", "IcadjustmentType", Name = "Idx_ICAdjustments")]
public partial class Icadjustment
{
    [Key]
    [Column("ICAdjustmentID")]
    public int IcadjustmentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("ICAdjustmentNo")]
    [StringLength(50)]
    public string IcadjustmentNo { get; set; }

    [Column("ICAdjustmentName")]
    [StringLength(50)]
    public string IcadjustmentName { get; set; }

    [Column("ICAdjustmentDesc")]
    [StringLength(512)]
    public string IcadjustmentDesc { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int FkIcstockSlotId { get; set; }

    [Required]
    [Column("ICAdjustmentType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentType { get; set; }

    [Column("ICAdjustmentDate", TypeName = "datetime")]
    public DateTime IcadjustmentDate { get; set; }

    [Required]
    [Column("ICAdjustmentReason")]
    [StringLength(512)]
    public string IcadjustmentReason { get; set; }

    [Column("ICAdjustmentStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentStatus { get; set; }

    [Column("ICAdjustmentMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode01Combo { get; set; }

    [Column("ICAdjustmentMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode02Combo { get; set; }

    [Column("ICAdjustmentMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode03Combo { get; set; }

    [Column("ICAdjustmentMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode04Combo { get; set; }

    [Column("ICAdjustmentMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode05Combo { get; set; }

    [Column("ICAdjustmentMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode06Combo { get; set; }

    [Column("ICAdjustmentMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode07Combo { get; set; }

    [Column("ICAdjustmentMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode08Combo { get; set; }

    [Column("ICAdjustmentMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode09Combo { get; set; }

    [Column("ICAdjustmentMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode10Combo { get; set; }

    [Column("ICAdjustmentMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode11Combo { get; set; }

    [Column("ICAdjustmentMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcadjustmentMatchCode12Combo { get; set; }

    [Column("ICAdjustmentOldQty", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentOldQty { get; set; }

    [Column("ICAdjustmentQty", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentQty { get; set; }

    [Column("ICAdjustmentOldCost", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentOldCost { get; set; }

    [Column("ICAdjustmentCost", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentCost { get; set; }

    [Column("ICAdjustmentDiffTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentDiffTotalCost { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Icadjustments")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("Icadjustments")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Icadjustments")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("Icadjustments")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("Icadjustments")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }

    [InverseProperty("FkIcadjustment")]
    public virtual ICollection<IcadjustmentItem> IcadjustmentItems { get; set; } = new List<IcadjustmentItem>();
}
