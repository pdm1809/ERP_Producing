using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICPriceAdjustments")]
public partial class IcpriceAdjustment
{
    [Key]
    [Column("ICPriceAdjustmentID")]
    public int IcpriceAdjustmentId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("ICPriceAdjustmentNo")]
    [StringLength(50)]
    public string IcpriceAdjustmentNo { get; set; }

    [Column("ICPriceAdjustmentName")]
    [StringLength(100)]
    public string IcpriceAdjustmentName { get; set; }

    [Column("ICPriceAdjustmentDesc")]
    [StringLength(512)]
    public string IcpriceAdjustmentDesc { get; set; }

    [Column("ICPriceAdjustmentComment")]
    [StringLength(512)]
    public string IcpriceAdjustmentComment { get; set; }

    [Column("ICPriceAdjustmentDate", TypeName = "datetime")]
    public DateTime? IcpriceAdjustmentDate { get; set; }

    [Column("ICPriceAdjustmentValidateDate", TypeName = "datetime")]
    public DateTime? IcpriceAdjustmentValidateDate { get; set; }

    [Column("ICPriceAdjustmentTypeCombo")]
    [StringLength(50)]
    public string IcpriceAdjustmentTypeCombo { get; set; }

    [Column("ICPriceAdjustmentStatus")]
    [StringLength(100)]
    public string IcpriceAdjustmentStatus { get; set; }

    [Column("ICPriceAdjustmentTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcpriceAdjustmentTotalCost { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IcpriceAdjustments")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcpriceAdjustments")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkIcpriceAdjustment")]
    public virtual ICollection<IcpriceAdjustmentItem> IcpriceAdjustmentItems { get; set; } = new List<IcpriceAdjustmentItem>();
}
