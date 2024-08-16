using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePieceWages")]
public partial class HremployeePieceWage
{
    [Key]
    [Column("HREmployeePieceWageID")]
    public int HremployeePieceWageId { get; set; }

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

    [Column("FK_HRProductPieceWageID")]
    public int? FkHrproductPieceWageId { get; set; }

    [Required]
    [Column("HREmployeePieceWageNo")]
    [StringLength(50)]
    public string HremployeePieceWageNo { get; set; }

    [Column("HREmployeePieceWageName")]
    [StringLength(100)]
    public string HremployeePieceWageName { get; set; }

    [Column("HREmployeePieceWageDesc")]
    [StringLength(512)]
    public string HremployeePieceWageDesc { get; set; }

    [Column("HREmployeePieceWageFromDate", TypeName = "datetime")]
    public DateTime HremployeePieceWageFromDate { get; set; }

    [Column("HREmployeePieceWageToDate", TypeName = "datetime")]
    public DateTime HremployeePieceWageToDate { get; set; }

    [Column("HREmployeePieceWageDate", TypeName = "datetime")]
    public DateTime? HremployeePieceWageDate { get; set; }

    [Column("HREmployeeCardNumber")]
    [StringLength(200)]
    public string HremployeeCardNumber { get; set; }

    [Column("HREmployeeName")]
    [StringLength(200)]
    public string HremployeeName { get; set; }

    [Column("HREmployeePieceWageHaveMeal")]
    public bool? HremployeePieceWageHaveMeal { get; set; }

    [Column("HREmployeePieceWageDateEnd", TypeName = "datetime")]
    public DateTime? HremployeePieceWageDateEnd { get; set; }

    [Column("HREmployeePieceWageStatus")]
    [StringLength(50)]
    public string HremployeePieceWageStatus { get; set; }

    [Column("HREmployeePieceWageProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePieceWageProductUnitPrice { get; set; }

    [Column("HREmployeePieceWagePlanProductTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePieceWagePlanProductTotalQty { get; set; }

    [Column("HREmployeePieceWageRealProductTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePieceWageRealProductTotalQty { get; set; }

    [Column("HREmployeePieceWageRealProductTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePieceWageRealProductTotalAmount { get; set; }

    [ForeignKey("FkHrproductPieceWageId")]
    [InverseProperty("HremployeePieceWages")]
    public virtual HrproductPieceWage FkHrproductPieceWage { get; set; }

    [InverseProperty("FkHremployeePieceWage")]
    public virtual ICollection<HremployeePieceWageItem> HremployeePieceWageItems { get; set; } = new List<HremployeePieceWageItem>();
}
