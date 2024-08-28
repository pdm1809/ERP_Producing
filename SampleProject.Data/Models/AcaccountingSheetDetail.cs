using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAccountingSheetDetails")]
public partial class AcaccountingSheetDetail
{
    [Key]
    [Column("ACAccountingSheetDetailID")]
    public int AcaccountingSheetDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACAccountingSheetID")]
    public int? FkAcaccountingSheetId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ACAccountingSheetDetailAcountNumber")]
    [StringLength(10)]
    public string AcaccountingSheetDetailAcountNumber { get; set; }

    [Column("ACAccountingSheetDetailAcountName")]
    [StringLength(200)]
    public string AcaccountingSheetDetailAcountName { get; set; }

    [Column("ACAccountingSheetDetailDesc")]
    [StringLength(200)]
    public string AcaccountingSheetDetailDesc { get; set; }

    [Column("ACAccountingSheetDetailType")]
    [StringLength(200)]
    public string AcaccountingSheetDetailType { get; set; }

    [Column("ACAccountingSheetDetailStartPeriodBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcaccountingSheetDetailStartPeriodBalance { get; set; }

    [Column("ACAccountingSheetDetailEndPeriodBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcaccountingSheetDetailEndPeriodBalance { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcaccountingSheetDetails")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcaccountingSheetId")]
    [InverseProperty("AcaccountingSheetDetails")]
    public virtual AcaccountingSheet FkAcaccountingSheet { get; set; }
}
