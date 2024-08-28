using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPurchaseContracts")]
public partial class AppurchaseContract
{
    [Key]
    [Column("APPurchaseContractID")]
    public int AppurchaseContractId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("APPurchaseContractNo")]
    [StringLength(50)]
    public string AppurchaseContractNo { get; set; }

    [Column("APPurchaseContractName")]
    [StringLength(256)]
    public string AppurchaseContractName { get; set; }

    [Column("APPurchaseContractDesc")]
    [StringLength(256)]
    public string AppurchaseContractDesc { get; set; }

    [Column("APPurchaseContractType")]
    [StringLength(50)]
    public string AppurchaseContractType { get; set; }

    [Column("APPurchaseContractParentID")]
    public int? AppurchaseContractParentId { get; set; }

    [Column("APPurchaseContractDate", TypeName = "datetime")]
    public DateTime? AppurchaseContractDate { get; set; }

    [Column("APPurchaseContractBeginDate", TypeName = "datetime")]
    public DateTime? AppurchaseContractBeginDate { get; set; }

    [Column("APPurchaseContractEndDate", TypeName = "datetime")]
    public DateTime? AppurchaseContractEndDate { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    public string ApobjectType { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_APPurchaseContractGroupID")]
    public int? FkAppurchaseContractGroupId { get; set; }

    [Column("APPurchaseContractExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseContractExchangeRate { get; set; }

    [Column("APPurchaseContractSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseContractSubTotalAmount { get; set; }

    [Column("APPurchaseContractDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseContractDiscountPercent { get; set; }

    [Column("APPurchaseContractDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseContractDiscountAmount { get; set; }

    [Column("APPurchaseContractTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseContractTaxPercent { get; set; }

    [Column("APPurchaseContractTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseContractTaxAmount { get; set; }

    [Column("APPurchaseContractTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseContractTotalAmount { get; set; }

    [Column("APPurchaseContractStatus")]
    [StringLength(50)]
    public string AppurchaseContractStatus { get; set; }

    [InverseProperty("FkAppurchaseContract")]
    public virtual ICollection<AcassetReceipt> AcassetReceipts { get; set; } = new List<AcassetReceipt>();

    [InverseProperty("FkAppurchaseContract")]
    public virtual ICollection<ApcancelPurchaseOrder> ApcancelPurchaseOrders { get; set; } = new List<ApcancelPurchaseOrder>();

    [InverseProperty("FkAppurchaseContract")]
    public virtual ICollection<ApinvoiceInTransaction> ApinvoiceInTransactions { get; set; } = new List<ApinvoiceInTransaction>();

    [InverseProperty("FkAppurchaseContract")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkAppurchaseContract")]
    public virtual ICollection<Approposal> Approposals { get; set; } = new List<Approposal>();

    [InverseProperty("FkAppurchaseContract")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkAppurchaseContract")]
    public virtual ICollection<ApreturnSupplier> ApreturnSuppliers { get; set; } = new List<ApreturnSupplier>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AppurchaseContracts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AppurchaseContracts")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AppurchaseContracts")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AppurchaseContracts")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkAppurchaseContract")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();
}
