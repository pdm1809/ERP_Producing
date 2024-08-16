using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APBillOfLadings")]
public partial class ApbillOfLading
{
    [Key]
    [Column("APBillOfLadingID")]
    public int ApbillOfLadingId { get; set; }

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
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("APBillOfLadingReference")]
    [StringLength(50)]
    public string ApbillOfLadingReference { get; set; }

    [Required]
    [Column("APBillOfLadingDeclarationNo")]
    [StringLength(50)]
    public string ApbillOfLadingDeclarationNo { get; set; }

    [Required]
    [Column("APBillOfLadingDeclarationNumber")]
    [StringLength(50)]
    public string ApbillOfLadingDeclarationNumber { get; set; }

    [Column("APBillOfLadingRegisDate", TypeName = "datetime")]
    public DateTime ApbillOfLadingRegisDate { get; set; }

    [Column("APBillOfLadingType")]
    [StringLength(50)]
    public string ApbillOfLadingType { get; set; }

    [Column("APBillOfLadingNo")]
    [StringLength(50)]
    public string ApbillOfLadingNo { get; set; }

    [Column("APBillOfLadingDate", TypeName = "datetime")]
    public DateTime? ApbillOfLadingDate { get; set; }

    [Column("APBillOfLadingStatus")]
    [StringLength(50)]
    public string ApbillOfLadingStatus { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    public string ApobjectType { get; set; }

    [Column("APBillOfLadingContractNo")]
    [StringLength(50)]
    public string ApbillOfLadingContractNo { get; set; }

    [Column("APBillOfLadingContractDate", TypeName = "datetime")]
    public DateTime? ApbillOfLadingContractDate { get; set; }

    [Column("APBillOfLadingTaxNumber")]
    [StringLength(50)]
    public string ApbillOfLadingTaxNumber { get; set; }

    [Column("APBillOfLadingSupplierNo")]
    [StringLength(50)]
    public string ApbillOfLadingSupplierNo { get; set; }

    [Column("APBillOfLadingVATDate", TypeName = "datetime")]
    public DateTime? ApbillOfLadingVatdate { get; set; }

    [Column("FK_GEPaymentTermID")]
    public int? FkGepaymentTermId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("APBillOfLadingExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingExchangeRate { get; set; }

    [Column("APBillOfLadingDesc")]
    [StringLength(500)]
    public string ApbillOfLadingDesc { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("APBillOfLadingImportTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingImportTaxPercent { get; set; }

    [Column("APBillOfLadingConsumptionTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingConsumptionTaxPercent { get; set; }

    [Column("APBillOfLadingEnviromentTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingEnviromentTaxPercent { get; set; }

    [Column("APBillOfLadingVATTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingVattaxPercent { get; set; }

    [Column("APBillOfLadingClearanceDate", TypeName = "datetime")]
    public DateTime? ApbillOfLadingClearanceDate { get; set; }

    [Column("APBillOfLadingImportExportType")]
    [StringLength(50)]
    public string ApbillOfLadingImportExportType { get; set; }

    [Column("APBillOfLadingBOLDate", TypeName = "datetime")]
    public DateTime? ApbillOfLadingBoldate { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [Column("APBillOfLadingPostedStatus")]
    [StringLength(50)]
    public string ApbillOfLadingPostedStatus { get; set; }

    [InverseProperty("FkApbillOfLading")]
    public virtual ICollection<ApbillOfLadingItem> ApbillOfLadingItems { get; set; } = new List<ApbillOfLadingItem>();

    [InverseProperty("FkApbillOfLading")]
    public virtual ICollection<AppaymentVoucherItemDetail> AppaymentVoucherItemDetails { get; set; } = new List<AppaymentVoucherItemDetail>();

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApbillOfLadings")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ApbillOfLadings")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApbillOfLadings")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ApbillOfLadings")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGepaymentTermId")]
    [InverseProperty("ApbillOfLadings")]
    public virtual GepaymentTerm FkGepaymentTerm { get; set; }

    [InverseProperty("FkApbillOfLading")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();
}
