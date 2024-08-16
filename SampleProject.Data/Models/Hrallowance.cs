using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAllowances")]
public partial class Hrallowance
{
    [Key]
    [Column("HRAllowanceID")]
    public int HrallowanceId { get; set; }

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
    [Column("HRAllowanceNo")]
    [StringLength(50)]
    public string HrallowanceNo { get; set; }

    [Required]
    [Column("HRAllowanceName")]
    [StringLength(100)]
    public string HrallowanceName { get; set; }

    [Column("HRAllowanceDesc")]
    [StringLength(512)]
    public string HrallowanceDesc { get; set; }

    [Column("HRAllowanceFromDate", TypeName = "datetime")]
    public DateTime HrallowanceFromDate { get; set; }

    [Column("HRAllowanceToDate", TypeName = "datetime")]
    public DateTime HrallowanceToDate { get; set; }

    [Required]
    [Column("HRAllowanceType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrallowanceType { get; set; }

    [Required]
    [Column("HRAllowanceOption")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrallowanceOption { get; set; }

    [Required]
    [Column("HRAllowanceValue")]
    [StringLength(512)]
    public string HrallowanceValue { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("HRAllowanceConst")]
    public bool? HrallowanceConst { get; set; }

    [Column("HRAllowanceCategory")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrallowanceCategory { get; set; }

    [Column("HRAllowanceByWorkDay")]
    public bool? HrallowanceByWorkDay { get; set; }

    [Column("HRAllowanceConfigValue", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceConfigValue { get; set; }

    [Column("HRAllowancePlusHoliday")]
    public bool? HrallowancePlusHoliday { get; set; }

    [Column("HRAllowanceContdifference", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceContdifference { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Hrallowances")]
    public virtual Brbranch FkBrbranch { get; set; }

    [InverseProperty("FkHrallowance")]
    public virtual ICollection<HrallowanceItem> HrallowanceItemFkHrallowances { get; set; } = new List<HrallowanceItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrallowanceItem> HrallowanceItemFkHremployees { get; set; } = new List<HrallowanceItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<HrallowanceItem> HrallowanceItemFkIcmeasureUnits { get; set; } = new List<HrallowanceItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<HrallowanceItem> HrallowanceItemFkIcproducts { get; set; } = new List<HrallowanceItem>();

    [InverseProperty("FkHrallowance")]
    public virtual ICollection<HremployeeAllowance> HremployeeAllowances { get; set; } = new List<HremployeeAllowance>();
}
