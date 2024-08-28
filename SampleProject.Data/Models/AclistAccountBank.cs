using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACListAccountBanks")]
public partial class AclistAccountBank
{
    [Key]
    [Column("ACListAccountBankID")]
    public int AclistAccountBankId { get; set; }

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

    [Column("ACListAccountBankNo")]
    [StringLength(100)]
    public string AclistAccountBankNo { get; set; }

    [Column("ACListAccountBankName")]
    [StringLength(512)]
    public string AclistAccountBankName { get; set; }

    [Required]
    [Column("ACListAccountBankAccount")]
    [StringLength(50)]
    [Unicode(false)]
    public string AclistAccountBankAccount { get; set; }

    [Column("ACListAccountBankBranch")]
    [StringLength(200)]
    public string AclistAccountBankBranch { get; set; }

    [Column("FK_ACListAccountBankBranchCityID")]
    public int? FkAclistAccountBankBranchCityId { get; set; }

    [Column("ACListAccountBankAccountHolder")]
    [StringLength(512)]
    public string AclistAccountBankAccountHolder { get; set; }

    [Column("ACListAccountBankAccountHolderIDNumber")]
    [StringLength(50)]
    public string AclistAccountBankAccountHolderIdnumber { get; set; }

    [Column("ACListAccountBankAccountHolderIDCardDate", TypeName = "datetime")]
    public DateTime? AclistAccountBankAccountHolderIdcardDate { get; set; }

    [Column("ACListAccountBankAccountHolderCity")]
    [StringLength(50)]
    public string AclistAccountBankAccountHolderCity { get; set; }

    [Column("FK_ACObjectID")]
    public int FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    public string AcobjectType { get; set; }

    [Column("ACListAccountBankObjectAddress")]
    [StringLength(512)]
    public string AclistAccountBankObjectAddress { get; set; }

    [Column("ACListAccountBankSwiftCode")]
    [StringLength(255)]
    public string AclistAccountBankSwiftCode { get; set; }

    [Column("ACListAccountBankIBanNumber")]
    [StringLength(255)]
    public string AclistAccountBankIbanNumber { get; set; }

    [Column("ACListAccountBankStatus")]
    [StringLength(50)]
    public string AclistAccountBankStatus { get; set; }

    [Column("FK_GEBankID")]
    public int? FkGebankId { get; set; }

    [InverseProperty("FkAclistAccountBank")]
    public virtual ICollection<AcbankTransaction> AcbankTransactions { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkAclistAccountBank")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPayments { get; set; } = new List<ApsupplierPayment>();

    [ForeignKey("FkAclistAccountBankBranchCityId")]
    [InverseProperty("AclistAccountBanks")]
    public virtual GestateProvince FkAclistAccountBankBranchCity { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AclistAccountBanks")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGebankId")]
    [InverseProperty("AclistAccountBanks")]
    public virtual Gebank FkGebank { get; set; }
}
