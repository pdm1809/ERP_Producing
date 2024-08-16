using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlans")]
public partial class ArdeliveryPlan
{
    [Key]
    [Column("ARDeliveryPlanID")]
    public int ArdeliveryPlanId { get; set; }

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

    [Column("FK_HREmployeeApprovedID")]
    public int FkHremployeeApprovedId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("ARDeliveryPlanNo")]
    [StringLength(50)]
    public string ArdeliveryPlanNo { get; set; }

    [Column("ARDeliveryPlanName")]
    [StringLength(256)]
    public string ArdeliveryPlanName { get; set; }

    [Column("ARDeliveryPlanDesc")]
    [StringLength(512)]
    public string ArdeliveryPlanDesc { get; set; }

    [Column("ARDeliveryPlanType")]
    [StringLength(50)]
    public string ArdeliveryPlanType { get; set; }

    [Column("ARDeliveryPlanReference")]
    [StringLength(256)]
    public string ArdeliveryPlanReference { get; set; }

    [Column("ARDeliveryPlanBeginDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanBeginDate { get; set; }

    [Column("ARDeliveryPlanEndDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanEndDate { get; set; }

    [Column("ARDeliveryPlanTotalTruck")]
    public int? ArdeliveryPlanTotalTruck { get; set; }

    [Column("ARDeliveryPlanTotalM3", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTotalM3 { get; set; }

    [Column("ARDeliveryPlanStatus")]
    [StringLength(50)]
    public string ArdeliveryPlanStatus { get; set; }

    [Column("ARDeliveryPlanDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanDate { get; set; }

    [Column("ARDeliveryPlanAddNewType")]
    [StringLength(50)]
    public string ArdeliveryPlanAddNewType { get; set; }

    [Column("ARDeliveryPlanFromType")]
    [StringLength(50)]
    public string ArdeliveryPlanFromType { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ARDeliveryPlanProductType")]
    [StringLength(50)]
    public string ArdeliveryPlanProductType { get; set; }

    [Column("ARDeliveryPlanPONo")]
    [StringLength(50)]
    public string ArdeliveryPlanPono { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("ARDeliveryPlanProject")]
    [StringLength(100)]
    public string ArdeliveryPlanProject { get; set; }

    [Column("ARDeliveryPlanComment")]
    public byte[] ArdeliveryPlanComment { get; set; }

    [Column("ARDeliveryPlanContainersNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArdeliveryPlanContainersNumber { get; set; }

    [Column("ARDeliveryPlanSeal")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArdeliveryPlanSeal { get; set; }

    [Column("ARDeliveryPlanInternalSeal")]
    [StringLength(100)]
    public string ArdeliveryPlanInternalSeal { get; set; }

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<Arallocation> Arallocations { get; set; } = new List<Arallocation>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArcanceledDeliveryPlan> ArcanceledDeliveryPlans { get; set; } = new List<ArcanceledDeliveryPlan>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArdeliveryPlanFile> ArdeliveryPlanFiles { get; set; } = new List<ArdeliveryPlanFile>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArdeliveryPlanMachineDevice> ArdeliveryPlanMachineDevices { get; set; } = new List<ArdeliveryPlanMachineDevice>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArdeliveryPlanReportIssue> ArdeliveryPlanReportIssues { get; set; } = new List<ArdeliveryPlanReportIssue>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArdeliveryPlanTruckPoint> ArdeliveryPlanTruckPoints { get; set; } = new List<ArdeliveryPlanTruckPoint>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArdeliveryPlanTruck> ArdeliveryPlanTrucks { get; set; } = new List<ArdeliveryPlanTruck>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArdeliveryPlanWorkAsset> ArdeliveryPlanWorkAssets { get; set; } = new List<ArdeliveryPlanWorkAsset>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<ArdeliveryPlanWork> ArdeliveryPlanWorks { get; set; } = new List<ArdeliveryPlanWork>();

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<Arreception> Arreceptions { get; set; } = new List<Arreception>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ArdeliveryPlans")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArdeliveryPlans")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArdeliveryPlans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArdeliveryPlanFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("ArdeliveryPlanFkHremployeeApproveds")]
    public virtual Hremployee FkHremployeeApproved { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ArdeliveryPlans")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArdeliveryPlans")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ArdeliveryPlans")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("ArdeliveryPlans")]
    public virtual Pmtemplate FkPmtemplate { get; set; }

    [InverseProperty("FkArdeliveryPlan")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();
}
