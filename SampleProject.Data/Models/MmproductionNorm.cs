using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNorms")]
public partial class MmproductionNorm
{
    [Key]
    [Column("MMProductionNormID")]
    public int MmproductionNormId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Required]
    [Column("MMProductionNormNo")]
    [StringLength(50)]
    public string MmproductionNormNo { get; set; }

    [Required]
    [Column("MMProductionNormName")]
    [StringLength(50)]
    public string MmproductionNormName { get; set; }

    [Column("MMProductionNormDesc")]
    [StringLength(512)]
    public string MmproductionNormDesc { get; set; }

    [Column("MMProductionNormWoodStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmproductionNormWoodStatus { get; set; }

    [Column("MMProductionNormHardwareStatus")]
    [StringLength(50)]
    public string MmproductionNormHardwareStatus { get; set; }

    [Column("MMProductionNormPaintStatus")]
    [StringLength(50)]
    public string MmproductionNormPaintStatus { get; set; }

    [Column("MMProductionNormPackingMaterialStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmproductionNormPackingMaterialStatus { get; set; }

    [Column("FK_HREmployeeWoodValidate")]
    public int? FkHremployeeWoodValidate { get; set; }

    [Column("FK_HREmployeeWoodApprove")]
    public int? FkHremployeeWoodApprove { get; set; }

    [Column("FK_HREmployeeHardwareValidate")]
    public int? FkHremployeeHardwareValidate { get; set; }

    [Column("FK_HREmployeeHardwareApprove")]
    public int? FkHremployeeHardwareApprove { get; set; }

    [Column("FK_HREmployeePaintApprove")]
    public int? FkHremployeePaintApprove { get; set; }

    [Column("FK_HREmployeePaintValidate")]
    public int? FkHremployeePaintValidate { get; set; }

    [Column("FK_HREmployeePackingMaterialApprove")]
    public int? FkHremployeePackingMaterialApprove { get; set; }

    [Column("FK_HREmployeePackingMaterialValidate")]
    public int? FkHremployeePackingMaterialValidate { get; set; }

    [Column("MMProductionNormWoodValidateDate", TypeName = "datetime")]
    public DateTime? MmproductionNormWoodValidateDate { get; set; }

    [Column("MMProductionNormWoodApproveDate", TypeName = "datetime")]
    public DateTime? MmproductionNormWoodApproveDate { get; set; }

    [Column("MMProductionNormHardwareValidateDate", TypeName = "datetime")]
    public DateTime? MmproductionNormHardwareValidateDate { get; set; }

    [Column("MMProductionNormHardwareApproveDate", TypeName = "datetime")]
    public DateTime? MmproductionNormHardwareApproveDate { get; set; }

    [Column("MMProductionNormPaintValidateDate", TypeName = "datetime")]
    public DateTime? MmproductionNormPaintValidateDate { get; set; }

    [Column("MMProductionNormPaintApproveDate", TypeName = "datetime")]
    public DateTime? MmproductionNormPaintApproveDate { get; set; }

    [Column("MMProductionNormPackingMaterialValidateDate", TypeName = "datetime")]
    public DateTime? MmproductionNormPackingMaterialValidateDate { get; set; }

    [Column("MMProductionNormPackingMaterialApproveDate", TypeName = "datetime")]
    public DateTime? MmproductionNormPackingMaterialApproveDate { get; set; }

    [Column("MMProductionNormDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormDepreciationRate { get; set; }

    [Column("MMProductionNormProductPicture")]
    public byte[] MmproductionNormProductPicture { get; set; }

    [Column("MMProductionNormPromulgateDate", TypeName = "datetime")]
    public DateTime? MmproductionNormPromulgateDate { get; set; }

    [Column("MMProductionNormNetWeight", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormNetWeight { get; set; }

    [Column("MMProductionNormGrossWeight", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormGrossWeight { get; set; }

    [Column("MMProductionNormVersion")]
    public int? MmproductionNormVersion { get; set; }

    [Column("MMProductionNormReferrence")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmproductionNormReferrence { get; set; }

    [Column("MMProductionNormOriginNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmproductionNormOriginNo { get; set; }

    [Column("MMProductionNormType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmproductionNormType { get; set; }

    [Column("MMProductionNormOverallSize")]
    [StringLength(50)]
    public string MmproductionNormOverallSize { get; set; }

    [Column("MMProductionNormTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormTotalPaint { get; set; }

    [Column("MMProductionNormProductNo")]
    [StringLength(50)]
    public string MmproductionNormProductNo { get; set; }

    [Column("MMProductionNormOldProductNo")]
    [StringLength(50)]
    public string MmproductionNormOldProductNo { get; set; }

    [Column("MMProductionNormProductDesc")]
    [StringLength(512)]
    public string MmproductionNormProductDesc { get; set; }

    [Column("MMProductionNormLength", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormLength { get; set; }

    [Column("MMProductionNormWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormWidth { get; set; }

    [Column("MMProductionNormHeigth", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormHeigth { get; set; }

    [Column("MMProductionNormOverallDimension")]
    [StringLength(50)]
    public string MmproductionNormOverallDimension { get; set; }

    [Column("MMProductionNormInsideDimension")]
    [StringLength(50)]
    public string MmproductionNormInsideDimension { get; set; }

    [Column("MMProductionNormBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormBlock { get; set; }

    [Column("MMProductionNormProductInBox")]
    [StringLength(50)]
    public string MmproductionNormProductInBox { get; set; }

    [Column("MMProductionNormProductLoadCont20DC")]
    [StringLength(256)]
    public string MmproductionNormProductLoadCont20Dc { get; set; }

    [Column("MMProductionNormProductLoadCont40DC", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormProductLoadCont40Dc { get; set; }

    [Column("MMProductionNormProductLoadCont40HC", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormProductLoadCont40Hc { get; set; }

    [Column("MMProductionNormOperationStatus")]
    [StringLength(50)]
    public string MmproductionNormOperationStatus { get; set; }

    [Column("FK_HREmployeeOperationApprove")]
    public int? FkHremployeeOperationApprove { get; set; }

    [Column("MMProductionNormOperationApproveDate", TypeName = "datetime")]
    public DateTime? MmproductionNormOperationApproveDate { get; set; }

    [Column("FK_HREmployeeOperationValidate")]
    public int? FkHremployeeOperationValidate { get; set; }

    [Column("MMProductionNormOperationValidateDate", TypeName = "datetime")]
    public DateTime? MmproductionNormOperationValidateDate { get; set; }

    [Column("MMProductionNormSemiProductDesc")]
    [StringLength(512)]
    public string MmproductionNormSemiProductDesc { get; set; }

    [Column("MMProductionNormHardwareDesc")]
    [StringLength(512)]
    public string MmproductionNormHardwareDesc { get; set; }

    [Column("MMProductionNormIngredientPaintDesc")]
    [StringLength(512)]
    public string MmproductionNormIngredientPaintDesc { get; set; }

    [Column("MMProductionNormIngredientPackagingDesc")]
    [StringLength(512)]
    public string MmproductionNormIngredientPackagingDesc { get; set; }

    [Column("MMProductionNormBlockPerOne", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormBlockPerOne { get; set; }

    [Column("MMProductionNormOverallLength", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormOverallLength { get; set; }

    [Column("MMProductionNormOverallWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormOverallWidth { get; set; }

    [Column("MMProductionNormOverallHeigth", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormOverallHeigth { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("MMObjectType")]
    [StringLength(64)]
    [Unicode(false)]
    public string MmobjectType { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("MMProductionNormEquipmentStatus")]
    [StringLength(50)]
    public string MmproductionNormEquipmentStatus { get; set; }

    [Column("MMProductionNormEquipmentDesc")]
    [StringLength(512)]
    public string MmproductionNormEquipmentDesc { get; set; }

    [Column("FK_HREmployeeEquipmentValidate")]
    public int? FkHremployeeEquipmentValidate { get; set; }

    [Column("MMProductionNormEquipmentValidateDate", TypeName = "datetime")]
    public DateTime? MmproductionNormEquipmentValidateDate { get; set; }

    [Column("FK_HREmployeeEquipmentApprove")]
    public int? FkHremployeeEquipmentApprove { get; set; }

    [Column("MMProductionNormEquipmentApproveDate", TypeName = "datetime")]
    public DateTime? MmproductionNormEquipmentApproveDate { get; set; }

    [Column("MMProductionNormColorAttribute")]
    [StringLength(255)]
    public string MmproductionNormColorAttribute { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ICProductCarcassID")]
    public int? FkIcproductCarcassId { get; set; }

    [Column("MMProductionNormGeneralMaterialStatus")]
    [StringLength(50)]
    public string MmproductionNormGeneralMaterialStatus { get; set; }

    [Column("MMProductionNormGeneralMaterialValidateDate", TypeName = "datetime")]
    public DateTime? MmproductionNormGeneralMaterialValidateDate { get; set; }

    [Column("MMProductionNormGeneralMaterialApprovedDate", TypeName = "datetime")]
    public DateTime? MmproductionNormGeneralMaterialApprovedDate { get; set; }

    [Column("FK_HREmployeeGeneralMaterialValidate")]
    public int? FkHremployeeGeneralMaterialValidate { get; set; }

    [Column("FK_HREmployeeGeneralMaterialApproved")]
    public int? FkHremployeeGeneralMaterialApproved { get; set; }

    [Column("MMProductionNormStatus")]
    [StringLength(50)]
    public string MmproductionNormStatus { get; set; }

    [Column("MMProductionNormCarcassProccessStatus")]
    [StringLength(50)]
    public string MmproductionNormCarcassProccessStatus { get; set; }

    [Column("MMProductionNormColorProccessStatus")]
    [StringLength(50)]
    public string MmproductionNormColorProccessStatus { get; set; }

    [Column("FK_MMProductionNormCarcassID")]
    public int? FkMmproductionNormCarcassId { get; set; }

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproductionNorms")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("MmproductionNorms")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmproductionNormFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeEquipmentValidate")]
    [InverseProperty("MmproductionNormFkHremployeeEquipmentValidateNavigations")]
    public virtual Hremployee FkHremployeeEquipmentValidateNavigation { get; set; }

    [ForeignKey("FkHremployeeHardwareApprove")]
    [InverseProperty("MmproductionNormFkHremployeeHardwareApproveNavigations")]
    public virtual Hremployee FkHremployeeHardwareApproveNavigation { get; set; }

    [ForeignKey("FkHremployeeHardwareValidate")]
    [InverseProperty("MmproductionNormFkHremployeeHardwareValidateNavigations")]
    public virtual Hremployee FkHremployeeHardwareValidateNavigation { get; set; }

    [ForeignKey("FkHremployeeOperationApprove")]
    [InverseProperty("MmproductionNormFkHremployeeOperationApproveNavigations")]
    public virtual Hremployee FkHremployeeOperationApproveNavigation { get; set; }

    [ForeignKey("FkHremployeeOperationValidate")]
    [InverseProperty("MmproductionNormFkHremployeeOperationValidateNavigations")]
    public virtual Hremployee FkHremployeeOperationValidateNavigation { get; set; }

    [ForeignKey("FkHremployeePackingMaterialApprove")]
    [InverseProperty("MmproductionNormFkHremployeePackingMaterialApproveNavigations")]
    public virtual Hremployee FkHremployeePackingMaterialApproveNavigation { get; set; }

    [ForeignKey("FkHremployeePackingMaterialValidate")]
    [InverseProperty("MmproductionNormFkHremployeePackingMaterialValidateNavigations")]
    public virtual Hremployee FkHremployeePackingMaterialValidateNavigation { get; set; }

    [ForeignKey("FkHremployeePaintApprove")]
    [InverseProperty("MmproductionNormFkHremployeePaintApproveNavigations")]
    public virtual Hremployee FkHremployeePaintApproveNavigation { get; set; }

    [ForeignKey("FkHremployeePaintValidate")]
    [InverseProperty("MmproductionNormFkHremployeePaintValidateNavigations")]
    public virtual Hremployee FkHremployeePaintValidateNavigation { get; set; }

    [ForeignKey("FkHremployeeWoodApprove")]
    [InverseProperty("MmproductionNormFkHremployeeWoodApproveNavigations")]
    public virtual Hremployee FkHremployeeWoodApproveNavigation { get; set; }

    [ForeignKey("FkHremployeeWoodValidate")]
    [InverseProperty("MmproductionNormFkHremployeeWoodValidateNavigations")]
    public virtual Hremployee FkHremployeeWoodValidateNavigation { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionNorms")]
    public virtual Icproduct FkIcproduct { get; set; }

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItems { get; set; } = new List<HrmanufactureTimeSheetItem>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmbatchProductItemOperationInfo> MmbatchProductItemOperationInfos { get; set; } = new List<MmbatchProductItemOperationInfo>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmbatchProductItemOperation> MmbatchProductItemOperations { get; set; } = new List<MmbatchProductItemOperation>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItems { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmbatchProductProductionNormItem> MmbatchProductProductionNormItems { get; set; } = new List<MmbatchProductProductionNormItem>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmcalculatorProductionNormCost> MmcalculatorProductionNormCosts { get; set; } = new List<MmcalculatorProductionNormCost>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmchangeBominformationItem> MmchangeBominformationItems { get; set; } = new List<MmchangeBominformationItem>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmchangeBominformation> MmchangeBominformations { get; set; } = new List<MmchangeBominformation>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmmergeBomchange> MmmergeBomchanges { get; set; } = new List<MmmergeBomchange>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmoperationDetailPlanItem> MmoperationDetailPlanItems { get; set; } = new List<MmoperationDetailPlanItem>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; } = new List<MmproductPriceIncomplete>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmproductionCostItem> MmproductionCostItems { get; set; } = new List<MmproductionCostItem>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmproductionCostOverall> MmproductionCostOveralls { get; set; } = new List<MmproductionCostOverall>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmproductionNormItemOperation> MmproductionNormItemOperations { get; set; } = new List<MmproductionNormItemOperation>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmproductionNormItemPacking> MmproductionNormItemPackings { get; set; } = new List<MmproductionNormItemPacking>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmproductionNormItem> MmproductionNormItems { get; set; } = new List<MmproductionNormItem>();

    [InverseProperty("FkMmproductionNorm")]
    public virtual ICollection<MmprofileManagementItem> MmprofileManagementItems { get; set; } = new List<MmprofileManagementItem>();
}
