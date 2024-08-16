using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACClearingDebtInvoiceItems")]
public partial class AcclearingDebtInvoiceItem
{
    [Key]
    [Column("ACClearingDebtInvoiceItemID")]
    public int AcclearingDebtInvoiceItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACClearingDebtID")]
    public int? FkAcclearingDebtId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("ACClearingDebtInvoiceItemDate", TypeName = "datetime")]
    public DateTime? AcclearingDebtInvoiceItemDate { get; set; }

    [Column("ACClearingDebtInvoiceItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtInvoiceItemTotalAmount { get; set; }

    [Column("ACClearingDebtInvoiceItemPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtInvoiceItemPaidAmount { get; set; }

    [Column("ACClearingDebtInvoiceItemRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtInvoiceItemRemainAmount { get; set; }

    [Column("ACClearingDebtInvoiceItemAmountClearing", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtInvoiceItemAmountClearing { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACClearingDebtInvoiceItemExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtInvoiceItemExchangeRate { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ACClearingDebtInvoiceItemGroup")]
    [StringLength(50)]
    public string AcclearingDebtInvoiceItemGroup { get; set; }

    [Column("ACClearingDebtInvoiceItemReferenceID")]
    public int? AcclearingDebtInvoiceItemReferenceId { get; set; }

    [Column("ACClearingDebtInvoiceItemReferenceNo")]
    [StringLength(128)]
    public string AcclearingDebtInvoiceItemReferenceNo { get; set; }

    [Column("ACClearingDebtInvoiceItemModuleName")]
    [StringLength(128)]
    public string AcclearingDebtInvoiceItemModuleName { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcclearingDebtInvoiceItems")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcclearingDebtId")]
    [InverseProperty("AcclearingDebtInvoiceItems")]
    public virtual AcclearingDebt FkAcclearingDebt { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("AcclearingDebtInvoiceItems")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("AcclearingDebtInvoiceItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcclearingDebtInvoiceItems")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
