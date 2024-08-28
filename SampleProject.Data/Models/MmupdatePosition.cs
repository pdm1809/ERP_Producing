using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMUpdatePositions")]
public partial class MmupdatePosition
{
    [Key]
    [Column("MMUpdatePositionID")]
    public int MmupdatePositionId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HREmployeeIDApproved")]
    public int? FkHremployeeIdapproved { get; set; }

    [Column("MMUpdatePositionDate", TypeName = "datetime")]
    public DateTime? MmupdatePositionDate { get; set; }

    [Required]
    [Column("MMUpdatePositionStatus")]
    [StringLength(50)]
    public string MmupdatePositionStatus { get; set; }

    [Required]
    [Column("MMUpdatePositionNo")]
    [StringLength(50)]
    public string MmupdatePositionNo { get; set; }

    [Column("MMUpdatePositionDesc")]
    [StringLength(512)]
    public string MmupdatePositionDesc { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmupdatePositionFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeIdapproved")]
    [InverseProperty("MmupdatePositionFkHremployeeIdapprovedNavigations")]
    public virtual Hremployee FkHremployeeIdapprovedNavigation { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("MmupdatePositions")]
    public virtual Icstock FkIcstock { get; set; }

    [InverseProperty("FkMmupdatePosition")]
    public virtual ICollection<MmupdatePositionItem> MmupdatePositionItems { get; set; } = new List<MmupdatePositionItem>();
}
