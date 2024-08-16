using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDormitorys")]
public partial class Hrdormitory
{
    [Key]
    [Column("HRDormitoryID")]
    public int HrdormitoryId { get; set; }

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

    [Required]
    [Column("HRDormitoryNo")]
    [StringLength(50)]
    public string HrdormitoryNo { get; set; }

    [Column("HRDormitoryName")]
    [StringLength(50)]
    public string HrdormitoryName { get; set; }

    [Column("HRDormitoryAcreage", TypeName = "decimal(18, 5)")]
    public decimal HrdormitoryAcreage { get; set; }

    [Column("HRDormitoryCapacity")]
    public int? HrdormitoryCapacity { get; set; }

    [Column("HRDormitoryDesc", TypeName = "ntext")]
    public string HrdormitoryDesc { get; set; }

    [Column("HRDormitoryDate", TypeName = "datetime")]
    public DateTime? HrdormitoryDate { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Hrdormitories")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Hrdormitories")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrdormitory")]
    public virtual ICollection<HrdormitoryCostItem> HrdormitoryCostItems { get; set; } = new List<HrdormitoryCostItem>();

    [InverseProperty("FkHrdormitory")]
    public virtual ICollection<HrdormitoryItem> HrdormitoryItems { get; set; } = new List<HrdormitoryItem>();

    [InverseProperty("FkHrdormitory")]
    public virtual ICollection<HrregisterDormitory> HrregisterDormitories { get; set; } = new List<HrregisterDormitory>();
}
