using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARProductionPlannings")]
public partial class ArproductionPlanning
{
    [Key]
    [Column("ARProductionPlanningID")]
    public int ArproductionPlanningId { get; set; }

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

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Required]
    [Column("ARProductionPlanningNo")]
    [StringLength(50)]
    public string ArproductionPlanningNo { get; set; }

    [Column("ARProductionPlanningName")]
    [StringLength(100)]
    public string ArproductionPlanningName { get; set; }

    [Column("ARProductionPlanningStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArproductionPlanningStatus { get; set; }

    [Column("ARProductionPlanningDate", TypeName = "datetime")]
    public DateTime? ArproductionPlanningDate { get; set; }

    [Column("ARProductionPlanningFromDate", TypeName = "datetime")]
    public DateTime? ArproductionPlanningFromDate { get; set; }

    [Column("ARProductionPlanningToDate", TypeName = "datetime")]
    public DateTime? ArproductionPlanningToDate { get; set; }

    [Column("ARProductionPlanningWeek")]
    [StringLength(512)]
    public string ArproductionPlanningWeek { get; set; }

    [Column("ARProductionPlanningTypeCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArproductionPlanningTypeCombo { get; set; }

    [Column("ARProductionPlanningCBM", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningCbm { get; set; }

    [Column("ARProductionPlanningContQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningContQty { get; set; }

    [Column("ARProductionPlanningTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningTotalAmount { get; set; }

    [Column("ARProductionPlanningDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningDepositBalance { get; set; }

    [Column("ARProductionPlanningBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningBalanceDue { get; set; }

    [Column("ARProductionPlanningDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningDiscountPerCent { get; set; }

    [Column("ARProductionPlanningDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningDiscountFix { get; set; }

    [Column("ARProductionPlanningTaxPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningTaxPerCent { get; set; }

    [Column("ARProductionPlanningTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningTaxAmount { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("ARProductionPlanningTotalBlock", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningTotalBlock { get; set; }

    [Column("ARProductionPlanningSources")]
    [StringLength(50)]
    public string ArproductionPlanningSources { get; set; }

    [Column("ARProductionPlanningApprovedDate", TypeName = "datetime")]
    public DateTime? ArproductionPlanningApprovedDate { get; set; }

    [Column("FK_HREmployeeApprovedID")]
    public int? FkHremployeeApprovedId { get; set; }

    [Column("ARProductionPlanningType")]
    [StringLength(50)]
    public string ArproductionPlanningType { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("ARProductionPlanningSaleType")]
    [StringLength(50)]
    public string ArproductionPlanningSaleType { get; set; }

    [Column("ARProductionPlanningDesc")]
    public byte[] ArproductionPlanningDesc { get; set; }

    [Column("ARProductionPlanningComment")]
    [StringLength(500)]
    public string ArproductionPlanningComment { get; set; }

    [Column("ARProductionPlanningSaleOrderName")]
    [StringLength(256)]
    public string ArproductionPlanningSaleOrderName { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [InverseProperty("FkArproductionPlanning")]
    public virtual ICollection<ArcontainerLoader> ArcontainerLoaders { get; set; } = new List<ArcontainerLoader>();

    [InverseProperty("FkArproductionPlanning")]
    public virtual ICollection<ArproductionPlanningItem> ArproductionPlanningItems { get; set; } = new List<ArproductionPlanningItem>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArproductionPlannings")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArproductionPlannings")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArproductionPlanningFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("ArproductionPlanningFkHremployeeApproveds")]
    public virtual Hremployee FkHremployeeApproved { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ArproductionPlannings")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("ArproductionPlannings")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkArproductionPlanning")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItems { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkArproductionPlanning")]
    public virtual ICollection<MmbatchProduct> MmbatchProducts { get; set; } = new List<MmbatchProduct>();
}
