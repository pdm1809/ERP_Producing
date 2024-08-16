using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectNorms")]
public partial class PmprojectNorm
{
    [Key]
    [Column("PMProjectNormID")]
    public int PmprojectNormId { get; set; }

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

    [Column("FK_PMTemplateItemID")]
    public int? FkPmtemplateItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_PMPhaseTypeID")]
    public int? FkPmphaseTypeId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("PMProjectNormProductType")]
    [StringLength(50)]
    public string PmprojectNormProductType { get; set; }

    [Column("PMProjectNormTypeCombo")]
    [StringLength(50)]
    public string PmprojectNormTypeCombo { get; set; }

    [Column("PMProjectNormSortOrder")]
    public int? PmprojectNormSortOrder { get; set; }

    [Column("PMProjectNormProductDesc", TypeName = "ntext")]
    public string PmprojectNormProductDesc { get; set; }

    [Column("PMProjectNormProductBasicUnit")]
    [StringLength(50)]
    public string PmprojectNormProductBasicUnit { get; set; }

    [Column("PMProjectNormProductPackagingUnit")]
    [StringLength(50)]
    public string PmprojectNormProductPackagingUnit { get; set; }

    [Column("PMProjectNormProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormProductPackagingFactor { get; set; }

    [Column("PMProjectNormProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormProductUnitCost { get; set; }

    [Column("PMProjectNormProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormProductQtyOld { get; set; }

    [Column("PMProjectNormProductQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormProductQty { get; set; }

    [Column("PMProjectNormProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormProductBasicQty { get; set; }

    [Column("PMProjectNormProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormProductPakagingQty { get; set; }

    [Column("PMProjectNormQty1", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormQty1 { get; set; }

    [Column("PMProjectNormQty2", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormQty2 { get; set; }

    [Column("PMProjectNormQty3", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormQty3 { get; set; }

    [Column("PMProjectNormQty4", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormQty4 { get; set; }

    [Column("PMProjectNormQty5", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormQty5 { get; set; }

    [Column("PMProjectNormQty6", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormQty6 { get; set; }

    [Column("PMProjectNormComment")]
    [StringLength(50)]
    public string PmprojectNormComment { get; set; }

    [Column("PMProjectNormUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormUnitVolumn { get; set; }

    [Column("PMProjectNormUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormUnitWeight { get; set; }

    [Column("PMProjectNormPlusCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormPlusCost { get; set; }

    [Column("PMProjectNormTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTotalCost { get; set; }

    [Column("PMProjectNormStartDate", TypeName = "datetime")]
    public DateTime? PmprojectNormStartDate { get; set; }

    [Column("PMProjectNormEndDate", TypeName = "datetime")]
    public DateTime? PmprojectNormEndDate { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductWorkGroupID")]
    public int? FkIcproductWorkGroupId { get; set; }

    [Column("FK_ICProductWorkGroupParentID")]
    public int? FkIcproductWorkGroupParentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("PMProjectNormParentID")]
    public int? PmprojectNormParentId { get; set; }

    [Column("PMProjectNormProductNo")]
    [StringLength(50)]
    public string PmprojectNormProductNo { get; set; }

    [Column("PMProjectNormProductName")]
    [StringLength(256)]
    public string PmprojectNormProductName { get; set; }

    [Column("PMProjectNormType")]
    [StringLength(50)]
    public string PmprojectNormType { get; set; }

    [Column("PMProjectNormProductNetWeight", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormProductNetWeight { get; set; }

    [Column("PMProjectNormStatus")]
    [StringLength(50)]
    public string PmprojectNormStatus { get; set; }

    [Column("PMProjectNormIsApproved")]
    public bool? PmprojectNormIsApproved { get; set; }

    [InverseProperty("FkPmprojectNorm")]
    public virtual ICollection<ArestimateItem> ArestimateItems { get; set; } = new List<ArestimateItem>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("PmprojectNorms")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("PmprojectNorms")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("PmprojectNorms")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmprojectNorms")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("PmprojectNorms")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductWorkGroupId")]
    [InverseProperty("PmprojectNormFkIcproductWorkGroups")]
    public virtual IcproductWorkGroup FkIcproductWorkGroup { get; set; }

    [ForeignKey("FkIcproductWorkGroupParentId")]
    [InverseProperty("PmprojectNormFkIcproductWorkGroupParents")]
    public virtual IcproductWorkGroup FkIcproductWorkGroupParent { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("PmprojectNorms")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkPmphaseTypeId")]
    [InverseProperty("PmprojectNorms")]
    public virtual PmphaseType FkPmphaseType { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmprojectNorms")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("PmprojectNorms")]
    public virtual Pmtemplate FkPmtemplate { get; set; }

    [ForeignKey("FkPmtemplateItemId")]
    [InverseProperty("PmprojectNorms")]
    public virtual PmtemplateItem FkPmtemplateItem { get; set; }

    [InverseProperty("FkPmprojectNorm")]
    public virtual ICollection<PmprojectNormHistory> PmprojectNormHistories { get; set; } = new List<PmprojectNormHistory>();

    [InverseProperty("FkPmprojectNorm")]
    public virtual ICollection<PmprojectNormItem> PmprojectNormItems { get; set; } = new List<PmprojectNormItem>();

    [InverseProperty("FkPmprojectNorm")]
    public virtual ICollection<PmprojectNormTask> PmprojectNormTasks { get; set; } = new List<PmprojectNormTask>();
}
