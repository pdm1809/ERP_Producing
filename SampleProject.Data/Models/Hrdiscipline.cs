using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDisciplines")]
public partial class Hrdiscipline
{
    [Key]
    [Column("HRDisciplineID")]
    public int HrdisciplineId { get; set; }

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
    [Column("HRDisciplineNo")]
    [StringLength(50)]
    public string HrdisciplineNo { get; set; }

    [Required]
    [Column("HRDisciplineName")]
    [StringLength(100)]
    public string HrdisciplineName { get; set; }

    [Column("HRDisciplineDesc")]
    [StringLength(512)]
    public string HrdisciplineDesc { get; set; }

    [Column("HRDisciplineFromDate", TypeName = "datetime")]
    public DateTime HrdisciplineFromDate { get; set; }

    [Column("HRDisciplineToDate", TypeName = "datetime")]
    public DateTime HrdisciplineToDate { get; set; }

    [Required]
    [Column("HRDisciplineType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrdisciplineType { get; set; }

    [Required]
    [Column("HRDisciplineValue")]
    [StringLength(512)]
    public string HrdisciplineValue { get; set; }

    [Column("HRDisciplineOption")]
    [StringLength(200)]
    public string HrdisciplineOption { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeRequest")]
    public int? FkHremployeeRequest { get; set; }

    [Column("HRDisciplineNumber")]
    [StringLength(10)]
    public string HrdisciplineNumber { get; set; }

    [Column("HRDisciplineExplain")]
    [StringLength(1000)]
    public string HrdisciplineExplain { get; set; }

    [Column("HRDisciplineEmployeeName")]
    [StringLength(50)]
    public string HrdisciplineEmployeeName { get; set; }

    [Column("HRDisciplineEmployeeCardNumber")]
    [StringLength(10)]
    public string HrdisciplineEmployeeCardNumber { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Hrdisciplines")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeRequest")]
    [InverseProperty("Hrdisciplines")]
    public virtual Hremployee FkHremployeeRequestNavigation { get; set; }

    [InverseProperty("FkHrdiscipline")]
    public virtual ICollection<HremployeeDiscipline> HremployeeDisciplines { get; set; } = new List<HremployeeDiscipline>();
}
