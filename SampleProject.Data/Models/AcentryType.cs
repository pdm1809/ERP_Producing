using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEntryTypes")]
public partial class AcentryType
{
    [Key]
    [Column("ACEntryTypeID")]
    public int AcentryTypeId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Required]
    [Column("ACEntryTypeName")]
    [StringLength(100)]
    public string AcentryTypeName { get; set; }

    [Required]
    [Column("ACEntryTypeDesc")]
    [StringLength(512)]
    public string AcentryTypeDesc { get; set; }

    [InverseProperty("FkAcentryType")]
    public virtual ICollection<AcaccountTranferCost> AcaccountTranferCosts { get; set; } = new List<AcaccountTranferCost>();

    [InverseProperty("FkAcentryType")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItems { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkAcentryType")]
    public virtual ICollection<AcdocTypeEntry> AcdocTypeEntries { get; set; } = new List<AcdocTypeEntry>();

    [InverseProperty("FkAcentryType")]
    public virtual ICollection<AcdocTypeEntryFunctionMapping> AcdocTypeEntryFunctionMappings { get; set; } = new List<AcdocTypeEntryFunctionMapping>();

    [InverseProperty("FkAcentryType")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntries { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkAcentryType")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItems { get; set; } = new List<AppaymentVoucherItem>();

    [InverseProperty("FkAcentryType")]
    public virtual ICollection<ApsupplierPaymentDocument> ApsupplierPaymentDocuments { get; set; } = new List<ApsupplierPaymentDocument>();

    [InverseProperty("FkAcentryType")]
    public virtual ICollection<ArcustomerPaymentDocument> ArcustomerPaymentDocuments { get; set; } = new List<ArcustomerPaymentDocument>();

    [InverseProperty("FkAcentryType")]
    public virtual ICollection<ArreceiptVoucherItem> ArreceiptVoucherItems { get; set; } = new List<ArreceiptVoucherItem>();
}
