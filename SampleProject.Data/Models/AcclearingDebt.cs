using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACClearingDebts")]
public partial class AcclearingDebt
{
    [Key]
    [Column("ACClearingDebtID")]
    public int AcclearingDebtId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("ACClearingDebtStatus")]
    [StringLength(100)]
    public string AcclearingDebtStatus { get; set; }

    [Required]
    [Column("ACClearingDebtNo")]
    [StringLength(50)]
    public string AcclearingDebtNo { get; set; }

    [Column("ACClearingDebtDesc")]
    [StringLength(512)]
    public string AcclearingDebtDesc { get; set; }

    [Column("ACClearingDebtDate", TypeName = "datetime")]
    public DateTime? AcclearingDebtDate { get; set; }

    [Column("ACClearingDebtTypeCombo")]
    [StringLength(50)]
    public string AcclearingDebtTypeCombo { get; set; }

    [Column("ACClearingDebtExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtExchangeRate { get; set; }

    [Column("ACClearingDebtComment")]
    [StringLength(512)]
    public string AcclearingDebtComment { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("FK_ACObjectID2")]
    public int? FkAcobjectId2 { get; set; }

    [Column("ACObjectType2")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType2 { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("ACClearingDebtPostedStatus")]
    [StringLength(64)]
    public string AcclearingDebtPostedStatus { get; set; }

    [Column("ACClearingDebtAmountClearing", TypeName = "decimal(18, 5)")]
    public decimal? AcclearingDebtAmountClearing { get; set; }

    [InverseProperty("FkAcclearingDebt")]
    public virtual ICollection<AcclearingDebtInvoiceInItem> AcclearingDebtInvoiceInItems { get; set; } = new List<AcclearingDebtInvoiceInItem>();

    [InverseProperty("FkAcclearingDebt")]
    public virtual ICollection<AcclearingDebtInvoiceItem> AcclearingDebtInvoiceItems { get; set; } = new List<AcclearingDebtInvoiceItem>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcclearingDebts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcclearingDebts")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AcclearingDebts")]
    public virtual Hremployee FkHremployee { get; set; }
}
