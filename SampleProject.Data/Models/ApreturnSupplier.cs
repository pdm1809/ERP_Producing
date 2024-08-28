using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APReturnSuppliers")]
public partial class ApreturnSupplier
{
    [Key]
    [Column("APReturnSupplierID")]
    public int ApreturnSupplierId { get; set; }

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

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("APReturnSupplierStatusCombo")]
    [StringLength(100)]
    public string ApreturnSupplierStatusCombo { get; set; }

    [Column("APReturnSupplierPaymentTerm")]
    [StringLength(50)]
    public string ApreturnSupplierPaymentTerm { get; set; }

    [Column("APReturnSupplierSupplierBonus", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierSupplierBonus { get; set; }

    [Column("ICPaymentMethodCombo")]
    [StringLength(50)]
    public string IcpaymentMethodCombo { get; set; }

    [Required]
    [Column("APReturnSupplierNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApreturnSupplierNo { get; set; }

    [Column("APReturnSupplierName")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApreturnSupplierName { get; set; }

    [Column("APReturnSupplierDesc", TypeName = "ntext")]
    public string ApreturnSupplierDesc { get; set; }

    [Column("APReturnSupplierReason", TypeName = "ntext")]
    public string ApreturnSupplierReason { get; set; }

    [Column("APReturnSupplierStartDate", TypeName = "datetime")]
    public DateTime? ApreturnSupplierStartDate { get; set; }

    [Column("APReturnSupplierDate", TypeName = "datetime")]
    public DateTime? ApreturnSupplierDate { get; set; }

    [Column("APReturnSupplierDeliveryDate", TypeName = "datetime")]
    public DateTime? ApreturnSupplierDeliveryDate { get; set; }

    [Column("APReturnSupplierIsDiscountPercentCheck")]
    public bool? ApreturnSupplierIsDiscountPercentCheck { get; set; }

    [Column("APReturnSupplierDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierDiscountPerCent { get; set; }

    [Column("APReturnSupplierDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierDiscountFix { get; set; }

    [Column("APReturnSupplierReference")]
    [StringLength(150)]
    public string ApreturnSupplierReference { get; set; }

    [Column("APReturnSupplierSupplierReference")]
    [StringLength(150)]
    public string ApreturnSupplierSupplierReference { get; set; }

    [Column("APReturnSupplierRemark")]
    [StringLength(255)]
    public string ApreturnSupplierRemark { get; set; }

    [Column("APReturnSupplierPerson")]
    public int? ApreturnSupplierPerson { get; set; }

    [Column("APReturnSupplierQuantity")]
    public int? ApreturnSupplierQuantity { get; set; }

    [Column("APReturnSupplierWeight", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierWeight { get; set; }

    [Column("APReturnSupplierVolume", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierVolume { get; set; }

    [Column("APReturnSupplierActiveCheck")]
    public bool? ApreturnSupplierActiveCheck { get; set; }

    [Column("APReturnSupplierTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApreturnSupplierTaxNumber { get; set; }

    [Column("APReturnSupplierTypeCombo")]
    [StringLength(50)]
    public string ApreturnSupplierTypeCombo { get; set; }

    [Column("APReturnSupplierMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApreturnSupplierMatchCode01Combo { get; set; }

    [Column("APReturnSupplierMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApreturnSupplierMatchCode02Combo { get; set; }

    [Column("APReturnSupplierMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApreturnSupplierMatchCode03Combo { get; set; }

    [Column("APReturnSupplierMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApreturnSupplierMatchCode04Combo { get; set; }

    [Column("APReturnSupplierMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApreturnSupplierMatchCode05Combo { get; set; }

    [Column("FK_APSupplierContactInvoiceID")]
    public int? FkApsupplierContactInvoiceId { get; set; }

    [Column("APReturnSupplierInvoiceContactName")]
    [StringLength(50)]
    public string ApreturnSupplierInvoiceContactName { get; set; }

    [Column("APReturnSupplierInvoiceContactEmail")]
    [StringLength(100)]
    public string ApreturnSupplierInvoiceContactEmail { get; set; }

    [Column("APReturnSupplierInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApreturnSupplierInvoiceContactPhone { get; set; }

    [Column("APReturnSupplierReasonType")]
    [StringLength(50)]
    public string ApreturnSupplierReasonType { get; set; }

    [Column("FK_APSupplierContactPOID")]
    public int? FkApsupplierContactPoid { get; set; }

    [Column("APReturnSupplierPOContactName")]
    [StringLength(50)]
    public string ApreturnSupplierPocontactName { get; set; }

    [Column("APReturnSupplierPOContactEmail")]
    [StringLength(100)]
    public string ApreturnSupplierPocontactEmail { get; set; }

    [Column("APReturnSupplierPOContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApreturnSupplierPocontactPhone { get; set; }

    [Column("APReturnSupplierShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierShippingFees { get; set; }

    [Column("APReturnSupplierShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierShippingExtraFees { get; set; }

    [Column("APReturnSupplierShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierShippingInsuranceFees { get; set; }

    [Column("APReturnSupplierShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierShippingPackagingFees { get; set; }

    [Column("APReturnSupplierShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierShippingReservedFees1 { get; set; }

    [Column("APReturnSupplierShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierShippingReservedFees2 { get; set; }

    [Column("APReturnSupplierShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierShippingReservedFees3 { get; set; }

    [Column("APReturnSupplierShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierShippingReservedFees4 { get; set; }

    [Column("APReturnSupplierShippingMethodDesc")]
    [StringLength(255)]
    public string ApreturnSupplierShippingMethodDesc { get; set; }

    [Column("APReturnSupplierShippingMethodName")]
    [StringLength(50)]
    public string ApreturnSupplierShippingMethodName { get; set; }

    [Column("APReturnSupplierTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierTaxAmount { get; set; }

    [Column("APReturnSupplierSubTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierSubTotalCost { get; set; }

    [Column("APReturnSupplierTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierTotalCost { get; set; }

    [Column("APReturnSupplierSymbol")]
    [StringLength(50)]
    public string ApreturnSupplierSymbol { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApobjectType { get; set; }

    [Column("APInvoiceInDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInDate { get; set; }

    [Column("APReturnSupplierExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierExchangeRate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("APReturnSupplierPostedStatus")]
    [StringLength(50)]
    public string ApreturnSupplierPostedStatus { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("APReturnSupplierVATFormNo")]
    [StringLength(50)]
    public string ApreturnSupplierVatformNo { get; set; }

    [Column("APReturnSupplierVATInvoiceNo")]
    [StringLength(50)]
    public string ApreturnSupplierVatinvoiceNo { get; set; }

    [Column("APReturnSupplierVATSymbol")]
    [StringLength(50)]
    public string ApreturnSupplierVatsymbol { get; set; }

    [Column("APOutputVATDocumentType")]
    [StringLength(1000)]
    public string ApoutputVatdocumentType { get; set; }

    [Column("APOutputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string ApoutputVatinvoiceNoCombo { get; set; }

    [Column("FK_APPurchaseContractID")]
    public int? FkAppurchaseContractId { get; set; }

    [Column("APInputVATDocumentType")]
    [StringLength(1000)]
    public string ApinputVatdocumentType { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Column("APReturnSupplierReceiptType")]
    [StringLength(50)]
    public string ApreturnSupplierReceiptType { get; set; }

    [Column("APReturnSupplierTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierTaxPercent { get; set; }

    [InverseProperty("FkApreturnSupplier")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [ForeignKey("FkAceinvoiceTypeId")]
    [InverseProperty("ApreturnSuppliers")]
    public virtual AceinvoiceType FkAceinvoiceType { get; set; }

    [ForeignKey("FkAppurchaseContractId")]
    [InverseProperty("ApreturnSuppliers")]
    public virtual AppurchaseContract FkAppurchaseContract { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApreturnSuppliers")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApreturnSuppliers")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ApreturnSuppliers")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("ApreturnSuppliers")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ApreturnSuppliers")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ApreturnSuppliers")]
    public virtual Icstock FkIcstock { get; set; }
}
