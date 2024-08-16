using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRATMCardPayrolls")]
public partial class HratmcardPayroll
{
    [Key]
    [Column("HRATMCardPayrollID")]
    public int HratmcardPayrollId { get; set; }

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

    [Column("FK_HRPayRollID")]
    public int? FkHrpayRollId { get; set; }

    [Required]
    [Column("HRATMCardPayrollNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string HratmcardPayrollNo { get; set; }

    [Column("HRATMCardPayrollName")]
    [StringLength(50)]
    public string HratmcardPayrollName { get; set; }

    [Column("HRATMCardPayrollDesc")]
    [StringLength(255)]
    public string HratmcardPayrollDesc { get; set; }

    [Column("HRATMCardPayrollDate", TypeName = "datetime")]
    public DateTime? HratmcardPayrollDate { get; set; }

    [Column("HRATMCardPayrollMonthDate", TypeName = "datetime")]
    public DateTime? HratmcardPayrollMonthDate { get; set; }

    [Column("HRATMCardPayrollStatus")]
    [StringLength(50)]
    public string HratmcardPayrollStatus { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("HRATMCardPayrollBankCN")]
    [StringLength(50)]
    public string HratmcardPayrollBankCn { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HratmcardPayrolls")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("HratmcardPayrolls")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkHrpayRollId")]
    [InverseProperty("HratmcardPayrolls")]
    public virtual HrpayRoll FkHrpayRoll { get; set; }

    [InverseProperty("FkHratmcardPayroll")]
    public virtual ICollection<HremployeeAtmcardPayroll> HremployeeAtmcardPayrolls { get; set; } = new List<HremployeeAtmcardPayroll>();
}
