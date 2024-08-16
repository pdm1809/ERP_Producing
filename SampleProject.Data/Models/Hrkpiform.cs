using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRKPIForms")]
public partial class Hrkpiform
{
    [Key]
    [Column("HRKPIFormID")]
    public int HrkpiformId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("HRKPIFormNo")]
    [StringLength(50)]
    public string HrkpiformNo { get; set; }

    [Required]
    [Column("HRKPIFormName")]
    [StringLength(256)]
    public string HrkpiformName { get; set; }

    [Column("HRKPIFormDate", TypeName = "datetime")]
    public DateTime? HrkpiformDate { get; set; }

    [Column("HRKPIFormStartDate", TypeName = "datetime")]
    public DateTime? HrkpiformStartDate { get; set; }

    [Column("HRKPIFormFinishedDate", TypeName = "datetime")]
    public DateTime? HrkpiformFinishedDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("HRKPIFormStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrkpiformStatus { get; set; }

    [Required]
    [Column("HRKPIFormType")]
    [StringLength(32)]
    [Unicode(false)]
    public string HrkpiformType { get; set; }

    [Column("FK_BRBranchID2")]
    public int? FkBrbranchId2 { get; set; }

    [Column("HRKPIFormTotalWeight", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiformTotalWeight { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrkpiformFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrbranchId2")]
    [InverseProperty("HrkpiformFkBrbranchId2Navigations")]
    public virtual Brbranch FkBrbranchId2Navigation { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Hrkpiforms")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Hrkpiforms")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Hrkpiforms")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrkpiform")]
    public virtual ICollection<HrkpievaluationItem> HrkpievaluationItems { get; set; } = new List<HrkpievaluationItem>();

    [InverseProperty("FkHrkpiform")]
    public virtual ICollection<HrkpiformItem> HrkpiformItemFkHrkpiforms { get; set; } = new List<HrkpiformItem>();

    [InverseProperty("HrkpiformParent")]
    public virtual ICollection<HrkpiformItem> HrkpiformItemHrkpiformParents { get; set; } = new List<HrkpiformItem>();

    [InverseProperty("FkHrkpiform")]
    public virtual ICollection<HrkpiregistrationItem> HrkpiregistrationItems { get; set; } = new List<HrkpiregistrationItem>();

    [InverseProperty("FkHrkpiform")]
    public virtual ICollection<Hrkpiregistration> Hrkpiregistrations { get; set; } = new List<Hrkpiregistration>();
}
