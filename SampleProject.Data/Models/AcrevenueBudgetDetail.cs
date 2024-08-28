using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACRevenueBudgetDetails")]
public partial class AcrevenueBudgetDetail
{
    [Key]
    [Column("ACRevenueBudgetDetailID")]
    public int AcrevenueBudgetDetailId { get; set; }

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

    [Column("FK_ACRevenueBudgetID")]
    public int FkAcrevenueBudgetId { get; set; }

    [Column("ACRevenueBudgetDetailFromDate", TypeName = "datetime")]
    public DateTime? AcrevenueBudgetDetailFromDate { get; set; }

    [Column("ACRevenueBudgetDetailToDate", TypeName = "datetime")]
    public DateTime? AcrevenueBudgetDetailToDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ACCustomerType")]
    [StringLength(50)]
    public string AccustomerType { get; set; }

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int FkAccreditAccountId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("ACRevenueBudgetDetailAmount", TypeName = "decimal(18, 0)")]
    public decimal? AcrevenueBudgetDetailAmount { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACRevenueBudgetDetailExchangeRate", TypeName = "decimal(18, 0)")]
    public decimal? AcrevenueBudgetDetailExchangeRate { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AcrevenueBudgetDetailFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AcrevenueBudgetDetailFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcrevenueBudgetId")]
    [InverseProperty("AcrevenueBudgetDetails")]
    public virtual AcrevenueBudget FkAcrevenueBudget { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("AcrevenueBudgetDetails")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcrevenueBudgetDetails")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcrevenueBudgetDetails")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGelocationId")]
    [InverseProperty("AcrevenueBudgetDetails")]
    public virtual Gelocation FkGelocation { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcrevenueBudgetDetails")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("AcrevenueBudgetDetails")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcrevenueBudgetDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("AcrevenueBudgetDetails")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
