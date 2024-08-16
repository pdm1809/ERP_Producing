using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeATMCardPayrolls")]
public partial class HremployeeAtmcardPayroll
{
    [Key]
    [Column("HREmployeeATMCardPayrollID")]
    public int HremployeeAtmcardPayrollId { get; set; }

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

    [Column("FK_HRATMCardPayrollID")]
    public int FkHratmcardPayrollId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HREmployeeATMCardPayrollAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAtmcardPayrollAmount { get; set; }

    [Column("HREmployeeATMCardPayrollBankAccount")]
    [StringLength(512)]
    public string HremployeeAtmcardPayrollBankAccount { get; set; }

    [Column("HREmployeeATMCardPayrollCompanyAccount")]
    [StringLength(50)]
    public string HremployeeAtmcardPayrollCompanyAccount { get; set; }

    [Column("HREmployeeATMCardPayrollCompanyAccountHolder")]
    [StringLength(255)]
    public string HremployeeAtmcardPayrollCompanyAccountHolder { get; set; }

    [Column("FK_BRBranch1")]
    public int? FkBrbranch1 { get; set; }

    [Column("FK_BRBranch2")]
    public int? FkBrbranch2 { get; set; }

    [Column("HREmployeeATMCardPayrollDesc")]
    [StringLength(255)]
    public string HremployeeAtmcardPayrollDesc { get; set; }

    [Column("HREmployeeATMCardPayrollBankCN1")]
    [StringLength(50)]
    public string HremployeeAtmcardPayrollBankCn1 { get; set; }

    [Column("HREmployeeATMCardPayrollBankCN2")]
    [StringLength(50)]
    public string HremployeeAtmcardPayrollBankCn2 { get; set; }

    [ForeignKey("FkBrbranch1")]
    [InverseProperty("HremployeeAtmcardPayrollFkBrbranch1Navigations")]
    public virtual Brbranch FkBrbranch1Navigation { get; set; }

    [ForeignKey("FkBrbranch2")]
    [InverseProperty("HremployeeAtmcardPayrollFkBrbranch2Navigations")]
    public virtual Brbranch FkBrbranch2Navigation { get; set; }

    [ForeignKey("FkHratmcardPayrollId")]
    [InverseProperty("HremployeeAtmcardPayrolls")]
    public virtual HratmcardPayroll FkHratmcardPayroll { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeAtmcardPayrolls")]
    public virtual Hremployee FkHremployee { get; set; }
}
