using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APClearInvoiceIns")]
public partial class ApclearInvoiceIn
{
    [Key]
    [Column("APClearInvoiceInID")]
    public int ApclearInvoiceInId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("APClearInvoiceInNo")]
    [StringLength(50)]
    public string ApclearInvoiceInNo { get; set; }

    [Column("APClearInvoiceInDate", TypeName = "datetime")]
    public DateTime? ApclearInvoiceInDate { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    public string ApobjectType { get; set; }

    [Column("APClearInvoiceInObjectName")]
    [StringLength(216)]
    public string ApclearInvoiceInObjectName { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("APClearInvoiceInExchangeRate", TypeName = "decimal(18, 0)")]
    public decimal? ApclearInvoiceInExchangeRate { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("APClearInvoiceInStatus")]
    [StringLength(50)]
    public string ApclearInvoiceInStatus { get; set; }

    [InverseProperty("FkApclearInvoiceIn")]
    public virtual ICollection<ApclearInvoiceInDocument> ApclearInvoiceInDocuments { get; set; } = new List<ApclearInvoiceInDocument>();

    [InverseProperty("FkApclearInvoiceIn")]
    public virtual ICollection<ApclearInvoiceInInvoiceIn> ApclearInvoiceInInvoiceIns { get; set; } = new List<ApclearInvoiceInInvoiceIn>();

    [ForeignKey("FkAcaccountPurchaseId")]
    [InverseProperty("ApclearInvoiceIns")]
    public virtual Acaccount FkAcaccountPurchase { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApclearInvoiceIns")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ApclearInvoiceIns")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ApclearInvoiceIns")]
    public virtual Hremployee FkHremployee { get; set; }
}
