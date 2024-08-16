using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMChangeBOMInformationItems")]
public partial class MmchangeBominformationItem
{
    [Key]
    [Column("MMChangeBOMInformationItemID")]
    public int MmchangeBominformationItemId { get; set; }

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
    public string Aastatus { get; set; }

    [Column("FK_MMChangeBOMInformationID")]
    public int? FkMmchangeBominformationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("MMChangeBOMInformationItemObjectName")]
    [StringLength(50)]
    public string MmchangeBominformationItemObjectName { get; set; }

    [Required]
    [Column("MMChangeBOMInformationItemNo")]
    [StringLength(50)]
    public string MmchangeBominformationItemNo { get; set; }

    [Column("MMChangeBOMInformationItemName")]
    [StringLength(512)]
    public string MmchangeBominformationItemName { get; set; }

    [Column("MMChangeBOMInformationItemDesc")]
    [StringLength(512)]
    public string MmchangeBominformationItemDesc { get; set; }

    [Column("MMChangeBOMInformationItemActionType")]
    [StringLength(50)]
    public string MmchangeBominformationItemActionType { get; set; }

    [Column("MMChangeBOMInformationItemOldValue")]
    [StringLength(512)]
    public string MmchangeBominformationItemOldValue { get; set; }

    [Column("MMChangeBOMInformationItemNewValue")]
    [StringLength(512)]
    public string MmchangeBominformationItemNewValue { get; set; }

    [Column("MMChangeBOMInformationItemHREmployeeName")]
    [StringLength(512)]
    public string MmchangeBominformationItemHremployeeName { get; set; }

    [Column("MMChangeBOMInformationItemUpdateDate", TypeName = "datetime")]
    public DateTime? MmchangeBominformationItemUpdateDate { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int? FkMmproductionNormItemId { get; set; }

    [Column("MMChangeBOMInformationItemGroup")]
    [StringLength(50)]
    public string MmchangeBominformationItemGroup { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("MMChangeBOMInformationItemBPProductionNormValues")]
    [StringLength(512)]
    public string MmchangeBominformationItemBpproductionNormValues { get; set; }

    [Column("MMChangeBOMInformationItemPNItemColumnName")]
    [StringLength(256)]
    public string MmchangeBominformationItemPnitemColumnName { get; set; }

    [Column("MMChangeBOMInformationItemBPPNItemColumnName")]
    [StringLength(256)]
    public string MmchangeBominformationItemBppnitemColumnName { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("MMChangeBOMInformationItemProductDesc")]
    [StringLength(1000)]
    public string MmchangeBominformationItemProductDesc { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmchangeBominformationItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmchangeBominformationItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmchangeBominformationItems")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmchangeBominformationId")]
    [InverseProperty("MmchangeBominformationItems")]
    public virtual MmchangeBominformation FkMmchangeBominformation { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmchangeBominformationItems")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [InverseProperty("FkMmchangeBominformationItem")]
    public virtual ICollection<MmprocessChangeDetail> MmprocessChangeDetails { get; set; } = new List<MmprocessChangeDetail>();

    [InverseProperty("FkMmchangeBominformationItem")]
    public virtual ICollection<MmprocessChangeItem> MmprocessChangeItems { get; set; } = new List<MmprocessChangeItem>();

    [InverseProperty("FkMmchangeBominformationItem")]
    public virtual ICollection<MmprocessChange> MmprocessChanges { get; set; } = new List<MmprocessChange>();
}
