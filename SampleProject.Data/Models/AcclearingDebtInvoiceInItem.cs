using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACClearingDebtInvoiceInItems")]
public partial class AcclearingDebtInvoiceInItem
{
    [Key]
    [Column("ACClearingDebtInvoiceInItemID")]
    public int AcclearingDebtInvoiceInItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACClearingDebtID")]
    public int? FkAcclearingDebtId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("ACClearingDebtInvoiceInItemDate", TypeName = "datetime")]
    public DateTime? AcclearingDebtInvoiceInItemDate { get; set; }

    [Column("ACClearingDebtInvoiceInItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtInvoiceInItemTotalAmount { get; set; }

    [Column("ACClearingDebtInvoiceInItemPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtInvoiceInItemPaidAmount { get; set; }

    [Column("ACClearingDebtInvoiceInItemRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtInvoiceInItemRemainAmount { get; set; }

    [Column("ACClearingDebtInvoiceInItemAmountClearing", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtInvoiceInItemAmountClearing { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACClearingDebtInvoiceInItemExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtInvoiceInItemExchangeRate { get; set; }

    [Column("FK_ACDocumentID")]
    public int? FkAcdocumentId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ACClearingDebtInvoiceInItemGroup")]
    [StringLength(50)]
    public string AcclearingDebtInvoiceInItemGroup { get; set; }

    [Column("ACClearingDebtInvoiceInItemReferenceID")]
    public int? AcclearingDebtInvoiceInItemReferenceId { get; set; }

    [Column("ACClearingDebtInvoiceInItemReferenceNo")]
    [StringLength(128)]
    public string AcclearingDebtInvoiceInItemReferenceNo { get; set; }

    [Column("ACClearingDebtInvoiceInItemModuleName")]
    [StringLength(128)]
    public string AcclearingDebtInvoiceInItemModuleName { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcclearingDebtInvoiceInItems")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcclearingDebtId")]
    [InverseProperty("AcclearingDebtInvoiceInItems")]
    public virtual AcclearingDebt FkAcclearingDebt { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcclearingDebtInvoiceInItems")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("AcclearingDebtInvoiceInItems")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AcclearingDebtInvoiceInItems")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcclearingDebtInvoiceInItems")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
