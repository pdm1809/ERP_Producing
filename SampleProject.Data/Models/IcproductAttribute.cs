using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductAttributes")]
public partial class IcproductAttribute
{
    [Key]
    [Column("ICProductAttributeID")]
    public int IcproductAttributeId { get; set; }

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

    [Required]
    [Column("ICProductAttributeGroup")]
    [StringLength(50)]
    public string IcproductAttributeGroup { get; set; }

    [Column("ICProductAttributeNo")]
    [StringLength(50)]
    public string IcproductAttributeNo { get; set; }

    [Column("ICProductAttributeValue")]
    [StringLength(50)]
    public string IcproductAttributeValue { get; set; }

    [Column("ICProductAttributeParentID")]
    public int? IcproductAttributeParentId { get; set; }

    [Column("ICProductAttributeAbbreviation")]
    [StringLength(50)]
    public string IcproductAttributeAbbreviation { get; set; }

    [Column("FK_ICProductAttributeHTType")]
    public int? FkIcproductAttributeHttype { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ICProductAttributeProductLine")]
    [StringLength(256)]
    public string IcproductAttributeProductLine { get; set; }

    [Column("ICProductAttributeFormulaCountBarrelA")]
    [StringLength(50)]
    public string IcproductAttributeFormulaCountBarrelA { get; set; }

    [Column("ICProductAttributeFormulaCountBarrelB")]
    [StringLength(50)]
    public string IcproductAttributeFormulaCountBarrelB { get; set; }

    [Column("ICProductAttributeFormulaCountSeparatelyValue", TypeName = "decimal(18, 5)")]
    public decimal? IcproductAttributeFormulaCountSeparatelyValue { get; set; }

    [Column("ICProductAttributeFormulaCountOperationA")]
    [StringLength(50)]
    public string IcproductAttributeFormulaCountOperationA { get; set; }

    [Column("ICProductAttributeFormulaCountOperationB")]
    [StringLength(50)]
    public string IcproductAttributeFormulaCountOperationB { get; set; }

    [Column("ICProductAttributeUnSpecifications")]
    public bool? IcproductAttributeUnSpecifications { get; set; }

    [InverseProperty("FkIcprodAttPackingMaterialWeightPerVolume")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItemFkIcprodAttPackingMaterialWeightPerVolumes { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItemFkIcproductAttributeQualities { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItemFkIcproductAttributeTtmts { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItemFkIcproductAttributeWoodTypes { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceInFkIcproductAttributeTtmts { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceInFkIcproductAttributeWoodTypes { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItemFkIcproductAttributeQualities { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItemFkIcproductAttributeTtmts { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItemFkIcproductAttributeWoodTypes { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkIcprodAttPackingMaterialWeightPerVolume")]
    public virtual ICollection<ApproposalItem> ApproposalItemFkIcprodAttPackingMaterialWeightPerVolumes { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<ApproposalItem> ApproposalItemFkIcproductAttributeQualities { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ApproposalItem> ApproposalItemFkIcproductAttributeTtmts { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<ApproposalItem> ApproposalItemFkIcproductAttributeWoodTypes { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkIcprodAttPackingMaterialWeightPerVolume")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotalFkIcprodAttPackingMaterialWeightPerVolumes { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotalFkIcproductAttributeQualities { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotalFkIcproductAttributeTtmts { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotalFkIcproductAttributeWoodTypes { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItemFkIcproductAttributeQualities { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItemFkIcproductAttributeTtmts { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItemFkIcproductAttributeWoodTypes { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcproductThickGroup")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItemFkIcproductThickGroups { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItemFkIcproductAttributeQualities { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItemFkIcproductAttributeTtmts { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItemFkIcproductAttributeQualities { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItemFkIcproductAttributeTtmts { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ArdeliveryPlan> ArdeliveryPlans { get; set; } = new List<ArdeliveryPlan>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItemFkIcproductAttributeQualities { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItemFkIcproductAttributeTtmts { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItemFkIcproductAttributeWoodTypes { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ArproductionPlanning> ArproductionPlannings { get; set; } = new List<ArproductionPlanning>();

    [InverseProperty("FkIcproductAttributeColor")]
    public virtual ICollection<ArproposalItem> ArproposalItemFkIcproductAttributeColors { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<ArproposalItem> ArproposalItemFkIcproductAttributeWoodTypes { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ArsaleForecast> ArsaleForecasts { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkIcproductAttributeColor")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItemFkIcproductAttributeColors { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItemFkIcproductAttributeQualities { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItemFkIcproductAttributeTtmts { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItemFkIcproductAttributeWoodTypes { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("IcproductAttributes")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcproductAttributes")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<GepackageNumeringConfig> GepackageNumeringConfigs { get; set; } = new List<GepackageNumeringConfig>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<IcconfigAccordWoodType> IcconfigAccordWoodTypeFkIcproductAttributeWoodTypes { get; set; } = new List<IcconfigAccordWoodType>();

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<IcconfigAccordWoodType> IcconfigAccordWoodTypeFkIcproductAttributes { get; set; } = new List<IcconfigAccordWoodType>();

    [InverseProperty("FkIcproductAttHttypeNavigation")]
    public virtual ICollection<IcmaterialConfig> IcmaterialConfigFkIcproductAttHttypeNavigations { get; set; } = new List<IcmaterialConfig>();

    [InverseProperty("FkIcproductAttPackingMaterialSpecialityNavigation")]
    public virtual ICollection<IcmaterialConfig> IcmaterialConfigFkIcproductAttPackingMaterialSpecialityNavigations { get; set; } = new List<IcmaterialConfig>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<IcmaterialConfig> IcmaterialConfigFkIcproductAttributeWoodTypes { get; set; } = new List<IcmaterialConfig>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<IcproductAlternative> IcproductAlternatives { get; set; } = new List<IcproductAlternative>();

    [InverseProperty("FkIcproductAttributeColor")]
    public virtual ICollection<IcproductApplyPriceItem> IcproductApplyPriceItemFkIcproductAttributeColors { get; set; } = new List<IcproductApplyPriceItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<IcproductApplyPriceItem> IcproductApplyPriceItemFkIcproductAttributeWoodTypes { get; set; } = new List<IcproductApplyPriceItem>();

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<IcproductAttributeItem> IcproductAttributeItems { get; set; } = new List<IcproductAttributeItem>();

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<IcproductAttributeWood> IcproductAttributeWoods { get; set; } = new List<IcproductAttributeWood>();

    [InverseProperty("FkIcprodAttPackingMaterialSize")]
    public virtual ICollection<Icproduct> IcproductFkIcprodAttPackingMaterialSizes { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcprodAttPackingMaterialSpeciality")]
    public virtual ICollection<Icproduct> IcproductFkIcprodAttPackingMaterialSpecialities { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcprodAttPackingMaterialWeightPerVolume")]
    public virtual ICollection<Icproduct> IcproductFkIcprodAttPackingMaterialWeightPerVolumes { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductAttributeColor")]
    public virtual ICollection<Icproduct> IcproductFkIcproductAttributeColors { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductAttributeFinishing")]
    public virtual ICollection<Icproduct> IcproductFkIcproductAttributeFinishings { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<Icproduct> IcproductFkIcproductAttributeQualities { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductAttributeSemiProductSpeciality")]
    public virtual ICollection<Icproduct> IcproductFkIcproductAttributeSemiProductSpecialities { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<Icproduct> IcproductFkIcproductAttributeWoodTypes { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductThickGroup")]
    public virtual ICollection<Icproduct> IcproductFkIcproductThickGroups { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcprodAttPackingMaterialWeightPerVolume")]
    public virtual ICollection<IcproductPackingDetail> IcproductPackingDetailFkIcprodAttPackingMaterialWeightPerVolumes { get; set; } = new List<IcproductPackingDetail>();

    [InverseProperty("FkIcproductAttributeSpeciality")]
    public virtual ICollection<IcproductPackingDetail> IcproductPackingDetailFkIcproductAttributeSpecialities { get; set; } = new List<IcproductPackingDetail>();

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<IcproductProductAttribute> IcproductProductAttributes { get; set; } = new List<IcproductProductAttribute>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<IcproductSeries> IcproductSeriesFkIcproductAttributeQualities { get; set; } = new List<IcproductSeries>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<IcproductSeries> IcproductSeriesFkIcproductAttributeTtmts { get; set; } = new List<IcproductSeries>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<IcproductSeries> IcproductSeriesFkIcproductAttributeWoodTypes { get; set; } = new List<IcproductSeries>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<IcreceiptCd> IcreceiptCdFkIcproductAttributeQualities { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<IcreceiptCd> IcreceiptCdFkIcproductAttributeTtmts { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<IcreceiptCd> IcreceiptCdFkIcproductAttributeWoodTypes { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditemFkIcproductAttributeQualities { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditemFkIcproductAttributeTtmts { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditemFkIcproductAttributeWoodTypes { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<Icreceipt> IcreceiptFkIcproductAttributeQualities { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<Icreceipt> IcreceiptFkIcproductAttributeTtmts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<Icreceipt> IcreceiptFkIcproductAttributeWoodTypes { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkIcproductAttributeQualities { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkIcproductAttributeTtmts { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkIcproductAttributeWoodTypes { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<Icshipment> IcshipmentFkIcproductAttributeQualities { get; set; } = new List<Icshipment>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<Icshipment> IcshipmentFkIcproductAttributeTtmts { get; set; } = new List<Icshipment>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<Icshipment> IcshipmentFkIcproductAttributeWoodTypes { get; set; } = new List<Icshipment>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkIcproductAttributeQualities { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkIcproductAttributeTtmts { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkIcproductAttributeWoodTypes { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcproductAttributeColorNavigation")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItemFkIcproductAttributeColorNavigations { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkIcproductAttributePaintTypeNavigation")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItemFkIcproductAttributePaintTypeNavigations { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItemFkIcproductAttributeQualities { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItemFkIcproductAttributeTtmts { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItemFkIcproductAttributes { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<IcshipmentProposal> IcshipmentProposals { get; set; } = new List<IcshipmentProposal>();

    [InverseProperty("FkIcproductAttributeColor")]
    public virtual ICollection<IctransferProposalItem> IctransferProposalItemFkIcproductAttributeColors { get; set; } = new List<IctransferProposalItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<IctransferProposalItem> IctransferProposalItemFkIcproductAttributeWoodTypes { get; set; } = new List<IctransferProposalItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItemFkIcproductAttributeQualities { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItemFkIcproductAttributeTtmts { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItemFkIcproductAttributeWoodTypes { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItemFkIcproductAttributeQualities { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItemFkIcproductAttributeTtmts { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItemFkIcproductAttributeWoodTypes { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmbatchItemPlan> MmbatchItemPlans { get; set; } = new List<MmbatchItemPlan>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmbatchItemWood> MmbatchItemWoods { get; set; } = new List<MmbatchItemWood>();

    [InverseProperty("FkIcproductAttributeColor")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItemFkIcproductAttributeColors { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkIcproductAttributeHttype")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItemFkIcproductAttributeHttypes { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItemFkIcproductAttributeQualities { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItemFkIcproductAttributeTtmts { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItemFkIcproductAttributeWoodTypes { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<MmbatchProductProductionNormItemPaint> MmbatchProductProductionNormItemPaints { get; set; } = new List<MmbatchProductProductionNormItemPaint>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmbatchProduct> MmbatchProducts { get; set; } = new List<MmbatchProduct>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmcalculatorProductionNormItemMaterial> MmcalculatorProductionNormItemMaterials { get; set; } = new List<MmcalculatorProductionNormItemMaterial>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmcancelAllocationPlanItem> MmcancelAllocationPlanItems { get; set; } = new List<MmcancelAllocationPlanItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItemFkIcproductAttributeQualities { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItemFkIcproductAttributeTtmts { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItemFkIcproductAttributeWoodTypes { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItemFkIcproductAttributeQualities { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItemFkIcproductAttributeTtmts { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItemFkIcproductAttributeWoodTypes { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmcanceledPurchasePlan> MmcanceledPurchasePlans { get; set; } = new List<MmcanceledPurchasePlan>();

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<MmconsumableConfig> MmconsumableConfigs { get; set; } = new List<MmconsumableConfig>();

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<MmexchangeRateConfig> MmexchangeRateConfigs { get; set; } = new List<MmexchangeRateConfig>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmfalseConditionalItem> MmfalseConditionalItems { get; set; } = new List<MmfalseConditionalItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmfalseConditional> MmfalseConditionals { get; set; } = new List<MmfalseConditional>();

    [InverseProperty("FkIcproductAttributePackingMaterialSpeciality")]
    public virtual ICollection<MmoverallInsideDimensionConfig> MmoverallInsideDimensionConfigs { get; set; } = new List<MmoverallInsideDimensionConfig>();

    [InverseProperty("FkIcproductAttributeColor")]
    public virtual ICollection<MmpaintProcessess> MmpaintProcessessFkIcproductAttributeColors { get; set; } = new List<MmpaintProcessess>();

    [InverseProperty("FkIcproductAttributeHt")]
    public virtual ICollection<MmpaintProcessess> MmpaintProcessessFkIcproductAttributeHts { get; set; } = new List<MmpaintProcessess>();

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<MmproductionNormItemConfig> MmproductionNormItemConfigs { get; set; } = new List<MmproductionNormItemConfig>();

    [InverseProperty("FkIcproductAttribute")]
    public virtual ICollection<MmproductionNormItemPaint> MmproductionNormItemPaints { get; set; } = new List<MmproductionNormItemPaint>();

    [InverseProperty("FkIcproductAttributeColor")]
    public virtual ICollection<MmproposalItem> MmproposalItemFkIcproductAttributeColors { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkIcproductAttributeHttype")]
    public virtual ICollection<MmproposalItem> MmproposalItemFkIcproductAttributeHttypes { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmproposalItem> MmproposalItemFkIcproductAttributeQualities { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmproposalItem> MmproposalItemFkIcproductAttributeTtmts { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmproposalItem> MmproposalItemFkIcproductAttributeWoodTypes { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<Mmproposal> Mmproposals { get; set; } = new List<Mmproposal>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmpurchasePlanInPutItem> MmpurchasePlanInPutItemFkIcproductAttributeQualities { get; set; } = new List<MmpurchasePlanInPutItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmpurchasePlanInPutItem> MmpurchasePlanInPutItemFkIcproductAttributeTtmts { get; set; } = new List<MmpurchasePlanInPutItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmpurchasePlanInPutItem> MmpurchasePlanInPutItemFkIcproductAttributeWoodTypes { get; set; } = new List<MmpurchasePlanInPutItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItemFkIcproductAttributeQualities { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItemFkIcproductAttributeTtmts { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItemFkIcproductAttributeWoodTypes { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotalFkIcproductAttributeQualities { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotalFkIcproductAttributeTtmts { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotalFkIcproductAttributeWoodTypes { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmpurchasePlan> MmpurchasePlans { get; set; } = new List<MmpurchasePlan>();

    [InverseProperty("FkIcproductAttributeSpeciality")]
    public virtual ICollection<MmreuseSpecificateConfig> MmreuseSpecificateConfigFkIcproductAttributeSpecialities { get; set; } = new List<MmreuseSpecificateConfig>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmreuseSpecificateConfig> MmreuseSpecificateConfigFkIcproductAttributeWoodTypes { get; set; } = new List<MmreuseSpecificateConfig>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmwoodPlanItemDetail> MmwoodPlanItemDetailFkIcproductAttributeQualities { get; set; } = new List<MmwoodPlanItemDetail>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmwoodPlanItemDetail> MmwoodPlanItemDetailFkIcproductAttributeWoodTypes { get; set; } = new List<MmwoodPlanItemDetail>();

    [InverseProperty("FkIcproductAttributeQuality")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItemFkIcproductAttributeQualities { get; set; } = new List<MmwoodPlanItem>();

    [InverseProperty("FkIcproductAttributeSpeciality")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItemFkIcproductAttributeSpecialities { get; set; } = new List<MmwoodPlanItem>();

    [InverseProperty("FkIcproductAttributeWoodType")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItemFkIcproductAttributeWoodTypes { get; set; } = new List<MmwoodPlanItem>();

    [InverseProperty("FkIcproductAttributeTtmt")]
    public virtual ICollection<MmwoodPlan> MmwoodPlans { get; set; } = new List<MmwoodPlan>();
}
