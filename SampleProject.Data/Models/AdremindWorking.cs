using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADRemindWorkings")]
public partial class AdremindWorking
{
    [Key]
    [Column("ADRemindWorkingID")]
    public int AdremindWorkingId { get; set; }

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

    [Column("ADRemindWorkingTitle")]
    [StringLength(255)]
    public string AdremindWorkingTitle { get; set; }

    [Column("ADRemindWorkingLocation")]
    [StringLength(255)]
    public string AdremindWorkingLocation { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("ADRemindWorkingEmployeeRef")]
    [StringLength(512)]
    public string AdremindWorkingEmployeeRef { get; set; }

    [Column("ADRemindWorkingBeginDate", TypeName = "datetime")]
    public DateTime? AdremindWorkingBeginDate { get; set; }

    [Column("ADRemindWorkingBeginTime", TypeName = "datetime")]
    public DateTime? AdremindWorkingBeginTime { get; set; }

    [Column("ADRemindWorkingEndDate", TypeName = "datetime")]
    public DateTime? AdremindWorkingEndDate { get; set; }

    [Column("ADRemindWorkingEndTime", TypeName = "datetime")]
    public DateTime? AdremindWorkingEndTime { get; set; }

    [Column("ADRemindWorkingLableType")]
    [StringLength(50)]
    public string AdremindWorkingLableType { get; set; }

    [Column("ADRemindWorkingShowTimeType")]
    [StringLength(50)]
    public string AdremindWorkingShowTimeType { get; set; }

    [Column("ADRemindWorkingDate", TypeName = "datetime")]
    public DateTime? AdremindWorkingDate { get; set; }

    [Column("ADRemindWorkingTime", TypeName = "datetime")]
    public DateTime? AdremindWorkingTime { get; set; }

    [Column("ADRemindWorkingIsFullTime")]
    public bool? AdremindWorkingIsFullTime { get; set; }

    [Column("ADRemindWorkingContent", TypeName = "ntext")]
    public string AdremindWorkingContent { get; set; }

    [Column("ADRemindWorkingStatus")]
    [StringLength(50)]
    public string AdremindWorkingStatus { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AdremindWorkings")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AdremindWorkings")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AdremindWorkings")]
    public virtual Hremployee FkHremployee { get; set; }
}
