using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeATMCardManages")]
public partial class HremployeeAtmcardManage
{
    [Key]
    [Column("HREmployeeATMCardManageID")]
    public int HremployeeAtmcardManageId { get; set; }

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

    [Column("FK_HRATMCardManageID")]
    public int FkHratmcardManageId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HREmployeeATMCardManageAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAtmcardManageAmount { get; set; }

    [Column("HREmployeeATMCardManageBankAccount")]
    [StringLength(512)]
    public string HremployeeAtmcardManageBankAccount { get; set; }

    [Column("HREmployeeATMCardManagePhone")]
    [StringLength(512)]
    public string HremployeeAtmcardManagePhone { get; set; }

    [Column("HREmployeeATMCardManageRegisterInsurance")]
    [StringLength(512)]
    public string HremployeeAtmcardManageRegisterInsurance { get; set; }

    [Column("HREmployeeATMCardManageCardRank")]
    [StringLength(512)]
    public string HremployeeAtmcardManageCardRank { get; set; }

    [Column("HREmployeeATMCardManageStatus")]
    [StringLength(50)]
    public string HremployeeAtmcardManageStatus { get; set; }

    [ForeignKey("FkHratmcardManageId")]
    [InverseProperty("HremployeeAtmcardManages")]
    public virtual HratmcardManage FkHratmcardManage { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeAtmcardManages")]
    public virtual Hremployee FkHremployee { get; set; }
}
