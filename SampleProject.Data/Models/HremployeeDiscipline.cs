using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeDisciplines")]
public partial class HremployeeDiscipline
{
    [Key]
    [Column("HREmployeeDisciplineID")]
    public int HremployeeDisciplineId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRDisciplineID")]
    public int FkHrdisciplineId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("HREmployeeDisciplineValue")]
    [StringLength(512)]
    public string HremployeeDisciplineValue { get; set; }

    [Column("HREmployeeDisciplineValueAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeDisciplineValueAmount { get; set; }

    [Column("HREmployeeDisciplineDate", TypeName = "datetime")]
    public DateTime? HremployeeDisciplineDate { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID2")]
    public int? FkHremployeeId2 { get; set; }

    [Column("HREmployeeDisciplineNo")]
    [StringLength(50)]
    public string HremployeeDisciplineNo { get; set; }

    [Column("HREmployeeDisciplineCreateType")]
    [StringLength(50)]
    public string HremployeeDisciplineCreateType { get; set; }

    [Column("HREmployeeDisciplineGroup")]
    [StringLength(50)]
    public string HremployeeDisciplineGroup { get; set; }

    [Column("HREmployeeDisciplineType")]
    [StringLength(50)]
    public string HremployeeDisciplineType { get; set; }

    [Column("HREmployeeDisciplineRemark")]
    [StringLength(200)]
    public string HremployeeDisciplineRemark { get; set; }

    [Column("HREmployeeDisciplineExplain")]
    [StringLength(500)]
    public string HremployeeDisciplineExplain { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("HREmployeeDisciplineNumber")]
    public int? HremployeeDisciplineNumber { get; set; }

    [Column("FK_HRLevelID2")]
    public int? FkHrlevelId2 { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeDisciplines")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdisciplineId")]
    [InverseProperty("HremployeeDisciplines")]
    public virtual Hrdiscipline FkHrdiscipline { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeDisciplineFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeId2")]
    [InverseProperty("HremployeeDisciplineFkHremployeeId2Navigations")]
    public virtual Hremployee FkHremployeeId2Navigation { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HremployeeDisciplineFkHrlevels")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("FkHrlevelId2")]
    [InverseProperty("HremployeeDisciplineFkHrlevelId2Navigations")]
    public virtual Hrlevel FkHrlevelId2Navigation { get; set; }
}
