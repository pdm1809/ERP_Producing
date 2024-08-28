using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRRegisterDormitorys")]
public partial class HrregisterDormitory
{
    [Key]
    [Column("HRRegisterDormitoryID")]
    public int HrregisterDormitoryId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_HRDormitoryID")]
    public int FkHrdormitoryId { get; set; }

    [Required]
    [Column("HRRegisterDormitoryNo")]
    [StringLength(50)]
    public string HrregisterDormitoryNo { get; set; }

    [Column("HRRegisterDormitoryFromDate", TypeName = "datetime")]
    public DateTime? HrregisterDormitoryFromDate { get; set; }

    [Column("HRRegisterDormitoryToDate", TypeName = "datetime")]
    public DateTime? HrregisterDormitoryToDate { get; set; }

    [Column("HRRegisterDormitoryDesc", TypeName = "ntext")]
    public string HrregisterDormitoryDesc { get; set; }

    [Column("HRRegisterDormitoryAcreage", TypeName = "decimal(18, 5)")]
    public decimal? HrregisterDormitoryAcreage { get; set; }

    [Column("HRRegisterDormitoryCapacity")]
    public int? HrregisterDormitoryCapacity { get; set; }

    [Column("FK_HREmployeeManager")]
    public int? FkHremployeeManager { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrregisterDormitories")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdormitoryId")]
    [InverseProperty("HrregisterDormitories")]
    public virtual Hrdormitory FkHrdormitory { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrregisterDormitoryFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeManager")]
    [InverseProperty("HrregisterDormitoryFkHremployeeManagerNavigations")]
    public virtual Hremployee FkHremployeeManagerNavigation { get; set; }

    [InverseProperty("FkHrregisterDormitory")]
    public virtual ICollection<HrregisterDormitoryItem> HrregisterDormitoryItems { get; set; } = new List<HrregisterDormitoryItem>();
}
