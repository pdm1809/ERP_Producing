using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEInvoiceGenerals")]
public partial class AceinvoiceGeneral
{
    [Key]
    [Column("ACEInvoiceGeneralID")]
    public int AceinvoiceGeneralId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [StringLength(50)]
    public string SellerAppRecordId { get; set; }

    [StringLength(128)]
    public string InvoiceType { get; set; }

    [StringLength(128)]
    public string TemplateCode { get; set; }

    [StringLength(128)]
    public string InvoiceSeries { get; set; }

    [StringLength(128)]
    public string InvoiceNumber { get; set; }

    [StringLength(100)]
    public string InvoiceName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceIssuedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SignedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SubmittedDate { get; set; }

    [StringLength(128)]
    public string ContractNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContractDate { get; set; }

    [StringLength(10)]
    public string CurrencyCode { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? ExchangeRate { get; set; }

    [StringLength(400)]
    public string InvoiceNote { get; set; }

    public int? AdjustmentType { get; set; }

    [StringLength(15)]
    public string OriginalInvoiceId { get; set; }

    [StringLength(255)]
    public string AdditionalReferenceDesc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdditionalReferenceDate { get; set; }

    [StringLength(128)]
    public string DeliveryOrderNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryOrderDate { get; set; }

    [StringLength(100)]
    public string DeliveryOrderBy { get; set; }

    [StringLength(100)]
    public string DeliveryBy { get; set; }

    [StringLength(100)]
    public string FromWarehouseName { get; set; }

    [StringLength(100)]
    public string ToWarehouseName { get; set; }

    [StringLength(100)]
    public string TransportationMethod { get; set; }

    [StringLength(100)]
    public string ContainerNumber { get; set; }

    [StringLength(255)]
    public string SellerLegalName { get; set; }

    [StringLength(128)]
    public string SellerTaxCode { get; set; }

    [StringLength(500)]
    public string SellerAddressLine { get; set; }

    [StringLength(128)]
    public string SellerPostalCode { get; set; }

    [StringLength(128)]
    public string SellerDistrictName { get; set; }

    [StringLength(128)]
    public string SellerCityName { get; set; }

    [StringLength(128)]
    public string SellerCountryCode { get; set; }

    [StringLength(128)]
    public string SellerPhoneNumber { get; set; }

    [StringLength(256)]
    public string SellerFaxNumber { get; set; }

    [StringLength(128)]
    public string SellerEmail { get; set; }

    [StringLength(100)]
    public string SellerBankName { get; set; }

    [StringLength(128)]
    public string SellerBankAccount { get; set; }

    [StringLength(100)]
    public string SellerContactPersonName { get; set; }

    [StringLength(100)]
    public string SellerSignedPersonName { get; set; }

    [StringLength(100)]
    public string SellerSubmittedPersonName { get; set; }

    [StringLength(255)]
    public string BuyerLegalName { get; set; }

    [StringLength(128)]
    public string BuyerTaxCode { get; set; }

    [StringLength(128)]
    public string BuyerPostalCode { get; set; }

    [StringLength(128)]
    public string BuyerDistrictName { get; set; }

    [StringLength(128)]
    public string BuyerCityName { get; set; }

    [StringLength(128)]
    public string BuyerCountryCode { get; set; }

    [StringLength(128)]
    public string BuyerPhoneNumber { get; set; }

    [StringLength(128)]
    public string BuyerFaxNumber { get; set; }

    [StringLength(100)]
    public string BuyerBankName { get; set; }

    [StringLength(128)]
    public string BuyerBankAccount { get; set; }

    [StringLength(100)]
    public string BuyerContactPersonName { get; set; }

    [StringLength(100)]
    public string BuyerSignedPersonName { get; set; }

    [StringLength(100)]
    public string BuyerSubmittedPersonName { get; set; }

    [Column("SumOfTotalLineAmountWithoutVAT", TypeName = "decimal(15, 2)")]
    public decimal? SumOfTotalLineAmountWithoutVat { get; set; }

    [Column("TotalAmountWithoutVAT", TypeName = "decimal(15, 2)")]
    public decimal? TotalAmountWithoutVat { get; set; }

    [Column("TotalVATAmount", TypeName = "decimal(15, 2)")]
    public decimal? TotalVatamount { get; set; }

    [Column("TotalAmountWithVAT", TypeName = "decimal(15, 2)")]
    public decimal? TotalAmountWithVat { get; set; }

    [Column("TotalAmountWithVATFrn", TypeName = "decimal(15, 2)")]
    public decimal? TotalAmountWithVatfrn { get; set; }

    [Column("TotalAmountWithVATInWords")]
    [StringLength(255)]
    public string TotalAmountWithVatinWords { get; set; }

    public bool? IsTotalAmountPos { get; set; }

    [Column("IsTotalVATAmountPos")]
    public bool? IsTotalVatamountPos { get; set; }

    public bool? IsTotalAmtWithoutVatPos { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? DiscountAmount { get; set; }

    public bool? IsDiscountAmtPos { get; set; }

    [Column("QRCodeData")]
    [StringLength(422)]
    public string QrcodeData { get; set; }

    [StringLength(128)]
    public string SystemCode { get; set; }

    [StringLength(128)]
    public string TaxOfficeCode { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IssuedDate { get; set; }

    [StringLength(96)]
    public string SellerSignatureHash { get; set; }

    [StringLength(128)]
    public string OriginalCertifiedId { get; set; }

    [StringLength(15)]
    public string CertifiedId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CertifiedDate { get; set; }

    [StringLength(96)]
    public string Signature { get; set; }

    [StringLength(96)]
    public string PublicKey { get; set; }

    [Column("ACEInvoiceGeneralType")]
    [StringLength(100)]
    public string AceinvoiceGeneralType { get; set; }

    [Column("ACEInvoiceGeneralStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AceinvoiceGeneralStatus { get; set; }

    [Column("ACEInvoicePaymentMethodName")]
    [StringLength(512)]
    public string AceinvoicePaymentMethodName { get; set; }

    [StringLength(128)]
    public string BuyerCode { get; set; }

    [Required]
    [StringLength(512)]
    public string BuyerDisplayName { get; set; }

    [Required]
    [StringLength(512)]
    public string BuyerAddressLine { get; set; }

    [Required]
    [StringLength(256)]
    public string BuyerEmail { get; set; }

    [StringLength(100)]
    public string BuyerBankNumber { get; set; }

    [StringLength(256)]
    public string BuyerType { get; set; }

    [StringLength(256)]
    public string PaymentStatus { get; set; }

    [StringLength(256)]
    public string ReferModuleName { get; set; }

    [Column("ACEInvoiceGeneralReceiveType")]
    [StringLength(512)]
    public string AceinvoiceGeneralReceiveType { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [StringLength(150)]
    public string EmployeeCreateInvoiceName { get; set; }

    [Column("EmployeeUpLoadDataToEInvoiceName")]
    [StringLength(150)]
    public string EmployeeUpLoadDataToEinvoiceName { get; set; }

    [Column("ACEInvoiceGeneralNo")]
    [StringLength(50)]
    public string AceinvoiceGeneralNo { get; set; }

    [Column("ACEInvoiceGeneralHDStatus")]
    [StringLength(50)]
    public string AceinvoiceGeneralHdstatus { get; set; }

    [Column("FK_ACEInvoicePaymentMethodID")]
    public int? FkAceinvoicePaymentMethodId { get; set; }

    [Column("FK_ACTaxUnitID")]
    public int? FkActaxUnitId { get; set; }

    [Column("ACEInvoiceGeneralIsAdjustmentInv")]
    public bool? AceinvoiceGeneralIsAdjustmentInv { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? DiscountPercent { get; set; }

    [InverseProperty("FkAceinvoiceGeneral")]
    public virtual ICollection<AceinvoiceDetail> AceinvoiceDetails { get; set; } = new List<AceinvoiceDetail>();

    [InverseProperty("FkAceinvoiceGeneral")]
    public virtual ICollection<AceinvoicePayment> AceinvoicePayments { get; set; } = new List<AceinvoicePayment>();

    [InverseProperty("FkAceinvoiceGeneral")]
    public virtual ICollection<AceinvoiceTaxLevelAndAmount> AceinvoiceTaxLevelAndAmounts { get; set; } = new List<AceinvoiceTaxLevelAndAmount>();

    [ForeignKey("FkAceinvoicePaymentMethodId")]
    [InverseProperty("AceinvoiceGenerals")]
    public virtual AceinvoicePaymentMethod FkAceinvoicePaymentMethod { get; set; }

    [ForeignKey("FkActaxUnitId")]
    [InverseProperty("AceinvoiceGenerals")]
    public virtual ActaxUnit FkActaxUnit { get; set; }
}
