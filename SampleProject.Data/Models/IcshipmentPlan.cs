using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipmentPlans")]
public partial class IcshipmentPlan
{
    [Key]
    [Column("ICShipmentPlanID")]
    public int IcshipmentPlanId { get; set; }

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

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ICShipmentPlanNo")]
    [StringLength(50)]
    public string IcshipmentPlanNo { get; set; }

    [Column("ICShipmentPlanDesc")]
    [StringLength(512)]
    public string IcshipmentPlanDesc { get; set; }

    [Column("ICShipmentPlanType")]
    [StringLength(50)]
    public string IcshipmentPlanType { get; set; }

    [Column("ICShipmentPlanReference")]
    [StringLength(256)]
    public string IcshipmentPlanReference { get; set; }

    [Column("ICShipmentPlanBeginDate", TypeName = "datetime")]
    public DateTime? IcshipmentPlanBeginDate { get; set; }

    [Column("ICShipmentPlanEndDate", TypeName = "datetime")]
    public DateTime? IcshipmentPlanEndDate { get; set; }

    [Column("ICShipmentPlanTotalTruck")]
    public int? IcshipmentPlanTotalTruck { get; set; }

    [Column("ICShipmentPlanStatus")]
    [StringLength(50)]
    public string IcshipmentPlanStatus { get; set; }

    [Column("ICShipmentPlanDate", TypeName = "datetime")]
    public DateTime? IcshipmentPlanDate { get; set; }

    [Column("ICShipmentPlanAddNewType")]
    [StringLength(50)]
    public string IcshipmentPlanAddNewType { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IcshipmentPlans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcshipmentPlanFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("IcshipmentPlanFkHremployeeApproveds")]
    public virtual Hremployee FkHremployeeApproved { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcshipmentPlans")]
    public virtual Icstock FkIcstock { get; set; }
}
