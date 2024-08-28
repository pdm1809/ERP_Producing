using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCreditNotes")]
[Microsoft.EntityFrameworkCore.Index("ArcreditNoteNo", "ArcreditNoteDate", "FkBrbranchId", "FkArcustomerId", "ArcreditNoteType", Name = "Idx_ARCreditNotes")]
public partial class ArcreditNote
{
    [Key]
    [Column("ARCreditNoteID")]
    public int ArcreditNoteId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("ARCreditNoteNo")]
    [StringLength(50)]
    public string ArcreditNoteNo { get; set; }

    [Column("ARCreditNoteName")]
    [StringLength(100)]
    public string ArcreditNoteName { get; set; }

    [Column("ARCreditNoteDesc")]
    [StringLength(512)]
    public string ArcreditNoteDesc { get; set; }

    [Column("ARCreditNoteDate", TypeName = "datetime")]
    public DateTime? ArcreditNoteDate { get; set; }

    [Column("ARCreditNoteExpiryDate", TypeName = "datetime")]
    public DateTime? ArcreditNoteExpiryDate { get; set; }

    [Column("ARCreditNoteType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcreditNoteType { get; set; }

    [Column("ARCreditNoteStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcreditNoteStatus { get; set; }

    [Column("ARCreditNoteTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteTotalAmount { get; set; }

    [Column("ARCreditNoteDueAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteDueAmount { get; set; }

    [Column("ARCreditNoteExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARCreditNoteTransferredDate", TypeName = "datetime")]
    public DateTime? ArcreditNoteTransferredDate { get; set; }

    [InverseProperty("FkArcreditNote")]
    public virtual ICollection<ArcreditNoteInvoice> ArcreditNoteInvoices { get; set; } = new List<ArcreditNoteInvoice>();

    [InverseProperty("FkArcreditNote")]
    public virtual ICollection<ArcreditNoteItem> ArcreditNoteItems { get; set; } = new List<ArcreditNoteItem>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcreditNotes")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArcreditNotes")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArcreditNotes")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArcreditNotes")]
    public virtual Hremployee FkHremployee { get; set; }
}
