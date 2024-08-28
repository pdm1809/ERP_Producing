using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPriceSheets")]
public partial class AppriceSheet
{
    [Key]
    [Column("APPriceSheetID")]
    public int AppriceSheetId { get; set; }

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
    public int FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("APPriceSheetNo")]
    [StringLength(50)]
    public string AppriceSheetNo { get; set; }

    [Column("APPriceSheetName")]
    [StringLength(256)]
    public string AppriceSheetName { get; set; }

    [Column("APPriceSheetDesc")]
    [StringLength(512)]
    public string AppriceSheetDesc { get; set; }

    [Column("APPriceSheetStatus")]
    [StringLength(50)]
    public string AppriceSheetStatus { get; set; }

    [Column("APPriceSheetDate", TypeName = "datetime")]
    public DateTime? AppriceSheetDate { get; set; }

    [Column("APPriceSheetBeginDate", TypeName = "datetime")]
    public DateTime? AppriceSheetBeginDate { get; set; }

    [Column("APPriceSheetEndDate", TypeName = "datetime")]
    public DateTime? AppriceSheetEndDate { get; set; }

    [Required]
    [Column("APPriceSheetType")]
    [StringLength(50)]
    public string AppriceSheetType { get; set; }

    [Column("FK_HRApprovedEmployeeID")]
    public int? FkHrapprovedEmployeeId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(100)]
    public string ApobjectType { get; set; }

    [InverseProperty("FkAppriceSheet")]
    public virtual ICollection<AppriceSheetItem> AppriceSheetItems { get; set; } = new List<AppriceSheetItem>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AppriceSheets")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AppriceSheets")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHrapprovedEmployeeId")]
    [InverseProperty("AppriceSheetFkHrapprovedEmployees")]
    public virtual Hremployee FkHrapprovedEmployee { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AppriceSheetFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }
}
