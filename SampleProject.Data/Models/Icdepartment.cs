using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICDepartments")]
[Microsoft.EntityFrameworkCore.Index("IcdepartmentNo", Name = "Idx_ICDepartments")]
public partial class Icdepartment
{
    [Key]
    [Column("ICDepartmentID")]
    public int IcdepartmentId { get; set; }

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
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ICDepartmentNo")]
    [StringLength(50)]
    public string IcdepartmentNo { get; set; }

    [Required]
    [Column("ICDepartmentName")]
    [StringLength(50)]
    public string IcdepartmentName { get; set; }

    [Column("ICDepartmentDesc")]
    [StringLength(512)]
    public string IcdepartmentDesc { get; set; }

    [Column("ICDepartmentActiveCheck")]
    public bool? IcdepartmentActiveCheck { get; set; }

    [Column("ICDepartmentMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode01Combo { get; set; }

    [Column("ICDepartmentMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode02Combo { get; set; }

    [Column("ICDepartmentMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode03Combo { get; set; }

    [Column("ICDepartmentMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode04Combo { get; set; }

    [Column("ICDepartmentMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode05Combo { get; set; }

    [Column("ICDepartmentMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode06Combo { get; set; }

    [Column("ICDepartmentMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode07Combo { get; set; }

    [Column("ICDepartmentMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode08Combo { get; set; }

    [Column("ICDepartmentMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode09Combo { get; set; }

    [Column("ICDepartmentMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode10Combo { get; set; }

    [Column("ICDepartmentMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode11Combo { get; set; }

    [Column("ICDepartmentMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode12Combo { get; set; }

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetails { get; set; } = new List<AcrevenueBudgetDetail>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItems { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ApsupplierDepartment> ApsupplierDepartments { get; set; } = new List<ApsupplierDepartment>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<AracceptanceItemWork> AracceptanceItemWorks { get; set; } = new List<AracceptanceItemWork>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<AracceptanceItem> AracceptanceItems { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<AradjustSaleOrderQuantityItem> AradjustSaleOrderQuantityItems { get; set; } = new List<AradjustSaleOrderQuantityItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArcancelSaleForecastItem> ArcancelSaleForecastItems { get; set; } = new List<ArcancelSaleForecastItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArcancelVoucherItemCost> ArcancelVoucherItemCosts { get; set; } = new List<ArcancelVoucherItemCost>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArcancelVoucherItem> ArcancelVoucherItems { get; set; } = new List<ArcancelVoucherItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArestimateItem> ArestimateItems { get; set; } = new List<ArestimateItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArinvoiceItemWork> ArinvoiceItemWorks { get; set; } = new List<ArinvoiceItemWork>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArpriceSheetItemWork> ArpriceSheetItemWorks { get; set; } = new List<ArpriceSheetItemWork>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArproductionPlanningItem> ArproductionPlanningItems { get; set; } = new List<ArproductionPlanningItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArproposalItemWorkItem> ArproposalItemWorkItems { get; set; } = new List<ArproposalItemWorkItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArproposalItemWork> ArproposalItemWorks { get; set; } = new List<ArproposalItemWork>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArproposalTemplateItem> ArproposalTemplateItems { get; set; } = new List<ArproposalTemplateItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArsaleForecastItem> ArsaleForecastItems { get; set; } = new List<ArsaleForecastItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArsaleOrderItemWorkItem> ArsaleOrderItemWorkItems { get; set; } = new List<ArsaleOrderItemWorkItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArsaleOrderItemWork> ArsaleOrderItemWorks { get; set; } = new List<ArsaleOrderItemWork>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<ArsaleReturnItem> ArsaleReturnItems { get; set; } = new List<ArsaleReturnItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<Brpositem> Brpositems { get; set; } = new List<Brpositem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItems { get; set; } = new List<HrmanufactureTimeSheetItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcadjustmentItem> IcadjustmentItems { get; set; } = new List<IcadjustmentItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcconversionProposalItem> IcconversionProposalItems { get; set; } = new List<IcconversionProposalItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcdepartmentAttribute> IcdepartmentAttributes { get; set; } = new List<IcdepartmentAttribute>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcinventoryStockCount> IcinventoryStockCounts { get; set; } = new List<IcinventoryStockCount>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcpriceAdjustmentItem> IcpriceAdjustmentItems { get; set; } = new List<IcpriceAdjustmentItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcproductGroup> IcproductGroups { get; set; } = new List<IcproductGroup>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcpromotionItem> IcpromotionItems { get; set; } = new List<IcpromotionItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcreceiptComponentItem> IcreceiptComponentItems { get; set; } = new List<IcreceiptComponentItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcreturnShippingItem> IcreturnShippingItems { get; set; } = new List<IcreturnShippingItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<IctransferProposalItem> IctransferProposalItems { get; set; } = new List<IctransferProposalItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItems { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItems { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmbatchItemWood> MmbatchItemWoods { get; set; } = new List<MmbatchItemWood>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmcancelAllocationPlanItem> MmcancelAllocationPlanItems { get; set; } = new List<MmcancelAllocationPlanItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmchangeBominformationItem> MmchangeBominformationItems { get; set; } = new List<MmchangeBominformationItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmdefaultAllocationOperationConfig> MmdefaultAllocationOperationConfigs { get; set; } = new List<MmdefaultAllocationOperationConfig>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmexchangeRateConfig> MmexchangeRateConfigs { get; set; } = new List<MmexchangeRateConfig>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; } = new List<MmproductPriceIncomplete>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmproductionCostFormulaProduct> MmproductionCostFormulaProducts { get; set; } = new List<MmproductionCostFormulaProduct>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmproductionCostItem> MmproductionCostItems { get; set; } = new List<MmproductionCostItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmproposalItem> MmproposalItems { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItems { get; set; } = new List<MmwoodPlanItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<PmbuidingCommandItem> PmbuidingCommandItems { get; set; } = new List<PmbuidingCommandItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<PmbuidingProposalItem> PmbuidingProposalItems { get; set; } = new List<PmbuidingProposalItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<PmbuildingAllocationItem> PmbuildingAllocationItems { get; set; } = new List<PmbuildingAllocationItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<PmbuildingPlanItem> PmbuildingPlanItems { get; set; } = new List<PmbuildingPlanItem>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<PmprojectNorm> PmprojectNorms { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkIcdepartment")]
    public virtual ICollection<PmtemplateItem> PmtemplateItems { get; set; } = new List<PmtemplateItem>();
}
