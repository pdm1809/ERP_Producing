using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICCollections")]
public partial class Iccollection
{
    [Key]
    [Column("ICCollectionID")]
    public int IccollectionId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("ICCollectionNo")]
    [StringLength(50)]
    public string IccollectionNo { get; set; }

    [Column("ICCollectionName")]
    [StringLength(50)]
    public string IccollectionName { get; set; }

    [Column("ICCollectionDesc")]
    [StringLength(255)]
    public string IccollectionDesc { get; set; }

    [Column("ICCollectionDate", TypeName = "datetime")]
    public DateTime? IccollectionDate { get; set; }

    [Column("ICCollectionStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IccollectionStatus { get; set; }

    [Column("ICCollectionType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IccollectionType { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeApproveID")]
    public int? FkHremployeeApproveId { get; set; }

    [Column("ICCollectionApproveDate", TypeName = "datetime")]
    public DateTime? IccollectionApproveDate { get; set; }

    [InverseProperty("FkIccollection")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IccollectionFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApproveId")]
    [InverseProperty("IccollectionFkHremployeeApproves")]
    public virtual Hremployee FkHremployeeApprove { get; set; }

    [InverseProperty("FkIccollection")]
    public virtual ICollection<IccollectionItem> IccollectionItems { get; set; } = new List<IccollectionItem>();
}
