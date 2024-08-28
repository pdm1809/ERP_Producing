using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEndingAllocations")]
public partial class AcendingAllocation
{
    [Key]
    [Column("ACEndingAllocationID")]
    public int AcendingAllocationId { get; set; }

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

    [Required]
    [Column("ACEndingAllocationNo")]
    [StringLength(50)]
    public string AcendingAllocationNo { get; set; }

    [Column("ACEndingAllocationDate", TypeName = "datetime")]
    public DateTime? AcendingAllocationDate { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACEndingAllocationExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcendingAllocationExchangeRate { get; set; }

    [Column("ACEndingAllocationDesc")]
    [StringLength(512)]
    public string AcendingAllocationDesc { get; set; }

    [Column("ACEndingAllocationFromDate", TypeName = "datetime")]
    public DateTime? AcendingAllocationFromDate { get; set; }

    [Column("ACEndingAllocationToDate", TypeName = "datetime")]
    public DateTime? AcendingAllocationToDate { get; set; }

    [Column("FK_ACEndingAllocationDeclarationID")]
    public int? FkAcendingAllocationDeclarationId { get; set; }

    [Column("ACEndingAllocationPostedStatus")]
    [StringLength(64)]
    public string AcendingAllocationPostedStatus { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [InverseProperty("FkAcendingAllocation")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItems { get; set; } = new List<AcendingAllocationItem>();

    [ForeignKey("FkAcendingAllocationDeclarationId")]
    [InverseProperty("AcendingAllocations")]
    public virtual AcendingAllocationDeclaration FkAcendingAllocationDeclaration { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcendingAllocations")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcendingAllocations")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
