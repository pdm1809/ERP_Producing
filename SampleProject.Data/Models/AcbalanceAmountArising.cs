using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACBalanceAmountArisings")]
public partial class AcbalanceAmountArising
{
    [Key]
    [Column("ACBalanceAmountArisingID")]
    public int AcbalanceAmountArisingId { get; set; }

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

    [Column("ACBalanceAmountArisingNo")]
    [StringLength(50)]
    public string AcbalanceAmountArisingNo { get; set; }

    [Column("ACBalanceAmountArisingStatus")]
    [StringLength(100)]
    public string AcbalanceAmountArisingStatus { get; set; }

    [Column("ACBalanceAmountArisingName")]
    [StringLength(512)]
    public string AcbalanceAmountArisingName { get; set; }

    [Column("ACBalanceAmountArisingDesc")]
    [StringLength(512)]
    public string AcbalanceAmountArisingDesc { get; set; }

    [Column("ACBalanceAmountArisingFromDate", TypeName = "datetime")]
    public DateTime? AcbalanceAmountArisingFromDate { get; set; }

    [Column("ACBalanceAmountArisingToDate", TypeName = "datetime")]
    public DateTime? AcbalanceAmountArisingToDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [InverseProperty("FkAcbalanceAmountArising")]
    public virtual ICollection<AcbalanceAmountArisingDetail> AcbalanceAmountArisingDetails { get; set; } = new List<AcbalanceAmountArisingDetail>();

    [InverseProperty("FkAcbalanceAmountArising")]
    public virtual ICollection<AcbalanceAmountArisingObjectDetail> AcbalanceAmountArisingObjectDetails { get; set; } = new List<AcbalanceAmountArisingObjectDetail>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcbalanceAmountArisings")]
    public virtual Brbranch FkBrbranch { get; set; }
}
