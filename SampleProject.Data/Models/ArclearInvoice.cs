using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARClearInvoices")]
public partial class ArclearInvoice
{
    [Key]
    [Column("ARClearInvoiceID")]
    public int ArclearInvoiceId { get; set; }

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
    [Column("ARClearInvoiceNo")]
    [StringLength(50)]
    public string ArclearInvoiceNo { get; set; }

    [Column("ARClearInvoiceDate", TypeName = "datetime")]
    public DateTime? ArclearInvoiceDate { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("ARClearInvoiceObjectName")]
    [StringLength(216)]
    public string ArclearInvoiceObjectName { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ARClearInvoiceExchangeRate", TypeName = "decimal(18, 0)")]
    public decimal? ArclearInvoiceExchangeRate { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("ARClearInvoiceStatus")]
    [StringLength(50)]
    public string ArclearInvoiceStatus { get; set; }

    [Column("ARClearInvoicePostedStatus")]
    [StringLength(100)]
    public string ArclearInvoicePostedStatus { get; set; }

    [InverseProperty("FkArclearInvoice")]
    public virtual ICollection<ArclearInvoiceDocument> ArclearInvoiceDocuments { get; set; } = new List<ArclearInvoiceDocument>();

    [InverseProperty("FkArclearInvoice")]
    public virtual ICollection<ArclearInvoiceInvoice> ArclearInvoiceInvoices { get; set; } = new List<ArclearInvoiceInvoice>();

    [ForeignKey("FkAcaccountSaleId")]
    [InverseProperty("ArclearInvoices")]
    public virtual Acaccount FkAcaccountSale { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArclearInvoices")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArclearInvoices")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArclearInvoices")]
    public virtual Hremployee FkHremployee { get; set; }
}
