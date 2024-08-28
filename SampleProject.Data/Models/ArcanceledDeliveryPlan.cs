using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCanceledDeliveryPlans")]
public partial class ArcanceledDeliveryPlan
{
    [Key]
    [Column("ARCanceledDeliveryPlanID")]
    public int ArcanceledDeliveryPlanId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ARDeliveryPlanID")]
    public int? FkArdeliveryPlanId { get; set; }

    [Required]
    [Column("ARCanceledDeliveryPlanNo")]
    [StringLength(50)]
    public string ArcanceledDeliveryPlanNo { get; set; }

    [Column("ARCanceledDeliveryPlanName")]
    [StringLength(100)]
    public string ArcanceledDeliveryPlanName { get; set; }

    [Column("ARCanceledDeliveryPlanDesc")]
    [StringLength(512)]
    public string ArcanceledDeliveryPlanDesc { get; set; }

    [Column("ARCanceledDeliveryPlanComment")]
    [StringLength(512)]
    public string ArcanceledDeliveryPlanComment { get; set; }

    [Column("ARCanceledDeliveryPlanDate", TypeName = "datetime")]
    public DateTime? ArcanceledDeliveryPlanDate { get; set; }

    [Column("ARCanceledDeliveryPlanType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcanceledDeliveryPlanType { get; set; }

    [Column("ARCanceledDeliveryPlanStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcanceledDeliveryPlanStatus { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [InverseProperty("FkArcanceledDeliveryPlan")]
    public virtual ICollection<ArcanceledDeliveryPlanItem> ArcanceledDeliveryPlanItems { get; set; } = new List<ArcanceledDeliveryPlanItem>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ArcanceledDeliveryPlans")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArcanceledDeliveryPlans")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArcanceledDeliveryPlans")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArcanceledDeliveryPlans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArcanceledDeliveryPlans")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ArcanceledDeliveryPlans")]
    public virtual Pmproject FkPmproject { get; set; }
}
