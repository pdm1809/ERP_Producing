using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCalculateDiscounts")]
public partial class ArcalculateDiscount
{
    [Key]
    [Column("ARCalculateDiscountID")]
    public int ArcalculateDiscountId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ARCalculateDiscountNo")]
    [StringLength(50)]
    public string ArcalculateDiscountNo { get; set; }

    [Column("ARCalculateDiscountName")]
    [StringLength(256)]
    public string ArcalculateDiscountName { get; set; }

    [Column("ARCalculateDiscountDesc")]
    [StringLength(515)]
    public string ArcalculateDiscountDesc { get; set; }

    [Column("ARCalculateDiscountDate", TypeName = "datetime")]
    public DateTime? ArcalculateDiscountDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ARCalculateDiscountType")]
    [StringLength(50)]
    public string ArcalculateDiscountType { get; set; }

    [Column("FK_ARDiscountProgramID")]
    public int? FkArdiscountProgramId { get; set; }

    [Column("ARCalculateDiscountStatus")]
    [StringLength(50)]
    public string ArcalculateDiscountStatus { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ARCalculateDiscountExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArcalculateDiscountExchangeRate { get; set; }

    [Column("FK_ARCustomerDistributionChannelID")]
    public int? FkArcustomerDistributionChannelId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [InverseProperty("FkArcalculateDiscount")]
    public virtual ICollection<ArcalculateDiscountItem> ArcalculateDiscountItems { get; set; } = new List<ArcalculateDiscountItem>();

    [ForeignKey("FkArcustomerDistributionChannelId")]
    [InverseProperty("ArcalculateDiscounts")]
    public virtual ArcustomerDistributionChannel FkArcustomerDistributionChannel { get; set; }

    [ForeignKey("FkArdiscountProgramId")]
    [InverseProperty("ArcalculateDiscounts")]
    public virtual ArdiscountProgram FkArdiscountProgram { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArcalculateDiscounts")]
    public virtual Hremployee FkHremployee { get; set; }
}
