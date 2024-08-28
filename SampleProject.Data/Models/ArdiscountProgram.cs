using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDiscountPrograms")]
public partial class ArdiscountProgram
{
    [Key]
    [Column("ARDiscountProgramID")]
    public int ArdiscountProgramId { get; set; }

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

    [Column("ARDiscountProgramNo")]
    [StringLength(50)]
    public string ArdiscountProgramNo { get; set; }

    [Column("ARDiscountProgramName")]
    [StringLength(256)]
    public string ArdiscountProgramName { get; set; }

    [Column("ARDiscountProgramDesc")]
    [StringLength(515)]
    public string ArdiscountProgramDesc { get; set; }

    [Column("ARDiscountProgramDate", TypeName = "datetime")]
    public DateTime? ArdiscountProgramDate { get; set; }

    [Column("ARDiscountProgramBeginDate", TypeName = "datetime")]
    public DateTime? ArdiscountProgramBeginDate { get; set; }

    [Column("ARDiscountProgramEndDate", TypeName = "datetime")]
    public DateTime? ArdiscountProgramEndDate { get; set; }

    [Required]
    [Column("ARDiscountProgramType")]
    [StringLength(80)]
    public string ArdiscountProgramType { get; set; }

    [Column("ARDiscountProgramMethodType")]
    [StringLength(50)]
    public string ArdiscountProgramMethodType { get; set; }

    [Column("ARDiscountProgramApplyType")]
    [StringLength(100)]
    public string ArdiscountProgramApplyType { get; set; }

    [Column("ARDiscountProgramCalMethod")]
    [StringLength(50)]
    public string ArdiscountProgramCalMethod { get; set; }

    [Column("ARDiscountProgramValue", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramValue { get; set; }

    [Column("ARDiscountProgramApplyOn")]
    [StringLength(50)]
    public string ArdiscountProgramApplyOn { get; set; }

    [Column("ARDiscountProgramStatus")]
    [StringLength(50)]
    public string ArdiscountProgramStatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_ARCustomerDistributionChannelID")]
    public int? FkArcustomerDistributionChannelId { get; set; }

    [Column("ARDiscountProgramIsExhibit")]
    public bool? ArdiscountProgramIsExhibit { get; set; }

    [Column("ARDiscountProgramIsSales")]
    public bool? ArdiscountProgramIsSales { get; set; }

    [Column("ARDiscountProgramSaleTarget", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramSaleTarget { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ARDiscountProgramCode")]
    [StringLength(256)]
    public string ArdiscountProgramCode { get; set; }

    [Column("ARDiscountProgramTogether")]
    public bool? ArdiscountProgramTogether { get; set; }

    [Column("ARDiscountProgramQuantityApplied")]
    public int? ArdiscountProgramQuantityApplied { get; set; }

    [Column("ARDiscountProgramRemainQuantityApplied")]
    public int? ArdiscountProgramRemainQuantityApplied { get; set; }

    [Column("ARDiscountProgramIsVoucher")]
    public bool? ArdiscountProgramIsVoucher { get; set; }

    [InverseProperty("FkArdiscountProgram")]
    public virtual ICollection<ArcalculateDiscount> ArcalculateDiscounts { get; set; } = new List<ArcalculateDiscount>();

    [InverseProperty("FkArdiscountProgram")]
    public virtual ICollection<ArdiscountProgramItemTarget> ArdiscountProgramItemTargets { get; set; } = new List<ArdiscountProgramItemTarget>();

    [InverseProperty("FkArdiscountProgram")]
    public virtual ICollection<ArdiscountProgramItem> ArdiscountProgramItems { get; set; } = new List<ArdiscountProgramItem>();

    [ForeignKey("FkArcustomerDistributionChannelId")]
    [InverseProperty("ArdiscountPrograms")]
    public virtual ArcustomerDistributionChannel FkArcustomerDistributionChannel { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArdiscountPrograms")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArdiscountPrograms")]
    public virtual Hremployee FkHremployee { get; set; }
}
