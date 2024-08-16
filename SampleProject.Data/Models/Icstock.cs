using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICStocks")]
[Microsoft.EntityFrameworkCore.Index("IcstockNo", "FkBrbranchId", "IcstockType", Name = "Idx_ICStocks")]
public partial class Icstock
{
    [Key]
    [Column("ICStockID")]
    public int IcstockId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_GELanguageID")]
    public int? FkGelanguageId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("ICStockParentID")]
    public int? IcstockParentId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Required]
    [Column("ICStockNo")]
    [StringLength(50)]
    public string IcstockNo { get; set; }

    [Required]
    [Column("ICStockName")]
    [StringLength(100)]
    public string IcstockName { get; set; }

    [Column("ICStockDesc")]
    [StringLength(512)]
    public string IcstockDesc { get; set; }

    [Required]
    [Column("ICStockType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockType { get; set; }

    [Column("ICStockMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockMatchCode01Combo { get; set; }

    [Column("ICStockMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockMatchCode02Combo { get; set; }

    [Column("ICStockMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockMatchCode03Combo { get; set; }

    [Column("ICStockMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockMatchCode04Combo { get; set; }

    [Column("ICStockMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockMatchCode05Combo { get; set; }

    [Column("ICStockMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockMatchCode06Combo { get; set; }

    [Column("ICStockMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockMatchCode07Combo { get; set; }

    [Column("ICStockMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockMatchCode08Combo { get; set; }

    [Column("ICStockMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockMatchCode09Combo { get; set; }

    [Column("ICStockMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockMatchCode10Combo { get; set; }

    [Required]
    [Column("ICStockActiveCheck")]
    public bool? IcstockActiveCheck { get; set; }

    [Column("ICStockInfo")]
    [StringLength(510)]
    public string IcstockInfo { get; set; }

    [Column("ICStockContactName")]
    [StringLength(50)]
    public string IcstockContactName { get; set; }

    [Column("ICStockContactBirthday", TypeName = "datetime")]
    public DateTime? IcstockContactBirthday { get; set; }

    [Column("ICStockContactFirstName")]
    [StringLength(50)]
    public string IcstockContactFirstName { get; set; }

    [Column("ICStockContactLastName")]
    [StringLength(50)]
    public string IcstockContactLastName { get; set; }

    [Column("ICStockContactTitle")]
    [StringLength(50)]
    public string IcstockContactTitle { get; set; }

    [Column("ICStockContactHeaderLetter")]
    [StringLength(100)]
    public string IcstockContactHeaderLetter { get; set; }

    [Column("ICStockContactHeaderMessage")]
    [StringLength(255)]
    public string IcstockContactHeaderMessage { get; set; }

    [Column("ICStockContactEmail1")]
    [StringLength(100)]
    public string IcstockContactEmail1 { get; set; }

    [Column("ICStockContactEmail2")]
    [StringLength(100)]
    public string IcstockContactEmail2 { get; set; }

    [Column("ICStockContactWebsite")]
    [StringLength(100)]
    public string IcstockContactWebsite { get; set; }

    [Column("ICStockContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockContactPhonePrivate { get; set; }

    [Column("ICStockContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockContactPhone { get; set; }

    [Column("ICStockContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockContactPhone1 { get; set; }

    [Column("ICStockContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockContactCellPhone { get; set; }

    [Column("ICStockContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockContactCellPhone1 { get; set; }

    [Column("ICStockContactFax")]
    [StringLength(50)]
    public string IcstockContactFax { get; set; }

    [Column("ICStockContactInformation")]
    [StringLength(510)]
    public string IcstockContactInformation { get; set; }

    [Column("ICStockContactDepartment")]
    [StringLength(50)]
    public string IcstockContactDepartment { get; set; }

    [Column("ICStockContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string IcstockContactRoom { get; set; }

    [Column("ICStockContactAddressStreet")]
    [StringLength(200)]
    public string IcstockContactAddressStreet { get; set; }

    [Column("ICStockContactAddressLine1")]
    [StringLength(200)]
    public string IcstockContactAddressLine1 { get; set; }

    [Column("ICStockContactAddressLine2")]
    [StringLength(200)]
    public string IcstockContactAddressLine2 { get; set; }

    [Column("ICStockContactAddressLine3")]
    [StringLength(200)]
    public string IcstockContactAddressLine3 { get; set; }

    [Column("ICStockContactAddressCity")]
    [StringLength(50)]
    public string IcstockContactAddressCity { get; set; }

    [Column("ICStockContactAddressPostalCode")]
    [StringLength(50)]
    public string IcstockContactAddressPostalCode { get; set; }

    [Column("ICStockContactAddressStateProvince")]
    [StringLength(50)]
    public string IcstockContactAddressStateProvince { get; set; }

    [Column("ICStockContactAddressZipCode")]
    [StringLength(50)]
    public string IcstockContactAddressZipCode { get; set; }

    [Column("ICStockContactAddressCountry")]
    [StringLength(50)]
    public string IcstockContactAddressCountry { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ICStockPrefix")]
    [StringLength(50)]
    public string IcstockPrefix { get; set; }

    [Column("ICStockIsSemiProduct")]
    public bool? IcstockIsSemiProduct { get; set; }

    [Column("ICStockNumberType")]
    [StringLength(50)]
    public string IcstockNumberType { get; set; }

    [InverseProperty("FkIcstock")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ApallocationCostItem> ApallocationCostItems { get; set; } = new List<ApallocationCostItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItems { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ApreturnSupplier> ApreturnSuppliers { get; set; } = new List<ApreturnSupplier>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<AracceptanceItem> AracceptanceItems { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<AradjustSaleOrderQuantityItem> AradjustSaleOrderQuantityItems { get; set; } = new List<AradjustSaleOrderQuantityItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArcancelSaleForecastItem> ArcancelSaleForecastItems { get; set; } = new List<ArcancelSaleForecastItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArcancelVoucherItem> ArcancelVoucherItems { get; set; } = new List<ArcancelVoucherItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArcanceledDeliveryPlanItem> ArcanceledDeliveryPlanItems { get; set; } = new List<ArcanceledDeliveryPlanItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArcreditNoteItem> ArcreditNoteItems { get; set; } = new List<ArcreditNoteItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArdeliveryPlan> ArdeliveryPlans { get; set; } = new List<ArdeliveryPlan>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArestimateItem> ArestimateItems { get; set; } = new List<ArestimateItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<Arestimate> Arestimates { get; set; } = new List<Arestimate>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArinvoiceItemComponent> ArinvoiceItemComponents { get; set; } = new List<ArinvoiceItemComponent>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArinvoiceItemPackage> ArinvoiceItemPackages { get; set; } = new List<ArinvoiceItemPackage>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArsaleForecastItem> ArsaleForecastItems { get; set; } = new List<ArsaleForecastItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArsaleReturnItemComponent> ArsaleReturnItemComponents { get; set; } = new List<ArsaleReturnItemComponent>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArsaleReturnItem> ArsaleReturnItems { get; set; } = new List<ArsaleReturnItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArsaleReturn> ArsaleReturns { get; set; } = new List<ArsaleReturn>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArsfitemComponent> ArsfitemComponents { get; set; } = new List<ArsfitemComponent>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<ArsoitemComponent> ArsoitemComponents { get; set; } = new List<ArsoitemComponent>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<Brpositem> Brpositems { get; set; } = new List<Brpositem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<BrposredemptionItem> BrposredemptionItems { get; set; } = new List<BrposredemptionItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<Brposs> Brposses { get; set; } = new List<Brposs>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<Cscompany> Cscompanies { get; set; } = new List<Cscompany>();

    [InverseProperty("FastockIdcomboNavigation")]
    public virtual ICollection<FacreditNoteItem> FacreditNoteItems { get; set; } = new List<FacreditNoteItem>();

    [InverseProperty("FastockIdcomboNavigation")]
    public virtual ICollection<FaproposalItem> FaproposalItems { get; set; } = new List<FaproposalItem>();

    [InverseProperty("FastockIdcomboNavigation")]
    public virtual ICollection<FapurchaseOrderItem> FapurchaseOrderItems { get; set; } = new List<FapurchaseOrderItem>();

    [InverseProperty("FastockIdcomboNavigation")]
    public virtual ICollection<FapurchaseOrder> FapurchaseOrders { get; set; } = new List<FapurchaseOrder>();

    [InverseProperty("FastockIdcomboNavigation")]
    public virtual ICollection<FasellReturnItem> FasellReturnItems { get; set; } = new List<FasellReturnItem>();

    [InverseProperty("FatransferStockInContact")]
    public virtual ICollection<Fatransfer> FatransferFatransferStockInContacts { get; set; } = new List<Fatransfer>();

    [InverseProperty("FatransferStockOutContact")]
    public virtual ICollection<Fatransfer> FatransferFatransferStockOutContacts { get; set; } = new List<Fatransfer>();

    [InverseProperty("FatransferWorkingContact")]
    public virtual ICollection<Fatransfer> FatransferFatransferWorkingContacts { get; set; } = new List<Fatransfer>();

    [InverseProperty("FastockIdcomboNavigation")]
    public virtual ICollection<FatransferStockInItem> FatransferStockInItems { get; set; } = new List<FatransferStockInItem>();

    [InverseProperty("FastockIdcomboNavigation")]
    public virtual ICollection<FatransferStockOutItem> FatransferStockOutItems { get; set; } = new List<FatransferStockOutItem>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("Icstocks")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Icstocks")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("Icstocks")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("Icstocks")]
    public virtual Gelanguage FkGelanguage { get; set; }

    [InverseProperty("FkIcstock")]
    public virtual ICollection<GestockNumbering> GestockNumberings { get; set; } = new List<GestockNumbering>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcadjustmentItem> IcadjustmentItems { get; set; } = new List<IcadjustmentItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<Icadjustment> Icadjustments { get; set; } = new List<Icadjustment>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcassembleProductDetail> IcassembleProductDetails { get; set; } = new List<IcassembleProductDetail>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcassembleProduct> IcassembleProducts { get; set; } = new List<IcassembleProduct>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcaverageCost> IcaverageCosts { get; set; } = new List<IcaverageCost>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcconversionProposalItem> IcconversionProposalItems { get; set; } = new List<IcconversionProposalItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcconversionProposal> IcconversionProposals { get; set; } = new List<IcconversionProposal>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcdisassembleProductDetail> IcdisassembleProductDetails { get; set; } = new List<IcdisassembleProductDetail>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcdisassembleProduct> IcdisassembleProducts { get; set; } = new List<IcdisassembleProduct>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcinitializedInventoryStock> IcinitializedInventoryStocks { get; set; } = new List<IcinitializedInventoryStock>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcinvAdjustment> IcinvAdjustments { get; set; } = new List<IcinvAdjustment>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcinvBalance> IcinvBalances { get; set; } = new List<IcinvBalance>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcinventoryItemPackage> IcinventoryItemPackages { get; set; } = new List<IcinventoryItemPackage>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcinventoryPackage> IcinventoryPackages { get; set; } = new List<IcinventoryPackage>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcinventoryPermission> IcinventoryPermissions { get; set; } = new List<IcinventoryPermission>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcinventoryStockCountItem> IcinventoryStockCountItems { get; set; } = new List<IcinventoryStockCountItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcinventoryStockCount> IcinventoryStockCounts { get; set; } = new List<IcinventoryStockCount>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcinventoryStockSerial> IcinventoryStockSerials { get; set; } = new List<IcinventoryStockSerial>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcinventoryStock> IcinventoryStocks { get; set; } = new List<IcinventoryStock>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcpriceAdjustmentItem> IcpriceAdjustmentItems { get; set; } = new List<IcpriceAdjustmentItem>();

    [InverseProperty("FkIcfromStock")]
    public virtual ICollection<IcproductConversion> IcproductConversionFkIcfromStocks { get; set; } = new List<IcproductConversion>();

    [InverseProperty("FkIctoStock")]
    public virtual ICollection<IcproductConversion> IcproductConversionFkIctoStocks { get; set; } = new List<IcproductConversion>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcproductConversionItem> IcproductConversionItems { get; set; } = new List<IcproductConversionItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcreceiptComponentItem> IcreceiptComponentItems { get; set; } = new List<IcreceiptComponentItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcreturnShippingItem> IcreturnShippingItems { get; set; } = new List<IcreturnShippingItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcshipmentItemComponent> IcshipmentItemComponents { get; set; } = new List<IcshipmentItemComponent>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcshipmentPlan> IcshipmentPlans { get; set; } = new List<IcshipmentPlan>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcshipmentProposal> IcshipmentProposals { get; set; } = new List<IcshipmentProposal>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcstockSlot> IcstockSlots { get; set; } = new List<IcstockSlot>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<Ictransaction> Ictransactions { get; set; } = new List<Ictransaction>();

    [InverseProperty("FkIcfromStock")]
    public virtual ICollection<Ictransfer> IctransferFkIcfromStocks { get; set; } = new List<Ictransfer>();

    [InverseProperty("FkIctoStock")]
    public virtual ICollection<Ictransfer> IctransferFkIctoStocks { get; set; } = new List<Ictransfer>();

    [InverseProperty("FkIctransitStock")]
    public virtual ICollection<Ictransfer> IctransferFkIctransitStocks { get; set; } = new List<Ictransfer>();

    [InverseProperty("FkIcfromStock")]
    public virtual ICollection<IctransferItem> IctransferItemFkIcfromStocks { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkIctoStock")]
    public virtual ICollection<IctransferItem> IctransferItemFkIctoStocks { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkIctransitStock")]
    public virtual ICollection<IctransferItem> IctransferItemFkIctransitStocks { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IctransferItemPackage> IctransferItemPackages { get; set; } = new List<IctransferItemPackage>();

    [InverseProperty("FkIcfromStock")]
    public virtual ICollection<IctransferLog> IctransferLogFkIcfromStocks { get; set; } = new List<IctransferLog>();

    [InverseProperty("FkIctoStock")]
    public virtual ICollection<IctransferLog> IctransferLogFkIctoStocks { get; set; } = new List<IctransferLog>();

    [InverseProperty("FkIctransitStock")]
    public virtual ICollection<IctransferLog> IctransferLogFkIctransitStocks { get; set; } = new List<IctransferLog>();

    [InverseProperty("FkIcfromStock")]
    public virtual ICollection<IctransferLogItem> IctransferLogItemFkIcfromStocks { get; set; } = new List<IctransferLogItem>();

    [InverseProperty("FkIcproductNavigation")]
    public virtual ICollection<IctransferLogItem> IctransferLogItemFkIcproductNavigations { get; set; } = new List<IctransferLogItem>();

    [InverseProperty("FkIctransitStock")]
    public virtual ICollection<IctransferLogItem> IctransferLogItemFkIctransitStocks { get; set; } = new List<IctransferLogItem>();

    [InverseProperty("FkIcfromStock")]
    public virtual ICollection<IctransferProposal> IctransferProposalFkIcfromStocks { get; set; } = new List<IctransferProposal>();

    [InverseProperty("FkIctoStock")]
    public virtual ICollection<IctransferProposal> IctransferProposalFkIctoStocks { get; set; } = new List<IctransferProposal>();

    [InverseProperty("FkIctransitStock")]
    public virtual ICollection<IctransferProposal> IctransferProposalFkIctransitStocks { get; set; } = new List<IctransferProposal>();

    [InverseProperty("FkIcfromStock")]
    public virtual ICollection<IctransferProposalItem> IctransferProposalItemFkIcfromStocks { get; set; } = new List<IctransferProposalItem>();

    [InverseProperty("FkIctoStock")]
    public virtual ICollection<IctransferProposalItem> IctransferProposalItemFkIctoStocks { get; set; } = new List<IctransferProposalItem>();

    [InverseProperty("FkIctransitStock")]
    public virtual ICollection<IctransferProposalItem> IctransferProposalItemFkIctransitStocks { get; set; } = new List<IctransferProposalItem>();

    [InverseProperty("FkIcstockExt")]
    public virtual ICollection<IcvitualTransaction> IcvitualTransactionFkIcstockExts { get; set; } = new List<IcvitualTransaction>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<IcvitualTransaction> IcvitualTransactionFkIcstocks { get; set; } = new List<IcvitualTransaction>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItems { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<MmbatchProductInputItem> MmbatchProductInputItems { get; set; } = new List<MmbatchProductInputItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<MmcancelAllocationPlanItem> MmcancelAllocationPlanItems { get; set; } = new List<MmcancelAllocationPlanItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<MmlineOperation> MmlineOperations { get; set; } = new List<MmlineOperation>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<MmupdatePosition> MmupdatePositions { get; set; } = new List<MmupdatePosition>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<PmprojectMaterialItem> PmprojectMaterialItems { get; set; } = new List<PmprojectMaterialItem>();

    [InverseProperty("FkIcstock")]
    public virtual ICollection<PmprojectNorm> PmprojectNorms { get; set; } = new List<PmprojectNorm>();
}
