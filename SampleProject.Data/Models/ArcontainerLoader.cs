using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARContainerLoaders")]
public partial class ArcontainerLoader
{
    [Key]
    [Column("ARContainerLoaderID")]
    public int ArcontainerLoaderId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Required]
    [Column("ARContainerLoaderNo")]
    [StringLength(50)]
    public string ArcontainerLoaderNo { get; set; }

    [Column("ARContainerLoaderName")]
    [StringLength(100)]
    public string ArcontainerLoaderName { get; set; }

    [Column("ARContainerLoaderDate", TypeName = "datetime")]
    public DateTime? ArcontainerLoaderDate { get; set; }

    [Column("ARContainerLoaderDesc")]
    [StringLength(512)]
    public string ArcontainerLoaderDesc { get; set; }

    [Column("ARContainerLoaderComment")]
    [StringLength(512)]
    public string ArcontainerLoaderComment { get; set; }

    [Column("ARContainerLoaderStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcontainerLoaderStatus { get; set; }

    [Column("ARContainerLoaderReference")]
    [StringLength(512)]
    public string ArcontainerLoaderReference { get; set; }

    [Column("ARContainerLoaderTypeCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcontainerLoaderTypeCombo { get; set; }

    [Column("FK_GEContainerID")]
    public int? FkGecontainerId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("ARContainerLoaderContNo")]
    [StringLength(100)]
    public string ArcontainerLoaderContNo { get; set; }

    [Column("ARContainerLoaderDelivery", TypeName = "datetime")]
    public DateTime? ArcontainerLoaderDelivery { get; set; }

    [Column("ARContainerLoaderSealNo")]
    [StringLength(50)]
    public string ArcontainerLoaderSealNo { get; set; }

    [Column("FK_ARProductionPlanningID")]
    public int? FkArproductionPlanningId { get; set; }

    [Column("ARContainerLoaderTrainRunDate", TypeName = "datetime")]
    public DateTime? ArcontainerLoaderTrainRunDate { get; set; }

    [Column("ARContainerLoaderObjectName")]
    [StringLength(1000)]
    public string ArcontainerLoaderObjectName { get; set; }

    [Column("ARContainerLoaderPONo")]
    [StringLength(50)]
    public string ArcontainerLoaderPono { get; set; }

    [InverseProperty("FkArcontainerLoader")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [InverseProperty("FkArcontainerLoader")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkArcontainerLoader")]
    public virtual ICollection<ArproductionPlanningItem> ArproductionPlanningItems { get; set; } = new List<ArproductionPlanningItem>();

    [ForeignKey("FkArproductionPlanningId")]
    [InverseProperty("ArcontainerLoaders")]
    public virtual ArproductionPlanning FkArproductionPlanning { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArcontainerLoaders")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecontainerId")]
    [InverseProperty("ArcontainerLoaders")]
    public virtual Gecontainer FkGecontainer { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArcontainerLoaders")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ArcontainerLoaders")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [InverseProperty("FkArcontainerLoader")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();
}
