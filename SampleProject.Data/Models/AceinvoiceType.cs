using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEInvoiceTypes")]
public partial class AceinvoiceType
{
    [Key]
    [Column("ACEInvoiceTypeID")]
    public int AceinvoiceTypeId { get; set; }

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

    [Column("ACEInvoiceTypeNo")]
    [StringLength(12)]
    [Unicode(false)]
    public string AceinvoiceTypeNo { get; set; }

    [Column("ACEInvoiceTypeTemplateCode")]
    [StringLength(12)]
    [Unicode(false)]
    public string AceinvoiceTypeTemplateCode { get; set; }

    [Column("ACEInvoiceTypeSeries")]
    [StringLength(12)]
    [Unicode(false)]
    public string AceinvoiceTypeSeries { get; set; }

    [Column("ACEInvoiceTypeName")]
    [StringLength(256)]
    public string AceinvoiceTypeName { get; set; }

    [Column("ACEInvoiceTypeNumber")]
    [StringLength(12)]
    [Unicode(false)]
    public string AceinvoiceTypeNumber { get; set; }

    [Column("ACEInvoiceTypeLength")]
    public int? AceinvoiceTypeLength { get; set; }

    [Column("ACEInvoiceTypeStart")]
    public int? AceinvoiceTypeStart { get; set; }

    [Column("ACEInvoiceTypeCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AceinvoiceTypeCombo { get; set; }

    [InverseProperty("FkAceinvoiceType")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkAceinvoiceType")]
    public virtual ICollection<AcassetReceipt> AcassetReceipts { get; set; } = new List<AcassetReceipt>();

    [InverseProperty("FkAceinvoiceType")]
    public virtual ICollection<AcretailVat> AcretailVats { get; set; } = new List<AcretailVat>();

    [InverseProperty("FkAceinvoiceType")]
    public virtual ICollection<ApfeePaymentFeeConfig> ApfeePaymentFeeConfigs { get; set; } = new List<ApfeePaymentFeeConfig>();

    [InverseProperty("FkAceinvoiceType")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkAceinvoiceType")]
    public virtual ICollection<ApreturnSupplier> ApreturnSuppliers { get; set; } = new List<ApreturnSupplier>();

    [InverseProperty("FkAceinvoiceType")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkAceinvoiceType")]
    public virtual ICollection<ArsaleReturn> ArsaleReturns { get; set; } = new List<ArsaleReturn>();

    [InverseProperty("FkAceinvoiceType")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoices { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkAceinvoiceType")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();
}
