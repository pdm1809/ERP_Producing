using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACUnfinishedConstructionCosts")]
public partial class AcunfinishedConstructionCost
{
    [Key]
    [Column("ACUnfinishedConstructionCostID")]
    public int AcunfinishedConstructionCostId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Required]
    [Column("ACUnfinishedConstructionCostNo")]
    [StringLength(50)]
    public string AcunfinishedConstructionCostNo { get; set; }

    [Required]
    [Column("ACUnfinishedConstructionCostName")]
    [StringLength(100)]
    public string AcunfinishedConstructionCostName { get; set; }

    [Column("ACUnfinishedConstructionCostStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcunfinishedConstructionCostStatus { get; set; }

    [Column("ACUnfinishedConstructionCostStartDate", TypeName = "datetime")]
    public DateTime? AcunfinishedConstructionCostStartDate { get; set; }

    [Column("ACUnfinishedConstructionCostFinishedDate", TypeName = "datetime")]
    public DateTime? AcunfinishedConstructionCostFinishedDate { get; set; }

    [Column("ACUnfinishedConstructionCostValue", TypeName = "decimal(18, 5)")]
    public decimal? AcunfinishedConstructionCostValue { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItems { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntries { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetails { get; set; } = new List<AcsalaryCalculationDetail>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItems { get; set; } = new List<AppaymentVoucherItem>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<ApsupplierPaymentDocument> ApsupplierPaymentDocuments { get; set; } = new List<ApsupplierPaymentDocument>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<ArcustomerPaymentDocument> ArcustomerPaymentDocuments { get; set; } = new List<ArcustomerPaymentDocument>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcunfinishedConstructionCosts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoices { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<HradvanceRequestPaymentTime> HradvanceRequestPaymentTimes { get; set; } = new List<HradvanceRequestPaymentTime>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkAcunfinishedConstructionCost")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();
}
