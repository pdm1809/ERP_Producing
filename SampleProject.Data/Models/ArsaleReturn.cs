using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleReturns")]
[Microsoft.EntityFrameworkCore.Index("ArsaleReturnNo", "ArsaleReturnDate", "FkBrbranchId", "FkArcustomerId", "ArsaleReturnType", Name = "Idx_ARSaleReturns")]
public partial class ArsaleReturn
{
    [Key]
    [Column("ARSaleReturnID")]
    public int ArsaleReturnId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Required]
    [Column("ARSaleReturnNo")]
    [StringLength(50)]
    public string ArsaleReturnNo { get; set; }

    [Column("ARSaleReturnName")]
    [StringLength(50)]
    public string ArsaleReturnName { get; set; }

    [Column("ARSaleReturnDesc")]
    [StringLength(512)]
    public string ArsaleReturnDesc { get; set; }

    [Column("ARSaleReturnComment")]
    [StringLength(512)]
    public string ArsaleReturnComment { get; set; }

    [Column("ARSaleReturnDate", TypeName = "datetime")]
    public DateTime? ArsaleReturnDate { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("ARSaleReturnPaymentTerm")]
    [StringLength(50)]
    public string ArsaleReturnPaymentTerm { get; set; }

    [Column("ARSaleReturnStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnStatus { get; set; }

    [Column("ARSaleReturnType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnType { get; set; }

    [Column("ARSaleReturnDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnDiscountPerCent { get; set; }

    [Column("ARSaleReturnDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnDiscountFix { get; set; }

    [Column("ARSaleReturnNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnNetAmount { get; set; }

    [Column("ARSaleReturnTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnTaxPercent { get; set; }

    [Column("ARSaleReturnTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnTaxAmount { get; set; }

    [Column("ARSaleReturnSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnSubTotalAmount { get; set; }

    [Column("ARSaleReturnTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnTotalAmount { get; set; }

    [Column("ARSaleReturnMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode01Combo { get; set; }

    [Column("ARSaleReturnMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode02Combo { get; set; }

    [Column("ARSaleReturnMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode03Combo { get; set; }

    [Column("ARSaleReturnMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode04Combo { get; set; }

    [Column("ARSaleReturnMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode05Combo { get; set; }

    [Column("ARSaleReturnMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode06Combo { get; set; }

    [Column("ARSaleReturnMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode07Combo { get; set; }

    [Column("ARSaleReturnMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode08Combo { get; set; }

    [Column("ARSaleReturnMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode09Combo { get; set; }

    [Column("ARSaleReturnMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode10Combo { get; set; }

    [Column("ARSaleReturnMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode11Combo { get; set; }

    [Column("ARSaleReturnMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnMatchCode12Combo { get; set; }

    [Column("ARSaleReturnExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARSaleReturnTransferredDate", TypeName = "datetime")]
    public DateTime? ArsaleReturnTransferredDate { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArobjectType { get; set; }

    [Column("ACObjectContactAddressLine3")]
    [StringLength(200)]
    public string AcobjectContactAddressLine3 { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("ARSaleReturnPostedStatus")]
    [StringLength(50)]
    public string ArsaleReturnPostedStatus { get; set; }

    [Column("ARSaleReturnVATInvoiceNo")]
    [StringLength(50)]
    public string ArsaleReturnVatinvoiceNo { get; set; }

    [Column("ARSaleReturnVATSymbol")]
    [StringLength(50)]
    public string ArsaleReturnVatsymbol { get; set; }

    [Column("ARSaleReturnTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleReturnTaxNumber { get; set; }

    [Column("ARInputVATDocumentType")]
    [StringLength(1000)]
    public string ArinputVatdocumentType { get; set; }

    [Column("ARSaleReturnVATFormNo")]
    [StringLength(50)]
    public string ArsaleReturnVatformNo { get; set; }

    [Column("ARInputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string ArinputVatinvoiceNoCombo { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Column("AROutputVATDocumentType")]
    [StringLength(1000)]
    public string AroutputVatdocumentType { get; set; }

    [Column("ARSaleReturnProductType")]
    [StringLength(50)]
    public string ArsaleReturnProductType { get; set; }

    [Column("ARSaleReturnProject")]
    [StringLength(100)]
    public string ArsaleReturnProject { get; set; }

    [Column("ARSaleReturnSaleContract")]
    [StringLength(100)]
    public string ArsaleReturnSaleContract { get; set; }

    [Column("ARSaleReturnInvoiceVATNo")]
    [StringLength(50)]
    public string ArsaleReturnInvoiceVatno { get; set; }

    [Column("ARSaleReturnGetPriceDate", TypeName = "datetime")]
    public DateTime? ArsaleReturnGetPriceDate { get; set; }

    [Column("ARSaleReturnSerialNo")]
    [StringLength(50)]
    public string ArsaleReturnSerialNo { get; set; }

    [Column("ARSaleReturnNote")]
    public byte[] ArsaleReturnNote { get; set; }

    [InverseProperty("FkArsaleReturn")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkArsaleReturn")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkArsaleReturn")]
    public virtual ICollection<ArdeliveryPlanTruckPoint> ArdeliveryPlanTruckPoints { get; set; } = new List<ArdeliveryPlanTruckPoint>();

    [InverseProperty("FkArsaleReturn")]
    public virtual ICollection<ArsaleReturnItem> ArsaleReturnItems { get; set; } = new List<ArsaleReturnItem>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ArsaleReturns")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAceinvoiceTypeId")]
    [InverseProperty("ArsaleReturns")]
    public virtual AceinvoiceType FkAceinvoiceType { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArsaleReturns")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArsaleReturns")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArsaleReturns")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArsaleReturns")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArsaleReturns")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArsaleReturns")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ArsaleReturns")]
    public virtual Pmproject FkPmproject { get; set; }
}
