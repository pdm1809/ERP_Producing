using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class VAcaccountingLedger
{
    [Column("ACDocumentID")]
    public int AcdocumentId { get; set; }

    [Column("ACDocumentEntryID")]
    public int? AcdocumentEntryId { get; set; }

    [Column("ACDocumentTypeName")]
    [StringLength(50)]
    public string AcdocumentTypeName { get; set; }

    [Required]
    [Column("ACDocumentNo")]
    [StringLength(50)]
    public string AcdocumentNo { get; set; }

    [Column("ACDocumentDate", TypeName = "date")]
    public DateTime? AcdocumentDate { get; set; }

    [Column("ACAccountID")]
    public int? AcaccountId { get; set; }

    [Column("ACAccountNo")]
    [StringLength(50)]
    public string AcaccountNo { get; set; }

    [Column("ACAccountName")]
    [StringLength(100)]
    public string AcaccountName { get; set; }

    [Column("ACAccountReciprocalID")]
    public int? AcaccountReciprocalId { get; set; }

    [Column("ACAccountReciprocalNo")]
    [StringLength(50)]
    public string AcaccountReciprocalNo { get; set; }

    [Column("ACAccountReciprocalName")]
    [StringLength(512)]
    public string AcaccountReciprocalName { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Required]
    [Column("GECurrencyName")]
    [StringLength(50)]
    public string GecurrencyName { get; set; }

    [Column("ACDocumentExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentExchangeRate { get; set; }

    [Column("ACDocumentEntryDebitAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentEntryDebitAmount { get; set; }

    [Column("ACDocumentEntryCreditAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentEntryCreditAmount { get; set; }

    [Column("ACDocumentEntryDebitExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentEntryDebitExchangeAmount { get; set; }

    [Column("ACDocumentEntryCreditExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentEntryCreditExchangeAmount { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ACDocumentDesc")]
    [StringLength(1024)]
    public string AcdocumentDesc { get; set; }

    public int IsCredit { get; set; }

    [Required]
    [Column("ACDocumentVoucherNo")]
    [StringLength(50)]
    public string AcdocumentVoucherNo { get; set; }

    [Column("ACDocumentEntryDesc")]
    [StringLength(1024)]
    public string AcdocumentEntryDesc { get; set; }
}
