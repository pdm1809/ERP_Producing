using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeOTs")]
public partial class HremployeeOt
{
    [Key]
    [Column("HREmployeeOTID")]
    public int HremployeeOtid { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HROverTimeID")]
    public int FkHroverTimeId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("HREmployeeOTDesc")]
    [StringLength(500)]
    public string HremployeeOtdesc { get; set; }

    [Column("FK_HREmployeeID2")]
    public int? FkHremployeeId2 { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("HREmployeeOTFromDate", TypeName = "datetime")]
    public DateTime? HremployeeOtfromDate { get; set; }

    [Column("HREmployeeOTToDate", TypeName = "datetime")]
    public DateTime? HremployeeOttoDate { get; set; }

    [Column("HREmployeeOTDate", TypeName = "datetime")]
    public DateTime? HremployeeOtdate { get; set; }

    [Column("HREmployeeOTDateEnd", TypeName = "datetime")]
    public DateTime? HremployeeOtdateEnd { get; set; }

    [Column("HREmployeeOTFactor", TypeName = "decimal(18, 5)")]
    public decimal HremployeeOtfactor { get; set; }

    [Column("HREmployeeOTChecked")]
    public bool? HremployeeOtchecked { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HremployeeOts")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeOts")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HremployeeOts")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeOtFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeId2")]
    [InverseProperty("HremployeeOtFkHremployeeId2Navigations")]
    public virtual Hremployee FkHremployeeId2Navigation { get; set; }

    [ForeignKey("FkHroverTimeId")]
    [InverseProperty("HremployeeOts")]
    public virtual HroverTime FkHroverTime { get; set; }
}
