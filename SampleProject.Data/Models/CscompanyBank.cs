using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("CSCompanyBanks")]
[Microsoft.EntityFrameworkCore.Index("FkBrbranchId", "FkCscompanyId", Name = "Idx_CSCompanyBanks")]
public partial class CscompanyBank
{
    [Key]
    [Column("CSCompanyBankID")]
    public int CscompanyBankId { get; set; }

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

    [Column("FK_CSCompanyID")]
    public int FkCscompanyId { get; set; }

    [Column("FK_GECurrenyID")]
    public int FkGecurrenyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("CSCompanyBankCode")]
    [StringLength(50)]
    public string CscompanyBankCode { get; set; }

    [Required]
    [Column("CSCompanyBankName")]
    [StringLength(100)]
    public string CscompanyBankName { get; set; }

    [Required]
    [Column("CSCompanyBankAccount")]
    [StringLength(50)]
    [Unicode(false)]
    public string CscompanyBankAccount { get; set; }

    public bool? IsDefault { get; set; }

    [Column("FK_ACAcountID")]
    public int? FkAcacountId { get; set; }

    [Column("CSCompanyBankAddress")]
    [StringLength(250)]
    public string CscompanyBankAddress { get; set; }

    [Column("CSCompanyBankSwiftCode")]
    [StringLength(250)]
    public string CscompanyBankSwiftCode { get; set; }

    [Column("CSCompanyBankBeneficiary")]
    [StringLength(256)]
    public string CscompanyBankBeneficiary { get; set; }

    [Column("CSCompanyBankAbbreviation")]
    [StringLength(50)]
    public string CscompanyBankAbbreviation { get; set; }

    [Column("CSCompanyBankSaleType")]
    [StringLength(100)]
    public string CscompanyBankSaleType { get; set; }

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<AcaccountDetail> AcaccountDetails { get; set; } = new List<AcaccountDetail>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<AcbalanceAmountArisingObjectDetail> AcbalanceAmountArisingObjectDetails { get; set; } = new List<AcbalanceAmountArisingObjectDetail>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<AcbankTransaction> AcbankTransactionFkCscompanyBanks { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkToCscompanyBank")]
    public virtual ICollection<AcbankTransaction> AcbankTransactionFkToCscompanyBanks { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<Acdocument> Acdocuments { get; set; } = new List<Acdocument>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<AcloanAgreement> AcloanAgreements { get; set; } = new List<AcloanAgreement>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<AcloanReceipt> AcloanReceipts { get; set; } = new List<AcloanReceipt>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<AcmoneyChangeItem> AcmoneyChangeItems { get; set; } = new List<AcmoneyChangeItem>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<AppaymentVoucher> AppaymentVouchers { get; set; } = new List<AppaymentVoucher>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPayments { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<ArcustomerPaymentDetail> ArcustomerPaymentDetails { get; set; } = new List<ArcustomerPaymentDetail>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<ArcustomerPayment> ArcustomerPayments { get; set; } = new List<ArcustomerPayment>();

    [InverseProperty("FkArcustomerContactPayment")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<ArpospaymentDetail> ArpospaymentDetails { get; set; } = new List<ArpospaymentDetail>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<ArreceiptVoucher> ArreceiptVouchers { get; set; } = new List<ArreceiptVoucher>();

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("CscompanyBanks")]
    public virtual Brbranch FkBrbranch { get; set; }

    [InverseProperty("FkCscompanyBank")]
    public virtual ICollection<HratmcardPayroll> HratmcardPayrolls { get; set; } = new List<HratmcardPayroll>();
}
