using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACRetailVATs")]
public partial class AcretailVat
{
    [Key]
    [Column("ACRetailVATID")]
    public int AcretailVatid { get; set; }

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

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ARSellerID")]
    public int FkArsellerId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ACTaxUnitID")]
    public int? FkActaxUnitId { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Required]
    [Column("ACRetailVATNo")]
    [StringLength(50)]
    public string AcretailVatno { get; set; }

    [Column("ACRetailVATName")]
    [StringLength(100)]
    public string AcretailVatname { get; set; }

    [Column("ACRetailVATDesc")]
    [StringLength(1000)]
    public string AcretailVatdesc { get; set; }

    [Column("ACRetailVATDate", TypeName = "datetime")]
    public DateTime? AcretailVatdate { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArobjectType { get; set; }

    [Column("ACRetailVATExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatexchangeRate { get; set; }

    [Column("ACRetailVATTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcretailVattaxNumber { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("ACRetailVATSOContactName")]
    [StringLength(1000)]
    public string AcretailVatsocontactName { get; set; }

    [Column("ACRetailVATInvoiceRequest")]
    [StringLength(100)]
    public string AcretailVatinvoiceRequest { get; set; }

    [Column("ACRetailVATStatus")]
    [StringLength(100)]
    public string AcretailVatstatus { get; set; }

    [Column("ACRetailVATReference")]
    [StringLength(512)]
    public string AcretailVatreference { get; set; }

    [Column("ACRetailVATSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatsubTotalAmount { get; set; }

    [Column("ACRetailVATTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVattaxPercent { get; set; }

    [Column("ACRetailVATTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVattaxAmount { get; set; }

    [Column("ACRetailVATDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatdiscountPerCent { get; set; }

    [Column("ACRetailVATDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatdiscountAmount { get; set; }

    [Column("ACRetailVATTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVattotalAmount { get; set; }

    [Column("ACRetailVATComment")]
    [StringLength(512)]
    public string AcretailVatcomment { get; set; }

    [Column("AROutputVATDocumentType")]
    [StringLength(1000)]
    public string AroutputVatdocumentType { get; set; }

    [Column("ACRetailVATVATFormNo")]
    [StringLength(50)]
    public string AcretailVatvatformNo { get; set; }

    [Column("ACRetailVATVATSymbol")]
    [StringLength(50)]
    public string AcretailVatvatsymbol { get; set; }

    [Column("ACRetailVATVATInvoiceNo")]
    [StringLength(50)]
    public string AcretailVatvatinvoiceNo { get; set; }

    [Column("ACRetailVATVATPaymentContactInformation")]
    [StringLength(512)]
    public string AcretailVatvatpaymentContactInformation { get; set; }

    [Column("AROutputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string AroutputVatinvoiceNoCombo { get; set; }

    [Column("ACRetailVATInternalComment")]
    [StringLength(512)]
    public string AcretailVatinternalComment { get; set; }

    [InverseProperty("FkAcretailVat")]
    public virtual ICollection<AcretailVatitem> AcretailVatitems { get; set; } = new List<AcretailVatitem>();

    [ForeignKey("FkAceinvoiceTypeId")]
    [InverseProperty("AcretailVats")]
    public virtual AceinvoiceType FkAceinvoiceType { get; set; }

    [ForeignKey("FkActaxUnitId")]
    [InverseProperty("AcretailVats")]
    public virtual ActaxUnit FkActaxUnit { get; set; }

    [ForeignKey("FkArsellerId")]
    [InverseProperty("AcretailVatFkArsellers")]
    public virtual Hremployee FkArseller { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcretailVats")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcretailVats")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AcretailVatFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }
}
