using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCancelAllocationPlans")]
public partial class MmcancelAllocationPlan
{
    [Key]
    [Column("MMCancelAllocationPlanID")]
    public int MmcancelAllocationPlanId { get; set; }

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

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMAllocationPlanID")]
    public int? FkMmallocationPlanId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMWoodPlanID")]
    public int? FkMmwoodPlanId { get; set; }

    [Required]
    [Column("MMCancelAllocationPlanNo")]
    [StringLength(50)]
    public string MmcancelAllocationPlanNo { get; set; }

    [Column("MMCancelAllocationPlanName")]
    [StringLength(100)]
    public string MmcancelAllocationPlanName { get; set; }

    [Column("MMCancelAllocationPlanDesc")]
    [StringLength(512)]
    public string MmcancelAllocationPlanDesc { get; set; }

    [Column("MMCancelAllocationPlanComment")]
    [StringLength(512)]
    public string MmcancelAllocationPlanComment { get; set; }

    [Column("MMCancelAllocationPlanDate", TypeName = "datetime")]
    public DateTime? MmcancelAllocationPlanDate { get; set; }

    [Column("MMCancelAllocationPlanType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmcancelAllocationPlanType { get; set; }

    [Column("MMCancelAllocationPlanStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmcancelAllocationPlanStatus { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("MMObjectType")]
    [StringLength(50)]
    public string MmobjectType { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmcancelAllocationPlans")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmcancelAllocationPlans")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmcancelAllocationPlans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmcancelAllocationPlans")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmcancelAllocationPlans")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmallocationPlanId")]
    [InverseProperty("MmcancelAllocationPlans")]
    public virtual MmallocationPlan FkMmallocationPlan { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmcancelAllocationPlans")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmcancelAllocationPlans")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmwoodPlanId")]
    [InverseProperty("MmcancelAllocationPlans")]
    public virtual MmwoodPlan FkMmwoodPlan { get; set; }

    [InverseProperty("FkMmcancelAllocationPlan")]
    public virtual ICollection<MmcancelAllocationPlanItem> MmcancelAllocationPlanItems { get; set; } = new List<MmcancelAllocationPlanItem>();
}
