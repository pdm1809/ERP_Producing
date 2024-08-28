using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRPayRolls")]
public partial class HrpayRoll
{
    [Key]
    [Column("HRPayRollID")]
    public int HrpayRollId { get; set; }

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

    public bool? IsTransferred { get; set; }

    [Column("AATransferredDate", TypeName = "datetime")]
    public DateTime? AatransferredDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRTimeSheetID")]
    public int? FkHrtimeSheetId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("HRPayRollNo")]
    [StringLength(50)]
    public string HrpayRollNo { get; set; }

    [Required]
    [Column("HRPayRollName")]
    [StringLength(50)]
    public string HrpayRollName { get; set; }

    [Column("HRPayRollDesc")]
    [StringLength(512)]
    public string HrpayRollDesc { get; set; }

    [Required]
    [Column("HRPayRollType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrpayRollType { get; set; }

    [Column("HRPayRollStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrpayRollStatus { get; set; }

    [Column("HRPayRollDate", TypeName = "datetime")]
    public DateTime HrpayRollDate { get; set; }

    [Column("HRPayRollPeriod")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrpayRollPeriod { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrpayRolls")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrpayRolls")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrpayRoll")]
    public virtual ICollection<HratmcardPayroll> HratmcardPayrolls { get; set; } = new List<HratmcardPayroll>();

    [InverseProperty("FkHrpayRoll")]
    public virtual ICollection<HremployeePayRoll> HremployeePayRolls { get; set; } = new List<HremployeePayRoll>();
}
