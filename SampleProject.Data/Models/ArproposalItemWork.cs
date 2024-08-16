using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARProposalItemWorks")]
public partial class ArproposalItemWork
{
    [Key]
    [Column("ARProposalItemWorkID")]
    public int ArproposalItemWorkId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARProposalItemID")]
    public int? FkArproposalItemId { get; set; }

    [Column("FK_ARProposalID")]
    public int? FkArproposalId { get; set; }

    [Column("ARProposalItemWorkProductNo")]
    [StringLength(50)]
    public string ArproposalItemWorkProductNo { get; set; }

    [Column("ARProposalItemWorkProductName")]
    [StringLength(256)]
    public string ArproposalItemWorkProductName { get; set; }

    [Column("ARProposalItemWorkProductDesc")]
    [StringLength(512)]
    public string ArproposalItemWorkProductDesc { get; set; }

    [Column("ARProposalItemWorkProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkProductQty { get; set; }

    [Column("ARProposalItemWorkProductType")]
    [StringLength(50)]
    public string ArproposalItemWorkProductType { get; set; }

    [Column("ARProposalItemWorkProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkProductUnitPrice { get; set; }

    [Column("ARProposalItemWorkTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTotalAmount { get; set; }

    [Column("ARProposalItemWorkSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkSubTotalAmount { get; set; }

    [Column("ARProposalItemWorkProductChargeCheck")]
    public bool? ArproposalItemWorkProductChargeCheck { get; set; }

    [Column("ARProposalItemWorkStatus")]
    [StringLength(50)]
    public string ArproposalItemWorkStatus { get; set; }

    [Column("ARProposalItemWorkType")]
    [StringLength(50)]
    public string ArproposalItemWorkType { get; set; }

    [Column("ARProposalItemWorkParentID")]
    public int? ArproposalItemWorkParentId { get; set; }

    [Column("ARProposalItemWorkComment")]
    [StringLength(256)]
    public string ArproposalItemWorkComment { get; set; }

    [Column("ARProposalItemWorkDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkDiscountAmount { get; set; }

    [Column("ARProposalItemWorkDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkDiscountPerCent { get; set; }

    [InverseProperty("FkArproposalItemWork")]
    public virtual ICollection<ArproposalItemWorkItem> ArproposalItemWorkItems { get; set; } = new List<ArproposalItemWorkItem>();

    [InverseProperty("FkArproposalItemWork")]
    public virtual ICollection<ArproposalItemWorkTask> ArproposalItemWorkTasks { get; set; } = new List<ArproposalItemWorkTask>();

    [ForeignKey("FkArproposalId")]
    [InverseProperty("ArproposalItemWorks")]
    public virtual Arproposal FkArproposal { get; set; }

    [ForeignKey("FkArproposalItemId")]
    [InverseProperty("ArproposalItemWorks")]
    public virtual ArproposalItem FkArproposalItem { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArproposalItemWorks")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArproposalItemWorks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArproposalItemWorks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArproposalItemWorks")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
